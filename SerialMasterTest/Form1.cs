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
    private enum TestObjEnum { General, Inclinometer, FeederMack };

    private TestObjEnum currTO = TestObjEnum.Inclinometer;

    public Form1() {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e) {
      serConn = new PLCSerialConnector();
      testObjCB.Items.AddRange(Enum.GetNames(typeof(TestObjEnum)));
      testObjCB.SelectedIndex = 0;
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
        data = new short[(int)countNUD.Value];
        bool res = true;
        sw.Start();
        for (int idx = 0; idx < loops; idx++)
          res = serConn.ReadRegisters(address, data.Length, data);
        sw.Stop();
      } catch (Exception ex) {
        outputLBL.Text = $"Write failed: {ex.Message}";
        return;
      }
      if (currTO == TestObjEnum.General) {
        outputLBL.Text = $"Write OK: {string.Join(", ", data.ToList().Select(x => x.ToString()))}";
      } else if (currTO == TestObjEnum.Inclinometer) {
        byte[] bts = new byte[4];
        byte[] bts0 = BitConverter.GetBytes(data[0]);
        byte[] bts1 = BitConverter.GetBytes(data[1]);
        byte[] ordBts = new byte[] { bts1[0], bts1[1], bts0[0], bts0[1] };
        int ang1000 = BitConverter.ToInt32(ordBts, 0);
        double temprat = data[2] / 100.0;
        double rtm = sw.ElapsedMilliseconds * 1.0 / loops;
        outputLBL.Text = $"Inc: {ang1000 / 1000.0}, Temp: {temprat}, Read time: {rtm}";
      } else if (currTO == TestObjEnum.FeederMack) { 
      } else
        outputLBL.Text = "No test object defined";
    }

    private void incTestTMR_Tick(object sender, EventArgs e) {
      int address = (int)addressNUD.Value;
      incTestCount++;
      short[] data = new short[3];
      bool res = serConn.ReadRegisters(address, data.Length, data);
      byte[] bts = new byte[4];
      byte[] bts0 = BitConverter.GetBytes(data[0]);
      byte[] bts1 = BitConverter.GetBytes(data[1]);
      byte[] ordBts = new byte[] { bts1[0], bts1[1], bts0[0], bts0[1] };
      int ang1000 = BitConverter.ToInt32(ordBts, 0);
      double temprat = data[2] / 100.0;
      double ang = 0.0;
      if (ang1000 > -180000 && ang1000 < -90000) {
        ang = ang1000 / 1000.0 + 270.0;
      } else {
        ang = ang1000 / 1000.0 - 90.0;
      }
      //itsw.WriteLine($"{ang1000/1000.0 - 90.0}, {temprat}");
      outputLBL.Text = $"Inc test run: {incTestCount}, Angle: {ang}";
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
      } else {
        incTestTMR.Enabled = false;
        itsw.Flush();
        itsw.Close();
        MessageBox.Show("Finished");
      }
    }

    private void TestObjCB_SelectedIndexChanged(object sender, EventArgs e) {
      if (testObjCB.SelectedIndex >= 0)
        currTO = (TestObjEnum) testObjCB.SelectedIndex;
    }
  }
}
