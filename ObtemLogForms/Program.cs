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
                    "Tempo de CPU"                                      -> Tempo de esxeução da aplicação
            
              METODOS:

                EfetuaLeituraGravacaoLog(DateTime.Today)                -> Concatenar as informação se há ou não erro(s) da aplicação no Event Viewer.
                CompletaComboServicosAtivos                             -> Monta uma combobox com os serviços ativos na maquina.
                EfetuaLeituraGravacaoLog                                -> Metodo principal que efetua leitura dos log e gravação no arquivo txt.
                DesabilitaHabilitaCampos                                -> Desabilita botões e campos de acordo com botão apertado.

                Desenvolvido por Junior Freitas e Michell Seidl

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
