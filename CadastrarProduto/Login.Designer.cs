namespace CadastrarProduto
{
    partial class Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.inputNome = new System.Windows.Forms.TextBox();
            this.inputSenha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.criarConta = new System.Windows.Forms.Button();
            this.enviar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(265, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // inputNome
            // 
            this.inputNome.Location = new System.Drawing.Point(268, 129);
            this.inputNome.Name = "inputNome";
            this.inputNome.Size = new System.Drawing.Size(261, 20);
            this.inputNome.TabIndex = 1;
            // 
            // inputSenha
            // 
            this.inputSenha.Location = new System.Drawing.Point(268, 186);
            this.inputSenha.Name = "inputSenha";
            this.inputSenha.Size = new System.Drawing.Size(261, 20);
            this.inputSenha.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(265, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Senha";
            // 
            // criarConta
            // 
            this.criarConta.Location = new System.Drawing.Point(315, 229);
            this.criarConta.Name = "criarConta";
            this.criarConta.Size = new System.Drawing.Size(154, 56);
            this.criarConta.TabIndex = 4;
            this.criarConta.Text = "Caso não possua uma conta crie uma";
            this.criarConta.UseVisualStyleBackColor = true;
            this.criarConta.Click += new System.EventHandler(this.criarConta_Click);
            // 
            // enviar
            // 
            this.enviar.Location = new System.Drawing.Point(356, 301);
            this.enviar.Name = "enviar";
            this.enviar.Size = new System.Drawing.Size(75, 23);
            this.enviar.TabIndex = 5;
            this.enviar.Text = "Enviar";
            this.enviar.UseVisualStyleBackColor = true;
            this.enviar.Click += new System.EventHandler(this.enviar_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.enviar);
            this.Controls.Add(this.criarConta);
            this.Controls.Add(this.inputSenha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inputNome);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputNome;
        private System.Windows.Forms.TextBox inputSenha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button criarConta;
        private System.Windows.Forms.Button enviar;
    }
}