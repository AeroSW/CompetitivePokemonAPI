using System;
using System.Collections.Generic;
using System.Text;

namespace Logic.Enums.Utilities
{
    class PokeTypeUtility
    {
        public static string ToString(PokeType type)
        {
            switch (type)
            {
                case PokeType.NORMAL:
                    return "normal";
                case PokeType.FIGHTING:
                    return "fighting";
                case PokeType.PSYCHIC:
                    return "psychic";
                case PokeType.DARK:
                    return "dark";
                case PokeType.DRAGON:
                    return "dragon";
                case PokeType.FIRE:
                    return "fire";
                case PokeType.WATER:
                    return "water";
                case PokeType.GRASS:
                    return "grass";
                case PokeType.ELECTRIC:
                    return "electric";
                case PokeType.GHOST:
                    return "ghost";
                case PokeType.ICE:
                    return "ice";
                case PokeType.GROUND:
                    return "ground";
                case PokeType.ROCK:
                    return "rock";
                case PokeType.STEEL:
                    return "steel";
                case PokeType.BUG:
                    return "bug";
                case PokeType.FAIRY:
                    return "fairy";
                case PokeType.POISON:
                    return "poison";
                case PokeType.FLYING:
                    return "flying";
            }
            throw new NotImplementedException("Provided type has not been implemented yet.");
        }
        public static PokeType ToEnum(string type)
        {
            var tempType = type.ToUpper().ToLower();
            switch (tempType)
            {
                case "normal":
                    return PokeType.NORMAL;
                case "fighting":
                    return PokeType.FIGHTING;
                case "psychic":
                    return PokeType.PSYCHIC;
                case "dark":
                    return PokeType.DARK;
                case "dragon":
                    return PokeType.DRAGON;
                case "fire":
                    return PokeType.FIRE;
                case "water":
                    return PokeType.WATER;
                case "grass":
                    return PokeType.GRASS;
                case "electric":
                    return PokeType.ELECTRIC;
                case "ghost":
                    return PokeType.GHOST;
                case "ice":
                    return PokeType.ICE;
                case "ground":
                    return PokeType.GROUND;
                case "rock":
                    return PokeType.ROCK;
                case "steel":
                    return PokeType.STEEL;
                case "bug":
                    return PokeType.BUG;
                case "fairy":
                    return PokeType.FAIRY;
                case "poison":
                    return PokeType.POISON;
                case "flying":
                    return PokeType.FLYING;
            }
            throw new NotImplementedException("Provided type has not been implemented yet.");
        }
    }
}
