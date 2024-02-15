namespace Aplicativo_de_Caixa_de_Super_Mercado
{
    partial class SubContas
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
            txtIDFuncionario = new TextBox();
            btnCriarConta = new Button();
            lbl = new Label();
            label1 = new Label();
            label2 = new Label();
            boxCargoDoFuncionario = new ComboBox();
            boxAutoID = new CheckBox();
            txtNomeFuncionario = new TextBox();
            label3 = new Label();
            DataGridDB = new DataGridView();
            txtDataFuncionarioLogin = new TextBox();
            label4 = new Label();
            label5 = new Label();
            txtDataFuncionarioCriado = new TextBox();
            txtUniqueID = new TextBox();
            label6 = new Label();
            txtPesquisa = new TextBox();
            button1 = new Button();
            btnAlterarFuncionario = new Button();
            btnConfirmarCriarFuncionario = new Button();
            txtSenhaDoFuncionario = new MaskedTextBox();
            btnCancelar = new Button();
            btnConfirmarAlteracao = new Button();
            btnConfirmarDeletarRegistro = new Button();
            btnDeletarRegistro = new Button();
            ((System.ComponentModel.ISupportInitialize)DataGridDB).BeginInit();
            SuspendLayout();
            // 
            // txtIDFuncionario
            // 
            txtIDFuncionario.Location = new Point(149, 54);
            txtIDFuncionario.MaxLength = 32;
            txtIDFuncionario.Name = "txtIDFuncionario";
            txtIDFuncionario.ReadOnly = true;
            txtIDFuncionario.Size = new Size(111, 23);
            txtIDFuncionario.TabIndex = 0;
            // 
            // btnCriarConta
            // 
            btnCriarConta.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnCriarConta.Location = new Point(69, 250);
            btnCriarConta.Name = "btnCriarConta";
            btnCriarConta.Size = new Size(191, 23);
            btnCriarConta.TabIndex = 2;
            btnCriarConta.Text = "Criar Registro de um Funcionario";
            btnCriarConta.UseVisualStyleBackColor = true;
            btnCriarConta.Click += btnCriarConta_Click;
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Location = new Point(30, 57);
            lbl.Name = "lbl";
            lbl.Size = new Size(104, 15);
            lbl.TabIndex = 3;
            lbl.Text = "ID do Funcionario:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 115);
            label1.Name = "label1";
            label1.Size = new Size(125, 15);
            label1.TabIndex = 4;
            label1.Text = "Senha do Funcionario:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 144);
            label2.Name = "label2";
            label2.Size = new Size(125, 15);
            label2.TabIndex = 5;
            label2.Text = "Cargo do Funcionario:";
            // 
            // boxCargoDoFuncionario
            // 
            boxCargoDoFuncionario.Enabled = false;
            boxCargoDoFuncionario.FormattingEnabled = true;
            boxCargoDoFuncionario.Items.AddRange(new object[] { "Caixista", "Admin" });
            boxCargoDoFuncionario.Location = new Point(149, 141);
            boxCargoDoFuncionario.Name = "boxCargoDoFuncionario";
            boxCargoDoFuncionario.Size = new Size(111, 23);
            boxCargoDoFuncionario.TabIndex = 6;
            // 
            // boxAutoID
            // 
            boxAutoID.AutoSize = true;
            boxAutoID.Checked = true;
            boxAutoID.CheckState = CheckState.Checked;
            boxAutoID.Location = new Point(266, 56);
            boxAutoID.Name = "boxAutoID";
            boxAutoID.Size = new Size(66, 19);
            boxAutoID.TabIndex = 7;
            boxAutoID.Text = "Auto ID";
            boxAutoID.UseVisualStyleBackColor = true;
            boxAutoID.Visible = false;
            boxAutoID.CheckedChanged += boxAutoID_CheckedChanged;
            // 
            // txtNomeFuncionario
            // 
            txtNomeFuncionario.Location = new Point(149, 83);
            txtNomeFuncionario.MaxLength = 32;
            txtNomeFuncionario.Name = "txtNomeFuncionario";
            txtNomeFuncionario.ReadOnly = true;
            txtNomeFuncionario.Size = new Size(111, 23);
            txtNomeFuncionario.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 86);
            label3.Name = "label3";
            label3.Size = new Size(126, 15);
            label3.TabIndex = 9;
            label3.Text = "Nome do Funcionario:";
            // 
            // DataGridDB
            // 
            DataGridDB.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            DataGridDB.Location = new Point(347, 23);
            DataGridDB.Name = "DataGridDB";
            DataGridDB.Size = new Size(465, 341);
            DataGridDB.TabIndex = 10;
            DataGridDB.CellClick += DataGridDB_CellClick;
            DataGridDB.CellContentClick += DataGridDB_CellContentClick;
            DataGridDB.CellEnter += DataGridDB_CellEnter;
            // 
            // txtDataFuncionarioLogin
            // 
            txtDataFuncionarioLogin.Location = new Point(149, 170);
            txtDataFuncionarioLogin.MaxLength = 32;
            txtDataFuncionarioLogin.Name = "txtDataFuncionarioLogin";
            txtDataFuncionarioLogin.ReadOnly = true;
            txtDataFuncionarioLogin.Size = new Size(111, 23);
            txtDataFuncionarioLogin.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 173);
            label4.Name = "label4";
            label4.Size = new Size(106, 15);
            label4.TabIndex = 13;
            label4.Text = "Data Ultimo Login:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(-1, 202);
            label5.Name = "label5";
            label5.Size = new Size(138, 15);
            label5.TabIndex = 14;
            label5.Text = "Data Funcionario Criado:";
            // 
            // txtDataFuncionarioCriado
            // 
            txtDataFuncionarioCriado.Location = new Point(149, 199);
            txtDataFuncionarioCriado.MaxLength = 32;
            txtDataFuncionarioCriado.Name = "txtDataFuncionarioCriado";
            txtDataFuncionarioCriado.ReadOnly = true;
            txtDataFuncionarioCriado.Size = new Size(111, 23);
            txtDataFuncionarioCriado.TabIndex = 15;
            // 
            // txtUniqueID
            // 
            txtUniqueID.Location = new Point(149, 25);
            txtUniqueID.MaxLength = 32;
            txtUniqueID.Name = "txtUniqueID";
            txtUniqueID.ReadOnly = true;
            txtUniqueID.Size = new Size(111, 23);
            txtUniqueID.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(74, 28);
            label6.Name = "label6";
            label6.Size = new Size(59, 15);
            label6.TabIndex = 17;
            label6.Text = "UniqueID:";
            // 
            // txtPesquisa
            // 
            txtPesquisa.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            txtPesquisa.Location = new Point(361, 370);
            txtPesquisa.MaxLength = 32;
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.Size = new Size(335, 23);
            txtPesquisa.TabIndex = 18;
            txtPesquisa.PreviewKeyDown += txtPesquisa_PreviewKeyDown;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            button1.Location = new Point(712, 370);
            button1.Name = "button1";
            button1.Size = new Size(100, 23);
            button1.TabIndex = 19;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnAlterarFuncionario
            // 
            btnAlterarFuncionario.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAlterarFuncionario.Location = new Point(69, 279);
            btnAlterarFuncionario.Name = "btnAlterarFuncionario";
            btnAlterarFuncionario.Size = new Size(191, 23);
            btnAlterarFuncionario.TabIndex = 20;
            btnAlterarFuncionario.Text = "Alterar Registro do Funcionario";
            btnAlterarFuncionario.UseVisualStyleBackColor = true;
            btnAlterarFuncionario.Click += btnAlterarFuncionario_Click;
            // 
            // btnConfirmarCriarFuncionario
            // 
            btnConfirmarCriarFuncionario.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnConfirmarCriarFuncionario.Location = new Point(69, 250);
            btnConfirmarCriarFuncionario.Name = "btnConfirmarCriarFuncionario";
            btnConfirmarCriarFuncionario.Size = new Size(191, 23);
            btnConfirmarCriarFuncionario.TabIndex = 21;
            btnConfirmarCriarFuncionario.Text = "Confirmar Criação do Registro";
            btnConfirmarCriarFuncionario.UseVisualStyleBackColor = true;
            btnConfirmarCriarFuncionario.Visible = false;
            btnConfirmarCriarFuncionario.Click += btnConfirmarCriarFuncionario_Click;
            // 
            // txtSenhaDoFuncionario
            // 
            txtSenhaDoFuncionario.Location = new Point(149, 112);
            txtSenhaDoFuncionario.Name = "txtSenhaDoFuncionario";
            txtSenhaDoFuncionario.ReadOnly = true;
            txtSenhaDoFuncionario.Size = new Size(111, 23);
            txtSenhaDoFuncionario.TabIndex = 22;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnCancelar.Location = new Point(69, 337);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(191, 23);
            btnCancelar.TabIndex = 23;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Visible = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnConfirmarAlteracao
            // 
            btnConfirmarAlteracao.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnConfirmarAlteracao.Location = new Point(69, 279);
            btnConfirmarAlteracao.Name = "btnConfirmarAlteracao";
            btnConfirmarAlteracao.Size = new Size(191, 23);
            btnConfirmarAlteracao.TabIndex = 24;
            btnConfirmarAlteracao.Text = "Confirmar Alteração no Registro";
            btnConfirmarAlteracao.UseVisualStyleBackColor = true;
            btnConfirmarAlteracao.Visible = false;
            btnConfirmarAlteracao.Click += btnConfirmarAlteracao_Click;
            // 
            // btnConfirmarDeletarRegistro
            // 
            btnConfirmarDeletarRegistro.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnConfirmarDeletarRegistro.Location = new Point(69, 308);
            btnConfirmarDeletarRegistro.Name = "btnConfirmarDeletarRegistro";
            btnConfirmarDeletarRegistro.Size = new Size(191, 23);
            btnConfirmarDeletarRegistro.TabIndex = 25;
            btnConfirmarDeletarRegistro.Text = "Confirmar Remoção do Registro";
            btnConfirmarDeletarRegistro.UseVisualStyleBackColor = true;
            btnConfirmarDeletarRegistro.Visible = false;
            btnConfirmarDeletarRegistro.Click += btnDeletarRegistro_Click;
            // 
            // btnDeletarRegistro
            // 
            btnDeletarRegistro.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnDeletarRegistro.Location = new Point(69, 308);
            btnDeletarRegistro.Name = "btnDeletarRegistro";
            btnDeletarRegistro.Size = new Size(191, 23);
            btnDeletarRegistro.TabIndex = 26;
            btnDeletarRegistro.Text = "Deletar Registro";
            btnDeletarRegistro.UseVisualStyleBackColor = true;
            btnDeletarRegistro.Click += btnDeletarRegistro_Click_1;
            // 
            // SubContas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(824, 451);
            Controls.Add(btnDeletarRegistro);
            Controls.Add(btnConfirmarDeletarRegistro);
            Controls.Add(btnConfirmarAlteracao);
            Controls.Add(btnCancelar);
            Controls.Add(txtSenhaDoFuncionario);
            Controls.Add(btnConfirmarCriarFuncionario);
            Controls.Add(btnAlterarFuncionario);
            Controls.Add(button1);
            Controls.Add(txtPesquisa);
            Controls.Add(label6);
            Controls.Add(txtUniqueID);
            Controls.Add(txtDataFuncionarioCriado);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtDataFuncionarioLogin);
            Controls.Add(DataGridDB);
            Controls.Add(label3);
            Controls.Add(txtNomeFuncionario);
            Controls.Add(boxAutoID);
            Controls.Add(boxCargoDoFuncionario);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lbl);
            Controls.Add(btnCriarConta);
            Controls.Add(txtIDFuncionario);
            MaximizeBox = false;
            Name = "SubContas";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Contas";
            Load += SubCriarConta_Load;
            ((System.ComponentModel.ISupportInitialize)DataGridDB).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtIDFuncionario;
        private Button btnCriarConta;
        private Label lbl;
        private Label label1;
        private Label label2;
        private ComboBox boxCargoDoFuncionario;
        private CheckBox boxAutoID;
        private TextBox txtNomeFuncionario;
        private Label label3;
        private DataGridView DataGridDB;
        private TextBox txtDataFuncionarioLogin;
        private Label label4;
        private Label label5;
        private TextBox txtDataFuncionarioCriado;
        private TextBox txtUniqueID;
        private Label label6;
        private TextBox txtPesquisa;
        private Button button1;
        private Button btnAlterarFuncionario;
        private Button btnConfirmarCriarFuncionario;
        private MaskedTextBox txtSenhaDoFuncionario;
        private Button btnCancelar;
        private Button btnConfirmarAlteracao;
        private Button btnConfirmarDeletarRegistro;
        private Button btnDeletarRegistro;
    }
}