using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel
{
    public partial class MainForm :Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel_slide.Height = button_room.Height;
            panel_slide.Top = button_room.Top;
            RoomForm roomForm = new RoomForm();
            roomForm.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button_home_Click(object sender, EventArgs e)
        {
            panel_slide.Height = button_home.Height;
            panel_slide.Top = button_home.Top;
        }

        private void button_client_Click(object sender, EventArgs e)
        {
            panel_slide.Height = button_client.Height;
            panel_slide.Top = button_client.Top;
            Client client = new Client();
            client.Show();
        }

        private void button_reception_Click(object sender, EventArgs e)
        {

            panel_slide.Height = button_reception.Height;
            panel_slide.Top = button_reception.Top;
            ReservationForm reservationForm = new ReservationForm();
            reservationForm.Show();
           
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel_slide_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel_slide.Height = button_client.Height;
            panel_slide.Top = button_client.Top;
           Avis Avis= new Avis();
            Avis.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Login roomForm = new Login();
            roomForm.Show();
        }
    }
}
