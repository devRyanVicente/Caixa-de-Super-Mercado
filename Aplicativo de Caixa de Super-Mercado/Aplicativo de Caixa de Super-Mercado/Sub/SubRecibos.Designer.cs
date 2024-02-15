namespace Aplicativo_de_Caixa_de_Super_Mercado
{
    partial class SubRecibos
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
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtValorVenda = new TextBox();
            txtIDFuncionario = new TextBox();
            txtUniqueID = new TextBox();
            txtDataCriado = new TextBox();
            txtUtilizadoRecibo = new TextBox();
            btnDevolucao = new Button();
            btnConfirmarDevolucao = new Button();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(776, 336);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellEnter += dataGridView1_CellEnter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(68, 355);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 1;
            label1.Text = "UniqueID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 386);
            label2.Name = "label2";
            label2.Size = new Size(93, 15);
            label2.TabIndex = 2;
            label2.Text = "ValorVendaTotal:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 416);
            label3.Name = "label3";
            label3.Size = new Size(120, 15);
            label3.TabIndex = 3;
            label3.Text = "IDFuncionarioRecibo:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(284, 357);
            label4.Name = "label4";
            label4.Size = new Size(105, 15);
            label4.TabIndex = 4;
            label4.Text = "DataCriadoRecibo:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(273, 386);
            label5.Name = "label5";
            label5.Size = new Size(116, 15);
            label5.TabIndex = 5;
            label5.Text = "DataUtilizadoRecibo:";
            // 
            // txtValorVenda
            // 
            txtValorVenda.Location = new Point(130, 383);
            txtValorVenda.Name = "txtValorVenda";
            txtValorVenda.ReadOnly = true;
            txtValorVenda.Size = new Size(137, 23);
            txtValorVenda.TabIndex = 6;
            // 
            // txtIDFuncionario
            // 
            txtIDFuncionario.Location = new Point(130, 413);
            txtIDFuncionario.Name = "txtIDFuncionario";
            txtIDFuncionario.ReadOnly = true;
            txtIDFuncionario.Size = new Size(137, 23);
            txtIDFuncionario.TabIndex = 7;
            // 
            // txtUniqueID
            // 
            txtUniqueID.Location = new Point(130, 354);
            txtUniqueID.Name = "txtUniqueID";
            txtUniqueID.ReadOnly = true;
            txtUniqueID.Size = new Size(137, 23);
            txtUniqueID.TabIndex = 8;
            // 
            // txtDataCriado
            // 
            txtDataCriado.Location = new Point(392, 354);
            txtDataCriado.Name = "txtDataCriado";
            txtDataCriado.ReadOnly = true;
            txtDataCriado.Size = new Size(126, 23);
            txtDataCriado.TabIndex = 9;
            // 
            // txtUtilizadoRecibo
            // 
            txtUtilizadoRecibo.Location = new Point(392, 383);
            txtUtilizadoRecibo.Name = "txtUtilizadoRecibo";
            txtUtilizadoRecibo.ReadOnly = true;
            txtUtilizadoRecibo.Size = new Size(126, 23);
            txtUtilizadoRecibo.TabIndex = 10;
            // 
            // btnDevolucao
            // 
            btnDevolucao.Location = new Point(524, 382);
            btnDevolucao.Name = "btnDevolucao";
            btnDevolucao.Size = new Size(131, 23);
            btnDevolucao.TabIndex = 11;
            btnDevolucao.Text = "Devolução";
            btnDevolucao.UseVisualStyleBackColor = true;
            btnDevolucao.Click += btnDevolução_Click;
            // 
            // btnConfirmarDevolucao
            // 
            btnConfirmarDevolucao.Location = new Point(524, 408);
            btnConfirmarDevolucao.Name = "btnConfirmarDevolucao";
            btnConfirmarDevolucao.Size = new Size(131, 23);
            btnConfirmarDevolucao.TabIndex = 12;
            btnConfirmarDevolucao.Text = "Confirmar Devolução";
            btnConfirmarDevolucao.UseVisualStyleBackColor = true;
            btnConfirmarDevolucao.Visible = false;
            btnConfirmarDevolucao.Click += btnConfirmarDevolucao_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(657, 382);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(76, 23);
            btnCancelar.TabIndex = 13;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Visible = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // SubRecibos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancelar);
            Controls.Add(btnConfirmarDevolucao);
            Controls.Add(btnDevolucao);
            Controls.Add(txtUtilizadoRecibo);
            Controls.Add(txtDataCriado);
            Controls.Add(txtUniqueID);
            Controls.Add(txtIDFuncionario);
            Controls.Add(txtValorVenda);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "SubRecibos";
            StartPosition = FormStartPosition.CenterParent;
            Text = "SubRecibos";
            Load += SubRecibos_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtValorVenda;
        private TextBox txtIDFuncionario;
        private TextBox txtUniqueID;
        private TextBox txtDataCriado;
        private TextBox txtUtilizadoRecibo;
        private Button btnDevolucao;
        private Button btnConfirmarDevolucao;
        private Button btnCancelar;
    }
}