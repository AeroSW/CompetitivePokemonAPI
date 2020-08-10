using Logic.Enums;
using Logic.Enums.Utilities;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Logic.Models
{
    class PokeTypeChart
    {
        public static double GetModifier(PokeType attack, List<PokeType> targetTypes)
        {
            if (targetTypes.Count < 1 || targetTypes.Count > 2)
            {
                throw new ArgumentException("There is a minimum of 1 type and a maximum of 2 types.");
            }
            if (TypeChart == null)
            {
                Setup();
            }
            var result = TypeChart[attack][targetTypes[0]];
            if (targetTypes.Count == 2)
            {
                result *= TypeChart[attack][targetTypes[1]];
            }
            return result;
        }
        public static Dictionary<string, double> GetWeaknesses(List<PokeType> targetTypes)
        {
            if (targetTypes.Count < 1 || targetTypes.Count > 2)
            {
                throw new ArgumentException("There is a minimum of 1 type and a maximum of 2 types.");
            }
            var result = _GetWeaknesses(targetTypes[0]);
            if(targetTypes.Count == 2)
            {
                var tResult = _GetWeaknesses(targetTypes[1]);
                result.Keys.ToList().ForEach(key => {
                    result[key] *= tResult[key];
                });
            }
            return result;
        }
        public static Dictionary<string, double> GetEffectiveness(PokeType type)
        {
            var result = _GetEffectiveness(type);
            return result;
        }

        private static Dictionary<PokeType, Dictionary<PokeType, double>> TypeChart { get; set; }
        private static readonly List<string> TypesList = new List<string>(new[] {
            "Normal",
            "Fire",
            "Water",
            "Electric",
            "Grass",
            "Ice",
            "Fighting",
            "Poison",
            "Ground",
            "Flying",
            "Psychic",
            "Bug",
            "Rock",
            "Ghost",
            "Dragon",
            "Dark",
            "Steel",
            "Fairy"
        });
        private static void Setup()
        {
            // Constant variables that will never change type.
            const string JsonPathTemplate = "../PokemonDetails/Types/{{type}}.json";

            // Instantiate TypeChart
            TypeChart = new Dictionary<PokeType, Dictionary<PokeType, double>>();

            TypesList.ForEach(type => {
                var typePath = JsonPathTemplate.Replace("{{type}}", type);
                var pokeType = PokeTypeUtility.ToEnum(type);
                // Instantiate the Type's values.
                TypeChart.Add(pokeType, new Dictionary<PokeType, double>());
                var chartJsonStr = File.ReadAllText(typePath);
                Dictionary<string, double> typeStrDoubleMap = JObject.Parse(chartJsonStr)
                    .ToObject<Dictionary<string, double>>();
                // For each key in parsed JSON Map
                typeStrDoubleMap.Keys.ToList().ForEach(key => {
                    // Convert key to type
                    var targetPokeType = PokeTypeUtility.ToEnum(key);
                    // Add type with modifier to the chart.
                    TypeChart[pokeType].Add(targetPokeType, typeStrDoubleMap[key]);
                });
            });
        }
        private static Dictionary<string, double> _GetWeaknesses(PokeType type)
        {
            var result = new Dictionary<string, double>();
            if(TypeChart == null)
            {
                Setup();
            }
            TypeChart.Keys.ToList().ForEach(key =>
            {
                var keyStr = PokeTypeUtility.ToString(key);
                result.Add(keyStr, TypeChart[key][type]);
            });
            return result;
        }

        private static Dictionary<string, double> _GetEffectiveness(PokeType type)
        {
            if (TypeChart == null)
            {
                Setup();
            }
            var result = new Dictionary<string, double>();
            var tResult = TypeChart[type];
            tResult.Keys.ToList().ForEach(key => {
                var keyStr = PokeTypeUtility.ToString(key);
                result.Add(keyStr, tResult[key]);
            });
            return result;
        }
    }
}
