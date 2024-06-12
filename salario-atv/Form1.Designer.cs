namespace salario_atv
{
    partial class Form1
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
            this.txtBoxSalario = new System.Windows.Forms.TextBox();
            this.txtBoxVenda = new System.Windows.Forms.TextBox();
            this.txtBoxComisao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Calcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBoxSalario
            // 
            this.txtBoxSalario.Location = new System.Drawing.Point(270, 115);
            this.txtBoxSalario.Name = "txtBoxSalario";
            this.txtBoxSalario.Size = new System.Drawing.Size(192, 20);
            this.txtBoxSalario.TabIndex = 0;
            // 
            // txtBoxVenda
            // 
            this.txtBoxVenda.Location = new System.Drawing.Point(270, 276);
            this.txtBoxVenda.Name = "txtBoxVenda";
            this.txtBoxVenda.Size = new System.Drawing.Size(192, 20);
            this.txtBoxVenda.TabIndex = 1;
            // 
            // txtBoxComisao
            // 
            this.txtBoxComisao.Location = new System.Drawing.Point(270, 197);
            this.txtBoxComisao.Name = "txtBoxComisao";
            this.txtBoxComisao.Size = new System.Drawing.Size(192, 20);
            this.txtBoxComisao.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(153, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "escreva sua Renda:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(153, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Valor de venda:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(159, 283);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sua comissão:";
            // 
            // btn_Calcular
            // 
            this.btn_Calcular.Location = new System.Drawing.Point(316, 159);
            this.btn_Calcular.Name = "btn_Calcular";
            this.btn_Calcular.Size = new System.Drawing.Size(100, 23);
            this.btn_Calcular.TabIndex = 6;
            this.btn_Calcular.Text = "Calcular";
            this.btn_Calcular.UseVisualStyleBackColor = true;
            this.btn_Calcular.Click += new System.EventHandler(this.btn_Calcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 437);
            this.Controls.Add(this.btn_Calcular);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxComisao);
            this.Controls.Add(this.txtBoxVenda);
            this.Controls.Add(this.txtBoxSalario);
            this.Name = "Form1";
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxSalario;
        private System.Windows.Forms.TextBox txtBoxVenda;
        private System.Windows.Forms.TextBox txtBoxComisao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Calcular;
    }
}

