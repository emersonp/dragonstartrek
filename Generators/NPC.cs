using dragonstartrek.Constants;
using dragonstartrek.Models;
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
                Profession = dice.Sample(NPCProfessions.BroadCategory),
                MaritalStatus = dice.Roll("1d100") <= 56 ? "Married" : "Single"
            };
            newNPC.Gender = dice.Roll("1d200") == 200 ? (newNPC.Sex == "Male" ? "Female" : "Male") : newNPC.Sex;

            // Sex
            return newNPC;
        }
    }
}