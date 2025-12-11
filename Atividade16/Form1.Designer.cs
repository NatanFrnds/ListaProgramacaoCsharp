namespace Atividade16
{
    partial class Form1
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
            label1 = new Label();
            cmbOpcoes = new ComboBox();
            btnConfirmar = new Button();
            txtValor = new TextBox();
            lblMensagem = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(241, 88);
            label1.Name = "label1";
            label1.Size = new Size(113, 15);
            label1.TabIndex = 0;
            label1.Text = "Escolha uma opção:";
            // 
            // cmbOpcoes
            // 
            cmbOpcoes.FormattingEnabled = true;
            cmbOpcoes.Items.AddRange(new object[] { "Sacar", "Depositar", "Consultar Saldo", "Sair" });
            cmbOpcoes.Location = new Point(241, 129);
            cmbOpcoes.Name = "cmbOpcoes";
            cmbOpcoes.Size = new Size(121, 23);
            cmbOpcoes.TabIndex = 1;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(241, 177);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(75, 23);
            btnConfirmar.TabIndex = 2;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // txtValor
            // 
            txtValor.Location = new Point(377, 129);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(100, 23);
            txtValor.TabIndex = 3;
            // 
            // lblMensagem
            // 
            lblMensagem.AutoSize = true;
            lblMensagem.Location = new Point(250, 236);
            lblMensagem.Name = "lblMensagem";
            lblMensagem.Size = new Size(10, 15);
            lblMensagem.TabIndex = 4;
            lblMensagem.Text = ".";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblMensagem);
            Controls.Add(txtValor);
            Controls.Add(btnConfirmar);
            Controls.Add(cmbOpcoes);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbOpcoes;
        private Button btnConfirmar;
        private TextBox txtValor;
        private Label lblMensagem;
    }
}
