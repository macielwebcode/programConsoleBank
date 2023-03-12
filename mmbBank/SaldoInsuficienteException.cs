using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mmbBank
{
    public class SaldoInsuficienteException : OperacaoFinanceiraExcepetion
    {
      
        public SaldoInsuficienteException(string mensagem) : base(mensagem)
        {

        }
    }
}
