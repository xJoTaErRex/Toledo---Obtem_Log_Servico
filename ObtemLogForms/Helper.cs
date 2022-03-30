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
    class Helper
    {
        public static bool executa; 


        /// <summary>
        /// Método para copiar os logs de ERRO da Aplicação 
        /// no Event Viewer e inserir concatenado as informações de log 
        /// do serviço no arquivo txt "dados" e na stirng de retorno.
        /// </summary>
        /// <param name="start"> Data de inicio </param>
        /// <param name="maquina"> Nome da Maquina utilizada</param>
        /// <param name="retorno"> String de log sem os dados do Event Viewer </param>
        /// <returns>Retorna a string de retorno com os dados do Event Viwer</returns>
        public static string GetEventLogData(DateTime start, string maquina, string retorno)
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
                mensagem = " ".PadLeft(10) + $"Há { aux} erros no Event Viewer. Verificar!";
                File.AppendAllText(@"D:\dados.txt", mensagem.PadLeft(50) + Environment.NewLine);
                retorno += " " + mensagem;
            }
            else
            {
                mensagem = " ".PadLeft(10)+ "Não há erros no Event Viewer!!!";
                File.AppendAllText(@"D:\dados.txt", mensagem.PadLeft(50) + Environment.NewLine);
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

        public static void teste(TextBox teste, string texto)
        {
            teste.Text = texto;

        }

    }
}
