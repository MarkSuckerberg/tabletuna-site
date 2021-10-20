using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
namespace Fortuna.Shared
{
    public class FortunaSheet
    {
        public string Name = "Name";
        public string Pronoun = "Pronoun";
        public string Species = "Race";
        public string Class = "Captain";
        public string Bio = "Put biographical information here.";
        public string ImageUrl = "/images/aftik.png";
        public Dictionary<string, int> Stats = new() { { "Strength", 5 }, { "Intelligence", 5 }, { "Charisma", 5 }, { "Endurance", 5 }, { "Agility", 5 }, { "Luck", 5 } };
        public List<Trait> Traits = new();
    }

    public enum TraitValue
    {
        Neutral,
        Good,
        Bad,
        Special,
        Ability
    }
    
    [Serializable]
    public struct Trait
    {
        public TraitValue Value { get; set; }
        public string Name { get; set; }
        public string Effects { get; set; }
        public bool Editable { get; set; }
        
        public Trait(TraitValue value, string name, string effects, bool editable = false)
        {
            Value = value;
            Name = name;
            Effects = effects;
            Editable = editable;
        }

        public override string ToString()
        {
            return Name;
        }

        public static int CompareTraitValue(Trait x, Trait y)
        {
            if ((int)x.Value > (int)y.Value) {
                return 1;
            } 
            if ((int)x.Value < (int)y.Value) {
                return -1;
            }
            return 0;
        }
    }
}