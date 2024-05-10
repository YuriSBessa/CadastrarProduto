namespace CadastrarProduto
{
    partial class CadastroUsuario
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
            this.inputSenha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.inputNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cofirmarSenha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.enviar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inputSenha
            // 
            this.inputSenha.Location = new System.Drawing.Point(269, 177);
            this.inputSenha.Name = "inputSenha";
            this.inputSenha.Size = new System.Drawing.Size(261, 20);
            this.inputSenha.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(266, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Senha";
            // 
            // inputNome
            // 
            this.inputNome.Location = new System.Drawing.Point(269, 120);
            this.inputNome.Name = "inputNome";
            this.inputNome.Size = new System.Drawing.Size(261, 20);
            this.inputNome.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(266, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nome";
            // 
            // cofirmarSenha
            // 
            this.cofirmarSenha.Location = new System.Drawing.Point(271, 234);
            this.cofirmarSenha.Name = "cofirmarSenha";
            this.cofirmarSenha.Size = new System.Drawing.Size(261, 20);
            this.cofirmarSenha.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(268, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Confirmar Senha";
            // 
            // enviar
            // 
            this.enviar.Location = new System.Drawing.Point(359, 276);
            this.enviar.Name = "enviar";
            this.enviar.Size = new System.Drawing.Size(75, 23);
            this.enviar.TabIndex = 10;
            this.enviar.Text = "Enviar";
            this.enviar.UseVisualStyleBackColor = true;
            this.enviar.Click += new System.EventHandler(this.enviar_Click);
            // 
            // CadastroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.enviar);
            this.Controls.Add(this.cofirmarSenha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.inputSenha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inputNome);
            this.Controls.Add(this.label1);
            this.Name = "CadastroUsuario";
            this.Text = "CadastroUsuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputSenha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inputNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cofirmarSenha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button enviar;
    }
}