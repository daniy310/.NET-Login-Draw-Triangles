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
    public partial class Vizualizare : Form
    {
        public Vizualizare()
        {
            InitializeComponent();
        }

        public Bitmap bitmap;
        public Graphics GFX;

        Brush fixedPointBrush = new SolidBrush(Color.Green);
        Brush whiteBrush = new SolidBrush(Color.White);
        Pen fixedLinesPen = new Pen(Color.Blue, 2);

         public int x1, y1, x2, y2, x3, y3;
        public int nrPuncte = 0;


        private void adaugareTriunghiInDb(int x1, int y1, int x2, int y2, int x3, int y3)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Path.GetFullPath(@"..\..\Desenare.mdf;") + @"Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sql = "INSERT INTO Triunghiuri (x1, y1, x2, y2, x3, y3) VALUES (@x1, @y1, @x2, @y2, @x3, @y3)";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@x1", x1);
                    command.Parameters.AddWithValue("@y1", y1);
                    command.Parameters.AddWithValue("@x2", x2);
                    command.Parameters.AddWithValue("@y2", y2);
                    command.Parameters.AddWithValue("@x3", x3);
                    command.Parameters.AddWithValue("@y3", y3);

                    command.ExecuteNonQuery();
                }
            }

        }

        private void stergereTriunghiDb(int x, int y)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Path.GetFullPath(@"..\..\Desenare.mdf;") + @"Integrated Security=True";
            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sql = "DELETE FROM Triunghiuri WHERE (x1 = @x AND y1 = @y) OR (x2 = @x AND y2 = @y) OR (x3 = @x AND y3 = @y)";
                using(SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@x", x);
                    command.Parameters.AddWithValue("@y", y);

                    int r = (int)command.ExecuteNonQuery();
                    if(r > 0)
                    {
                        this.Close();
                        Vizualizare frmVizualizare = new Vizualizare();
                        frmVizualizare.Show();
                    }
                }
            }
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
                MouseEventArgs args = (MouseEventArgs)e;
                int x = args.X;
                int y = args.Y;

            if (radioButtonDesenare.Checked)
            {
                Graphics GFX = Graphics.FromImage(bitmap);



                switch (nrPuncte)
                {
                    case 0:
                        {
                            x1 = x;
                            y1 = y;
                            GFX.FillEllipse(fixedPointBrush, x1 - 7, y1 - 7, 14, 14);

                            nrPuncte++;
                            break;
                        }
                    case 1:
                        {
                            x2 = x;
                            y2 = y;
                            GFX.FillEllipse(fixedPointBrush, x2 - 7, y2 - 7, 14, 14);
                            GFX.DrawLine(fixedLinesPen, x1, y1, x2, y2);

                            nrPuncte++;
                            break;
                        }
                    case 2:
                        {
                            x3 = x;
                            y3 = y;
                            GFX.FillEllipse(fixedPointBrush, x3 - 7, y3 - 7, 14, 14);
                            GFX.DrawLine(fixedLinesPen, x2, y2, x3, y3);
                            GFX.DrawLine(fixedLinesPen, x3, y3, x1, y1);

                            adaugareTriunghiInDb(x1, y1, x2, y2, x3, y3);

                            nrPuncte++;
                            break;
                        }
                }

                if (nrPuncte == 3)
                    nrPuncte = 0;




                pictureBox1.Image = bitmap;
            }
            //STERGERE
            else
                stergereTriunghiDb(x, y);
        }

        private void Vizualizare_Load(object sender, EventArgs e)
        {
            bitmap = new Bitmap(800, 600);
            Graphics GFX = Graphics.FromImage(bitmap);
            GFX.FillRectangle(whiteBrush, 0, 0, this.Width, this.Height);


            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Path.GetFullPath(@"..\..\Desenare.mdf;") + @"Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sql = "SELECT x1, y1, x2, y2, x3, y3 FROM Triunghiuri";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        var indexOfColumn1 = reader.GetOrdinal("x1");
                        var indexOfColumn2 = reader.GetOrdinal("y1");
                        var indexOfColumn3 = reader.GetOrdinal("x2");
                        var indexOfColumn4 = reader.GetOrdinal("y2");
                        var indexOfColumn5 = reader.GetOrdinal("x3");
                        var indexOfColumn6 = reader.GetOrdinal("y3");

                        while (reader.Read())
                        {
                            var x1 = (int)reader.GetValue(indexOfColumn1);
                            var y1 = (int)reader.GetValue(indexOfColumn2);
                            var x2 = (int)reader.GetValue(indexOfColumn3);
                            var y2 = (int)reader.GetValue(indexOfColumn4);
                            var x3 = (int)reader.GetValue(indexOfColumn5);
                            var y3 = (int)reader.GetValue(indexOfColumn6);

                            GFX.FillEllipse(fixedPointBrush, x1 - 7, y1 - 7, 14, 14);
                            GFX.FillEllipse(fixedPointBrush, x2 - 7, y2 - 7, 14, 14);
                            GFX.FillEllipse(fixedPointBrush, x3 - 7, y3 - 7, 14, 14);

                            GFX.DrawLine(fixedLinesPen, x1, y1, x2, y2);
                            GFX.DrawLine(fixedLinesPen, x2, y2, x3, y3);
                            GFX.DrawLine(fixedLinesPen, x3, y3, x1, y1);
                        }
                    }
                }
            }


            pictureBox1.Image = bitmap;
        }
    }
}
