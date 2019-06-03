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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        HW2_Front.ServiceReference1.WebService1SoapClient service = new HW2_Front.ServiceReference1.WebService1SoapClient();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            service.Post(Form1.idUser, textBoxTitle.Text, textBoxContent.Text);
            MessageBox.Show("Added");
        }
    }
}
