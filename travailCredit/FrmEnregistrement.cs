using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; // bibliothèque connexion SQL 

namespace travailCredit
{
    public partial class FrmEnregistrement : Form
    {
        private string strConnexion = @"Data Source=IMLYHZ\SQLEXPRESS;Initial Catalog=Credit;Integrated Security=True;"; 

        public FrmEnregistrement()
        {
            InitializeComponent();
        }



        private void btnCredit_Click(object sender, EventArgs e)
        {
            // une seule fenetre ??, booleen, enable ??
            // tester si la fenetre existe, singleton


            if (Globales.fenCredit == null)
                Globales.fenCredit = new FrmCredit();

            Globales.fenCredit.Show();

            // cacher ma fenetre

            this.Hide();
        }

        private void cmbCredit_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FrmEnregistrement_Load(object sender, EventArgs e)
        {
            foreach (Crédit.Crédit credit in Globales.listeCrédits)
            {
                listCredit.Items.Add($"Crédit #Montant:{credit.getMensualite()}");

                // affichage des crédit dans la listBox chargé a partir de la collection listCredit
            }

            if (Globales.unClient.getInfo() != null) // si l'objet client est nul attribué les valeurs
            {
                Globales.unClient.setNomClient(txtNom.Text);
                Globales.unClient.setPrenomClient(txtPrenom.Text);
            }
            else // afficher les valeurs si le client en possède
            {
                txtNom.Text = Globales.unClient.getNomClient();
                txtPrenom.Text = Globales.unClient.getPrenomClient();
            }


            LoadListBoxCredits(); // LoadListBoxCredits() efface et recharge la ListBox avec les crédits actualisés.



        }

        public void LoadListBoxCredits() // fonction appelé
        {
            listCredit.Items.Clear(); // listCredit.Items.Clear();
            foreach (Crédit.Crédit credit in Globales.listeCrédits)
            {
                listCredit.Items.Add($"Crédit #Montant:{credit.getMensualite()}"); // ce qui est affiché dans la listBox
            }
        }

        private void listCredit_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtNom_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPrenom_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrEmpty(txtNom.Text) || string.IsNullOrEmpty(txtPrenom.Text)) // vérifier que les champs ne sont pas vide
            {
                MessageBox.Show("Veuillez saisir le nom et le prénom du client."); // obliger 
                return;
            }

            // Vérification de la sélection d'un crédit
            if (listCredit.SelectedIndex == -1)
            {
                MessageBox.Show("Veuillez sélectionner un crédit.");
                return;
            }

            Client unClient = new Client(txtNom.Text, txtPrenom.Text); // créer l'objet client
            var unVraiCredit = Globales.listeCrédits[listCredit.SelectedIndex]; // var, acpt le type objet, stock le crédit séléctionné


            decimal montant = Convert.ToInt32(unVraiCredit.getMontant()); // champ en string donc conversion en double
            decimal nbMensualite = Convert.ToInt32(unVraiCredit.getNbMensualite());
            decimal mensualite = Convert.ToInt32(unVraiCredit.getMensualite());
            decimal taux = Convert.ToInt32(unVraiCredit.getTaux());

            string nom = unClient.getNomClient();
            string prenom = unClient.getPrenomClient();

            using (SqlConnection connection = new SqlConnection(strConnexion)) // connexion bdd
            {
                using (SqlCommand command = new SqlCommand("insCredit", connection)) // utilisation de la procédure insCrédit
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add(new SqlParameter("@nom", nom)); // ajout des paramètres de la procédure stockée
                    command.Parameters.Add(new SqlParameter("@prenom", prenom));

                    command.Parameters.Add(new SqlParameter("@montantFin", montant));
                    command.Parameters.Add(new SqlParameter("@nbMensualite", nbMensualite));
                    command.Parameters.Add(new SqlParameter("@mensualite", mensualite));
                    command.Parameters.Add(new SqlParameter("@taux", taux));

                    

                    try
                    {
                        connection.Open(); // ouverture de la connexion

                        command.ExecuteNonQuery();
                        MessageBox.Show("Le crédit et le client a été ajouté avec succès.");

                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show($"Erreur lors de l'ajout du crédit : {ex.Message}");
                    }

                }

            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Globales.listeCrédits = RecupererCredit(); //

            listCredit.Items.Clear();

            foreach (Crédit.Crédit xCredit in Globales.listeCrédits)
            {
                listCredit.Items.Add($"Montant : {xCredit.getMontant()}, Durée : {xCredit.getNbMensualite()}, Mensualite : {xCredit.getMensualite()}");
            }
        }


        public List<Crédit.Crédit> RecupererCredit() // récupérer les crédit 
        {
            string connectionString = @"Data Source=IMLYHZ\SQLEXPRESS;Initial Catalog=Credit;Integrated Security=True;";

            List<Crédit.Crédit> locCredits = new List<Crédit.Crédit>();

            string strRequete = "SELECT MontantFinance, NombreMensualite, TauxAnnuel, MontantMensualites FROM CREDIT;";


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(strRequete, connection))
                {
                    try
                    {
                        connection.Open();

                        using (SqlDataReader oReader = command.ExecuteReader())
                        {
                            while (oReader.Read())
                            {
                                Crédit.Crédit unCredit = new Crédit.Crédit(Convert.ToDouble(oReader[0]), Convert.ToDouble(oReader[1]), Convert.ToDouble(oReader[2]), Convert.ToDouble(oReader[3]));

                                locCredits.Add(unCredit);
                            }
                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show($"Erreur lors de la récupération des crédits : {ex.Message}");

                    }
                }

                return locCredits;
            }
        }

        private void btnInit_Click(object sender, EventArgs e)
        {
            listCredit.Items.Clear();

        }
    }
}