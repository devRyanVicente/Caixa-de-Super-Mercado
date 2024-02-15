namespace Aplicativo_de_Caixa_de_Super_Mercado
{
    partial class LogIn
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnEntrar = new Button();
            txtIDEntrar = new TextBox();
            txtSenhaEntrar = new TextBox();
            lbl1241 = new Label();
            txtconexaoativaoudesativa = new Label();
            SuspendLayout();
            // 
            // btnEntrar
            // 
            btnEntrar.Location = new Point(42, 117);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(75, 23);
            btnEntrar.TabIndex = 0;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = true;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // txtIDEntrar
            // 
            txtIDEntrar.Location = new Point(31, 30);
            txtIDEntrar.Name = "txtIDEntrar";
            txtIDEntrar.Size = new Size(100, 23);
            txtIDEntrar.TabIndex = 1;
            // 
            // txtSenhaEntrar
            // 
            txtSenhaEntrar.Location = new Point(31, 75);
            txtSenhaEntrar.Name = "txtSenhaEntrar";
            txtSenhaEntrar.Size = new Size(100, 23);
            txtSenhaEntrar.TabIndex = 2;
            // 
            // lbl1241
            // 
            lbl1241.AutoSize = true;
            lbl1241.Location = new Point(2, 4);
            lbl1241.Name = "lbl1241";
            lbl1241.Size = new Size(64, 15);
            lbl1241.TabIndex = 3;
            lbl1241.Text = "Database : ";
            // 
            // txtconexaoativaoudesativa
            // 
            txtconexaoativaoudesativa.AutoSize = true;
            txtconexaoativaoudesativa.Location = new Point(64, 4);
            txtconexaoativaoudesativa.Name = "txtconexaoativaoudesativa";
            txtconexaoativaoudesativa.Size = new Size(62, 15);
            txtconexaoativaoudesativa.TabIndex = 4;
            txtconexaoativaoudesativa.Text = "Buscando!";
            // 
            // LogIn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(165, 178);
            Controls.Add(txtconexaoativaoudesativa);
            Controls.Add(lbl1241);
            Controls.Add(txtSenhaEntrar);
            Controls.Add(txtIDEntrar);
            Controls.Add(btnEntrar);
            Name = "LogIn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LogIn";
            Load += LogIn_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEntrar;
        private TextBox txtIDEntrar;
        private TextBox txtSenhaEntrar;
        private Label lbl1241;
        private Label txtconexaoativaoudesativa;
    }
}
