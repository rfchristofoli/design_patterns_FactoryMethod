using System;
using FactoryMethod.Enumerators;

namespace FactoryMethod
{
    public class SubZero : IPersonagem
    {
        public string Escolhido() => $"{TiposDePersonagem.SubZero}";
    }
}
