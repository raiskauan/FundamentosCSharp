namespace ExerciciosFundamentoCSharp 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crie um programa em que o usuário digita uma ou mais palavras
            //e é exibido a quantidade de caracteres que a palavra inserida tem.

            Console.Write("Digite uma palavra ou mais: ");
            string palavra = Console.ReadLine();
            double contador = 0;

            foreach (char c in palavra)
            {
                if (c != ' ')
                {
                    contador++;
                }
            }
                

            Console.WriteLine($"Existe {contador} caracteres nessa(s) palavras");
        }
    }
}