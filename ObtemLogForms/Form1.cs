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
using System.IO;
using System.Threading;


namespace ObtemLogForms
{
    public partial class Form1 : Form
    {
        /*
             Programa desenvolvido para extrair informações de uma aplicação do sistema:
            
          
             INFORMAÇÕES do LOG:
            
                    "Nome"                                              -> Noma da aplicação
                    "PID"                                               -> Número de identificação da aplicação 
                    "Threads"                                           -> Quantidade de Threads
                    "Handles"                                           -> Quantidade de Handles
                    "Memória (conjunto de trabalho privado ativo)"      -> Valor de Memória  
                    "CPU"                                               -> Consumo de CPU em porcentagem
                    "Tempo de CPU                                       -> Tempo de esxeução da aplicação
            
            METODOS:
                GetEventLogData(DateTime.Today)                         -> Concatenar as informação se há ou não erro(s) na aplicação 

         */
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Método para copiar os logs de ERRO da Aplicação 
        /// no Event Viewer e inserir concatenado as informações de log 
        /// do serviço no arquivo txt "dados" e na stirng de retorno.
        /// </summary>
        /// <param name="start">
        /// Retorna uma string
        /// no Event Viewer rn</param>
        private static string GetEventLogData(DateTime start, string maquina, string retorno)
        {
            var log = new EventLog("Application", maquina);
            string sourceName = "srvTBROCR";
            string mensagem;

            log.Source = sourceName;
            int aux = 0;
            foreach (EventLogEntry entry in log.Entries)
            {
                if ((entry.EntryType == EventLogEntryType.Error) &&
                    (entry.TimeGenerated >= start) && entry.Source == log.Source)
                {
                    aux++;
                    Console.WriteLine("Error in Event Log:\n" + entry.Message + "\n");
                }

            }
            if (aux > 0)
            {
                mensagem = $"Há { aux} erros no Event Viewer. Verificar!";
                File.AppendAllText(@"D:\dados.txt", mensagem.PadLeft(50) + Environment.NewLine);
                retorno += " " +  mensagem;
            }
            else
            {
                mensagem = "Não há erros no Event Viewer!!!";
                File.AppendAllText(@"D:\dados.txt", mensagem.PadLeft(50) + Environment.NewLine);
                retorno += " " + mensagem;
            }

            return retorno;

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            string servico = "LMPService";
            string nomeMaquina = "CE230";
            string caminhoLog = @"D:\dados.txt";
            string log;

            try
            {

                if (txtNomeServico.Text != "")
                {
                    servico = txtNomeServico.Text;
                }
                if (txtNomeMaquina.Text != "")
                {
                    nomeMaquina = txtNomeMaquina.Text;
                }
                if (txtCaminhoArquivoLog.Text != "")
                {
                    caminhoLog = txtCaminhoArquivoLog.Text;
                }

                txtLog.Text += "Obtendo os Log's de " + servico + "...";

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

                    log =   DateTime.Now +
                            "Nome: ".PadLeft(25) + theprocess.ProcessName.ToString() +
                            "PID: ".PadLeft(25) + theprocess.Id.ToString() +
                            "Threads: ".PadLeft(25) + theprocess.Threads.Count +
                            "Handles: ".PadLeft(25) + theprocess.HandleCount +
                            "Memória (conjunto de trabalho privado ativo): ".PadLeft(50) + counter.RawValue / 1024 + "K" +
                            "CPU: ".PadLeft(25) + usage + "%".PadLeft(3) +
                            "Tempo de CPU: ".PadLeft(25) + theprocess.TotalProcessorTime.TotalSeconds.ToString("N2");

                    //C:\LogAplicacao\dados.txt -- Caminho original 
                    File.AppendAllText(caminhoLog, log); 

                    txtLog.Text += GetEventLogData(DateTime.Today, nomeMaquina, log);
                    lblAvisoRodapé.Text = "O arquivo de log dados.txt foi salvo no caminho " + caminhoLog;
                }

                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro inesperado, verifique se o serviço esta rodando, erro: " + ex.Message, "Help Caption", MessageBoxButtons.OK,
                                   MessageBoxIcon.Error);
            }

        }
    }
}
  
