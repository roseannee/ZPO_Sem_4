namespace lab2
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
            this.num_tb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.res_tb = new System.Windows.Forms.TextBox();
            this.square_chb = new System.Windows.Forms.CheckBox();
            this.root_chb = new System.Windows.Forms.CheckBox();
            this.inverse_chb = new System.Windows.Forms.CheckBox();
            this.calcSingle_bt = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.selected_op_lb = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.applyAppearanceChanges_bt = new System.Windows.Forms.Button();
            this.changeBgColor_chb = new System.Windows.Forms.CheckBox();
            this.changeFontColor_chb = new System.Windows.Forms.CheckBox();
            this.changeFontStyle_chb = new System.Windows.Forms.CheckBox();
            this.calcArray_bt = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // num_tb
            // 
            this.num_tb.ForeColor = System.Drawing.SystemColors.WindowText;
            this.num_tb.Location = new System.Drawing.Point(15, 30);
            this.num_tb.Margin = new System.Windows.Forms.Padding(4);
            this.num_tb.Name = "num_tb";
            this.num_tb.Size = new System.Drawing.Size(108, 23);
            this.num_tb.TabIndex = 0;
            this.num_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyNumbersValidation);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "result";
            // 
            // res_tb
            // 
            this.res_tb.ForeColor = System.Drawing.SystemColors.WindowText;
            this.res_tb.Location = new System.Drawing.Point(138, 30);
            this.res_tb.Margin = new System.Windows.Forms.Padding(4);
            this.res_tb.Name = "res_tb";
            this.res_tb.Size = new System.Drawing.Size(108, 23);
            this.res_tb.TabIndex = 4;
            // 
            // square_chb
            // 
            this.square_chb.AutoSize = true;
            this.square_chb.Location = new System.Drawing.Point(16, 22);
            this.square_chb.Name = "square_chb";
            this.square_chb.Size = new System.Drawing.Size(70, 21);
            this.square_chb.TabIndex = 5;
            this.square_chb.Text = "square";
            this.square_chb.UseVisualStyleBackColor = true;
            this.square_chb.CheckedChanged += new System.EventHandler(this.Chb_CheckedChanged);
            // 
            // root_chb
            // 
            this.root_chb.AutoSize = true;
            this.root_chb.Location = new System.Drawing.Point(16, 49);
            this.root_chb.Name = "root_chb";
            this.root_chb.Size = new System.Drawing.Size(54, 21);
            this.root_chb.TabIndex = 6;
            this.root_chb.Text = "root";
            this.root_chb.UseVisualStyleBackColor = true;
            this.root_chb.CheckedChanged += new System.EventHandler(this.Chb_CheckedChanged);
            // 
            // inverse_chb
            // 
            this.inverse_chb.AutoSize = true;
            this.inverse_chb.Location = new System.Drawing.Point(16, 76);
            this.inverse_chb.Name = "inverse_chb";
            this.inverse_chb.Size = new System.Drawing.Size(71, 21);
            this.inverse_chb.TabIndex = 7;
            this.inverse_chb.Text = "inverse";
            this.inverse_chb.UseVisualStyleBackColor = true;
            this.inverse_chb.CheckedChanged += new System.EventHandler(this.Chb_CheckedChanged);
            // 
            // calcSingle_bt
            // 
            this.calcSingle_bt.Location = new System.Drawing.Point(15, 60);
            this.calcSingle_bt.Name = "calcSingle_bt";
            this.calcSingle_bt.Size = new System.Drawing.Size(94, 27);
            this.calcSingle_bt.TabIndex = 8;
            this.calcSingle_bt.Text = "Calc: single";
            this.calcSingle_bt.UseVisualStyleBackColor = true;
            this.calcSingle_bt.Click += new System.EventHandler(this.calcSingle_bt_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Selected operation:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.square_chb);
            this.groupBox1.Controls.Add(this.root_chb);
            this.groupBox1.Controls.Add(this.inverse_chb);
            this.groupBox1.Location = new System.Drawing.Point(253, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(120, 104);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "arithmetic op";
            // 
            // selected_op_lb
            // 
            this.selected_op_lb.AutoSize = true;
            this.selected_op_lb.Location = new System.Drawing.Point(153, 99);
            this.selected_op_lb.Name = "selected_op_lb";
            this.selected_op_lb.Size = new System.Drawing.Size(0, 17);
            this.selected_op_lb.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Silver;
            this.label5.Location = new System.Drawing.Point(12, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(359, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "———————————————————————————\r\n";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.applyAppearanceChanges_bt);
            this.groupBox2.Controls.Add(this.changeBgColor_chb);
            this.groupBox2.Controls.Add(this.changeFontColor_chb);
            this.groupBox2.Controls.Add(this.changeFontStyle_chb);
            this.groupBox2.Location = new System.Drawing.Point(15, 139);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(356, 104);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "appearance mod";
            // 
            // applyAppearanceChanges_bt
            // 
            this.applyAppearanceChanges_bt.Location = new System.Drawing.Point(214, 45);
            this.applyAppearanceChanges_bt.Name = "applyAppearanceChanges_bt";
            this.applyAppearanceChanges_bt.Size = new System.Drawing.Size(94, 27);
            this.applyAppearanceChanges_bt.TabIndex = 8;
            this.applyAppearanceChanges_bt.Text = "Apply";
            this.applyAppearanceChanges_bt.UseVisualStyleBackColor = true;
            this.applyAppearanceChanges_bt.Click += new System.EventHandler(this.applyAppearanceChanges_bt_Click);
            // 
            // changeBgColor_chb
            // 
            this.changeBgColor_chb.AutoSize = true;
            this.changeBgColor_chb.Location = new System.Drawing.Point(16, 22);
            this.changeBgColor_chb.Name = "changeBgColor_chb";
            this.changeBgColor_chb.Size = new System.Drawing.Size(136, 21);
            this.changeBgColor_chb.TabIndex = 5;
            this.changeBgColor_chb.Text = "change bg color";
            this.changeBgColor_chb.UseVisualStyleBackColor = true;
            // 
            // changeFontColor_chb
            // 
            this.changeFontColor_chb.AutoSize = true;
            this.changeFontColor_chb.Location = new System.Drawing.Point(16, 49);
            this.changeFontColor_chb.Name = "changeFontColor_chb";
            this.changeFontColor_chb.Size = new System.Drawing.Size(144, 21);
            this.changeFontColor_chb.TabIndex = 6;
            this.changeFontColor_chb.Text = "change font color";
            this.changeFontColor_chb.UseVisualStyleBackColor = true;
            // 
            // changeFontStyle_chb
            // 
            this.changeFontStyle_chb.AutoSize = true;
            this.changeFontStyle_chb.Location = new System.Drawing.Point(16, 76);
            this.changeFontStyle_chb.Name = "changeFontStyle_chb";
            this.changeFontStyle_chb.Size = new System.Drawing.Size(138, 21);
            this.changeFontStyle_chb.TabIndex = 7;
            this.changeFontStyle_chb.Text = "change font style";
            this.changeFontStyle_chb.UseVisualStyleBackColor = true;
            // 
            // calcArray_bt
            // 
            this.calcArray_bt.Location = new System.Drawing.Point(138, 60);
            this.calcArray_bt.Name = "calcArray_bt";
            this.calcArray_bt.Size = new System.Drawing.Size(94, 27);
            this.calcArray_bt.TabIndex = 15;
            this.calcArray_bt.Text = "Calc: array";
            this.calcArray_bt.UseVisualStyleBackColor = true;
            this.calcArray_bt.Click += new System.EventHandler(this.calcArray_bt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 256);
            this.Controls.Add(this.calcArray_bt);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.selected_op_lb);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.calcSingle_bt);
            this.Controls.Add(this.res_tb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.num_tb);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Lab 2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox num_tb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox res_tb;
        private System.Windows.Forms.CheckBox square_chb;
        private System.Windows.Forms.CheckBox root_chb;
        private System.Windows.Forms.CheckBox inverse_chb;
        private System.Windows.Forms.Button calcSingle_bt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label selected_op_lb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button applyAppearanceChanges_bt;
        private System.Windows.Forms.CheckBox changeBgColor_chb;
        private System.Windows.Forms.CheckBox changeFontColor_chb;
        private System.Windows.Forms.CheckBox changeFontStyle_chb;
        private System.Windows.Forms.Button calcArray_bt;
    }
}

