using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace KnockDoc
{
    public partial class patientDashboard : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DARKPHANTOM\SQLEXPRESS;Initial Catalog=knock_doc;Integrated Security=True;Encrypt=False");
        public string loggedInUsername { get; set; }
        public patientDashboard()
        {
            InitializeComponent();
           

        }
        public patientDashboard(string username)
        {
            InitializeComponent();
            loggedInUsername = username;

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void GetHospitalList2()
        {
            try
            {
                con.Open();

                using (SqlCommand cmd = new SqlCommand("SELECT H_Name, D_Name, D_qualification,D_Location, D_Specialization FROM Hospitaltbl", con))
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
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            User_Information fm = new User_Information();
            fm.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
           
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Hide();
                frmLogin fm = new frmLogin();
                fm.Show();

                            }

        }
        public void populateGrid()
        {
            con.Open();
            string query = "SELECT DocName, DocSpecialized,HospitalName, DocCountry From DoctorTbl";
            SqlDataAdapter da = new SqlDataAdapter(query,con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dataGridView.DataSource = ds.Tables[0];

            con.Close();

        }
        public void TextFilter()
        {
            con.Open();
            string query = "SELECT DocId, DocName,HospitalName, DocSpecialized, DocCountry From DoctorTbl where DocName = '" + searchbox.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dataGridView.DataSource = ds.Tables[0];

            con.Close();

        }

       public void CountryFilter()
        {
            con.Open();
            string query = "SELECT DocId, DocName, DocSpecialized,HospitalName, DocCountry From DoctorTbl where DocCountry = '" + cmbCountry.SelectedItem.ToString() + "'";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dataGridView.DataSource = ds.Tables[0];

            con.Close();

        }

        public void SpecializationFilter()
        {
            con.Open();
            string query = "SELECT DocId, DocName, DocSpecialized,HospitalName, DocCountry From DoctorTbl where DocSpecialized = '" + cmbSpecialized.SelectedItem.ToString() + "'";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dataGridView.DataSource = ds.Tables[0];

            con.Close();

        }
       

        private void patientDashboard_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'knock_docDataSet4.Hospitaltbl' table. You can move, or remove it, as needed.
            this.hospitaltblTableAdapter.Fill(this.knock_docDataSet4.Hospitaltbl);

            if (!string.IsNullOrEmpty(loggedInUsername))
            {
                // Assuming toolStripMenuItem2 is the name of your ToolStripMenuItem
                toolStripMenuItem2.Text = "Logged in as: " + loggedInUsername;
            }
            else
            {
                toolStripMenuItem2.Text = "Username not available";
            }
            

            // TODO: This line of code loads data into the 'knock_docDataSet1.DoctorTbl' table. You can move, or remove it, as needed.
            this.doctorTblTableAdapter.Fill(this.knock_docDataSet1.DoctorTbl);
            populateGrid();
            GetHospitalList2();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            populateGrid();
            searchbox.Text = " ";
            cmbCountry.SelectedItem = null;
            cmbSpecialized.SelectedItem = null;

        }
        public void ApplyFilters()
        {
            if (cmbSpecialized.SelectedItem != null && cmbCountry.SelectedItem != null)
            {
                string query = "SELECT DocId, DocName, DocSpecialized,HospitalName, DocCountry FROM DoctorTbl WHERE DocSpecialized = @DocSpecialized AND DocCountry = @DocCountry";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.SelectCommand.Parameters.AddWithValue("@DocSpecialized", cmbSpecialized.SelectedItem.ToString());
                da.SelectCommand.Parameters.AddWithValue("@DocCountry", cmbCountry.SelectedItem.ToString());

                var ds = new DataSet();
                da.Fill(ds);
                dataGridView.DataSource = ds.Tables[0];
            }
            else if (cmbSpecialized.SelectedItem != null)
            {
                SpecializationFilter();
            }
            else if (cmbCountry.SelectedItem != null)
            {
                CountryFilter();
            }
            else
            {
                populateGrid();
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            TextFilter();
        }

        private void cmbCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            ApplyFilters();
        }

        private void cmbSpecialized_SelectedIndexChanged(object sender, EventArgs e)
        {
          
            ApplyFilters();
        }

        private void dataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == dataGridView.Columns["ViewProfile"].Index && e.RowIndex >= 0)
            {
                this.Hide();
                DataGridViewRow row = dataGridView.Rows[e.RowIndex];

                //int docId = Convert.ToInt32(row.Cells["DocId"].Value);

                DoctorDetailsForm doctorDetailsForm = new DoctorDetailsForm();
                //doctorDetailsForm.LoadDoctorDetails(docId);
                doctorDetailsForm.ShowDialog();
            }


        }

        private void toolStripTextBox2_Click(object sender, EventArgs e)
        {
            
               
            
        }

        private void toolStripMenuItem2_Click_1(object sender, EventArgs e)
        {
            patientDashboard patientDashboardForm = new patientDashboard();

            
                toolStripMenuItem2.Text = patientDashboardForm.loggedInUsername;
            
            
        }

        private void HospitalList2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == HospitalList2.Columns["Profile"].Index && e.RowIndex >= 0)
            {
                this.Hide();
                DataGridViewRow row = dataGridView.Rows[e.RowIndex];

                //int docId = Convert.ToInt32(row.Cells["DocId"].Value);

                DocInfo fm = new DocInfo();
                //doctorDetailsForm.LoadDoctorDetails(docId);
                fm.ShowDialog();
            }
        }

        public void Apply()
        {
            if (comboBox1.SelectedItem != null)
            {
                try
                {
                    con.Open();
                    string query = "SELECT H_Name, D_Name, D_qualification, D_Location, D_Specialization FROM Hospitaltbl WHERE H_Name = @H_Name";
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    da.SelectCommand.Parameters.AddWithValue("@H_Name", comboBox1.SelectedItem.ToString());

                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    HospitalList2.DataSource = dt;
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
            else
            {
                GetHospitalList2();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Apply();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            GetHospitalList2();

            comboBox1.SelectedItem = null;
        }
    }
}
