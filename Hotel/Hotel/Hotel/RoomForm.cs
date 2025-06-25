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

namespace Hotel
{
    public partial class RoomForm : Form
    {
        BDConnect dbCon = new BDConnect();
        private string connection;
        
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\LENOVO\Documents\hotel bd.mdf"";Integrated Security=True;Connect Timeout=30";

        private object dBCon;
        private object dbo;
        private SqlConnection con;
        private object label11;
        private object label10;

        public object RoomNo { get; private set; }
        public object Id { get; private set; }

        public RoomForm()
        {
            InitializeComponent();
            GetRoom();
            DisplayTableRoom();
        }
        private void DisplayTableRoom()
        {
            try
            {

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "SELECT RoomNo ,DateIn ,DateOut ,ClientId  FROM RoomRef where RoomNo=@roomno";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@roomno", comboBox3.Text);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    guna2DataGridView1.Columns.Clear();
                    guna2DataGridView1.Columns.Add("RoomNo","RoomNo");
                    guna2DataGridView1.Columns.Add("DateIn", "DateIn");
                    guna2DataGridView1.Columns.Add("DateOut", "DateOut");
                    guna2DataGridView1.Columns.Add("ClientId", "ClientId");



                    foreach (DataRow row in dataTable.Rows)
                    {
                        guna2DataGridView1.Rows.Add(row["RoomNo"], row["DateIn"], row["DateOut"], row["ClientId"]);

                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("this room is available");
            }



        }

        private void GetRoom()
        {
            try
            {
                
                    
                    string query = "SELECT * FROM Room  ";

                    SqlCommand cmd = new SqlCommand(query, dbCon.GetCon());
                    dbCon.OpenCon();
                    

                    SqlDataReader Reader = cmd.ExecuteReader();

                    if (Reader.HasRows)
                    {
                        while (Reader.Read())
                        {

                            comboBox3.Items.Add(Reader["RoomNo"].ToString());

                        }
                    }
                    else
                    {
                        MessageBox.Show("No Room exist !!.");
                    }
                  Reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur s'est produite : " + ex.Message);
            }
        }
        private void RoomForm_Load(object sender, EventArgs e)
        {

        }

        private void button_delete_Click(object sender, EventArgs e)
        {

        }

        private void label_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void button_save_Click(object sender, EventArgs e)
        {
           
        }

        

        private bool EstNumeroTelephoniqueValide(object text)
        {
            throw new NotImplementedException();
        }

        private bool EstChiffresSeulement(object text)
        {
            throw new NotImplementedException();
        }

        private void DisplayLocation()
        {
            throw new NotImplementedException();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            recherche();
        }

        private void recherche()
        {   
            
            try
            {
                string selectQuery = "SELECT * FROM Room WHERE RoomNo = @RoomNo ";
                using (SqlCommand command = new SqlCommand(selectQuery, dbCon.GetCon()))
                {dbCon.OpenCon();
                    command.Parameters.AddWithValue("@RoomNo", comboBox3.Text); // Assuming id is a TextBox for entering the search string

                    
                    using (SqlDataReader reader1 = command.ExecuteReader())
                    {
                        if (reader1.HasRows)
                        {
                            // Display the data for the first matching record
                            reader1.Read();

                            comboBox1.Text = reader1["RoomType"].ToString();
                            comboBox2.Text = reader1["RoomState"].ToString();
                            DisplayTableRoom();
                          
                            
                            
                        }
                        else
                        {
                            MessageBox.Show("No Reservation found.");
                           
                            
                           
                        }
                        
                    }
                    
                }
                string selectQuery2 = "SELECT c.First_Name, c.Last_Name " +
                      "FROM client c " +
                      "JOIN reservation r ON c.Id_No = r.ClientId " +
                      "WHERE r.RoomNo = @roomno";

                using (SqlCommand command = new SqlCommand(selectQuery2, dbCon.GetCon()))
                {
                    dbCon.OpenCon();
                    command.Parameters.AddWithValue("@roomno", comboBox3.Text);

                    using (SqlDataReader reader2 = command.ExecuteReader())
                    {
                        if (reader2.HasRows)
                        {
                            // Display the data for the first matching record
                            reader2.Read();

                            label12.Visible = true;
                            label13.Visible = true;
                            label3.Text = reader2["First_Name"].ToString();
                            label4.Text = reader2["Last_Name"].ToString();
                            label3.Visible = true;
                            label4.Visible = true;
                            label5.Visible = false;
                        }
                        else
                        {
                            MessageBox.Show("No Reservation found.");

                            label12.Visible = false;
                            label13.Visible = false;
                            label3.Visible = false;
                            label4.Visible = false;
                            label5.Visible= true;

                        }
                    }
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                dbCon.CloseCon();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainForm Client = new MainForm();
            Client.Show();
            this.Hide();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    }

