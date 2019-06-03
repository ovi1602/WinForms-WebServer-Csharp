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
    public partial class Form2 : Form
    {
        //Using Singleton Design Pattern in order to have a unique edit window
        private static Form2 f;
        private Form2()
        {
            InitializeComponent();
            Load2();
        }

        public static Form2 getInstance()
        {
            try
            {
                if (f == null)
                    f = new Form2();
                return f;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        //Setting the form to null every time the window is closed so that the app doesn't crash due to singleton

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            //MessageBox.Show("Closed");
            Form2.f = null;
        }




        HW2_Front.ServiceReference1.WebService1SoapClient service = new HW2_Front.ServiceReference1.WebService1SoapClient();

        public void Load2()
        {
   
            DataSet dsPosts = new DataSet();
            dsPosts = service.Load();
          
            foreach (DataRow dr in dsPosts.Tables["Posts"].Rows)
            {
                
                String name = dr.ItemArray.GetValue(1).ToString();
                listBoxTitle.Items.Add(name);
            }
        }

        private void listBoxTitle_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //listBoxTitle.Items.Clear();
                listBoxContent.Items.Clear();
                int code = 0;
                DataSet dsPosts = new DataSet();
                dsPosts = service.Load();
                string TitleSelected;
                TitleSelected = listBoxTitle.SelectedItem.ToString();
                foreach (DataRow dr in dsPosts.Tables["Posts"].Rows)
                {
                    if (TitleSelected == dr.ItemArray.GetValue(1).ToString())
                    {
                        string content = dr.ItemArray.GetValue(2).ToString();
                        listBoxContent.Items.Add(content);
                    }
                }
                textBoxPostedBy.Text = service.postedBy(TitleSelected);
            }
            catch(Exception xe)
            {
                Console.WriteLine(xe);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.Show();
        }

        private void buttonR_Click(object sender, EventArgs e)
        {
            listBoxTitle.Items.Clear();
            listBoxContent.Items.Clear();
            Load2();
        }
    }
}
