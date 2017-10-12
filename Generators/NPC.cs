using dragonstartrek.Constants;
using System;
using System.Collections.Generic;
using Tools;

namespace dragonstartrek.Generators {
    public class NPCGenerator {
        public MarkovChain Chain;
        public string Culture;
        public NPCGenerator(string culture) {
            Culture = culture;
            Chain = new MarkovChain(2);
            Chain.ConvertWords(LanguageEin.Names);
        }
        public NPC Generate(string sex, string species) {
            NPC newNPC = new NPC(sex, species, Culture);
            newNPC.Name = Chain.Generate() + " " + Chain.Generate();
            return newNPC;
        }
    }
    public class NPC {
        public string Species { get; set; }
        public string Sex { get; set; }
        public string Gender { get; set; }
        public string Name { get; set; }
        private Dice dice = new Dice();

        public NPC(string sex, string species, string culture) {
            // Sex
            if(sex == "random") {
                Sex = dice.Roll("1d2") == 1 ? "male" : "female";
            } else {
                Sex = sex;
            }
            Gender = dice.Roll("1d200") == 200 ? (Sex == "male" ? "female" : "male") : Sex;
            Species = species;
        }
    }
}