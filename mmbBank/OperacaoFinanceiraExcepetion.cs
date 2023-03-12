using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mmbBank
{
    public class OperacaoFinanceiraExcepetion : Exception
    {
        public OperacaoFinanceiraExcepetion(string mensagem) : base(mensagem)
        {

        }
        public OperacaoFinanceiraExcepetion(string mensagem, Exception excecaointerna) : base(mensagem, excecaointerna)
        {

        }
    }
}
