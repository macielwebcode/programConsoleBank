using mmbBank.Funcionarios;
using mmbBank.ParceriaComercial;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mmbBank.SistemaInterno
{
    public class SistemaInterno
    {
        public bool Logar(IAutenticavel auth, string password)
        {
            bool userAutenticado = auth.Autenticar(password);

            if (userAutenticado)
            {
                Console.WriteLine("Boas Vindas, sistema tá ON");
                return true;
            }
            else
            {
                Console.WriteLine("Acesso Negado. Senha Incorreta");
                return false;
            }
        }

    }
}
