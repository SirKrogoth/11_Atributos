using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using _03_Validacao_Customizada;

namespace _03_Validacao_Customizada
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instancia da classe usuário
            Usuario usuario = new Usuario() { nome = "João Rafael", email = "joao", senha = "1234" };

            ValidationContext validationContext = new ValidationContext(usuario);

            List<ValidationResult> validationResults = new List<ValidationResult>();

            if (Validator.TryValidateObject(usuario, validationContext, validationResults, true) == false)
            {
                //Mensagem
                foreach (var erro in validationResults)
                {
                    Console.WriteLine(erro.ErrorMessage);
                }

                Console.ReadKey();
            }

        }
    }
}
