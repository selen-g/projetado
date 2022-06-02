
namespace TestADO
{
    partial class FrmADO
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
            this.cmdInfo = new System.Windows.Forms.Button();
            this.cmdNbClient = new System.Windows.Forms.Button();
            this.cmdCA = new System.Windows.Forms.Button();
            this.txtPrix = new System.Windows.Forms.TextBox();
            this.cmdModifierPrixArticle3 = new System.Windows.Forms.Button();
            this.txtCodeArticle = new System.Windows.Forms.TextBox();
            this.txtNouveauPrix = new System.Windows.Forms.TextBox();
            this.txtmagasin = new System.Windows.Forms.TextBox();
            this.btnEx7 = new System.Windows.Forms.Button();
            this.cboArticle = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cmdInfo
            // 
            this.cmdInfo.Location = new System.Drawing.Point(131, 51);
            this.cmdInfo.Name = "cmdInfo";
            this.cmdInfo.Size = new System.Drawing.Size(140, 85);
            this.cmdInfo.TabIndex = 0;
            this.cmdInfo.Text = "information connexion SQL Server";
            this.cmdInfo.UseVisualStyleBackColor = true;
            this.cmdInfo.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmdNbClient
            // 
            this.cmdNbClient.Location = new System.Drawing.Point(131, 160);
            this.cmdNbClient.Name = "cmdNbClient";
            this.cmdNbClient.Size = new System.Drawing.Size(140, 60);
            this.cmdNbClient.TabIndex = 1;
            this.cmdNbClient.Text = "Afficher le nombre de clients";
            this.cmdNbClient.UseVisualStyleBackColor = true;
            this.cmdNbClient.Click += new System.EventHandler(this.cmdNbClient_Click);
            // 
            // cmdCA
            // 
            this.cmdCA.Location = new System.Drawing.Point(131, 256);
            this.cmdCA.Name = "cmdCA";
            this.cmdCA.Size = new System.Drawing.Size(140, 50);
            this.cmdCA.TabIndex = 2;
            this.cmdCA.Text = "Chiffre d\'affaires";
            this.cmdCA.UseVisualStyleBackColor = true;
            this.cmdCA.Click += new System.EventHandler(this.cmdCA_Click);
            // 
            // txtPrix
            // 
            this.txtPrix.Location = new System.Drawing.Point(463, 51);
            this.txtPrix.Name = "txtPrix";
            this.txtPrix.Size = new System.Drawing.Size(123, 20);
            this.txtPrix.TabIndex = 3;
            // 
            // cmdModifierPrixArticle3
            // 
            this.cmdModifierPrixArticle3.Location = new System.Drawing.Point(463, 117);
            this.cmdModifierPrixArticle3.Name = "cmdModifierPrixArticle3";
            this.cmdModifierPrixArticle3.Size = new System.Drawing.Size(123, 45);
            this.cmdModifierPrixArticle3.TabIndex = 4;
            this.cmdModifierPrixArticle3.Text = "button1";
            this.cmdModifierPrixArticle3.UseVisualStyleBackColor = true;
            this.cmdModifierPrixArticle3.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // txtCodeArticle
            // 
            this.txtCodeArticle.Location = new System.Drawing.Point(463, 222);
            this.txtCodeArticle.Name = "txtCodeArticle";
            this.txtCodeArticle.Size = new System.Drawing.Size(123, 20);
            this.txtCodeArticle.TabIndex = 5;
            this.txtCodeArticle.TextChanged += new System.EventHandler(this.txtCodeArticle_TextChanged);
            // 
            // txtNouveauPrix
            // 
            this.txtNouveauPrix.Location = new System.Drawing.Point(463, 286);
            this.txtNouveauPrix.Name = "txtNouveauPrix";
            this.txtNouveauPrix.Size = new System.Drawing.Size(123, 20);
            this.txtNouveauPrix.TabIndex = 6;
            this.txtNouveauPrix.TextChanged += new System.EventHandler(this.txtNouveauPrix_TextChanged);
            // 
            // txtmagasin
            // 
            this.txtmagasin.Location = new System.Drawing.Point(206, 362);
            this.txtmagasin.Name = "txtmagasin";
            this.txtmagasin.Size = new System.Drawing.Size(100, 20);
            this.txtmagasin.TabIndex = 7;
            this.txtmagasin.TextChanged += new System.EventHandler(this.txtmagasin_TextChanged);
            // 
            // btnEx7
            // 
            this.btnEx7.Location = new System.Drawing.Point(396, 362);
            this.btnEx7.Name = "btnEx7";
            this.btnEx7.Size = new System.Drawing.Size(75, 23);
            this.btnEx7.TabIndex = 8;
            this.btnEx7.Text = "button1";
            this.btnEx7.UseVisualStyleBackColor = true;
            this.btnEx7.Click += new System.EventHandler(this.btnEx7_Click);
            // 
            // cboArticle
            // 
            this.cboArticle.FormattingEnabled = true;
            this.cboArticle.Location = new System.Drawing.Point(228, 462);
            this.cboArticle.Name = "cboArticle";
            this.cboArticle.Size = new System.Drawing.Size(121, 21);
            this.cboArticle.TabIndex = 9;
            this.cboArticle.SelectedIndexChanged += new System.EventHandler(this.cboArticle_SelectedIndexChanged);
            // 
            // FrmADO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 595);
            this.Controls.Add(this.cboArticle);
            this.Controls.Add(this.btnEx7);
            this.Controls.Add(this.txtmagasin);
            this.Controls.Add(this.txtNouveauPrix);
            this.Controls.Add(this.txtCodeArticle);
            this.Controls.Add(this.cmdModifierPrixArticle3);
            this.Controls.Add(this.txtPrix);
            this.Controls.Add(this.cmdCA);
            this.Controls.Add(this.cmdNbClient);
            this.Controls.Add(this.cmdInfo);
            this.Name = "FrmADO";
            this.Text = "Test ADO.net";
            this.Load += new System.EventHandler(this.FrmADO_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdInfo;
        private System.Windows.Forms.Button cmdNbClient;
        private System.Windows.Forms.Button cmdCA;
        private System.Windows.Forms.TextBox txtPrix;
        private System.Windows.Forms.Button cmdModifierPrixArticle3;
        private System.Windows.Forms.TextBox txtCodeArticle;
        private System.Windows.Forms.TextBox txtNouveauPrix;
        private System.Windows.Forms.TextBox txtmagasin;
        private System.Windows.Forms.Button btnEx7;
        private System.Windows.Forms.ComboBox cboArticle;
    }
}

