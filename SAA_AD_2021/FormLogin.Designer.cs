
namespace SAA_AD_2021
{
    partial class FormLogin
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
            this.btnlogin = new System.Windows.Forms.Button();
            this.labelEmail = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tboxusername = new System.Windows.Forms.TextBox();
            this.tboxpassword = new System.Windows.Forms.TextBox();
            this.btnsignup = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnlogin
            // 
            this.btnlogin.Location = new System.Drawing.Point(192, 303);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(121, 42);
            this.btnlogin.TabIndex = 3;
            this.btnlogin.Text = "Login";
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(188, 105);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(83, 20);
            this.labelEmail.TabIndex = 1;
            this.labelEmail.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(188, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Password";
            // 
            // tboxusername
            // 
            this.tboxusername.Location = new System.Drawing.Point(192, 129);
            this.tboxusername.Name = "tboxusername";
            this.tboxusername.Size = new System.Drawing.Size(217, 26);
            this.tboxusername.TabIndex = 1;
            // 
            // tboxpassword
            // 
            this.tboxpassword.Location = new System.Drawing.Point(192, 213);
            this.tboxpassword.Name = "tboxpassword";
            this.tboxpassword.Size = new System.Drawing.Size(217, 26);
            this.tboxpassword.TabIndex = 2;
            this.tboxpassword.UseSystemPasswordChar = true;
            // 
            // btnsignup
            // 
            this.btnsignup.Location = new System.Drawing.Point(376, 303);
            this.btnsignup.Name = "btnsignup";
            this.btnsignup.Size = new System.Drawing.Size(121, 42);
            this.btnsignup.TabIndex = 5;
            this.btnsignup.Text = "Sign Up";
            this.btnsignup.UseVisualStyleBackColor = true;
            this.btnsignup.Click += new System.EventHandler(this.btnsignup_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(200, 348);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(300, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "*Sign up first if you don\'t have an account";
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 580);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnsignup);
            this.Controls.Add(this.tboxpassword);
            this.Controls.Add(this.tboxusername);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.btnlogin);
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tboxusername;
        private System.Windows.Forms.TextBox tboxpassword;
        private System.Windows.Forms.Button btnsignup;
        private System.Windows.Forms.Label label2;
    }
}

