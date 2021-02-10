using System;
using FactoryMethod.Enumerators;

namespace FactoryMethod
{
    public class Scorpion : IPersonagem
    {
        public string Escolhido() => $"{TiposDePersonagem.Scorpion}";
    }
}
