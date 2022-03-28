namespace lab3
{
    partial class AddManyPeopleForm
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
            this.close_btn = new System.Windows.Forms.Button();
            this.add_btn = new System.Windows.Forms.Button();
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
            // close_btn
            // 
            this.close_btn.Location = new System.Drawing.Point(120, 153);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(73, 29);
            this.close_btn.TabIndex = 29;
            this.close_btn.Text = "Close";
            this.close_btn.UseVisualStyleBackColor = true;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(16, 153);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(73, 29);
            this.add_btn.TabIndex = 28;
            this.add_btn.Text = "Add";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // residence_txb
            // 
            this.residence_txb.Location = new System.Drawing.Point(93, 100);
            this.residence_txb.Name = "residence_txb";
            this.residence_txb.Size = new System.Drawing.Size(100, 23);
            this.residence_txb.TabIndex = 27;
            this.residence_txb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyCharsValidation);
            // 
            // birthdate_txb
            // 
            this.birthdate_txb.Location = new System.Drawing.Point(93, 71);
            this.birthdate_txb.Name = "birthdate_txb";
            this.birthdate_txb.Size = new System.Drawing.Size(100, 23);
            this.birthdate_txb.TabIndex = 26;
            this.birthdate_txb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BirthDateValidation);
            // 
            // surname_txb
            // 
            this.surname_txb.Location = new System.Drawing.Point(93, 42);
            this.surname_txb.Name = "surname_txb";
            this.surname_txb.Size = new System.Drawing.Size(100, 23);
            this.surname_txb.TabIndex = 25;
            this.surname_txb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyCharsValidation);
            // 
            // name_txb
            // 
            this.name_txb.Location = new System.Drawing.Point(93, 13);
            this.name_txb.Name = "name_txb";
            this.name_txb.Size = new System.Drawing.Size(100, 23);
            this.name_txb.TabIndex = 24;
            this.name_txb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyCharsValidation);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 103);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 23;
            this.label4.Text = "residence:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 74);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 22;
            this.label3.Text = "birthdate:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 45);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "surname:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "name:";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // AddManyPeopleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(207, 195);
            this.Controls.Add(this.close_btn);
            this.Controls.Add(this.add_btn);
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
            this.Name = "AddManyPeopleForm";
            this.Text = "Add people";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button close_btn;
        private System.Windows.Forms.Button add_btn;
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