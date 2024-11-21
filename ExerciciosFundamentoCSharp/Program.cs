using System.Text.RegularExpressions;

namespace ExerciciosFundamentoCSharp 
{
    internal class Program
    {
        static void Main(string[] args)
        {
                //Crie um programa que solicita ao usuário a exibição da data atual em diferentes formatos:
                //- Formato completo (dia da semana, dia do mês, mês, ano, hora, minutos, segundos).
                //- Apenas a data no formato "01/03/2024".
                //- Apenas a hora no formato de 24 horas.
                //- A data com o mês por extenso.

                Console.Write("Digite a data atual: ");
                DateTime dataAtual = DateTime.Parse(Console.ReadLine());
                

                Console.WriteLine(dataAtual);
                Console.WriteLine(dataAtual.ToString("dd/MM/yyyy"));
                Console.WriteLine(dataAtual.ToString("HH:mm:ss"));
                Console.WriteLine(dataAtual.ToString("dd MMMM yyyy"));
                
                
                
                
        }
    }
}