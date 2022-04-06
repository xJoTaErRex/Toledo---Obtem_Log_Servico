using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Management;
using System.IO;
using System.Threading;

namespace ObtemLogForms
{
    public partial class Form1 : Form
    {
        #region Variaveis e Metodos

        string nomeArquivo;
        string servico = "TBR_SRV_OCR";
        string caminhoLogPadrao = @"C:\";
        string fonteDoEvento = "srvTBROCR";
        string caminhoLog;
        int segundos = 5;
        Thread t;

        /// <summary>
        /// Método habilita e desabilita campos do forms, de acordo com o botão pressionado
        /// </summary>
        /// <param name="valida"> Boleano que indica quais campos habilitar ou desabilitar </param>
        /// <returns>Sem retorno</returns>
        public void DesabilitaHabilitaCampos(bool valida)
        {
            if (valida)
            {
                if (ckbEventViewer.Checked == true)
                {
                    txtFonteErroEventViewer.Enabled = true;
                }
                ckbEventViewer.Enabled = true;
                nudTempoGravacao.Enabled = true;
                txtCaminhoArquivoLog.Enabled = true;
                txtServico.Enabled = true;
                btnConsultar.Enabled = true;
                btnParar.Enabled = false;

            }
            else
            {
                ckbEventViewer.Enabled = false;
                txtFonteErroEventViewer.Enabled = false;
                nudTempoGravacao.Enabled = false;
                txtCaminhoArquivoLog.Enabled = false;
                txtServico.Enabled = false;
                btnConsultar.Enabled = false;
                btnParar.Enabled = true;
            }
        }

        #endregion

        #region Forms
        public Form1()
        {
            InitializeComponent();
            //Helper.CompletaComboServicosAtivos(cbServicosAtivos);
            txtCaminhoArquivoLog.Text = caminhoLogPadrao;
            txtServico.Text = servico;
            txtFonteErroEventViewer.Text = fonteDoEvento;
            nudTempoGravacao.Text = segundos.ToString();
            btnParar.Enabled = false;

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {

            if (txtServico.Text != "")
            {
                epValidaServicoNull.Clear();
                DesabilitaHabilitaCampos(false);

                servico = txtServico.Text;
                if (servico.Contains(".exe"))  //caso o usuario digite .exe no final do nome do serviço, com .exe o serviço não é encontrado 
                {
                    servico = servico.Replace(".exe", null);
                }

                nomeArquivo = "Log" + servico;


                if (!string.IsNullOrEmpty(nudTempoGravacao.Text))
                {
                    segundos = Convert.ToInt32(nudTempoGravacao.Text);
                }

                if (!string.IsNullOrEmpty(txtFonteErroEventViewer.Text))
                {
                    fonteDoEvento = txtFonteErroEventViewer.Text;
                }

                if (!string.IsNullOrEmpty(txtCaminhoArquivoLog.Text) && txtCaminhoArquivoLog.Text != caminhoLogPadrao) //Verifica se o campo do caminho esta vazio e se o que ele possui é o caminho padrão
                {
                    if (txtCaminhoArquivoLog.Text.EndsWith(@"\")) //Verifica se o usuario colocou "\" no final do caminho, caso contrario adiciona
                    {
                        caminhoLog = txtCaminhoArquivoLog.Text + nomeArquivo;
                    }
                    else
                    {
                        caminhoLog = txtCaminhoArquivoLog.Text + @"\" + nomeArquivo;
                    }
                }
                else
                {
                    txtCaminhoArquivoLog.Text = caminhoLogPadrao;
                    caminhoLog = caminhoLogPadrao + nomeArquivo;
                }


                t = new Thread(() => LogServicos.EfetuaLeituraGravacaoLog(servico, caminhoLog, segundos, fonteDoEvento, ckbEventViewer));
                t.Start();

                pnStatus.BackColor = Color.Green;

                txtLog.Text = "OBTENDO LOG DO SERVIÇO: " + servico + Environment.NewLine + Environment.NewLine +
                               "O programa esta em execução, gravando os logs no arquivo txt, pare ou feche o programa, e abra o arquivo para verificar os resultados obtidos!";
                lblAvisoRodapé.Text = "O arquivo de log: " + nomeArquivo + "{Data atual}, foi salvo no caminho:   " + caminhoLog + "{Data atual}.txt";

            }
            else
            {
                epValidaServicoNull.SetError(txtServico, "Escreva o nome de um serviço");
            }

        }

        private void btnParar_Click(object sender, EventArgs e)
        {
            DesabilitaHabilitaCampos(true);

            pnStatus.BackColor = Color.Red;

            t.Abort();

            txtLog.Text = "O PROGRAMA ESTA PARADO" + Environment.NewLine + Environment.NewLine + "abra o arquivo .txt para verificar os resultados";
        }

        private void ckbEventViewer_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbEventViewer.Checked == false)
            {
                txtFonteErroEventViewer.Enabled = false;
            }
            else
            {
                txtFonteErroEventViewer.Enabled = true;
            }

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (t != null)
            {
                t.Abort();
            }
        }
    }

    #endregion

}
  
