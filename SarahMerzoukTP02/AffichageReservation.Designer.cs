namespace SarahMerzoukTP02
{
    partial class AffichageReservation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_campingChoisiAffichage = new System.Windows.Forms.Label();
            this.pictureBox_campingChoisieAffichage = new System.Windows.Forms.PictureBox();
            this.comboBox_reservations = new System.Windows.Forms.ComboBox();
            this.label_terrainChoisi = new System.Windows.Forms.Label();
            this.label_nbAdultsAffichage = new System.Windows.Forms.Label();
            this.label_nbEnfantsAffichage = new System.Windows.Forms.Label();
            this.label_nombreDeNuits = new System.Windows.Forms.Label();
            this.label_typePaiement = new System.Windows.Forms.Label();
            this.label_totalCost = new System.Windows.Forms.Label();
            this.textBox_terrainChoisi = new System.Windows.Forms.TextBox();
            this.textBox_nbAdults = new System.Windows.Forms.TextBox();
            this.textBox_nbEnfants = new System.Windows.Forms.TextBox();
            this.textBox_nbNuits = new System.Windows.Forms.TextBox();
            this.textBox_typeDePaiement = new System.Windows.Forms.TextBox();
            this.textBox_coutTotal = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_campingChoisieAffichage)).BeginInit();
            this.SuspendLayout();
            // 
            // label_campingChoisiAffichage
            // 
            this.label_campingChoisiAffichage.AutoSize = true;
            this.label_campingChoisiAffichage.Font = new System.Drawing.Font("MV Boli", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label_campingChoisiAffichage.Location = new System.Drawing.Point(36, 9);
            this.label_campingChoisiAffichage.Name = "label_campingChoisiAffichage";
            this.label_campingChoisiAffichage.Size = new System.Drawing.Size(475, 85);
            this.label_campingChoisiAffichage.TabIndex = 1;
            this.label_campingChoisiAffichage.Text = "Camping choisi";
            // 
            // pictureBox_campingChoisieAffichage
            // 
            this.pictureBox_campingChoisieAffichage.Location = new System.Drawing.Point(36, 108);
            this.pictureBox_campingChoisieAffichage.Name = "pictureBox_campingChoisieAffichage";
            this.pictureBox_campingChoisieAffichage.Size = new System.Drawing.Size(833, 392);
            this.pictureBox_campingChoisieAffichage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_campingChoisieAffichage.TabIndex = 2;
            this.pictureBox_campingChoisieAffichage.TabStop = false;
            // 
            // comboBox_reservations
            // 
            this.comboBox_reservations.FormattingEnabled = true;
            this.comboBox_reservations.Location = new System.Drawing.Point(36, 524);
            this.comboBox_reservations.Name = "comboBox_reservations";
            this.comboBox_reservations.Size = new System.Drawing.Size(838, 56);
            this.comboBox_reservations.TabIndex = 3;
            // 
            // label_terrainChoisi
            // 
            this.label_terrainChoisi.AutoSize = true;
            this.label_terrainChoisi.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_terrainChoisi.Location = new System.Drawing.Point(910, 108);
            this.label_terrainChoisi.Name = "label_terrainChoisi";
            this.label_terrainChoisi.Size = new System.Drawing.Size(291, 46);
            this.label_terrainChoisi.TabIndex = 4;
            this.label_terrainChoisi.Text = "Terrain choisi : ";
            // 
            // label_nbAdultsAffichage
            // 
            this.label_nbAdultsAffichage.AutoSize = true;
            this.label_nbAdultsAffichage.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_nbAdultsAffichage.Location = new System.Drawing.Point(910, 182);
            this.label_nbAdultsAffichage.Name = "label_nbAdultsAffichage";
            this.label_nbAdultsAffichage.Size = new System.Drawing.Size(363, 46);
            this.label_nbAdultsAffichage.TabIndex = 5;
            this.label_nbAdultsAffichage.Text = "Nombre d\'adultes : ";
            // 
            // label_nbEnfantsAffichage
            // 
            this.label_nbEnfantsAffichage.AutoSize = true;
            this.label_nbEnfantsAffichage.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_nbEnfantsAffichage.Location = new System.Drawing.Point(910, 265);
            this.label_nbEnfantsAffichage.Name = "label_nbEnfantsAffichage";
            this.label_nbEnfantsAffichage.Size = new System.Drawing.Size(368, 46);
            this.label_nbEnfantsAffichage.TabIndex = 6;
            this.label_nbEnfantsAffichage.Text = "Nombre d\'enfants : ";
            // 
            // label_nombreDeNuits
            // 
            this.label_nombreDeNuits.AutoSize = true;
            this.label_nombreDeNuits.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_nombreDeNuits.Location = new System.Drawing.Point(910, 366);
            this.label_nombreDeNuits.Name = "label_nombreDeNuits";
            this.label_nombreDeNuits.Size = new System.Drawing.Size(356, 46);
            this.label_nombreDeNuits.TabIndex = 7;
            this.label_nombreDeNuits.Text = "Nombre de nuits : ";
            // 
            // label_typePaiement
            // 
            this.label_typePaiement.AutoSize = true;
            this.label_typePaiement.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_typePaiement.Location = new System.Drawing.Point(910, 465);
            this.label_typePaiement.Name = "label_typePaiement";
            this.label_typePaiement.Size = new System.Drawing.Size(375, 46);
            this.label_typePaiement.TabIndex = 8;
            this.label_typePaiement.Text = "Type de paiement : ";
            // 
            // label_totalCost
            // 
            this.label_totalCost.AutoSize = true;
            this.label_totalCost.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_totalCost.Location = new System.Drawing.Point(910, 556);
            this.label_totalCost.Name = "label_totalCost";
            this.label_totalCost.Size = new System.Drawing.Size(249, 46);
            this.label_totalCost.TabIndex = 9;
            this.label_totalCost.Text = "Côut total : ";
            // 
            // textBox_terrainChoisi
            // 
            this.textBox_terrainChoisi.Location = new System.Drawing.Point(1289, 99);
            this.textBox_terrainChoisi.Name = "textBox_terrainChoisi";
            this.textBox_terrainChoisi.ReadOnly = true;
            this.textBox_terrainChoisi.Size = new System.Drawing.Size(300, 55);
            this.textBox_terrainChoisi.TabIndex = 10;
            // 
            // textBox_nbAdults
            // 
            this.textBox_nbAdults.Location = new System.Drawing.Point(1289, 173);
            this.textBox_nbAdults.Name = "textBox_nbAdults";
            this.textBox_nbAdults.ReadOnly = true;
            this.textBox_nbAdults.Size = new System.Drawing.Size(300, 55);
            this.textBox_nbAdults.TabIndex = 11;
            // 
            // textBox_nbEnfants
            // 
            this.textBox_nbEnfants.Location = new System.Drawing.Point(1289, 265);
            this.textBox_nbEnfants.Name = "textBox_nbEnfants";
            this.textBox_nbEnfants.ReadOnly = true;
            this.textBox_nbEnfants.Size = new System.Drawing.Size(300, 55);
            this.textBox_nbEnfants.TabIndex = 12;
            // 
            // textBox_nbNuits
            // 
            this.textBox_nbNuits.Location = new System.Drawing.Point(1289, 366);
            this.textBox_nbNuits.Name = "textBox_nbNuits";
            this.textBox_nbNuits.ReadOnly = true;
            this.textBox_nbNuits.Size = new System.Drawing.Size(300, 55);
            this.textBox_nbNuits.TabIndex = 13;
            // 
            // textBox_typeDePaiement
            // 
            this.textBox_typeDePaiement.Location = new System.Drawing.Point(1289, 456);
            this.textBox_typeDePaiement.Name = "textBox_typeDePaiement";
            this.textBox_typeDePaiement.ReadOnly = true;
            this.textBox_typeDePaiement.Size = new System.Drawing.Size(300, 55);
            this.textBox_typeDePaiement.TabIndex = 14;
            // 
            // textBox_coutTotal
            // 
            this.textBox_coutTotal.Location = new System.Drawing.Point(1289, 556);
            this.textBox_coutTotal.Name = "textBox_coutTotal";
            this.textBox_coutTotal.ReadOnly = true;
            this.textBox_coutTotal.Size = new System.Drawing.Size(300, 55);
            this.textBox_coutTotal.TabIndex = 15;
            // 
            // AffichageReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 48F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1610, 668);
            this.Controls.Add(this.textBox_coutTotal);
            this.Controls.Add(this.textBox_typeDePaiement);
            this.Controls.Add(this.textBox_nbNuits);
            this.Controls.Add(this.textBox_nbEnfants);
            this.Controls.Add(this.textBox_nbAdults);
            this.Controls.Add(this.textBox_terrainChoisi);
            this.Controls.Add(this.label_totalCost);
            this.Controls.Add(this.label_typePaiement);
            this.Controls.Add(this.label_nombreDeNuits);
            this.Controls.Add(this.label_nbEnfantsAffichage);
            this.Controls.Add(this.label_nbAdultsAffichage);
            this.Controls.Add(this.label_terrainChoisi);
            this.Controls.Add(this.comboBox_reservations);
            this.Controls.Add(this.pictureBox_campingChoisieAffichage);
            this.Controls.Add(this.label_campingChoisiAffichage);
            this.Name = "AffichageReservation";
            this.Text = "Affichage de la réservation";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_campingChoisieAffichage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label_campingChoisiAffichage;
        private PictureBox pictureBox_campingChoisieAffichage;
        private ComboBox comboBox_reservations;
        private Label label_terrainChoisi;
        private Label label_nbAdultsAffichage;
        private Label label_nbEnfantsAffichage;
        private Label label_nombreDeNuits;
        private Label label_typePaiement;
        private Label label_totalCost;
        private TextBox textBox_terrainChoisi;
        private TextBox textBox_nbAdults;
        private TextBox textBox_nbEnfants;
        private TextBox textBox_nbNuits;
        private TextBox textBox_typeDePaiement;
        private TextBox textBox_coutTotal;
    }
}