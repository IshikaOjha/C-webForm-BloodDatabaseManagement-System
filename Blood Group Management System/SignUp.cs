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
    public partial class SignUp : Form
    {
        SqlConnection sql = new SqlConnection(@"Data Source = DESKTOP-JHT4G1S; initial catalog = Blood Group; integrated security = True");
        public SignUp()
        {
            InitializeComponent();
        }

        private int GetUserId()
        {
            sql.Open();

            var cmm = "select max(id)+1 from tbllogin";

            SqlCommand cmd = new SqlCommand(cmm, sql);
            var newId = cmd.ExecuteScalar();

            sql.Close();

            return Convert.ToInt32(newId);
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            sql.Open();
            var cmd = new SqlCommand("insert into tbllogin (id,username,password) values ('" + idtxt.Text + "','" + usernametxt.Text + "','" + passwordtxt.Text + "')", sql);
            cmd.ExecuteNonQuery();
            MessageBox.Show("you created new ID successfully");

            SqlCommand sqlcmd = new SqlCommand("select * from tbllogin", sql);
            SqlDataReader sdr = sqlcmd.ExecuteReader();
            sql.Close();
            this.Hide();
            Login lg = new Login();
            lg.ShowDialog();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            idtxt.Text = GetUserId().ToString();
        }
    }
}
