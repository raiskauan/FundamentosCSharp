﻿namespace ExerciciosFundamentoCSharp 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crie um programa em que o usuário precisa digitar um nome e uma mensagem de boas vindas personalizada
            //com o nome dele é exibida:  Olá, Welisson! Seja muito bem-vindo!
            
            Console.Write("Digite o seu Nome");
            string nome = Console.ReadLine();

            Console.WriteLine($"Olá, {nome}! Seja muito bem-vindo!");
        }
    }
}