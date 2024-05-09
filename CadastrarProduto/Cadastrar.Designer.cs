namespace CadastrarProduto
{
    partial class Cadastrar
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
            this.label2 = new System.Windows.Forms.Label();
            this.inputPreco = new System.Windows.Forms.TextBox();
            this.inputMarca = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.inputQuantidade = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.inputDataDeValidade = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.inputDescricao = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.inputQuantidade)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(272, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // inputNome
            // 
            this.inputNome.Location = new System.Drawing.Point(275, 25);
            this.inputNome.Name = "inputNome";
            this.inputNome.Size = new System.Drawing.Size(245, 20);
            this.inputNome.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(272, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Preço";
            // 
            // inputPreco
            // 
            this.inputPreco.Location = new System.Drawing.Point(275, 73);
            this.inputPreco.Name = "inputPreco";
            this.inputPreco.Size = new System.Drawing.Size(245, 20);
            this.inputPreco.TabIndex = 3;
            // 
            // inputMarca
            // 
            this.inputMarca.Location = new System.Drawing.Point(275, 120);
            this.inputMarca.Name = "inputMarca";
            this.inputMarca.Size = new System.Drawing.Size(245, 20);
            this.inputMarca.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(272, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Marca";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(272, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Quantidade";
            // 
            // inputQuantidade
            // 
            this.inputQuantidade.Location = new System.Drawing.Point(275, 164);
            this.inputQuantidade.Name = "inputQuantidade";
            this.inputQuantidade.Size = new System.Drawing.Size(59, 20);
            this.inputQuantidade.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(272, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Data de Validade";
            // 
            // inputDataDeValidade
            // 
            this.inputDataDeValidade.Location = new System.Drawing.Point(275, 216);
            this.inputDataDeValidade.Name = "inputDataDeValidade";
            this.inputDataDeValidade.Size = new System.Drawing.Size(245, 20);
            this.inputDataDeValidade.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(272, 248);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Descrição";
            // 
            // inputDescricao
            // 
            this.inputDescricao.Location = new System.Drawing.Point(275, 264);
            this.inputDescricao.Name = "inputDescricao";
            this.inputDescricao.Size = new System.Drawing.Size(245, 20);
            this.inputDescricao.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(275, 299);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Enviar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Cadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.inputDescricao);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.inputDataDeValidade);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.inputQuantidade);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.inputMarca);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.inputPreco);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inputNome);
            this.Controls.Add(this.label1);
            this.Name = "Cadastrar";
            this.Text = "Cadastrar";
            ((System.ComponentModel.ISupportInitialize)(this.inputQuantidade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inputPreco;
        private System.Windows.Forms.TextBox inputMarca;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown inputQuantidade;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker inputDataDeValidade;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox inputDescricao;
        private System.Windows.Forms.Button button1;
    }
}