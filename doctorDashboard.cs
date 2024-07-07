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

namespace KnockDoc
{ 

    public partial class doctorDashboard : Form
    {
        private string connectionString = "Data Source=DARKPHANTOM\\SQLEXPRESS;Initial Catalog=knock_doc;Integrated Security=True;";
        
        public doctorDashboard()
        {
            InitializeComponent();
           
        }
        
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
            

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void doctorDashboard_Load(object sender, EventArgs e)
        {
            DisplayAllAppointments();
        }
        private void DisplayAllAppointments()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT [p_id], [p_name] AS 'Name', [p_address] AS 'Address', [p_phonenumber] AS 'Phone', [p_blood] AS 'Blood', [p_gender] AS 'Gender', [p_problems] AS 'Problems', [p_age] AS 'Age', [AppointmentDateTime] AS 'Appointment Date' FROM patient_tbl";

                    SqlCommand cmd = new SqlCommand(query, connection);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Bind the fetched data to the DataGridView
                    dataGridView1.DataSource = dataTable;

                    // Customize column headers
                    dataGridView1.Columns["p_id"].Visible = false; // Hide the p_id column
                    dataGridView1.Columns["Name"].HeaderText = "Name";
                    dataGridView1.Columns["Address"].HeaderText = "Address";
                    dataGridView1.Columns["Phone"].HeaderText = "Phone";
                    dataGridView1.Columns["Blood"].HeaderText = "Blood";
                    dataGridView1.Columns["Gender"].HeaderText = "Gender";
                    dataGridView1.Columns["Problems"].HeaderText = "Problems";
                    dataGridView1.Columns["Age"].HeaderText = "Age";
                    dataGridView1.Columns["Appointment Date"].HeaderText = "Appointment Date";



                    string countQuery = "SELECT COUNT(*) FROM patient_tbl";
                    SqlCommand countCmd = new SqlCommand(countQuery, connection);
                    int totalAppointments = (int)countCmd.ExecuteScalar();

                    labelTotalAppointments.Text = $" {totalAppointments}";

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin fm = new frmLogin();
            fm.Show();
        }
    }
}
