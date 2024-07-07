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

namespace KnockDoc
{
    public partial class appointment : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DARKPHANTOM\\SQLEXPRESS;Initial Catalog=knock_doc;Integrated Security=True;");
        public appointment()
        {
            InitializeComponent();

        }
        private void GetHospitalList2()
        {
            try
            {
                con.Open();

                using (SqlCommand cmd = new SqlCommand("SELECT H_Name, D_Name, D_qualification, D_Specialization FROM Hospitaltbl", con))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        HospitalList2.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void appointment_Load(object sender, EventArgs e)
        {
            GetHospitalList2();
        }
    }
}
