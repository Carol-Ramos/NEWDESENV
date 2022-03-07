namespace NEWDESENV
{
    partial class Produto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_salvar = new System.Windows.Forms.Button();
            this.btn_excluir_cliente = new System.Windows.Forms.Button();
            this.btn_editar_cliente = new System.Windows.Forms.Button();
            this.btn_add_cliente = new System.Windows.Forms.Button();
            this.txt_cod_produto = new System.Windows.Forms.TextBox();
            this.cod_produto = new System.Windows.Forms.Label();
            this.txt_cod_fornecedor = new System.Windows.Forms.TextBox();
            this.cod_fornecedor = new System.Windows.Forms.Label();
            this.txt_nome_produto = new System.Windows.Forms.TextBox();
            this.nome_produto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_salvar
            // 
            this.btn_salvar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_salvar.Location = new System.Drawing.Point(514, 233);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(98, 36);
            this.btn_salvar.TabIndex = 30;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.UseVisualStyleBackColor = true;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // btn_excluir_cliente
            // 
            this.btn_excluir_cliente.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_excluir_cliente.Location = new System.Drawing.Point(368, 233);
            this.btn_excluir_cliente.Name = "btn_excluir_cliente";
            this.btn_excluir_cliente.Size = new System.Drawing.Size(98, 36);
            this.btn_excluir_cliente.TabIndex = 29;
            this.btn_excluir_cliente.Text = "Excluir";
            this.btn_excluir_cliente.UseVisualStyleBackColor = true;
            this.btn_excluir_cliente.Click += new System.EventHandler(this.btn_excluir_cliente_Click);
            // 
            // btn_editar_cliente
            // 
            this.btn_editar_cliente.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_editar_cliente.Location = new System.Drawing.Point(206, 233);
            this.btn_editar_cliente.Name = "btn_editar_cliente";
            this.btn_editar_cliente.Size = new System.Drawing.Size(100, 36);
            this.btn_editar_cliente.TabIndex = 28;
            this.btn_editar_cliente.Text = "Editar";
            this.btn_editar_cliente.UseVisualStyleBackColor = true;
            this.btn_editar_cliente.Click += new System.EventHandler(this.btn_editar_cliente_Click);
            // 
            // btn_add_cliente
            // 
            this.btn_add_cliente.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_add_cliente.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_add_cliente.Location = new System.Drawing.Point(47, 233);
            this.btn_add_cliente.Name = "btn_add_cliente";
            this.btn_add_cliente.Size = new System.Drawing.Size(96, 36);
            this.btn_add_cliente.TabIndex = 27;
            this.btn_add_cliente.Text = "Adicionar";
            this.btn_add_cliente.UseVisualStyleBackColor = false;
            this.btn_add_cliente.Click += new System.EventHandler(this.btn_add_cliente_Click);
            // 
            // txt_cod_produto
            // 
            this.txt_cod_produto.Location = new System.Drawing.Point(185, 94);
            this.txt_cod_produto.Name = "txt_cod_produto";
            this.txt_cod_produto.Size = new System.Drawing.Size(72, 23);
            this.txt_cod_produto.TabIndex = 36;
            // 
            // cod_produto
            // 
            this.cod_produto.AutoSize = true;
            this.cod_produto.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cod_produto.Location = new System.Drawing.Point(47, 96);
            this.cod_produto.Name = "cod_produto";
            this.cod_produto.Size = new System.Drawing.Size(92, 21);
            this.cod_produto.TabIndex = 35;
            this.cod_produto.Text = "Id_Produto";
            // 
            // txt_cod_fornecedor
            // 
            this.txt_cod_fornecedor.Location = new System.Drawing.Point(185, 146);
            this.txt_cod_fornecedor.Name = "txt_cod_fornecedor";
            this.txt_cod_fornecedor.Size = new System.Drawing.Size(72, 23);
            this.txt_cod_fornecedor.TabIndex = 34;
            // 
            // cod_fornecedor
            // 
            this.cod_fornecedor.AutoSize = true;
            this.cod_fornecedor.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cod_fornecedor.Location = new System.Drawing.Point(47, 146);
            this.cod_fornecedor.Name = "cod_fornecedor";
            this.cod_fornecedor.Size = new System.Drawing.Size(117, 21);
            this.cod_fornecedor.TabIndex = 33;
            this.cod_fornecedor.Text = "Id_Fornecedor";
            // 
            // txt_nome_produto
            // 
            this.txt_nome_produto.Location = new System.Drawing.Point(125, 39);
            this.txt_nome_produto.Name = "txt_nome_produto";
            this.txt_nome_produto.Size = new System.Drawing.Size(337, 23);
            this.txt_nome_produto.TabIndex = 32;
            // 
            // nome_produto
            // 
            this.nome_produto.AutoSize = true;
            this.nome_produto.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nome_produto.Location = new System.Drawing.Point(47, 37);
            this.nome_produto.Name = "nome_produto";
            this.nome_produto.Size = new System.Drawing.Size(70, 21);
            this.nome_produto.TabIndex = 31;
            this.nome_produto.Text = "Produto";
            // 
            // Produto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 308);
            this.Controls.Add(this.txt_cod_produto);
            this.Controls.Add(this.cod_produto);
            this.Controls.Add(this.txt_cod_fornecedor);
            this.Controls.Add(this.cod_fornecedor);
            this.Controls.Add(this.txt_nome_produto);
            this.Controls.Add(this.nome_produto);
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(this.btn_excluir_cliente);
            this.Controls.Add(this.btn_editar_cliente);
            this.Controls.Add(this.btn_add_cliente);
            this.Name = "Produto";
            this.Text = "Produto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_salvar;
        private Button btn_excluir_cliente;
        private Button btn_editar_cliente;
        private Button btn_add_cliente;
        private TextBox txt_cod_produto;
        private Label cod_produto;
        private TextBox txt_cod_fornecedor;
        private Label cod_fornecedor;
        private TextBox txt_nome_produto;
        private Label nome_produto;
    }
}