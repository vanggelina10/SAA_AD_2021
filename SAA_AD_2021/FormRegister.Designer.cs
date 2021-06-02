
namespace SAA_AD_2021
{
    partial class FormRegister
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
            this.tboxusername = new System.Windows.Forms.TextBox();
            this.tboxfullname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.tboxphoneno = new System.Windows.Forms.TextBox();
            this.tboxemail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tboxconfirm = new System.Windows.Forms.TextBox();
            this.tboxpassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnback = new System.Windows.Forms.Button();
            this.btnregister = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tboxusername
            // 
            this.tboxusername.Location = new System.Drawing.Point(322, 121);
            this.tboxusername.Name = "tboxusername";
            this.tboxusername.Size = new System.Drawing.Size(217, 26);
            this.tboxusername.TabIndex = 8;
            // 
            // tboxfullname
            // 
            this.tboxfullname.Location = new System.Drawing.Point(322, 37);
            this.tboxfullname.Name = "tboxfullname";
            this.tboxfullname.Size = new System.Drawing.Size(217, 26);
            this.tboxfullname.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(318, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Username";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(318, 13);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(80, 20);
            this.labelEmail.TabIndex = 5;
            this.labelEmail.Text = "Full Name";
            // 
            // tboxphoneno
            // 
            this.tboxphoneno.Location = new System.Drawing.Point(322, 278);
            this.tboxphoneno.Name = "tboxphoneno";
            this.tboxphoneno.Size = new System.Drawing.Size(217, 26);
            this.tboxphoneno.TabIndex = 12;
            // 
            // tboxemail
            // 
            this.tboxemail.Location = new System.Drawing.Point(322, 194);
            this.tboxemail.Name = "tboxemail";
            this.tboxemail.Size = new System.Drawing.Size(217, 26);
            this.tboxemail.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(318, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Phone Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(318, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "email";
            // 
            // tboxconfirm
            // 
            this.tboxconfirm.Location = new System.Drawing.Point(322, 431);
            this.tboxconfirm.Name = "tboxconfirm";
            this.tboxconfirm.Size = new System.Drawing.Size(217, 26);
            this.tboxconfirm.TabIndex = 16;
            this.tboxconfirm.UseSystemPasswordChar = true;
            // 
            // tboxpassword
            // 
            this.tboxpassword.Location = new System.Drawing.Point(322, 347);
            this.tboxpassword.Name = "tboxpassword";
            this.tboxpassword.Size = new System.Drawing.Size(217, 26);
            this.tboxpassword.TabIndex = 15;
            this.tboxpassword.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(318, 395);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Confirm Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(318, 323);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Password";
            // 
            // btnback
            // 
            this.btnback.Location = new System.Drawing.Point(322, 479);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(90, 32);
            this.btnback.TabIndex = 17;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // btnregister
            // 
            this.btnregister.Location = new System.Drawing.Point(449, 479);
            this.btnregister.Name = "btnregister";
            this.btnregister.Size = new System.Drawing.Size(90, 32);
            this.btnregister.TabIndex = 18;
            this.btnregister.Text = "Register";
            this.btnregister.UseVisualStyleBackColor = true;
            this.btnregister.Click += new System.EventHandler(this.btnregister_Click);
            // 
            // FormRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 580);
            this.Controls.Add(this.btnregister);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.tboxconfirm);
            this.Controls.Add(this.tboxpassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tboxphoneno);
            this.Controls.Add(this.tboxemail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tboxusername);
            this.Controls.Add(this.tboxfullname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelEmail);
            this.Name = "FormRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormRegister";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tboxusername;
        private System.Windows.Forms.TextBox tboxfullname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox tboxphoneno;
        private System.Windows.Forms.TextBox tboxemail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tboxconfirm;
        private System.Windows.Forms.TextBox tboxpassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Button btnregister;
    }
}