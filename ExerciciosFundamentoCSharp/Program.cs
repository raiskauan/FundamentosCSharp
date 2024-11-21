namespace ExerciciosFundamentoCSharp 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Crie um programa com 2 valores do tipo **`double`** já declarados ****que retorne:
            //- A soma entre esses dois números;
            //- A subtração entre os dois números;
            //- A multiplicação entre os dois números;
            //- A divisão entre os dois números (vale uma verificação se o segundo número é 0!);
            //- A média entre os dois números.
            
            Console.Write("Digite o primeiro valor: ");
            double valor1 = double.Parse(Console.ReadLine());
            Console.Write("Digite o segundo valor: ");
            double valor2 = double.Parse(Console.ReadLine());
            
            double soma = valor1 + valor2;
            double subtracao = valor1 - valor2;
            double multiplicacao = valor1 * valor2;
            double divisao = valor1 / valor2;
            double media = (valor1 + valor2) / 2;
            

            Console.WriteLine("A soma entre esses dois números: " + soma);
            Console.WriteLine("A subtração entre esses dois números: " + subtracao);
            Console.WriteLine("A multiplição entre esse dois números: " + multiplicacao);
            if (valor1 == 0 || valor2 == 0)
            {
                Console.WriteLine("Impossivel fazer essa divisão.");
            }
            else
            {
                Console.WriteLine("A divisão entre esse dois números: " + divisao);
            }

            Console.WriteLine("A média entre esse dois números: " + media);
        }
    }
}