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
            this.Lambda = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.sort_delegate_btn = new System.Windows.Forms.Button();
            this.sort_desc_btn = new System.Windows.Forms.Button();
            this.sort_asc_btn = new System.Windows.Forms.Button();
            this.sort_num_txb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.result_txb = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.xn_var_2_btn = new System.Windows.Forms.Button();
            this.xn_var_1_btn = new System.Windows.Forms.Button();
            this.xn_n_txb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.xn_x_txb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.createString_btn = new System.Windows.Forms.Button();
            this.chn_n_txb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chn_char_txb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.String = new System.Windows.Forms.TabPage();
            this.originalStr_txb = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.resultStr_txb = new System.Windows.Forms.TextBox();
            this.mostFrequentElem_btn = new System.Windows.Forms.Button();
            this.wordsLen_btn = new System.Windows.Forms.Button();
            this.isSentence_btn = new System.Windows.Forms.Button();
            this.delVowels_btn = new System.Windows.Forms.Button();
            this.regChg_btn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.clear_btn = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.Lambda.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.String.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Lambda);
            this.tabControl1.Controls.Add(this.String);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(289, 364);
            this.tabControl1.TabIndex = 2;
            // 
            // Lambda
            // 
            this.Lambda.BackColor = System.Drawing.SystemColors.Control;
            this.Lambda.Controls.Add(this.groupBox3);
            this.Lambda.Controls.Add(this.result_txb);
            this.Lambda.Controls.Add(this.groupBox1);
            this.Lambda.Controls.Add(this.label3);
            this.Lambda.Controls.Add(this.groupBox2);
            this.Lambda.Location = new System.Drawing.Point(4, 26);
            this.Lambda.Name = "Lambda";
            this.Lambda.Padding = new System.Windows.Forms.Padding(3);
            this.Lambda.Size = new System.Drawing.Size(281, 334);
            this.Lambda.TabIndex = 0;
            this.Lambda.Text = "Lambda";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.sort_delegate_btn);
            this.groupBox3.Controls.Add(this.sort_desc_btn);
            this.groupBox3.Controls.Add(this.sort_asc_btn);
            this.groupBox3.Controls.Add(this.sort_num_txb);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(9, 143);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(260, 87);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "sort numbers";
            // 
            // sort_delegate_btn
            // 
            this.sort_delegate_btn.Location = new System.Drawing.Point(113, 51);
            this.sort_delegate_btn.Name = "sort_delegate_btn";
            this.sort_delegate_btn.Size = new System.Drawing.Size(135, 26);
            this.sort_delegate_btn.TabIndex = 8;
            this.sort_delegate_btn.Text = "using delegate";
            this.sort_delegate_btn.UseVisualStyleBackColor = true;
            this.sort_delegate_btn.Click += new System.EventHandler(this.sort_delegate_btn_Click);
            // 
            // sort_desc_btn
            // 
            this.sort_desc_btn.Location = new System.Drawing.Point(61, 51);
            this.sort_desc_btn.Name = "sort_desc_btn";
            this.sort_desc_btn.Size = new System.Drawing.Size(46, 26);
            this.sort_desc_btn.TabIndex = 7;
            this.sort_desc_btn.Text = "descending";
            this.sort_desc_btn.UseVisualStyleBackColor = true;
            this.sort_desc_btn.Click += new System.EventHandler(this.sort_desc_btn_Click);
            // 
            // sort_asc_btn
            // 
            this.sort_asc_btn.Location = new System.Drawing.Point(10, 51);
            this.sort_asc_btn.Name = "sort_asc_btn";
            this.sort_asc_btn.Size = new System.Drawing.Size(45, 26);
            this.sort_asc_btn.TabIndex = 6;
            this.sort_asc_btn.Text = "ascending";
            this.sort_asc_btn.UseVisualStyleBackColor = true;
            this.sort_asc_btn.Click += new System.EventHandler(this.sort_asc_btn_Click);
            // 
            // sort_num_txb
            // 
            this.sort_num_txb.Location = new System.Drawing.Point(59, 22);
            this.sort_num_txb.Name = "sort_num_txb";
            this.sort_num_txb.Size = new System.Drawing.Size(189, 23);
            this.sort_num_txb.TabIndex = 3;
            this.sort_num_txb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.sort_num_txb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyNumbersValidation);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "nums:";
            // 
            // result_txb
            // 
            this.result_txb.Location = new System.Drawing.Point(67, 268);
            this.result_txb.Name = "result_txb";
            this.result_txb.Size = new System.Drawing.Size(202, 23);
            this.result_txb.TabIndex = 7;
            this.result_txb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.xn_var_2_btn);
            this.groupBox1.Controls.Add(this.xn_var_1_btn);
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
            // xn_var_2_btn
            // 
            this.xn_var_2_btn.Location = new System.Drawing.Point(60, 81);
            this.xn_var_2_btn.Name = "xn_var_2_btn";
            this.xn_var_2_btn.Size = new System.Drawing.Size(44, 26);
            this.xn_var_2_btn.TabIndex = 5;
            this.xn_var_2_btn.Text = "v 2";
            this.xn_var_2_btn.UseVisualStyleBackColor = true;
            this.xn_var_2_btn.Click += new System.EventHandler(this.xn_var_2_btn_Click);
            // 
            // xn_var_1_btn
            // 
            this.xn_var_1_btn.Location = new System.Drawing.Point(10, 81);
            this.xn_var_1_btn.Name = "xn_var_1_btn";
            this.xn_var_1_btn.Size = new System.Drawing.Size(44, 26);
            this.xn_var_1_btn.TabIndex = 4;
            this.xn_var_1_btn.Text = "v 1";
            this.xn_var_1_btn.UseVisualStyleBackColor = true;
            this.xn_var_1_btn.Click += new System.EventHandler(this.xn_var_1_btn_Click);
            // 
            // xn_n_txb
            // 
            this.xn_n_txb.Location = new System.Drawing.Point(31, 52);
            this.xn_n_txb.Name = "xn_n_txb";
            this.xn_n_txb.Size = new System.Drawing.Size(73, 23);
            this.xn_n_txb.TabIndex = 3;
            this.xn_n_txb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.xn_n_txb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyNumbersValidation);
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
            // xn_x_txb
            // 
            this.xn_x_txb.Location = new System.Drawing.Point(31, 23);
            this.xn_x_txb.Name = "xn_x_txb";
            this.xn_x_txb.Size = new System.Drawing.Size(73, 23);
            this.xn_x_txb.TabIndex = 1;
            this.xn_x_txb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.xn_x_txb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyNumbersValidation);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "result:";
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
            // chn_n_txb
            // 
            this.chn_n_txb.Location = new System.Drawing.Point(53, 51);
            this.chn_n_txb.Name = "chn_n_txb";
            this.chn_n_txb.Size = new System.Drawing.Size(73, 23);
            this.chn_n_txb.TabIndex = 7;
            this.chn_n_txb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chn_n_txb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyNumbersValidation);
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
            // chn_char_txb
            // 
            this.chn_char_txb.Location = new System.Drawing.Point(53, 22);
            this.chn_char_txb.Name = "chn_char_txb";
            this.chn_char_txb.Size = new System.Drawing.Size(73, 23);
            this.chn_char_txb.TabIndex = 5;
            this.chn_char_txb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chn_char_txb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyCharsValidation);
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
            // String
            // 
            this.String.BackColor = System.Drawing.SystemColors.Control;
            this.String.Controls.Add(this.originalStr_txb);
            this.String.Controls.Add(this.groupBox4);
            this.String.Controls.Add(this.mostFrequentElem_btn);
            this.String.Controls.Add(this.wordsLen_btn);
            this.String.Controls.Add(this.isSentence_btn);
            this.String.Controls.Add(this.delVowels_btn);
            this.String.Controls.Add(this.regChg_btn);
            this.String.Controls.Add(this.label6);
            this.String.Location = new System.Drawing.Point(4, 26);
            this.String.Name = "String";
            this.String.Padding = new System.Windows.Forms.Padding(3);
            this.String.Size = new System.Drawing.Size(281, 334);
            this.String.TabIndex = 1;
            this.String.Text = "String";
            // 
            // originalStr_txb
            // 
            this.originalStr_txb.Location = new System.Drawing.Point(40, 6);
            this.originalStr_txb.Name = "originalStr_txb";
            this.originalStr_txb.Size = new System.Drawing.Size(234, 23);
            this.originalStr_txb.TabIndex = 9;
            this.originalStr_txb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.originalStr_txb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyCharsValidation);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.resultStr_txb);
            this.groupBox4.Location = new System.Drawing.Point(11, 233);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(263, 56);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "result";
            // 
            // resultStr_txb
            // 
            this.resultStr_txb.Location = new System.Drawing.Point(6, 22);
            this.resultStr_txb.Name = "resultStr_txb";
            this.resultStr_txb.Size = new System.Drawing.Size(251, 23);
            this.resultStr_txb.TabIndex = 8;
            this.resultStr_txb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mostFrequentElem_btn
            // 
            this.mostFrequentElem_btn.Location = new System.Drawing.Point(11, 163);
            this.mostFrequentElem_btn.Name = "mostFrequentElem_btn";
            this.mostFrequentElem_btn.Size = new System.Drawing.Size(263, 26);
            this.mostFrequentElem_btn.TabIndex = 6;
            this.mostFrequentElem_btn.Text = "find most frequent element";
            this.mostFrequentElem_btn.UseVisualStyleBackColor = true;
            this.mostFrequentElem_btn.Click += new System.EventHandler(this.mostFrequentElem_btn_Click);
            // 
            // wordsLen_btn
            // 
            this.wordsLen_btn.Location = new System.Drawing.Point(11, 99);
            this.wordsLen_btn.Name = "wordsLen_btn";
            this.wordsLen_btn.Size = new System.Drawing.Size(263, 26);
            this.wordsLen_btn.TabIndex = 5;
            this.wordsLen_btn.Text = "words length";
            this.wordsLen_btn.UseVisualStyleBackColor = true;
            this.wordsLen_btn.Click += new System.EventHandler(this.wordsLen_btn_Click);
            // 
            // isSentence_btn
            // 
            this.isSentence_btn.Location = new System.Drawing.Point(11, 131);
            this.isSentence_btn.Name = "isSentence_btn";
            this.isSentence_btn.Size = new System.Drawing.Size(263, 26);
            this.isSentence_btn.TabIndex = 4;
            this.isSentence_btn.Text = "is a sentence?";
            this.isSentence_btn.UseVisualStyleBackColor = true;
            this.isSentence_btn.Click += new System.EventHandler(this.isSentence_btn_Click);
            // 
            // delVowels_btn
            // 
            this.delVowels_btn.Location = new System.Drawing.Point(11, 67);
            this.delVowels_btn.Name = "delVowels_btn";
            this.delVowels_btn.Size = new System.Drawing.Size(263, 26);
            this.delVowels_btn.TabIndex = 3;
            this.delVowels_btn.Text = "delete all vowels";
            this.delVowels_btn.UseVisualStyleBackColor = true;
            this.delVowels_btn.Click += new System.EventHandler(this.delVowels_btn_Click);
            // 
            // regChg_btn
            // 
            this.regChg_btn.Location = new System.Drawing.Point(11, 35);
            this.regChg_btn.Name = "regChg_btn";
            this.regChg_btn.Size = new System.Drawing.Size(263, 26);
            this.regChg_btn.TabIndex = 2;
            this.regChg_btn.Text = "register change";
            this.regChg_btn.UseVisualStyleBackColor = true;
            this.regChg_btn.Click += new System.EventHandler(this.regChg_btn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "str:";
            // 
            // clear_btn
            // 
            this.clear_btn.Location = new System.Drawing.Point(12, 370);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(62, 26);
            this.clear_btn.TabIndex = 8;
            this.clear_btn.Text = "clear";
            this.clear_btn.UseVisualStyleBackColor = true;
            this.clear_btn.Click += new System.EventHandler(this.clear_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 403);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.clear_btn);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Lab 4";
            this.tabControl1.ResumeLayout(false);
            this.Lambda.ResumeLayout(false);
            this.Lambda.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.String.ResumeLayout(false);
            this.String.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Lambda;
        private System.Windows.Forms.TextBox result_txb;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button xn_var_2_btn;
        private System.Windows.Forms.Button xn_var_1_btn;
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
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button sort_desc_btn;
        private System.Windows.Forms.Button sort_asc_btn;
        private System.Windows.Forms.TextBox sort_num_txb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button sort_delegate_btn;
        private System.Windows.Forms.Button regChg_btn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox originalStr_txb;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox resultStr_txb;
        private System.Windows.Forms.Button mostFrequentElem_btn;
        private System.Windows.Forms.Button wordsLen_btn;
        private System.Windows.Forms.Button isSentence_btn;
        private System.Windows.Forms.Button delVowels_btn;
    }
}

