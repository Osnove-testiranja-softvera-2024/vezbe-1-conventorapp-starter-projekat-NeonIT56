﻿namespace OTS2023_ConventorApp
{
    partial class Form1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.radioMass = new System.Windows.Forms.RadioButton();
            this.radioLength = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioCustom = new System.Windows.Forms.RadioButton();
            this.radioTime = new System.Windows.Forms.RadioButton();
            this.radioMoney = new System.Windows.Forms.RadioButton();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupTimeOutput = new System.Windows.Forms.GroupBox();
            this.radioSeconds = new System.Windows.Forms.RadioButton();
            this.radioMinutes = new System.Windows.Forms.RadioButton();
            this.radioHours = new System.Windows.Forms.RadioButton();
            this.groupSegmentType = new System.Windows.Forms.GroupBox();
            this.radioArray = new System.Windows.Forms.RadioButton();
            this.radioSingle = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupTimeOutput.SuspendLayout();
            this.groupSegmentType.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(265, 167);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(140, 20);
            this.textBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(167, 250);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Convert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonConvert_Click);
            // 
            // radioMass
            // 
            this.radioMass.AutoSize = true;
            this.radioMass.Checked = true;
            this.radioMass.Location = new System.Drawing.Point(17, 19);
            this.radioMass.Name = "radioMass";
            this.radioMass.Size = new System.Drawing.Size(50, 17);
            this.radioMass.TabIndex = 2;
            this.radioMass.TabStop = true;
            this.radioMass.Text = "Mass";
            this.radioMass.UseVisualStyleBackColor = true;
            this.radioMass.CheckedChanged += new System.EventHandler(this.radioMass_CheckedChanged);
            // 
            // radioLength
            // 
            this.radioLength.AutoSize = true;
            this.radioLength.Location = new System.Drawing.Point(17, 43);
            this.radioLength.Name = "radioLength";
            this.radioLength.Size = new System.Drawing.Size(58, 17);
            this.radioLength.TabIndex = 3;
            this.radioLength.TabStop = true;
            this.radioLength.Text = "Length";
            this.radioLength.UseVisualStyleBackColor = true;
            this.radioLength.CheckedChanged += new System.EventHandler(this.radioLength_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(164, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "label2";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioCustom);
            this.groupBox1.Controls.Add(this.radioTime);
            this.groupBox1.Controls.Add(this.radioMoney);
            this.groupBox1.Controls.Add(this.radioMass);
            this.groupBox1.Controls.Add(this.radioLength);
            this.groupBox1.Location = new System.Drawing.Point(49, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 99);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Converter Type";
            // 
            // radioCustom
            // 
            this.radioCustom.AutoSize = true;
            this.radioCustom.Location = new System.Drawing.Point(35, 67);
            this.radioCustom.Name = "radioCustom";
            this.radioCustom.Size = new System.Drawing.Size(94, 17);
            this.radioCustom.TabIndex = 6;
            this.radioCustom.TabStop = true;
            this.radioCustom.Text = "Custom money";
            this.radioCustom.UseVisualStyleBackColor = true;
            this.radioCustom.CheckedChanged += new System.EventHandler(this.radioCustom_CheckedChanged);
            // 
            // radioTime
            // 
            this.radioTime.AutoSize = true;
            this.radioTime.Location = new System.Drawing.Point(94, 43);
            this.radioTime.Name = "radioTime";
            this.radioTime.Size = new System.Drawing.Size(48, 17);
            this.radioTime.TabIndex = 5;
            this.radioTime.TabStop = true;
            this.radioTime.Text = "Time";
            this.radioTime.UseVisualStyleBackColor = true;
            this.radioTime.CheckedChanged += new System.EventHandler(this.radioTime_CheckedChanged);
            // 
            // radioMoney
            // 
            this.radioMoney.AutoSize = true;
            this.radioMoney.Location = new System.Drawing.Point(94, 19);
            this.radioMoney.Name = "radioMoney";
            this.radioMoney.Size = new System.Drawing.Size(57, 17);
            this.radioMoney.TabIndex = 4;
            this.radioMoney.TabStop = true;
            this.radioMoney.Text = "Money";
            this.radioMoney.UseVisualStyleBackColor = true;
            this.radioMoney.CheckedChanged += new System.EventHandler(this.radioMoney_CheckedChanged);
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(265, 207);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(140, 20);
            this.textBox2.TabIndex = 7;
            // 
            // groupTimeOutput
            // 
            this.groupTimeOutput.Controls.Add(this.radioSeconds);
            this.groupTimeOutput.Controls.Add(this.radioMinutes);
            this.groupTimeOutput.Controls.Add(this.radioHours);
            this.groupTimeOutput.Location = new System.Drawing.Point(265, 34);
            this.groupTimeOutput.Name = "groupTimeOutput";
            this.groupTimeOutput.Size = new System.Drawing.Size(200, 100);
            this.groupTimeOutput.TabIndex = 9;
            this.groupTimeOutput.TabStop = false;
            this.groupTimeOutput.Text = "Time output";
            this.groupTimeOutput.Visible = false;
            // 
            // radioSeconds
            // 
            this.radioSeconds.AutoSize = true;
            this.radioSeconds.Location = new System.Drawing.Point(26, 68);
            this.radioSeconds.Name = "radioSeconds";
            this.radioSeconds.Size = new System.Drawing.Size(67, 17);
            this.radioSeconds.TabIndex = 2;
            this.radioSeconds.TabStop = true;
            this.radioSeconds.Text = "Seconds";
            this.radioSeconds.UseVisualStyleBackColor = true;
            this.radioSeconds.CheckedChanged += new System.EventHandler(this.radioSeconds_CheckedChanged);
            // 
            // radioMinutes
            // 
            this.radioMinutes.AutoSize = true;
            this.radioMinutes.Location = new System.Drawing.Point(26, 44);
            this.radioMinutes.Name = "radioMinutes";
            this.radioMinutes.Size = new System.Drawing.Size(62, 17);
            this.radioMinutes.TabIndex = 1;
            this.radioMinutes.TabStop = true;
            this.radioMinutes.Text = "Minutes";
            this.radioMinutes.UseVisualStyleBackColor = true;
            this.radioMinutes.CheckedChanged += new System.EventHandler(this.radioMinutes_CheckedChanged);
            // 
            // radioHours
            // 
            this.radioHours.AutoSize = true;
            this.radioHours.Location = new System.Drawing.Point(26, 20);
            this.radioHours.Name = "radioHours";
            this.radioHours.Size = new System.Drawing.Size(53, 17);
            this.radioHours.TabIndex = 0;
            this.radioHours.TabStop = true;
            this.radioHours.Text = "Hours";
            this.radioHours.UseVisualStyleBackColor = true;
            this.radioHours.CheckedChanged += new System.EventHandler(this.radioHours_CheckedChanged);
            // 
            // groupSegmentType
            // 
            this.groupSegmentType.Controls.Add(this.radioArray);
            this.groupSegmentType.Controls.Add(this.radioSingle);
            this.groupSegmentType.Location = new System.Drawing.Point(480, 34);
            this.groupSegmentType.Name = "groupSegmentType";
            this.groupSegmentType.Size = new System.Drawing.Size(200, 100);
            this.groupSegmentType.TabIndex = 10;
            this.groupSegmentType.TabStop = false;
            this.groupSegmentType.Text = "Segment type";
            this.groupSegmentType.Visible = false;
            // 
            // radioArray
            // 
            this.radioArray.AutoSize = true;
            this.radioArray.Location = new System.Drawing.Point(23, 44);
            this.radioArray.Name = "radioArray";
            this.radioArray.Size = new System.Drawing.Size(95, 17);
            this.radioArray.TabIndex = 1;
            this.radioArray.TabStop = true;
            this.radioArray.Text = "Array of values";
            this.radioArray.UseVisualStyleBackColor = true;
            // 
            // radioSingle
            // 
            this.radioSingle.AutoSize = true;
            this.radioSingle.Location = new System.Drawing.Point(23, 20);
            this.radioSingle.Name = "radioSingle";
            this.radioSingle.Size = new System.Drawing.Size(83, 17);
            this.radioSingle.TabIndex = 0;
            this.radioSingle.TabStop = true;
            this.radioSingle.Text = "Single value";
            this.radioSingle.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 358);
            this.Controls.Add(this.groupSegmentType);
            this.Controls.Add(this.groupTimeOutput);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupTimeOutput.ResumeLayout(false);
            this.groupTimeOutput.PerformLayout();
            this.groupSegmentType.ResumeLayout(false);
            this.groupSegmentType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radioMass;
        private System.Windows.Forms.RadioButton radioLength;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox groupTimeOutput;
        private System.Windows.Forms.RadioButton radioSeconds;
        private System.Windows.Forms.RadioButton radioMinutes;
        private System.Windows.Forms.RadioButton radioHours;
        private System.Windows.Forms.RadioButton radioCustom;
        private System.Windows.Forms.RadioButton radioTime;
        private System.Windows.Forms.RadioButton radioMoney;
        private System.Windows.Forms.GroupBox groupSegmentType;
        private System.Windows.Forms.RadioButton radioArray;
        private System.Windows.Forms.RadioButton radioSingle;
    }
}

