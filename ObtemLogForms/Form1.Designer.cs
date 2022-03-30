
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
            this.txtLog = new System.Windows.Forms.TextBox();
            this.txtCaminhoArquivoLog = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAvisoRodapé = new System.Windows.Forms.Label();
            this.cbServicosAtivos = new System.Windows.Forms.ComboBox();
            this.txtNomeMaquina = new System.Windows.Forms.TextBox();
            this.btnParar = new System.Windows.Forms.Button();
            this.btnLimparCaixaDeTexto = new System.Windows.Forms.Button();
            this.lblAvisoHeadtxt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(881, 35);
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
            this.label1.Location = new System.Drawing.Point(570, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome da Maquina";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(244, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome do Serviço";
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(15, 212);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(1343, 404);
            this.txtLog.TabIndex = 5;
            // 
            // txtCaminhoArquivoLog
            // 
            this.txtCaminhoArquivoLog.CausesValidation = false;
            this.txtCaminhoArquivoLog.Location = new System.Drawing.Point(247, 118);
            this.txtCaminhoArquivoLog.Name = "txtCaminhoArquivoLog";
            this.txtCaminhoArquivoLog.Size = new System.Drawing.Size(234, 20);
            this.txtCaminhoArquivoLog.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(244, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(227, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Caminho de salvamento do arquivo .txt de logs";
            // 
            // lblAvisoRodapé
            // 
            this.lblAvisoRodapé.AutoSize = true;
            this.lblAvisoRodapé.ForeColor = System.Drawing.Color.Red;
            this.lblAvisoRodapé.Location = new System.Drawing.Point(12, 655);
            this.lblAvisoRodapé.Name = "lblAvisoRodapé";
            this.lblAvisoRodapé.Size = new System.Drawing.Size(0, 13);
            this.lblAvisoRodapé.TabIndex = 8;
            // 
            // cbServicosAtivos
            // 
            this.cbServicosAtivos.FormattingEnabled = true;
            this.cbServicosAtivos.Location = new System.Drawing.Point(247, 35);
            this.cbServicosAtivos.Name = "cbServicosAtivos";
            this.cbServicosAtivos.Size = new System.Drawing.Size(234, 21);
            this.cbServicosAtivos.Sorted = true;
            this.cbServicosAtivos.TabIndex = 9;
            // 
            // txtNomeMaquina
            // 
            this.txtNomeMaquina.CausesValidation = false;
            this.txtNomeMaquina.Location = new System.Drawing.Point(573, 36);
            this.txtNomeMaquina.Name = "txtNomeMaquina";
            this.txtNomeMaquina.Size = new System.Drawing.Size(234, 20);
            this.txtNomeMaquina.TabIndex = 3;
            // 
            // btnParar
            // 
            this.btnParar.Location = new System.Drawing.Point(881, 118);
            this.btnParar.Name = "btnParar";
            this.btnParar.Size = new System.Drawing.Size(234, 57);
            this.btnParar.TabIndex = 10;
            this.btnParar.Text = "Parar";
            this.btnParar.UseVisualStyleBackColor = true;
            this.btnParar.Click += new System.EventHandler(this.btnParar_Click);
            // 
            // btnLimparCaixaDeTexto
            // 
            this.btnLimparCaixaDeTexto.Location = new System.Drawing.Point(1124, 633);
            this.btnLimparCaixaDeTexto.Name = "btnLimparCaixaDeTexto";
            this.btnLimparCaixaDeTexto.Size = new System.Drawing.Size(234, 57);
            this.btnLimparCaixaDeTexto.TabIndex = 11;
            this.btnLimparCaixaDeTexto.Text = "Limpar Log";
            this.btnLimparCaixaDeTexto.UseVisualStyleBackColor = true;
            this.btnLimparCaixaDeTexto.Click += new System.EventHandler(this.btnLimparCaixaDeTexto_Click);
            // 
            // lblAvisoHeadtxt
            // 
            this.lblAvisoHeadtxt.AutoSize = true;
            this.lblAvisoHeadtxt.Location = new System.Drawing.Point(12, 187);
            this.lblAvisoHeadtxt.Name = "lblAvisoHeadtxt";
            this.lblAvisoHeadtxt.Size = new System.Drawing.Size(0, 13);
            this.lblAvisoHeadtxt.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 702);
            this.Controls.Add(this.lblAvisoHeadtxt);
            this.Controls.Add(this.btnLimparCaixaDeTexto);
            this.Controls.Add(this.btnParar);
            this.Controls.Add(this.cbServicosAtivos);
            this.Controls.Add(this.lblAvisoRodapé);
            this.Controls.Add(this.txtCaminhoArquivoLog);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.txtNomeMaquina);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConsultar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Monitor de Serviço";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.TextBox txtCaminhoArquivoLog;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblAvisoRodapé;
        private System.Windows.Forms.ComboBox cbServicosAtivos;
        private System.Windows.Forms.TextBox txtNomeMaquina;
        private System.Windows.Forms.Button btnParar;
        private System.Windows.Forms.Button btnLimparCaixaDeTexto;
        private System.Windows.Forms.Label lblAvisoHeadtxt;
    }
}

