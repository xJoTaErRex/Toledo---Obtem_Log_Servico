
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnConsultar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.txtCaminhoArquivoLog = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAvisoRodapé = new System.Windows.Forms.Label();
            this.btnParar = new System.Windows.Forms.Button();
            this.txtFonteErroEventViewer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtServico = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.epValidaServicoNull = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnStatus = new System.Windows.Forms.Panel();
            this.ckbEventViewer = new System.Windows.Forms.CheckBox();
            this.nudTempoGravacao = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.epValidaServicoNull)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTempoGravacao)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(614, 35);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(234, 57);
            this.btnConsultar.TabIndex = 0;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome do Serviço";
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(27, 262);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.Size = new System.Drawing.Size(565, 72);
            this.txtLog.TabIndex = 5;
            // 
            // txtCaminhoArquivoLog
            // 
            this.txtCaminhoArquivoLog.CausesValidation = false;
            this.txtCaminhoArquivoLog.Location = new System.Drawing.Point(336, 130);
            this.txtCaminhoArquivoLog.Name = "txtCaminhoArquivoLog";
            this.txtCaminhoArquivoLog.Size = new System.Drawing.Size(234, 20);
            this.txtCaminhoArquivoLog.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(333, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(222, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Caminho de salvamento do arquivo .txt de log";
            // 
            // lblAvisoRodapé
            // 
            this.lblAvisoRodapé.AutoSize = true;
            this.lblAvisoRodapé.ForeColor = System.Drawing.Color.Red;
            this.lblAvisoRodapé.Location = new System.Drawing.Point(24, 347);
            this.lblAvisoRodapé.Name = "lblAvisoRodapé";
            this.lblAvisoRodapé.Size = new System.Drawing.Size(0, 13);
            this.lblAvisoRodapé.TabIndex = 8;
            // 
            // btnParar
            // 
            this.btnParar.Location = new System.Drawing.Point(614, 159);
            this.btnParar.Name = "btnParar";
            this.btnParar.Size = new System.Drawing.Size(234, 57);
            this.btnParar.TabIndex = 10;
            this.btnParar.Text = "Parar";
            this.btnParar.UseVisualStyleBackColor = true;
            this.btnParar.Click += new System.EventHandler(this.btnParar_Click);
            // 
            // txtFonteErroEventViewer
            // 
            this.txtFonteErroEventViewer.CausesValidation = false;
            this.txtFonteErroEventViewer.Enabled = false;
            this.txtFonteErroEventViewer.Location = new System.Drawing.Point(336, 35);
            this.txtFonteErroEventViewer.Name = "txtFonteErroEventViewer";
            this.txtFonteErroEventViewer.Size = new System.Drawing.Size(234, 20);
            this.txtFonteErroEventViewer.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(333, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Nome da fonte do erro no Event Viewer";
            // 
            // txtServico
            // 
            this.txtServico.CausesValidation = false;
            this.txtServico.Location = new System.Drawing.Point(27, 35);
            this.txtServico.Name = "txtServico";
            this.txtServico.Size = new System.Drawing.Size(234, 20);
            this.txtServico.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(333, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Intervalo de gravação (segundos)";
            // 
            // epValidaServicoNull
            // 
            this.epValidaServicoNull.ContainerControl = this;
            // 
            // pnStatus
            // 
            this.pnStatus.Location = new System.Drawing.Point(614, 262);
            this.pnStatus.Name = "pnStatus";
            this.pnStatus.Size = new System.Drawing.Size(234, 72);
            this.pnStatus.TabIndex = 19;
            // 
            // ckbEventViewer
            // 
            this.ckbEventViewer.AutoSize = true;
            this.ckbEventViewer.Location = new System.Drawing.Point(336, 62);
            this.ckbEventViewer.Name = "ckbEventViewer";
            this.ckbEventViewer.Size = new System.Drawing.Size(208, 17);
            this.ckbEventViewer.TabIndex = 20;
            this.ckbEventViewer.Text = "Adicionar Log de erro do Event Viewer";
            this.ckbEventViewer.UseVisualStyleBackColor = true;
            this.ckbEventViewer.CheckedChanged += new System.EventHandler(this.ckbEventViewer_CheckedChanged);
            // 
            // nudTempoGravacao
            // 
            this.nudTempoGravacao.Location = new System.Drawing.Point(336, 196);
            this.nudTempoGravacao.Name = "nudTempoGravacao";
            this.nudTempoGravacao.Size = new System.Drawing.Size(120, 20);
            this.nudTempoGravacao.TabIndex = 21;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(27, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(234, 153);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Campos mostrados no arquivo de log ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 25);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(121, 13);
            this.label13.TabIndex = 15;
            this.label13.Text = "- Data e Hora da coleta ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 130);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(176, 13);
            this.label12.TabIndex = 14;
            this.label12.Text = "- Erros no Event Viewer * (Opcional)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 117);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = "- Tempo de CPU";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 104);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "- CPU";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 91);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(223, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "- Memória (conjunto de trabalho privado ativo)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "- Handles";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "- Threads";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "- Nome do Processo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "- PID";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 379);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.nudTempoGravacao);
            this.Controls.Add(this.ckbEventViewer);
            this.Controls.Add(this.pnStatus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtServico);
            this.Controls.Add(this.txtFonteErroEventViewer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnParar);
            this.Controls.Add(this.lblAvisoRodapé);
            this.Controls.Add(this.txtCaminhoArquivoLog);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnConsultar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Monitor de Serviços Especificos do Windows ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.epValidaServicoNull)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTempoGravacao)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.TextBox txtCaminhoArquivoLog;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblAvisoRodapé;
        private System.Windows.Forms.Button btnParar;
        private System.Windows.Forms.TextBox txtFonteErroEventViewer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtServico;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider epValidaServicoNull;
        private System.Windows.Forms.Panel pnStatus;
        private System.Windows.Forms.CheckBox ckbEventViewer;
        private System.Windows.Forms.NumericUpDown nudTempoGravacao;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}

