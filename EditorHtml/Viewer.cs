using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EditorHtml
{
    public class Viewer
    {
        public static void Tela03(string text)
        {

            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("Modo Editor!");
            Console.WriteLine("-----------");
            Replace(text);
            Console.WriteLine("-----------");
            Console.ReadKey();
            Menu.Show();

        }

        private static void Replace(string text)
        {
            var strong = new Regex($@"<\s*strong[^>]*>(.*?)<\s*/\s*strong>");
            Console.WriteLine(strong.ToString());
            var palavras = text.Split(' ');

            for (int i = 0; i < palavras.Length; i++)
            {
                if (strong.IsMatch(palavras[i]))
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(
                        palavras[i].Substring(
                            palavras[i].IndexOf('>') + 1,
                            (
                                (palavras[i].LastIndexOf('<') - 1) -
                                    palavras[i].IndexOf('>')
                            )
                        )
                    );
                    Console.Write(" ");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(palavras[i]);
                    Console.Write(" ");
                }

            }

        }
    }
}
