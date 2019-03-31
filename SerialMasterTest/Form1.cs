using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerialMasterTest {
  public partial class Form1 : Form {
    private PLCSerialConnector serConn = null;

    public Form1() {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e) {
      serConn = new PLCSerialConnector();
    }

    private void Form1_FormClosing(object sender, FormClosingEventArgs e) {

    }

    private void connectBTN_Click(object sender, EventArgs e) {
      string errorStr = "";
      SerialCommConfig sc = new SerialCommConfig() {
        name = "sercomm",
        addressMajor = commPortTB.Text, addressMinor = (int)baudNUD.Value, devId = (int)devidNUD.Value,
        dataBits = MBDataBitsEnum.SER_DATABITS_8, parity = MBParityEnum.SER_PARITY_NONE,
        stopBits = MBStopBitsEnum.SER_STOPBITS_1, pollDelay = 1, retryCnt = 3, timeout = 100
      };
      if (!serConn.Connect(sc, out errorStr)) {
        MessageBox.Show("Error: " + errorStr);
        return;
      }
    }

    private void disconnectBTN_Click(object sender, EventArgs e) {
      serConn.Disconnect();
    }

    private void writeBTN_Click(object sender, EventArgs e) {
      int address = (int)addressNUD.Value;
      try {
        short[] data = new short[] { (short)(int)inputNUD.Value };
        bool res = serConn.WriteRegisters(address, data.Length, data);
      } catch (Exception ex) {
        System.Diagnostics.Debug.WriteLine($"Write failed: {ex.Message}");
      }
      System.Diagnostics.Debug.WriteLine("Write OK");
    }

    private void readBTN_Click(object sender, EventArgs e) {
      int address = (int)addressNUD.Value;
      Stopwatch sw = new Stopwatch();
      int loops = 1;
      short[] data = null;
      try {
        data = new short[3];
        bool res = true;
        sw.Start();
        for (int idx = 0; idx < loops; idx++)
          res = serConn.ReadRegisters(address, data.Length, data);
        sw.Stop();
      } catch (Exception ex) {
        outputLBL.Text = $"Write failed: {ex.Message}";
        return;
      }
      byte[] bts = new byte[4];
      byte[] bts0 = BitConverter.GetBytes(data[0]);
      byte[] bts1 = BitConverter.GetBytes(data[1]);
      byte[] ordBts = new byte[] { bts1[0], bts1[1], bts0[0], bts0[1] };
      int ang1000 = BitConverter.ToInt32(ordBts, 0);
      double temprat = data[2] / 100.0;
      double rtm = sw.ElapsedMilliseconds * 1.0 / loops;
      outputLBL.Text = $"Inc: {ang1000 / 1000.0}, Temp: {temprat}, Read time: {rtm}";
    }

    private void incTestTMR_Tick(object sender, EventArgs e) {
      int address = (int)addressNUD.Value;
      incTestCount++;
      if (incTestCount <= 500) {
        short[] data = new short[3];
        bool res = serConn.ReadRegisters(address, data.Length, data);
        byte[] bts = new byte[4];
        byte[] bts0 = BitConverter.GetBytes(data[0]);
        byte[] bts1 = BitConverter.GetBytes(data[1]);
        byte[] ordBts = new byte[] { bts1[0], bts1[1], bts0[0], bts0[1] };
        int ang1000 = BitConverter.ToInt32(ordBts, 0);
        double temprat = data[2] / 100.0;
        itsw.WriteLine($"{ang1000}, {temprat}");
        outputLBL.Text = $"Inc test run: {incTestCount}, Angle: {ang1000}";
      } else {
        incTestTMR.Enabled = false;
        itsw.Flush();
        itsw.Close();
        MessageBox.Show("Finished");
        incTestCHB.Checked = false;
      }
    }


    private StreamWriter itsw = null;
    private int incTestCount = 0;
    private void incTestCHB_CheckedChanged(object sender, EventArgs e) {
      CheckBox chb = sender as CheckBox; ;
      if (chb.Checked) { // checked ON
        itsw = new StreamWriter("Inctest.csv");
        incTestCount = 0;
        incTestTMR.Interval = 250;
        incTestTMR.Enabled = true;
      }
    }
  }
}
