using Logic.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logic.Repositories.PokeTypeRepository
{
    public interface IPokeTypeRepository
    {
        public Dictionary<string, double> GetWeaknesses(PokeType primary, PokeType? secondary = null);
        public Dictionary<string, double> GetEffectiveness(PokeType attack);
        public double GetModifier(PokeType attack, PokeType primary, PokeType? secondary = null);
    }
}
