﻿namespace Calculator
{
    partial class CalculatorForm
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
            this.ButtonTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.EqualButton = new System.Windows.Forms.Button();
            this.DecimalButton = new System.Windows.Forms.Button();
            this.ZeroButton = new System.Windows.Forms.Button();
            this.PlusMinusButton = new System.Windows.Forms.Button();
            this.Plusbutton = new System.Windows.Forms.Button();
            this.ThreeButton = new System.Windows.Forms.Button();
            this.TwoButton = new System.Windows.Forms.Button();
            this.OneButton = new System.Windows.Forms.Button();
            this.MinusButton = new System.Windows.Forms.Button();
            this.SixButton = new System.Windows.Forms.Button();
            this.FiveButton = new System.Windows.Forms.Button();
            this.FourButton = new System.Windows.Forms.Button();
            this.MultiplyButton = new System.Windows.Forms.Button();
            this.NineButton = new System.Windows.Forms.Button();
            this.EightButton = new System.Windows.Forms.Button();
            this.SevenButton = new System.Windows.Forms.Button();
            this.DivideButton = new System.Windows.Forms.Button();
            this.BackSpaceButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.ResultTextBox = new System.Windows.Forms.TextBox();
            this.ButtonTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonTableLayoutPanel
            // 
            this.ButtonTableLayoutPanel.ColumnCount = 4;
            this.ButtonTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonTableLayoutPanel.Controls.Add(this.EqualButton, 3, 4);
            this.ButtonTableLayoutPanel.Controls.Add(this.DecimalButton, 2, 4);
            this.ButtonTableLayoutPanel.Controls.Add(this.ZeroButton, 1, 4);
            this.ButtonTableLayoutPanel.Controls.Add(this.PlusMinusButton, 0, 4);
            this.ButtonTableLayoutPanel.Controls.Add(this.Plusbutton, 3, 3);
            this.ButtonTableLayoutPanel.Controls.Add(this.ThreeButton, 2, 3);
            this.ButtonTableLayoutPanel.Controls.Add(this.TwoButton, 1, 3);
            this.ButtonTableLayoutPanel.Controls.Add(this.OneButton, 0, 3);
            this.ButtonTableLayoutPanel.Controls.Add(this.MinusButton, 3, 2);
            this.ButtonTableLayoutPanel.Controls.Add(this.SixButton, 2, 2);
            this.ButtonTableLayoutPanel.Controls.Add(this.FiveButton, 1, 2);
            this.ButtonTableLayoutPanel.Controls.Add(this.FourButton, 0, 2);
            this.ButtonTableLayoutPanel.Controls.Add(this.MultiplyButton, 3, 1);
            this.ButtonTableLayoutPanel.Controls.Add(this.NineButton, 2, 1);
            this.ButtonTableLayoutPanel.Controls.Add(this.EightButton, 1, 1);
            this.ButtonTableLayoutPanel.Controls.Add(this.SevenButton, 0, 1);
            this.ButtonTableLayoutPanel.Controls.Add(this.DivideButton, 3, 0);
            this.ButtonTableLayoutPanel.Controls.Add(this.BackSpaceButton, 2, 0);
            this.ButtonTableLayoutPanel.Controls.Add(this.ClearButton, 0, 0);
            this.ButtonTableLayoutPanel.Location = new System.Drawing.Point(2, 140);
            this.ButtonTableLayoutPanel.Name = "ButtonTableLayoutPanel";
            this.ButtonTableLayoutPanel.RowCount = 5;
            this.ButtonTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonTableLayoutPanel.Size = new System.Drawing.Size(299, 299);
            this.ButtonTableLayoutPanel.TabIndex = 0;
            // 
            // EqualButton
            // 
            this.EqualButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.EqualButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.EqualButton.Location = new System.Drawing.Point(225, 243);
            this.EqualButton.Name = "EqualButton";
            this.EqualButton.Size = new System.Drawing.Size(71, 53);
            this.EqualButton.TabIndex = 19;
            this.EqualButton.Text = "=";
            this.EqualButton.UseVisualStyleBackColor = false;
            this.EqualButton.Click += new System.EventHandler(this.OperatorButton_Click);
            // 
            // DecimalButton
            // 
            this.DecimalButton.BackColor = System.Drawing.Color.White;
            this.DecimalButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DecimalButton.Location = new System.Drawing.Point(151, 243);
            this.DecimalButton.Name = "DecimalButton";
            this.DecimalButton.Size = new System.Drawing.Size(68, 53);
            this.DecimalButton.TabIndex = 18;
            this.DecimalButton.Text = ".";
            this.DecimalButton.UseVisualStyleBackColor = false;
            this.DecimalButton.Click += new System.EventHandler(this.CalculatorButton_Click);
            // 
            // ZeroButton
            // 
            this.ZeroButton.BackColor = System.Drawing.Color.White;
            this.ZeroButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ZeroButton.Location = new System.Drawing.Point(77, 243);
            this.ZeroButton.Name = "ZeroButton";
            this.ZeroButton.Size = new System.Drawing.Size(68, 53);
            this.ZeroButton.TabIndex = 17;
            this.ZeroButton.Text = "0";
            this.ZeroButton.UseVisualStyleBackColor = false;
            this.ZeroButton.Click += new System.EventHandler(this.CalculatorButton_Click);
            // 
            // PlusMinusButton
            // 
            this.PlusMinusButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PlusMinusButton.Location = new System.Drawing.Point(3, 243);
            this.PlusMinusButton.Name = "PlusMinusButton";
            this.PlusMinusButton.Size = new System.Drawing.Size(68, 53);
            this.PlusMinusButton.TabIndex = 16;
            this.PlusMinusButton.Text = "±";
            this.PlusMinusButton.UseVisualStyleBackColor = true;
            this.PlusMinusButton.Click += new System.EventHandler(this.OperatorButton_Click);
            // 
            // Plusbutton
            // 
            this.Plusbutton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Plusbutton.Location = new System.Drawing.Point(225, 180);
            this.Plusbutton.Name = "Plusbutton";
            this.Plusbutton.Size = new System.Drawing.Size(71, 53);
            this.Plusbutton.TabIndex = 15;
            this.Plusbutton.Text = "+";
            this.Plusbutton.UseVisualStyleBackColor = true;
            this.Plusbutton.Click += new System.EventHandler(this.OperatorButton_Click);
            // 
            // ThreeButton
            // 
            this.ThreeButton.BackColor = System.Drawing.Color.White;
            this.ThreeButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ThreeButton.Location = new System.Drawing.Point(151, 180);
            this.ThreeButton.Name = "ThreeButton";
            this.ThreeButton.Size = new System.Drawing.Size(68, 53);
            this.ThreeButton.TabIndex = 14;
            this.ThreeButton.Text = "3";
            this.ThreeButton.UseVisualStyleBackColor = false;
            this.ThreeButton.Click += new System.EventHandler(this.CalculatorButton_Click);
            // 
            // TwoButton
            // 
            this.TwoButton.BackColor = System.Drawing.Color.White;
            this.TwoButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TwoButton.Location = new System.Drawing.Point(77, 180);
            this.TwoButton.Name = "TwoButton";
            this.TwoButton.Size = new System.Drawing.Size(68, 53);
            this.TwoButton.TabIndex = 13;
            this.TwoButton.Text = "2";
            this.TwoButton.UseVisualStyleBackColor = false;
            this.TwoButton.Click += new System.EventHandler(this.CalculatorButton_Click);
            // 
            // OneButton
            // 
            this.OneButton.BackColor = System.Drawing.Color.White;
            this.OneButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.OneButton.Location = new System.Drawing.Point(3, 180);
            this.OneButton.Name = "OneButton";
            this.OneButton.Size = new System.Drawing.Size(68, 53);
            this.OneButton.TabIndex = 12;
            this.OneButton.Text = "1";
            this.OneButton.UseVisualStyleBackColor = false;
            this.OneButton.Click += new System.EventHandler(this.CalculatorButton_Click);
            // 
            // MinusButton
            // 
            this.MinusButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MinusButton.Location = new System.Drawing.Point(225, 121);
            this.MinusButton.Name = "MinusButton";
            this.MinusButton.Size = new System.Drawing.Size(71, 53);
            this.MinusButton.TabIndex = 11;
            this.MinusButton.Text = "-";
            this.MinusButton.UseVisualStyleBackColor = true;
            this.MinusButton.Click += new System.EventHandler(this.OperatorButton_Click);
            // 
            // SixButton
            // 
            this.SixButton.BackColor = System.Drawing.Color.White;
            this.SixButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SixButton.Location = new System.Drawing.Point(151, 121);
            this.SixButton.Name = "SixButton";
            this.SixButton.Size = new System.Drawing.Size(68, 53);
            this.SixButton.TabIndex = 10;
            this.SixButton.Text = "6";
            this.SixButton.UseVisualStyleBackColor = false;
            this.SixButton.Click += new System.EventHandler(this.CalculatorButton_Click);
            // 
            // FiveButton
            // 
            this.FiveButton.BackColor = System.Drawing.Color.White;
            this.FiveButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.FiveButton.Location = new System.Drawing.Point(77, 121);
            this.FiveButton.Name = "FiveButton";
            this.FiveButton.Size = new System.Drawing.Size(68, 53);
            this.FiveButton.TabIndex = 9;
            this.FiveButton.Text = "5";
            this.FiveButton.UseVisualStyleBackColor = false;
            this.FiveButton.Click += new System.EventHandler(this.CalculatorButton_Click);
            // 
            // FourButton
            // 
            this.FourButton.BackColor = System.Drawing.Color.White;
            this.FourButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.FourButton.Location = new System.Drawing.Point(3, 121);
            this.FourButton.Name = "FourButton";
            this.FourButton.Size = new System.Drawing.Size(68, 53);
            this.FourButton.TabIndex = 8;
            this.FourButton.Text = "4";
            this.FourButton.UseVisualStyleBackColor = false;
            this.FourButton.Click += new System.EventHandler(this.CalculatorButton_Click);
            // 
            // MultiplyButton
            // 
            this.MultiplyButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MultiplyButton.Location = new System.Drawing.Point(225, 62);
            this.MultiplyButton.Name = "MultiplyButton";
            this.MultiplyButton.Size = new System.Drawing.Size(71, 53);
            this.MultiplyButton.TabIndex = 7;
            this.MultiplyButton.Text = "x";
            this.MultiplyButton.UseVisualStyleBackColor = true;
            this.MultiplyButton.Click += new System.EventHandler(this.OperatorButton_Click);
            // 
            // NineButton
            // 
            this.NineButton.BackColor = System.Drawing.Color.White;
            this.NineButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.NineButton.Location = new System.Drawing.Point(151, 62);
            this.NineButton.Name = "NineButton";
            this.NineButton.Size = new System.Drawing.Size(68, 53);
            this.NineButton.TabIndex = 6;
            this.NineButton.Text = "9";
            this.NineButton.UseVisualStyleBackColor = false;
            this.NineButton.Click += new System.EventHandler(this.CalculatorButton_Click);
            // 
            // EightButton
            // 
            this.EightButton.BackColor = System.Drawing.Color.White;
            this.EightButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.EightButton.Location = new System.Drawing.Point(77, 62);
            this.EightButton.Name = "EightButton";
            this.EightButton.Size = new System.Drawing.Size(68, 53);
            this.EightButton.TabIndex = 5;
            this.EightButton.Text = "8";
            this.EightButton.UseVisualStyleBackColor = false;
            this.EightButton.Click += new System.EventHandler(this.CalculatorButton_Click);
            // 
            // SevenButton
            // 
            this.SevenButton.BackColor = System.Drawing.Color.White;
            this.SevenButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SevenButton.Location = new System.Drawing.Point(3, 62);
            this.SevenButton.Name = "SevenButton";
            this.SevenButton.Size = new System.Drawing.Size(68, 53);
            this.SevenButton.TabIndex = 4;
            this.SevenButton.Text = "7";
            this.SevenButton.UseVisualStyleBackColor = false;
            this.SevenButton.Click += new System.EventHandler(this.CalculatorButton_Click);
            // 
            // DivideButton
            // 
            this.DivideButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DivideButton.Location = new System.Drawing.Point(225, 3);
            this.DivideButton.Name = "DivideButton";
            this.DivideButton.Size = new System.Drawing.Size(71, 53);
            this.DivideButton.TabIndex = 3;
            this.DivideButton.Text = "÷";
            this.DivideButton.UseVisualStyleBackColor = true;
            this.DivideButton.Click += new System.EventHandler(this.OperatorButton_Click);
            // 
            // BackSpaceButton
            // 
            this.BackSpaceButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BackSpaceButton.Location = new System.Drawing.Point(151, 3);
            this.BackSpaceButton.Name = "BackSpaceButton";
            this.BackSpaceButton.Size = new System.Drawing.Size(68, 53);
            this.BackSpaceButton.TabIndex = 2;
            this.BackSpaceButton.Text = "DEL";
            this.BackSpaceButton.UseVisualStyleBackColor = true;
            this.BackSpaceButton.Click += new System.EventHandler(this.OperatorButton_Click);
            // 
            // ClearButton
            // 
            this.ButtonTableLayoutPanel.SetColumnSpan(this.ClearButton, 2);
            this.ClearButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ClearButton.Location = new System.Drawing.Point(3, 3);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(142, 53);
            this.ClearButton.TabIndex = 0;
            this.ClearButton.Text = "C";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.OperatorButton_Click);
            // 
            // ResultTextBox
            // 
            this.ResultTextBox.BackColor = System.Drawing.Color.White;
            this.ResultTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ResultTextBox.Enabled = false;
            this.ResultTextBox.Location = new System.Drawing.Point(5, 69);
            this.ResultTextBox.Multiline = true;
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.ReadOnly = true;
            this.ResultTextBox.Size = new System.Drawing.Size(293, 65);
            this.ResultTextBox.TabIndex = 1;
            this.ResultTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // CalculatorForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(304, 442);
            this.Controls.Add(this.ResultTextBox);
            this.Controls.Add(this.ButtonTableLayoutPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "CalculatorForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CalculatorForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CalculatorForm_FormClosed);
            this.Load += new System.EventHandler(this.CalculatorForm_Load);
            this.ButtonTableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel ButtonTableLayoutPanel;
        private System.Windows.Forms.TextBox ResultTextBox;
        private System.Windows.Forms.Button EqualButton;
        private System.Windows.Forms.Button DecimalButton;
        private System.Windows.Forms.Button ZeroButton;
        private System.Windows.Forms.Button PlusMinusButton;
        private System.Windows.Forms.Button Plusbutton;
        private System.Windows.Forms.Button ThreeButton;
        private System.Windows.Forms.Button TwoButton;
        private System.Windows.Forms.Button OneButton;
        private System.Windows.Forms.Button MinusButton;
        private System.Windows.Forms.Button SixButton;
        private System.Windows.Forms.Button FiveButton;
        private System.Windows.Forms.Button FourButton;
        private System.Windows.Forms.Button MultiplyButton;
        private System.Windows.Forms.Button NineButton;
        private System.Windows.Forms.Button EightButton;
        private System.Windows.Forms.Button SevenButton;
        private System.Windows.Forms.Button DivideButton;
        private System.Windows.Forms.Button BackSpaceButton;
        private System.Windows.Forms.Button ClearButton;
    }
}

