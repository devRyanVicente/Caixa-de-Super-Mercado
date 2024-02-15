namespace Aplicativo_de_Caixa_de_Super_Mercado
{
    partial class SubProdutos
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
            DataGridDB = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtIDProduto = new TextBox();
            txtNomeProduto = new TextBox();
            txtValorProduto = new TextBox();
            txtPesquisa = new TextBox();
            btnCriarProduto = new Button();
            btnAlterarProduto = new Button();
            btnExcluirProduto = new Button();
            btnConfirmarCriarProduto = new Button();
            btnConfirmarExcluirProduto = new Button();
            btnConfirmarAlteracaoProduto = new Button();
            btnCancelarProdutos = new Button();
            boxCategoriaProdutos = new ComboBox();
            boxAutoID = new CheckBox();
            btnBuscar = new Button();
            label4 = new Label();
            btnEditCategoria = new Button();
            ((System.ComponentModel.ISupportInitialize)DataGridDB).BeginInit();
            SuspendLayout();
            // 
            // DataGridDB
            // 
            DataGridDB.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            DataGridDB.Location = new Point(12, 12);
            DataGridDB.Name = "DataGridDB";
            DataGridDB.Size = new Size(776, 311);
            DataGridDB.TabIndex = 1;
            DataGridDB.CellEnter += DataGridDB_CellEnter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(98, 332);
            label1.Name = "label1";
            label1.Size = new Size(21, 15);
            label1.TabIndex = 2;
            label1.Text = "ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 362);
            label2.Name = "label2";
            label2.Size = new Size(106, 15);
            label2.TabIndex = 3;
            label2.Text = "Nome do Produto:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 391);
            label3.Name = "label3";
            label3.Size = new Size(99, 15);
            label3.TabIndex = 4;
            label3.Text = "Valor do Produto:";
            // 
            // txtIDProduto
            // 
            txtIDProduto.Location = new Point(124, 330);
            txtIDProduto.Name = "txtIDProduto";
            txtIDProduto.ReadOnly = true;
            txtIDProduto.Size = new Size(100, 23);
            txtIDProduto.TabIndex = 5;
            // 
            // txtNomeProduto
            // 
            txtNomeProduto.Location = new Point(124, 359);
            txtNomeProduto.Name = "txtNomeProduto";
            txtNomeProduto.ReadOnly = true;
            txtNomeProduto.Size = new Size(100, 23);
            txtNomeProduto.TabIndex = 6;
            // 
            // txtValorProduto
            // 
            txtValorProduto.Location = new Point(124, 387);
            txtValorProduto.Name = "txtValorProduto";
            txtValorProduto.ReadOnly = true;
            txtValorProduto.Size = new Size(100, 23);
            txtValorProduto.TabIndex = 7;
            // 
            // txtPesquisa
            // 
            txtPesquisa.Location = new Point(501, 329);
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.Size = new Size(233, 23);
            txtPesquisa.TabIndex = 8;
            // 
            // btnCriarProduto
            // 
            btnCriarProduto.Location = new Point(230, 332);
            btnCriarProduto.Name = "btnCriarProduto";
            btnCriarProduto.Size = new Size(98, 23);
            btnCriarProduto.TabIndex = 9;
            btnCriarProduto.Text = "Criar Produto";
            btnCriarProduto.UseVisualStyleBackColor = true;
            btnCriarProduto.Click += btnCriarProduto_Click;
            // 
            // btnAlterarProduto
            // 
            btnAlterarProduto.Location = new Point(232, 362);
            btnAlterarProduto.Name = "btnAlterarProduto";
            btnAlterarProduto.Size = new Size(98, 23);
            btnAlterarProduto.TabIndex = 10;
            btnAlterarProduto.Text = "Alterar Produto";
            btnAlterarProduto.UseVisualStyleBackColor = true;
            btnAlterarProduto.Click += btnAlterarProduto_Click;
            // 
            // btnExcluirProduto
            // 
            btnExcluirProduto.Location = new Point(232, 391);
            btnExcluirProduto.Name = "btnExcluirProduto";
            btnExcluirProduto.Size = new Size(98, 23);
            btnExcluirProduto.TabIndex = 11;
            btnExcluirProduto.Text = "Excluir Produto";
            btnExcluirProduto.UseVisualStyleBackColor = true;
            btnExcluirProduto.Click += btnExcluirProduto_Click;
            // 
            // btnConfirmarCriarProduto
            // 
            btnConfirmarCriarProduto.Location = new Point(230, 333);
            btnConfirmarCriarProduto.Name = "btnConfirmarCriarProduto";
            btnConfirmarCriarProduto.Size = new Size(160, 23);
            btnConfirmarCriarProduto.TabIndex = 12;
            btnConfirmarCriarProduto.Text = "Criar Registro do Produto";
            btnConfirmarCriarProduto.UseVisualStyleBackColor = true;
            btnConfirmarCriarProduto.Visible = false;
            btnConfirmarCriarProduto.Click += btnConfirmarCriarProduto_Click;
            // 
            // btnConfirmarExcluirProduto
            // 
            btnConfirmarExcluirProduto.Location = new Point(232, 391);
            btnConfirmarExcluirProduto.Name = "btnConfirmarExcluirProduto";
            btnConfirmarExcluirProduto.Size = new Size(162, 23);
            btnConfirmarExcluirProduto.TabIndex = 13;
            btnConfirmarExcluirProduto.Text = "Excluir Registro do Produto";
            btnConfirmarExcluirProduto.UseVisualStyleBackColor = true;
            btnConfirmarExcluirProduto.Visible = false;
            btnConfirmarExcluirProduto.Click += btnConfirmarExcluirProduto_Click;
            // 
            // btnConfirmarAlteracaoProduto
            // 
            btnConfirmarAlteracaoProduto.Location = new Point(232, 362);
            btnConfirmarAlteracaoProduto.Name = "btnConfirmarAlteracaoProduto";
            btnConfirmarAlteracaoProduto.Size = new Size(128, 23);
            btnConfirmarAlteracaoProduto.TabIndex = 14;
            btnConfirmarAlteracaoProduto.Text = "Confirmar Alterações";
            btnConfirmarAlteracaoProduto.UseVisualStyleBackColor = true;
            btnConfirmarAlteracaoProduto.Visible = false;
            btnConfirmarAlteracaoProduto.Click += btnConfirmarAlteracaoProduto_Click;
            // 
            // btnCancelarProdutos
            // 
            btnCancelarProdutos.Location = new Point(366, 362);
            btnCancelarProdutos.Name = "btnCancelarProdutos";
            btnCancelarProdutos.Size = new Size(65, 23);
            btnCancelarProdutos.TabIndex = 15;
            btnCancelarProdutos.Text = "Cancelar";
            btnCancelarProdutos.UseVisualStyleBackColor = true;
            btnCancelarProdutos.Visible = false;
            btnCancelarProdutos.Click += btnCancelarProdutos_Click;
            // 
            // boxCategoriaProdutos
            // 
            boxCategoriaProdutos.Enabled = false;
            boxCategoriaProdutos.FormattingEnabled = true;
            boxCategoriaProdutos.Location = new Point(125, 417);
            boxCategoriaProdutos.Name = "boxCategoriaProdutos";
            boxCategoriaProdutos.Size = new Size(99, 23);
            boxCategoriaProdutos.TabIndex = 16;
            // 
            // boxAutoID
            // 
            boxAutoID.AutoSize = true;
            boxAutoID.Checked = true;
            boxAutoID.CheckState = CheckState.Checked;
            boxAutoID.Location = new Point(26, 330);
            boxAutoID.Name = "boxAutoID";
            boxAutoID.Size = new Size(66, 19);
            boxAutoID.TabIndex = 17;
            boxAutoID.Text = "Auto ID";
            boxAutoID.UseVisualStyleBackColor = true;
            boxAutoID.Visible = false;
            boxAutoID.CheckedChanged += boxAutoID_CheckedChanged;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(740, 329);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(57, 23);
            btnBuscar.TabIndex = 18;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(58, 420);
            label4.Name = "label4";
            label4.Size = new Size(61, 15);
            label4.TabIndex = 19;
            label4.Text = "Categoria:";
            // 
            // btnEditCategoria
            // 
            btnEditCategoria.Location = new Point(230, 417);
            btnEditCategoria.Name = "btnEditCategoria";
            btnEditCategoria.Size = new Size(112, 23);
            btnEditCategoria.TabIndex = 20;
            btnEditCategoria.Text = "Editar Categorias";
            btnEditCategoria.UseVisualStyleBackColor = true;
            btnEditCategoria.Click += btnEditCategoria_Click;
            // 
            // SubProdutos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEditCategoria);
            Controls.Add(label4);
            Controls.Add(btnBuscar);
            Controls.Add(boxAutoID);
            Controls.Add(boxCategoriaProdutos);
            Controls.Add(btnCancelarProdutos);
            Controls.Add(btnConfirmarAlteracaoProduto);
            Controls.Add(btnConfirmarExcluirProduto);
            Controls.Add(btnConfirmarCriarProduto);
            Controls.Add(btnExcluirProduto);
            Controls.Add(btnAlterarProduto);
            Controls.Add(btnCriarProduto);
            Controls.Add(txtPesquisa);
            Controls.Add(txtValorProduto);
            Controls.Add(txtNomeProduto);
            Controls.Add(txtIDProduto);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(DataGridDB);
            Name = "SubProdutos";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Produtos";
            Load += SubProdutos_Load;
            ((System.ComponentModel.ISupportInitialize)DataGridDB).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DataGridDB;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtIDProduto;
        private TextBox txtNomeProduto;
        private TextBox txtValorProduto;
        private TextBox txtPesquisa;
        private Button btnCriarProduto;
        private Button btnAlterarProduto;
        private Button btnExcluirProduto;
        private Button btnConfirmarCriarProduto;
        private Button btnConfirmarExcluirProduto;
        private Button btnConfirmarAlteracaoProduto;
        private Button btnCancelarProdutos;
        private ComboBox boxCategoriaProdutos;
        private CheckBox boxAutoID;
        private Button btnBuscar;
        private Label label4;
        private Button btnEditCategoria;
    }
}