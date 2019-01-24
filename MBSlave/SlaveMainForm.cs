using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using FieldTalk.Modbus.Slave;

namespace MBSlave {
  public partial class SlaveMainForm : Form {
    MbusTcpSlaveProtocol protocol;
    private Task serverThread = null;
    private bool bContinue;
    private DataTable dt;

    public SlaveMainForm() {
      InitializeComponent();
      dt = new DataTable();
      dt.OnLog += new DataTable.LogDelegate(this.Log);
      protocol = new MbusTcpSlaveProtocol();
      protocol.addDataTable(10, dt);
    }

    private void MainForm_Load(object sender, EventArgs e) {
      bContinue = true;
      protocol.startupServer();
      serverThread = new Task(ServerLoop);
      serverThread.Start();
      Log($"Server started = {protocol.isStarted()}");
    }

    private void MainForm_FormClosing(object sender, FormClosingEventArgs e) {
      protocol.shutdownServer();
      bContinue = false;
      serverThread.Wait(1000);
      dt.OnLog -= this.Log;
    }

    private void Log(string msg) {
      if (this.InvokeRequired) {
        string newMsg = (string)msg.Clone();
        //this.BeginInvoke(new Action<string> (this.Log), newMsg);
        DataTable.LogDelegate del = new DataTable.LogDelegate(this.Log);
        this.BeginInvoke(del, newMsg);
        return;
      }
      msgsLB.Items.Insert(0, msg);
      while (msgsLB.Items.Count > 1000)
        msgsLB.Items.RemoveAt(1000);
    }

    void ServerLoop() {
      int result;
      do {
        result = protocol.serverLoop();
      } while (bContinue && result == BusProtocolErrors.FTALK_SUCCESS);
    }
  }
}
