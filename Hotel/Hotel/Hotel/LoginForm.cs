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
    public partial class Login : Form

    {
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\LENOVO\Documents\hotel bd.mdf"";Integrated Security=True;Connect Timeout=30";

        public Login()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void X_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_MouseEnter(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
          
        }

        private void label_exit_MouseEnter(object sender, EventArgs e)
        {
            label_exit.ForeColor = Color.Red;
        }

        private void label_exit_MouseLeave(object sender, EventArgs e)
        {
            label_exit.ForeColor = Color.Orange;
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))


                {
                    con.Open();

                    // Use parameterized query to avoid SQL injection
                    string query = "SELECT * FROM [User] WHERE username=@Username AND password=@Password";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Username", username.Text);
                        cmd.Parameters.AddWithValue("@Password", password.Text);
                       SqlDataReader dr= cmd.ExecuteReader();
                     /*   using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            sda.Fill(dt);
                     */
                            if (dr.Read())
                            {
                                MainForm h = new MainForm();
                                h.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Invalid Username or Password", "Error");
                            }
                        
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            mdp p = new mdp();
            p.Show();
        }
    }
}
    



  