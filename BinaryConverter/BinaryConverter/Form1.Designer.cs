using System.Windows.Forms;

namespace BinaryConverter
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
            this.Bit5 = new System.Windows.Forms.TextBox();
            this.Bit4 = new System.Windows.Forms.TextBox();
            this.Bit3 = new System.Windows.Forms.TextBox();
            this.Bit2 = new System.Windows.Forms.TextBox();
            this.Bit1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Bit6 = new System.Windows.Forms.TextBox();
            this.Bit7 = new System.Windows.Forms.TextBox();
            this.Bit8 = new System.Windows.Forms.TextBox();
            this.B8 = new System.Windows.Forms.TextBox();
            this.B7 = new System.Windows.Forms.TextBox();
            this.B6 = new System.Windows.Forms.TextBox();
            this.B1 = new System.Windows.Forms.TextBox();
            this.B2 = new System.Windows.Forms.TextBox();
            this.B3 = new System.Windows.Forms.TextBox();
            this.B4 = new System.Windows.Forms.TextBox();
            this.B5 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BT8 = new System.Windows.Forms.TextBox();
            this.BT7 = new System.Windows.Forms.TextBox();
            this.BT6 = new System.Windows.Forms.TextBox();
            this.BT1 = new System.Windows.Forms.TextBox();
            this.BT2 = new System.Windows.Forms.TextBox();
            this.BT3 = new System.Windows.Forms.TextBox();
            this.BT4 = new System.Windows.Forms.TextBox();
            this.BT5 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.operationUpDown = new System.Windows.Forms.DomainUpDown();
            this.clearButton = new System.Windows.Forms.Button();
            this.rightShift = new System.Windows.Forms.Button();
            this.leftShift = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Bit5
            // 
            this.Bit5.Location = new System.Drawing.Point(432, 104);
            this.Bit5.Name = "Bit5";
            this.Bit5.ReadOnly = true;
            this.Bit5.Size = new System.Drawing.Size(22, 22);
            this.Bit5.TabIndex = 0;
            this.Bit5.Text = "0";
            this.Bit5.MouseClick += new System.Windows.Forms.MouseEventHandler(this.bit_MouseClick);
            // 
            // Bit4
            // 
            this.Bit4.Location = new System.Drawing.Point(460, 104);
            this.Bit4.Name = "Bit4";
            this.Bit4.ReadOnly = true;
            this.Bit4.Size = new System.Drawing.Size(22, 22);
            this.Bit4.TabIndex = 1;
            this.Bit4.Text = "0";
            this.Bit4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.bit_MouseClick);
            // 
            // Bit3
            // 
            this.Bit3.Location = new System.Drawing.Point(488, 104);
            this.Bit3.Name = "Bit3";
            this.Bit3.ReadOnly = true;
            this.Bit3.Size = new System.Drawing.Size(22, 22);
            this.Bit3.TabIndex = 2;
            this.Bit3.Text = "0";
            this.Bit3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.bit_MouseClick);
            // 
            // Bit2
            // 
            this.Bit2.Location = new System.Drawing.Point(516, 104);
            this.Bit2.Name = "Bit2";
            this.Bit2.ReadOnly = true;
            this.Bit2.Size = new System.Drawing.Size(22, 22);
            this.Bit2.TabIndex = 3;
            this.Bit2.Text = "0";
            this.Bit2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.bit_MouseClick);
            // 
            // Bit1
            // 
            this.Bit1.Location = new System.Drawing.Point(544, 104);
            this.Bit1.Name = "Bit1";
            this.Bit1.ReadOnly = true;
            this.Bit1.Size = new System.Drawing.Size(22, 22);
            this.Bit1.TabIndex = 4;
            this.Bit1.Text = "0";
            this.Bit1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.bit_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(572, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "0";
            // 
            // Bit6
            // 
            this.Bit6.Location = new System.Drawing.Point(404, 104);
            this.Bit6.Name = "Bit6";
            this.Bit6.ReadOnly = true;
            this.Bit6.Size = new System.Drawing.Size(22, 22);
            this.Bit6.TabIndex = 7;
            this.Bit6.Text = "0";
            this.Bit6.MouseClick += new System.Windows.Forms.MouseEventHandler(this.bit_MouseClick);
            // 
            // Bit7
            // 
            this.Bit7.Location = new System.Drawing.Point(376, 104);
            this.Bit7.Name = "Bit7";
            this.Bit7.ReadOnly = true;
            this.Bit7.Size = new System.Drawing.Size(22, 22);
            this.Bit7.TabIndex = 8;
            this.Bit7.Text = "0";
            this.Bit7.MouseClick += new System.Windows.Forms.MouseEventHandler(this.bit_MouseClick);
            // 
            // Bit8
            // 
            this.Bit8.Location = new System.Drawing.Point(348, 104);
            this.Bit8.Name = "Bit8";
            this.Bit8.ReadOnly = true;
            this.Bit8.Size = new System.Drawing.Size(22, 22);
            this.Bit8.TabIndex = 9;
            this.Bit8.Text = "0";
            this.Bit8.MouseClick += new System.Windows.Forms.MouseEventHandler(this.bit_MouseClick);
            // 
            // B8
            // 
            this.B8.Location = new System.Drawing.Point(348, 132);
            this.B8.Name = "B8";
            this.B8.ReadOnly = true;
            this.B8.Size = new System.Drawing.Size(22, 22);
            this.B8.TabIndex = 17;
            this.B8.Text = "0";
            this.B8.MouseClick += new System.Windows.Forms.MouseEventHandler(this.bit_MouseClick);
            // 
            // B7
            // 
            this.B7.Location = new System.Drawing.Point(376, 132);
            this.B7.Name = "B7";
            this.B7.ReadOnly = true;
            this.B7.Size = new System.Drawing.Size(22, 22);
            this.B7.TabIndex = 16;
            this.B7.Text = "0";
            this.B7.MouseClick += new System.Windows.Forms.MouseEventHandler(this.bit_MouseClick);
            // 
            // B6
            // 
            this.B6.Location = new System.Drawing.Point(404, 132);
            this.B6.Name = "B6";
            this.B6.ReadOnly = true;
            this.B6.Size = new System.Drawing.Size(22, 22);
            this.B6.TabIndex = 15;
            this.B6.Text = "0";
            this.B6.MouseClick += new System.Windows.Forms.MouseEventHandler(this.bit_MouseClick);
            // 
            // B1
            // 
            this.B1.Location = new System.Drawing.Point(544, 132);
            this.B1.Name = "B1";
            this.B1.ReadOnly = true;
            this.B1.Size = new System.Drawing.Size(22, 22);
            this.B1.TabIndex = 14;
            this.B1.Text = "0";
            this.B1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.bit_MouseClick);
            // 
            // B2
            // 
            this.B2.Location = new System.Drawing.Point(516, 132);
            this.B2.Name = "B2";
            this.B2.ReadOnly = true;
            this.B2.Size = new System.Drawing.Size(22, 22);
            this.B2.TabIndex = 13;
            this.B2.Text = "0";
            this.B2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.bit_MouseClick);
            // 
            // B3
            // 
            this.B3.Location = new System.Drawing.Point(488, 132);
            this.B3.Name = "B3";
            this.B3.ReadOnly = true;
            this.B3.Size = new System.Drawing.Size(22, 22);
            this.B3.TabIndex = 12;
            this.B3.Text = "0";
            this.B3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.bit_MouseClick);
            // 
            // B4
            // 
            this.B4.Location = new System.Drawing.Point(460, 132);
            this.B4.Name = "B4";
            this.B4.ReadOnly = true;
            this.B4.Size = new System.Drawing.Size(22, 22);
            this.B4.TabIndex = 11;
            this.B4.Text = "0";
            this.B4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.bit_MouseClick);
            // 
            // B5
            // 
            this.B5.Location = new System.Drawing.Point(432, 132);
            this.B5.Name = "B5";
            this.B5.ReadOnly = true;
            this.B5.Size = new System.Drawing.Size(22, 22);
            this.B5.TabIndex = 10;
            this.B5.Text = "0";
            this.B5.MouseClick += new System.Windows.Forms.MouseEventHandler(this.bit_MouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(572, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "0";
            // 
            // BT8
            // 
            this.BT8.Location = new System.Drawing.Point(348, 176);
            this.BT8.Name = "BT8";
            this.BT8.ReadOnly = true;
            this.BT8.Size = new System.Drawing.Size(22, 22);
            this.BT8.TabIndex = 26;
            this.BT8.Text = "0";
            // 
            // BT7
            // 
            this.BT7.Location = new System.Drawing.Point(376, 176);
            this.BT7.Name = "BT7";
            this.BT7.ReadOnly = true;
            this.BT7.Size = new System.Drawing.Size(22, 22);
            this.BT7.TabIndex = 25;
            this.BT7.Text = "0";
            // 
            // BT6
            // 
            this.BT6.Location = new System.Drawing.Point(404, 176);
            this.BT6.Name = "BT6";
            this.BT6.ReadOnly = true;
            this.BT6.Size = new System.Drawing.Size(22, 22);
            this.BT6.TabIndex = 24;
            this.BT6.Text = "0";
            // 
            // BT1
            // 
            this.BT1.Location = new System.Drawing.Point(544, 176);
            this.BT1.Name = "BT1";
            this.BT1.ReadOnly = true;
            this.BT1.Size = new System.Drawing.Size(22, 22);
            this.BT1.TabIndex = 23;
            this.BT1.Text = "0";
            // 
            // BT2
            // 
            this.BT2.Location = new System.Drawing.Point(516, 176);
            this.BT2.Name = "BT2";
            this.BT2.ReadOnly = true;
            this.BT2.Size = new System.Drawing.Size(22, 22);
            this.BT2.TabIndex = 22;
            this.BT2.Text = "0";
            // 
            // BT3
            // 
            this.BT3.Location = new System.Drawing.Point(488, 176);
            this.BT3.Name = "BT3";
            this.BT3.ReadOnly = true;
            this.BT3.Size = new System.Drawing.Size(22, 22);
            this.BT3.TabIndex = 21;
            this.BT3.Text = "0";
            // 
            // BT4
            // 
            this.BT4.Location = new System.Drawing.Point(460, 176);
            this.BT4.Name = "BT4";
            this.BT4.ReadOnly = true;
            this.BT4.Size = new System.Drawing.Size(22, 22);
            this.BT4.TabIndex = 20;
            this.BT4.Text = "0";
            // 
            // BT5
            // 
            this.BT5.Location = new System.Drawing.Point(432, 176);
            this.BT5.Name = "BT5";
            this.BT5.ReadOnly = true;
            this.BT5.Size = new System.Drawing.Size(22, 22);
            this.BT5.TabIndex = 19;
            this.BT5.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(572, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 16);
            this.label3.TabIndex = 27;
            this.label3.Text = "0";
            // 
            // operationUpDown
            // 
            this.operationUpDown.Items.Add("+");
            this.operationUpDown.Items.Add("&");
            this.operationUpDown.Items.Add("|");
            this.operationUpDown.Items.Add("^");
            this.operationUpDown.Location = new System.Drawing.Point(308, 132);
            this.operationUpDown.Name = "operationUpDown";
            this.operationUpDown.ReadOnly = true;
            this.operationUpDown.Size = new System.Drawing.Size(34, 22);
            this.operationUpDown.TabIndex = 29;
            this.operationUpDown.Text = "+";
            this.operationUpDown.SelectedItemChanged += new System.EventHandler(this.operationUpDown_SelectedItemChanged);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(348, 228);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(218, 42);
            this.clearButton.TabIndex = 30;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // rightShift
            // 
            this.rightShift.Location = new System.Drawing.Point(460, 66);
            this.rightShift.Name = "rightShift";
            this.rightShift.Size = new System.Drawing.Size(106, 32);
            this.rightShift.TabIndex = 31;
            this.rightShift.Text = "Shift Right   >";
            this.rightShift.UseVisualStyleBackColor = true;
            this.rightShift.Click += new System.EventHandler(this.rightShift_Click);
            // 
            // leftShift
            // 
            this.leftShift.Location = new System.Drawing.Point(348, 66);
            this.leftShift.Name = "leftShift";
            this.leftShift.Size = new System.Drawing.Size(106, 32);
            this.leftShift.TabIndex = 32;
            this.leftShift.Text = "<   Shift Left";
            this.leftShift.UseVisualStyleBackColor = true;
            this.leftShift.Click += new System.EventHandler(this.leftShift_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(348, 276);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(218, 42);
            this.button1.TabIndex = 33;
            this.button1.Text = "Flip";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.leftShift);
            this.Controls.Add(this.rightShift);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.operationUpDown);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BT8);
            this.Controls.Add(this.BT7);
            this.Controls.Add(this.BT6);
            this.Controls.Add(this.BT1);
            this.Controls.Add(this.BT2);
            this.Controls.Add(this.BT3);
            this.Controls.Add(this.BT4);
            this.Controls.Add(this.BT5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.B8);
            this.Controls.Add(this.B7);
            this.Controls.Add(this.B6);
            this.Controls.Add(this.B1);
            this.Controls.Add(this.B2);
            this.Controls.Add(this.B3);
            this.Controls.Add(this.B4);
            this.Controls.Add(this.B5);
            this.Controls.Add(this.Bit8);
            this.Controls.Add(this.Bit7);
            this.Controls.Add(this.Bit6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Bit1);
            this.Controls.Add(this.Bit2);
            this.Controls.Add(this.Bit3);
            this.Controls.Add(this.Bit4);
            this.Controls.Add(this.Bit5);
            this.Name = "Form1";
            this.Text = "Binary";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Bit5;
        private System.Windows.Forms.TextBox Bit4;
        private System.Windows.Forms.TextBox Bit3;
        private System.Windows.Forms.TextBox Bit2;
        private System.Windows.Forms.TextBox Bit1;
        private System.Windows.Forms.Label label1;
        private TextBox Bit6;
        private TextBox Bit7;
        private TextBox Bit8;
        private TextBox B8;
        private TextBox B7;
        private TextBox B6;
        private TextBox B1;
        private TextBox B2;
        private TextBox B3;
        private TextBox B4;
        private TextBox B5;
        private Label label2;
        private TextBox BT8;
        private TextBox BT7;
        private TextBox BT6;
        private TextBox BT1;
        private TextBox BT2;
        private TextBox BT3;
        private TextBox BT4;
        private TextBox BT5;
        private Label label3;
        private DomainUpDown operationUpDown;
        private Button clearButton;
        private Button rightShift;
        private Button leftShift;
        private Button button1;
    }
}

