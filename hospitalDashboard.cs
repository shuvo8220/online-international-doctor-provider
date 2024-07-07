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
    public partial class hospitalDashboard : Form
    {
        private readonly SqlConnection con = new SqlConnection("Data Source=DARKPHANTOM\\SQLEXPRESS;Initial Catalog=knock_doc;Integrated Security=True;");
        public hospitalDashboard()
        {
            InitializeComponent();
        }

        private void hospitalDashboard_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'knock_docDataSet3.Hospitaltbl' table. You can move, or remove it, as needed.
            this.hospitaltblTableAdapter.Fill(this.knock_docDataSet3.Hospitaltbl);
            GetHospitalRecord();
        }
        private void GetHospitalRecord()
        {
            try
            {
                if (con.State != ConnectionState.Open)
                    con.Open();

                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Hospitaltbl", con))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        HospitalList.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin fm = new frmLogin();
            fm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                using (SqlCommand cmd = new SqlCommand("INSERT INTO Hospitaltbl (H_Name, D_Name, D_qualification, D_Specialization, D_Location) VALUES (@HName, @DName, @Qulification, @Specialization, @Location)", con))
                {
                    cmd.Parameters.AddWithValue("@HName", textHospitalName.Text);
                    cmd.Parameters.AddWithValue("@DName", textDoctorName.Text);
                    cmd.Parameters.AddWithValue("@Qulification", textqualification.Text);
                    cmd.Parameters.AddWithValue("@Specialization", textSpecialization.Text);
                    cmd.Parameters.AddWithValue("@Location", textLocation.Text);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Record inserted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Refresh both DataGridViews after insertion
                        GetHospitalRecord();
                        
                    }
                    else
                    {
                        MessageBox.Show("No rows inserted. Check your data and try again.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}\nStack Trace: {ex.StackTrace}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (HospitalList.SelectedRows.Count > 0)
            {
                try
                {
                    con.Open();

                    int selectedRowIndex = HospitalList.SelectedRows[0].Index;
                    int hospitalId = Convert.ToInt32(HospitalList.Rows[selectedRowIndex].Cells["H_Id"].Value);

                    using (SqlCommand cmd = new SqlCommand("UPDATE Hospitaltbl SET H_Name = @HName, D_Name = @DName, D_qualification = @Qulification, D_Specialization = @Specialization, D_Location = @Location WHERE H_Id = @HospitalId", con))
                    {
                        cmd.Parameters.AddWithValue("@HospitalId", hospitalId);
                        cmd.Parameters.AddWithValue("@HName", textHospitalName.Text);
                        cmd.Parameters.AddWithValue("@DName", textDoctorName.Text);
                        cmd.Parameters.AddWithValue("@Qulification", textqualification.Text);
                        cmd.Parameters.AddWithValue("@Specialization", textSpecialization.Text);
                        cmd.Parameters.AddWithValue("@Location", textLocation.Text);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Record updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Refresh both DataGridViews after update
                            GetHospitalRecord();
                           
                        }
                        else
                        {
                            MessageBox.Show("No rows updated. Check your data and try again.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}\nStack Trace: {ex.StackTrace}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (con.State == ConnectionState.Open)
                        con.Close();
                }
            }
            else
            {
                MessageBox.Show("Select a row to update.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (HospitalList.SelectedRows.Count > 0)
            {
                try
                {
                    con.Open();

                    int selectedRowIndex = HospitalList.SelectedRows[0].Index;
                    int hospitalId = Convert.ToInt32(HospitalList.Rows[selectedRowIndex].Cells["H_Id"].Value);

                    using (SqlCommand cmd = new SqlCommand("DELETE FROM Hospitaltbl WHERE H_Id = @HospitalId", con))
                    {
                        cmd.Parameters.AddWithValue("@HospitalId", hospitalId);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Record deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Refresh both DataGridViews after deletion
                            GetHospitalRecord();
                          
                        }
                        else
                        {
                            MessageBox.Show("No rows deleted. Check your data and try again.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}\nStack Trace: {ex.StackTrace}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (con.State == ConnectionState.Open)
                        con.Close();
                }
            }
            else
            {
                MessageBox.Show("Select a row to delete.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            appointment ap = new appointment();
            ap.Show();
        }
    }
    
}
