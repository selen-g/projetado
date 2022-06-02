
namespace prjmagasin
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnRechercher = new System.Windows.Forms.Button();
            this.btnListeMagasin = new System.Windows.Forms.Button();
            this.btnCreer = new System.Windows.Forms.Button();
            this.btnMAJ = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtboxNum = new System.Windows.Forms.TextBox();
            this.txtBoxLocalite = new System.Windows.Forms.TextBox();
            this.txtBoxGerant = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBoxCommande = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboCommande = new System.Windows.Forms.ComboBox();
            this.groupBoxClient = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtBoxMail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBoxPrenom = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBoxNom = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnRechercherCli = new System.Windows.Forms.Button();
            this.txtBoxNumCli = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBoxMagasin = new System.Windows.Forms.GroupBox();
            this.richTBLigne = new System.Windows.Forms.RichTextBox();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBoxCommande.SuspendLayout();
            this.groupBoxClient.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBoxMagasin.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRechercher
            // 
            this.btnRechercher.Location = new System.Drawing.Point(159, 20);
            this.btnRechercher.Name = "btnRechercher";
            this.btnRechercher.Size = new System.Drawing.Size(118, 26);
            this.btnRechercher.TabIndex = 0;
            this.btnRechercher.Text = "Rechercher";
            this.btnRechercher.UseVisualStyleBackColor = true;
            this.btnRechercher.Click += new System.EventHandler(this.btnRechercher_Click);
            // 
            // btnListeMagasin
            // 
            this.btnListeMagasin.Location = new System.Drawing.Point(298, 39);
            this.btnListeMagasin.Name = "btnListeMagasin";
            this.btnListeMagasin.Size = new System.Drawing.Size(118, 27);
            this.btnListeMagasin.TabIndex = 1;
            this.btnListeMagasin.Text = "Liste des magasins";
            this.btnListeMagasin.UseVisualStyleBackColor = true;
            this.btnListeMagasin.Click += new System.EventHandler(this.btnListeMagasin_Click);
            // 
            // btnCreer
            // 
            this.btnCreer.Location = new System.Drawing.Point(298, 72);
            this.btnCreer.Name = "btnCreer";
            this.btnCreer.Size = new System.Drawing.Size(118, 26);
            this.btnCreer.TabIndex = 2;
            this.btnCreer.Text = "Créer";
            this.btnCreer.UseVisualStyleBackColor = true;
            this.btnCreer.Click += new System.EventHandler(this.btnCreer_Click);
            // 
            // btnMAJ
            // 
            this.btnMAJ.Location = new System.Drawing.Point(298, 104);
            this.btnMAJ.Name = "btnMAJ";
            this.btnMAJ.Size = new System.Drawing.Size(118, 26);
            this.btnMAJ.TabIndex = 3;
            this.btnMAJ.Text = "Mettre à jour";
            this.btnMAJ.UseVisualStyleBackColor = true;
            this.btnMAJ.Click += new System.EventHandler(this.btnMAJ_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(298, 136);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(118, 26);
            this.btnSupprimer.TabIndex = 4;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Numéro :";
            // 
            // txtboxNum
            // 
            this.txtboxNum.Location = new System.Drawing.Point(80, 24);
            this.txtboxNum.Name = "txtboxNum";
            this.txtboxNum.Size = new System.Drawing.Size(73, 20);
            this.txtboxNum.TabIndex = 6;
            // 
            // txtBoxLocalite
            // 
            this.txtBoxLocalite.Location = new System.Drawing.Point(90, 29);
            this.txtBoxLocalite.Name = "txtBoxLocalite";
            this.txtBoxLocalite.Size = new System.Drawing.Size(117, 20);
            this.txtBoxLocalite.TabIndex = 7;
            // 
            // txtBoxGerant
            // 
            this.txtBoxGerant.Location = new System.Drawing.Point(90, 66);
            this.txtBoxGerant.Name = "txtBoxGerant";
            this.txtBoxGerant.Size = new System.Drawing.Size(117, 20);
            this.txtBoxGerant.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Localité :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Gérant :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtBoxGerant);
            this.groupBox1.Controls.Add(this.txtBoxLocalite);
            this.groupBox1.Location = new System.Drawing.Point(27, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(236, 117);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informations";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBoxCommande
            // 
            this.groupBoxCommande.Controls.Add(this.label4);
            this.groupBoxCommande.Controls.Add(this.cboCommande);
            this.groupBoxCommande.Location = new System.Drawing.Point(40, 24);
            this.groupBoxCommande.Name = "groupBoxCommande";
            this.groupBoxCommande.Size = new System.Drawing.Size(446, 87);
            this.groupBoxCommande.TabIndex = 12;
            this.groupBoxCommande.TabStop = false;
            this.groupBoxCommande.Text = "Commande";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Rechercher une commande :";
            // 
            // cboCommande
            // 
            this.cboCommande.FormattingEnabled = true;
            this.cboCommande.Location = new System.Drawing.Point(185, 30);
            this.cboCommande.Name = "cboCommande";
            this.cboCommande.Size = new System.Drawing.Size(168, 21);
            this.cboCommande.TabIndex = 0;
            this.cboCommande.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // groupBoxClient
            // 
            this.groupBoxClient.Controls.Add(this.groupBox2);
            this.groupBoxClient.Controls.Add(this.btnRechercherCli);
            this.groupBoxClient.Controls.Add(this.txtBoxNumCli);
            this.groupBoxClient.Controls.Add(this.label5);
            this.groupBoxClient.Location = new System.Drawing.Point(40, 497);
            this.groupBoxClient.Name = "groupBoxClient";
            this.groupBoxClient.Size = new System.Drawing.Size(446, 211);
            this.groupBoxClient.TabIndex = 13;
            this.groupBoxClient.TabStop = false;
            this.groupBoxClient.Text = "Client";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtBoxMail);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtBoxPrenom);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtBoxNom);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(24, 77);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(252, 109);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Iinformations";
            // 
            // txtBoxMail
            // 
            this.txtBoxMail.Location = new System.Drawing.Point(69, 72);
            this.txtBoxMail.Name = "txtBoxMail";
            this.txtBoxMail.Size = new System.Drawing.Size(153, 20);
            this.txtBoxMail.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Mail :";
            // 
            // txtBoxPrenom
            // 
            this.txtBoxPrenom.Location = new System.Drawing.Point(69, 46);
            this.txtBoxPrenom.Name = "txtBoxPrenom";
            this.txtBoxPrenom.Size = new System.Drawing.Size(153, 20);
            this.txtBoxPrenom.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Prénom :";
            // 
            // txtBoxNom
            // 
            this.txtBoxNom.Location = new System.Drawing.Point(69, 20);
            this.txtBoxNom.Name = "txtBoxNom";
            this.txtBoxNom.Size = new System.Drawing.Size(153, 20);
            this.txtBoxNom.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Nom :";
            // 
            // btnRechercherCli
            // 
            this.btnRechercherCli.Location = new System.Drawing.Point(250, 28);
            this.btnRechercherCli.Name = "btnRechercherCli";
            this.btnRechercherCli.Size = new System.Drawing.Size(115, 27);
            this.btnRechercherCli.TabIndex = 2;
            this.btnRechercherCli.Text = "Rechercher";
            this.btnRechercherCli.UseVisualStyleBackColor = true;
            this.btnRechercherCli.Click += new System.EventHandler(this.btnRechercherCli_Click);
            // 
            // txtBoxNumCli
            // 
            this.txtBoxNumCli.Location = new System.Drawing.Point(93, 32);
            this.txtBoxNumCli.Name = "txtBoxNumCli";
            this.txtBoxNumCli.Size = new System.Drawing.Size(141, 20);
            this.txtBoxNumCli.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Numéro :";
            // 
            // groupBoxMagasin
            // 
            this.groupBoxMagasin.Controls.Add(this.groupBox1);
            this.groupBoxMagasin.Controls.Add(this.txtboxNum);
            this.groupBoxMagasin.Controls.Add(this.label1);
            this.groupBoxMagasin.Controls.Add(this.btnSupprimer);
            this.groupBoxMagasin.Controls.Add(this.btnMAJ);
            this.groupBoxMagasin.Controls.Add(this.btnCreer);
            this.groupBoxMagasin.Controls.Add(this.btnListeMagasin);
            this.groupBoxMagasin.Controls.Add(this.btnRechercher);
            this.groupBoxMagasin.Location = new System.Drawing.Point(40, 293);
            this.groupBoxMagasin.Name = "groupBoxMagasin";
            this.groupBoxMagasin.Size = new System.Drawing.Size(446, 198);
            this.groupBoxMagasin.TabIndex = 14;
            this.groupBoxMagasin.TabStop = false;
            this.groupBoxMagasin.Text = "Magasin";
            // 
            // richTBLigne
            // 
            this.richTBLigne.Location = new System.Drawing.Point(40, 117);
            this.richTBLigne.Name = "richTBLigne";
            this.richTBLigne.Size = new System.Drawing.Size(446, 161);
            this.richTBLigne.TabIndex = 15;
            this.richTBLigne.Text = "";
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(174, 714);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(158, 32);
            this.btnQuitter.TabIndex = 16;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 767);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.richTBLigne);
            this.Controls.Add(this.groupBoxMagasin);
            this.Controls.Add(this.groupBoxClient);
            this.Controls.Add(this.groupBoxCommande);
            this.Name = "Form1";
            this.Text = "Gestion";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxCommande.ResumeLayout(false);
            this.groupBoxCommande.PerformLayout();
            this.groupBoxClient.ResumeLayout(false);
            this.groupBoxClient.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBoxMagasin.ResumeLayout(false);
            this.groupBoxMagasin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRechercher;
        private System.Windows.Forms.Button btnListeMagasin;
        private System.Windows.Forms.Button btnCreer;
        private System.Windows.Forms.Button btnMAJ;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtboxNum;
        private System.Windows.Forms.TextBox txtBoxLocalite;
        private System.Windows.Forms.TextBox txtBoxGerant;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBoxCommande;
        private System.Windows.Forms.ComboBox cboCommande;
        private System.Windows.Forms.GroupBox groupBoxClient;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBoxMagasin;
        private System.Windows.Forms.Button btnRechercherCli;
        private System.Windows.Forms.TextBox txtBoxNumCli;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBoxMail;
        private System.Windows.Forms.TextBox txtBoxPrenom;
        private System.Windows.Forms.TextBox txtBoxNom;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox richTBLigne;
        private System.Windows.Forms.Button btnQuitter;
    }
}

