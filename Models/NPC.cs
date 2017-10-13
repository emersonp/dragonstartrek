using System;

namespace dragonstartrek.Models {

    public class NPC {
        public string Culture { get; set; }
        public string FamilyName { get; set; }
        public string Gender { get; set; }
        public string GivenName { get; set; }
        public string Profession { get; set; }
        public string Sex { get; set; }
        public string Species { get; set; }
        public string MaritalStatus { get; set; }
        public NPCPhysicalDescription PhysicalDescription { get; set; }
        
        public string FullName() {
            return GivenName + " " + FamilyName;
        }
    }
    public class NPCPhysicalDescription {
        public int Height;
        public int Weight;
        public string Build;
    }
}