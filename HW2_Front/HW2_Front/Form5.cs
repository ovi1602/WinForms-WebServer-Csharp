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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        HW2_Front.ServiceReference1.WebService1SoapClient service = new HW2_Front.ServiceReference1.WebService1SoapClient();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void butonDelete_Click(object sender, EventArgs e)
        {
            service.DeletePost(textBoxTitle.Text);
            MessageBox.Show("Message deleted");
        }

        private void buttonMakeAdmin_Click(object sender, EventArgs e)
        {
            service.MakeAdmin(textBoxUsername.Text);
            MessageBox.Show("User made admin");
        }
    }
}
