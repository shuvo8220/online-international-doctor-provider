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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace KnockDoc
{
    public partial class frmRegister : Form
    {
        DBConnect dbCon = new DBConnect();
        public frmRegister()
        {
            InitializeComponent();
        }

        private void frmRegister_Load(object sender, EventArgs e)
        {
            cmbRole.SelectedIndex = 0;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            

            string connectionString = "Data Source=DARKPHANTOM\\SQLEXPRESS;Initial Catalog=knock_doc;Integrated Security=True;";
          

            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string confirmPassword = txtCompassword.Text;
            string selectedRole = cmbRole.SelectedItem?.ToString();

            if (username == "" || password == "" || confirmPassword == "" || selectedRole == null)
            {
                MessageBox.Show("Please fill in all fields.", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    try
                    {
                        con.Open();

                        string insertQuery = "INSERT INTO register_tbl (user_name, user_password, user_role) VALUES (@user_name, @user_password, @user_role)";
                        SqlCommand cmd = new SqlCommand(insertQuery, con);
                        cmd.Parameters.AddWithValue("@user_name", username);
                        cmd.Parameters.AddWithValue("@user_password", password);
                        cmd.Parameters.AddWithValue("@user_role", selectedRole);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Registration Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        con.Close();
                    }
                    this.Hide();
                    frmLogin fm = new frmLogin();
                    fm.Show();
                }


            }
            
        }

        private void lblCreate_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin fm = new frmLogin();
            fm.Show();
        }

        private void clrValue_Click(object sender, EventArgs e)
        {
            cmbRole.SelectedIndex = 0;
            txtUsername.Clear();
            txtPassword.Clear();
            txtCompassword.Clear();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            if (txtUsername.Text == String.Empty)
            {
                MessageBox.Show("Please Enter valid UserName", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Focus();
                return;
            }
            else { }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text == String.Empty)
            {
                MessageBox.Show("Please Enter valid Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Focus();
                return;
            }
            else { }
        }
    }
}
