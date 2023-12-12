namespace AOC2023
{
    partial class Day1
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
            openFileDialog1 = new OpenFileDialog();
            textBox1 = new TextBox();
            buttonBrowse = new Button();
            textBoxAnswer = new TextBox();
            label1 = new Label();
            buttonRun = new Button();
            linkLabel1 = new LinkLabel();
            buttonRunAdvanced = new Button();
            SuspendLayout();
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(48, 61);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(417, 23);
            textBox1.TabIndex = 0;
            // 
            // buttonBrowse
            // 
            buttonBrowse.Location = new Point(483, 59);
            buttonBrowse.Name = "buttonBrowse";
            buttonBrowse.Size = new Size(107, 25);
            buttonBrowse.TabIndex = 1;
            buttonBrowse.Text = "Browse";
            buttonBrowse.UseVisualStyleBackColor = true;
            buttonBrowse.Click += buttonBrowse_Click;
            // 
            // textBoxAnswer
            // 
            textBoxAnswer.Font = new Font("Segoe UI", 20F);
            textBoxAnswer.Location = new Point(167, 190);
            textBoxAnswer.Name = "textBoxAnswer";
            textBoxAnswer.Size = new Size(600, 43);
            textBoxAnswer.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(48, 196);
            label1.Name = "label1";
            label1.Size = new Size(103, 37);
            label1.TabIndex = 3;
            label1.Text = "Answer";
            // 
            // buttonRun
            // 
            buttonRun.Location = new Point(641, 61);
            buttonRun.Name = "buttonRun";
            buttonRun.Size = new Size(126, 23);
            buttonRun.TabIndex = 4;
            buttonRun.Text = "Run";
            buttonRun.UseVisualStyleBackColor = true;
            buttonRun.Click += buttonRun_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(48, 9);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(211, 15);
            linkLabel1.TabIndex = 5;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "https://adventofcode.com/2023/day/1";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // buttonRunAdvanced
            // 
            buttonRunAdvanced.Location = new Point(641, 90);
            buttonRunAdvanced.Name = "buttonRunAdvanced";
            buttonRunAdvanced.Size = new Size(126, 23);
            buttonRunAdvanced.TabIndex = 6;
            buttonRunAdvanced.Text = "Run Advanced";
            buttonRunAdvanced.UseVisualStyleBackColor = true;
            buttonRunAdvanced.Click += buttonRunAdvanced_Click;
            // 
            // Day1Part1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonRunAdvanced);
            Controls.Add(linkLabel1);
            Controls.Add(buttonRun);
            Controls.Add(label1);
            Controls.Add(textBoxAnswer);
            Controls.Add(buttonBrowse);
            Controls.Add(textBox1);
            Name = "Day1Part1";
            Text = "Day1Part1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private OpenFileDialog openFileDialog1;
        private TextBox textBox1;
        private Button buttonBrowse;
        private TextBox textBoxAnswer;
        private Label label1;
        private Button buttonRun;
        private LinkLabel linkLabel1;
        private Button buttonRunAdvanced;
    }
}