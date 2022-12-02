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
    public partial class infosReservation : Form
    {
        Camping campingChoisi;
        public infosReservation(Camping pCampingChoisi)
        {
            campingChoisi = pCampingChoisi;
            InitializeComponent();
        }

        private void Reservation_Load(object sender, EventArgs e)
        {
            // Affichage des informations déjà connues
            label_campingChoisi.Text = campingChoisi.getNomCamping();
            pictureBox_campingChoisi.ImageLocation = campingChoisi.getCheminImage();

            // Ajout de la bonne quantité de terrains dans le comboBox
            for (int i = 1; i <= campingChoisi.getNbTerrains(); i++)
            {
                comboBox_terrains.Items.Add("Terrain " + i);
            }

            // Rendre invisible le surplus de terrains qui n'appartiennent pas aux bons campings
            if (campingChoisi.getNoCamping() == 1) // Parc du Mont_Orford
            {
                label_T9.Visible = false;
                label_T10.Visible = false;
                richTextBox_T9.Visible = false;
                richTextBox_T10.Visible = false;

            }
            else if (campingChoisi.getNoCamping() == 2) // Camping du Rocher Percé
            {
                label_T6.Visible = false;
                label_T7.Visible = false;
                label_T8.Visible = false;
                label_T9.Visible = false;
                label_T10.Visible = false;
                richTextBox_T6.Visible = false;
                richTextBox_T7.Visible = false;
                richTextBox_T8.Visible = false;
                richTextBox_T9.Visible = false;
                richTextBox_T10.Visible = false;
            }
        }
    }
}
