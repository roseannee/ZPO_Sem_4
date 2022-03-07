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
            this.calc_bt = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.selected_op_lb = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // num_tb
            // 
            this.num_tb.Location = new System.Drawing.Point(15, 30);
            this.num_tb.Margin = new System.Windows.Forms.Padding(4);
            this.num_tb.Name = "num_tb";
            this.num_tb.Size = new System.Drawing.Size(85, 23);
            this.num_tb.TabIndex = 0;
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
            this.res_tb.Location = new System.Drawing.Point(138, 30);
            this.res_tb.Margin = new System.Windows.Forms.Padding(4);
            this.res_tb.Name = "res_tb";
            this.res_tb.Size = new System.Drawing.Size(85, 23);
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
            // 
            // calc_bt
            // 
            this.calc_bt.Location = new System.Drawing.Point(72, 60);
            this.calc_bt.Name = "calc_bt";
            this.calc_bt.Size = new System.Drawing.Size(94, 27);
            this.calc_bt.TabIndex = 8;
            this.calc_bt.Text = "Calculate";
            this.calc_bt.UseVisualStyleBackColor = true;
            this.calc_bt.Click += new System.EventHandler(this.calc_bt_Click);
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
            this.groupBox1.Text = "arithmetic ops";
            // 
            // selected_op_lb
            // 
            this.selected_op_lb.AutoSize = true;
            this.selected_op_lb.Location = new System.Drawing.Point(153, 99);
            this.selected_op_lb.Name = "selected_op_lb";
            this.selected_op_lb.Size = new System.Drawing.Size(0, 17);
            this.selected_op_lb.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 300);
            this.Controls.Add(this.selected_op_lb);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.calc_bt);
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
        private System.Windows.Forms.Button calc_bt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label selected_op_lb;
    }
}

