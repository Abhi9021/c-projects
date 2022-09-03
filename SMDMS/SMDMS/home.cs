using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SMDMS
{
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }
  

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new11 n = new new11();
            n.Show();
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            search1 s = new search1();
            s.Show();
        }

        private void home_Load(object sender, EventArgs e)
        {

        }

       
    }
}
