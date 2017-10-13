using dragonstartrek.Constants;
using dragonstartrek.Models;
using System;
using System.Collections.Generic;
using Tools;

namespace dragonstartrek.Generators {
    public class NPCGenerator {
        public Dictionary<string, MarkovChain> Chains;
        private Dice dice = new Dice();
        public NPCGenerator() {
            Chains = new Dictionary<string, MarkovChain>();
            foreach(Language language in Languages.List) {
                Chains[language.Name] = new MarkovChain(2);
                Chains[language.Name].ConvertWords(language.Names);
            }
        }
        public NPC Generate() {
            NPC newNPC = new NPC() {
                Sex = dice.Roll("1d2") == 1 ? "Male" : "Female",
                Species = dice.Sample(new List<string>() { "Summer Elf", "Vrar" }),
                Profession = dice.Sample(NPCProfessions.BroadCategory),
                MaritalStatus = dice.Roll("1d100") <= 56 ? "Married" : "Single"
            };
            switch(newNPC.Species) {
                case "Summer Elf":
                    newNPC.GivenName = Chains["Ein"].Generate();
                    newNPC.FamilyName = Chains["Ein"].Generate();
                    break;
                case "Vrar":
                    newNPC.GivenName = Chains["Rozons"].Generate();
                    newNPC.FamilyName = Chains["Rozons"].Generate();
                    break;
            }
            newNPC.Gender = dice.Roll("1d200") == 200 ? (newNPC.Sex == "Male" ? "Female" : "Male") : newNPC.Sex;

            // Sex
            return newNPC;
        }
    }
}