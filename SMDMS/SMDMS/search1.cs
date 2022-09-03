using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace SMDMS
{
    public partial class search1 : Form
    {
        public search1()
        {
            InitializeComponent();
        }
        OleDbConnection con;
        OleDbDataAdapter ad;
        DataSet ds;

        private void search1_Load(object sender, EventArgs e)
        {
            con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\Database6.accdb");
            ad = new OleDbDataAdapter("select * from Student", con);

            showdata();

        }
        void showdata()
        {
            ds = new DataSet();
            ad.Fill(ds, "demo");
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
     
        }

    }
}