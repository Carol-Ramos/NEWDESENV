using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NEWDESENV
{
    public partial class Vendedor : Form
    {
        public Vendedor()
        {
            InitializeComponent();
            nome_funcionario.Enabled = true;
            id_funcionario.Enabled = true;
        }
        SqlConnection connection;
        private string conexao = "Data Source=DESKTOP-NKBOEUL/SQLEXPRESS;Initial Catalog=NewDesenv;Integrated Security=True";
        private string sqlConexao = String.Empty;

        private void btn_add_cliente_Click(object sender, EventArgs e)
        {
            sqlConexao = "insert into Vendedor set Id_Vendedor = @idvendedor, Nome_Vendedor = @nomevendedor";
            connection = new SqlConnection(sqlConexao);
            SqlCommand cmd = new SqlCommand(sqlConexao, connection);

            cmd.Parameters.Add("@idvendedor", SqlDbType.VarChar).Value = id_funcionario.Text;
            cmd.Parameters.Add("@nomevendedor", SqlDbType.VarChar).Value = nome_funcionario.Text;

            try
            {
                connection.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Adicionado com Sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }

        }

        private void btn_editar_cliente_Click(object sender, EventArgs e)
        {
            sqlConexao = "update Vendedor set Id_Vendedor = @idvendedor, Nome_Vendedor = @nomevendedor";
            connection = new SqlConnection(sqlConexao);
            SqlCommand cmd = new SqlCommand(sqlConexao, connection);

            cmd.Parameters.Add("@idvendedor", SqlDbType.VarChar).Value = id_funcionario.Text;
            cmd.Parameters.Add("@nomevendedor", SqlDbType.VarChar).Value = nome_funcionario.Text;

            try
            {
                connection.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Editado com Sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void btn_excluir_cliente_Click(object sender, EventArgs e)
        {
            sqlConexao = "delete from Vendedor set Id_Vendedor = @idvendedor, Nome_Vendedor = @nomevendedor";
            connection = new SqlConnection(sqlConexao);
            SqlCommand cmd = new SqlCommand(sqlConexao, connection);

            cmd.Parameters.Add("@idvendedor", SqlDbType.VarChar).Value = id_funcionario.Text;
            cmd.Parameters.Add("@nomevendedor", SqlDbType.VarChar).Value = nome_funcionario.Text;

            try
            {
                connection.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Excluído com Sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            sqlConexao = "insert into Vendedor set Id_Vendedor = @idvendedor, Nome_Vendedor = @nomevendedor";
            connection = new SqlConnection(sqlConexao);
            SqlCommand cmd = new SqlCommand(sqlConexao, connection);

            cmd.Parameters.Add("@idvendedor", SqlDbType.VarChar).Value = id_funcionario.Text;
            cmd.Parameters.Add("@nomevendedor", SqlDbType.VarChar).Value = nome_funcionario.Text;

            try
            {
                connection.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Adicionado com Sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
