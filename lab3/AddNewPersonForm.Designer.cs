namespace lab3
{
    partial class AddNewPersonForm
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
            this.components = new System.ComponentModel.Container();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.ok_btn = new System.Windows.Forms.Button();
            this.residence_txb = new System.Windows.Forms.TextBox();
            this.birthdate_txb = new System.Windows.Forms.TextBox();
            this.surname_txb = new System.Windows.Forms.TextBox();
            this.name_txb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // cancel_btn
            // 
            this.cancel_btn.Location = new System.Drawing.Point(120, 153);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(73, 29);
            this.cancel_btn.TabIndex = 19;
            this.cancel_btn.Text = "Cancel";
            this.cancel_btn.UseVisualStyleBackColor = true;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // ok_btn
            // 
            this.ok_btn.Location = new System.Drawing.Point(16, 153);
            this.ok_btn.Name = "ok_btn";
            this.ok_btn.Size = new System.Drawing.Size(73, 29);
            this.ok_btn.TabIndex = 18;
            this.ok_btn.Text = "OK";
            this.ok_btn.UseVisualStyleBackColor = true;
            this.ok_btn.Click += new System.EventHandler(this.ok_btn_Click);
            // 
            // residence_txb
            // 
            this.residence_txb.Location = new System.Drawing.Point(93, 100);
            this.residence_txb.Name = "residence_txb";
            this.residence_txb.Size = new System.Drawing.Size(100, 23);
            this.residence_txb.TabIndex = 17;
            this.residence_txb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyCharsValidation);
            // 
            // birthdate_txb
            // 
            this.birthdate_txb.Location = new System.Drawing.Point(93, 71);
            this.birthdate_txb.Name = "birthdate_txb";
            this.birthdate_txb.Size = new System.Drawing.Size(100, 23);
            this.birthdate_txb.TabIndex = 16;
            this.birthdate_txb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BirthDateValidation);
            // 
            // surname_txb
            // 
            this.surname_txb.Location = new System.Drawing.Point(93, 42);
            this.surname_txb.Name = "surname_txb";
            this.surname_txb.Size = new System.Drawing.Size(100, 23);
            this.surname_txb.TabIndex = 15;
            this.surname_txb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyCharsValidation);
            // 
            // name_txb
            // 
            this.name_txb.Location = new System.Drawing.Point(93, 13);
            this.name_txb.Name = "name_txb";
            this.name_txb.Size = new System.Drawing.Size(100, 23);
            this.name_txb.TabIndex = 14;
            this.name_txb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyCharsValidation);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 103);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "residence:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 74);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "birthdate:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 45);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "surname:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "name:";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // AddNewPersonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(214, 195);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.ok_btn);
            this.Controls.Add(this.residence_txb);
            this.Controls.Add(this.birthdate_txb);
            this.Controls.Add(this.surname_txb);
            this.Controls.Add(this.name_txb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddNewPersonForm";
            this.Text = "Add person";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.Button ok_btn;
        private System.Windows.Forms.TextBox residence_txb;
        private System.Windows.Forms.TextBox birthdate_txb;
        private System.Windows.Forms.TextBox surname_txb;
        private System.Windows.Forms.TextBox name_txb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}