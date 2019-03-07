using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;
using System.Threading;
using System.Runtime.InteropServices;

namespace ModbusScanner {
  public partial class Form1 : Form {
    private bool isScanning = false;
    private bool isConnected = false;
    private Task scanTask;
    private PLCSerialConnector serConn = null;
    private List<String> valueList = new List<string>();
    private int currentValue=0;
    public Form1() {
      InitializeComponent();


    }

    private void Form1_Load(object sender, EventArgs e) {

    }

    private void Form1_FormClosing(object sender, FormClosingEventArgs e) {

    }





    //private void writeBTN_Click(object sender, EventArgs e) {
    //  int address = (int)addressNUD.Value;
    //  try {
    //    short[] data = new short[] { (short)(int)inputNUD.Value };
    //    bool res = serConn.WriteRegisters(address, data.Length, data);
    //  } catch (Exception ex) {
    //    System.Diagnostics.Debug.WriteLine($"Write failed: {ex.Message}");
    //  }
    //  System.Diagnostics.Debug.WriteLine("Write OK");
    //}

    //private void readBTN_Click(object sender, EventArgs e) {
    //  int address = (int)addressNUD.Value;

    //  byte[] bts = new byte[4];
    //  byte[] bts0 = BitConverter.GetBytes(data[0]);
    //  byte[] bts1 = BitConverter.GetBytes(data[1]);

    //  bts[0] = bts0[0];
    //  bts[1] = bts0[1];
    //  bts[2] = bts1[0];
    //  bts[3] = bts1[1];

    //  int ang1000 = BitConverter.ToInt32(bts, 0);
    //  double temprat = data[2] / 100.0;
    //  double rtm = sw.ElapsedMilliseconds * 1.0 / loops;
    //  outputLBL.Text = $"Inc: {ang1000 / 1000.0}, Temp: {temprat}, Read time: {rtm}";
    //}

    private void label1_Click(object sender, EventArgs e) {

    }

    private void startScanBTN_Click(object sender, EventArgs e) {
      isScanning = true;
      valueList.Clear();
      StartAutomationInterface();
      Thread.Sleep(200);
      scanTask = Task.Factory.StartNew(() => ScanLoop());

    }
    private void StartAutomationInterface()
      {
      short code = 0x2000;
      
      short[] sData = new short[] { (short)(int)code };
      bool sRes = serConn.WriteRegisters(101, sData.Length, sData);
      if (sRes == true)System.Diagnostics.Debug.WriteLine("Auto OK");
          else System.Diagnostics.Debug.WriteLine("Auto Not OK");

    }
    private void ScanLoop() {
      
      int addr = (int)addrNUD.Value;
      int lowRange = Convert.ToInt32(valueRangeLowTB.Text,16);
      int highRange = Convert.ToInt32(valueRangeHighTB.Text,16);
      try {
        for (int i =lowRange; i <= highRange && isScanning; i++) {
        
         currentValue=i;
          short[] sData = new short[] { (short)(int)i };
          bool sRes = serConn.WriteRegisters(addr, sData.Length, sData);
          Thread.Sleep(200);
          Stopwatch sw = new Stopwatch();
          //int loops = 100;
          short[] rData = null;
          try {
            rData = new short[2];
            bool rRes = true;
            sw.Start();
            // for (int idx = 0; idx < loops; idx++)
            rRes = serConn.ReadInputRegisters(addr, 1, rData);
            System.Diagnostics.Debug.WriteLine(rRes);
            sw.Stop();
            if (sData[0] == rData[0]) {
              valueList.Add(sData[0].ToString("X"));
            }
          } catch (Exception ex) {
           // outputLBL.Text = $"Write failed: {ex.Message}";
            StopScan();
            return;
          }
        }
        StopScan();
      } catch (Exception ex) {
        System.Diagnostics.Debug.WriteLine($"Write failed: {ex.Message}");
        StopScan();
      }
      System.Diagnostics.Debug.WriteLine("Write OK");
    }





    private void stopScanBTN_Click(object sender, EventArgs e) {
      StopScan();
    }
    private void StopScan() {
      isScanning = false;
      isScanningLBL.Text = "Stopped";
    }
    private void resetListBoxBTN_Click(object sender, EventArgs e) {
      valueList.Clear();
    }

    private void connectBTN_Click_1(object sender, EventArgs e) {
      serConn = new PLCSerialConnector();
      string errorStr = "";
      SerialCommConfig sc = new SerialCommConfig() {
        name = "sercomm",
        addressMajor = comPortTB.Text, addressMinor = (int)baudRateNUD.Value, devId = (int)devIDNUD.Value,
        dataBits = MBDataBitsEnum.SER_DATABITS_8, parity = MBParityEnum.SER_PARITY_NONE,
        stopBits = MBStopBitsEnum.SER_STOPBITS_1, pollDelay = 3, retryCnt = 3, timeout = 100
      };
      if (!serConn.Connect(sc, out errorStr)) {
        MessageBox.Show("Error: " + errorStr);
        return;
      }
      isConnected = true;
    }

    private void disconnectBTN_Click(object sender, EventArgs e) {
      serConn.Disconnect();
      isConnected = false;
      serConn = null;
    }

    private void comPortTB_TextChanged(object sender, EventArgs e) {

    }

    private void valueRangeLowNUD_ValueChanged(object sender, EventArgs e) {

    }

    private void timer1_Tick(object sender, EventArgs e) {
      CurrentValueLBL.Text = "0x"+currentValue.ToString("X");
      if (isScanning)
        isScanningLBL.Text = "Scanning";
      else
        isScanningLBL.Text = "Stopped";

      if (isConnected)
        connectionStatusLBL.Text = "Connected";
      else
        connectionStatusLBL.Text = "Disconnected";
      if(valueList.Count!=validValuesLV.Items.Count){
        validValuesLV.Items.Clear();
      foreach (string str in valueList){
        validValuesLV.Items.Add(str);
      }
      }
    }

    private void button1_Click(object sender, EventArgs e) {
      int i =5;
      validValuesLV.Items.Add(i.ToString());
    }
  }
}

