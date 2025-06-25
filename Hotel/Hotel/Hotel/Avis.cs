using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace Hotel
{
    public partial class Avis : Form
    {
       
        public Avis()
        {
            InitializeComponent();

            // Assurez-vous que cet abonnement à l'événement est fait après l'initialisation des composants.
            guna2RatingStar1.Click += Guna2RatingStar1_Click;
        }
        

        private void Guna2RatingStar1_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            // Code à exécuter lorsque le bouton est cliqué
            // Par exemple, afficher un message
            MessageBox.Show("Client satisfait !");
        }

        private void label_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2CircleProgressBar1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void guna2CircleProgressBar4_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void guna2RatingStar1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
