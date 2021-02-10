using System;
using FactoryMethod.Enumerators;

namespace FactoryMethod
{
    public class FactoryMethod
    {
        public IPersonagem Escolher_Personagem(TiposDePersonagem personagem)
        {
            switch(personagem)
            {
                case TiposDePersonagem.LiuKang: return new LiuKang();
                case TiposDePersonagem.Scorpion: return new Scorpion();
                case TiposDePersonagem.SubZero: return new SubZero();
                default: return null;
            }
        }
    }
}
