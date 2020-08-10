using System;
using System.Collections.Generic;
using System.Text;
using Logic.Enums;
using PokeType = Logic.Enums.PokeType;

namespace Logic.Models
{
    public class Attack
    {
        string name { get; set; }
        PokeType type { get; set; }
        Target target { get; set; }
        Category category { get; set; }
        double? power { get; set; }
        double? accuracy { get; set; }
        string flavor { get; set; }
        ulong powerpoints { get; set; }
    }
}
