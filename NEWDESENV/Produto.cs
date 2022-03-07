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
    public partial class Produto : Form
    {
        public Produto()
        {
            InitializeComponent();
            cod_fornecedor.Enabled = true;
            cod_produto.Enabled = true;
            nome_produto.Enabled = true;
        }

        SqlConnection connection;
        private string conexao = "Data Source=DESKTOP-NKBOEUL/SQLEXPRESS;Initial Catalog=NewDesenv;Integrated Security=True";
        private string sqlConexao = String.Empty;

        private void btn_add_cliente_Click(object sender, EventArgs e)
        {
            sqlConexao = "insert into Produto set Id_Produto = @idproduto, Id_Fornecedor = @idfornecedor, Nome_Produto = @idnomeproduto";
            connection = new SqlConnection(sqlConexao);
            SqlCommand cmd = new SqlCommand(sqlConexao, connection);

            cmd.Parameters.Add("@idproduto", SqlDbType.VarChar).Value = cod_produto.Text;
            cmd.Parameters.Add("@idfornecedor", SqlDbType.VarChar).Value = cod_fornecedor.Text;
            cmd.Parameters.Add("@nomeproduto", SqlDbType.VarChar).Value = nome_produto.Text;

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
            sqlConexao = "update Produto set Id_Produto = @idproduto, Id_Fornecedor = @idfornecedor, Nome_Produto = @idnomeproduto";
            connection = new SqlConnection(sqlConexao);
            SqlCommand cmd = new SqlCommand(sqlConexao, connection);

            cmd.Parameters.Add("@idproduto", SqlDbType.VarChar).Value = cod_produto.Text;
            cmd.Parameters.Add("@idfornecedor", SqlDbType.VarChar).Value = cod_fornecedor.Text;
            cmd.Parameters.Add("@nomeproduto", SqlDbType.VarChar).Value = nome_produto.Text;

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
            sqlConexao = "delete from Produto set Id_Produto = @idproduto, Id_Fornecedor = @idfornecedor, Nome_Produto = @idnomeproduto";
            connection = new SqlConnection(sqlConexao);
            SqlCommand cmd = new SqlCommand(sqlConexao, connection);

            cmd.Parameters.Add("@idproduto", SqlDbType.VarChar).Value = cod_produto.Text;
            cmd.Parameters.Add("@idfornecedor", SqlDbType.VarChar).Value = cod_fornecedor.Text;
            cmd.Parameters.Add("@nomeproduto", SqlDbType.VarChar).Value = nome_produto.Text;

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
            sqlConexao = "insert into Produto set Id_Produto = @idproduto, Id_Fornecedor = @idfornecedor, Nome_Produto = @idnomeproduto";
            connection = new SqlConnection(sqlConexao);
            SqlCommand cmd = new SqlCommand(sqlConexao, connection);

            cmd.Parameters.Add("@idproduto", SqlDbType.VarChar).Value = cod_produto.Text;
            cmd.Parameters.Add("@idfornecedor", SqlDbType.VarChar).Value = cod_fornecedor.Text;
            cmd.Parameters.Add("@nomeproduto", SqlDbType.VarChar).Value = nome_produto.Text;

            try
            {
                connection.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Salvo com Sucesso!");
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
