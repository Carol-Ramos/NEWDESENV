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
    public partial class NotaFiscal : Form
    {
        public NotaFiscal()
        {
            InitializeComponent();

            id_cliente.Enabled = true;
            id_fornecedor.Enabled = true;
            id_vendedor.Enabled = true;
            id_nota_fiscal.Enabled = true;
            id_produto.Enabled = true;
        }
        SqlConnection connection;
        private string conexao = "Data Source=DESKTOP-NKBOEUL/SQLEXPRESS;Initial Catalog=NewDesenv;Integrated Security=True";
        private string sqlConexao = String.Empty;
        private void btn_add_cliente_Click(object sender, EventArgs e)
        {
            sqlConexao = "insert into Nota_Fiscal set Id = @Id, Id_Fornecedor = @IdFornecedor, Id_Cliente = @IdCliente, Id_Produto = @IdProduto, Id_Vendedor = @IdVendedor";
            connection = new SqlConnection(sqlConexao);
            SqlCommand cmd = new SqlCommand(sqlConexao, connection);

            cmd.Parameters.Add("@Id", SqlDbType.VarChar).Value = id_nota_fiscal.Text;
            cmd.Parameters.Add("@IdFornecedor", SqlDbType.VarChar).Value = id_fornecedor.Text;
            cmd.Parameters.Add("@IdCliente", SqlDbType.VarChar).Value = id_cliente.Text;
            cmd.Parameters.Add("@IdProduto", SqlDbType.VarChar).Value = id_produto.Text;
            cmd.Parameters.Add("@IdVendedor", SqlDbType.VarChar).Value = id_vendedor.Text;

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
            sqlConexao = "update Nota_Fiscal set Id = @Id, Id_Fornecedor = @IdFornecedor, Id_Cliente = @IdCliente, Id_Produto = @IdProduto, Id_Vendedor = @IdVendedor";
            connection = new SqlConnection(sqlConexao);
            SqlCommand cmd = new SqlCommand(sqlConexao, connection);

            cmd.Parameters.Add("@Id", SqlDbType.VarChar).Value = id_nota_fiscal.Text;
            cmd.Parameters.Add("@IdFornecedor", SqlDbType.VarChar).Value = id_fornecedor.Text;
            cmd.Parameters.Add("@IdCliente", SqlDbType.VarChar).Value = id_cliente.Text;
            cmd.Parameters.Add("@IdProduto", SqlDbType.VarChar).Value = id_produto.Text;
            cmd.Parameters.Add("@IdVendedor", SqlDbType.VarChar).Value = id_vendedor.Text;

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
            sqlConexao = "delete from Nota_Fiscal set Id = @Id, Id_Fornecedor = @IdFornecedor, Id_Cliente = @IdCliente, Id_Produto = @IdProduto, Id_Vendedor = @IdVendedor";
            connection = new SqlConnection(sqlConexao);
            SqlCommand cmd = new SqlCommand(sqlConexao, connection);

            cmd.Parameters.Add("@Id", SqlDbType.VarChar).Value = id_nota_fiscal.Text;
            cmd.Parameters.Add("@IdFornecedor", SqlDbType.VarChar).Value = id_fornecedor.Text;
            cmd.Parameters.Add("@IdCliente", SqlDbType.VarChar).Value = id_cliente.Text;
            cmd.Parameters.Add("@IdProduto", SqlDbType.VarChar).Value = id_produto.Text;
            cmd.Parameters.Add("@IdVendedor", SqlDbType.VarChar).Value = id_vendedor.Text;

            try
            {
                connection.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Exluído com Sucesso!");
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
            sqlConexao = "insert into Nota_Fiscal set Id = @Id, Id_Fornecedor = @IdFornecedor, Id_Cliente = @IdCliente, Id_Produto = @IdProduto, Id_Vendedor = @IdVendedor";
            connection = new SqlConnection(sqlConexao);
            SqlCommand cmd = new SqlCommand(sqlConexao, connection);

            cmd.Parameters.Add("@Id", SqlDbType.VarChar).Value = id_nota_fiscal.Text;
            cmd.Parameters.Add("@IdFornecedor", SqlDbType.VarChar).Value = id_fornecedor.Text;
            cmd.Parameters.Add("@IdCliente", SqlDbType.VarChar).Value = id_cliente.Text;
            cmd.Parameters.Add("@IdProduto", SqlDbType.VarChar).Value = id_produto.Text;
            cmd.Parameters.Add("@IdVendedor", SqlDbType.VarChar).Value = id_vendedor.Text;

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
