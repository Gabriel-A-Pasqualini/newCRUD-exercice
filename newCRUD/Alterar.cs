using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace newCRUD
{
    public partial class Alterar : Form
    {
        string stringcon = @"Data Source = C:\Users\gabri\Documents\dev\SQLite\newCRUD.s3db";
        Carro _carro;
        public Alterar(Carro carro)
        {
            InitializeComponent();
            _carro = carro;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void salvar_Click(object sender, EventArgs e)
        {
            //Alter no Banco
            Carro carro = new Carro();
            carro.Id = _carro.Id;
            carro.modelo = alterModelo.Text;
            carro.placa = alterPlaca.Text;
            carro.cor = alterCor.Text;

            if (_carro.Id > 0)
            {
                alteraCarro(carro);
            }
            this.Close();
        }

        private int alteraCarro(Carro carro)
        {
            int res = -1;
            using (SQLiteConnection connection = new SQLiteConnection(stringcon))
            {
                connection.Open();

                var comSql = "SELECT * FROM Carro WHERE placa = '" + carro.placa + "' AND id = '"+carro.Id+"'";

                var cmd = new SQLiteCommand(comSql, connection);
                SQLiteDataReader aux = cmd.ExecuteReader();

                bool read = aux.Read();
                if (read == true)
                {
                    using (SQLiteCommand command = new SQLiteCommand(connection))
                    {
                        command.CommandText = $"UPDATE Carro SET modelo=@modelo, placa=@placa, cor=@cor WHERE id=@id";
                        command.Prepare();
                        command.Parameters.AddWithValue("@id", carro.Id);
                        command.Parameters.AddWithValue("@modelo", carro.modelo.First().ToString().ToUpper() + carro.modelo.Substring(1));
                        command.Parameters.AddWithValue("@placa", carro.placa.ToUpper());
                        command.Parameters.AddWithValue("@cor", carro.cor.First().ToString().ToUpper() + carro.cor.Substring(1));
                        res = command.ExecuteNonQuery();

                        connection.Close();

                        MessageBox.Show("Carro atualizado com sucesso!");
                        return res;
                    }
                }
                else
                {
                    connection.Close();
                    MessageBox.Show("Já existe um carro com esta placa!");
                    return 0;
                }
            }
        }

        private void Alterar_Load(object sender, EventArgs e)
        {
            SQLiteConnection connection = new SQLiteConnection(stringcon);

            connection.Open();
            string sqlModelo = "SELECT modelo FROM Carro WHERE modelo='" + _carro.modelo + "'";
            string sqlPlaca = "SELECT placa FROM Carro WHERE placa='" + _carro.placa + "'";
            string sqlCor = "SELECT cor FROM Carro WHERE cor='" + _carro.cor + "'";

            var cmdModelo = new SQLiteCommand(sqlModelo, connection);
            var cmdPlaca = new SQLiteCommand(sqlPlaca, connection);
            var cmdCor = new SQLiteCommand(sqlCor, connection);

            string modelo = cmdModelo.ExecuteScalar().ToString();
            string placa = cmdPlaca.ExecuteScalar().ToString();
            string cor = cmdCor.ExecuteScalar().ToString();

            alterModelo.Text = modelo;
            alterPlaca.Text = placa;
            alterCor.Text = cor;
        }
    }
}
