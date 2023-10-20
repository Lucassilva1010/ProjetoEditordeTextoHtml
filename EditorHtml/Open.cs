using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EditorHtml
{
    public class Open
    {

        public static void AbrirArquivo()
        {
            Console.Clear();
            Console.WriteLine("Digite o caminho do arquivo");
            string path = Console.ReadLine();

            using (var arquivo = new StreamReader(path))
            {
                string text = arquivo.ReadToEnd();//ler todo o arquivo
                Console.WriteLine(text);
            }
            Console.WriteLine(" ");
            Console.ReadLine();
            Menu.Show();
        }
    }
}
