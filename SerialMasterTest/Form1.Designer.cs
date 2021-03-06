﻿using System.Collections.Generic;
using System.Windows.Forms;

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
      this.components = new System.ComponentModel.Container();
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
      this.incTestTMR = new System.Windows.Forms.Timer(this.components);
      this.incTestCHB = new System.Windows.Forms.CheckBox();
      this.testObjCB = new System.Windows.Forms.ComboBox();
      this.label4 = new System.Windows.Forms.Label();
      this.countNUD = new System.Windows.Forms.NumericUpDown();
      this.mackENBTN = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.baudNUD)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.devidNUD)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.inputNUD)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.addressNUD)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.countNUD)).BeginInit();
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
            1,
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
      this.inputNUD.Location = new System.Drawing.Point(420, 119);
      this.inputNUD.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
      this.inputNUD.Minimum = new decimal(new int[] {
            10000000,
            0,
            0,
            -2147483648});
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
      this.addressNUD.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
      this.addressNUD.Name = "addressNUD";
      this.addressNUD.Size = new System.Drawing.Size(90, 20);
      this.addressNUD.TabIndex = 12;
      this.addressNUD.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
      // 
      // incTestTMR
      // 
      this.incTestTMR.Tick += new System.EventHandler(this.incTestTMR_Tick);
      // 
      // incTestCHB
      // 
      this.incTestCHB.AutoSize = true;
      this.incTestCHB.Location = new System.Drawing.Point(29, 223);
      this.incTestCHB.Name = "incTestCHB";
      this.incTestCHB.Size = new System.Drawing.Size(112, 17);
      this.incTestCHB.TabIndex = 13;
      this.incTestCHB.Text = "Inclinometer tester";
      this.incTestCHB.UseVisualStyleBackColor = true;
      this.incTestCHB.CheckedChanged += new System.EventHandler(this.incTestCHB_CheckedChanged);
      // 
      // testObjCB
      // 
      this.testObjCB.FormattingEnabled = true;
      this.testObjCB.Location = new System.Drawing.Point(608, 118);
      this.testObjCB.Name = "testObjCB";
      this.testObjCB.Size = new System.Drawing.Size(121, 21);
      this.testObjCB.TabIndex = 14;
      this.testObjCB.SelectedIndexChanged += new System.EventHandler(this.TestObjCB_SelectedIndexChanged);
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(541, 121);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(63, 13);
      this.label4.TabIndex = 15;
      this.label4.Text = "Test object:";
      // 
      // countNUD
      // 
      this.countNUD.Location = new System.Drawing.Point(269, 119);
      this.countNUD.Name = "countNUD";
      this.countNUD.Size = new System.Drawing.Size(90, 20);
      this.countNUD.TabIndex = 16;
      this.countNUD.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
      // 
      // mackENBTN
      // 
      this.mackENBTN.BackColor = System.Drawing.Color.LightSalmon;
      this.mackENBTN.Enabled = false;
      this.mackENBTN.Location = new System.Drawing.Point(157, 179);
      this.mackENBTN.Name = "mackENBTN";
      this.mackENBTN.Size = new System.Drawing.Size(75, 23);
      this.mackENBTN.TabIndex = 17;
      this.mackENBTN.Text = "Run feeder";
      this.mackENBTN.UseVisualStyleBackColor = false;
      this.mackENBTN.Click += new System.EventHandler(this.MackENBTN_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(775, 266);
      this.Controls.Add(this.mackENBTN);
      this.Controls.Add(this.countNUD);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.testObjCB);
      this.Controls.Add(this.incTestCHB);
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
      ((System.ComponentModel.ISupportInitialize)(this.countNUD)).EndInit();
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
    private System.Windows.Forms.Timer incTestTMR;
    private System.Windows.Forms.CheckBox incTestCHB;
    private System.Windows.Forms.ComboBox testObjCB;
    private System.Windows.Forms.Label label4;
    private NumericUpDown countNUD;
    private Button mackENBTN;
  }
}

