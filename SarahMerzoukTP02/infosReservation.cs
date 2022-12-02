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
        decimal nbDePersonnes;
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

            // Affichage du total de nuit
            int nbNuit = dateFin.Value.DayOfYear - dateDebut.Value.DayOfYear;
            textBox_nbNuits.Text = nbNuit.ToString();

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

        private void button_reserver_Click(object sender, EventArgs e)
        {
            // Valider le nombre maximum de personnes
            if (numericUpDown_nbAdultes.Value + numericUpDown_nbEnfants.Value > MAX_RESERVATION)
            {
                errorProvider_maxDePersonnes.SetError(numericUpDown_nbAdultes, "Le maximum est de 8 personnes");
            }
            else
            {
                errorProvider_maxDePersonnes.Clear();
            }

            // Vérifier si un type de paiement a été choisie
            if (comboBox_typeDePaiement.Text == "")
            {
                errorProvider_typePaiement.SetError(comboBox_typeDePaiement, "Il faut choisir un type de paiement");
            }
            else
            {
                errorProvider_typePaiement.Clear();

            }
        }

        private void numericUpDown_nbAdultes_ValueChanged(object sender, EventArgs e)
        {
            textBox_nbAdultes.Text = numericUpDown_nbAdultes.Value.ToString();
            nbDePersonnes = numericUpDown_nbEnfants.Value + numericUpDown_nbAdultes.Value; //
            textBox_nbPersonnes.Text = nbDePersonnes.ToString();


            // Affichage du cout total
            textBox_coutTotal.Text = coutTotal(campingChoisi).ToString() + " $";
        }

        private void numericUpDown_nbEnfants_ValueChanged(object sender, EventArgs e)
        {
            textBox_nbEnfants.Text = numericUpDown_nbEnfants.Value.ToString();
            nbDePersonnes = numericUpDown_nbEnfants.Value + numericUpDown_nbAdultes.Value;
            textBox_nbPersonnes.Text = nbDePersonnes.ToString();


            // Affichage du cout total
            textBox_coutTotal.Text = coutTotal(campingChoisi).ToString() + " $";
        }

        public decimal coutTotal(Camping camping)
        {
            decimal prixAdulte;
            decimal prixEnfant;
            decimal coutTotal;

            if (camping.getNoCamping() == 0) // Parc du Bic
            {
                prixAdulte = 20;
                prixEnfant = 5;

            } else if (camping.getNoCamping() == 1) // Parc du Mont_Orford
            {
                prixAdulte = 15;
                prixEnfant = 5;

            } else if (camping.getNoCamping() == 2) // Camping du Rocher Percé
            {
                prixAdulte = 30;
                prixEnfant = 10;

            }
            else // Camping de la plage de St-Siméon
            {
                prixAdulte = 25;
                prixEnfant = 0;
            }

            coutTotal = (numericUpDown_nbAdultes.Value * prixAdulte) + (numericUpDown_nbEnfants.Value * prixEnfant);

            return coutTotal;
        }
    }
}
