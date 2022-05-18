using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace newCRUD
{
    public partial class inicial : Form
    {
        string stringcon = @"Data Source = C:\Users\gabri\Documents\dev\SQLite\newCRUD.s3db";
        public inicial()
        {
            InitializeComponent();
            selectCarro();
        }

        private void sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void novo_Click(object sender, EventArgs e)
        {
            //Chama o forms "Novo" para adicionar novo carro
            Carro carro = null;
            Novo novo = new Novo(carro);
            novo.ShowDialog();
            selectCarro();
        }

        private void modificar_Click(object sender, EventArgs e)
        {
            //Chama o forms "Alterar" para alterar o carro selecionado
            Alterar alterar = new Alterar(lerGrid());    
            alterar.ShowDialog();
            selectCarro();
        }

        private void excluir_Click(object sender, EventArgs e)
        {
            //Acionara o aviso de confirmação de exclusão, caso a escolha seja "sim", exclui do banco
            DialogResult response = MessageBox.Show("Deseja deletar este carro ?", "Deletar linha",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (response == DialogResult.Yes)
            {
                excluiCarro(lerGrid());
                selectCarro();
            }
        }
    
        private void selectCarro()
        {
            DataTable table = new DataTable();
            SQLiteConnection connection = null;
            string comSql = "SELECT * FROM Carro";

            connection = new SQLiteConnection(stringcon);
            SQLiteDataAdapter dataA = new SQLiteDataAdapter(comSql,stringcon);

            dataA.Fill(table);
            carroGrid.DataSource = table.DefaultView;
        } 

        public Carro lerGrid()
        {
            int linha = carroGrid.CurrentRow.Index;
            Carro carro = new Carro();
            carro.Id = Convert.ToInt32(carroGrid[0, linha].Value);
            carro.modelo = carroGrid[1, linha].Value.ToString();
            carro.placa = carroGrid[2, linha].Value.ToString();
            carro.cor = carroGrid[3, linha].Value.ToString();
            return carro;
        }

        public int excluiCarro(Carro carro)
        {
            int res = -1;
            using (SQLiteConnection connection = new SQLiteConnection(stringcon))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    command.CommandText = "DELETE FROM Carro WHERE Id = @Id";
                    command.Prepare();
                    command.Parameters.AddWithValue("@Id", carro.Id);
                    try
                    {
                        res = command.ExecuteNonQuery();
                    }
                    catch (SQLiteException ex)
                    {
                        throw ex;
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
            return res;
        }

        private void srcModelo_TextChanged(object sender, EventArgs e)
        {
            carroGrid.DataSource = procurarModelo();
        }

        private void srcPlaca_TextChanged(object sender, EventArgs e)
        {
            carroGrid.DataSource = procurarPlaca();
        }

        private void srcCor_TextChanged(object sender, EventArgs e)
        {
            carroGrid.DataSource = procurarCor();
        }

        private DataTable procurarModelo()
        {
            string sql = "SELECT * FROM Carro WHERE modelo LIKE '"+ srcModelo.Text+ "%'";
            {
                using (SQLiteConnection connection = new SQLiteConnection(stringcon))
                {
                    connection.Open();
                    using (SQLiteDataAdapter da = new SQLiteDataAdapter(sql, connection))
                    {
                        try
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            return dt;
                        }
                        catch (SQLiteException ex)
                        {
                            throw ex;
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }   
                }
            }
        }

        private DataTable procurarPlaca()
        {
            string sql = "SELECT * FROM Carro WHERE placa LIKE '" + srcPlaca.Text + "%'";
            {
                using (SQLiteConnection connection = new SQLiteConnection(stringcon))
                {
                    connection.Open();
                    using (SQLiteDataAdapter da = new SQLiteDataAdapter(sql, connection))
                    {
                        try
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            return dt;
                        }
                        catch (SQLiteException ex)
                        {
                            throw ex;
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
            }
        }

        private DataTable procurarCor()
        {
            string sql = "SELECT * FROM Carro WHERE cor LIKE '" + srcCor.Text + "%'";
            {
                using (SQLiteConnection connection = new SQLiteConnection(stringcon))
                {
                    connection.Open();
                    using (SQLiteDataAdapter da = new SQLiteDataAdapter(sql, connection))
                    {
                        try
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            return dt;
                        }
                        catch (SQLiteException ex)
                        {
                            throw ex;
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
            }
        }
    }
}
