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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nameVal = name.Text;
            string surnameVal = surname.Text;
            string genderVal = gender.Text.StartsWith("K") ? "Kişi" : "Qadın";
            string usernameVal = username.Text;

            //var sha=SHA256.Create();
            //var byteArr = Encoding.Default.GetBytes(password.Text);
            //var shaExample = sha.ComputeHash(byteArr);

            //string passwordVal = Convert.ToBase64String(shaExample);

            string passwordVal=SqlHelper.HashPassword(password.Text);


            var result = SqlHelper.Execute($"INSERT INTO Users VALUES (N'{nameVal}',N'{surnameVal}',N'{genderVal}','{usernameVal}','{passwordVal}')");
            if (result == 0)
            {
                MessageBox.Show("Xəta baş verdi");
            }
            else
            {
                MessageBox.Show("Uğurla qeydiyyatdan keçirildi");
            }
        }
    }
}
