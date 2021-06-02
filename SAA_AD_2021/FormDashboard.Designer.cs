
namespace SAA_AD_2021
{
    partial class FormDashboard
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
            this.btnBooking = new System.Windows.Forms.Button();
            this.btnstorage = new System.Windows.Forms.Button();
            this.btnContactus = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnpurchase = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBooking
            // 
            this.btnBooking.Location = new System.Drawing.Point(254, 146);
            this.btnBooking.Name = "btnBooking";
            this.btnBooking.Size = new System.Drawing.Size(276, 61);
            this.btnBooking.TabIndex = 0;
            this.btnBooking.Text = "Booking Now";
            this.btnBooking.UseVisualStyleBackColor = true;
            this.btnBooking.Click += new System.EventHandler(this.btnBooking_Click);
            // 
            // btnstorage
            // 
            this.btnstorage.Location = new System.Drawing.Point(254, 225);
            this.btnstorage.Name = "btnstorage";
            this.btnstorage.Size = new System.Drawing.Size(276, 61);
            this.btnstorage.TabIndex = 1;
            this.btnstorage.Text = "Store Unit & Price";
            this.btnstorage.UseVisualStyleBackColor = true;
            this.btnstorage.Click += new System.EventHandler(this.btnstorage_Click);
            // 
            // btnContactus
            // 
            this.btnContactus.Location = new System.Drawing.Point(254, 304);
            this.btnContactus.Name = "btnContactus";
            this.btnContactus.Size = new System.Drawing.Size(276, 61);
            this.btnContactus.TabIndex = 2;
            this.btnContactus.Text = "Contact Us";
            this.btnContactus.UseVisualStyleBackColor = true;
            this.btnContactus.Click += new System.EventHandler(this.btnContactus_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(106, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(587, 46);
            this.label1.TabIndex = 3;
            this.label1.Text = "Welcome To Rental Warehouse";
            // 
            // btnpurchase
            // 
            this.btnpurchase.Location = new System.Drawing.Point(254, 389);
            this.btnpurchase.Name = "btnpurchase";
            this.btnpurchase.Size = new System.Drawing.Size(276, 61);
            this.btnpurchase.TabIndex = 4;
            this.btnpurchase.Text = "Purchase History";
            this.btnpurchase.UseVisualStyleBackColor = true;
            this.btnpurchase.Click += new System.EventHandler(this.btnpurchase_Click);
            // 
            // FormDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 580);
            this.Controls.Add(this.btnpurchase);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnContactus);
            this.Controls.Add(this.btnstorage);
            this.Controls.Add(this.btnBooking);
            this.Name = "FormDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBooking;
        private System.Windows.Forms.Button btnstorage;
        private System.Windows.Forms.Button btnContactus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnpurchase;
    }
}