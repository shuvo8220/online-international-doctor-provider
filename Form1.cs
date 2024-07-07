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
    public partial class frmLogin : Form
    {
        DBConnect dbCon = new DBConnect();
        private string loggedInUsername;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            cmbRole.SelectedIndex = 0;  

        }


        private void cmbRole_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            try
            {
                if (cmbRole.SelectedIndex > 0)
                {
                    if (txtUsername.Text == String.Empty)
                    {
                        MessageBox.Show("Please Enter valid UserName", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtUsername.Focus();
                        return;
                    }
                   else if (txtPassword.Text == String.Empty)
                    {
                        MessageBox.Show("Please Enter valid Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtPassword.Focus();
                        return;
                    }
                   else if (cmbRole.SelectedIndex > 0 && txtUsername.Text != String.Empty && txtPassword.Text != String.Empty)
                    {
                        //logincode
                        if(cmbRole.Text== "Patient")
                        {
                            SqlCommand cmd = new SqlCommand("select user_role, user_password,user_name from register_tbl where user_name = @user_name and user_password= @user_password and user_role = 'Patient'", dbCon.GetCon());
                            cmd.Parameters.AddWithValue("@user_name", txtUsername.Text);
                            cmd.Parameters.AddWithValue("@user_password", txtPassword.Text);
                            cmd.Parameters.AddWithValue("@user_role", cmbRole.Text);

                            dbCon.OpenCon();
                            SqlDataAdapter da = new SqlDataAdapter(cmd);
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            if(dt.Rows.Count > 0)
                            {

                                this.Hide();
                                patientDashboard patientDashboardForm = new patientDashboard();
                                patientDashboardForm.loggedInUsername = username; // Set loggedInUsername property
                                patientDashboardForm.Show(); //
                            }
                            else
                            {
                                MessageBox.Show("Invalid Login!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                           

                        }
                        else if (cmbRole.Text== "Doctor")
                        {
                            SqlCommand cmd = new SqlCommand("select user_password,user_role,user_name from register_tbl where user_name = @user_name and user_password= @user_password and user_role = 'Doctor'", dbCon.GetCon());
                            cmd.Parameters.AddWithValue("@user_name", txtUsername.Text);
                            cmd.Parameters.AddWithValue("@user_password", txtPassword.Text);
                            cmd.Parameters.AddWithValue("@user_role", cmbRole.Text);


                        
                            

                            dbCon.OpenCon();
                            SqlDataAdapter da = new SqlDataAdapter(cmd);
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            if (dt.Rows.Count > 0)
                            {
                                this.Hide();
                                doctorDashboard patientDashboardForm = new doctorDashboard();
                                //patientDashboardForm.loggedInUsername = username; // Set loggedInUsername property
                                patientDashboardForm.Show(); //
                            }
                            else
                            {
                                MessageBox.Show("Invalid Login!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                        }
                        else if (cmbRole.Text=="Hospital")
                        {
                            SqlCommand cmd = new SqlCommand("select top 1 user_id, user_password,user_name from register_tbl where user_name = @user_name and user_password= @user_password and user_role = 'Hospital'", dbCon.GetCon());
                            cmd.Parameters.AddWithValue("@user_name", txtUsername.Text);
                            cmd.Parameters.AddWithValue("@user_password", txtPassword.Text);
                            cmd.Parameters.AddWithValue("@user_role", cmbRole.Text);

                            dbCon.OpenCon();
                            SqlDataAdapter da = new SqlDataAdapter(cmd);
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            if (dt.Rows.Count > 0)
                            {
                               
                                this.Hide();
                                hospitalDashboard hospital = new hospitalDashboard();
                                //hospital.loggedInUsername = username;
                                hospitalDashboard fm = new hospitalDashboard();
                                fm.Show();
                            }
                            else
                            {
                                MessageBox.Show("Invalid Login!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Invalid Login!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                        
                        

                    }
                    else
                    {
                        MessageBox.Show("Please Enter UserName or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        
                    } }
                else
                {
                    MessageBox.Show("Please select any role", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                }
                
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cmbRole.SelectedIndex = 0;
            txtUsername.Clear();
            txtPassword.Clear();

        }

        private void lblCreate_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRegister fm = new frmRegister();
            fm.Show();
        }
    }
}
