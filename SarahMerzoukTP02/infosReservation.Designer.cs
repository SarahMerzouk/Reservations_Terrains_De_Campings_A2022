namespace SarahMerzoukTP02
{
    partial class infosReservation
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
            this.components = new System.ComponentModel.Container();
            this.label_campingChoisi = new System.Windows.Forms.Label();
            this.pictureBox_campingChoisi = new System.Windows.Forms.PictureBox();
            this.comboBox_terrains = new System.Windows.Forms.ComboBox();
            this.button_reserver = new System.Windows.Forms.Button();
            this.button_terrainsDispos = new System.Windows.Forms.Button();
            this.label_T1 = new System.Windows.Forms.Label();
            this.label_T2 = new System.Windows.Forms.Label();
            this.label_T3 = new System.Windows.Forms.Label();
            this.label_T4 = new System.Windows.Forms.Label();
            this.label_T5 = new System.Windows.Forms.Label();
            this.label_T6 = new System.Windows.Forms.Label();
            this.label_T7 = new System.Windows.Forms.Label();
            this.label_T8 = new System.Windows.Forms.Label();
            this.label_T9 = new System.Windows.Forms.Label();
            this.label_T10 = new System.Windows.Forms.Label();
            this.richTextBox_T1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox_T2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox_T3 = new System.Windows.Forms.RichTextBox();
            this.richTextBox_T4 = new System.Windows.Forms.RichTextBox();
            this.richTextBox_T5 = new System.Windows.Forms.RichTextBox();
            this.richTextBox_T6 = new System.Windows.Forms.RichTextBox();
            this.richTextBox_T7 = new System.Windows.Forms.RichTextBox();
            this.richTextBox_T8 = new System.Windows.Forms.RichTextBox();
            this.richTextBox_T9 = new System.Windows.Forms.RichTextBox();
            this.richTextBox_T10 = new System.Windows.Forms.RichTextBox();
            this.label_enfants = new System.Windows.Forms.Label();
            this.numericUpDown_nbAdultes = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_nbEnfants = new System.Windows.Forms.NumericUpDown();
            this.label_adultes = new System.Windows.Forms.Label();
            this.label_selectionTerrains = new System.Windows.Forms.Label();
            this.label_infosSurQt = new System.Windows.Forms.Label();
            this.label_infosDuClient = new System.Windows.Forms.Label();
            this.label_nom = new System.Windows.Forms.Label();
            this.label_courriel = new System.Windows.Forms.Label();
            this.label_typeDePaiement = new System.Windows.Forms.Label();
            this.comboBox_typeDePaiement = new System.Windows.Forms.ComboBox();
            this.textBox_nom = new System.Windows.Forms.TextBox();
            this.textBox_courriel = new System.Windows.Forms.TextBox();
            this.label_facture = new System.Windows.Forms.Label();
            this.label_nbNuits = new System.Windows.Forms.Label();
            this.label_totalDeGens = new System.Windows.Forms.Label();
            this.label_nbEnfants = new System.Windows.Forms.Label();
            this.label_nbAdultes = new System.Windows.Forms.Label();
            this.textBox_nbNuits = new System.Windows.Forms.TextBox();
            this.textBox_nbPersonnes = new System.Windows.Forms.TextBox();
            this.textBox_nbAdultes = new System.Windows.Forms.TextBox();
            this.textBox_nbEnfants = new System.Windows.Forms.TextBox();
            this.label_coutTotal = new System.Windows.Forms.Label();
            this.textBox_coutTotal = new System.Windows.Forms.TextBox();
            this.statusStrip_reservation = new System.Windows.Forms.StatusStrip();
            this.toolStripStatus_reservation = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip_reservation = new System.Windows.Forms.MenuStrip();
            this.réservationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nouvelleRéservationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.faireLaRéservationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afficherUneRéservationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.retourAuMenuPrincipalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.errorProvider_nom = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider_courriel = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider_typePaiement = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider_maxDePersonnes = new System.Windows.Forms.ErrorProvider(this.components);
            this.saveFileDialogFichier = new System.Windows.Forms.SaveFileDialog();
            this.listBox_reservation = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_campingChoisi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_nbAdultes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_nbEnfants)).BeginInit();
            this.statusStrip_reservation.SuspendLayout();
            this.menuStrip_reservation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_nom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_courriel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_typePaiement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_maxDePersonnes)).BeginInit();
            this.SuspendLayout();
            // 
            // label_campingChoisi
            // 
            this.label_campingChoisi.AutoSize = true;
            this.label_campingChoisi.Font = new System.Drawing.Font("MV Boli", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label_campingChoisi.Location = new System.Drawing.Point(50, 47);
            this.label_campingChoisi.Name = "label_campingChoisi";
            this.label_campingChoisi.Size = new System.Drawing.Size(475, 85);
            this.label_campingChoisi.TabIndex = 0;
            this.label_campingChoisi.Text = "Camping choisi";
            // 
            // pictureBox_campingChoisi
            // 
            this.pictureBox_campingChoisi.Location = new System.Drawing.Point(50, 184);
            this.pictureBox_campingChoisi.Name = "pictureBox_campingChoisi";
            this.pictureBox_campingChoisi.Size = new System.Drawing.Size(594, 332);
            this.pictureBox_campingChoisi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_campingChoisi.TabIndex = 1;
            this.pictureBox_campingChoisi.TabStop = false;
            // 
            // comboBox_terrains
            // 
            this.comboBox_terrains.FormattingEnabled = true;
            this.comboBox_terrains.Location = new System.Drawing.Point(50, 574);
            this.comboBox_terrains.Name = "comboBox_terrains";
            this.comboBox_terrains.Size = new System.Drawing.Size(594, 56);
            this.comboBox_terrains.TabIndex = 2;
            this.comboBox_terrains.SelectedIndexChanged += new System.EventHandler(this.comboBox_terrains_SelectedIndexChanged);
            // 
            // button_reserver
            // 
            this.button_reserver.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_reserver.Location = new System.Drawing.Point(50, 1316);
            this.button_reserver.Name = "button_reserver";
            this.button_reserver.Size = new System.Drawing.Size(493, 84);
            this.button_reserver.TabIndex = 3;
            this.button_reserver.Text = "Réserver le terrain";
            this.button_reserver.UseVisualStyleBackColor = true;
            this.button_reserver.Click += new System.EventHandler(this.button_reserver_Click_1);
            // 
            // button_terrainsDispos
            // 
            this.button_terrainsDispos.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_terrainsDispos.Location = new System.Drawing.Point(50, 661);
            this.button_terrainsDispos.Name = "button_terrainsDispos";
            this.button_terrainsDispos.Size = new System.Drawing.Size(493, 89);
            this.button_terrainsDispos.TabIndex = 4;
            this.button_terrainsDispos.Text = "Vérifier les disponibilités";
            this.button_terrainsDispos.UseVisualStyleBackColor = true;
            this.button_terrainsDispos.Click += new System.EventHandler(this.button_terrainsDispos_Click);
            // 
            // label_T1
            // 
            this.label_T1.AutoSize = true;
            this.label_T1.Location = new System.Drawing.Point(50, 777);
            this.label_T1.Name = "label_T1";
            this.label_T1.Size = new System.Drawing.Size(156, 48);
            this.label_T1.TabIndex = 5;
            this.label_T1.Text = "Terrain 1";
            // 
            // label_T2
            // 
            this.label_T2.AutoSize = true;
            this.label_T2.Location = new System.Drawing.Point(50, 825);
            this.label_T2.Name = "label_T2";
            this.label_T2.Size = new System.Drawing.Size(156, 48);
            this.label_T2.TabIndex = 6;
            this.label_T2.Text = "Terrain 2";
            // 
            // label_T3
            // 
            this.label_T3.AutoSize = true;
            this.label_T3.Location = new System.Drawing.Point(50, 879);
            this.label_T3.Name = "label_T3";
            this.label_T3.Size = new System.Drawing.Size(156, 48);
            this.label_T3.TabIndex = 7;
            this.label_T3.Text = "Terrain 3";
            // 
            // label_T4
            // 
            this.label_T4.AutoSize = true;
            this.label_T4.Location = new System.Drawing.Point(50, 927);
            this.label_T4.Name = "label_T4";
            this.label_T4.Size = new System.Drawing.Size(156, 48);
            this.label_T4.TabIndex = 8;
            this.label_T4.Text = "Terrain 4";
            // 
            // label_T5
            // 
            this.label_T5.AutoSize = true;
            this.label_T5.Location = new System.Drawing.Point(50, 975);
            this.label_T5.Name = "label_T5";
            this.label_T5.Size = new System.Drawing.Size(156, 48);
            this.label_T5.TabIndex = 9;
            this.label_T5.Text = "Terrain 5";
            // 
            // label_T6
            // 
            this.label_T6.AutoSize = true;
            this.label_T6.Location = new System.Drawing.Point(50, 1023);
            this.label_T6.Name = "label_T6";
            this.label_T6.Size = new System.Drawing.Size(156, 48);
            this.label_T6.TabIndex = 10;
            this.label_T6.Text = "Terrain 6";
            // 
            // label_T7
            // 
            this.label_T7.AutoSize = true;
            this.label_T7.Location = new System.Drawing.Point(50, 1071);
            this.label_T7.Name = "label_T7";
            this.label_T7.Size = new System.Drawing.Size(156, 48);
            this.label_T7.TabIndex = 11;
            this.label_T7.Text = "Terrain 7";
            // 
            // label_T8
            // 
            this.label_T8.AutoSize = true;
            this.label_T8.Location = new System.Drawing.Point(50, 1119);
            this.label_T8.Name = "label_T8";
            this.label_T8.Size = new System.Drawing.Size(156, 48);
            this.label_T8.TabIndex = 12;
            this.label_T8.Text = "Terrain 8";
            // 
            // label_T9
            // 
            this.label_T9.AutoSize = true;
            this.label_T9.Location = new System.Drawing.Point(50, 1167);
            this.label_T9.Name = "label_T9";
            this.label_T9.Size = new System.Drawing.Size(156, 48);
            this.label_T9.TabIndex = 13;
            this.label_T9.Text = "Terrain 9";
            // 
            // label_T10
            // 
            this.label_T10.AutoSize = true;
            this.label_T10.Location = new System.Drawing.Point(50, 1215);
            this.label_T10.Name = "label_T10";
            this.label_T10.Size = new System.Drawing.Size(175, 48);
            this.label_T10.TabIndex = 14;
            this.label_T10.Text = "Terrain 10";
            // 
            // richTextBox_T1
            // 
            this.richTextBox_T1.Location = new System.Drawing.Point(230, 777);
            this.richTextBox_T1.Name = "richTextBox_T1";
            this.richTextBox_T1.Size = new System.Drawing.Size(102, 44);
            this.richTextBox_T1.TabIndex = 15;
            this.richTextBox_T1.Text = "";
            // 
            // richTextBox_T2
            // 
            this.richTextBox_T2.Location = new System.Drawing.Point(230, 827);
            this.richTextBox_T2.Name = "richTextBox_T2";
            this.richTextBox_T2.Size = new System.Drawing.Size(102, 46);
            this.richTextBox_T2.TabIndex = 16;
            this.richTextBox_T2.Text = "";
            // 
            // richTextBox_T3
            // 
            this.richTextBox_T3.Location = new System.Drawing.Point(230, 883);
            this.richTextBox_T3.Name = "richTextBox_T3";
            this.richTextBox_T3.Size = new System.Drawing.Size(102, 44);
            this.richTextBox_T3.TabIndex = 17;
            this.richTextBox_T3.Text = "";
            // 
            // richTextBox_T4
            // 
            this.richTextBox_T4.Location = new System.Drawing.Point(230, 933);
            this.richTextBox_T4.Name = "richTextBox_T4";
            this.richTextBox_T4.Size = new System.Drawing.Size(102, 44);
            this.richTextBox_T4.TabIndex = 18;
            this.richTextBox_T4.Text = "";
            // 
            // richTextBox_T5
            // 
            this.richTextBox_T5.Location = new System.Drawing.Point(230, 979);
            this.richTextBox_T5.Name = "richTextBox_T5";
            this.richTextBox_T5.Size = new System.Drawing.Size(102, 44);
            this.richTextBox_T5.TabIndex = 19;
            this.richTextBox_T5.Text = "";
            // 
            // richTextBox_T6
            // 
            this.richTextBox_T6.Location = new System.Drawing.Point(230, 1029);
            this.richTextBox_T6.Name = "richTextBox_T6";
            this.richTextBox_T6.Size = new System.Drawing.Size(102, 44);
            this.richTextBox_T6.TabIndex = 20;
            this.richTextBox_T6.Text = "";
            // 
            // richTextBox_T7
            // 
            this.richTextBox_T7.Location = new System.Drawing.Point(230, 1079);
            this.richTextBox_T7.Name = "richTextBox_T7";
            this.richTextBox_T7.Size = new System.Drawing.Size(102, 44);
            this.richTextBox_T7.TabIndex = 21;
            this.richTextBox_T7.Text = "";
            // 
            // richTextBox_T8
            // 
            this.richTextBox_T8.Location = new System.Drawing.Point(230, 1129);
            this.richTextBox_T8.Name = "richTextBox_T8";
            this.richTextBox_T8.Size = new System.Drawing.Size(102, 44);
            this.richTextBox_T8.TabIndex = 22;
            this.richTextBox_T8.Text = "";
            // 
            // richTextBox_T9
            // 
            this.richTextBox_T9.Location = new System.Drawing.Point(231, 1179);
            this.richTextBox_T9.Name = "richTextBox_T9";
            this.richTextBox_T9.Size = new System.Drawing.Size(102, 47);
            this.richTextBox_T9.TabIndex = 23;
            this.richTextBox_T9.Text = "";
            // 
            // richTextBox_T10
            // 
            this.richTextBox_T10.Location = new System.Drawing.Point(230, 1232);
            this.richTextBox_T10.Name = "richTextBox_T10";
            this.richTextBox_T10.Size = new System.Drawing.Size(102, 45);
            this.richTextBox_T10.TabIndex = 24;
            this.richTextBox_T10.Text = "";
            // 
            // label_enfants
            // 
            this.label_enfants.AutoSize = true;
            this.label_enfants.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_enfants.Location = new System.Drawing.Point(919, 304);
            this.label_enfants.Name = "label_enfants";
            this.label_enfants.Size = new System.Drawing.Size(419, 46);
            this.label_enfants.TabIndex = 26;
            this.label_enfants.Text = "Enfants (0 à 17 ans) :";
            // 
            // numericUpDown_nbAdultes
            // 
            this.numericUpDown_nbAdultes.Location = new System.Drawing.Point(1363, 234);
            this.numericUpDown_nbAdultes.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numericUpDown_nbAdultes.Name = "numericUpDown_nbAdultes";
            this.numericUpDown_nbAdultes.Size = new System.Drawing.Size(300, 55);
            this.numericUpDown_nbAdultes.TabIndex = 27;
            this.numericUpDown_nbAdultes.ValueChanged += new System.EventHandler(this.numericUpDown_nbAdultes_ValueChanged);
            // 
            // numericUpDown_nbEnfants
            // 
            this.numericUpDown_nbEnfants.Location = new System.Drawing.Point(1363, 295);
            this.numericUpDown_nbEnfants.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numericUpDown_nbEnfants.Name = "numericUpDown_nbEnfants";
            this.numericUpDown_nbEnfants.Size = new System.Drawing.Size(300, 55);
            this.numericUpDown_nbEnfants.TabIndex = 28;
            this.numericUpDown_nbEnfants.ValueChanged += new System.EventHandler(this.numericUpDown_nbEnfants_ValueChanged);
            // 
            // label_adultes
            // 
            this.label_adultes.AutoSize = true;
            this.label_adultes.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_adultes.Location = new System.Drawing.Point(919, 243);
            this.label_adultes.Name = "label_adultes";
            this.label_adultes.Size = new System.Drawing.Size(177, 46);
            this.label_adultes.TabIndex = 25;
            this.label_adultes.Text = "Adultes :";
            // 
            // label_selectionTerrains
            // 
            this.label_selectionTerrains.AutoSize = true;
            this.label_selectionTerrains.Font = new System.Drawing.Font("MV Boli", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_selectionTerrains.Location = new System.Drawing.Point(50, 519);
            this.label_selectionTerrains.Name = "label_selectionTerrains";
            this.label_selectionTerrains.Size = new System.Drawing.Size(417, 52);
            this.label_selectionTerrains.TabIndex = 33;
            this.label_selectionTerrains.Text = "Sélection du terrain";
            // 
            // label_infosSurQt
            // 
            this.label_infosSurQt.AutoSize = true;
            this.label_infosSurQt.Font = new System.Drawing.Font("MV Boli", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_infosSurQt.Location = new System.Drawing.Point(919, 154);
            this.label_infosSurQt.Name = "label_infosSurQt";
            this.label_infosSurQt.Size = new System.Drawing.Size(447, 52);
            this.label_infosSurQt.TabIndex = 34;
            this.label_infosSurQt.Text = "Nombre de personnes";
            // 
            // label_infosDuClient
            // 
            this.label_infosDuClient.AutoSize = true;
            this.label_infosDuClient.Font = new System.Drawing.Font("MV Boli", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_infosDuClient.Location = new System.Drawing.Point(919, 533);
            this.label_infosDuClient.Name = "label_infosDuClient";
            this.label_infosDuClient.Size = new System.Drawing.Size(810, 52);
            this.label_infosDuClient.TabIndex = 35;
            this.label_infosDuClient.Text = "Informations de la personne qui réserve";
            // 
            // label_nom
            // 
            this.label_nom.AutoSize = true;
            this.label_nom.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_nom.Location = new System.Drawing.Point(928, 597);
            this.label_nom.Name = "label_nom";
            this.label_nom.Size = new System.Drawing.Size(129, 46);
            this.label_nom.TabIndex = 36;
            this.label_nom.Text = "Nom :";
            // 
            // label_courriel
            // 
            this.label_courriel.AutoSize = true;
            this.label_courriel.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_courriel.Location = new System.Drawing.Point(928, 664);
            this.label_courriel.Name = "label_courriel";
            this.label_courriel.Size = new System.Drawing.Size(177, 46);
            this.label_courriel.TabIndex = 37;
            this.label_courriel.Text = "Courriel :";
            // 
            // label_typeDePaiement
            // 
            this.label_typeDePaiement.AutoSize = true;
            this.label_typeDePaiement.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_typeDePaiement.Location = new System.Drawing.Point(919, 714);
            this.label_typeDePaiement.Name = "label_typeDePaiement";
            this.label_typeDePaiement.Size = new System.Drawing.Size(357, 46);
            this.label_typeDePaiement.TabIndex = 38;
            this.label_typeDePaiement.Text = "Type de paiement :";
            // 
            // comboBox_typeDePaiement
            // 
            this.comboBox_typeDePaiement.FormattingEnabled = true;
            this.comboBox_typeDePaiement.Location = new System.Drawing.Point(1296, 709);
            this.comboBox_typeDePaiement.Name = "comboBox_typeDePaiement";
            this.comboBox_typeDePaiement.Size = new System.Drawing.Size(363, 56);
            this.comboBox_typeDePaiement.TabIndex = 39;
            this.comboBox_typeDePaiement.SelectedIndexChanged += new System.EventHandler(this.comboBox_typeDePaiement_SelectedIndexChanged);
            // 
            // textBox_nom
            // 
            this.textBox_nom.Location = new System.Drawing.Point(1296, 588);
            this.textBox_nom.Name = "textBox_nom";
            this.textBox_nom.Size = new System.Drawing.Size(363, 55);
            this.textBox_nom.TabIndex = 40;
            this.textBox_nom.TextChanged += new System.EventHandler(this.textBox_nom_TextChanged);
            // 
            // textBox_courriel
            // 
            this.textBox_courriel.Location = new System.Drawing.Point(1296, 648);
            this.textBox_courriel.Name = "textBox_courriel";
            this.textBox_courriel.Size = new System.Drawing.Size(363, 55);
            this.textBox_courriel.TabIndex = 41;
            this.textBox_courriel.TextChanged += new System.EventHandler(this.textBox_courriel_TextChanged);
            // 
            // label_facture
            // 
            this.label_facture.AutoSize = true;
            this.label_facture.Font = new System.Drawing.Font("MV Boli", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_facture.Location = new System.Drawing.Point(909, 816);
            this.label_facture.Name = "label_facture";
            this.label_facture.Size = new System.Drawing.Size(209, 52);
            this.label_facture.TabIndex = 42;
            this.label_facture.Text = "FACTURE";
            // 
            // label_nbNuits
            // 
            this.label_nbNuits.AutoSize = true;
            this.label_nbNuits.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_nbNuits.Location = new System.Drawing.Point(919, 1088);
            this.label_nbNuits.Name = "label_nbNuits";
            this.label_nbNuits.Size = new System.Drawing.Size(338, 46);
            this.label_nbNuits.TabIndex = 46;
            this.label_nbNuits.Text = "Nombre de nuits :";
            // 
            // label_totalDeGens
            // 
            this.label_totalDeGens.AutoSize = true;
            this.label_totalDeGens.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_totalDeGens.Location = new System.Drawing.Point(919, 1025);
            this.label_totalDeGens.Name = "label_totalDeGens";
            this.label_totalDeGens.Size = new System.Drawing.Size(390, 46);
            this.label_totalDeGens.TabIndex = 45;
            this.label_totalDeGens.Text = "Total de personnes : ";
            // 
            // label_nbEnfants
            // 
            this.label_nbEnfants.AutoSize = true;
            this.label_nbEnfants.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_nbEnfants.Location = new System.Drawing.Point(919, 966);
            this.label_nbEnfants.Name = "label_nbEnfants";
            this.label_nbEnfants.Size = new System.Drawing.Size(419, 46);
            this.label_nbEnfants.TabIndex = 44;
            this.label_nbEnfants.Text = "Enfants (0 à 17 ans) :";
            // 
            // label_nbAdultes
            // 
            this.label_nbAdultes.AutoSize = true;
            this.label_nbAdultes.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_nbAdultes.Location = new System.Drawing.Point(919, 905);
            this.label_nbAdultes.Name = "label_nbAdultes";
            this.label_nbAdultes.Size = new System.Drawing.Size(177, 46);
            this.label_nbAdultes.TabIndex = 43;
            this.label_nbAdultes.Text = "Adultes :";
            // 
            // textBox_nbNuits
            // 
            this.textBox_nbNuits.Location = new System.Drawing.Point(1344, 1074);
            this.textBox_nbNuits.Name = "textBox_nbNuits";
            this.textBox_nbNuits.ReadOnly = true;
            this.textBox_nbNuits.Size = new System.Drawing.Size(321, 55);
            this.textBox_nbNuits.TabIndex = 48;
            // 
            // textBox_nbPersonnes
            // 
            this.textBox_nbPersonnes.Location = new System.Drawing.Point(1344, 1011);
            this.textBox_nbPersonnes.Name = "textBox_nbPersonnes";
            this.textBox_nbPersonnes.ReadOnly = true;
            this.textBox_nbPersonnes.Size = new System.Drawing.Size(321, 55);
            this.textBox_nbPersonnes.TabIndex = 47;
            // 
            // textBox_nbAdultes
            // 
            this.textBox_nbAdultes.Location = new System.Drawing.Point(1344, 883);
            this.textBox_nbAdultes.Name = "textBox_nbAdultes";
            this.textBox_nbAdultes.ReadOnly = true;
            this.textBox_nbAdultes.Size = new System.Drawing.Size(321, 55);
            this.textBox_nbAdultes.TabIndex = 49;
            // 
            // textBox_nbEnfants
            // 
            this.textBox_nbEnfants.Location = new System.Drawing.Point(1344, 950);
            this.textBox_nbEnfants.Name = "textBox_nbEnfants";
            this.textBox_nbEnfants.ReadOnly = true;
            this.textBox_nbEnfants.Size = new System.Drawing.Size(321, 55);
            this.textBox_nbEnfants.TabIndex = 50;
            // 
            // label_coutTotal
            // 
            this.label_coutTotal.AutoSize = true;
            this.label_coutTotal.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_coutTotal.Location = new System.Drawing.Point(919, 1156);
            this.label_coutTotal.Name = "label_coutTotal";
            this.label_coutTotal.Size = new System.Drawing.Size(231, 46);
            this.label_coutTotal.TabIndex = 51;
            this.label_coutTotal.Text = "Coût total :";
            // 
            // textBox_coutTotal
            // 
            this.textBox_coutTotal.Location = new System.Drawing.Point(1338, 1135);
            this.textBox_coutTotal.Name = "textBox_coutTotal";
            this.textBox_coutTotal.ReadOnly = true;
            this.textBox_coutTotal.Size = new System.Drawing.Size(321, 55);
            this.textBox_coutTotal.TabIndex = 52;
            // 
            // statusStrip_reservation
            // 
            this.statusStrip_reservation.ImageScalingSize = new System.Drawing.Size(48, 48);
            this.statusStrip_reservation.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatus_reservation});
            this.statusStrip_reservation.Location = new System.Drawing.Point(0, 1440);
            this.statusStrip_reservation.Name = "statusStrip_reservation";
            this.statusStrip_reservation.Size = new System.Drawing.Size(1782, 63);
            this.statusStrip_reservation.TabIndex = 53;
            this.statusStrip_reservation.Text = "statusStrip1";
            // 
            // toolStripStatus_reservation
            // 
            this.toolStripStatus_reservation.Name = "toolStripStatus_reservation";
            this.toolStripStatus_reservation.Size = new System.Drawing.Size(442, 48);
            this.toolStripStatus_reservation.Text = "toolStripStatus_reservation";
            // 
            // menuStrip_reservation
            // 
            this.menuStrip_reservation.ImageScalingSize = new System.Drawing.Size(48, 48);
            this.menuStrip_reservation.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.réservationToolStripMenuItem});
            this.menuStrip_reservation.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_reservation.Name = "menuStrip_reservation";
            this.menuStrip_reservation.Size = new System.Drawing.Size(1782, 56);
            this.menuStrip_reservation.TabIndex = 54;
            this.menuStrip_reservation.Text = "menuStrip1";
            // 
            // réservationToolStripMenuItem
            // 
            this.réservationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nouvelleRéservationToolStripMenuItem,
            this.faireLaRéservationToolStripMenuItem,
            this.afficherUneRéservationToolStripMenuItem,
            this.retourAuMenuPrincipalToolStripMenuItem});
            this.réservationToolStripMenuItem.Name = "réservationToolStripMenuItem";
            this.réservationToolStripMenuItem.Size = new System.Drawing.Size(232, 52);
            this.réservationToolStripMenuItem.Text = "Réservation";
            // 
            // nouvelleRéservationToolStripMenuItem
            // 
            this.nouvelleRéservationToolStripMenuItem.Name = "nouvelleRéservationToolStripMenuItem";
            this.nouvelleRéservationToolStripMenuItem.Size = new System.Drawing.Size(619, 66);
            this.nouvelleRéservationToolStripMenuItem.Text = "Nouvelle réservation";
            this.nouvelleRéservationToolStripMenuItem.Click += new System.EventHandler(this.nouvelleRéservationToolStripMenuItem_Click);
            // 
            // faireLaRéservationToolStripMenuItem
            // 
            this.faireLaRéservationToolStripMenuItem.Name = "faireLaRéservationToolStripMenuItem";
            this.faireLaRéservationToolStripMenuItem.Size = new System.Drawing.Size(619, 66);
            this.faireLaRéservationToolStripMenuItem.Text = "Faire la réservation";
            this.faireLaRéservationToolStripMenuItem.Click += new System.EventHandler(this.faireLaRéservationToolStripMenuItem_Click);
            // 
            // afficherUneRéservationToolStripMenuItem
            // 
            this.afficherUneRéservationToolStripMenuItem.Name = "afficherUneRéservationToolStripMenuItem";
            this.afficherUneRéservationToolStripMenuItem.Size = new System.Drawing.Size(619, 66);
            this.afficherUneRéservationToolStripMenuItem.Text = "Afficher une réservation";
            this.afficherUneRéservationToolStripMenuItem.Click += new System.EventHandler(this.afficherUneRéservationToolStripMenuItem_Click);
            // 
            // retourAuMenuPrincipalToolStripMenuItem
            // 
            this.retourAuMenuPrincipalToolStripMenuItem.Name = "retourAuMenuPrincipalToolStripMenuItem";
            this.retourAuMenuPrincipalToolStripMenuItem.Size = new System.Drawing.Size(619, 66);
            this.retourAuMenuPrincipalToolStripMenuItem.Text = "Retour au menu principal";
            this.retourAuMenuPrincipalToolStripMenuItem.Click += new System.EventHandler(this.retourAuMenuPrincipalToolStripMenuItem_Click);
            // 
            // errorProvider_nom
            // 
            this.errorProvider_nom.ContainerControl = this;
            // 
            // errorProvider_courriel
            // 
            this.errorProvider_courriel.ContainerControl = this;
            // 
            // errorProvider_typePaiement
            // 
            this.errorProvider_typePaiement.ContainerControl = this;
            // 
            // errorProvider_maxDePersonnes
            // 
            this.errorProvider_maxDePersonnes.ContainerControl = this;
            // 
            // listBox_reservation
            // 
            this.listBox_reservation.FormattingEnabled = true;
            this.listBox_reservation.ItemHeight = 48;
            this.listBox_reservation.Location = new System.Drawing.Point(384, 777);
            this.listBox_reservation.Name = "listBox_reservation";
            this.listBox_reservation.Size = new System.Drawing.Size(482, 484);
            this.listBox_reservation.TabIndex = 56;
            // 
            // infosReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 48F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1782, 1503);
            this.Controls.Add(this.listBox_reservation);
            this.Controls.Add(this.statusStrip_reservation);
            this.Controls.Add(this.menuStrip_reservation);
            this.Controls.Add(this.textBox_coutTotal);
            this.Controls.Add(this.label_coutTotal);
            this.Controls.Add(this.textBox_nbEnfants);
            this.Controls.Add(this.textBox_nbAdultes);
            this.Controls.Add(this.textBox_nbNuits);
            this.Controls.Add(this.textBox_nbPersonnes);
            this.Controls.Add(this.label_nbNuits);
            this.Controls.Add(this.label_totalDeGens);
            this.Controls.Add(this.label_nbEnfants);
            this.Controls.Add(this.label_nbAdultes);
            this.Controls.Add(this.label_facture);
            this.Controls.Add(this.textBox_courriel);
            this.Controls.Add(this.textBox_nom);
            this.Controls.Add(this.comboBox_typeDePaiement);
            this.Controls.Add(this.label_typeDePaiement);
            this.Controls.Add(this.label_courriel);
            this.Controls.Add(this.label_nom);
            this.Controls.Add(this.label_infosDuClient);
            this.Controls.Add(this.label_infosSurQt);
            this.Controls.Add(this.label_selectionTerrains);
            this.Controls.Add(this.numericUpDown_nbEnfants);
            this.Controls.Add(this.numericUpDown_nbAdultes);
            this.Controls.Add(this.label_enfants);
            this.Controls.Add(this.label_adultes);
            this.Controls.Add(this.richTextBox_T10);
            this.Controls.Add(this.richTextBox_T9);
            this.Controls.Add(this.richTextBox_T8);
            this.Controls.Add(this.richTextBox_T7);
            this.Controls.Add(this.richTextBox_T6);
            this.Controls.Add(this.richTextBox_T5);
            this.Controls.Add(this.richTextBox_T4);
            this.Controls.Add(this.richTextBox_T3);
            this.Controls.Add(this.richTextBox_T2);
            this.Controls.Add(this.richTextBox_T1);
            this.Controls.Add(this.label_T10);
            this.Controls.Add(this.label_T9);
            this.Controls.Add(this.label_T8);
            this.Controls.Add(this.label_T7);
            this.Controls.Add(this.label_T6);
            this.Controls.Add(this.label_T5);
            this.Controls.Add(this.label_T4);
            this.Controls.Add(this.label_T3);
            this.Controls.Add(this.label_T2);
            this.Controls.Add(this.label_T1);
            this.Controls.Add(this.button_terrainsDispos);
            this.Controls.Add(this.button_reserver);
            this.Controls.Add(this.comboBox_terrains);
            this.Controls.Add(this.pictureBox_campingChoisi);
            this.Controls.Add(this.label_campingChoisi);
            this.Name = "infosReservation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Entrée des informations concernant la réservation";
            this.Load += new System.EventHandler(this.Reservation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_campingChoisi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_nbAdultes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_nbEnfants)).EndInit();
            this.statusStrip_reservation.ResumeLayout(false);
            this.statusStrip_reservation.PerformLayout();
            this.menuStrip_reservation.ResumeLayout(false);
            this.menuStrip_reservation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_nom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_courriel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_typePaiement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_maxDePersonnes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label_campingChoisi;
        private PictureBox pictureBox_campingChoisi;
        private ComboBox comboBox_terrains;
        private Button button_reserver;
        private Button button_terrainsDispos;
        private Label label_T1;
        private Label label_T2;
        private Label label_T3;
        private Label label_T4;
        private Label label_T5;
        private Label label_T6;
        private Label label_T7;
        private Label label_T8;
        private Label label_T9;
        private Label label_T10;
        private RichTextBox richTextBox_T1;
        private RichTextBox richTextBox_T2;
        private RichTextBox richTextBox_T3;
        private RichTextBox richTextBox_T4;
        private RichTextBox richTextBox_T5;
        private RichTextBox richTextBox_T6;
        private RichTextBox richTextBox_T7;
        private RichTextBox richTextBox_T8;
        private RichTextBox richTextBox_T9;
        private RichTextBox richTextBox_T10;
        private Label label_enfants;
        private NumericUpDown numericUpDown_nbAdultes;
        private NumericUpDown numericUpDown_nbEnfants;
        private Label label_adultes;
        private Label label_selectionTerrains;
        private Label label_infosSurQt;
        private Label label_infosDuClient;
        private Label label_nom;
        private Label label_courriel;
        private Label label_typeDePaiement;
        private ComboBox comboBox_typeDePaiement;
        private TextBox textBox_nom;
        private TextBox textBox_courriel;
        private Label label_facture;
        private Label label_nbNuits;
        private Label label_totalDeGens;
        private Label label_nbEnfants;
        private Label label_nbAdultes;
        private TextBox textBox_nbNuits;
        private TextBox textBox_nbPersonnes;
        private TextBox textBox_nbAdultes;
        private TextBox textBox_nbEnfants;
        private Label label_coutTotal;
        private TextBox textBox_coutTotal;
        private StatusStrip statusStrip_reservation;
        private ToolStripStatusLabel toolStripStatus_reservation;
        private MenuStrip menuStrip_reservation;
        private ToolStripMenuItem réservationToolStripMenuItem;
        private ToolStripMenuItem nouvelleRéservationToolStripMenuItem;
        private ToolStripMenuItem faireLaRéservationToolStripMenuItem;
        private ToolStripMenuItem afficherUneRéservationToolStripMenuItem;
        private ToolStripMenuItem retourAuMenuPrincipalToolStripMenuItem;
        private ErrorProvider errorProvider_nom;
        private ErrorProvider errorProvider_courriel;
        private ErrorProvider errorProvider_typePaiement;
        private ErrorProvider errorProvider_maxDePersonnes;
        private SaveFileDialog saveFileDialogFichier;
        private ListBox listBox_reservation;
    }
}