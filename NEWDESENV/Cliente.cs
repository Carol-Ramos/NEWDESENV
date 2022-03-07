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
    public partial class Cliente : Form
    {
        public Cliente()
        {
            InitializeComponent();
        }

        SqlConnection connection;
        private string conexao = "Data Source=DESKTOP-NKBOEUL/SQLEXPRESS;Initial Catalog=NewDesenv;Integrated Security=True";
        private string sqlConexao = String.Empty;

        private void txt_nome_cliente_TextChanged(object sender, EventArgs e)
        {
            txt_nome_cliente.Enabled = true;
            txt_cpf_cliente.Enabled = true;
            txt_cod_cliente.Enabled = true;
        }

        private void btn_add_cliente_Click(object sender, EventArgs e)
        {
            sqlConexao = "insert into Cliente set Nome = @Nome, Id_Cliente = @IdCliente, CPF = @CPF";
            connection = new SqlConnection(sqlConexao);
            SqlCommand cmd = new SqlCommand(sqlConexao, connection);

            cmd.Parameters.Add("@Nome", SqlDbType.VarChar).Value = txt_nome_cliente.Text;
            cmd.Parameters.Add("@IdCliente", SqlDbType.VarChar).Value = txt_cod_cliente.Text;
            cmd.Parameters.Add("@CPF", SqlDbType.VarChar).Value = txt_cpf_cliente.Text;

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
            sqlConexao = "update Cliente set Nome = @Nome, Id_Cliente = @IdCliente, CPF = @CPF";
            connection = new SqlConnection(conexao);
            SqlCommand cmd = new SqlCommand(sqlConexao, connection);

            cmd.Parameters.Add("@Nome", SqlDbType.VarChar).Value = txt_nome_cliente;
            cmd.Parameters.Add("@IdCliente", SqlDbType.VarChar).Value = txt_cod_cliente;
            cmd.Parameters.Add("@CPF", SqlDbType.VarChar).Value = txt_cpf_cliente;

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
            sqlConexao = "delete from Cliente where Nome = @Nome, IdCliente = @IdCliente, CPF = @CPF";
            connection = new SqlConnection(conexao);
            SqlCommand cmd = new SqlCommand(sqlConexao, connection);

            cmd.Parameters.Add("@Nome", SqlDbType.VarChar).Value = txt_nome_cliente;
            cmd.Parameters.Add("@IdCliente", SqlDbType.VarChar).Value = txt_cod_cliente;
            cmd.Parameters.Add("@CPF", SqlDbType.VarChar).Value = txt_cpf_cliente;

            try
            {
                connection.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Excluído.");
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

            sqlConexao = "insert into Cliente(Nome, Id, CPF) values(@nome, @id, @cpf)";
            connection = new SqlConnection(conexao);
            SqlCommand cmd = new SqlCommand(sqlConexao, connection);

            cmd.Parameters.Add("@nome", SqlDbType.VarChar).Value = txt_nome_cliente.Text;
            cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = txt_cod_cliente.Text;
            cmd.Parameters.Add("@cpf", SqlDbType.VarChar).Value = txt_cpf_cliente.Text;

            try
            {
                connection.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Salvo com sucesso!");
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
