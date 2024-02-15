namespace Aplicativo_de_Caixa_de_Super_Mercado
{
    partial class Admin
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
            components = new System.ComponentModel.Container();
            contextMenuStrip1 = new ContextMenuStrip(components);
            menuStrip1 = new MenuStrip();
            toolStripMenuItem3 = new ToolStripMenuItem();
            verProdutos = new ToolStripMenuItem();
            toolStripMenuItem4 = new ToolStripMenuItem();
            recibosToolStripMenuItem = new ToolStripMenuItem();
            logOutToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            lblIDPOR = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem3, logOutToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.DropDownItems.AddRange(new ToolStripItem[] { verProdutos, toolStripMenuItem4, recibosToolStripMenuItem });
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(55, 20);
            toolStripMenuItem3.Text = "Admin";
            // 
            // verProdutos
            // 
            verProdutos.Name = "verProdutos";
            verProdutos.Size = new Size(142, 22);
            verProdutos.Text = "Produtos";
            verProdutos.Click += verProdutos_Click;
            // 
            // toolStripMenuItem4
            // 
            toolStripMenuItem4.Name = "toolStripMenuItem4";
            toolStripMenuItem4.Size = new Size(142, 22);
            toolStripMenuItem4.Text = "Funcionarios";
            toolStripMenuItem4.Click += novoFuncionarioToolStripMenuItem_Click;
            // 
            // recibosToolStripMenuItem
            // 
            recibosToolStripMenuItem.Name = "recibosToolStripMenuItem";
            recibosToolStripMenuItem.Size = new Size(142, 22);
            recibosToolStripMenuItem.Text = "Recibos";
            recibosToolStripMenuItem.Click += recibosToolStripMenuItem_Click;
            // 
            // logOutToolStripMenuItem
            // 
            logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            logOutToolStripMenuItem.Size = new Size(59, 20);
            logOutToolStripMenuItem.Text = "LogOut";
            logOutToolStripMenuItem.Click += logOutToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(725, 24);
            label1.Name = "label1";
            label1.Size = new Size(21, 15);
            label1.TabIndex = 2;
            label1.Text = "ID:";
            // 
            // lblIDPOR
            // 
            lblIDPOR.AutoSize = true;
            lblIDPOR.Location = new Point(765, 24);
            lblIDPOR.Name = "lblIDPOR";
            lblIDPOR.Size = new Size(12, 15);
            lblIDPOR.TabIndex = 3;
            lblIDPOR.Text = "*";
            lblIDPOR.Click += lblIDPOR_Click;
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblIDPOR);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            Name = "Admin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin";
            Load += Admin_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem logOutToolStripMenuItem;
        private ToolStripMenuItem produtosToolStripMenuItem;
        private Label label1;
        public Label lblIDPOR;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem toolStripMenuItem4;
        private ToolStripMenuItem recibosToolStripMenuItem;
        private ToolStripMenuItem verProdutos;
    }
}