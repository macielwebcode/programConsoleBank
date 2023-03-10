using mmbBank.SistemaInterno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mmbBank.Funcionarios
{
    public class Diretor:FuncionarioAutenticavel
    {
       
        public override double GetBonificacao()
        {
            return Salario * Salario;
        }
        public Diretor(string cpf):base(cpf, 10000)
        {
            //Console.WriteLine("criando diretor");
        }
        public override void AumentarSalario()
        {
            this.Salario *= 1.15;
        }

    }
}
