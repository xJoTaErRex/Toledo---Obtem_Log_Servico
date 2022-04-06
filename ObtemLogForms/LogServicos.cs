using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using System.Management;
using System.IO;
using System.Threading;

namespace ObtemLogForms
{
    class LogServicos
    {

        /// <summary>
        /// Método para copiar os logs de ERRO da Aplicação 
        /// no Event Viewer e inserir concatenado as informações de log 
        /// do serviço na stirng de retorno.
        /// </summary>
        /// <param name="start"> Data de inicio </param>
        /// <param name="maquina"> Nome da Maquina utilizada</param>
        /// <param name="retorno"> String de log sem os dados do Event Viewer </param>
        /// <param name="fonte"> String com o nome da fonte dos erros no Event Viewer </param>
        /// <returns>Retorna a string de retorno com os dados do Event Viwer</returns>
        public static string RetornaLogEventViewer(DateTime start, string maquina, string retorno, string fonte)
        {
            var log = new EventLog("Application", maquina);
            //string sourceName = "srvTBROCR";
            string mensagem;
            log.Source = fonte; //sourceName;
            int aux = 0;

            foreach (EventLogEntry entry in log.Entries)
            {
                if ((entry.EntryType == EventLogEntryType.Error) &&
                    (entry.TimeGenerated >= start) && entry.Source == log.Source)
                {
                    aux++;
                }

            }
            if (aux > 0)
            {
                mensagem = " ".PadLeft(10) + $"Há { aux} erros no Event Viewer. Verificar!";
                retorno += " " + mensagem;
            }
            else
            {
                mensagem = " ".PadLeft(10)+ "Não há erros no Event Viewer!!!";
                retorno += mensagem;
            }

            return retorno;

        }


        /// <summary>
        /// Método lista os processos ativos e preenche uma combobox com a lista
        /// </summary>
        /// <param name="combo"> Combobox que será preenchida com a lista </param>
        /// <returns>Sem retorno</returns>
        public static void CompletaComboServicosAtivos(ComboBox combo)
        {
            ManagementClass management = new ManagementClass("Win32_Process");
            ManagementObjectCollection mCollection = management.GetInstances();
            foreach (ManagementObject process in mCollection)
            {
                string nomeProcesso = (string)process["Name"];
                combo.Items.Add(nomeProcesso.Replace(".exe", null));
            }

        }


        /// <summary>
        /// Método efetua a leitura a gravação dos logs do serviço escolhido
        /// </summary>
        /// <param name="servico"> Combobox que será preenchida com a lista </param>
        /// <param name="caminhoLog"> Combobox que será preenchida com a lista </param>
        /// <param name="segundos"> Combobox que será preenchida com a lista </param>
        /// <param name="fonteEvento"> Combobox que será preenchida com a lista </param>
        /// <param name="checkEventViewer"> Combobox que será preenchida com a lista </param>
        /// <returns>Sem retorno</returns>
        public static void EfetuaLeituraGravacaoLog(string servico, string caminhoLog, int segundos, string fonteEvento, CheckBox checkEventViewer)
        {
            string log = null;

            while (true)
            {
                try
                {
                    Process[] processlist = Process.GetProcessesByName(servico);

                    if (processlist.Length == 0)
                    {
                        throw new Exception("Serviço não encontrado");
                    }
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

                        log += Environment.NewLine + DateTime.Now +
                                "Nome: ".PadLeft(25) + theprocess.ProcessName.ToString() +
                                "PID: ".PadLeft(25) + theprocess.Id.ToString() +
                                "Threads: ".PadLeft(25) + theprocess.Threads.Count +
                                "Handles: ".PadLeft(25) + theprocess.HandleCount +
                                "Memória (conjunto de trabalho privado ativo): ".PadLeft(50) + counter.RawValue / 1024 + "K" +
                                "CPU: ".PadLeft(25) + usage + "%".PadLeft(3) + " ".PadLeft(15) +
                                "Tempo de CPU: ".PadLeft(10) + theprocess.TotalProcessorTime.TotalSeconds.ToString("N2");

                        if (checkEventViewer.Checked && fonteEvento != null)
                        {
                            string retorno = RetornaLogEventViewer(DateTime.Today, Environment.MachineName, log, fonteEvento);
                            log = retorno;
                        }

                        string caminhoComDataAtual = caminhoLog + DateTime.Now.ToString("ddMMyyyy") + ".txt";

                        File.AppendAllText(caminhoComDataAtual, log);
                        Thread.Sleep(segundos * 1000);

                    }
                }
                catch (ThreadAbortException ex)
                {

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }

            }

        }

    }
}
