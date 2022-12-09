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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SarahMerzoukTP02
{
    public partial class infosReservation : Form
    {
        const int maxReservation = 8;
        const int nbJours = 365;
        const int nbTerrains = 10; // Car j'ai un maximum de 10 terrains

        Boolean[,] campingDispo; // tableau pour réservation - disponibilité du camping

        Camping campingChoisi;
        DateTimePicker dateDebut;
        DateTimePicker dateFin;
        int numeroReservation;

        decimal nbDePersonnes;

        Reservation uneReservation;
        Reservation[] desReservations;
        int ctrReservation = 0;

        private string chemin = Application.StartupPath + "\\"; // bin/debug/nte-window6.0

        public infosReservation(Camping pCampingChoisi, DateTimePicker pDebut, DateTimePicker pFin, int pNo)
        {
            campingChoisi = pCampingChoisi;
            dateDebut = pDebut;
            dateFin = pFin;
            numeroReservation = pNo;

            InitializeComponent();
        }

        private void Reservation_Load(object sender, EventArgs e)
        {
            button_reserver.Enabled = false;

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
            
            // tableau pour réservation - disponibilité du camping
            campingDispo = new Boolean[nbTerrains, nbJours];

            // initialiser des terrains dans le camping
            for (int i = 0; i < nbTerrains; i++)
            {
                for (int j = 0; j < nbJours; j++)
                {
                    campingDispo[i, j] = false;
                }
            }

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

        private void faireLaRéservationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Valider le nombre maximum de personnes
            if (numericUpDown_nbAdultes.Value + numericUpDown_nbEnfants.Value > maxReservation)
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

        private void button_reserver_Click_1(object sender, EventArgs e)
        {
            numeroReservation++;
            
            saveFileDialogFichier.InitialDirectory = chemin;
            saveFileDialogFichier.Title = campingChoisi.getNomFichierDuCamping();
            saveFileDialogFichier.FileName = campingChoisi.getNomFichierDuCamping();

            saveFileDialogFichier.Filter = "Fichier texte|*.txt";
            saveFileDialogFichier.FilterIndex = 1;

            int nbAdultes = Convert.ToInt32(textBox_nbAdultes.Text);
            int nbEnfants = Convert.ToInt32(textBox_nbEnfants.Text);

            if (comboBox_terrains.SelectedIndex != -1) //
            {
                int dateArrivee = dateDebut.Value.DayOfYear;
                int dateDepart = dateFin.Value.DayOfYear;
                decimal cout = Convert.ToDecimal(textBox_coutTotal.Text);

                if (dateArrivee < dateDepart)
                {
                  
                    // Écriture de la réservation dans un fichier texte
                    if (saveFileDialogFichier.ShowDialog() == DialogResult.OK)
                    {
                        // sauvegarde du fichier
                        try
                        {
                            StreamWriter ecriture = new StreamWriter(saveFileDialogFichier.FileName, true);

                            if (!textBox_nbNuits.Text.Equals("0") && nbDePersonnes != 0)
                            {
                                ecriture.WriteLine(numeroReservation + " ; " + dateDebut.Value + " ; " + dateFin.Value + " ; " + comboBox_terrains.SelectedItem + " ; "
                                  + textBox_nbAdultes.Text + " ; " + textBox_nbEnfants.Text + " ; " + textBox_nom.Text + " ; " + textBox_courriel.Text + " ; "
                                  + comboBox_typeDePaiement.SelectedItem + " ; " + textBox_coutTotal.Text + "\r\n");

                                ecriture.Close();

                                ctrReservation++;
                                uneReservation = new Reservation(numeroReservation, campingChoisi.getNoCamping(), textBox_nom.Text, textBox_courriel.Text, comboBox_typeDePaiement.Text, dateDebut, dateFin, nbAdultes, nbEnfants, cout); ;
                                desReservations[ctrReservation] = uneReservation;

                            } else
                            {
                                MessageBox.Show("Une réservation à 0 nuit ou à 0 nombre de personnes n’existe pas dans notre système.");
                            }

                            // faire la réservation dans le tab => mettre à True les journées qui sont réservées
                            for (int ctr = dateArrivee; ctr < dateDepart; ctr++)
                            {
                                campingDispo[comboBox_terrains.SelectedIndex, ctr] = true;

                                // ajout dans le log de réservation
                                 listBox_reservation.Items.Add("Site : " +
                                    (comboBox_terrains.SelectedIndex + 1).ToString() + " Jour: " + ctr +
                                    "\r\n");
                            }

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Erreur de fichier: " + ex.Message, "Sauvegarde de fichier",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }

                }

                toolStripStatus_reservation.Text = "Réservation sauvegardée dans le fichier";
            }
        }

        private void button_terrainsDispos_Click(object sender, EventArgs e)
        {
            richTextBox_T1.BackColor = Color.Green;
            richTextBox_T2.BackColor = Color.Green;
            richTextBox_T3.BackColor = Color.Green;
            richTextBox_T4.BackColor = Color.Green;
            richTextBox_T5.BackColor = Color.Green;
            richTextBox_T6.BackColor = Color.Green;
            richTextBox_T7.BackColor = Color.Green;
            richTextBox_T8.BackColor = Color.Green;
            richTextBox_T9.BackColor = Color.Green;
            richTextBox_T10.BackColor = Color.Green;

            int dateArrivee = dateDebut.Value.DayOfYear;
            int dateDepart = dateFin.Value.DayOfYear;

            if (dateArrivee < dateDepart)
            {
                for (int ctr = dateArrivee; ctr < dateDepart; ctr++)
                {
                    // Terrani 1 : si réserver = change la couleur

                    if (campingDispo[0, ctr])
                    {
                        richTextBox_T1.BackColor = Color.Red;
                    }
                    if (campingDispo[1, ctr])
                    {
                        richTextBox_T2.BackColor = Color.Red;
                    }
                    if (campingDispo[2, ctr])
                    {
                        richTextBox_T3.BackColor = Color.Red;
                    }
                    if (campingDispo[3, ctr])
                    {
                        richTextBox_T4.BackColor = Color.Red;
                    }
                    if (campingDispo[4, ctr])
                    {
                        richTextBox_T5.BackColor = Color.Red;
                    }
                    if (campingDispo[5, ctr])
                    {
                        richTextBox_T6.BackColor = Color.Red;
                    }
                    if (campingDispo[6, ctr])
                    {
                        richTextBox_T7.BackColor = Color.Red;
                    }
                    if (campingDispo[7, ctr])
                    {
                        richTextBox_T8.BackColor = Color.Red;
                    }
                    if (campingDispo[8, ctr])
                    {
                        richTextBox_T9.BackColor = Color.Red;
                    }
                    if (campingDispo[9, ctr])
                    {
                        richTextBox_T10.BackColor = Color.Red;
                    }
                }

            }
        }

        private void comboBox_typeDePaiement_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (textBox_courriel.Text != "" && textBox_nom.Text != "" && textBox_nbAdultes.Text != "" && textBox_nbEnfants.Text != "" && textBox_coutTotal.Text != "" && textBox_nbNuits.Text != "")
            {
                button_reserver.Enabled = true;

            }
        }

        private void nouvelleRéservationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            numericUpDown_nbAdultes.Value = 0;
            numericUpDown_nbEnfants.Value = 0;
            textBox_courriel.Text = "";
            textBox_nom.Text = "";
            comboBox_typeDePaiement.Text = "";
            button_reserver.Enabled = false;
        }

        private void retourAuMenuPrincipalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
