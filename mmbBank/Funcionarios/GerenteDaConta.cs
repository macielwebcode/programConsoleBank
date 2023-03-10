﻿using mmbBank.SistemaInterno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mmbBank.Funcionarios
{
    public class GerenteDaConta : FuncionarioAutenticavel
    {
      

        public GerenteDaConta(string cpf) : base(cpf, 4000)
        {

        }

        public override double GetBonificacao()
        {
            return Salario * 0.25;
        }

        public override void AumentarSalario()
        {
            Salario *= 1.05;
        }

   
    }
}
