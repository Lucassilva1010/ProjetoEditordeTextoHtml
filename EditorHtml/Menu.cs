using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EditorHtml
{
    public class Menu
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;
            Tela();
            OpcaoTela();
           
            short opc  = short.Parse(Console.ReadLine());
            MenuOpc(opc);
        }

        public static void Tela()
        {
            Topo();
            Colunas();
            RodaPe();
        }
        public static void OpcaoTela()
        {
            Console.SetCursorPosition(3, 2);
            Console.WriteLine("Deus é Fiel!");
            Console.SetCursorPosition(3, 3);
            Console.WriteLine("====================");
            Console.SetCursorPosition(3, 4);
            Console.WriteLine("Escolha uma opção!");
            Console.SetCursorPosition(3, 6);
            Console.WriteLine("1 - Novo Arquivo");
            Console.SetCursorPosition(3, 7);
            Console.WriteLine("2 - Ler contéudo do Arquivo");
            Console.SetCursorPosition(3, 8);
            Console.WriteLine("0 - Sair");
            Console.SetCursorPosition(3, 10);
            Console.Write("Digite a opção Desejada: ");
        }
        public static void MenuOpc(short opc)
        { 
            switch (opc)
            {
                case 0:
                    Console.Clear();
                    Thread.Sleep(1000);
                    Console.SetCursorPosition(3, 11);
                    Console.Write("Finalizando");
                    Thread.Sleep(1000);
                    Console.Write(".");
                    Thread.Sleep(1000);
                    Console.Write(".");
                    Thread.Sleep(1000);
                    Console.WriteLine(".");
                    Environment.Exit(0);
                    break;
                    case 1:Editor.Tela02(); break;
                    case 2:Open.AbrirArquivo(); break;
                    default:Show(); break;
            }
        }


        #region "Estrutura da tela"
        static void Topo()
        {

            Console.Write("+");
            for (int i = 0; i <= 30; i++)
            {
                Console.Write("-");
            }
            Console.Write("+");
            Console.Write("\n");
        }
        static void Colunas()
        {
            for (int linha = 0; linha <= 10; linha++)
            {
                Console.Write("|");
                for (int j = 0; j <= 30; j++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("|");
            }
        }
        static void RodaPe()
        {
            Console.Write("+");
            for (int i = 0; i <= 30; i++)
            {
                Console.Write("-");
            }
            Console.Write("+");
            Console.Write("\n");
        }
        #endregion


    }
}
