using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace HW2
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {


        SqlConnection myCon = new SqlConnection();


        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public string AddUser(string username, string password)
        {
            string commandText = "INSERT INTO Users (Id, username, password, isAdmin) VALUES (@val0, @val1, @val2, @val3)";
            try
            {
                myCon.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ovi\Desktop\ii\HW2\HW2\App_Data\Database1.mdf;Integrated Security=True";
                myCon.Open();

                //Checking if there is already an user with the same username
                string valString = "SELECT * FROM Users WHERE username = @val0";
                SqlCommand comm1 = new SqlCommand();
                comm1.Connection = myCon;
                comm1.CommandText = valString;
                comm1.Parameters.AddWithValue("@val0", username);
                SqlDataReader sdr = comm1.ExecuteReader();
                if (sdr.Read())
                {
                    return "Username already exists";
                }
                sdr.Close();

                //Next id
                int lastId;
                SqlCommand IdCommand = new SqlCommand("SELECT MAX(id) FROM Users", myCon);
                lastId = (int)IdCommand.ExecuteScalar();
                SqlCommand comm = new SqlCommand();
                comm.Connection = myCon;
                comm.CommandText = commandText;
                comm.Parameters.AddWithValue("@val0", lastId + 1);
                comm.Parameters.AddWithValue("@val1", username);
                comm.Parameters.AddWithValue("@val2", password);
                comm.Parameters.AddWithValue("@val3", 0);



                comm.ExecuteNonQuery();
                myCon.Close();
                return "Succesfully registered";
            }
            catch (SqlException xe)
            {
                myCon.Close();
                return xe.ToString();
            }
            
        }

        [WebMethod]
        public int Signin(string username, string password, ref int id, ref int isAdmin)
        {

            myCon.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ovi\Desktop\ii\HW2\HW2\App_Data\Database1.mdf;Integrated Security=True";
            myCon.Open();
            string valString = "SELECT * FROM Users WHERE username = @val0 AND password = @val1";
            SqlCommand comm = new SqlCommand();
            comm.Connection = myCon;
            comm.CommandText = valString;
            comm.Parameters.AddWithValue("@val0", username);
            comm.Parameters.AddWithValue("@val1", password);
            SqlDataReader sdr = comm.ExecuteReader();
            

            if (sdr.Read())
            {
                sdr.Close();
                SqlCommand IdCommand = new SqlCommand("SELECT id FROM Users WHERE username = '" + username + "'", myCon);
                int lastId = (int)IdCommand.ExecuteScalar();
                SqlCommand Admin = new SqlCommand("SELECT isAdmin FROM Users WHERE username = '" + username + "'", myCon);
                int IsAdmin = (int)Admin.ExecuteScalar();
                myCon.Close();
                isAdmin = IsAdmin;
                id = lastId;
                return lastId;
            }
            else
                return 0;
        }
        [WebMethod]
        public bool Post(int idUser, string title, string content)
        {
            string commandText = "INSERT INTO Posts (Id, Title, Content, idUser) VALUES (@val0, @val1, @val2, @val3)";
            try
            {
                myCon.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ovi\Desktop\ii\HW2\HW2\App_Data\Database1.mdf;Integrated Security=True";
                myCon.Open();
                int lastId;
                SqlCommand IdCommand = new SqlCommand("SELECT MAX(id) FROM Posts", myCon);
                lastId = (int)IdCommand.ExecuteScalar();
                SqlCommand comm = new SqlCommand();
                comm.Connection = myCon;
                comm.CommandText = commandText;
                comm.Parameters.AddWithValue("@val0", lastId + 1);
                comm.Parameters.AddWithValue("@val1", title);
                comm.Parameters.AddWithValue("@val2", content);
                comm.Parameters.AddWithValue("@val3", idUser);
                //comm.CommandText = "INSERT INTO Universitati (NameUniv, City, Code) VALUES (" +
                //    textBox_AddUniv.ToString() + ", " + textBox_AddCity.ToString() + ", " + textBox_AddCode.ToString() + ")";

                comm.ExecuteNonQuery();
                myCon.Close();
                return true;
            }
            catch (SqlException xe)
            {
                myCon.Close();
                return false;
            }
        }

        [WebMethod]
        public DataSet Load()
        {

            myCon.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ovi\Desktop\ii\HW2\HW2\App_Data\Database1.mdf;Integrated Security=True";
            myCon.Open();
            DataSet dsPosts = new DataSet();
            SqlDataAdapter daPosts = new SqlDataAdapter("SELECT * FROM Posts", myCon);
            daPosts.Fill(dsPosts, "Posts");
            myCon.Close();
            return dsPosts;
        }
        [WebMethod]
        public string postedBy(string title)
        {
            myCon.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ovi\Desktop\ii\HW2\HW2\App_Data\Database1.mdf;Integrated Security=True";
            myCon.Open();
            SqlCommand IdCommand = new SqlCommand("SELECT idUser FROM Posts WHERE Title = '" + title + "'", myCon);
            int lastId = (int)IdCommand.ExecuteScalar();
            SqlCommand IdCommand2 = new SqlCommand("SELECT username FROM Users WHERE id = '" + lastId + "'", myCon);
            string user = IdCommand2.ExecuteScalar().ToString();
            myCon.Close();
            return user;
            
        }

        [WebMethod]
        public bool DeletePost(string title)
        {
            myCon.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ovi\Desktop\ii\HW2\HW2\App_Data\Database1.mdf;Integrated Security=True";
            myCon.Open();
            try
            {
                string commandText = "DELETE FROM Posts WHERE Title = @val0";
                SqlCommand comm = new SqlCommand();
                comm.Connection = myCon;
                comm.CommandText = commandText;
                comm.Parameters.AddWithValue("@val0", title);
                comm.ExecuteNonQuery();
                myCon.Close();
                return true;
            }
            catch(Exception e)
            {
                return false;
            }

        }

        [WebMethod]
        public bool MakeAdmin(string username)
        {
            myCon.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ovi\Desktop\ii\HW2\HW2\App_Data\Database1.mdf;Integrated Security=True";
            myCon.Open();
            try
            {
                string commandText = "UPDATE Users SET isAdmin = 1 WHERE username = @val0";
                SqlCommand comm = new SqlCommand();
                comm.Connection = myCon;
                comm.CommandText = commandText;
                comm.Parameters.AddWithValue("@val0", username);
                comm.ExecuteNonQuery();
                myCon.Close();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }

        }

    }
}
