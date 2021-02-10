using System;
using FactoryMethod.Enumerators;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            FactoryMethod fm = new FactoryMethod();
            IPersonagem personagem = null;

            Console.WriteLine($"(A){TiposDePersonagem.LiuKang} | (B){TiposDePersonagem.Scorpion} | (C){TiposDePersonagem.SubZero} ");
            Console.WriteLine();

            Console.Write("Escolha seu personagem: ");

            string escolha = Console.ReadLine().ToUpper();

            if (escolha == "A")
                personagem = fm.Escolher_Personagem(TiposDePersonagem.LiuKang);
            else if (escolha == "B")
                personagem = fm.Escolher_Personagem(TiposDePersonagem.Scorpion);
            else if (escolha == "C")
                personagem = fm.Escolher_Personagem(TiposDePersonagem.SubZero);
            else
                Console.WriteLine("Personagem inválido!");

            if (personagem == null)
            Console.WriteLine($"Você vai jogar com {personagem.Escolhido()}");
            Console.ReadLine();
        }
    }
}
