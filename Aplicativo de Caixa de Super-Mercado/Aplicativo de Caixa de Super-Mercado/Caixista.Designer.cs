namespace Aplicativo_de_Caixa_de_Super_Mercado
{
    partial class Caixista
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
            menuStrip1 = new MenuStrip();
            caixaToolStripMenuItem = new ToolStripMenuItem();
            logOutToolStripMenuItem = new ToolStripMenuItem();
            dataGridView1 = new DataGridView();
            txtIDAdicionar = new TextBox();
            lblPrecoProduto = new Label();
            lblNomeProduto = new Label();
            label1 = new Label();
            btnAdicionar = new Button();
            btnEnviarTabela = new Button();
            txtQuantidade = new TextBox();
            label2 = new Label();
            lblIDCX = new Label();
            label4 = new Label();
            lblValorTotal = new Label();
            label3 = new Label();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { caixaToolStripMenuItem, logOutToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1118, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // caixaToolStripMenuItem
            // 
            caixaToolStripMenuItem.Name = "caixaToolStripMenuItem";
            caixaToolStripMenuItem.Size = new Size(48, 20);
            caixaToolStripMenuItem.Text = "Caixa";
            // 
            // logOutToolStripMenuItem
            // 
            logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            logOutToolStripMenuItem.Size = new Size(59, 20);
            logOutToolStripMenuItem.Text = "LogOut";
            logOutToolStripMenuItem.Click += logOutToolStripMenuItem_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(537, 38);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(569, 339);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellEnter += dataGridView1_CellEnter;
            // 
            // txtIDAdicionar
            // 
            txtIDAdicionar.Location = new Point(537, 394);
            txtIDAdicionar.Name = "txtIDAdicionar";
            txtIDAdicionar.Size = new Size(483, 23);
            txtIDAdicionar.TabIndex = 2;
            // 
            // lblPrecoProduto
            // 
            lblPrecoProduto.AutoSize = true;
            lblPrecoProduto.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPrecoProduto.Location = new Point(1048, 443);
            lblPrecoProduto.Name = "lblPrecoProduto";
            lblPrecoProduto.Size = new Size(58, 32);
            lblPrecoProduto.TabIndex = 3;
            lblPrecoProduto.Text = "0.00";
            // 
            // lblNomeProduto
            // 
            lblNomeProduto.AutoSize = true;
            lblNomeProduto.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNomeProduto.Location = new Point(537, 443);
            lblNomeProduto.Name = "lblNomeProduto";
            lblNomeProduto.Size = new Size(464, 32);
            lblNomeProduto.TabIndex = 4;
            lblNomeProduto.Text = "---------------------------------------------";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(511, 398);
            label1.Name = "label1";
            label1.Size = new Size(21, 15);
            label1.TabIndex = 5;
            label1.Text = "ID:";
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(1031, 393);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(75, 23);
            btnAdicionar.TabIndex = 6;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnEnviarTabela
            // 
            btnEnviarTabela.Location = new Point(994, 423);
            btnEnviarTabela.Name = "btnEnviarTabela";
            btnEnviarTabela.Size = new Size(112, 23);
            btnEnviarTabela.TabIndex = 9;
            btnEnviarTabela.Text = "Terminar Compras";
            btnEnviarTabela.UseVisualStyleBackColor = true;
            btnEnviarTabela.Click += btnEnviarTabela_Click;
            // 
            // txtQuantidade
            // 
            txtQuantidade.Location = new Point(537, 423);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(55, 23);
            txtQuantidade.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(459, 426);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 11;
            label2.Text = "Quantidade:";
            // 
            // lblIDCX
            // 
            lblIDCX.AutoSize = true;
            lblIDCX.Location = new Point(1068, 24);
            lblIDCX.Name = "lblIDCX";
            lblIDCX.Size = new Size(12, 15);
            lblIDCX.TabIndex = 12;
            lblIDCX.Text = "*";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1041, 24);
            label4.Name = "label4";
            label4.Size = new Size(21, 15);
            label4.TabIndex = 13;
            label4.Text = "ID:";
            // 
            // lblValorTotal
            // 
            lblValorTotal.AutoSize = true;
            lblValorTotal.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblValorTotal.Location = new Point(1048, 485);
            lblValorTotal.Name = "lblValorTotal";
            lblValorTotal.Size = new Size(58, 32);
            lblValorTotal.TabIndex = 14;
            lblValorTotal.Text = "0.00";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(959, 499);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 15;
            label3.Text = "Valor Total";
            // 
            // Caixista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1118, 541);
            Controls.Add(label3);
            Controls.Add(lblValorTotal);
            Controls.Add(label4);
            Controls.Add(lblIDCX);
            Controls.Add(label2);
            Controls.Add(txtQuantidade);
            Controls.Add(btnEnviarTabela);
            Controls.Add(btnAdicionar);
            Controls.Add(label1);
            Controls.Add(lblNomeProduto);
            Controls.Add(lblPrecoProduto);
            Controls.Add(txtIDAdicionar);
            Controls.Add(dataGridView1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Caixista";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Caixista";
            Load += Caixista_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem caixaToolStripMenuItem;
        private ToolStripMenuItem logOutToolStripMenuItem;
        private DataGridView dataGridView1;
        private TextBox txtIDAdicionar;
        private Label lblPrecoProduto;
        private Label lblNomeProduto;
        private Label label1;
        private Button btnAdicionar;
        private Button btnEnviarTabela;
        private TextBox txtQuantidade;
        private Label label2;
        private Label label4;
        public Label lblIDCX;
        private Label lblValorTotal;
        private Label label3;
    }
}