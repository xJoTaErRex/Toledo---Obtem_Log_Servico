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


        public Form1()
        {
            InitializeComponent();
            Helper.CompletaComboServicosAtivos(cbServicosAtivos);
            Helper.executa = true;
        }


        private void btnConsultar_Click(object sender, EventArgs e)
        {
            string servico = "LMPService";
            string nomeMaquina = "CE230";
            string caminhoLog = @"D:\dados.txt";
            string log;

            try
            {

                if (cbServicosAtivos.SelectedItem != null)
                {
                    servico = cbServicosAtivos.SelectedItem.ToString();
                }
                if (!string.IsNullOrEmpty(txtNomeMaquina.Text))
                {
                    nomeMaquina = txtNomeMaquina.Text;
                }
                if (!string.IsNullOrEmpty(txtCaminhoArquivoLog.Text))
                {
                    caminhoLog = txtCaminhoArquivoLog.Text;
                }

                Process[] processlist = Process.GetProcessesByName(servico);

                foreach (Process theprocess in Process.GetProcessesByName(servico))
                {
                    var counter = new PerformanceCounter("Process", "Working Set - Private", servico);
                    var cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
                    int usage = (int)cpuCounter.NextValue();

                    while (usage == 0 || usage > 100)
                    {
                        Thread.Sleep(250);
                        usage = (int)cpuCounter.NextValue();
                    }

                    log = DateTime.Now +
                            "Nome: ".PadLeft(25) + theprocess.ProcessName.ToString() +
                            "PID: ".PadLeft(25) + theprocess.Id.ToString() +
                            "Threads: ".PadLeft(25) + theprocess.Threads.Count +
                            "Handles: ".PadLeft(25) + theprocess.HandleCount +
                            "Memória (conjunto de trabalho privado ativo): ".PadLeft(50) + counter.RawValue / 1024 + "K" +
                            "CPU: ".PadLeft(25) + usage + "%".PadLeft(3) + " ".PadLeft(15) +
                            "Tempo de CPU: ".PadLeft(10) + theprocess.TotalProcessorTime.TotalSeconds.ToString("N2");

                    File.AppendAllText(caminhoLog, log);

                    string res = Environment.NewLine + Helper.GetEventLogData(DateTime.Today, nomeMaquina, log);
                    txtLog.Text += res;
                    lblAvisoHeadtxt.Text = "Obtendo log do serviço " + servico;
                    lblAvisoRodapé.Text = "O arquivo de log dados.txt foi salvo no caminho " + caminhoLog;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro inesperado, " + ex.Message, "Help Caption", MessageBoxButtons.OK,
                                   MessageBoxIcon.Error);
            } 

        }

        private void btnParar_Click(object sender, EventArgs e)
        {
            Helper.executa = false;
        }

        private void btnLimparCaixaDeTexto_Click(object sender, EventArgs e)
        {
            txtLog.Text = null;
        }
    }
}
  
