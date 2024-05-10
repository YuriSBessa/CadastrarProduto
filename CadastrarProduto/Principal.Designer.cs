namespace CadastrarProduto
{
    partial class Principal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.cadastar = new System.Windows.Forms.Button();
            this.editar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.inputNome = new System.Windows.Forms.TextBox();
            this.inputDataInicial = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.deletar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.inputDataFinal = new System.Windows.Forms.DateTimePicker();
            this.usuarioCadastrado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cadastar
            // 
            this.cadastar.Location = new System.Drawing.Point(713, 12);
            this.cadastar.Name = "cadastar";
            this.cadastar.Size = new System.Drawing.Size(75, 23);
            this.cadastar.TabIndex = 0;
            this.cadastar.Text = "Cadastrar";
            this.cadastar.UseVisualStyleBackColor = true;
            this.cadastar.Click += new System.EventHandler(this.cadastar_Click);
            // 
            // editar
            // 
            this.editar.Location = new System.Drawing.Point(632, 12);
            this.editar.Name = "editar";
            this.editar.Size = new System.Drawing.Size(75, 23);
            this.editar.TabIndex = 1;
            this.editar.Text = "Editar";
            this.editar.UseVisualStyleBackColor = true;
            this.editar.Click += new System.EventHandler(this.editar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Produtos";
            // 
            // inputNome
            // 
            this.inputNome.Location = new System.Drawing.Point(12, 64);
            this.inputNome.Name = "inputNome";
            this.inputNome.Size = new System.Drawing.Size(227, 20);
            this.inputNome.TabIndex = 3;
            // 
            // inputDataInicial
            // 
            this.inputDataInicial.Location = new System.Drawing.Point(246, 64);
            this.inputDataInicial.Name = "inputDataInicial";
            this.inputDataInicial.Size = new System.Drawing.Size(228, 20);
            this.inputDataInicial.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(243, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Data Inicial";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 328);
            this.dataGridView1.TabIndex = 6;
            // 
            // deletar
            // 
            this.deletar.Location = new System.Drawing.Point(363, 424);
            this.deletar.Name = "deletar";
            this.deletar.Size = new System.Drawing.Size(75, 23);
            this.deletar.TabIndex = 7;
            this.deletar.Text = "Deletar";
            this.deletar.UseVisualStyleBackColor = true;
            this.deletar.Click += new System.EventHandler(this.deletar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(713, 62);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(477, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Data Final";
            // 
            // inputDataFinal
            // 
            this.inputDataFinal.Location = new System.Drawing.Point(480, 64);
            this.inputDataFinal.Name = "inputDataFinal";
            this.inputDataFinal.Size = new System.Drawing.Size(220, 20);
            this.inputDataFinal.TabIndex = 9;
            // 
            // usuarioCadastrado
            // 
            this.usuarioCadastrado.AutoSize = true;
            this.usuarioCadastrado.Location = new System.Drawing.Point(12, 12);
            this.usuarioCadastrado.Name = "usuarioCadastrado";
            this.usuarioCadastrado.Size = new System.Drawing.Size(35, 13);
            this.usuarioCadastrado.TabIndex = 11;
            this.usuarioCadastrado.Text = "label4";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.usuarioCadastrado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.inputDataFinal);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.deletar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inputDataInicial);
            this.Controls.Add(this.inputNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.editar);
            this.Controls.Add(this.cadastar);
            this.Name = "Principal";
            this.Text = "Principal";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cadastar;
        private System.Windows.Forms.Button editar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputNome;
        private System.Windows.Forms.DateTimePicker inputDataInicial;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button deletar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker inputDataFinal;
        private System.Windows.Forms.Label usuarioCadastrado;
    }
}

