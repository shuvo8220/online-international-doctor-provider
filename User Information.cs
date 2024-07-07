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
using System.Xml.Linq;

namespace KnockDoc
{
    public partial class User_Information : Form
    {
        private string connectionString = "Data Source=DARKPHANTOM\\SQLEXPRESS;Initial Catalog=knock_doc;Integrated Security=True;";
        private int selectedp_id = 0;

        public User_Information()
        {
            InitializeComponent();
            patient();


        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void User_Information_Load(object sender, EventArgs e)
        {
            

        }
        private void patient()
        {
            try
            {
                string query = "SELECT * FROM patient_tbl";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        PatientList.DataSource = dataTable;
                        
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       

       

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            patientDashboard fm = new patientDashboard();
            fm.Show();
        }
       

        private void btnPsave_Click(object sender, EventArgs e)
        {
            try
            {
                if (AreTextBoxesEmpty())
                {
                    MessageBox.Show("Missing Data!!!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    string name = txtPname.Text;
                    string address = txtPaddress.Text;
                    string phone = txtPnumber.Text;
                    string blood = txtPbgroup.Text;
                    string problems = txtPproblem.Text;
                    string age = txtPage.Text;
                    string gender = string.Empty;
                    DateTime selectedDateTime = dateTimePicker1.Value;

                    if (radioMale.Checked)
                    {
                        gender = "Male";
                    }
                    else if (radioFemale.Checked)
                    {
                        gender = "Female";
                    }

                    
                    string query = "INSERT INTO patient_tbl (p_name, p_address, p_phonenumber, p_blood,AppointmentDateTime, p_problems, p_gender) VALUES (@Name, @Address, @Phone, @Blood, @AppointmentDateTime,@Problems, @Gender)";


                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        using (SqlCommand cmd = new SqlCommand(query, connection))
                        {
                            cmd.Parameters.AddWithValue("@Name", name);
                            cmd.Parameters.AddWithValue("@Address", address);
                            cmd.Parameters.AddWithValue("@Phone", phone);
                            cmd.Parameters.AddWithValue("@Blood", blood);
                            cmd.Parameters.AddWithValue("@Problems", problems);
                            cmd.Parameters.AddWithValue("@Age", age);
                            cmd.Parameters.AddWithValue("@Gender", gender);
                            cmd.Parameters.AddWithValue("@AppointmentDateTime", selectedDateTime);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    patient();
                    MessageBox.Show("Information Saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearTextBoxes();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding patient: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private bool AreTextBoxesEmpty()
        {
            
            return string.IsNullOrEmpty(txtPname.Text) || string.IsNullOrEmpty(txtPaddress.Text) ||
                   string.IsNullOrEmpty(txtPnumber.Text) || string.IsNullOrEmpty(txtPbgroup.Text) ||
                   string.IsNullOrEmpty(txtPproblem.Text) || string.IsNullOrEmpty(txtPage.Text);
        }

        private void ClearTextBoxes()
        {
           
            foreach (Control control in Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Clear();
                }
            }
        }

       

        private void PatientList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

           
        }

        private void PatientList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < PatientList.Rows.Count)
            {
                DataGridViewRow selectedRow = PatientList.Rows[e.RowIndex];

                txtPname.Text = selectedRow.Cells["p_name"].Value?.ToString() ?? string.Empty;
                txtPaddress.Text = selectedRow.Cells["p_address"].Value?.ToString() ?? string.Empty;
                txtPnumber.Text = selectedRow.Cells["p_phonenumber"].Value?.ToString() ?? string.Empty;
                txtPbgroup.Text = selectedRow.Cells["p_blood"].Value?.ToString() ?? string.Empty;
                txtPproblem.Text = selectedRow.Cells["p_problems"].Value?.ToString() ?? string.Empty;
                txtPage.Text = selectedRow.Cells["p_age"].Value?.ToString() ?? string.Empty;

            
                if (int.TryParse(selectedRow.Cells["p_id"].Value?.ToString(), out int p_id))
                {
                    selectedp_id = p_id;
                }
                else
                {
                    selectedp_id = 0; 
                }
            }
            else
            {
                ClearTextBoxes(); 
                selectedp_id = 0; 
            }
        }
    }
}


// some features to work 
//1. User Authentication; advanced datagridview;