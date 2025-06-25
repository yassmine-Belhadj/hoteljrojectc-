using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace Hotel
{
    public partial class mdp : Form
    {
        private readonly string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\LENOVO\Documents\hotel bd.mdf"";Integrated Security=True;Connect Timeout=30";
        private string query;

        public Login LoginForm { get; private set; }

        public mdp()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

            string currentPassword = textBox1.Text;
            string newPassword = textBox2.Text;
            string confirmNewPassword = textBox3.Text;

            if (newPassword != confirmNewPassword)
            {
                MessageBox.Show("Le nouveau mot de passe et la confirmation du mot de passe ne correspondent pas.", "Erreur");
                return;
            }

            using (SqlConnection con = new SqlConnection(connection))
            {
                try
                {
                    con.Open();

                    string verifyQuery = "SELECT * FROM [USER] WHERE password=@CurrentPassword";
                    SqlCommand verifyCmd = new SqlCommand(verifyQuery, con);
                    verifyCmd.Parameters.AddWithValue("@CurrentPassword", currentPassword);

                    SqlDataAdapter verifySda = new SqlDataAdapter(verifyCmd);
                    DataTable verifyDt = new DataTable();
                    verifySda.Fill(verifyDt);

                    if (verifyDt.Rows.Count > 0)
                    {
                        // Update the user's password for the fixed username
                        string updateQuery = "UPDATE [USER] SET Password=@NewPassword ";
                        using (SqlCommand updateCmd = new SqlCommand(updateQuery, con))
                        {
                            updateCmd.Parameters.AddWithValue("@NewPassword", newPassword);
                            updateCmd.ExecuteNonQuery();

                            MessageBox.Show("Mot de passe mis à jour avec succès.");
                            LoginForm = new Login();
                            LoginForm.Show();
                            this.Hide();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Mot de passe actuel invalide.", "Erreur");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Une erreur s'est produite" +
                        ": " + ex.Message);
                }
            }

        
    }

   

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";

        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Login f = new Login();
           f.Show();
        }

       

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

   
}

