using Logic.Enums;
using System.Collections.Generic;

namespace Logic.Models
{
    public class Pokemon
    {
        ulong dexno { get; set; }
        string name { get; set; }
        List<PokeType> types { get; set; }
        PokeStats stats { get; set; }
        List<Attack> attacks { get; set; }
        double low_height { get; set; }
        double high_height { get; set; }
        double low_weight { get; set; }
        double high_weight { get; set; }
        bool gmax { get; set; } = false;
        string description { get; set; }
        Pokemon previous { get; set; }
        Pokemon next { get; set; }
    }
}
