using Logic.Enums;
using Logic.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logic.Repositories.PokeTypeRepository
{
    public class PokeTypeRepository: IPokeTypeRepository
    {
        public Dictionary<string, double> GetWeaknesses(PokeType primary, PokeType? secondary = null)
        {
            var typeList = new List<PokeType>() { primary };
            if (secondary.HasValue) typeList.Add(secondary.Value);
            var result = PokeTypeChart.GetWeaknesses(typeList);
            return result;
        }
        public Dictionary<string, double> GetEffectiveness(PokeType attack)
        {
            var result = PokeTypeChart.GetEffectiveness(attack);
            return result;
        }
        public double GetModifier(PokeType attack, PokeType primary, PokeType? secondary = null)
        {
            var typeList = new List<PokeType>() { primary };
            if (secondary.HasValue) typeList.Add(secondary.Value);
            var result = PokeTypeChart.GetModifier(attack, typeList);
            return result;
        }
    }
}
