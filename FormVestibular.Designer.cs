namespace Exercicios_praticos_JoaoVitor
{
    partial class FormVestibular
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
            this.txtArrecadacao = new System.Windows.Forms.TextBox();
            this.txtAlimentacao = new System.Windows.Forms.TextBox();
            this.txtFiscais = new System.Windows.Forms.TextBox();
            this.lblArrecadacao = new System.Windows.Forms.Label();
            this.lblFiscais = new System.Windows.Forms.Label();
            this.lblAlimentacao = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtArrecadacao
            // 
            this.txtArrecadacao.Location = new System.Drawing.Point(340, 92);
            this.txtArrecadacao.Multiline = true;
            this.txtArrecadacao.Name = "txtArrecadacao";
            this.txtArrecadacao.Size = new System.Drawing.Size(100, 20);
            this.txtArrecadacao.TabIndex = 0;
           
            // 
            // txtAlimentacao
            // 
            this.txtAlimentacao.Location = new System.Drawing.Point(340, 176);
            this.txtAlimentacao.Multiline = true;
            this.txtAlimentacao.Name = "txtAlimentacao";
            this.txtAlimentacao.Size = new System.Drawing.Size(100, 20);
            this.txtAlimentacao.TabIndex = 1;
            // 
            // txtFiscais
            // 
            this.txtFiscais.Location = new System.Drawing.Point(340, 134);
            this.txtFiscais.Multiline = true;
            this.txtFiscais.Name = "txtFiscais";
            this.txtFiscais.Size = new System.Drawing.Size(100, 20);
            this.txtFiscais.TabIndex = 2;
            // 
            // lblArrecadacao
            // 
            this.lblArrecadacao.AutoSize = true;
            this.lblArrecadacao.Location = new System.Drawing.Point(116, 92);
            this.lblArrecadacao.Name = "lblArrecadacao";
            this.lblArrecadacao.Size = new System.Drawing.Size(89, 13);
            this.lblArrecadacao.TabIndex = 3;
            this.lblArrecadacao.Text = "Valor Arrecadado";
            // 
            // lblFiscais
            // 
            this.lblFiscais.AutoSize = true;
            this.lblFiscais.Location = new System.Drawing.Point(116, 141);
            this.lblFiscais.Name = "lblFiscais";
            this.lblFiscais.Size = new System.Drawing.Size(112, 13);
            this.lblFiscais.TabIndex = 4;
            this.lblFiscais.Text = "Quantidade de Fiscais";
            // 
            // lblAlimentacao
            // 
            this.lblAlimentacao.AutoSize = true;
            this.lblAlimentacao.Location = new System.Drawing.Point(116, 183);
            this.lblAlimentacao.Name = "lblAlimentacao";
            this.lblAlimentacao.Size = new System.Drawing.Size(92, 13);
            this.lblAlimentacao.TabIndex = 5;
            this.lblAlimentacao.Text = "Valor Alimentação";
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnCalcular.Location = new System.Drawing.Point(70, 19);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(103, 50);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnLimpar.Location = new System.Drawing.Point(197, 19);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(103, 50);
            this.btnLimpar.TabIndex = 7;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnVoltar.Location = new System.Drawing.Point(323, 19);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(103, 50);
            this.btnVoltar.TabIndex = 8;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.btnCalcular);
            this.groupBox1.Controls.Add(this.btnVoltar);
            this.groupBox1.Controls.Add(this.btnLimpar);
            this.groupBox1.Location = new System.Drawing.Point(143, 293);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(496, 100);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " ";
            // 
            // FormVestibular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblAlimentacao);
            this.Controls.Add(this.lblFiscais);
            this.Controls.Add(this.lblArrecadacao);
            this.Controls.Add(this.txtFiscais);
            this.Controls.Add(this.txtAlimentacao);
            this.Controls.Add(this.txtArrecadacao);
            this.Name = "FormVestibular";
            this.Text = "Gasto Vestibular";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtArrecadacao;
        private System.Windows.Forms.TextBox txtAlimentacao;
        private System.Windows.Forms.TextBox txtFiscais;
        private System.Windows.Forms.Label lblArrecadacao;
        private System.Windows.Forms.Label lblFiscais;
        private System.Windows.Forms.Label lblAlimentacao;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}