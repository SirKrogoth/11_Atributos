using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Servirá essa classe para nos trazer uma listagem padrão de Attributos que servirão de validação no código C#
using System.ComponentModel.DataAnnotations;
using _03_Validacao_Customizada;

namespace _03_Validacao_Customizada
{
    public class Usuario
    {
        [Required(ErrorMessage = "O campo 'nome' é de preenchimento obrigatório.")]
        public string nome { get; set; }

        [Required]
        [EmailAddress]
        public string email { get; set; }

        [Required, StringLength(10, MinimumLength = 6)]
        [MyValidation(ErrorMessage = "O campo senha deverá ter 10 caracteres")]
        public string senha { get; set; }
    }
}
