using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IDXForm
{
    public partial class Form2 : Form
    {
        /*
         * Form2 is used to get the Key for Encryption.
         * Password is the Key for Encryption.
         * AES algorithm requires key to be 16 byte long(16 chars).
         */
        string password;
        string confirmpswd;
        bool invalidData = false;
        public Form2()
        {
            InitializeComponent();
            passwordText.UseSystemPasswordChar = true;      //Hides the Password.
            confirmText.UseSystemPasswordChar = true;       //Hides the Password.
        }

        public string keyText { get; set; }
        private void button1_Click(object sender, EventArgs e)
        {
            if (passwordText.Text != null)
            {
                password = passwordText.Text;
            }
            else
            {
                MessageBox.Show("Enter the password", "Empty Field");
                invalidData = true;
            }

            if(confirmText.Text != null && !invalidData)
            {
                confirmpswd = confirmText.Text;
            }
            else
            {
                MessageBox.Show("Re-enter the password", "Empty Field");
                invalidData = true;
            }

            if(password != confirmpswd && !invalidData)     //Password and Confirm Password do not match.
            {
                MessageBox.Show("Password and Confirm Password do not match", "Invalid Data");
                invalidData = true;
            }
            else
            {
                if(password.Length != 16 && !invalidData)
                {
                    MessageBox.Show("Password must be of exact 16 characters", "Invalid Format");
                    invalidData = true;
                }
            }

            if(!invalidData)
            {
                keyText = password;
                passwordText.Clear();
                confirmText.Clear();
                this.DialogResult = DialogResult.OK;     
            }
            else
            {
                invalidData = false;
                passwordText.Clear();
                confirmText.Clear();
            }

        }
    }
}
