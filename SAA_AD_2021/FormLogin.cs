﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SAA_AD_2021
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
        MySqlConnection sqlConnect;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        string sqlQuery;
        string connectString = "server=localhost;uid=root;pwd=;database=kuyrental;";
        private void btnsignup_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormRegister signup = new FormRegister();
            signup.ShowDialog();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
           
            sqlConnect = new MySqlConnection(connectString);
            string username = tboxusername.Text;
            string password = tboxpassword.Text;
            DataTable dtlogin = new DataTable();
            sqlQuery = "SELECT * FROM `pengguna` WHERE `user_name`=@user AND `user_password`=@pass";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlCommand.Parameters.Add("@user", MySqlDbType.VarChar).Value = username;
            sqlCommand.Parameters.Add("@pass", MySqlDbType.VarChar).Value = password;
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.SelectCommand = sqlCommand;
           
            sqlAdapter.Fill(dtlogin);
           //Mengecek user ada apa tidak
            if(dtlogin.Rows.Count>0)
            {
                MessageBox.Show("Your Login is Succeed!", "Welcome to Kuyrental", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.Hide();
                FormDashboard dash = new FormDashboard();
                dash.ShowDialog();
              
            }
            else
            {  
                if (tboxusername.Text == "" && tboxpassword.Text == "")
                {
                    MessageBox.Show("Enter Your  Username and Password to Login!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
               else if (tboxusername.Text == "")
                {
                    MessageBox.Show("Enter Your Username to Login!","Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (tboxpassword.Text == "")
                {
                    MessageBox.Show("Enter Your Password to Login!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
              
                else
                {
                    MessageBox.Show("Wrong Your Username or Password to Login!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
           
            
        }
    }
}
