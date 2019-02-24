namespace SerialMasterTest {
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
      this.label1 = new System.Windows.Forms.Label();
      this.commPortTB = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.baudNUD = new System.Windows.Forms.NumericUpDown();
      this.devidNUD = new System.Windows.Forms.NumericUpDown();
      this.label3 = new System.Windows.Forms.Label();
      this.connectBTN = new System.Windows.Forms.Button();
      this.disconnectBTN = new System.Windows.Forms.Button();
      this.inputNUD = new System.Windows.Forms.NumericUpDown();
      this.outputLBL = new System.Windows.Forms.Label();
      this.writeBTN = new System.Windows.Forms.Button();
      this.readBTN = new System.Windows.Forms.Button();
      this.addressNUD = new System.Windows.Forms.NumericUpDown();
      ((System.ComponentModel.ISupportInitialize)(this.baudNUD)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.devidNUD)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.inputNUD)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.addressNUD)).BeginInit();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(26, 22);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(56, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "COM Port:";
      // 
      // commPortTB
      // 
      this.commPortTB.Location = new System.Drawing.Point(109, 18);
      this.commPortTB.Name = "commPortTB";
      this.commPortTB.Size = new System.Drawing.Size(100, 20);
      this.commPortTB.TabIndex = 1;
      this.commPortTB.Text = "COM6";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(242, 22);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(35, 13);
      this.label2.TabIndex = 2;
      this.label2.Text = "Baud:";
      // 
      // baudNUD
      // 
      this.baudNUD.Location = new System.Drawing.Point(314, 18);
      this.baudNUD.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
      this.baudNUD.Name = "baudNUD";
      this.baudNUD.Size = new System.Drawing.Size(120, 20);
      this.baudNUD.TabIndex = 3;
      this.baudNUD.Value = new decimal(new int[] {
            38400,
            0,
            0,
            0});
      // 
      // devidNUD
      // 
      this.devidNUD.Location = new System.Drawing.Point(521, 18);
      this.devidNUD.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
      this.devidNUD.Name = "devidNUD";
      this.devidNUD.Size = new System.Drawing.Size(120, 20);
      this.devidNUD.TabIndex = 5;
      this.devidNUD.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(449, 22);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(44, 13);
      this.label3.TabIndex = 4;
      this.label3.Text = "Dev ID:";
      // 
      // connectBTN
      // 
      this.connectBTN.Location = new System.Drawing.Point(29, 60);
      this.connectBTN.Name = "connectBTN";
      this.connectBTN.Size = new System.Drawing.Size(75, 23);
      this.connectBTN.TabIndex = 6;
      this.connectBTN.Text = "Connect";
      this.connectBTN.UseVisualStyleBackColor = true;
      this.connectBTN.Click += new System.EventHandler(this.connectBTN_Click);
      // 
      // disconnectBTN
      // 
      this.disconnectBTN.Location = new System.Drawing.Point(134, 60);
      this.disconnectBTN.Name = "disconnectBTN";
      this.disconnectBTN.Size = new System.Drawing.Size(75, 23);
      this.disconnectBTN.TabIndex = 7;
      this.disconnectBTN.Text = "Disconnect";
      this.disconnectBTN.UseVisualStyleBackColor = true;
      this.disconnectBTN.Click += new System.EventHandler(this.disconnectBTN_Click);
      // 
      // inputNUD
      // 
      this.inputNUD.Enabled = false;
      this.inputNUD.Location = new System.Drawing.Point(267, 119);
      this.inputNUD.Name = "inputNUD";
      this.inputNUD.Size = new System.Drawing.Size(90, 20);
      this.inputNUD.TabIndex = 8;
      // 
      // outputLBL
      // 
      this.outputLBL.BackColor = System.Drawing.SystemColors.InactiveCaption;
      this.outputLBL.Location = new System.Drawing.Point(154, 154);
      this.outputLBL.Name = "outputLBL";
      this.outputLBL.Size = new System.Drawing.Size(521, 16);
      this.outputLBL.TabIndex = 9;
      this.outputLBL.Text = "label4";
      this.outputLBL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // writeBTN
      // 
      this.writeBTN.Enabled = false;
      this.writeBTN.Location = new System.Drawing.Point(41, 116);
      this.writeBTN.Name = "writeBTN";
      this.writeBTN.Size = new System.Drawing.Size(75, 23);
      this.writeBTN.TabIndex = 10;
      this.writeBTN.Text = "Write";
      this.writeBTN.UseVisualStyleBackColor = true;
      this.writeBTN.Click += new System.EventHandler(this.writeBTN_Click);
      // 
      // readBTN
      // 
      this.readBTN.Location = new System.Drawing.Point(44, 150);
      this.readBTN.Name = "readBTN";
      this.readBTN.Size = new System.Drawing.Size(75, 23);
      this.readBTN.TabIndex = 11;
      this.readBTN.Text = "Read";
      this.readBTN.UseVisualStyleBackColor = true;
      this.readBTN.Click += new System.EventHandler(this.readBTN_Click);
      // 
      // addressNUD
      // 
      this.addressNUD.Location = new System.Drawing.Point(157, 119);
      this.addressNUD.Name = "addressNUD";
      this.addressNUD.Size = new System.Drawing.Size(90, 20);
      this.addressNUD.TabIndex = 12;
      this.addressNUD.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.addressNUD);
      this.Controls.Add(this.readBTN);
      this.Controls.Add(this.writeBTN);
      this.Controls.Add(this.outputLBL);
      this.Controls.Add(this.inputNUD);
      this.Controls.Add(this.disconnectBTN);
      this.Controls.Add(this.connectBTN);
      this.Controls.Add(this.devidNUD);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.baudNUD);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.commPortTB);
      this.Controls.Add(this.label1);
      this.Name = "Form1";
      this.Text = "Form1";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
      this.Load += new System.EventHandler(this.Form1_Load);
      ((System.ComponentModel.ISupportInitialize)(this.baudNUD)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.devidNUD)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.inputNUD)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.addressNUD)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox commPortTB;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.NumericUpDown baudNUD;
    private System.Windows.Forms.NumericUpDown devidNUD;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Button connectBTN;
    private System.Windows.Forms.Button disconnectBTN;
    private System.Windows.Forms.NumericUpDown inputNUD;
    private System.Windows.Forms.Label outputLBL;
    private System.Windows.Forms.Button writeBTN;
    private System.Windows.Forms.Button readBTN;
    private System.Windows.Forms.NumericUpDown addressNUD;
  }
}

