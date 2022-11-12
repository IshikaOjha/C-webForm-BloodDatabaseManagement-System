using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blood_Group_Management_System
{
    public partial class Login : Form
    {
         SqlConnection sql = new SqlConnection(@"Data Source = DESKTOP-JHT4G1S; initial catalog = Blood Group; integrated security = True");
        public Login()
        {
            InitializeComponent();
        }

        private void signupbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUp sgu = new SignUp();
            sgu.ShowDialog();
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {

            var username = usertxt.Text;
            var password = passwordtxt.Text;
            sql.Open();
            SqlCommand sqlCommand = new SqlCommand("Select * from tbllogin where username = '" + username + "' and password ='" + password + "'", sql);
            SqlDataReader sdr = sqlCommand.ExecuteReader();
            if (sdr.HasRows)
            {
                MessageBox.Show("Login Successful");
                this.Hide();
                Dashboard dbs = new Dashboard();
                dbs.ShowDialog();
            }
            else
            {
                MessageBox.Show("Invalied Username/Password");
                usertxt.Text = "";
                passwordtxt.Text = "";
            }
            sql.Close();

           

        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
