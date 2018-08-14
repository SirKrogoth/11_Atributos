using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Atributos
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Field | AttributeTargets.Property | AttributeTargets.Method)]
    class MeuAtributo : Attribute
    {
        public string nome { get; set; }
        public string descricao { get; set; }

        public MeuAtributo(string nome)
        {
            this.nome = nome;
        }
    }
}
