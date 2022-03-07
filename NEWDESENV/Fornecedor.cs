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
    public partial class Fornecedor : Form
    {
        public Fornecedor()
        {
            InitializeComponent();
        }

        SqlConnection connection;
        private string conexao = "Data Source=DESKTOP-NKBOEUL/SQLEXPRESS;Initial Catalog=NewDesenv;Integrated Security=True";
        private string sqlConexao = String.Empty;


        private void txt_fornecedor_TextChanged(object sender, EventArgs e)
        {
            txt_cnpj.Enabled = true;
            txt_cod_fornecedor.Enabled = true;
            txt_fornecedor.Enabled = true;
        }
        private void btn_add_cliente_Click(object sender, EventArgs e)
        {
            txt_cnpj.Enabled = true;
            txt_cod_fornecedor.Enabled = true;
            txt_fornecedor.Enabled = true;

            sqlConexao = "insert into Fornecesor set Nome_Fornecedor = @NomeFornecedor, Id_Fornecedor = @IdFornecedor, CNPJ = @CNPJ";
            connection = new SqlConnection(sqlConexao);
            SqlCommand cmd = new SqlCommand(sqlConexao, connection);

            cmd.Parameters.Add("@NomeFornecedor", SqlDbType.VarChar).Value = txt_fornecedor.Text;
            cmd.Parameters.Add("@IdFornecedor", SqlDbType.VarChar).Value = txt_cod_fornecedor.Text;
            cmd.Parameters.Add("@CNPJ", SqlDbType.VarChar).Value = txt_cnpj.Text;

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
            txt_fornecedor.Enabled = true;
            txt_cnpj.Enabled = true;
            txt_cod_fornecedor.Enabled = true;

            sqlConexao = "update Fornecedor set Nome_Fornecedor = @NomeFornecedor, Id_Fornecedor = @IdFornecedor, CNPJ = @cnpj";
            connection = new SqlConnection(sqlConexao);
            SqlCommand cmd = new SqlCommand(sqlConexao, connection);

            cmd.Parameters.Add("@NomeFornecedor", SqlDbType.VarChar).Value = txt_fornecedor.Text;
            cmd.Parameters.Add("@IdFornecedor", SqlDbType.VarChar).Value = txt_cod_fornecedor.Text;
            cmd.Parameters.Add("@cnpj", SqlDbType.VarChar).Value = txt_cnpj.Text;

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
            txt_fornecedor.Enabled = true;
            txt_cod_fornecedor.Enabled = true;
            txt_cnpj.Enabled = true;

            sqlConexao = "delete Fornecedor set Nome_Fornecedor = @NomeFornecedor, Id_Fornecedor = @IdFornecedor, CNPJ = @cnpj";
            connection = new SqlConnection(sqlConexao);
            SqlCommand cmd = new SqlCommand(sqlConexao, connection);

            cmd.Parameters.Add("@NomeFornecedor", SqlDbType.VarChar).Value = txt_fornecedor.Text;
            cmd.Parameters.Add("@IdFornecedor", SqlDbType.VarChar).Value = txt_cod_fornecedor.Text;
            cmd.Parameters.Add("@CNPJ", SqlDbType.VarChar).Value = txt_cnpj.Text;

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

        }
    }
}
