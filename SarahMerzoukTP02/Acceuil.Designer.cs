namespace SarahMerzoukTP02
{
    partial class Acceuil
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Acceuil));
            this.pictureBox_icon = new System.Windows.Forms.PictureBox();
            this.label_campingQC = new System.Windows.Forms.Label();
            this.label_sysoReservationHebergement = new System.Windows.Forms.Label();
            this.pictureBox_campings = new System.Windows.Forms.PictureBox();
            this.comboBox_choixHebergement = new System.Windows.Forms.ComboBox();
            this.dateTimePicker_debut = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_fin = new System.Windows.Forms.DateTimePicker();
            this.label_dateDebut = new System.Windows.Forms.Label();
            this.label_dateFin = new System.Windows.Forms.Label();
            this.button_reservation = new System.Windows.Forms.Button();
            this.button_quitter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_campings)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_icon
            // 
            this.pictureBox_icon.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_icon.Image")));
            this.pictureBox_icon.Location = new System.Drawing.Point(37, 47);
            this.pictureBox_icon.Name = "pictureBox_icon";
            this.pictureBox_icon.Size = new System.Drawing.Size(203, 148);
            this.pictureBox_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_icon.TabIndex = 0;
            this.pictureBox_icon.TabStop = false;
            // 
            // label_campingQC
            // 
            this.label_campingQC.AutoSize = true;
            this.label_campingQC.Font = new System.Drawing.Font("MV Boli", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label_campingQC.Location = new System.Drawing.Point(266, 47);
            this.label_campingQC.Name = "label_campingQC";
            this.label_campingQC.Size = new System.Drawing.Size(348, 73);
            this.label_campingQC.TabIndex = 1;
            this.label_campingQC.Text = "Camping QC";
            // 
            // label_sysoReservationHebergement
            // 
            this.label_sysoReservationHebergement.AutoSize = true;
            this.label_sysoReservationHebergement.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_sysoReservationHebergement.Location = new System.Drawing.Point(266, 136);
            this.label_sysoReservationHebergement.Name = "label_sysoReservationHebergement";
            this.label_sysoReservationHebergement.Size = new System.Drawing.Size(691, 46);
            this.label_sysoReservationHebergement.TabIndex = 2;
            this.label_sysoReservationHebergement.Text = "Système de réservation - Hebergement";
            // 
            // pictureBox_campings
            // 
            this.pictureBox_campings.Location = new System.Drawing.Point(112, 209);
            this.pictureBox_campings.Name = "pictureBox_campings";
            this.pictureBox_campings.Size = new System.Drawing.Size(757, 410);
            this.pictureBox_campings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_campings.TabIndex = 3;
            this.pictureBox_campings.TabStop = false;
            // 
            // comboBox_choixHebergement
            // 
            this.comboBox_choixHebergement.FormattingEnabled = true;
            this.comboBox_choixHebergement.Location = new System.Drawing.Point(37, 634);
            this.comboBox_choixHebergement.Name = "comboBox_choixHebergement";
            this.comboBox_choixHebergement.Size = new System.Drawing.Size(920, 56);
            this.comboBox_choixHebergement.TabIndex = 4;
            this.comboBox_choixHebergement.SelectedIndexChanged += new System.EventHandler(this.comboBox_choixHebergement_SelectedIndexChanged);
            // 
            // dateTimePicker_debut
            // 
            this.dateTimePicker_debut.Location = new System.Drawing.Point(37, 800);
            this.dateTimePicker_debut.MaxDate = new System.DateTime(2022, 10, 30, 0, 0, 0, 0);
            this.dateTimePicker_debut.MinDate = new System.DateTime(2022, 5, 1, 0, 0, 0, 0);
            this.dateTimePicker_debut.Name = "dateTimePicker_debut";
            this.dateTimePicker_debut.Size = new System.Drawing.Size(411, 55);
            this.dateTimePicker_debut.TabIndex = 5;
            this.dateTimePicker_debut.Value = new System.DateTime(2022, 10, 30, 0, 0, 0, 0);
            // 
            // dateTimePicker_fin
            // 
            this.dateTimePicker_fin.Location = new System.Drawing.Point(507, 800);
            this.dateTimePicker_fin.MaxDate = new System.DateTime(2022, 10, 31, 0, 0, 0, 0);
            this.dateTimePicker_fin.MinDate = new System.DateTime(2022, 5, 2, 0, 0, 0, 0);
            this.dateTimePicker_fin.Name = "dateTimePicker_fin";
            this.dateTimePicker_fin.Size = new System.Drawing.Size(450, 55);
            this.dateTimePicker_fin.TabIndex = 6;
            this.dateTimePicker_fin.Value = new System.DateTime(2022, 10, 26, 0, 0, 0, 0);
            // 
            // label_dateDebut
            // 
            this.label_dateDebut.AutoSize = true;
            this.label_dateDebut.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_dateDebut.Location = new System.Drawing.Point(37, 720);
            this.label_dateDebut.Name = "label_dateDebut";
            this.label_dateDebut.Size = new System.Drawing.Size(255, 46);
            this.label_dateDebut.TabIndex = 7;
            this.label_dateDebut.Text = "Date d\'arrivée";
            // 
            // label_dateFin
            // 
            this.label_dateFin.AutoSize = true;
            this.label_dateFin.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_dateFin.Location = new System.Drawing.Point(675, 720);
            this.label_dateFin.Name = "label_dateFin";
            this.label_dateFin.Size = new System.Drawing.Size(282, 46);
            this.label_dateFin.TabIndex = 8;
            this.label_dateFin.Text = "Date de départ";
            // 
            // button_reservation
            // 
            this.button_reservation.Location = new System.Drawing.Point(37, 891);
            this.button_reservation.Name = "button_reservation";
            this.button_reservation.Size = new System.Drawing.Size(411, 102);
            this.button_reservation.TabIndex = 9;
            this.button_reservation.Text = "Réservation";
            this.button_reservation.UseVisualStyleBackColor = true;
            this.button_reservation.Click += new System.EventHandler(this.button_reservation_Click);
            // 
            // button_quitter
            // 
            this.button_quitter.Location = new System.Drawing.Point(507, 891);
            this.button_quitter.Name = "button_quitter";
            this.button_quitter.Size = new System.Drawing.Size(450, 102);
            this.button_quitter.TabIndex = 10;
            this.button_quitter.Text = "Quitter";
            this.button_quitter.UseVisualStyleBackColor = true;
            this.button_quitter.Click += new System.EventHandler(this.button_quitter_Click);
            // 
            // Acceuil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 48F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 1011);
            this.Controls.Add(this.button_quitter);
            this.Controls.Add(this.button_reservation);
            this.Controls.Add(this.label_dateFin);
            this.Controls.Add(this.label_dateDebut);
            this.Controls.Add(this.dateTimePicker_fin);
            this.Controls.Add(this.dateTimePicker_debut);
            this.Controls.Add(this.comboBox_choixHebergement);
            this.Controls.Add(this.pictureBox_campings);
            this.Controls.Add(this.label_sysoReservationHebergement);
            this.Controls.Add(this.label_campingQC);
            this.Controls.Add(this.pictureBox_icon);
            this.Name = "Acceuil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TP02 - Merzouk Sarah";
            this.Load += new System.EventHandler(this.Acceuil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_campings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox_icon;
        private Label label_campingQC;
        private Label label_sysoReservationHebergement;
        private PictureBox pictureBox_campings;
        private ComboBox comboBox_choixHebergement;
        private DateTimePicker dateTimePicker_debut;
        private DateTimePicker dateTimePicker_fin;
        private Label label_dateDebut;
        private Label label_dateFin;
        private Button button_reservation;
        private Button button_quitter;
    }
}