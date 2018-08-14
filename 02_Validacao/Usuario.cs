using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Servirá essa classe para nos trazer uma listagem padrão de Attributos que servirão de validação no código C#
using System.ComponentModel.DataAnnotations;

namespace _02_Validacao
{
    public class Usuario
    {
        [Required(ErrorMessage = "O campo 'nome' é de preenchimento obrigatório.")]
        public string nome { get; set; }

        [Required(ErrorMessageResourceType = typeof(Idioma.Linguagem), ErrorMessageResourceName = "MSG_OBRIGATORIO")]
        [EmailAddress]
        public string email { get; set; }

        [Required, StringLength(10, MinimumLength = 6)]
        public string senha { get; set; }
    }
}
