namespace NEWDESENV
{
    partial class NotaFiscal
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
            this.id_vendedor = new System.Windows.Forms.TextBox();
            this.cod_funcionario = new System.Windows.Forms.Label();
            this.id_produto = new System.Windows.Forms.TextBox();
            this.cod_produto = new System.Windows.Forms.Label();
            this.txt_id_fornecedor = new System.Windows.Forms.TextBox();
            this.id_fornecedor = new System.Windows.Forms.Label();
            this.txt_id_cliente = new System.Windows.Forms.TextBox();
            this.id_cliente = new System.Windows.Forms.Label();
            this.txt_id_nota_fiscal = new System.Windows.Forms.TextBox();
            this.id_nota_fiscal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_salvar
            // 
            this.btn_salvar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_salvar.Location = new System.Drawing.Point(482, 349);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(98, 36);
            this.btn_salvar.TabIndex = 47;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.UseVisualStyleBackColor = true;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // btn_excluir_cliente
            // 
            this.btn_excluir_cliente.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_excluir_cliente.Location = new System.Drawing.Point(336, 349);
            this.btn_excluir_cliente.Name = "btn_excluir_cliente";
            this.btn_excluir_cliente.Size = new System.Drawing.Size(98, 36);
            this.btn_excluir_cliente.TabIndex = 46;
            this.btn_excluir_cliente.Text = "Excluir";
            this.btn_excluir_cliente.UseVisualStyleBackColor = true;
            this.btn_excluir_cliente.Click += new System.EventHandler(this.btn_excluir_cliente_Click);
            // 
            // btn_editar_cliente
            // 
            this.btn_editar_cliente.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_editar_cliente.Location = new System.Drawing.Point(174, 349);
            this.btn_editar_cliente.Name = "btn_editar_cliente";
            this.btn_editar_cliente.Size = new System.Drawing.Size(100, 36);
            this.btn_editar_cliente.TabIndex = 45;
            this.btn_editar_cliente.Text = "Editar";
            this.btn_editar_cliente.UseVisualStyleBackColor = true;
            this.btn_editar_cliente.Click += new System.EventHandler(this.btn_editar_cliente_Click);
            // 
            // btn_add_cliente
            // 
            this.btn_add_cliente.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_add_cliente.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_add_cliente.Location = new System.Drawing.Point(15, 349);
            this.btn_add_cliente.Name = "btn_add_cliente";
            this.btn_add_cliente.Size = new System.Drawing.Size(96, 36);
            this.btn_add_cliente.TabIndex = 44;
            this.btn_add_cliente.Text = "Adicionar";
            this.btn_add_cliente.UseVisualStyleBackColor = false;
            this.btn_add_cliente.Click += new System.EventHandler(this.btn_add_cliente_Click);
            // 
            // id_vendedor
            // 
            this.id_vendedor.Location = new System.Drawing.Point(310, 263);
            this.id_vendedor.Name = "id_vendedor";
            this.id_vendedor.Size = new System.Drawing.Size(124, 23);
            this.id_vendedor.TabIndex = 57;
            // 
            // cod_funcionario
            // 
            this.cod_funcionario.AutoSize = true;
            this.cod_funcionario.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cod_funcionario.Location = new System.Drawing.Point(161, 265);
            this.cod_funcionario.Name = "cod_funcionario";
            this.cod_funcionario.Size = new System.Drawing.Size(104, 21);
            this.cod_funcionario.TabIndex = 56;
            this.cod_funcionario.Text = "Id_Vendedor";
            // 
            // id_produto
            // 
            this.id_produto.Location = new System.Drawing.Point(310, 204);
            this.id_produto.Name = "id_produto";
            this.id_produto.Size = new System.Drawing.Size(124, 23);
            this.id_produto.TabIndex = 55;
            // 
            // cod_produto
            // 
            this.cod_produto.AutoSize = true;
            this.cod_produto.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cod_produto.Location = new System.Drawing.Point(161, 206);
            this.cod_produto.Name = "cod_produto";
            this.cod_produto.Size = new System.Drawing.Size(92, 21);
            this.cod_produto.TabIndex = 54;
            this.cod_produto.Text = "Id_Produto";
            // 
            // txt_id_fornecedor
            // 
            this.txt_id_fornecedor.Location = new System.Drawing.Point(310, 96);
            this.txt_id_fornecedor.Name = "txt_id_fornecedor";
            this.txt_id_fornecedor.Size = new System.Drawing.Size(124, 23);
            this.txt_id_fornecedor.TabIndex = 53;
            // 
            // id_fornecedor
            // 
            this.id_fornecedor.AutoSize = true;
            this.id_fornecedor.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.id_fornecedor.Location = new System.Drawing.Point(161, 98);
            this.id_fornecedor.Name = "id_fornecedor";
            this.id_fornecedor.Size = new System.Drawing.Size(117, 21);
            this.id_fornecedor.TabIndex = 52;
            this.id_fornecedor.Text = "Id_Fornecedor";
            // 
            // txt_id_cliente
            // 
            this.txt_id_cliente.Location = new System.Drawing.Point(310, 148);
            this.txt_id_cliente.Name = "txt_id_cliente";
            this.txt_id_cliente.Size = new System.Drawing.Size(124, 23);
            this.txt_id_cliente.TabIndex = 51;
            // 
            // id_cliente
            // 
            this.id_cliente.AutoSize = true;
            this.id_cliente.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.id_cliente.Location = new System.Drawing.Point(161, 148);
            this.id_cliente.Name = "id_cliente";
            this.id_cliente.Size = new System.Drawing.Size(83, 21);
            this.id_cliente.TabIndex = 50;
            this.id_cliente.Text = "Id_Cliente";
            // 
            // txt_id_nota_fiscal
            // 
            this.txt_id_nota_fiscal.Location = new System.Drawing.Point(310, 41);
            this.txt_id_nota_fiscal.Name = "txt_id_nota_fiscal";
            this.txt_id_nota_fiscal.Size = new System.Drawing.Size(124, 23);
            this.txt_id_nota_fiscal.TabIndex = 49;
            // 
            // id_nota_fiscal
            // 
            this.id_nota_fiscal.AutoSize = true;
            this.id_nota_fiscal.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.id_nota_fiscal.Location = new System.Drawing.Point(161, 39);
            this.id_nota_fiscal.Name = "id_nota_fiscal";
            this.id_nota_fiscal.Size = new System.Drawing.Size(25, 21);
            this.id_nota_fiscal.TabIndex = 48;
            this.id_nota_fiscal.Text = "Id";
            // 
            // NotaFiscal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 417);
            this.Controls.Add(this.id_vendedor);
            this.Controls.Add(this.cod_funcionario);
            this.Controls.Add(this.id_produto);
            this.Controls.Add(this.cod_produto);
            this.Controls.Add(this.txt_id_fornecedor);
            this.Controls.Add(this.id_fornecedor);
            this.Controls.Add(this.txt_id_cliente);
            this.Controls.Add(this.id_cliente);
            this.Controls.Add(this.txt_id_nota_fiscal);
            this.Controls.Add(this.id_nota_fiscal);
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(this.btn_excluir_cliente);
            this.Controls.Add(this.btn_editar_cliente);
            this.Controls.Add(this.btn_add_cliente);
            this.Name = "NotaFiscal";
            this.Text = "NotaFiscal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_salvar;
        private Button btn_excluir_cliente;
        private Button btn_editar_cliente;
        private Button btn_add_cliente;
        private TextBox id_vendedor;
        private Label cod_funcionario;
        private TextBox id_produto;
        private Label cod_produto;
        private TextBox txt_id_fornecedor;
        private Label id_fornecedor;
        private TextBox txt_id_cliente;
        private Label id_cliente;
        private TextBox txt_id_nota_fiscal;
        private Label id_nota_fiscal;
    }
}