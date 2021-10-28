using System.Collections.Generic;
namespace Fortuna.Shared
{
    public class FortunaSheet
    {
        /// <summary>
        ///     The biographical information of the character the sheet contains.
        /// </summary>
        public string Bio = "Put biographical information here.";

        /// <summary>
        ///     The class of the character the sheet contains. May be changed to a unique struct if codified?
        /// </summary>
        public string Class = "Captain";

        /// <summary>
        ///     Image URL linking to a custom picture of the character the sheet contains.
        /// </summary>
        public string ImageUrl = "images/aftik.png";

        /// <summary>
        ///     A list of items in the character's inventory.
        /// </summary>
        public List<string> Inventory = new();

        /// <summary>
        ///     The moves this character can use.
        /// </summary>
        public Dictionary<string, Move> Moves = new();

        /// <summary>
        ///     The name of the character the sheet contains.
        /// </summary>
        public string Name = "Name";

        /// <summary>
        ///     The pronouns of the character the sheet contains.
        /// </summary>
        public string Pronoun = "Pronoun";

        /// <summary>
        ///     The race of the character the sheet contains. May be changed to a unique struct if codified?
        /// </summary>
        public string Species = "Race";

        /// <summary>
        ///     A dictionary of the character's stats, with the key being a string that represents a stat.
        /// </summary>
        public Dictionary<string, int> Stats = new() { { "Strength", 5 }, { "Intelligence", 5 }, { "Charisma", 5 }, { "Endurance", 5 }, { "Agility", 5 }, { "Luck", 5 } };

        /// <summary>
        ///     A list of the character's traits.
        /// </summary>
        public List<Trait> Traits = new();
    }

    public class Move
    {
        public string OnSuccessPartial { get; set; }
        public string OnSuccess { get; set; }
    }
}