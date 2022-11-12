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
    public partial class search : Form
    {
        SqlConnection sql = new SqlConnection(@"Data Source = DESKTOP-JHT4G1S; initial catalog = Blood Group; integrated security = True");
        public search()
        {
            InitializeComponent();
        }

        private void search_Load(object sender, EventArgs e)
        {
            loaddata();
        }

        DataTable dt ;

        public void loaddata()
        {
            SqlCommand cmd = new SqlCommand("select * from tblAddRecord", sql);
            dt = new DataTable();

            sql.Open();

            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            sql.Close();

            dataGridView1.DataSource = dt;
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataView dv = new DataView(dt);
            dv.RowFilter = string.Format("BloodGroup LIKE '%{0}%'", comboBox1.SelectedItem);
            
            dataGridView1.DataSource = dv;
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard dbs = new Dashboard();
            dbs.ShowDialog();
        
        }

        
    }
}
