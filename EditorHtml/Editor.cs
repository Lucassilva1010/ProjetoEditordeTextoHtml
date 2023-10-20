using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EditorHtml
{
    public class Editor
    {

        public static void Tela02()
        {

            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("Modo de Visualização!");
            Console.WriteLine("-----------");
            Start();
        }

        public static void Start()
        {
            var file = new StringBuilder();
            do
            {
                file.Append(Console.ReadLine());
                file.Append(Environment.NewLine);
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
            Console.WriteLine("Deseja Salvar o Arquivo? ");
            string res = Console.ReadLine();
            if (res != "n".ToLower())
            {
                Salvar(file);
                
            }
            else
            {
                Environment.Exit(0);
            }
        }

        static void Salvar(StringBuilder text)
        {
            Console.Clear();
            Console.WriteLine("Digite o caminho para Salvar o Arquivo");
            var path = Console.ReadLine();

            using (var arquivo = new StreamWriter(path))
            {
                arquivo.Write(text);
            }
            Viewer.Tela03(text.ToString());
            Thread.Sleep(1500);
            Console.Write("Salvado");
            Thread.Sleep(100);
            Console.Write(".");
            Thread.Sleep(1000);
            Console.Write(".");
            Thread.Sleep(1200);
            Console.WriteLine(".");
            Menu.Show();
        }


    }
}
