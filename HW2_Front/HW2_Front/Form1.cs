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

namespace HW2_Front
{
    public partial class Form1 : Form
    {
        public static int idUser = 0;
        private int isAdmin = 0;
        HW2_Front.ServiceReference1.WebService1SoapClient service = new HW2_Front.ServiceReference1.WebService1SoapClient();
        public Form1()
        {
            InitializeComponent();
            textBoxPassword.PasswordChar = '*';
        }

        public static string MD5Hash(string input)
        {
            StringBuilder hash = new StringBuilder();
            MD5CryptoServiceProvider md5provider = new MD5CryptoServiceProvider();
            byte[] bytes = md5provider.ComputeHash(new UTF8Encoding().GetBytes(input));

            for (int i = 0; i < bytes.Length; i++)
            {
                hash.Append(bytes[i].ToString("x2"));
            }
            return hash.ToString();
        }

        private void butonSignin_Click(object sender, EventArgs e)
        {
            if (service.Signin(textBoxUser.Text, MD5Hash(textBoxPassword.Text), ref idUser, ref isAdmin)!=0)
            {
                
                Form2.getInstance().Show();
            }
            else
            {
                MessageBox.Show("Wrong username/password");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonReg_Click(object sender, EventArgs e)
        {
            Form4 f = new Form4();
            f.Show();
        }

        private void buttonAdmin_Click(object sender, EventArgs e)
        {
            if (service.Signin(textBoxUser.Text, MD5Hash(textBoxPassword.Text), ref idUser, ref isAdmin) != 0)
            {
                if (isAdmin != 1)
                {
                    MessageBox.Show("Not an admin");
                }
                else
                {
                    Form5 f = new Form5();
                    f.Show();
                }
            }
        }
    }
}
