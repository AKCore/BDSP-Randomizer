﻿
namespace BDSP_Randomizer
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnRandomize = new DarkUI.Controls.DarkButton();
            this.btnLoadSettings = new DarkUI.Controls.DarkButton();
            this.cbEncounters = new DarkUI.Controls.DarkCheckBox();
            this.cbTrainers = new DarkUI.Controls.DarkCheckBox();
            this.cbTMs = new DarkUI.Controls.DarkCheckBox();
            this.cbAbilities = new DarkUI.Controls.DarkCheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbLog = new DarkUI.Controls.DarkTextBox();
            this.cbEncLevel = new DarkUI.Controls.DarkCheckBox();
            this.rbDiamond = new DarkUI.Controls.DarkRadioButton();
            this.rbPearl = new DarkUI.Controls.DarkRadioButton();
            this.darkGroupBox1 = new DarkUI.Controls.DarkGroupBox();
            this.darkGroupBox2 = new DarkUI.Controls.DarkGroupBox();
            this.darkGroupBox3 = new DarkUI.Controls.DarkGroupBox();
            this.darkLabel2 = new DarkUI.Controls.DarkLabel();
            this.numMaxLevel = new DarkUI.Controls.DarkNumericUpDown();
            this.darkLabel1 = new DarkUI.Controls.DarkLabel();
            this.numMinLevel = new DarkUI.Controls.DarkNumericUpDown();
            this.darkLabel3 = new DarkUI.Controls.DarkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.darkGroupBox1.SuspendLayout();
            this.darkGroupBox2.SuspendLayout();
            this.darkGroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinLevel)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRandomize
            // 
            this.btnRandomize.Checked = false;
            this.btnRandomize.Location = new System.Drawing.Point(602, 406);
            this.btnRandomize.Name = "btnRandomize";
            this.btnRandomize.Size = new System.Drawing.Size(186, 32);
            this.btnRandomize.TabIndex = 2;
            this.btnRandomize.Text = "Randomize!";
            this.btnRandomize.Click += new System.EventHandler(this.btnRandomize_Click);
            // 
            // btnLoadSettings
            // 
            this.btnLoadSettings.Checked = false;
            this.btnLoadSettings.Location = new System.Drawing.Point(602, 368);
            this.btnLoadSettings.Name = "btnLoadSettings";
            this.btnLoadSettings.Size = new System.Drawing.Size(186, 32);
            this.btnLoadSettings.TabIndex = 3;
            this.btnLoadSettings.Text = "Load gamesettings";
            this.btnLoadSettings.Click += new System.EventHandler(this.btnLoadSettings_Click);
            // 
            // cbEncounters
            // 
            this.cbEncounters.AutoSize = true;
            this.cbEncounters.Location = new System.Drawing.Point(18, 25);
            this.cbEncounters.Name = "cbEncounters";
            this.cbEncounters.Size = new System.Drawing.Size(136, 17);
            this.cbEncounters.TabIndex = 5;
            this.cbEncounters.Text = "Randomize Encounters";
            // 
            // cbTrainers
            // 
            this.cbTrainers.AutoSize = true;
            this.cbTrainers.Enabled = false;
            this.cbTrainers.Location = new System.Drawing.Point(18, 71);
            this.cbTrainers.Name = "cbTrainers";
            this.cbTrainers.Size = new System.Drawing.Size(120, 17);
            this.cbTrainers.TabIndex = 6;
            this.cbTrainers.Text = "Randomize Trainers";
            this.cbTrainers.Visible = false;
            // 
            // cbTMs
            // 
            this.cbTMs.AutoSize = true;
            this.cbTMs.Enabled = false;
            this.cbTMs.Location = new System.Drawing.Point(18, 94);
            this.cbTMs.Name = "cbTMs";
            this.cbTMs.Size = new System.Drawing.Size(103, 17);
            this.cbTMs.TabIndex = 7;
            this.cbTMs.Text = "Randomize TMs";
            this.cbTMs.Visible = false;
            // 
            // cbAbilities
            // 
            this.cbAbilities.AutoSize = true;
            this.cbAbilities.Enabled = false;
            this.cbAbilities.Location = new System.Drawing.Point(18, 117);
            this.cbAbilities.Name = "cbAbilities";
            this.cbAbilities.Size = new System.Drawing.Size(117, 17);
            this.cbAbilities.TabIndex = 8;
            this.cbAbilities.Text = "Randomize Abilities";
            this.cbAbilities.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BDSP_Randomizer.Properties.Resources.Pokemon_Brilliant_Diamond_Shining_Pearl;
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(583, 236);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // tbLog
            // 
            this.tbLog.Location = new System.Drawing.Point(11, 255);
            this.tbLog.Multiline = true;
            this.tbLog.Name = "tbLog";
            this.tbLog.ReadOnly = true;
            this.tbLog.Size = new System.Drawing.Size(585, 183);
            this.tbLog.TabIndex = 10;
            // 
            // cbEncLevel
            // 
            this.cbEncLevel.AutoSize = true;
            this.cbEncLevel.Location = new System.Drawing.Point(18, 48);
            this.cbEncLevel.Name = "cbEncLevel";
            this.cbEncLevel.Size = new System.Drawing.Size(135, 17);
            this.cbEncLevel.TabIndex = 11;
            this.cbEncLevel.Text = "Randomize Enc Levels";
            // 
            // rbDiamond
            // 
            this.rbDiamond.AutoSize = true;
            this.rbDiamond.Checked = true;
            this.rbDiamond.Location = new System.Drawing.Point(18, 19);
            this.rbDiamond.Name = "rbDiamond";
            this.rbDiamond.Size = new System.Drawing.Size(67, 17);
            this.rbDiamond.TabIndex = 12;
            this.rbDiamond.TabStop = true;
            this.rbDiamond.Text = "Diamond";
            // 
            // rbPearl
            // 
            this.rbPearl.AutoSize = true;
            this.rbPearl.Location = new System.Drawing.Point(105, 19);
            this.rbPearl.Name = "rbPearl";
            this.rbPearl.Size = new System.Drawing.Size(49, 17);
            this.rbPearl.TabIndex = 13;
            this.rbPearl.Text = "Pearl";
            // 
            // darkGroupBox1
            // 
            this.darkGroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.darkGroupBox1.Controls.Add(this.cbAbilities);
            this.darkGroupBox1.Controls.Add(this.cbEncounters);
            this.darkGroupBox1.Controls.Add(this.cbTrainers);
            this.darkGroupBox1.Controls.Add(this.cbEncLevel);
            this.darkGroupBox1.Controls.Add(this.cbTMs);
            this.darkGroupBox1.Location = new System.Drawing.Point(602, 109);
            this.darkGroupBox1.Name = "darkGroupBox1";
            this.darkGroupBox1.Size = new System.Drawing.Size(185, 140);
            this.darkGroupBox1.TabIndex = 14;
            this.darkGroupBox1.TabStop = false;
            this.darkGroupBox1.Text = "Randomize Options";
            // 
            // darkGroupBox2
            // 
            this.darkGroupBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.darkGroupBox2.Controls.Add(this.darkLabel3);
            this.darkGroupBox2.Controls.Add(this.rbPearl);
            this.darkGroupBox2.Controls.Add(this.rbDiamond);
            this.darkGroupBox2.Location = new System.Drawing.Point(602, 13);
            this.darkGroupBox2.Name = "darkGroupBox2";
            this.darkGroupBox2.Size = new System.Drawing.Size(184, 90);
            this.darkGroupBox2.TabIndex = 15;
            this.darkGroupBox2.TabStop = false;
            this.darkGroupBox2.Text = "Your Pokemon Version";
            // 
            // darkGroupBox3
            // 
            this.darkGroupBox3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.darkGroupBox3.Controls.Add(this.darkLabel2);
            this.darkGroupBox3.Controls.Add(this.numMaxLevel);
            this.darkGroupBox3.Controls.Add(this.darkLabel1);
            this.darkGroupBox3.Controls.Add(this.numMinLevel);
            this.darkGroupBox3.Location = new System.Drawing.Point(603, 255);
            this.darkGroupBox3.Name = "darkGroupBox3";
            this.darkGroupBox3.Size = new System.Drawing.Size(185, 107);
            this.darkGroupBox3.TabIndex = 15;
            this.darkGroupBox3.TabStop = false;
            this.darkGroupBox3.Text = "Level Options";
            // 
            // darkLabel2
            // 
            this.darkLabel2.AutoSize = true;
            this.darkLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel2.Location = new System.Drawing.Point(14, 59);
            this.darkLabel2.Name = "darkLabel2";
            this.darkLabel2.Size = new System.Drawing.Size(56, 13);
            this.darkLabel2.TabIndex = 3;
            this.darkLabel2.Text = "Max Level";
            // 
            // numMaxLevel
            // 
            this.numMaxLevel.Location = new System.Drawing.Point(17, 75);
            this.numMaxLevel.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numMaxLevel.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numMaxLevel.Name = "numMaxLevel";
            this.numMaxLevel.Size = new System.Drawing.Size(120, 20);
            this.numMaxLevel.TabIndex = 2;
            this.numMaxLevel.Value = new decimal(new int[] {
            99,
            0,
            0,
            0});
            // 
            // darkLabel1
            // 
            this.darkLabel1.AutoSize = true;
            this.darkLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel1.Location = new System.Drawing.Point(14, 20);
            this.darkLabel1.Name = "darkLabel1";
            this.darkLabel1.Size = new System.Drawing.Size(53, 13);
            this.darkLabel1.TabIndex = 1;
            this.darkLabel1.Text = "Min Level";
            // 
            // numMinLevel
            // 
            this.numMinLevel.Location = new System.Drawing.Point(17, 36);
            this.numMinLevel.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numMinLevel.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numMinLevel.Name = "numMinLevel";
            this.numMinLevel.Size = new System.Drawing.Size(120, 20);
            this.numMinLevel.TabIndex = 0;
            this.numMinLevel.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // darkLabel3
            // 
            this.darkLabel3.AutoSize = true;
            this.darkLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel3.Location = new System.Drawing.Point(6, 39);
            this.darkLabel3.Name = "darkLabel3";
            this.darkLabel3.Size = new System.Drawing.Size(171, 39);
            this.darkLabel3.TabIndex = 14;
            this.darkLabel3.Text = "I currently have no idea if\r\n_d and _p is related to which \r\nversion of pokemon d" +
    "o them both. \r\n";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.darkGroupBox3);
            this.Controls.Add(this.darkGroupBox2);
            this.Controls.Add(this.darkGroupBox1);
            this.Controls.Add(this.tbLog);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnLoadSettings);
            this.Controls.Add(this.btnRandomize);
            this.Name = "MainForm";
            this.Text = "Brilliant Diamond/Shining Pearl Randomizer";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.darkGroupBox1.ResumeLayout(false);
            this.darkGroupBox1.PerformLayout();
            this.darkGroupBox2.ResumeLayout(false);
            this.darkGroupBox2.PerformLayout();
            this.darkGroupBox3.ResumeLayout(false);
            this.darkGroupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinLevel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DarkUI.Controls.DarkButton btnRandomize;
        private DarkUI.Controls.DarkButton btnLoadSettings;
        private DarkUI.Controls.DarkCheckBox cbEncounters;
        private DarkUI.Controls.DarkCheckBox cbTrainers;
        private DarkUI.Controls.DarkCheckBox cbTMs;
        private DarkUI.Controls.DarkCheckBox cbAbilities;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DarkUI.Controls.DarkTextBox tbLog;
        private DarkUI.Controls.DarkCheckBox cbEncLevel;
        private DarkUI.Controls.DarkRadioButton rbDiamond;
        private DarkUI.Controls.DarkRadioButton rbPearl;
        private DarkUI.Controls.DarkGroupBox darkGroupBox1;
        private DarkUI.Controls.DarkGroupBox darkGroupBox2;
        private DarkUI.Controls.DarkGroupBox darkGroupBox3;
        private DarkUI.Controls.DarkLabel darkLabel1;
        private DarkUI.Controls.DarkNumericUpDown numMinLevel;
        private DarkUI.Controls.DarkLabel darkLabel2;
        private DarkUI.Controls.DarkNumericUpDown numMaxLevel;
        private DarkUI.Controls.DarkLabel darkLabel3;
    }
}
