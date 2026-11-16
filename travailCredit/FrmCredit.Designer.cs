
namespace travailCredit
{
    partial class FrmCredit
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
            this.txtMontantFinancier = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbxDuree = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAnnuel = new System.Windows.Forms.TextBox();
            this.txtMensualite = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmdCalcul = new System.Windows.Forms.Button();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.btnFormulaire = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMontantFinancier
            // 
            this.txtMontantFinancier.Location = new System.Drawing.Point(106, 76);
            this.txtMontantFinancier.Name = "txtMontantFinancier";
            this.txtMontantFinancier.Size = new System.Drawing.Size(100, 22);
            this.txtMontantFinancier.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Montant financé";
            // 
            // cmbxDuree
            // 
            this.cmbxDuree.FormattingEnabled = true;
            this.cmbxDuree.Location = new System.Drawing.Point(106, 151);
            this.cmbxDuree.Name = "cmbxDuree";
            this.cmbxDuree.Size = new System.Drawing.Size(121, 24);
            this.cmbxDuree.TabIndex = 2;
            this.cmbxDuree.SelectedIndexChanged += new System.EventHandler(this.cmbxDuree_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 3;
            // 
            // txtAnnuel
            // 
            this.txtAnnuel.Location = new System.Drawing.Point(106, 229);
            this.txtAnnuel.Name = "txtAnnuel";
            this.txtAnnuel.Size = new System.Drawing.Size(100, 22);
            this.txtAnnuel.TabIndex = 4;
            // 
            // txtMensualite
            // 
            this.txtMensualite.Location = new System.Drawing.Point(106, 301);
            this.txtMensualite.Name = "txtMensualite";
            this.txtMensualite.Size = new System.Drawing.Size(100, 22);
            this.txtMensualite.TabIndex = 5;
            this.txtMensualite.TextChanged += new System.EventHandler(this.txtMensualite_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(103, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Durée et mois";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(103, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Taux annuel";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(103, 326);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Mensualité";
            // 
            // cmdCalcul
            // 
            this.cmdCalcul.Location = new System.Drawing.Point(207, 393);
            this.cmdCalcul.Name = "cmdCalcul";
            this.cmdCalcul.Size = new System.Drawing.Size(75, 23);
            this.cmdCalcul.TabIndex = 9;
            this.cmdCalcul.Text = "Calcul";
            this.cmdCalcul.UseVisualStyleBackColor = true;
            this.cmdCalcul.Click += new System.EventHandler(this.cmdCalcul_Click);
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Location = new System.Drawing.Point(342, 393);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(101, 23);
            this.btnEnregistrer.TabIndex = 10;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // btnFormulaire
            // 
            this.btnFormulaire.Location = new System.Drawing.Point(500, 393);
            this.btnFormulaire.Name = "btnFormulaire";
            this.btnFormulaire.Size = new System.Drawing.Size(91, 23);
            this.btnFormulaire.TabIndex = 11;
            this.btnFormulaire.Text = "Formulaire";
            this.btnFormulaire.UseVisualStyleBackColor = true;
            this.btnFormulaire.Click += new System.EventHandler(this.btnFormulaire_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(799, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FrmCredit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnFormulaire);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.cmdCalcul);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMensualite);
            this.Controls.Add(this.txtAnnuel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbxDuree);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMontantFinancier);
            this.Name = "FrmCredit";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmCredit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMontantFinancier;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbxDuree;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAnnuel;
        private System.Windows.Forms.TextBox txtMensualite;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button cmdCalcul;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.Button btnFormulaire;
        private System.Windows.Forms.Button button1;
    }
}

