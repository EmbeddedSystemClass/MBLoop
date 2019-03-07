namespace ModbusScanner {
  partial class Form1 {
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
      this.components = new System.ComponentModel.Container();
      this.DevIDLBL = new System.Windows.Forms.Label();
      this.BaudRateLBL = new System.Windows.Forms.Label();
      this.connectBTN = new System.Windows.Forms.Button();
      this.devIDNUD = new System.Windows.Forms.NumericUpDown();
      this.baudRateNUD = new System.Windows.Forms.NumericUpDown();
      this.comPortLBL = new System.Windows.Forms.Label();
      this.comPortTB = new System.Windows.Forms.TextBox();
      this.addressToScanLBL = new System.Windows.Forms.Label();
      this.addrNUD = new System.Windows.Forms.NumericUpDown();
      this.disconnectBTN = new System.Windows.Forms.Button();
      this.connectionStatusLBL = new System.Windows.Forms.Label();
      this.startScanBTN = new System.Windows.Forms.Button();
      this.stopScanBTN = new System.Windows.Forms.Button();
      this.rangeLBL = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.validValuesLBL = new System.Windows.Forms.Label();
      this.resetListBoxBTN = new System.Windows.Forms.Button();
      this.outputLBL = new System.Windows.Forms.Label();
      this.isScanningLBL = new System.Windows.Forms.Label();
      this.timer1 = new System.Windows.Forms.Timer(this.components);
      this.valueRangeLowTB = new System.Windows.Forms.TextBox();
      this.valueRangeHighTB = new System.Windows.Forms.TextBox();
      this.validValuesLV = new System.Windows.Forms.ListBox();
      this.label2 = new System.Windows.Forms.Label();
      this.CurrentValueLBL = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.devIDNUD)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.baudRateNUD)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.addrNUD)).BeginInit();
      this.SuspendLayout();
      // 
      // DevIDLBL
      // 
      this.DevIDLBL.AutoSize = true;
      this.DevIDLBL.Location = new System.Drawing.Point(12, 65);
      this.DevIDLBL.Name = "DevIDLBL";
      this.DevIDLBL.Size = new System.Drawing.Size(38, 13);
      this.DevIDLBL.TabIndex = 1;
      this.DevIDLBL.Text = "DevID";
      this.DevIDLBL.Click += new System.EventHandler(this.label1_Click);
      // 
      // BaudRateLBL
      // 
      this.BaudRateLBL.AutoSize = true;
      this.BaudRateLBL.Location = new System.Drawing.Point(12, 107);
      this.BaudRateLBL.Name = "BaudRateLBL";
      this.BaudRateLBL.Size = new System.Drawing.Size(58, 13);
      this.BaudRateLBL.TabIndex = 1;
      this.BaudRateLBL.Text = "Baud Rate";
      this.BaudRateLBL.Click += new System.EventHandler(this.label1_Click);
      // 
      // connectBTN
      // 
      this.connectBTN.Location = new System.Drawing.Point(40, 159);
      this.connectBTN.Name = "connectBTN";
      this.connectBTN.Size = new System.Drawing.Size(75, 23);
      this.connectBTN.TabIndex = 2;
      this.connectBTN.Text = "Connect";
      this.connectBTN.UseVisualStyleBackColor = true;
      this.connectBTN.Click += new System.EventHandler(this.connectBTN_Click_1);
      // 
      // devIDNUD
      // 
      this.devIDNUD.Location = new System.Drawing.Point(79, 63);
      this.devIDNUD.Name = "devIDNUD";
      this.devIDNUD.Size = new System.Drawing.Size(51, 20);
      this.devIDNUD.TabIndex = 3;
      this.devIDNUD.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
      // 
      // baudRateNUD
      // 
      this.baudRateNUD.Location = new System.Drawing.Point(79, 105);
      this.baudRateNUD.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
      this.baudRateNUD.Name = "baudRateNUD";
      this.baudRateNUD.Size = new System.Drawing.Size(99, 20);
      this.baudRateNUD.TabIndex = 3;
      this.baudRateNUD.Value = new decimal(new int[] {
            38400,
            0,
            0,
            0});
      // 
      // comPortLBL
      // 
      this.comPortLBL.AutoSize = true;
      this.comPortLBL.Location = new System.Drawing.Point(12, 25);
      this.comPortLBL.Name = "comPortLBL";
      this.comPortLBL.Size = new System.Drawing.Size(53, 13);
      this.comPortLBL.TabIndex = 1;
      this.comPortLBL.Text = "COM Port";
      this.comPortLBL.Click += new System.EventHandler(this.label1_Click);
      // 
      // comPortTB
      // 
      this.comPortTB.Location = new System.Drawing.Point(79, 22);
      this.comPortTB.Name = "comPortTB";
      this.comPortTB.Size = new System.Drawing.Size(75, 20);
      this.comPortTB.TabIndex = 4;
      this.comPortTB.Text = "COM4";
      this.comPortTB.TextChanged += new System.EventHandler(this.comPortTB_TextChanged);
      // 
      // addressToScanLBL
      // 
      this.addressToScanLBL.AutoSize = true;
      this.addressToScanLBL.Location = new System.Drawing.Point(260, 23);
      this.addressToScanLBL.Name = "addressToScanLBL";
      this.addressToScanLBL.Size = new System.Drawing.Size(85, 13);
      this.addressToScanLBL.TabIndex = 1;
      this.addressToScanLBL.Text = "Address to Scan";
      this.addressToScanLBL.Click += new System.EventHandler(this.label1_Click);
      // 
      // addrNUD
      // 
      this.addrNUD.Location = new System.Drawing.Point(363, 19);
      this.addrNUD.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
      this.addrNUD.Name = "addrNUD";
      this.addrNUD.Size = new System.Drawing.Size(63, 20);
      this.addrNUD.TabIndex = 3;
      this.addrNUD.Value = new decimal(new int[] {
            102,
            0,
            0,
            0});
      // 
      // disconnectBTN
      // 
      this.disconnectBTN.Location = new System.Drawing.Point(40, 219);
      this.disconnectBTN.Name = "disconnectBTN";
      this.disconnectBTN.Size = new System.Drawing.Size(75, 23);
      this.disconnectBTN.TabIndex = 2;
      this.disconnectBTN.Text = "Disconnect";
      this.disconnectBTN.UseVisualStyleBackColor = true;
      this.disconnectBTN.Click += new System.EventHandler(this.disconnectBTN_Click);
      // 
      // connectionStatusLBL
      // 
      this.connectionStatusLBL.AutoSize = true;
      this.connectionStatusLBL.Location = new System.Drawing.Point(37, 272);
      this.connectionStatusLBL.Name = "connectionStatusLBL";
      this.connectionStatusLBL.Size = new System.Drawing.Size(73, 13);
      this.connectionStatusLBL.TabIndex = 1;
      this.connectionStatusLBL.Text = "Disconnected";
      this.connectionStatusLBL.Click += new System.EventHandler(this.label1_Click);
      // 
      // startScanBTN
      // 
      this.startScanBTN.Location = new System.Drawing.Point(359, 65);
      this.startScanBTN.Name = "startScanBTN";
      this.startScanBTN.Size = new System.Drawing.Size(75, 23);
      this.startScanBTN.TabIndex = 2;
      this.startScanBTN.Text = "Start Scan";
      this.startScanBTN.UseVisualStyleBackColor = true;
      this.startScanBTN.Click += new System.EventHandler(this.startScanBTN_Click);
      // 
      // stopScanBTN
      // 
      this.stopScanBTN.Location = new System.Drawing.Point(469, 65);
      this.stopScanBTN.Name = "stopScanBTN";
      this.stopScanBTN.Size = new System.Drawing.Size(75, 23);
      this.stopScanBTN.TabIndex = 2;
      this.stopScanBTN.Text = "Stop Scan";
      this.stopScanBTN.UseVisualStyleBackColor = true;
      this.stopScanBTN.Click += new System.EventHandler(this.stopScanBTN_Click);
      // 
      // rangeLBL
      // 
      this.rangeLBL.AutoSize = true;
      this.rangeLBL.Location = new System.Drawing.Point(473, 22);
      this.rangeLBL.Name = "rangeLBL";
      this.rangeLBL.Size = new System.Drawing.Size(69, 13);
      this.rangeLBL.TabIndex = 1;
      this.rangeLBL.Text = "Value Range";
      this.rangeLBL.Click += new System.EventHandler(this.label1_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(619, 22);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(10, 13);
      this.label1.TabIndex = 1;
      this.label1.Text = "-";
      this.label1.Click += new System.EventHandler(this.label1_Click);
      // 
      // validValuesLBL
      // 
      this.validValuesLBL.AutoSize = true;
      this.validValuesLBL.Location = new System.Drawing.Point(297, 147);
      this.validValuesLBL.Name = "validValuesLBL";
      this.validValuesLBL.Size = new System.Drawing.Size(65, 13);
      this.validValuesLBL.TabIndex = 1;
      this.validValuesLBL.Text = "Valid Values";
      this.validValuesLBL.Click += new System.EventHandler(this.label1_Click);
      // 
      // resetListBoxBTN
      // 
      this.resetListBoxBTN.Location = new System.Drawing.Point(525, 187);
      this.resetListBoxBTN.Name = "resetListBoxBTN";
      this.resetListBoxBTN.Size = new System.Drawing.Size(75, 23);
      this.resetListBoxBTN.TabIndex = 2;
      this.resetListBoxBTN.Text = "Reset";
      this.resetListBoxBTN.UseVisualStyleBackColor = true;
      this.resetListBoxBTN.Click += new System.EventHandler(this.resetListBoxBTN_Click);
      // 
      // outputLBL
      // 
      this.outputLBL.AutoSize = true;
      this.outputLBL.Location = new System.Drawing.Point(420, 282);
      this.outputLBL.Name = "outputLBL";
      this.outputLBL.Size = new System.Drawing.Size(39, 13);
      this.outputLBL.TabIndex = 1;
      this.outputLBL.Text = "Output";
      this.outputLBL.Click += new System.EventHandler(this.label1_Click);
      // 
      // isScanningLBL
      // 
      this.isScanningLBL.AutoSize = true;
      this.isScanningLBL.Location = new System.Drawing.Point(431, 105);
      this.isScanningLBL.Name = "isScanningLBL";
      this.isScanningLBL.Size = new System.Drawing.Size(47, 13);
      this.isScanningLBL.TabIndex = 1;
      this.isScanningLBL.Text = "Stopped";
      this.isScanningLBL.Click += new System.EventHandler(this.label1_Click);
      // 
      // timer1
      // 
      this.timer1.Enabled = true;
      this.timer1.Interval = 200;
      this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
      // 
      // valueRangeLowTB
      // 
      this.valueRangeLowTB.Location = new System.Drawing.Point(554, 18);
      this.valueRangeLowTB.Name = "valueRangeLowTB";
      this.valueRangeLowTB.Size = new System.Drawing.Size(59, 20);
      this.valueRangeLowTB.TabIndex = 6;
      // 
      // valueRangeHighTB
      // 
      this.valueRangeHighTB.Location = new System.Drawing.Point(635, 18);
      this.valueRangeHighTB.Name = "valueRangeHighTB";
      this.valueRangeHighTB.Size = new System.Drawing.Size(59, 20);
      this.valueRangeHighTB.TabIndex = 6;
      // 
      // validValuesLV
      // 
      this.validValuesLV.FormattingEnabled = true;
      this.validValuesLV.Location = new System.Drawing.Point(382, 147);
      this.validValuesLV.Name = "validValuesLV";
      this.validValuesLV.Size = new System.Drawing.Size(120, 95);
      this.validValuesLV.TabIndex = 9;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(565, 105);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(74, 13);
      this.label2.TabIndex = 10;
      this.label2.Text = "Current Value:";
      // 
      // CurrentValueLBL
      // 
      this.CurrentValueLBL.AutoSize = true;
      this.CurrentValueLBL.Location = new System.Drawing.Point(645, 105);
      this.CurrentValueLBL.Name = "CurrentValueLBL";
      this.CurrentValueLBL.Size = new System.Drawing.Size(18, 13);
      this.CurrentValueLBL.TabIndex = 10;
      this.CurrentValueLBL.Text = "0x";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.CurrentValueLBL);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.validValuesLV);
      this.Controls.Add(this.valueRangeHighTB);
      this.Controls.Add(this.valueRangeLowTB);
      this.Controls.Add(this.comPortTB);
      this.Controls.Add(this.baudRateNUD);
      this.Controls.Add(this.addrNUD);
      this.Controls.Add(this.devIDNUD);
      this.Controls.Add(this.disconnectBTN);
      this.Controls.Add(this.resetListBoxBTN);
      this.Controls.Add(this.stopScanBTN);
      this.Controls.Add(this.startScanBTN);
      this.Controls.Add(this.connectBTN);
      this.Controls.Add(this.connectionStatusLBL);
      this.Controls.Add(this.BaudRateLBL);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.isScanningLBL);
      this.Controls.Add(this.rangeLBL);
      this.Controls.Add(this.outputLBL);
      this.Controls.Add(this.validValuesLBL);
      this.Controls.Add(this.addressToScanLBL);
      this.Controls.Add(this.comPortLBL);
      this.Controls.Add(this.DevIDLBL);
      this.Name = "Form1";
      this.Text = "Form1";
      ((System.ComponentModel.ISupportInitialize)(this.devIDNUD)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.baudRateNUD)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.addrNUD)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.Label DevIDLBL;
    private System.Windows.Forms.Label BaudRateLBL;
    private System.Windows.Forms.Button connectBTN;
    private System.Windows.Forms.NumericUpDown devIDNUD;
    private System.Windows.Forms.NumericUpDown baudRateNUD;
    private System.Windows.Forms.Label comPortLBL;
    private System.Windows.Forms.TextBox comPortTB;
    private System.Windows.Forms.Label addressToScanLBL;
    private System.Windows.Forms.NumericUpDown addrNUD;
    private System.Windows.Forms.Button disconnectBTN;
    private System.Windows.Forms.Label connectionStatusLBL;
    private System.Windows.Forms.Button startScanBTN;
    private System.Windows.Forms.Button stopScanBTN;
    private System.Windows.Forms.Label rangeLBL;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label validValuesLBL;
    private System.Windows.Forms.Button resetListBoxBTN;
    private System.Windows.Forms.Label outputLBL;
    private System.Windows.Forms.Label isScanningLBL;
    private System.Windows.Forms.Timer timer1;
    private System.Windows.Forms.TextBox valueRangeLowTB;
    private System.Windows.Forms.TextBox valueRangeHighTB;
    private System.Windows.Forms.ListBox validValuesLV;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label CurrentValueLBL;
  }
}

