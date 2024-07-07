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
    public partial class DoctorDetailsForm : Form
    {
        public DoctorDetailsForm()
        {
            InitializeComponent();
        }

        private void DoctorDetailsForm_Load(object sender, EventArgs e)
        {

        }
        public void LoadDoctorDetails(int docId)
        {
            // Write logic to load doctor details based on the provided DocId
            // For example:
            // - Retrieve details from the database
            // - Populate labels, textboxes, or other UI elements with the details
        }

        

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            patientDashboard pa = new patientDashboard();
            pa.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
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
