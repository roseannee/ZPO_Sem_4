namespace lab4
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.String = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.chn_char_txb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chn_n_txb = new System.Windows.Forms.TextBox();
            this.createString_btn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.xn_x_txb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.xn_n_txb = new System.Windows.Forms.TextBox();
            this.p_1_btn = new System.Windows.Forms.Button();
            this.p_2_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.result_txb = new System.Windows.Forms.TextBox();
            this.Lambda = new System.Windows.Forms.TabPage();
            this.clear_btn = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.Lambda.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Lambda);
            this.tabControl1.Controls.Add(this.String);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(292, 269);
            this.tabControl1.TabIndex = 2;
            // 
            // String
            // 
            this.String.BackColor = System.Drawing.SystemColors.Control;
            this.String.Location = new System.Drawing.Point(4, 26);
            this.String.Name = "String";
            this.String.Padding = new System.Windows.Forms.Padding(3);
            this.String.Size = new System.Drawing.Size(284, 239);
            this.String.TabIndex = 1;
            this.String.Text = "String";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.createString_btn);
            this.groupBox2.Controls.Add(this.chn_n_txb);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.chn_char_txb);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(131, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(138, 117);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "char^n";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "char:";
            // 
            // chn_char_txb
            // 
            this.chn_char_txb.Location = new System.Drawing.Point(53, 22);
            this.chn_char_txb.Name = "chn_char_txb";
            this.chn_char_txb.Size = new System.Drawing.Size(73, 23);
            this.chn_char_txb.TabIndex = 5;
            this.chn_char_txb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "n:";
            // 
            // chn_n_txb
            // 
            this.chn_n_txb.Location = new System.Drawing.Point(53, 51);
            this.chn_n_txb.Name = "chn_n_txb";
            this.chn_n_txb.Size = new System.Drawing.Size(73, 23);
            this.chn_n_txb.TabIndex = 7;
            this.chn_n_txb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // createString_btn
            // 
            this.createString_btn.Location = new System.Drawing.Point(9, 80);
            this.createString_btn.Name = "createString_btn";
            this.createString_btn.Size = new System.Drawing.Size(117, 26);
            this.createString_btn.TabIndex = 8;
            this.createString_btn.Text = "create string";
            this.createString_btn.UseVisualStyleBackColor = true;
            this.createString_btn.Click += new System.EventHandler(this.createString_btn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.p_2_btn);
            this.groupBox1.Controls.Add(this.p_1_btn);
            this.groupBox1.Controls.Add(this.xn_n_txb);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.xn_x_txb);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(9, 19);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(115, 117);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "x^n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "x:";
            // 
            // xn_x_txb
            // 
            this.xn_x_txb.Location = new System.Drawing.Point(31, 23);
            this.xn_x_txb.Name = "xn_x_txb";
            this.xn_x_txb.Size = new System.Drawing.Size(73, 23);
            this.xn_x_txb.TabIndex = 1;
            this.xn_x_txb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "n:";
            // 
            // xn_n_txb
            // 
            this.xn_n_txb.Location = new System.Drawing.Point(31, 52);
            this.xn_n_txb.Name = "xn_n_txb";
            this.xn_n_txb.Size = new System.Drawing.Size(73, 23);
            this.xn_n_txb.TabIndex = 3;
            this.xn_n_txb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // p_1_btn
            // 
            this.p_1_btn.Location = new System.Drawing.Point(10, 81);
            this.p_1_btn.Name = "p_1_btn";
            this.p_1_btn.Size = new System.Drawing.Size(44, 26);
            this.p_1_btn.TabIndex = 4;
            this.p_1_btn.Text = "p. 1";
            this.p_1_btn.UseVisualStyleBackColor = true;
            this.p_1_btn.Click += new System.EventHandler(this.p_1_btn_Click);
            // 
            // p_2_btn
            // 
            this.p_2_btn.Location = new System.Drawing.Point(60, 81);
            this.p_2_btn.Name = "p_2_btn";
            this.p_2_btn.Size = new System.Drawing.Size(44, 26);
            this.p_2_btn.TabIndex = 5;
            this.p_2_btn.Text = "p. 3";
            this.p_2_btn.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "result:";
            // 
            // result_txb
            // 
            this.result_txb.Location = new System.Drawing.Point(67, 160);
            this.result_txb.Name = "result_txb";
            this.result_txb.Size = new System.Drawing.Size(202, 23);
            this.result_txb.TabIndex = 7;
            this.result_txb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Lambda
            // 
            this.Lambda.BackColor = System.Drawing.SystemColors.Control;
            this.Lambda.Controls.Add(this.clear_btn);
            this.Lambda.Controls.Add(this.result_txb);
            this.Lambda.Controls.Add(this.groupBox1);
            this.Lambda.Controls.Add(this.label3);
            this.Lambda.Controls.Add(this.groupBox2);
            this.Lambda.Location = new System.Drawing.Point(4, 26);
            this.Lambda.Name = "Lambda";
            this.Lambda.Padding = new System.Windows.Forms.Padding(3);
            this.Lambda.Size = new System.Drawing.Size(284, 239);
            this.Lambda.TabIndex = 0;
            this.Lambda.Text = "Lambda";
            // 
            // clear_btn
            // 
            this.clear_btn.Location = new System.Drawing.Point(9, 207);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(62, 26);
            this.clear_btn.TabIndex = 8;
            this.clear_btn.Text = "clear";
            this.clear_btn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 281);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Lab 4";
            this.tabControl1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Lambda.ResumeLayout(false);
            this.Lambda.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Lambda;
        private System.Windows.Forms.TextBox result_txb;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button p_2_btn;
        private System.Windows.Forms.Button p_1_btn;
        private System.Windows.Forms.TextBox xn_n_txb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox xn_x_txb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button createString_btn;
        private System.Windows.Forms.TextBox chn_n_txb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox chn_char_txb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage String;
        private System.Windows.Forms.Button clear_btn;
    }
}

