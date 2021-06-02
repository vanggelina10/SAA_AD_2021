
namespace SAA_AD_2021
{
    partial class FormInvoice
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
            this.label9 = new System.Windows.Forms.Label();
            this.tboxname = new System.Windows.Forms.TextBox();
            this.tboxno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.tboxVA = new System.Windows.Forms.TextBox();
            this.tboxtotal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnhowtopay = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(328, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(146, 46);
            this.label9.TabIndex = 28;
            this.label9.Text = "Invoice";
            // 
            // tboxname
            // 
            this.tboxname.Location = new System.Drawing.Point(274, 157);
            this.tboxname.Name = "tboxname";
            this.tboxname.Size = new System.Drawing.Size(254, 26);
            this.tboxname.TabIndex = 32;
            // 
            // tboxno
            // 
            this.tboxno.Location = new System.Drawing.Point(274, 96);
            this.tboxno.Name = "tboxno";
            this.tboxno.Size = new System.Drawing.Size(254, 26);
            this.tboxno.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 30;
            this.label1.Text = "Name";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(112, 96);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(33, 20);
            this.labelEmail.TabIndex = 29;
            this.labelEmail.Text = "No.";
            // 
            // tboxVA
            // 
            this.tboxVA.Location = new System.Drawing.Point(274, 281);
            this.tboxVA.Name = "tboxVA";
            this.tboxVA.Size = new System.Drawing.Size(254, 26);
            this.tboxVA.TabIndex = 36;
            // 
            // tboxtotal
            // 
            this.tboxtotal.Location = new System.Drawing.Point(274, 220);
            this.tboxtotal.Name = "tboxtotal";
            this.tboxtotal.Size = new System.Drawing.Size(254, 26);
            this.tboxtotal.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 281);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 20);
            this.label2.TabIndex = 34;
            this.label2.Text = "Virtual Account";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(112, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 33;
            this.label3.Text = "Total";
            // 
            // btnhowtopay
            // 
            this.btnhowtopay.Location = new System.Drawing.Point(116, 361);
            this.btnhowtopay.Name = "btnhowtopay";
            this.btnhowtopay.Size = new System.Drawing.Size(123, 37);
            this.btnhowtopay.TabIndex = 37;
            this.btnhowtopay.Text = "How to Pay?";
            this.btnhowtopay.UseVisualStyleBackColor = true;
            this.btnhowtopay.Click += new System.EventHandler(this.btnhowtopay_Click);
            // 
            // btnback
            // 
            this.btnback.Location = new System.Drawing.Point(300, 361);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(123, 37);
            this.btnback.TabIndex = 38;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // FormInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 580);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btnhowtopay);
            this.Controls.Add(this.tboxVA);
            this.Controls.Add(this.tboxtotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tboxname);
            this.Controls.Add(this.tboxno);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.label9);
            this.Name = "FormInvoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormInvoice";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tboxname;
        private System.Windows.Forms.TextBox tboxno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox tboxVA;
        private System.Windows.Forms.TextBox tboxtotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnhowtopay;
        private System.Windows.Forms.Button btnback;
    }
}