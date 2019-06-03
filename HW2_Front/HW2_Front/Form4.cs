using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW2_Front
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            textBoxPassword.PasswordChar = '*';
        }
        HW2_Front.ServiceReference1.WebService1SoapClient service = new HW2_Front.ServiceReference1.WebService1SoapClient();

        private void butonReg_Click(object sender, EventArgs e)
        {

            MessageBox.Show(service.AddUser(textBoxUser.Text, Form1.MD5Hash(textBoxPassword.Text)));
            
        }
    }
}
