using Guna.UI2.WinForms;
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
using System.Xml.Linq;
using TheArtOfDevHtmlRenderer.Adapters;

namespace Hotel
{
    public partial class Client : Form

    {
        BDConnect dbCon = new BDConnect();
        private object dbo;
        private object dBCon;
        private string textBox_City;
        private SqlDataAdapter adapter;
        private string DeletetQuery;
    
        private object dataGridView1;
        private string connectionString;
        private object nomclient;
        private string connection;
        private SqlConnection con;
        private Sqlcommand md;
        private object cmd;
        private object b1SID;
        private object dataGridView2;

        public object TextBox_City { get; private set; }
        public object TextBox_Phone { get; private set; }
        public object TextBox_lname { get; private set; }
        public object TextBox_fname { get; private set; }
        public object TextBox_id { get; private set; }
        public object Textbox_fname { get; private set; }
        public object textbox_city { get; private set; }

        public Client()
        {
            InitializeComponent();
            Displayclient();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button_home_Click(object sender, EventArgs e)
        {
            //ClientClass client = new ClientClass();
        }

       /* private void Button_clean_Click(object sender, EventArgs e)
        {

            textBox_fname.Clear();
            textBox_lname.Clear();
            textBox_phone.Clear();
            textBox_city.Clear();
            textBox_cin.Clear();
        }*/
        private void button_clean_Click(object sender, EventArgs e)
        {

            this.textBox_fname.Text = "";
            this.textBox_lname.Text = "";
            this.textBox_phone.Text = "";
            this.textBox_city.Text = "";
            this.textBox_city.Text = "";
            this.textBox_ld.Text = "";
            this.textBox_cin.Text = "";
        }

        private void Client_Paint(object sender, PaintEventArgs e)
        {
            GetTable();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button_update_Click(object sender, EventArgs e)

        {
            try
            {
                if (guna2DataGridView1.SelectedRows.Count > 0)
                {
                    

                  

                    dbCon.OpenCon();
                    string query = "UPDATE client SET " +
                                   "First_Name = @val1, " +
                                   "Last_Name = @val2, " +
                                   "Phone= @val3, " + "CIN=@vaL5,"+
                                   "City= @val4" + " where Id_No=@val8";

                    SqlCommand cmd = new SqlCommand(query, dbCon.GetCon());

                    cmd.Parameters.AddWithValue("@val1", textBox_fname.Text.Trim());
                    cmd.Parameters.AddWithValue("@val2", textBox_lname.Text.Trim());
                    cmd.Parameters.AddWithValue("@val3", textBox_phone.Text.Trim());
                    cmd.Parameters.AddWithValue("@val4", textBox_city.Text.Trim());
                    cmd.Parameters.AddWithValue("@val5", textBox_cin.Text.Trim());
                    cmd.Parameters.AddWithValue("@val8", textBox_ld.Text.Trim());

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Record updated successfully!");
                        GetTable();
                        guna2DataGridView1.Update();
                        guna2DataGridView1.Refresh();
                    }
                    else
                    {
                        MessageBox.Show("No records were updated. Please check the provided Employee ID.");
                    }
                }

                else
                {
                    MessageBox.Show("Please select a row to update.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void Displayclient()
        {

        }

        private void panel_button_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button_delete_Click(object sender, EventArgs e)
        {
           
                try
                {
                    if (guna2DataGridView1.SelectedRows.Count > 0)
                    {
                    dbCon.OpenCon();
                    string query = "DELETE FROM Client WHERE Id_No = @memId";

                    SqlCommand cmd = new SqlCommand(query, dbCon.GetCon());
                    cmd.Parameters.AddWithValue("@memId", textBox_ld.Text.Trim());


                    int rowsAffected = cmd.ExecuteNonQuery();
                    MessageBox.Show("Record deleted successfully!");
                    GetTable();
                    guna2DataGridView1.Update();
                    guna2DataGridView1.Refresh();
                    this.textBox_fname.Text = "";
                    this.textBox_lname.Text = "";
                    this.textBox_phone.Text = "";
                    this.textBox_city.Text = "";
                    this.textBox_city.Text = "";
                    this.textBox_ld.Text = "";
                    this.textBox_cin.Text = "";
                }
                    else
                    {
                        MessageBox.Show("Please select a row to delete.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }

        private void dateEnd_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Client_Load(object sender, EventArgs e)
        {

        }



        private void label_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void GetTable()
        {
            string selectQuerry = "SELECT Id_No, First_Name, Last_Name, Phone, City, CIN FROM Client";
            SqlCommand command = new SqlCommand(selectQuerry, dbCon.GetCon());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            guna2DataGridView1.DataSource = table;
            guna2DataGridView1.Columns[0].Visible = true;

        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                if(EstChiffresSeulement(textBox_cin.Text)&& EstNumeroTelephoniqueValide(textBox_phone.Text))
                { 
                    string insertQuery = "INSERT INTO Client (First_Name, Last_Name, Phone, City, CIN) VALUES (@FirstName, @LastName, @Phone, @City, @CIN)";

                    using (SqlCommand command = new SqlCommand(insertQuery, dbCon.GetCon()))
                    {
                        command.Parameters.AddWithValue("@FirstName", textBox_fname.Text.Trim());
                        command.Parameters.AddWithValue("@LastName", textBox_lname.Text.Trim());
                        command.Parameters.AddWithValue("@Phone", textBox_phone.Text.Trim());
                        command.Parameters.AddWithValue("@City", textBox_city.Text.Trim());
                        command.Parameters.AddWithValue("@CIN", textBox_cin.Text.Trim());

                        dbCon.OpenCon();
                        command.ExecuteNonQuery();
                        dbCon.CloseCon();

                        GetTable();
                        guna2DataGridView1.Update();
                        guna2DataGridView1.Refresh();
                        MessageBox.Show("Client Added Successfully");
                    }
                } 
                else { MessageBox.Show("verifier!"); }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void clear()
        {
            throw new NotImplementedException();
        }

        private void getTable()
        {
            throw new NotImplementedException();
        }



        private void label5_Click(object sender, EventArgs e)
        {

        }

  

        private void Guna2DataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
           
           
            // int selectedclient = (int)guna2DataGridView1.SelectedRows[0].Cells["Id_No"].Value;
              this.textBox_fname.Text =""+ guna2DataGridView1.SelectedRows[0].Cells["First_Name"].Value.ToString() ;
              this.textBox_lname.Text =""+ guna2DataGridView1.SelectedRows[0].Cells["Last_Name"].Value.ToString();
              this.textBox_phone.Text = ""+guna2DataGridView1.SelectedRows[0].Cells["Phone"].Value.ToString();
              this.textBox_city.Text = ""+guna2DataGridView1.SelectedRows[0].Cells["City"].Value.ToString();
            this.textBox_city.Text =""+ guna2DataGridView1.SelectedRows[0].Cells["Phone"].Value.ToString();
            this.textBox_ld.Text = ""+guna2DataGridView1.SelectedRows[0].Cells["Id_No"].Value.ToString();
            this.textBox_cin.Text = ""+guna2DataGridView1.SelectedRows[0].Cells["CIN"].Value.ToString();

        }

        private void textBox_lname_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_ld_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           MainForm Client= new MainForm();
            Client.Show();
            this.Hide();
        }

        private void Client_Load_1(object sender, EventArgs e)
        {

        }

        private void textBox_cin_TextChanged(object sender, EventArgs e)
        {

        }
        private bool EstChiffresSeulement(string texte)
        {
            foreach (char caractere in texte)
            {
                if (!char.IsDigit(caractere))
                {
                    return false;
                }
            }
            String clean = new string(texte.Where(char.IsDigit).ToArray());
            return clean.Length >= 8; ;

        }
        private bool EstNumeroTelephoniqueValide(string texte)
        {
            // Assurez-vous que la chaîne contient uniquement des chiffres et a une longueur d'au moins 8
            string cleanPhoneNumber = new string(texte.Where(char.IsDigit).ToArray());

            // Vérifiez si le numéro de téléphone nettoyé a une longueur d'au moins 8
            return cleanPhoneNumber.Length >=8;
        }
        private void textBox_phone_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
