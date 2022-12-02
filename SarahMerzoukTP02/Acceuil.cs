using System.Diagnostics;

namespace SarahMerzoukTP02
{
    public partial class Acceuil : Form
    {
        Camping parcDuBic = new Camping(0, "Parc du Bic", 10, "campingBic.jpg", "RESERV_BIC.txt");
        Camping parcDuMontOrford = new Camping(1, "Parc du Mont_Orford", 8, "campingOrford.jpg", "RESERV_ORFORD.txt");
        Camping campingDuRochePerce = new Camping(2, "Camping du Rocher Percé", 5, "campingPerce.jpg", "RESERV_PERCE.txt");
        Camping campingDeLaPlageStSimon = new Camping(3, "Camping de la plage de St-Siméon", 10, "campingStSimeon.jpg", "RESERV_SIMEON.txt");
        Camping[] campings = new Camping[4];
        Camping campingChoisi = null;

        public Acceuil()
        {
            InitializeComponent();
        }

        private void Acceuil_Load(object sender, EventArgs e)
        {
            // Initalisation de mon tableau campings qui contient mes différents choix de campings
            campings[0] = parcDuBic;
            campings[1] = parcDuMontOrford;
            campings[2] = campingDuRochePerce;
            campings[3] = campingDeLaPlageStSimon;

            // Entrée de mes différents campings dans le comboBox
            for (int i = 0; i < campings.Length; i++)
            {
                comboBox_choixHebergement.Items.Add(campings[i].getNomCamping());
            }
        }

        private void comboBox_choixHebergement_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_choixHebergement.SelectedIndex == 0)
            {
                pictureBox_campings.ImageLocation =  campings[0].getCheminImage();
                campingChoisi = campings[0];

            } else if (comboBox_choixHebergement.SelectedIndex == 1)
            {
                pictureBox_campings.ImageLocation = campings[1].getCheminImage();
                campingChoisi = campings[1];

            }
            else if (comboBox_choixHebergement.SelectedIndex == 2)
            {
                pictureBox_campings.ImageLocation = campings[2].getCheminImage();
                campingChoisi = campings[2];

            }
            else
            {
                pictureBox_campings.ImageLocation = campings[3].getCheminImage();
                campingChoisi = campings[3];
            }
        }

        private void button_quitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_reservation_Click(object sender, EventArgs e)
        {
            if (dateTimePicker_debut.Value.DayOfYear < dateTimePicker_fin.Value.DayOfYear)
            {
                infosReservation saisirInfos = new infosReservation(campingChoisi);

                saisirInfos.ShowDialog();
            } else
            {
                MessageBox.Show("La date d'arrivée doit être plus petite que la date de départ!!!!",
                                "Erreur de date", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}