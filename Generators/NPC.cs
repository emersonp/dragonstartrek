using dragonstartrek.Constants;
using System;
using System.Collections.Generic;
using Tools;

namespace dragonstartrek.Generators {
    public class NPCGenerator {
        public MarkovChain Chain;
        private Dice dice = new Dice();
        public string Culture;
        public NPCGenerator(string culture) {
            Culture = culture;
            Chain = new MarkovChain(2);
            Chain.ConvertWords(LanguageEin.Names);
        }
        public NPC Generate(string sex, string species) {
            NPC newNPC = new NPC() {
                Sex = sex == "Random" ? (dice.Roll("1d2") == 1 ? "Male" : "Female") : sex,
                Species = species,
                GivenName = Chain.Generate(),
                FamilyName = Chain.Generate(),
                Culture = Culture,
                Profession = NPCProfessions.BroadCategory[dice.Roll("1d" + NPCProfessions.BroadCategory.Count) - 1]
            };
            newNPC.Gender = dice.Roll("1d200") == 200 ? (newNPC.Sex == "Male" ? "Female" : "Male") : newNPC.Sex;

            // Sex
            return newNPC;
        }
    }
    public class NPC {
        public string Culture { get; set; }
        public string FamilyName { get; set; }
        public string Gender { get; set; }
        public string GivenName { get; set; }
        public string Profession { get; set; }
        public string Sex { get; set; }
        public string Species { get; set; }
        public string FullName() {
            return GivenName + " " + FamilyName;
        }

        public NPC() {
        }
    }
}