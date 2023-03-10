using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mmbBank.Pessoa;


namespace mmbBank.Contas
{
    public class ContaCorrente
    {
        public static int TotalDeContasCriadas{ get; private set; }

        
        private int numero_agencia;
        public int NumeroAgenca
        {
            get { return numero_agencia; }
            private set { 
                    if(value > 0)
                    {
                        this.numero_agencia = value;
                    }
                     
            }
        }


        public string Conta { get; set; }

        public PessoaTitular Titular { get; set; }

        private double saldo = 0;

        public ContaCorrente(int numero_agencia, string conta, PessoaTitular cliente)
        {
            this.NumeroAgenca = numero_agencia;
            this.Conta = conta;
            Titular = cliente;
            TotalDeContasCriadas++;
        }

        public void SetSaldo(double valor)
        {
            if(valor < 0)
            {
                return;
            }
            else
            {
                this.saldo = valor;
            }
        }

        public double GetSaldo()
        {
            return this.saldo;
        }
        public void Depositar(double valor)
        {
            saldo += valor;

        }

        public bool Sacar(double valor)
        {
            if (valor <= saldo)
            {
                saldo -= valor;
                return true;
            }
            return false;


        }
        public bool Transferir(double valor, ContaCorrente conta_destino)
        {
            if (saldo < valor)
            {
                return false;
            }
            if (valor < 0)
            {
                return false;
            }
            else
            {

                Sacar(valor);
                conta_destino.Depositar(valor);
                return true;
            }
        }

        public void ExibirDadosDaConta()
        {
            Console.WriteLine("Titular :" + Titular.pessoaNome);
            Console.WriteLine("Conta :" + Conta);
            Console.WriteLine("Número Agência :" + numero_agencia);
            Console.WriteLine("Saldo: " + saldo);
        }

    }
}
