namespace Aplicativo_de_Caixa_de_Super_Mercado.SubAdmin
{
    partial class SubCategorias
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
            btnConfirmarCriarProduto = new Button();
            DataGridDB = new DataGridView();
            txtCategoriaCriar = new TextBox();
            txtUniqueID = new TextBox();
            txtPesquisa = new TextBox();
            button1 = new Button();
            btnCriarCategoria = new Button();
            btnEditarCategoria = new Button();
            btnRemoverCategoria = new Button();
            btnConfirmarEdicao = new Button();
            btnConfirmarRemocao = new Button();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)DataGridDB).BeginInit();
            SuspendLayout();
            // 
            // btnConfirmarCriarProduto
            // 
            btnConfirmarCriarProduto.Location = new Point(232, 415);
            btnConfirmarCriarProduto.Name = "btnConfirmarCriarProduto";
            btnConfirmarCriarProduto.Size = new Size(156, 23);
            btnConfirmarCriarProduto.TabIndex = 13;
            btnConfirmarCriarProduto.Text = "Criar Registro da Categoria";
            btnConfirmarCriarProduto.UseVisualStyleBackColor = true;
            btnConfirmarCriarProduto.Visible = false;
            btnConfirmarCriarProduto.Click += btnConfirmarCriarProduto_Click;
            // 
            // DataGridDB
            // 
            DataGridDB.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            DataGridDB.Location = new Point(41, 11);
            DataGridDB.Name = "DataGridDB";
            DataGridDB.Size = new Size(562, 340);
            DataGridDB.TabIndex = 14;
            DataGridDB.CellContentClick += DataGridDB_CellContentClick;
            DataGridDB.CellEnter += DataGridDB_CellEnter;
            // 
            // txtCategoriaCriar
            // 
            txtCategoriaCriar.Location = new Point(221, 386);
            txtCategoriaCriar.MaxLength = 64;
            txtCategoriaCriar.Name = "txtCategoriaCriar";
            txtCategoriaCriar.ReadOnly = true;
            txtCategoriaCriar.Size = new Size(178, 23);
            txtCategoriaCriar.TabIndex = 15;
            // 
            // txtUniqueID
            // 
            txtUniqueID.Location = new Point(221, 357);
            txtUniqueID.Name = "txtUniqueID";
            txtUniqueID.ReadOnly = true;
            txtUniqueID.Size = new Size(178, 23);
            txtUniqueID.TabIndex = 16;
            // 
            // txtPesquisa
            // 
            txtPesquisa.Location = new Point(419, 357);
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.Size = new Size(137, 23);
            txtPesquisa.TabIndex = 17;
            txtPesquisa.PreviewKeyDown += txtPesquisa_PreviewKeyDown;
            // 
            // button1
            // 
            button1.Location = new Point(562, 357);
            button1.Name = "button1";
            button1.Size = new Size(63, 23);
            button1.TabIndex = 18;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnCriarCategoria
            // 
            btnCriarCategoria.Location = new Point(232, 415);
            btnCriarCategoria.Name = "btnCriarCategoria";
            btnCriarCategoria.Size = new Size(156, 23);
            btnCriarCategoria.TabIndex = 19;
            btnCriarCategoria.Text = "Criar Categoria";
            btnCriarCategoria.UseVisualStyleBackColor = true;
            btnCriarCategoria.Click += btnCriarCategoria_Click;
            // 
            // btnEditarCategoria
            // 
            btnEditarCategoria.Location = new Point(246, 444);
            btnEditarCategoria.Name = "btnEditarCategoria";
            btnEditarCategoria.Size = new Size(119, 23);
            btnEditarCategoria.TabIndex = 20;
            btnEditarCategoria.Text = "Editar Categoria";
            btnEditarCategoria.UseVisualStyleBackColor = true;
            btnEditarCategoria.Click += btnEditarCategoria_Click;
            // 
            // btnRemoverCategoria
            // 
            btnRemoverCategoria.Location = new Point(246, 473);
            btnRemoverCategoria.Name = "btnRemoverCategoria";
            btnRemoverCategoria.Size = new Size(119, 23);
            btnRemoverCategoria.TabIndex = 21;
            btnRemoverCategoria.Text = "Remover Categoria";
            btnRemoverCategoria.UseVisualStyleBackColor = true;
            btnRemoverCategoria.Click += btnRemoverCategoria_Click;
            // 
            // btnConfirmarEdicao
            // 
            btnConfirmarEdicao.Location = new Point(216, 444);
            btnConfirmarEdicao.Name = "btnConfirmarEdicao";
            btnConfirmarEdicao.Size = new Size(183, 23);
            btnConfirmarEdicao.TabIndex = 22;
            btnConfirmarEdicao.Text = "Confirmar Edição Na Categoria";
            btnConfirmarEdicao.UseVisualStyleBackColor = true;
            btnConfirmarEdicao.Visible = false;
            btnConfirmarEdicao.Click += btnConfirmarEdicao_Click;
            // 
            // btnConfirmarRemocao
            // 
            btnConfirmarRemocao.Location = new Point(202, 473);
            btnConfirmarRemocao.Name = "btnConfirmarRemocao";
            btnConfirmarRemocao.Size = new Size(211, 23);
            btnConfirmarRemocao.TabIndex = 23;
            btnConfirmarRemocao.Text = "Confirmar Remoção da Categoria";
            btnConfirmarRemocao.UseVisualStyleBackColor = true;
            btnConfirmarRemocao.Visible = false;
            btnConfirmarRemocao.Click += btnConfirmarRemocao_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(419, 427);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(119, 40);
            btnCancelar.TabIndex = 24;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Visible = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // SubCategorias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(649, 496);
            Controls.Add(btnCancelar);
            Controls.Add(btnConfirmarRemocao);
            Controls.Add(btnConfirmarEdicao);
            Controls.Add(btnRemoverCategoria);
            Controls.Add(btnEditarCategoria);
            Controls.Add(btnCriarCategoria);
            Controls.Add(button1);
            Controls.Add(txtPesquisa);
            Controls.Add(txtUniqueID);
            Controls.Add(txtCategoriaCriar);
            Controls.Add(DataGridDB);
            Controls.Add(btnConfirmarCriarProduto);
            MaximizeBox = false;
            Name = "SubCategorias";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Categorias";
            Load += SubCriarCategorias_Load;
            ((System.ComponentModel.ISupportInitialize)DataGridDB).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConfirmarCriarProduto;
        private DataGridView DataGridDB;
        private TextBox txtCategoriaCriar;
        private TextBox txtUniqueID;
        private TextBox txtPesquisa;
        private Button button1;
        private Button btnCriarCategoria;
        private Button btnEditarCategoria;
        private Button btnRemoverCategoria;
        private Button btnConfirmarEdicao;
        private Button btnConfirmarRemocao;
        private Button btnCancelar;
    }
}