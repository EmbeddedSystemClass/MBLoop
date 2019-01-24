using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MBMaster.PLCConnection;

namespace MBMaster {
  public partial class MasterMainForm : Form {
    IPLCConnector masterPLC;
    private TCPCommConfig tcpCfg;

    public MasterMainForm() {
      InitializeComponent();
    }

    private void MainForm_Load(object sender, EventArgs e) {
      masterPLC = PLCConnectorFactory.GetConnector(ProtocolTypeEnum.TCP);
    }

    private void MainForm_FormClosing(object sender, FormClosingEventArgs e) {
      masterPLC?.Disconnect();
    }

    private void connectBTN_Click(object sender, EventArgs e) {
      string errorStr = "";
      int devId;
      if (!int.TryParse(idTB.Text, out devId)) {
        MessageBox.Show("Bad ID");
        return;
      }
      tcpCfg = new TCPCommConfig() { addressMajor = "127.0.0.1", addressMinor = 502, devId = devId, name = "", pollDelay = 100, retryCnt = 3, timeout = 3000 };
      if (!masterPLC.Connect(ProtocolTypeEnum.TCP, tcpCfg, out errorStr)) {
        MessageBox.Show($@"Failed connecting Master ({tcpCfg.devId}) : {errorStr}");
        return;
      }
    }

    private void disconnectBTN_Click(object sender, EventArgs e) {
      masterPLC?.Disconnect();
    }

    private void readBTN_Click(object sender, EventArgs e) {
      string addressStr = addressTB.Text;
      int address;
      if (string.IsNullOrEmpty(addressStr) || !int.TryParse(addressStr, out address)) {
        MessageBox.Show("No Address");
        return;
      }
      short[] data = null;
      try {
        data = new short[(int)countNUD.Value];
        bool res = masterPLC.ReadRegisters(address, data.Length, data);
      } catch (Exception ex) {
        readTB.Text=$"Write failed: {ex.Message}";
      }
      readTB.Text = string.Join(", ", data);
    }

    private void writeBTN_Click(object sender, EventArgs e) {
      string addressStr = addressTB.Text;
      int address;
      if (string.IsNullOrEmpty(addressStr) || !int.TryParse(addressStr, out address)) {
        MessageBox.Show("No Address");
        return;
      }
      string str = dataTB.Text;
      if (string.IsNullOrEmpty(str)) {
        MessageBox.Show("No data");
        return;
      }
      try {
        string[] parts = str.Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
        short[] data = parts.Select(x => Convert.ToInt16(x)).ToArray();
        bool res = masterPLC.WriteRegisters(address, data.Length, data);
      } catch (Exception ex) {
        System.Diagnostics.Debug.WriteLine($"Write failed: {ex.Message}");
      }
      System.Diagnostics.Debug.WriteLine("Write OK");

    }
  }
}
