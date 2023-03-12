using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mmbBank
{
    public class LeitorDeArquivo : IDisposable
    {
       
        public string Arquivo { get; }

        public LeitorDeArquivo(string arquivo)
        {
            Arquivo = arquivo;
            Console.WriteLine("Abrindo arquivo: " + arquivo);
        }
        public string LerProximaLinha()
        {
            Console.WriteLine("Lendo linha. . .");

            //comenta o descomenta o throw para testar erro na leitura do arquivo
            throw new IOException();

            return "Linha do arquivo";
        }
        public void Dispose()
        {
            Console.WriteLine("Fechando arquivo.");
        }
    }
}
