using System;

    public class NPC {
        public string Culture { get; set; }
        public string FamilyName { get; set; }
        public string Gender { get; set; }
        public string GivenName { get; set; }
        public string Profession { get; set; }
        public string Sex { get; set; }
        public string Species { get; set; }
        public string MaritalStatus { get; set; }
        
        public string FullName() {
            return GivenName + " " + FamilyName;
        }
        public NPC() {
        }
    }