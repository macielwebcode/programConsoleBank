using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mmbBank
{
    public class StudentNotFoundException : Exception
    {
        public double Saldo { get; }
        public double ValorSaque { get; }
        public StudentNotFoundException(double saldo, double valorSaque) : this ("Tentativa de saque de " + valorSaque + " com saldo de " + saldo) {
            Saldo = saldo;
            ValorSaque = valorSaque;

        }
        public StudentNotFoundException(string message) : base(message) { }
        public StudentNotFoundException(string message, Exception innerException) : base(message, innerException) { }

    }
}
