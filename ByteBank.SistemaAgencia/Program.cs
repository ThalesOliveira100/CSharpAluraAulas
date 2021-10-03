using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;
using System.Text.RegularExpressions;
using ByteBank.SistemaAgencia.Extensoes;
using ByteBank.SistemaAgencia.Comparadores;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            var contas = new List<ContaCorrente>()
            {
                new ContaCorrente(341, 1),
                new ContaCorrente(342, 999),
                null,
                new ContaCorrente(341, 57480),
                new ContaCorrente(342, 45678),
                new ContaCorrente(340, 48950),
                null,
                null,
                new ContaCorrente(290, 18950)
            };
            // contas.Sort(); Chamar a implementacao dada em ICOmparable
            // contas.Sort(new ComparadorContaCorrentePorAgencia());


           var contasOrdenada = contas
                .Where(conta => conta != null)
                .OrderBy(conta => conta.Numero);

            foreach (var conta in contasOrdenada)
            {
                Console.WriteLine($"Conta numero {conta.Numero}, ag. {conta.Agencia}");
            }

            Console.ReadLine();
        }

        static void TestaSort()
        {
            var nomes = new List<string>()
            {
                "Guilherme",
                "Luana",
                "Ana",
                "Wesley",
                "Thales"
            };
            nomes.Sort();

            foreach (var nome in nomes)
            {
                Console.WriteLine(nome);
            }


            var idades = new List<int>();

            idades.Add(1);
            idades.Add(5);
            idades.Add(14);
            idades.Add(25);
            idades.Add(38);
            idades.Add(61);
            idades.AdicionarVarios(99, -1);
            idades.Sort();

            for (int i = 0; i < idades.Count; i++)
            {
                Console.WriteLine(idades[i]);
            }
        }

        static void TestaListaDeObject()
        {
            ListaDeObject listaDeIdades = new ListaDeObject();

            listaDeIdades.Adicionar(10);
            listaDeIdades.Adicionar(5);
            listaDeIdades.Adicionar(4);
            listaDeIdades.AdicionarVarios(16, 23, 60);

            for (int i = 0; i < listaDeIdades.Tamanho; i++)
            {
                int idade = (int)listaDeIdades[i];
                Console.WriteLine($"Idade no indice {i}: {idade}");
            }

        }

        static void TestaListaDeContaCorrente()
        {
            ListaDeContaCorrente lista = new ListaDeContaCorrente();

            ContaCorrente contaDoThales = new ContaCorrente(111, 1111111);

            ContaCorrente[] contas = new ContaCorrente[]
            {
                contaDoThales,
                new ContaCorrente(874, 5679787),
                new ContaCorrente(874, 5679754),
            };

            lista.AdicionarVarios(contas);

            lista.AdicionarVarios(
                contaDoThales,
                new ContaCorrente(789, 7897894),
                new ContaCorrente(879, 3478392)
                );

            for (int i = 0; i < lista.Tamanho; i++)
            {
                ContaCorrente itemAtual = lista.GetItemNoIndice(i);
                Console.WriteLine($"Item na posicao {i} = Conta {itemAtual.Numero}/{itemAtual.Agencia}");
            }
        }

        static int SomarVarios(params int[] numeros)
        {
            int acumulador = 0;
            foreach(int numero in numeros)
            {
                acumulador += numero;
            }
            return acumulador;
        }

        static void TestaArrayDeContaCorrente()
        {
            // Inicializacao de Arrays0
            ContaCorrente[] contas = new ContaCorrente[]
            {
                new ContaCorrente(874, 56789767),
                new ContaCorrente(874, 44456686),
                new ContaCorrente(874, 77781438),
            };

            for (int indice = 0; indice < contas.Length; indice++)
            {
                ContaCorrente contaAtual = contas[indice];
                Console.WriteLine($"Conta {indice} = {contaAtual.Numero}");
            }

            Console.ReadLine();
        }

        static void TestaArrayInt()
        {
            // ARRAY de inteiros, com 6 posicoes!
            int[] idades = new int[6];

            idades[0] = 15;
            idades[1] = 28;
            idades[2] = 35;
            idades[3] = 50;
            idades[4] = 28;
            idades[5] = 60;

            int acumulador = 0;
            for (int indice = 0; indice < idades.Length; indice++)
            {
                int idade = idades[indice];

                Console.WriteLine($"Acessando o array idades no indice {indice}");
                Console.WriteLine($"Valor de idades[{indice}] = {idade}");

                acumulador += idade;
            }

            int media = acumulador / idades.Length;
            Console.WriteLine($"Media de idades = {media}");

        }

        static void TestaEquals()
        {
            // Testanto e Mudando Equals
            object conta = new ContaCorrente(456, 687876);
            object desenvolvedor = new Desenvolvedor("4658");

            string contaToString = conta.ToString();
            Console.WriteLine(conta);

            Cliente carlos_1 = new Cliente();
            carlos_1.Nome = "Carlos";
            carlos_1.CPF = "123.123.123-20";
            carlos_1.Profissao = "Designer";

            Cliente carlos_2 = new Cliente();
            carlos_2.Nome = "Carlos";
            carlos_2.CPF = "123.123.123-20";
            carlos_2.Profissao = "Designer";

            ContaCorrente conta_2 = new ContaCorrente(456, 876453);

            if (carlos_1.Equals(carlos_2))
            {
                Console.WriteLine("Sao iguais");
            }
            else
            {
                Console.WriteLine("Nao sao iguais");
            }
        }

        static void TestaString()
        {

            string urlTeste = "https://www.bytebank.com/cambio";
            int indiceByteBank = urlTeste.IndexOf("https://www.bytebank.com");

            Console.WriteLine(urlTeste.StartsWith("https://www.bytebank.com"));
            Console.WriteLine(urlTeste.EndsWith("cambio"));
            Console.WriteLine(urlTeste.Contains("bytebank"));

            Console.WriteLine(indiceByteBank == 0);
            Console.ReadLine();



            string urlParametros = "http://www.bytebank.com/cambio?moedaOrigem=real&moedaDestino=dolar&valor=1500";
            ExtratorValorDeArgumentosURL extratorDeValores = new ExtratorValorDeArgumentosURL(urlParametros);

            string valor = extratorDeValores.GetValor("moedaDestino");
            Console.WriteLine("Valor de moedaDestino: " + valor);

            string valorMoedaOrigem = extratorDeValores.GetValor("moedaOrigem");
            Console.WriteLine("Valor de moedaOrigem: " + valorMoedaOrigem);

            string valorValor = extratorDeValores.GetValor("VALOR");
            Console.WriteLine("Valor do valor: " + valorValor);
            Console.ReadLine();



            // Testando ToLower
            string mensagemOrigem = "PALAVRA";
            string termoBusca = "ra";

            Console.WriteLine(mensagemOrigem.ToLower());


            // Testando Replace
            termoBusca = termoBusca.Replace("r", "R");
            Console.WriteLine(termoBusca);

            termoBusca = termoBusca.Replace("a", "A");
            Console.WriteLine(termoBusca);

            Console.WriteLine(mensagemOrigem.IndexOf(termoBusca));
            Console.ReadLine();


            // Testando o metodo Remove
            string testeRemocao = "primeiraParte&123456";
            int indiceEComercial = testeRemocao.IndexOf("&");
            Console.WriteLine(testeRemocao.Remove(indiceEComercial, 6));


            // <nome>=<valor>
            string palavra = "moedaOrigem=real&moedaDestino=dolar";
            string nomeArgumento = "moedaDestino=";

            int indice = palavra.IndexOf(nomeArgumento);
            Console.WriteLine(indice);

            Console.WriteLine("Tamanho da string nomeArgumento: " + nomeArgumento.Length);

            Console.WriteLine(palavra);
            Console.WriteLine(palavra.Substring(indice));
            Console.WriteLine(palavra.Substring(indice + nomeArgumento.Length));
            Console.ReadLine();


            // Testando o IsNullOrEmpty / WhiteSpace
            string textoTeste = " ";
            Console.WriteLine(String.IsNullOrEmpty(textoTeste));
            Console.WriteLine(String.IsNullOrWhiteSpace(textoTeste));
            Console.ReadLine();



            string url = "pagina?moedaOrigem=real&moedaDestino=dolar";
            int indiceInterrogacao = url.IndexOf("?");

            Console.WriteLine(url);
            Console.WriteLine("Indice: " + indiceInterrogacao);

            string argumentos = url.Substring(indiceInterrogacao + 1);
            Console.WriteLine(argumentos);
        }

        static void TestaRegex()
        {
            // Testando REGEX

            // Regex --> numeros de telefones
            // 7645-8903

            // "9[0123456789][0123456789][0123456789][0123456789][-][0123456789][0123456789][0123456789][0123456789]";
            // "9[0-9][0-9][0-9][0-9][-][0-9][0-9][0-9][0-9]";
            // "9[0-9]{4}[-][0-9]{4}";
            // "[0-9]{4,5}[-][0-9]{4}";
            // "[0-9]{4,5}[-]{0,1}[0-9]{4}";
            // "[0-9]{4,5}-?[0-9]{4}";

            string padrao = @"\d{4,5}-?\d{4}";
            string textoDeTeste = "Meu nome é Thales, me ligue em 7645-8903";

            Match resultado = Regex.Match(textoDeTeste, padrao);

            Console.WriteLine(resultado);
            Console.ReadLine();
        }
    }
}
