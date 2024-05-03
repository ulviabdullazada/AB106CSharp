using AdoNET.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdoNET
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var data = SqlHelper.ExecuteQuery($"SELECT Id FROM Users WHERE Username='{username.Text}' and Password='{SqlHelper.HashPassword(password.Text)}'   ");
            if (data.Rows.Count > 0)
            {
                MessageBox.Show("Xoş gəldiniz");
            }
            else
            {
                MessageBox.Show("İstifadəçi adı və ya parolu yalnışdır.");
            }
        }

        private void registerHref_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register register = new Register();
            this.Hide();
            register.Show();
        }
    }
}
