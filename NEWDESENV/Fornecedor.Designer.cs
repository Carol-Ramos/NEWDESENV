namespace NEWDESENV
{
    partial class Fornecedor
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
            this.txt_cnpj = new System.Windows.Forms.TextBox();
            this.cnpj = new System.Windows.Forms.Label();
            this.txt_cod_fornecedor = new System.Windows.Forms.TextBox();
            this.id_fornecedor = new System.Windows.Forms.Label();
            this.txt_fornecedor = new System.Windows.Forms.TextBox();
            this.nome_fornecedor = new System.Windows.Forms.Label();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.btn_excluir_cliente = new System.Windows.Forms.Button();
            this.btn_editar_cliente = new System.Windows.Forms.Button();
            this.btn_add_cliente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_cnpj
            // 
            this.txt_cnpj.Location = new System.Drawing.Point(140, 99);
            this.txt_cnpj.Name = "txt_cnpj";
            this.txt_cnpj.Size = new System.Drawing.Size(289, 23);
            this.txt_cnpj.TabIndex = 39;
            // 
            // cnpj
            // 
            this.cnpj.AutoSize = true;
            this.cnpj.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cnpj.Location = new System.Drawing.Point(39, 101);
            this.cnpj.Name = "cnpj";
            this.cnpj.Size = new System.Drawing.Size(46, 21);
            this.cnpj.TabIndex = 38;
            this.cnpj.Text = "CNPJ";
            // 
            // txt_cod_fornecedor
            // 
            this.txt_cod_fornecedor.Location = new System.Drawing.Point(177, 151);
            this.txt_cod_fornecedor.Name = "txt_cod_fornecedor";
            this.txt_cod_fornecedor.Size = new System.Drawing.Size(72, 23);
            this.txt_cod_fornecedor.TabIndex = 37;
            // 
            // id_fornecedor
            // 
            this.id_fornecedor.AutoSize = true;
            this.id_fornecedor.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.id_fornecedor.Location = new System.Drawing.Point(39, 151);
            this.id_fornecedor.Name = "id_fornecedor";
            this.id_fornecedor.Size = new System.Drawing.Size(117, 21);
            this.id_fornecedor.TabIndex = 36;
            this.id_fornecedor.Text = "Id_Fornecedor";
            // 
            // txt_fornecedor
            // 
            this.txt_fornecedor.Location = new System.Drawing.Point(140, 44);
            this.txt_fornecedor.Name = "txt_fornecedor";
            this.txt_fornecedor.Size = new System.Drawing.Size(289, 23);
            this.txt_fornecedor.TabIndex = 35;
            // 
            // nome_fornecedor
            // 
            this.nome_fornecedor.AutoSize = true;
            this.nome_fornecedor.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nome_fornecedor.Location = new System.Drawing.Point(39, 42);
            this.nome_fornecedor.Name = "nome_fornecedor";
            this.nome_fornecedor.Size = new System.Drawing.Size(95, 21);
            this.nome_fornecedor.TabIndex = 34;
            this.nome_fornecedor.Text = "Fornecedor";
            // 
            // btn_salvar
            // 
            this.btn_salvar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_salvar.Location = new System.Drawing.Point(505, 228);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(98, 36);
            this.btn_salvar.TabIndex = 43;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.UseVisualStyleBackColor = true;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // btn_excluir_cliente
            // 
            this.btn_excluir_cliente.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_excluir_cliente.Location = new System.Drawing.Point(359, 228);
            this.btn_excluir_cliente.Name = "btn_excluir_cliente";
            this.btn_excluir_cliente.Size = new System.Drawing.Size(98, 36);
            this.btn_excluir_cliente.TabIndex = 42;
            this.btn_excluir_cliente.Text = "Excluir";
            this.btn_excluir_cliente.UseVisualStyleBackColor = true;
            this.btn_excluir_cliente.Click += new System.EventHandler(this.btn_excluir_cliente_Click);
            // 
            // btn_editar_cliente
            // 
            this.btn_editar_cliente.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_editar_cliente.Location = new System.Drawing.Point(197, 228);
            this.btn_editar_cliente.Name = "btn_editar_cliente";
            this.btn_editar_cliente.Size = new System.Drawing.Size(100, 36);
            this.btn_editar_cliente.TabIndex = 41;
            this.btn_editar_cliente.Text = "Editar";
            this.btn_editar_cliente.UseVisualStyleBackColor = true;
            this.btn_editar_cliente.Click += new System.EventHandler(this.btn_editar_cliente_Click);
            // 
            // btn_add_cliente
            // 
            this.btn_add_cliente.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_add_cliente.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_add_cliente.Location = new System.Drawing.Point(38, 228);
            this.btn_add_cliente.Name = "btn_add_cliente";
            this.btn_add_cliente.Size = new System.Drawing.Size(96, 36);
            this.btn_add_cliente.TabIndex = 40;
            this.btn_add_cliente.Text = "Adicionar";
            this.btn_add_cliente.UseVisualStyleBackColor = false;
            this.btn_add_cliente.Click += new System.EventHandler(this.btn_add_cliente_Click);
            // 
            // Fornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 308);
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(this.btn_excluir_cliente);
            this.Controls.Add(this.btn_editar_cliente);
            this.Controls.Add(this.btn_add_cliente);
            this.Controls.Add(this.txt_cnpj);
            this.Controls.Add(this.cnpj);
            this.Controls.Add(this.txt_cod_fornecedor);
            this.Controls.Add(this.id_fornecedor);
            this.Controls.Add(this.txt_fornecedor);
            this.Controls.Add(this.nome_fornecedor);
            this.Name = "Fornecedor";
            this.Text = "Fornecedor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txt_cnpj;
        private Label cnpj;
        private TextBox txt_cod_fornecedor;
        private Label id_fornecedor;
        private TextBox txt_fornecedor;
        private Label nome_fornecedor;
        private Button btn_salvar;
        private Button btn_excluir_cliente;
        private Button btn_editar_cliente;
        private Button btn_add_cliente;
    }
}