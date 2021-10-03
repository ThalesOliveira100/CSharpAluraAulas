using ByteBankImportacaoExportacao.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO; // IO = Input and Output

namespace ByteBankImportacaoExportacao 
{
    partial class Program
    {
        static void Main(string[] args)
        {
            File.WriteAllText("EscrevendoComAClasseFile.txt", "Testando file.WriteAllText");


            var bytesArquivo = File.ReadAllBytes("contas.txt");
            Console.WriteLine($"Arquivo contas.txt possui {bytesArquivo.Length} bytes.");

            var linhas = File.ReadAllLines("contas.txt");
            // Console.WriteLine(linhas.Length);

            foreach (var linha in linhas)
            {
                Console.WriteLine(linha);
            }


            Console.WriteLine("Digite o seu nome: ");
            var nome = Console.ReadLine();


            UsarStreamDeEntrada();

            Console.WriteLine("Aplicacao finalizada..");

            Console.ReadLine();
        }
    }    
} 
