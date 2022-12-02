using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
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
        const int MAX_RESERVATION = 8;
        Camping campingChoisi;
        DateTimePicker dateDebut;
        DateTimePicker dateFin;
        int numeroReservation = 0;
        public infosReservation(Camping pCampingChoisi, DateTimePicker pDebut, DateTimePicker pFin)
        {
            campingChoisi = pCampingChoisi;
            dateDebut = pDebut;
            dateFin = pFin;

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

            // Ajout des types de paiements dans le comboBox
            comboBox_typeDePaiement.Items.Add("Interac");
            comboBox_typeDePaiement.Items.Add("Crédit-Visa");
            comboBox_typeDePaiement.Items.Add("Crédit-MasterCard");
        }

        private void textBox_nom_TextChanged(object sender, EventArgs e)
        {
            string txt = textBox_nom.Text;
            bool numerique = false; // n'est pas un numéro

            foreach (char car in txt)
            {
                if (char.IsDigit(car))
                {
                    numerique = true;
                }
            }

            if (numerique)
            {
                errorProvider_nom.SetError(textBox_nom, "Les numéros ne sont pas acceptés");
            } else
            {
                errorProvider_nom.Clear();
            }
        }

        private void textBox_courriel_TextChanged(object sender, EventArgs e)
        {
            var email = new EmailAddressAttribute();
            
            if (!email.IsValid(textBox_courriel.Text)) // SI email n'est pas valide
            {
                errorProvider_courriel.SetError(textBox_courriel,"L'email doit contenit un «@» et ce qui précède le «@» ne doit pas être vide") ;
            } else
            {
                errorProvider_courriel.Clear();
            }
        }

        private void comboBox_typeDePaiement_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_typeDePaiement.Text != "")
            {
                errorProvider_typePaiement.SetError(comboBox_typeDePaiement, "Il faut choisir un type de paiement");
            } else
            {
                errorProvider_typePaiement.Clear();
            }
        }
    }
}
