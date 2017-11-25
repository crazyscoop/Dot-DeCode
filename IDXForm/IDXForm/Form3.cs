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
    
    public partial class Form3 : Form
    {
        /*
         * Form3 is used to get Key for Decryption.
         * 16 byte Password is the Key for Decryption.
         */
        public string keyD { get; set; }

        public Form3()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {

            Form1 form1 = new Form1();
            if(passwordTextbox.Text.Length != 16)       //Checks if Password is 16 Char.
            {
                MessageBox.Show("Password Invalid Length", "Error");
            }
            else
            {
                keyD = passwordTextbox.Text;
                this.DialogResult = DialogResult.OK;
            } 
        }

    }
}
