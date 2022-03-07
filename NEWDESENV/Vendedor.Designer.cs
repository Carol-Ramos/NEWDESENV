namespace NEWDESENV
{
    partial class Vendedor
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
            this.btn_add_vendedor = new System.Windows.Forms.Button();
            this.txt_cod_funcionario = new System.Windows.Forms.TextBox();
            this.id_funcionario = new System.Windows.Forms.Label();
            this.txt_nome_funcionario = new System.Windows.Forms.TextBox();
            this.nome_funcionario = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_salvar
            // 
            this.btn_salvar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_salvar.Location = new System.Drawing.Point(508, 232);
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
            this.btn_excluir_cliente.Location = new System.Drawing.Point(362, 232);
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
            this.btn_editar_cliente.Location = new System.Drawing.Point(200, 232);
            this.btn_editar_cliente.Name = "btn_editar_cliente";
            this.btn_editar_cliente.Size = new System.Drawing.Size(100, 36);
            this.btn_editar_cliente.TabIndex = 28;
            this.btn_editar_cliente.Text = "Editar";
            this.btn_editar_cliente.UseVisualStyleBackColor = true;
            this.btn_editar_cliente.Click += new System.EventHandler(this.btn_editar_cliente_Click);
            // 
            // btn_add_vendedor
            // 
            this.btn_add_vendedor.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_add_vendedor.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_add_vendedor.Location = new System.Drawing.Point(41, 232);
            this.btn_add_vendedor.Name = "btn_add_vendedor";
            this.btn_add_vendedor.Size = new System.Drawing.Size(96, 36);
            this.btn_add_vendedor.TabIndex = 27;
            this.btn_add_vendedor.Text = "Adicionar";
            this.btn_add_vendedor.UseVisualStyleBackColor = false;
            this.btn_add_vendedor.Click += new System.EventHandler(this.btn_add_cliente_Click);
            // 
            // txt_cod_funcionario
            // 
            this.txt_cod_funcionario.Location = new System.Drawing.Point(284, 133);
            this.txt_cod_funcionario.Name = "txt_cod_funcionario";
            this.txt_cod_funcionario.Size = new System.Drawing.Size(225, 23);
            this.txt_cod_funcionario.TabIndex = 34;
            // 
            // id_funcionario
            // 
            this.id_funcionario.AutoSize = true;
            this.id_funcionario.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.id_funcionario.Location = new System.Drawing.Point(121, 133);
            this.id_funcionario.Name = "id_funcionario";
            this.id_funcionario.Size = new System.Drawing.Size(117, 21);
            this.id_funcionario.TabIndex = 33;
            this.id_funcionario.Text = "Id_Funcionario";
            // 
            // txt_nome_funcionario
            // 
            this.txt_nome_funcionario.Location = new System.Drawing.Point(200, 55);
            this.txt_nome_funcionario.Name = "txt_nome_funcionario";
            this.txt_nome_funcionario.Size = new System.Drawing.Size(337, 23);
            this.txt_nome_funcionario.TabIndex = 32;
            // 
            // nome_funcionario
            // 
            this.nome_funcionario.AutoSize = true;
            this.nome_funcionario.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nome_funcionario.Location = new System.Drawing.Point(121, 58);
            this.nome_funcionario.Name = "nome_funcionario";
            this.nome_funcionario.Size = new System.Drawing.Size(55, 21);
            this.nome_funcionario.TabIndex = 31;
            this.nome_funcionario.Text = "Nome";
            // 
            // Vendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 308);
            this.Controls.Add(this.txt_cod_funcionario);
            this.Controls.Add(this.id_funcionario);
            this.Controls.Add(this.txt_nome_funcionario);
            this.Controls.Add(this.nome_funcionario);
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(this.btn_excluir_cliente);
            this.Controls.Add(this.btn_editar_cliente);
            this.Controls.Add(this.btn_add_vendedor);
            this.Name = "Vendedor";
            this.Text = "Vendedor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_salvar;
        private Button btn_excluir_cliente;
        private Button btn_editar_cliente;
        private Button btn_add_vendedor;
        private TextBox txt_cod_funcionario;
        private Label id_funcionario;
        private TextBox txt_nome_funcionario;
        private Label nome_funcionario;
    }
}