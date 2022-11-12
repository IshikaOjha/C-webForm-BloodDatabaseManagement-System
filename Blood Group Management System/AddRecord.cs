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
    public partial class AddRecord : Form
    {
        SqlConnection sql = new SqlConnection(@"Data Source = DESKTOP-JHT4G1S; initial catalog = Blood Group; integrated security = True");
        public AddRecord()
        {
            InitializeComponent();
        }

        private int GetUserId()
        {
            sql.Open();

            var cmm = "select max(id)+1 from tblAddRecord";

            SqlCommand cmd = new SqlCommand(cmm, sql);
            var newId = cmd.ExecuteScalar();

            sql.Close();

            return Convert.ToInt32(newId);
        }

        public void loaddata()
        {
            SqlDataAdapter sda = new SqlDataAdapter("select * from tblAddRecord", sql);
            DataSet ds = new DataSet();
            sda.Fill(ds, "tblAddRecord");
            dataGridView1.DataSource = ds.Tables["tblAddRecord"].DefaultView;
        }

        public void clear()
        {
            idtxt.Text= "";
            nametxt.Text= "";
            agetxt.Text= "";
            addresstxt.Text= "";
            gendercombo.SelectedItem= "";
            bloodgrpcombo.SelectedItem = "";
            idtxt.Focus();
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            sql.Open();
            var cmd = new SqlCommand("insert into tblAddRecord(ID,Name,Age,Address,Gender,BloodGroup) values('" + Convert.ToInt32(idtxt.Text) + "','" + nametxt.Text + "','" + agetxt.Text + "','" + addresstxt.Text + "','" + gendercombo.SelectedItem + "','" + bloodgrpcombo.SelectedItem + "')", sql);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data saved successfully");

            SqlCommand sqlcmd = new SqlCommand("select * from tblAddRecord", sql);
            
            SqlDataReader sdr = sqlcmd.ExecuteReader();
            sql.Close();
            loaddata();
        }

        private void AddRecord_Load(object sender, EventArgs e)
        {
            idtxt.Text = GetUserId().ToString();
            loaddata();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard dashboard = new Dashboard();
            dashboard.ShowDialog();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            clear();
            idtxt.Text = GetUserId().ToString();
        }
    }
}
