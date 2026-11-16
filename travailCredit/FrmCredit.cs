using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Crédit;
using System.Windows.Forms;


namespace travailCredit
{
    public partial class FrmCredit : Form
    {
        public FrmCredit()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cmbxDuree_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FrmCredit_Load(object sender, EventArgs e)
        {
            int i;

            //  remplir la ComboBox (cmbxDuree) avec des valeurs allant de 1 à 179

            for (i=1; i<180; i++)
            {
                cmbxDuree.Items.Add(i);
            }
        }

        private void cmdCalcul_Click(object sender, EventArgs e)
        {
            Crédit.Crédit unCrédit = new Crédit.Crédit(Convert.ToDouble(txtMontantFinancier.Text), Convert.ToDouble(cmbxDuree.Text), Convert.ToDouble(txtAnnuel.Text));


            txtMensualite.Text = unCrédit.getMensualite().ToString(); // met à jour le champ qui est à calculer
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            Crédit.Crédit unCrédit = new Crédit.Crédit(Convert.ToDouble(txtMontantFinancier.Text), Convert.ToDouble(cmbxDuree.Text), Convert.ToDouble(txtAnnuel.Text));
            Globales.listeCrédits.Add(unCrédit);

            // ajouter le crédit dans la liste static


            if (Globales.fenEnregistrement != null && !Globales.fenEnregistrement.IsDisposed)
            {
                Globales.fenEnregistrement.LoadListBoxCredits();  // Méthode pour mettre à jour la ListBox de frmEnregistrement
            }
        }

        private void btnFormulaire_Click(object sender, EventArgs e)
        {
            // une seule fenetre ??, booleen, enable ??
            // tester si la fenetre existe, singleton


            if (Globales.fenEnregistrement == null)
                Globales.fenEnregistrement = new FrmEnregistrement();

            Globales.fenEnregistrement.Show();

            // cacher ma fenetre

            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void txtMensualite_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
