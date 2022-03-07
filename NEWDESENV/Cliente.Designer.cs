namespace NEWDESENV
{
    partial class Cliente
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
            this.txt_cpf_cliente = new System.Windows.Forms.TextBox();
            this.cpf_cliente = new System.Windows.Forms.Label();
            this.txt_cod_cliente = new System.Windows.Forms.TextBox();
            this.cod_cliente = new System.Windows.Forms.Label();
            this.btn_excluir_cliente = new System.Windows.Forms.Button();
            this.btn_editar_cliente = new System.Windows.Forms.Button();
            this.btn_add_cliente = new System.Windows.Forms.Button();
            this.txt_nome_cliente = new System.Windows.Forms.TextBox();
            this.nome_cliente = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_salvar
            // 
            this.btn_salvar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_salvar.Location = new System.Drawing.Point(526, 235);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(98, 36);
            this.btn_salvar.TabIndex = 26;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.UseVisualStyleBackColor = true;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // txt_cpf_cliente
            // 
            this.txt_cpf_cliente.Location = new System.Drawing.Point(119, 95);
            this.txt_cpf_cliente.Name = "txt_cpf_cliente";
            this.txt_cpf_cliente.Size = new System.Drawing.Size(337, 23);
            this.txt_cpf_cliente.TabIndex = 25;
            // 
            // cpf_cliente
            // 
            this.cpf_cliente.AutoSize = true;
            this.cpf_cliente.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cpf_cliente.Location = new System.Drawing.Point(41, 97);
            this.cpf_cliente.Name = "cpf_cliente";
            this.cpf_cliente.Size = new System.Drawing.Size(37, 21);
            this.cpf_cliente.TabIndex = 24;
            this.cpf_cliente.Text = "CPF";
            // 
            // txt_cod_cliente
            // 
            this.txt_cod_cliente.Location = new System.Drawing.Point(145, 149);
            this.txt_cod_cliente.Name = "txt_cod_cliente";
            this.txt_cod_cliente.Size = new System.Drawing.Size(88, 23);
            this.txt_cod_cliente.TabIndex = 23;
            // 
            // cod_cliente
            // 
            this.cod_cliente.AutoSize = true;
            this.cod_cliente.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cod_cliente.Location = new System.Drawing.Point(41, 147);
            this.cod_cliente.Name = "cod_cliente";
            this.cod_cliente.Size = new System.Drawing.Size(83, 21);
            this.cod_cliente.TabIndex = 22;
            this.cod_cliente.Text = "Id_Cliente";
            // 
            // btn_excluir_cliente
            // 
            this.btn_excluir_cliente.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_excluir_cliente.Location = new System.Drawing.Point(380, 235);
            this.btn_excluir_cliente.Name = "btn_excluir_cliente";
            this.btn_excluir_cliente.Size = new System.Drawing.Size(98, 36);
            this.btn_excluir_cliente.TabIndex = 21;
            this.btn_excluir_cliente.Text = "Excluir";
            this.btn_excluir_cliente.UseVisualStyleBackColor = true;
            this.btn_excluir_cliente.Click += new System.EventHandler(this.btn_excluir_cliente_Click);
            // 
            // btn_editar_cliente
            // 
            this.btn_editar_cliente.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_editar_cliente.Location = new System.Drawing.Point(218, 235);
            this.btn_editar_cliente.Name = "btn_editar_cliente";
            this.btn_editar_cliente.Size = new System.Drawing.Size(100, 36);
            this.btn_editar_cliente.TabIndex = 20;
            this.btn_editar_cliente.Text = "Editar";
            this.btn_editar_cliente.UseVisualStyleBackColor = true;
            this.btn_editar_cliente.Click += new System.EventHandler(this.btn_editar_cliente_Click);
            // 
            // btn_add_cliente
            // 
            this.btn_add_cliente.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_add_cliente.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_add_cliente.Location = new System.Drawing.Point(59, 235);
            this.btn_add_cliente.Name = "btn_add_cliente";
            this.btn_add_cliente.Size = new System.Drawing.Size(96, 36);
            this.btn_add_cliente.TabIndex = 19;
            this.btn_add_cliente.Text = "Adicionar";
            this.btn_add_cliente.UseVisualStyleBackColor = false;
            this.btn_add_cliente.Click += new System.EventHandler(this.btn_add_cliente_Click);
            // 
            // txt_nome_cliente
            // 
            this.txt_nome_cliente.Location = new System.Drawing.Point(119, 40);
            this.txt_nome_cliente.Name = "txt_nome_cliente";
            this.txt_nome_cliente.Size = new System.Drawing.Size(337, 23);
            this.txt_nome_cliente.TabIndex = 18;
            this.txt_nome_cliente.TextChanged += new System.EventHandler(this.txt_nome_cliente_TextChanged);
            // 
            // nome_cliente
            // 
            this.nome_cliente.AutoSize = true;
            this.nome_cliente.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nome_cliente.Location = new System.Drawing.Point(41, 38);
            this.nome_cliente.Name = "nome_cliente";
            this.nome_cliente.Size = new System.Drawing.Size(55, 21);
            this.nome_cliente.TabIndex = 17;
            this.nome_cliente.Text = "Nome";
            // 
            // Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 308);
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(this.txt_cpf_cliente);
            this.Controls.Add(this.cpf_cliente);
            this.Controls.Add(this.txt_cod_cliente);
            this.Controls.Add(this.cod_cliente);
            this.Controls.Add(this.btn_excluir_cliente);
            this.Controls.Add(this.btn_editar_cliente);
            this.Controls.Add(this.btn_add_cliente);
            this.Controls.Add(this.txt_nome_cliente);
            this.Controls.Add(this.nome_cliente);
            this.Name = "Cliente";
            this.Text = "Cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_salvar;
        private TextBox txt_cpf_cliente;
        private Label cpf_cliente;
        private TextBox txt_cod_cliente;
        private Label cod_cliente;
        private Button btn_excluir_cliente;
        private Button btn_editar_cliente;
        private Button btn_add_cliente;
        private TextBox txt_nome_cliente;
        private Label nome_cliente;
    }
}