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

namespace locala { 
    public partial class Autentificare : Form
    {
        public Autentificare()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public Inregistrare formInregistrare;
        public Vizualizare formVizualizare;
        private void butonInregistrare_Click(object sender, EventArgs e)
        {
            this.Hide();

            formInregistrare = new Inregistrare();
            formInregistrare.Show();
        }

        private void butonLogare_Click(object sender, EventArgs e)
        {
            string username = textboxUsername.Text;
            string parola = textboxParola.Text;
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""" + Path.GetFullPath(@"..\..\Desenare.mdf") + @""";Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sql = "SELECT COUNT(*) FROM Utilizatori WHERE NumeUtilizator = @username AND Parola = @password";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", parola);
                    
                    int count = (int)command.ExecuteScalar();
                    if(count > 0)
                    {
                        this.Hide();

                        formVizualizare = new Vizualizare();
                        formVizualizare.Show();
                    } else
                    {
                        MessageBox.Show("Nume de utilizator si/sau parola invalida!");
                        textboxUsername.Text = "";
                        textboxParola.Text = "";
                    }
                }
            }

        }
    }
}
