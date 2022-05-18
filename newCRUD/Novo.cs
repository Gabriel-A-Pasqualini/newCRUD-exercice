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
    public partial class Novo : Form
    {
        string stringcon = @"Data Source = C:\Users\gabri\Documents\dev\SQLite\newCRUD.s3db";
        public Novo(Carro carro)
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void salvar_Click(object sender, EventArgs e)
        {
            //Insert no banco
            Carro carro = new Carro();
            carro.Id = carro?.Id ?? 0;
            carro.modelo = newModelo.Text;
            carro.placa = newPlaca.Text.ToUpper();
            carro.cor = newCor.Text;
            if ((carro?.Id ?? 0) == 0)
            {
                insereCarro(carro);
            }

            this.Close();
        }

        private int insereCarro(Carro carro)
        {
            int res = -1;
            using (SQLiteConnection connection = new SQLiteConnection(stringcon)) {
                connection.Open();
                
                var comSql = "SELECT * FROM Carro WHERE placa = '" + carro.placa + "'";

                var cmd = new SQLiteCommand(comSql, connection);
                SQLiteDataReader aux = cmd.ExecuteReader();

                bool teste = aux.Read();
                if (teste == false)
                {
                    using (SQLiteCommand command = new SQLiteCommand(connection))
                    {
                        command.CommandText = $"INSERT INTO Carro (modelo,placa,cor) VALUES (@modelo, @placa, @cor)";
                        command.Prepare();
                        command.Parameters.AddWithValue("@modelo", carro.modelo.First().ToString().ToUpper() + carro.modelo.Substring(1));
                        command.Parameters.AddWithValue("@placa", carro.placa.ToUpper());
                        command.Parameters.AddWithValue("@cor", carro.cor.First().ToString().ToUpper() + carro.cor.Substring(1));
                        res = command.ExecuteNonQuery();
                       
                        connection.Close();
                       
                        MessageBox.Show("Carro inserido com sucesso!");
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
    }
}
