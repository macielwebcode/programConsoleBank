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

        public static float TaxaOperacao { get; private set; }
        
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

        private double saldo = 100;

        public ContaCorrente(int numero_agencia, string conta, PessoaTitular cliente)
        {
            this.NumeroAgenca = numero_agencia;
            this.Conta = conta;
            if(numero_agencia <= 0)
            {
                throw new ArgumentException("Número de agencia menor ou igual a zero",  nameof(numero_agencia));
            }
            //try
            //{
            //    TaxaOperacao = 30 / TotalDeContasCriadas;
            //}
            //catch (DivideByZeroException)
            //{

            //    Console.WriteLine("Divisão por zero nao existe");
            //}

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
            else
            {
                throw new SaldoInsuficienteException("Saldo Insuficiente para a Operação de Sacar");
            }
            


        }
        public bool Transferir(double valor, ContaCorrente conta_destino)
        {
            if (saldo < valor)
            {
                throw new ArgumentException("Valor inválido para a transferência.", nameof(valor));
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
