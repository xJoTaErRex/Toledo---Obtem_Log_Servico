using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObtemLogForms
{
    static class Program
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
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
