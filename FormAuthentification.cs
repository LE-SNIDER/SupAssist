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
    public partial class FormAuthentification : Form
    {
        public FormAuthentification()
        {
            InitializeComponent();
        }

        private void buttonConnexion_Click(object sender, EventArgs e)
        {
            try
            {
                string connexion = "SERVER = 127.0.0.1; DATABASE = supassist; UID = root; PASSWORD =";
                MySqlConnection connexionDb = new MySqlConnection(connexion);

                MySqlCommand SelectCommand = new MySqlCommand("SELECT * FROM employe WHERE user_name=@user_name AND password=@password;", connexionDb);

                SelectCommand.Parameters.Add(new MySqlParameter("@user_name", MySqlDbType.VarChar, 16));
                SelectCommand.Parameters.Add(new MySqlParameter("@password", MySqlDbType.VarChar, 16));

                SelectCommand.Parameters["@user_name"].Value = textBoxUser.Text;
                SelectCommand.Parameters["@password"].Value = textBoxPassword.Text;

                connexionDb.Open();
                MySqlDataReader dr = SelectCommand.ExecuteReader();

                while (dr.Read())
                {
                    if (dr.HasRows == true)
                    {
                        //MessageBox.Show("Ok");
                        connexionDb.Close();
                        FormClient FormClient = new FormClient();
                        FormClient.Show(); // Affichage de la nouvelle fenêtre
                        this.Owner = FormClient; // La Form2 devient fenêtre principal (pour pouvoir quitter l'application)
                        this.Hide(); // On cache la FormAuthentification
                    }
                }
                if (textBoxUser.Text == "" || textBoxPassword.Text == "")
                {
                    MessageBox.Show("Nom d'utilisateur et/ou mot de passe manquant", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (textBoxUser.Text == textBoxPassword.Text)
                {
                    MessageBox.Show("Nom d'utilisateur et mot de passe identique", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (dr.HasRows == false)
                {
                    MessageBox.Show("Nom d'utilisateur et/ou mot de passe incorrect", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {
                if (ex.Message == "Unable to connect to any of the specified MySQL hosts.")
                {
                    // Traduction du message d'erreur envoyé par MySQL
                    MessageBox.Show("Impossible de se connecter à la base de données\nVérifiez que XAMPP soit bien lancé\n\n" + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Console.WriteLine(ex.Message);
                }
                //MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonFermer_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBoxUser_Enter(object sender, EventArgs e)
        {
            textBoxUser.SelectionStart = 0;
            textBoxUser.SelectionLength = textBoxUser.Text.Length;
        }

        private void textBoxPassword_Enter(object sender, EventArgs e)
        {
            textBoxPassword.SelectionStart = 0;
            textBoxPassword.SelectionLength = textBoxPassword.Text.Length;
        }

        private void FormAuthentification_Load(object sender, EventArgs e)
        {
            textBoxUser.Select();
        }
    }
}
