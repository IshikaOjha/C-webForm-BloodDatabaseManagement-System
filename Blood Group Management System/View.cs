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
    public partial class View : Form
    {
        SqlConnection sql = new SqlConnection(@"Data Source = DESKTOP-JHT4G1S; initial catalog = Blood Group; integrated security = True");
        public View()
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


        private void View_Load(object sender, EventArgs e)
        {
            loaddata();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard dashboard = new Dashboard();
            dashboard.ShowDialog();
        }
    }
}
