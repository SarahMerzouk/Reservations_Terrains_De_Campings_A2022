using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SarahMerzoukTP02
{
    public partial class AffichageReservation : Form
    {
        Reservation[] reservations;
        Camping campingChoisi;
        public AffichageReservation(Reservation[] pReservations, Camping pCamping)
        {
            reservations = pReservations;
            campingChoisi = pCamping;

            InitializeComponent();
        }

        private void AffichageReservation_Load(object sender, EventArgs e)
        {
            label_campingChoisiAffichage.Text = campingChoisi.getNomCamping();
            pictureBox_campingChoisieAffichage.ImageLocation = campingChoisi.getCheminImage();

            for (int i = 0; i < reservations.Length; i++)
            {
                if (reservations[i] != null)
                {
                    comboBox_reservations.Items.Add("Nom : " +reservations[i].getNomClient() + " Courriel : " + reservations[i].getCourriel());
                }
            }

        }
    }
}
