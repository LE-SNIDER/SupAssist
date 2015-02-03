using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SupAssist
{
    public partial class FormNouveauClient : Form
    {
        public class Contact
        {
            // Création de propriétés
            public string Prenom { get; set; }
            public string Nom { get; set; }
            public string Adresse { get; set; }
            public string Code_Postal { get; set; }
            public string Ville { get; set; }
            public string Telephone { get; set; }
            public string Email { get; set; }

            // Constructeur
            public Contact()
            {
            }
        }
        public class Bdd
        {

            private MySqlConnection connection;

            // Constructeur
            public Bdd()
            {
                this.InitConnexion();
            }

            // Méthode pour initialiser la connexion
            private void InitConnexion()
            {
                // Création de la chaîne de connexion
                string connectionString = "SERVER=127.0.0.1; DATABASE=supassist; UID=root; PASSWORD=";
                this.connection = new MySqlConnection(connectionString);
            }
            public void AddContact(Contact contact)
            {
                try
                {
                    // Ouverture de la connexion SQL
                    this.connection.Open();

                    // Création d'une commande SQL en fonction de l'objet connection
                    MySqlCommand cmd = this.connection.CreateCommand();

                    // Requête SQL
                    cmd.CommandText = "INSERT INTO client (Prenom, Nom, Adresse, Code_Postal, Ville, Telephone, Email) VALUES (@Prenom, @Nom, @Adresse, @Code_Postal, @Ville, @Telephone, @Email)";

                    //Création et décalartion des paramètres 
                    cmd.Parameters.Add(new MySqlParameter("@Prenom", MySqlDbType.VarChar, 64));
                    cmd.Parameters.Add(new MySqlParameter("@Nom", MySqlDbType.VarChar, 64));
                    cmd.Parameters.Add(new MySqlParameter("@Adresse", MySqlDbType.VarChar, 128));
                    cmd.Parameters.Add(new MySqlParameter("@Code_Postal", MySqlDbType.VarChar, 5));
                    cmd.Parameters.Add(new MySqlParameter("@Ville", MySqlDbType.VarChar, 64));
                    cmd.Parameters.Add(new MySqlParameter("@Telephone", MySqlDbType.VarChar, 10));
                    cmd.Parameters.Add(new MySqlParameter("@Email", MySqlDbType.VarChar, 255));

                    //Attribution des valeurs aux paramètres 
                    cmd.Parameters["@Prenom"].Value = contact.Prenom;
                    cmd.Parameters["@Nom"].Value = contact.Nom;
                    cmd.Parameters["@Adresse"].Value = contact.Adresse;
                    cmd.Parameters["@Code_Postal"].Value = contact.Code_Postal;
                    cmd.Parameters["@Ville"].Value = contact.Ville;
                    cmd.Parameters["@Telephone"].Value = contact.Telephone;
                    cmd.Parameters["@Email"].Value = contact.Email;

                    // Exécution de la commande SQL
                    cmd.ExecuteNonQuery();

                    // Fermeture de la connexion
                    this.connection.Close();
                }
                catch(Exception ex)
                {
                    // Gestion des erreurs :
                    MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    // Possibilité de créer un Logger pour les exceptions SQL reçus
                    // Possibilité de créer une méthode avec un booléan en retour pour savoir si le contact à été ajouté correctement.
                }
            }
        }
        public FormNouveauClient()
        {
            InitializeComponent();
        }
        private void buttonEnregistrer_Click(object sender, EventArgs e)
        {
            DialogResult enregistrer;
            enregistrer = MessageBox.Show("Souhaitez-vous enregistrer ce client ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);


            if (enregistrer == DialogResult.Yes)
            {
                // Création d'un contact à ajouter
                Contact contact = new Contact();
                contact.Prenom = textBoxPrenom.Text;
                contact.Nom = textBoxNom.Text;
                contact.Adresse = textBoxAdresse.Text;
                contact.Code_Postal = maskedTextBoxCodePostal.Text;
                contact.Ville = textBoxVille.Text;
                contact.Telephone = maskedTextBoxTelephone.Text;
                contact.Email = textBoxEmail.Text;

                // Création de l'objet Bdd pour l'intéraction avec la base de donnée MySQL
                Bdd bdd = new Bdd();
                bdd.AddContact(contact);

                this.Close();
            }
        }

        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
