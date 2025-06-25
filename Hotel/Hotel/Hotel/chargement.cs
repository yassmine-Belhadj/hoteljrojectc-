using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace Hotel
{
    public partial class chargement : Form
    {
        public chargement()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void chargement_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {


        }
       int Debut = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            Debut += 1;
            progressBar1.Value = Debut;

            if (progressBar1.Value == 100)
            {
                progressBar1.Value = 0;
                timer1.Stop();
               Login Obj = new Login();
                Obj.Show();
                this.Hide();


            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
