namespace SDC_PDV
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.MenuPrincipal = new System.Windows.Forms.MenuStrip();
            this.menuCadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.frmProduto = new System.Windows.Forms.ToolStripMenuItem();
            this.frmMovimentações = new System.Windows.Forms.ToolStripMenuItem();
            this.frmRelatórios = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSair = new System.Windows.Forms.ToolStripMenuItem();
            this.frmFuncionario = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.menuUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFornecedor = new System.Windows.Forms.ToolStripMenuItem();
            this.menuProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEstoque = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFluxoDeCaixa = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLancarVenda = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEntradasSaidas = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDespesas = new System.Windows.Forms.ToolStripMenuItem();
            this.menuListagemDeProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuVendas = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMovimentos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEntradasaida = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDespesa = new System.Windows.Forms.ToolStripMenuItem();
            this.img04 = new System.Windows.Forms.PictureBox();
            this.img03 = new System.Windows.Forms.PictureBox();
            this.img02 = new System.Windows.Forms.PictureBox();
            this.img01 = new System.Windows.Forms.PictureBox();
            this.MenuPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img04)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img03)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img02)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img01)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuPrincipal
            // 
            this.MenuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCadastro,
            this.frmProduto,
            this.frmMovimentações,
            this.frmRelatórios,
            this.menuSair});
            this.MenuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.MenuPrincipal.Name = "MenuPrincipal";
            this.MenuPrincipal.Size = new System.Drawing.Size(839, 24);
            this.MenuPrincipal.TabIndex = 0;
            this.MenuPrincipal.Text = "Menu";
            // 
            // menuCadastro
            // 
            this.menuCadastro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.frmFuncionario,
            this.menuCliente,
            this.menuUsuario,
            this.menuFornecedor});
            this.menuCadastro.Name = "menuCadastro";
            this.menuCadastro.Size = new System.Drawing.Size(71, 20);
            this.menuCadastro.Text = "Cadastros";
            // 
            // frmProduto
            // 
            this.frmProduto.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuProdutos,
            this.menuEstoque});
            this.frmProduto.Name = "frmProduto";
            this.frmProduto.Size = new System.Drawing.Size(67, 20);
            this.frmProduto.Text = "Produtos";
            // 
            // frmMovimentações
            // 
            this.frmMovimentações.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFluxoDeCaixa,
            this.menuLancarVenda,
            this.menuEntradasSaidas,
            this.menuDespesas});
            this.frmMovimentações.Name = "frmMovimentações";
            this.frmMovimentações.Size = new System.Drawing.Size(104, 20);
            this.frmMovimentações.Text = "Movimentações";
            // 
            // frmRelatórios
            // 
            this.frmRelatórios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuListagemDeProdutos,
            this.menuVendas,
            this.menuMovimentos,
            this.menuEntradasaida,
            this.menuDespesa});
            this.frmRelatórios.Name = "frmRelatórios";
            this.frmRelatórios.Size = new System.Drawing.Size(71, 20);
            this.frmRelatórios.Text = "Relatórios";
            // 
            // menuSair
            // 
            this.menuSair.Name = "menuSair";
            this.menuSair.Size = new System.Drawing.Size(38, 20);
            this.menuSair.Text = "Sair";
            this.menuSair.Click += new System.EventHandler(this.menuSair_Click);
            // 
            // frmFuncionario
            // 
            this.frmFuncionario.Name = "frmFuncionario";
            this.frmFuncionario.Size = new System.Drawing.Size(180, 22);
            this.frmFuncionario.Text = "Funcionários";
            this.frmFuncionario.Click += new System.EventHandler(this.frmFuncionario_Click);
            // 
            // menuCliente
            // 
            this.menuCliente.Name = "menuCliente";
            this.menuCliente.Size = new System.Drawing.Size(180, 22);
            this.menuCliente.Text = "Clientes";
            // 
            // menuUsuario
            // 
            this.menuUsuario.Name = "menuUsuario";
            this.menuUsuario.Size = new System.Drawing.Size(180, 22);
            this.menuUsuario.Text = "Usuário";
            // 
            // menuFornecedor
            // 
            this.menuFornecedor.Name = "menuFornecedor";
            this.menuFornecedor.Size = new System.Drawing.Size(180, 22);
            this.menuFornecedor.Text = "Fornecedor";
            // 
            // menuProdutos
            // 
            this.menuProdutos.Name = "menuProdutos";
            this.menuProdutos.Size = new System.Drawing.Size(122, 22);
            this.menuProdutos.Text = "Produtos";
            // 
            // menuEstoque
            // 
            this.menuEstoque.Name = "menuEstoque";
            this.menuEstoque.Size = new System.Drawing.Size(122, 22);
            this.menuEstoque.Text = "Estoque";
            // 
            // menuFluxoDeCaixa
            // 
            this.menuFluxoDeCaixa.Name = "menuFluxoDeCaixa";
            this.menuFluxoDeCaixa.Size = new System.Drawing.Size(157, 22);
            this.menuFluxoDeCaixa.Text = "Fluxo de caixa";
            // 
            // menuLancarVenda
            // 
            this.menuLancarVenda.Name = "menuLancarVenda";
            this.menuLancarVenda.Size = new System.Drawing.Size(157, 22);
            this.menuLancarVenda.Text = "Lançar venda";
            // 
            // menuEntradasSaidas
            // 
            this.menuEntradasSaidas.Name = "menuEntradasSaidas";
            this.menuEntradasSaidas.Size = new System.Drawing.Size(157, 22);
            this.menuEntradasSaidas.Text = "Entradas/Saídas";
            // 
            // menuDespesas
            // 
            this.menuDespesas.Name = "menuDespesas";
            this.menuDespesas.Size = new System.Drawing.Size(157, 22);
            this.menuDespesas.Text = "Despesas";
            // 
            // menuListagemDeProdutos
            // 
            this.menuListagemDeProdutos.Name = "menuListagemDeProdutos";
            this.menuListagemDeProdutos.Size = new System.Drawing.Size(189, 22);
            this.menuListagemDeProdutos.Text = "Listagem de produtos";
            // 
            // menuVendas
            // 
            this.menuVendas.Name = "menuVendas";
            this.menuVendas.Size = new System.Drawing.Size(189, 22);
            this.menuVendas.Text = "Vendas";
            // 
            // menuMovimentos
            // 
            this.menuMovimentos.Name = "menuMovimentos";
            this.menuMovimentos.Size = new System.Drawing.Size(189, 22);
            this.menuMovimentos.Text = "Movimentos";
            // 
            // menuEntradasaida
            // 
            this.menuEntradasaida.Name = "menuEntradasaida";
            this.menuEntradasaida.Size = new System.Drawing.Size(189, 22);
            this.menuEntradasaida.Text = "Entrada/Saída";
            // 
            // menuDespesa
            // 
            this.menuDespesa.Name = "menuDespesa";
            this.menuDespesa.Size = new System.Drawing.Size(189, 22);
            this.menuDespesa.Text = "Despesas";
            // 
            // img04
            // 
            this.img04.Image = global::SDC_PDV.Properties.Resources.icons8_invoice_64px;
            this.img04.Location = new System.Drawing.Point(276, 285);
            this.img04.Name = "img04";
            this.img04.Size = new System.Drawing.Size(64, 64);
            this.img04.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.img04.TabIndex = 4;
            this.img04.TabStop = false;
            // 
            // img03
            // 
            this.img03.Image = global::SDC_PDV.Properties.Resources.icons8_combo_chart_64px;
            this.img03.Location = new System.Drawing.Point(365, 377);
            this.img03.Name = "img03";
            this.img03.Size = new System.Drawing.Size(64, 64);
            this.img03.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.img03.TabIndex = 3;
            this.img03.TabStop = false;
            // 
            // img02
            // 
            this.img02.Image = global::SDC_PDV.Properties.Resources.icons8_customer_64px;
            this.img02.Location = new System.Drawing.Point(84, 103);
            this.img02.Name = "img02";
            this.img02.Size = new System.Drawing.Size(64, 64);
            this.img02.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.img02.TabIndex = 2;
            this.img02.TabStop = false;
            // 
            // img01
            // 
            this.img01.Image = global::SDC_PDV.Properties.Resources.icons8_checkout_64px;
            this.img01.Location = new System.Drawing.Point(185, 193);
            this.img01.Name = "img01";
            this.img01.Size = new System.Drawing.Size(64, 64);
            this.img01.TabIndex = 1;
            this.img01.TabStop = false;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(839, 557);
            this.Controls.Add(this.img04);
            this.Controls.Add(this.img03);
            this.Controls.Add(this.img02);
            this.Controls.Add(this.img01);
            this.Controls.Add(this.MenuPrincipal);
            this.Font = new System.Drawing.Font("MS Outlook", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuPrincipal;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormPrincipal";
            this.Text = "Sistema de caixa";
            this.MenuPrincipal.ResumeLayout(false);
            this.MenuPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img04)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img03)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img02)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img01)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem menuCadastro;
        private System.Windows.Forms.ToolStripMenuItem frmProduto;
        private System.Windows.Forms.ToolStripMenuItem frmMovimentações;
        private System.Windows.Forms.ToolStripMenuItem frmRelatórios;
        private System.Windows.Forms.ToolStripMenuItem menuSair;
        private System.Windows.Forms.PictureBox img01;
        private System.Windows.Forms.PictureBox img02;
        private System.Windows.Forms.PictureBox img03;
        private System.Windows.Forms.PictureBox img04;
        private System.Windows.Forms.ToolStripMenuItem frmFuncionario;
        private System.Windows.Forms.ToolStripMenuItem menuCliente;
        private System.Windows.Forms.ToolStripMenuItem menuUsuario;
        private System.Windows.Forms.ToolStripMenuItem menuFornecedor;
        private System.Windows.Forms.ToolStripMenuItem menuProdutos;
        private System.Windows.Forms.ToolStripMenuItem menuEstoque;
        private System.Windows.Forms.ToolStripMenuItem menuFluxoDeCaixa;
        private System.Windows.Forms.ToolStripMenuItem menuLancarVenda;
        private System.Windows.Forms.ToolStripMenuItem menuEntradasSaidas;
        private System.Windows.Forms.ToolStripMenuItem menuDespesas;
        private System.Windows.Forms.ToolStripMenuItem menuListagemDeProdutos;
        private System.Windows.Forms.ToolStripMenuItem menuVendas;
        private System.Windows.Forms.ToolStripMenuItem menuMovimentos;
        private System.Windows.Forms.ToolStripMenuItem menuEntradasaida;
        private System.Windows.Forms.ToolStripMenuItem menuDespesa;
    }
}

