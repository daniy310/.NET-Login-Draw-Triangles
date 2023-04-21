using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace locala
{
    public partial class Inregistrare : Form
    {
        public Inregistrare()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public Autentificare autentificare;
        private void butonLogare_Click(object sender, EventArgs e)
        {

            if (textboxUsername.Text.Length < 5)
            {
                MessageBox.Show("Numele de utilizator este prea scurt !");
                return;
            }

            string parola = textboxParola.Text;
            string username = textboxUsername.Text;
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Path.GetFullPath(@"..\..\Desenare.mdf;") + @"Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sql = "SELECT COUNT(*) FROM Utilizatori WHERE NumeUtilizator = @username";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@username", username);

                    int count = (int)command.ExecuteScalar();
                    if (count > 0)
                    {
                        MessageBox.Show("Numele de utilizator a fost inregistrat deja !");
                        return;
                    }
                }
            }

            if (textboxParola.Text.Length < 5)
            {
                MessageBox.Show("Parola este prea scurta !");
                return;
            }

            if (textboxParola.Text != textboxConfirmareParola.Text)
            {
                MessageBox.Show("Parolele nu coincid !");
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sql = "INSERT INTO Utilizatori (NumeUtilizator, Parola) VALUES (@username, @password)";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", parola);

                    command.ExecuteNonQuery();
                    MessageBox.Show("Inregistrare cu succes !");
                }
            }

            this.Close();
            autentificare = new Autentificare();
            autentificare.Show();
        }

        private void butonRenuntare_Click(object sender, EventArgs e)
        {
            this.Close();

            autentificare = new Autentificare();
            autentificare.Show();
        }
    }
}
