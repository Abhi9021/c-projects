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
    public partial class new11 : Form
    {
        public new11()
        {
            InitializeComponent();
        }
        OleDbConnection con;
        OleDbCommand cmd;
        OleDbDataAdapter adpt;
        DataSet ds;
        int cnt;

        private void Form3_Load(object sender, EventArgs e)
        {
            con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\Database6.accdb");
            cnt = 0;
            loaddata();
           
        }
        void loaddata()
        {
            adpt = new OleDbDataAdapter("select * from student", con);
            ds = new DataSet();
            adpt.Fill(ds, "demo1");
        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            txtname.Clear();
            txtmob.Clear();
            txtdist.Clear();
            txtcollege.Clear();
            txtvilage.Clear();
            txtstate.Clear();
            txt10.Clear();
            txt12.Clear();
            txtper.Clear();
            txtclass1.Text= "";
        }

 

        private void Update_Click_1(object sender, EventArgs e)
        {
            cmd=new OleDbCommand( "update student set name='" + txtname.Text + "',mob='" + txtmob.Text + "',village='" + txtvilage.Text + "',dist='" + txtdist.Text + "',state='" + txtstate.Text + "',dob='" + txtdob.Text + "',class='" + txtclass1.SelectedItem + "',per=" + txtper.Text + ",college='" + txtcollege.Text + "',10th=" + txt10.Text + ",12th=" + txt12.Text + "where id=" + txtid.Text + "",con);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("record updated succesfully");
            loaddata();
           


        }

        private void Save_Click(object sender, EventArgs e)
        {
            cmd = new OleDbCommand("insert into Student(name,mob,village,dist,state,dob,class,per,college,10th,12th) values('" + txtname.Text + "','" + txtmob.Text + "','" + txtvilage.Text + "','" + txtdist.Text + "','" + txtstate.Text + "','" + txtdob.Text + "','" + txtclass1.SelectedItem + "'," + txtper.Text + ",'" + txtcollege.Text + "'," + txt10.Text + "," + txt12.Text + ")", con);
            con.Open();
            cnt = cmd.ExecuteNonQuery();
            con.Close();
            if (cnt > 0)
            {
                MessageBox.Show("record inserted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loaddata();

            }
            else
            {
                MessageBox.Show("failed", "warning", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            }
            
        }

        private void delete_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }


    }
}
