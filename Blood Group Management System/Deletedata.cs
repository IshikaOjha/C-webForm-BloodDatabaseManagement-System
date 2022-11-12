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
    public partial class Deletedata : Form
    {
        SqlConnection sql = new SqlConnection(@"Data Source = DESKTOP-JHT4G1S; initial catalog = Blood Group; integrated security = True");
        public Deletedata()
        {
            InitializeComponent();
        }

        public void loaddata()
        {
            SqlDataAdapter sda = new SqlDataAdapter("select * from tblAddRecord", sql);
            DataSet ds = new DataSet();
            sda.Fill(ds, "tblAddRecord");
            dataGridView1.DataSource = ds.Tables["tblAddRecord"].DefaultView;
        }

        public void clean()
        {
            idtxt.Text = "";
            nametxt.Text = "";
            agetxt.Text = "";
            addresstxt.Text = "";
            gendercombo.SelectedItem = "";
            bloodgroupcombo.SelectedItem = "";
            idtxt.Focus();
        }
        private void Back_Click(object sender, EventArgs e)
        {

            this.Hide();
            Dashboard dashboard = new Dashboard();
            dashboard.ShowDialog();
        }

        private void Deletedata_Load(object sender, EventArgs e)
        {
            loaddata();
        }

        private void dataGridView1_MouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            idtxt.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            nametxt.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            agetxt.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            addresstxt.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            gendercombo.SelectedItem = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            bloodgroupcombo.SelectedItem = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Delete from tblAddRecord where ID=" + Convert.ToInt32(idtxt.Text) + "", sql);
           // SqlCommand cmd = new SqlCommand("Delete from tblAddRecord where  Name='" + nametxt.Text + "',Age='" + agetxt.Text + "',Address='" + addresstxt.Text + "',Gender='" + gendercombo.SelectedItem + "',BloodGroup='" + bloodgroupcombo.SelectedItem + "' ,' ID=" + Convert.ToInt32(idtxt.Text) + '"", sql);
            sql.Open();
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data is deleted");

            SqlCommand sqlcmd = new SqlCommand("select * from tblAddRecord", sql);

            //SqlDataAdapter sdr = sqlcmd.ExecuteReader();

            sql.Close();
            loaddata();

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            clean();
        }
    }
}
