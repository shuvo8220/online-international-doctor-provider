using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KnockDoc
{
    public partial class DocInfo : Form
    {
        public DocInfo()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           this.Hide();
            patientDashboard pa = new patientDashboard();   
            pa.Show();
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            User_Information fm = new User_Information();
            fm.Show();
        }
    }
}
