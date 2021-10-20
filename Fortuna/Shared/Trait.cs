using System;
namespace Fortuna.Shared
{
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
    
    public enum TraitValue
    {
        Neutral,
        Good,
        Bad,
        Special,
        Ability
    }
}