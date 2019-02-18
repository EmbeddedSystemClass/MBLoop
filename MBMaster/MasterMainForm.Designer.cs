namespace MBMaster {
  partial class MasterMainForm {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.connectBTN = new System.Windows.Forms.Button();
      this.disconnectBTN = new System.Windows.Forms.Button();
      this.addressTB = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.dataTB = new System.Windows.Forms.TextBox();
      this.readBTN = new System.Windows.Forms.Button();
      this.writeBTN = new System.Windows.Forms.Button();
      this.label3 = new System.Windows.Forms.Label();
      this.idTB = new System.Windows.Forms.TextBox();
      this.readTB = new System.Windows.Forms.TextBox();
      this.countNUD = new System.Windows.Forms.NumericUpDown();
      this.label4 = new System.Windows.Forms.Label();
      this.slaveIpTB = new System.Windows.Forms.TextBox();
      ((System.ComponentModel.ISupportInitialize)(this.countNUD)).BeginInit();
      this.SuspendLayout();
      // 
      // connectBTN
      // 
      this.connectBTN.Location = new System.Drawing.Point(40, 27);
      this.connectBTN.Name = "connectBTN";
      this.connectBTN.Size = new System.Drawing.Size(75, 23);
      this.connectBTN.TabIndex = 0;
      this.connectBTN.Text = "Connect";
      this.connectBTN.UseVisualStyleBackColor = true;
      this.connectBTN.Click += new System.EventHandler(this.connectBTN_Click);
      // 
      // disconnectBTN
      // 
      this.disconnectBTN.Location = new System.Drawing.Point(162, 27);
      this.disconnectBTN.Name = "disconnectBTN";
      this.disconnectBTN.Size = new System.Drawing.Size(75, 23);
      this.disconnectBTN.TabIndex = 1;
      this.disconnectBTN.Text = "Disconnect";
      this.disconnectBTN.UseVisualStyleBackColor = true;
      this.disconnectBTN.Click += new System.EventHandler(this.disconnectBTN_Click);
      // 
      // addressTB
      // 
      this.addressTB.Location = new System.Drawing.Point(110, 71);
      this.addressTB.Name = "addressTB";
      this.addressTB.Size = new System.Drawing.Size(100, 20);
      this.addressTB.TabIndex = 2;
      this.addressTB.Text = "200";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(37, 74);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(69, 13);
      this.label1.TabIndex = 3;
      this.label1.Text = "Start address";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(223, 74);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(30, 13);
      this.label2.TabIndex = 5;
      this.label2.Text = "Data";
      // 
      // dataTB
      // 
      this.dataTB.Location = new System.Drawing.Point(266, 71);
      this.dataTB.Name = "dataTB";
      this.dataTB.Size = new System.Drawing.Size(402, 20);
      this.dataTB.TabIndex = 4;
      this.dataTB.Text = "1,2,3,4,5,6,7,8";
      // 
      // readBTN
      // 
      this.readBTN.Location = new System.Drawing.Point(230, 107);
      this.readBTN.Name = "readBTN";
      this.readBTN.Size = new System.Drawing.Size(75, 23);
      this.readBTN.TabIndex = 6;
      this.readBTN.Text = "Read";
      this.readBTN.UseVisualStyleBackColor = true;
      this.readBTN.Click += new System.EventHandler(this.readBTN_Click);
      // 
      // writeBTN
      // 
      this.writeBTN.Location = new System.Drawing.Point(126, 107);
      this.writeBTN.Name = "writeBTN";
      this.writeBTN.Size = new System.Drawing.Size(75, 23);
      this.writeBTN.TabIndex = 7;
      this.writeBTN.Text = "Write";
      this.writeBTN.UseVisualStyleBackColor = true;
      this.writeBTN.Click += new System.EventHandler(this.writeBTN_Click);
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(250, 32);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(55, 13);
      this.label3.TabIndex = 9;
      this.label3.Text = "Device ID";
      // 
      // idTB
      // 
      this.idTB.Location = new System.Drawing.Point(323, 29);
      this.idTB.Name = "idTB";
      this.idTB.Size = new System.Drawing.Size(100, 20);
      this.idTB.TabIndex = 8;
      this.idTB.Text = "10";
      // 
      // readTB
      // 
      this.readTB.Location = new System.Drawing.Point(31, 150);
      this.readTB.Name = "readTB";
      this.readTB.Size = new System.Drawing.Size(664, 20);
      this.readTB.TabIndex = 10;
      // 
      // countNUD
      // 
      this.countNUD.Location = new System.Drawing.Point(323, 107);
      this.countNUD.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
      this.countNUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.countNUD.Name = "countNUD";
      this.countNUD.Size = new System.Drawing.Size(120, 20);
      this.countNUD.TabIndex = 11;
      this.countNUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
      // 
      // label4
      // 
      this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(538, 28);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(50, 13);
      this.label4.TabIndex = 13;
      this.label4.Text = "Slave IP:";
      // 
      // slaveIpTB
      // 
      this.slaveIpTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.slaveIpTB.Location = new System.Drawing.Point(611, 25);
      this.slaveIpTB.Name = "slaveIpTB";
      this.slaveIpTB.Size = new System.Drawing.Size(100, 20);
      this.slaveIpTB.TabIndex = 12;
      this.slaveIpTB.Text = "192.168.1.11";
      // 
      // MasterMainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(723, 251);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.slaveIpTB);
      this.Controls.Add(this.countNUD);
      this.Controls.Add(this.readTB);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.idTB);
      this.Controls.Add(this.writeBTN);
      this.Controls.Add(this.readBTN);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.dataTB);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.addressTB);
      this.Controls.Add(this.disconnectBTN);
      this.Controls.Add(this.connectBTN);
      this.Name = "MasterMainForm";
      this.Text = "Form1";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
      this.Load += new System.EventHandler(this.MainForm_Load);
      ((System.ComponentModel.ISupportInitialize)(this.countNUD)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button connectBTN;
    private System.Windows.Forms.Button disconnectBTN;
    private System.Windows.Forms.TextBox addressTB;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox dataTB;
    private System.Windows.Forms.Button readBTN;
    private System.Windows.Forms.Button writeBTN;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox idTB;
    private System.Windows.Forms.TextBox readTB;
    private System.Windows.Forms.NumericUpDown countNUD;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox slaveIpTB;
  }
}

