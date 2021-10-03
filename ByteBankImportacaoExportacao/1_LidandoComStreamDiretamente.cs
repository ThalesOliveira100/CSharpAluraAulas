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
        static void LidarComFileStreamDiretamente()
        {
            var enderecoDoArquivo = "contas.txt";

            using (var fluxoDoArquivo = new FileStream(enderecoDoArquivo, FileMode.Open))
            {
                var buffer = new byte[1024]; // 1 kb
                var numeroDeBytesLidos = -1;

                while (numeroDeBytesLidos != 0)
                {
                    numeroDeBytesLidos = fluxoDoArquivo.Read(buffer, 0, 1024);

                    Console.WriteLine(($"Numero de bytes lidos {numeroDeBytesLidos}"));


                    EscreverBuffer(buffer, numeroDeBytesLidos);
                }
            }
        }

        static void EscreverBuffer(byte[] buffer, int bytesLidos)
        {
            var texto = Encoding.UTF8.GetString(buffer, 0, bytesLidos);

            Console.Write(texto);

            //foreach (var meuByte in buffer)
            //{
            //    Console.Write(meuByte);
            //    Console.Write(" ");
            //}
        }

        // TESTES ENUMERADORES
        static void TestaEnumeradores()
        {
            var btnCancelar = new Botao();
            btnCancelar.Texto = "Cancelar";
            btnCancelar.Cor = CoresBotao.Vermelho;
        }
        class Botao
        {
            public String Texto { get; set; }
            public CoresBotao Cor { get; set; }
        }
        enum CoresBotao
        {
            Azul = 128,
            Vermelho = 256,
            Verde = 512
        }
    }
}