namespace Lab2_Zhirova
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_Close = new System.Windows.Forms.Button();
            this.button_XOR = new System.Windows.Forms.Button();
            this.button_Clean = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_PP = new System.Windows.Forms.TextBox();
            this.textBox_KKey = new System.Windows.Forms.TextBox();
            this.textBox_CC = new System.Windows.Forms.TextBox();
            this.textBox_C = new System.Windows.Forms.TextBox();
            this.textBox_Key = new System.Windows.Forms.TextBox();
            this.textBox_P = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label_Bin_P = new System.Windows.Forms.Label();
            this.label_Bin_Key = new System.Windows.Forms.Label();
            this.label_Bin_C = new System.Windows.Forms.Label();
            this.label_Hex_P = new System.Windows.Forms.Label();
            this.label_Hex_Key = new System.Windows.Forms.Label();
            this.label_Hex_C = new System.Windows.Forms.Label();
            this.label_Dec_P = new System.Windows.Forms.Label();
            this.label_Dec_Key = new System.Windows.Forms.Label();
            this.label_Dec_C = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_Dec_C);
            this.groupBox1.Controls.Add(this.label_Dec_Key);
            this.groupBox1.Controls.Add(this.label_Dec_P);
            this.groupBox1.Controls.Add(this.label_Hex_C);
            this.groupBox1.Controls.Add(this.label_Hex_Key);
            this.groupBox1.Controls.Add(this.label_Hex_P);
            this.groupBox1.Controls.Add(this.label_Bin_C);
            this.groupBox1.Controls.Add(this.label_Bin_Key);
            this.groupBox1.Controls.Add(this.label_Bin_P);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.button_Close);
            this.groupBox1.Controls.Add(this.button_XOR);
            this.groupBox1.Controls.Add(this.button_Clean);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox_PP);
            this.groupBox1.Controls.Add(this.textBox_KKey);
            this.groupBox1.Controls.Add(this.textBox_CC);
            this.groupBox1.Controls.Add(this.textBox_C);
            this.groupBox1.Controls.Add(this.textBox_Key);
            this.groupBox1.Controls.Add(this.textBox_P);
            this.groupBox1.Location = new System.Drawing.Point(3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(474, 395);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "XOR шифратор";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button_Close
            // 
            this.button_Close.Location = new System.Drawing.Point(380, 337);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(88, 42);
            this.button_Close.TabIndex = 14;
            this.button_Close.Text = "Закрити";
            this.button_Close.UseVisualStyleBackColor = true;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // button_XOR
            // 
            this.button_XOR.Location = new System.Drawing.Point(211, 75);
            this.button_XOR.Name = "button_XOR";
            this.button_XOR.Size = new System.Drawing.Size(75, 33);
            this.button_XOR.TabIndex = 13;
            this.button_XOR.Text = "XOR";
            this.button_XOR.UseVisualStyleBackColor = true;
            this.button_XOR.Click += new System.EventHandler(this.button_XOR_Click);
            // 
            // button_Clean
            // 
            this.button_Clean.Location = new System.Drawing.Point(101, 185);
            this.button_Clean.Name = "button_Clean";
            this.button_Clean.Size = new System.Drawing.Size(91, 42);
            this.button_Clean.TabIndex = 12;
            this.button_Clean.Text = "Прибрати";
            this.button_Clean.UseVisualStyleBackColor = true;
            this.button_Clean.Click += new System.EventHandler(this.button_Clean_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(424, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "= P";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(424, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "= Key";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(424, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "= C";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "C =";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Key =";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "P =";
            // 
            // textBox_PP
            // 
            this.textBox_PP.Location = new System.Drawing.Point(308, 137);
            this.textBox_PP.Name = "textBox_PP";
            this.textBox_PP.Size = new System.Drawing.Size(100, 20);
            this.textBox_PP.TabIndex = 5;
            // 
            // textBox_KKey
            // 
            this.textBox_KKey.Location = new System.Drawing.Point(308, 88);
            this.textBox_KKey.Name = "textBox_KKey";
            this.textBox_KKey.Size = new System.Drawing.Size(100, 20);
            this.textBox_KKey.TabIndex = 4;
            // 
            // textBox_CC
            // 
            this.textBox_CC.Location = new System.Drawing.Point(308, 46);
            this.textBox_CC.Name = "textBox_CC";
            this.textBox_CC.Size = new System.Drawing.Size(100, 20);
            this.textBox_CC.TabIndex = 3;
            // 
            // textBox_C
            // 
            this.textBox_C.Location = new System.Drawing.Point(76, 137);
            this.textBox_C.Name = "textBox_C";
            this.textBox_C.Size = new System.Drawing.Size(100, 20);
            this.textBox_C.TabIndex = 2;
            // 
            // textBox_Key
            // 
            this.textBox_Key.Location = new System.Drawing.Point(76, 88);
            this.textBox_Key.Name = "textBox_Key";
            this.textBox_Key.Size = new System.Drawing.Size(100, 20);
            this.textBox_Key.TabIndex = 1;
            // 
            // textBox_P
            // 
            this.textBox_P.Location = new System.Drawing.Point(76, 46);
            this.textBox_P.Name = "textBox_P";
            this.textBox_P.Size = new System.Drawing.Size(100, 20);
            this.textBox_P.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 303);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "P";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 337);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Key";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 366);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(14, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "C";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(82, 270);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "у 2ому форматі";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(208, 270);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "у 16ому";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(305, 270);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 13);
            this.label12.TabIndex = 20;
            this.label12.Text = "у 10му";
            // 
            // label_Bin_P
            // 
            this.label_Bin_P.AutoSize = true;
            this.label_Bin_P.Location = new System.Drawing.Point(82, 303);
            this.label_Bin_P.Name = "label_Bin_P";
            this.label_Bin_P.Size = new System.Drawing.Size(0, 13);
            this.label_Bin_P.TabIndex = 21;
            // 
            // label_Bin_Key
            // 
            this.label_Bin_Key.AutoSize = true;
            this.label_Bin_Key.Location = new System.Drawing.Point(82, 336);
            this.label_Bin_Key.Name = "label_Bin_Key";
            this.label_Bin_Key.Size = new System.Drawing.Size(0, 13);
            this.label_Bin_Key.TabIndex = 22;
            // 
            // label_Bin_C
            // 
            this.label_Bin_C.AutoSize = true;
            this.label_Bin_C.Location = new System.Drawing.Point(82, 365);
            this.label_Bin_C.Name = "label_Bin_C";
            this.label_Bin_C.Size = new System.Drawing.Size(0, 13);
            this.label_Bin_C.TabIndex = 23;
            // 
            // label_Hex_P
            // 
            this.label_Hex_P.AutoSize = true;
            this.label_Hex_P.Location = new System.Drawing.Point(211, 303);
            this.label_Hex_P.Name = "label_Hex_P";
            this.label_Hex_P.Size = new System.Drawing.Size(0, 13);
            this.label_Hex_P.TabIndex = 24;
            // 
            // label_Hex_Key
            // 
            this.label_Hex_Key.AutoSize = true;
            this.label_Hex_Key.Location = new System.Drawing.Point(211, 336);
            this.label_Hex_Key.Name = "label_Hex_Key";
            this.label_Hex_Key.Size = new System.Drawing.Size(0, 13);
            this.label_Hex_Key.TabIndex = 25;
            // 
            // label_Hex_C
            // 
            this.label_Hex_C.AutoSize = true;
            this.label_Hex_C.Location = new System.Drawing.Point(211, 365);
            this.label_Hex_C.Name = "label_Hex_C";
            this.label_Hex_C.Size = new System.Drawing.Size(0, 13);
            this.label_Hex_C.TabIndex = 26;
            // 
            // label_Dec_P
            // 
            this.label_Dec_P.AutoSize = true;
            this.label_Dec_P.Location = new System.Drawing.Point(308, 303);
            this.label_Dec_P.Name = "label_Dec_P";
            this.label_Dec_P.Size = new System.Drawing.Size(0, 13);
            this.label_Dec_P.TabIndex = 27;
            // 
            // label_Dec_Key
            // 
            this.label_Dec_Key.AutoSize = true;
            this.label_Dec_Key.Location = new System.Drawing.Point(308, 336);
            this.label_Dec_Key.Name = "label_Dec_Key";
            this.label_Dec_Key.Size = new System.Drawing.Size(0, 13);
            this.label_Dec_Key.TabIndex = 28;
            // 
            // label_Dec_C
            // 
            this.label_Dec_C.AutoSize = true;
            this.label_Dec_C.Location = new System.Drawing.Point(308, 365);
            this.label_Dec_C.Name = "label_Dec_C";
            this.label_Dec_C.Size = new System.Drawing.Size(0, 13);
            this.label_Dec_C.TabIndex = 29;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 409);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_XOR;
        private System.Windows.Forms.Button button_Clean;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_PP;
        private System.Windows.Forms.TextBox textBox_KKey;
        private System.Windows.Forms.TextBox textBox_CC;
        private System.Windows.Forms.TextBox textBox_C;
        private System.Windows.Forms.TextBox textBox_Key;
        private System.Windows.Forms.TextBox textBox_P;
        private System.Windows.Forms.Button button_Close;
        private System.Windows.Forms.Label label_Dec_C;
        private System.Windows.Forms.Label label_Dec_Key;
        private System.Windows.Forms.Label label_Dec_P;
        private System.Windows.Forms.Label label_Hex_C;
        private System.Windows.Forms.Label label_Hex_Key;
        private System.Windows.Forms.Label label_Hex_P;
        private System.Windows.Forms.Label label_Bin_C;
        private System.Windows.Forms.Label label_Bin_Key;
        private System.Windows.Forms.Label label_Bin_P;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}

