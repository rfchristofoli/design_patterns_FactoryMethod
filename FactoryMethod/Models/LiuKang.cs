using System;
using FactoryMethod.Enumerators;

namespace FactoryMethod
{
    public class LiuKang : IPersonagem
    {
        public string Escolhido() => $"{TiposDePersonagem.LiuKang}";
    }
}
