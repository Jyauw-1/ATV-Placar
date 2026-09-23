namespace Exercicios_praticos_JoaoVitor
{
    partial class FormMenu
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
            this.btnCalculoVestibular = new System.Windows.Forms.Button();
            this.btnPlacarJogo = new System.Windows.Forms.Button();
            this.btnFinalizarSistema = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCalculoVestibular
            // 
            this.btnCalculoVestibular.Location = new System.Drawing.Point(258, 68);
            this.btnCalculoVestibular.Name = "btnCalculoVestibular";
            this.btnCalculoVestibular.Size = new System.Drawing.Size(272, 73);
            this.btnCalculoVestibular.TabIndex = 0;
            this.btnCalculoVestibular.Text = "Calculo Vestibular";
            this.btnCalculoVestibular.UseVisualStyleBackColor = true;
            this.btnCalculoVestibular.Click += new System.EventHandler(this.btnCalculoVestibular_Click);
            // 
            // btnPlacarJogo
            // 
            this.btnPlacarJogo.Location = new System.Drawing.Point(258, 176);
            this.btnPlacarJogo.Name = "btnPlacarJogo";
            this.btnPlacarJogo.Size = new System.Drawing.Size(272, 73);
            this.btnPlacarJogo.TabIndex = 1;
            this.btnPlacarJogo.Text = "Placar Jogo";
            this.btnPlacarJogo.UseVisualStyleBackColor = true;
            this.btnPlacarJogo.Click += new System.EventHandler(this.btnPlacarJogo_Click);
            // 
            // btnFinalizarSistema
            // 
            this.btnFinalizarSistema.Location = new System.Drawing.Point(258, 291);
            this.btnFinalizarSistema.Name = "btnFinalizarSistema";
            this.btnFinalizarSistema.Size = new System.Drawing.Size(272, 73);
            this.btnFinalizarSistema.TabIndex = 2;
            this.btnFinalizarSistema.Text = "Finalizar Sistema";
            this.btnFinalizarSistema.UseVisualStyleBackColor = true;
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFinalizarSistema);
            this.Controls.Add(this.btnPlacarJogo);
            this.Controls.Add(this.btnCalculoVestibular);
            this.Name = "FormMenu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCalculoVestibular;
        private System.Windows.Forms.Button btnPlacarJogo;
        private System.Windows.Forms.Button btnFinalizarSistema;
    }
}

