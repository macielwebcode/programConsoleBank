﻿using mmbBank.SistemaInterno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mmbBank.ParceriaComercial
{
    public class ParceiroComercial:IAutenticavel
    {
       
        public string Senha { get; set; }

        public bool Autenticar(string senha){
            return this.Senha == senha;
        }

    }
}
