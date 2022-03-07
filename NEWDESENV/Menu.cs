namespace NEWDESENV
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.ShowDialog();   
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();    
        }

        private void vendedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vendedor vendedor = new Vendedor();
            vendedor.ShowDialog();
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Produto produto = new Produto();
            produto.ShowDialog();
        }

        private void fornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fornecedor fornecedor = new Fornecedor();
            fornecedor.ShowDialog();
        }

        private void notaFiscalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NotaFiscal notaFiscal = new NotaFiscal();   
            notaFiscal.ShowDialog();    
        }
    }
}