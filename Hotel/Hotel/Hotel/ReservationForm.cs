using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel
{
    public partial class ReservationForm : Form
    {


        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\LENOVO\Documents\hotel bd.mdf"";Integrated Security=True;Connect Timeout=30";

        BDConnect dbCon = new BDConnect();
        private object dbo;
        private object dBCon;
        private string textBox_City;
        private SqlDataAdapter adapter;
        private string updatetQuery;

        private Button Date2;


        public ReservationForm()
        {
            InitializeComponent();
            DisplayLocation();
            DisplayRoom();
          
        }


        



        private void DisplayRoom()
        {
            try
            {

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "SELECT * FROM Room where Dispo=@dispo";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@dispo", "disponible");

                    SqlDataReader Reader = cmd.ExecuteReader();

                    if (Reader.HasRows)
                    {
                        while (Reader.Read())
                        {

                            comboBox1.Items.Add(Reader["RoomNo"].ToString());

                        }
                    }
                    else
                    {
                        comboBox1.Items.Add("no room!!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur s'est produite : " + ex.Message);
            }
        }


        private void DisplayLocation()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "SELECT * FROM Reservation";
                    SqlDataAdapter sda = new SqlDataAdapter(query, con);
                    SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                    var ds = new DataSet();
                    sda.Fill(ds);
                    guna2DataGridView1.DataSource = ds.Tables[0];

                    // Set the column header text
                    guna2DataGridView1.Columns[1].HeaderText = "RoomNo";
                    guna2DataGridView1.Columns[2].HeaderText = "DateIn";
                    guna2DataGridView1.Columns[3].HeaderText = "DateOut";

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur s'est produite : " + ex.Message);
            }
        }
        private void RefreshDataGridView()
        {
            try
            {
                
                DisplayLocation();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur s'est produite lors du rafraîchissement du DataGridView : " + ex.Message);
            }
        }

        private void ReservationForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(dateTimePicker1.Text) || string.IsNullOrWhiteSpace(dateTimePicker3.Text) || string.IsNullOrWhiteSpace(comboBox1.Text))
                {
                    MessageBox.Show("Missing information");
                }
                else
                {
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        con.Open();




                        // Use the stored empId and empName in the insert query
                        string insertQuery = "INSERT INTO Reservation ( RoomNo, DateIn, DateOut, ClientId) VALUES ( @RoomNo, @DateIn, @DateOut, @ClientId)";
                        SqlCommand insertCmd = new SqlCommand(insertQuery, con);


                        insertCmd.Parameters.AddWithValue("@RoomNo", comboBox1.Text);
                        insertCmd.Parameters.AddWithValue("@DateIn", DateTime.Parse(dateTimePicker1.Text));
                        insertCmd.Parameters.AddWithValue("@DateOut", DateTime.Parse(dateTimePicker3.Text));
                        insertCmd.Parameters.AddWithValue("@ClientId", Convert.ToInt32(label11.Text));

                        insertCmd.ExecuteNonQuery();
                        string insertQuery1 = "INSERT INTO RoomRef ( RoomNo, DateIn, DateOut, ClientId) VALUES ( @RoomNo, @DateIn, @DateOut, @ClientId)";
                        SqlCommand insertCmd1 = new SqlCommand(insertQuery1, con);


                        insertCmd1.Parameters.AddWithValue("@RoomNo", comboBox1.Text);
                        insertCmd1.Parameters.AddWithValue("@DateIn", DateTime.Parse(dateTimePicker1.Text));
                        insertCmd1.Parameters.AddWithValue("@DateOut", DateTime.Parse(dateTimePicker3.Text));
                        insertCmd1.Parameters.AddWithValue("@ClientId", Convert.ToInt32(label11.Text));

                        insertCmd1.ExecuteNonQuery();

                        SqlCommand updatecmd = new SqlCommand("update Room set Dispo=@dispo where RoomNo=@roomno ", con);
                        updatecmd.Parameters.AddWithValue("@dispo", "non disponible");
                        updatecmd.Parameters.AddWithValue("@roomno", comboBox1.Text);
                        updatecmd.ExecuteNonQuery();
                        MessageBox.Show("Record inserted successfully!");
                        RefreshDataGridView();


                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }




        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2DataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {

        }




        private void recherche()
        {
            try
            {
                if (cin.Text == null)
                {
                    MessageBox.Show("CIN Not Exist !!!");
                }
                else
                {
                    string selectQuery = "SELECT * FROM Client WHERE CIN = @CIN ";
                    using (SqlCommand command = new SqlCommand(selectQuery, dbCon.GetCon()))
                    {
                        command.Parameters.AddWithValue("@CIN", cin.Text); // Assuming cin is a TextBox for entering the search string

                        dbCon.OpenCon();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                // Display the data for the first matching record
                                reader.Read();

                                label11.Text = reader["Id_No"].ToString();
                                label5.Text = reader["First_Name"].ToString();
                                label8.Text = reader["Last_Name"].ToString();
                                label9.Text = reader["Phone"].ToString();

                                label5.Visible = true;
                                label8.Visible = true;
                                label9.Visible = true;
                                label3.Visible = true;
                                label7.Visible = true;
                                label11.Visible = true;
                                label2.Visible = true;
                                label12.Visible = true;
                                label13.Visible = true;
                                label14.Visible = true;

                                comboBox1.Visible = true;
                                dateTimePicker1.Visible = true;
                                dateTimePicker3.Visible = true;
                            }
                            else
                            {
                                MessageBox.Show("No matching records found.");
                                label5.Visible = false;
                                label8.Visible = false;
                                label9.Visible = false;
                                // ... (Hide other labels and controls if necessary)
                            }
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


        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            recherche();

        }

        private void guna2DataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick_3(object sender, DataGridViewCellEventArgs e)
        {
            // int selectedclient = (int)guna2DataGridView1.SelectedRows[0].Cells["Id_No"].Value;

            this.comboBox1.Text = "" + guna2DataGridView1.SelectedRows[0].Cells["RoomNO"].Value.ToString();
            this.dateTimePicker1.Text = "" + guna2DataGridView1.SelectedRows[0].Cells["dateIn"].Value.ToString();
            this.dateTimePicker3.Text = "" + guna2DataGridView1.SelectedRows[0].Cells["DateOut"].Value.ToString();

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainForm mf = new MainForm();
            mf.Show();
            this.Hide();
        }

        private void button_update_Click(object sender, EventArgs e)
        {

            string updateQuery = "update reservation set DateIn=@datein ,DateOut=@dateout where RoomNo=@roomno ";
            using (SqlCommand command = new SqlCommand(updateQuery, dbCon.GetCon()))
            {
                dbCon.OpenCon();
                command.Parameters.AddWithValue("@datein", dateTimePicker1.Value);
                command.Parameters.AddWithValue("@dateout", dateTimePicker3.Value);
                command.Parameters.AddWithValue("@roomno", comboBox1.Text);
                command.ExecuteNonQuery();
                MessageBox.Show("update successfully .");
                RefreshDataGridView();

            }
        }

        private void button_clean_Click(object sender, EventArgs e)
        {
            this.cin.Text = "";
            this.comboBox1.Text = "";
            this.dateTimePicker1.Text = "";
            this.dateTimePicker3.Text = "";
          
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            string updateQuery = "delete from Reservation where RoomNo=@roomno ";
            using (SqlCommand command = new SqlCommand(updateQuery, dbCon.GetCon()))
            {

                dbCon.OpenCon();
                command.Parameters.AddWithValue("@roomno", comboBox1.Text);
                command.ExecuteNonQuery();
                RefreshDataGridView();
                MessageBox.Show("delete successfully .");
                
                SqlCommand updatecmd = new SqlCommand("update Room set Dispo=@dispo where RoomNo=@roomno ", dbCon.GetCon());
                updatecmd.Parameters.AddWithValue("@dispo", "disponible");
                updatecmd.Parameters.AddWithValue("@roomno", comboBox1.Text);
                updatecmd.ExecuteNonQuery();
                

            }

        }
    }
}
