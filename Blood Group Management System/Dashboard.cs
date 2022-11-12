using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blood_Group_Management_System
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void viewbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            View view = new View();
            view.ShowDialog();
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddRecord addRecord = new AddRecord();
            addRecord.ShowDialog();
        }

       

        private void searchbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            search search = new search();
            search.ShowDialog();

        }

        private void editbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Edit edit = new Edit();
            edit.ShowDialog();
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Deletedata delete = new Deletedata();
            delete.ShowDialog();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
        }
    }
}
