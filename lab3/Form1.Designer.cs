namespace lab3
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
            this.people_lbx = new System.Windows.Forms.ListBox();
            this.addPerson_btn = new System.Windows.Forms.Button();
            this.addMany_btn = new System.Windows.Forms.Button();
            this.editSelected_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // people_lbx
            // 
            this.people_lbx.FormattingEnabled = true;
            this.people_lbx.ItemHeight = 17;
            this.people_lbx.Location = new System.Drawing.Point(13, 13);
            this.people_lbx.Margin = new System.Windows.Forms.Padding(4);
            this.people_lbx.Name = "people_lbx";
            this.people_lbx.Size = new System.Drawing.Size(427, 225);
            this.people_lbx.TabIndex = 0;
            // 
            // addPerson_btn
            // 
            this.addPerson_btn.Location = new System.Drawing.Point(13, 249);
            this.addPerson_btn.Name = "addPerson_btn";
            this.addPerson_btn.Size = new System.Drawing.Size(98, 34);
            this.addPerson_btn.TabIndex = 1;
            this.addPerson_btn.Text = "Add person";
            this.addPerson_btn.UseVisualStyleBackColor = true;
            this.addPerson_btn.Click += new System.EventHandler(this.addPerson_btn_Click);
            // 
            // addMany_btn
            // 
            this.addMany_btn.Location = new System.Drawing.Point(117, 249);
            this.addMany_btn.Name = "addMany_btn";
            this.addMany_btn.Size = new System.Drawing.Size(98, 34);
            this.addMany_btn.TabIndex = 2;
            this.addMany_btn.Text = "Add many";
            this.addMany_btn.UseVisualStyleBackColor = true;
            this.addMany_btn.Click += new System.EventHandler(this.addMany_btn_Click);
            // 
            // editSelected_btn
            // 
            this.editSelected_btn.Location = new System.Drawing.Point(221, 249);
            this.editSelected_btn.Name = "editSelected_btn";
            this.editSelected_btn.Size = new System.Drawing.Size(98, 34);
            this.editSelected_btn.TabIndex = 3;
            this.editSelected_btn.Text = "Edit selected";
            this.editSelected_btn.UseVisualStyleBackColor = true;
            this.editSelected_btn.Click += new System.EventHandler(this.editSelected_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 295);
            this.Controls.Add(this.editSelected_btn);
            this.Controls.Add(this.addMany_btn);
            this.Controls.Add(this.addPerson_btn);
            this.Controls.Add(this.people_lbx);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Lab 3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox people_lbx;
        private System.Windows.Forms.Button addPerson_btn;
        private System.Windows.Forms.Button addMany_btn;
        private System.Windows.Forms.Button editSelected_btn;
    }
}

