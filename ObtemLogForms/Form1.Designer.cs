
namespace ObtemLogForms
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
            this.btnConsultar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomeMaquina = new System.Windows.Forms.TextBox();
            this.txtNomeServico = new System.Windows.Forms.TextBox();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.txtCaminhoArquivoLog = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAvisoRodapé = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(282, 161);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(234, 57);
            this.btnConsultar.TabIndex = 0;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome da Maquina";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(472, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome do Serviço";
            // 
            // txtNomeMaquina
            // 
            this.txtNomeMaquina.Location = new System.Drawing.Point(126, 36);
            this.txtNomeMaquina.Name = "txtNomeMaquina";
            this.txtNomeMaquina.Size = new System.Drawing.Size(234, 20);
            this.txtNomeMaquina.TabIndex = 3;
            // 
            // txtNomeServico
            // 
            this.txtNomeServico.Location = new System.Drawing.Point(475, 36);
            this.txtNomeServico.Name = "txtNomeServico";
            this.txtNomeServico.Size = new System.Drawing.Size(234, 20);
            this.txtNomeServico.TabIndex = 4;
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(12, 243);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(776, 195);
            this.txtLog.TabIndex = 5;
            // 
            // txtCaminhoArquivoLog
            // 
            this.txtCaminhoArquivoLog.Location = new System.Drawing.Point(126, 101);
            this.txtCaminhoArquivoLog.Name = "txtCaminhoArquivoLog";
            this.txtCaminhoArquivoLog.Size = new System.Drawing.Size(234, 20);
            this.txtCaminhoArquivoLog.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(123, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Caminho Arquivo";
            // 
            // lblAvisoRodapé
            // 
            this.lblAvisoRodapé.AutoSize = true;
            this.lblAvisoRodapé.ForeColor = System.Drawing.Color.Red;
            this.lblAvisoRodapé.Location = new System.Drawing.Point(13, 445);
            this.lblAvisoRodapé.Name = "lblAvisoRodapé";
            this.lblAvisoRodapé.Size = new System.Drawing.Size(0, 13);
            this.lblAvisoRodapé.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 508);
            this.Controls.Add(this.lblAvisoRodapé);
            this.Controls.Add(this.txtCaminhoArquivoLog);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.txtNomeServico);
            this.Controls.Add(this.txtNomeMaquina);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConsultar);
            this.Name = "Form1";
            this.Text = "Monitor de Serviço";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNomeMaquina;
        private System.Windows.Forms.TextBox txtNomeServico;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.TextBox txtCaminhoArquivoLog;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblAvisoRodapé;
    }
}

