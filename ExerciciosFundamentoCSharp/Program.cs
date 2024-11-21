using System.Text.RegularExpressions;

namespace ExerciciosFundamentoCSharp 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Crie um programa em que o usuário precisa digitar a placa de um veículo e o programa verifica se a placa é válida, seguindo o padrão brasileiro válido até 2018:
            //- A placa deve ter 7 caracteres alfanuméricos;
            //- Os três primeiros caracteres são letras (maiúsculas ou minúsculas);
            //- Os quatro últimos caracteres são números;
    
            //Ao final, o programa deve exibir ***Verdadeiro*** se a placa for válida e ***Falso*** caso contrário.

            Console.Write("Digite a placa do carro: ");
            string placa = Console.ReadLine();
            string padrao = @"^[a-zA-Z]{3}\d{4}$";
            ;

            if (Regex.IsMatch(placa, padrao))
            {
                Console.WriteLine("Placa Valida");
            }
            else
            {
                Console.WriteLine("Placa Invalida");
            }
        }
    }
}