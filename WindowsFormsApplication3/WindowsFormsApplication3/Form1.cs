using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_strings_Click(object sender, EventArgs e)
        {
            string firstName;
            string messageText;
            messageText = "your name is ";
            firstName = textBox1.Text;
            //MessageBox.Show(messageText + firstName);
            TextMessage.Text = messageText + firstName;
            textBox2.Text = messageText + firstName;
        }
    }
}
