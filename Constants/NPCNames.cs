using System;
using System.Collections.Generic;

namespace dragonstartrek.Constants {
    public static class Languages {
        public static List<Language> List = new List<Language>() {
            new Language() {
                Name = "Ein",
                Names = new List<string>() {
                    "Destal", "Aayo", "Adau", "Adre", "Affigen", "Aipaun", "Ame", "Amul", 
                    "Aryodail", "Attiitel", "Attsyol", "Attsyolu", "Azay", "Autcho", "Bautio",
                    "Bau", "Baul", "Bavo", "Bote", "Bel", "Bepe", "Bessa", "Bevee", "Beveer",
                    "Bolamo", "Buumi", "Buumil", "Buunjel", "Choa", "Chol", "Chondo",
                    "Dai", "Dain", "Daro", "Daru", "Daun", "Deen", "Deeyu", "Deeyur",
                    "Deite", "Dela", "Demil", "Demol", "Dimion", "Dobal", "Dun", "Duruu",
                    "Duun", "Ebbyan", "Ebbyanuun", "Edaa", "Eelan", "Eepe", "Eero", 
                    "Eertamu", "Eirtsa", "Eltreru", "Ensya", "Ero", "Eteryo", "Faur", "Fauza"
                }
            }, 
            new Language() {
                Name = "Rozons",
                Names = new List<string>() {
                    "Aigaf", "Aigau", "Airtou", "Aizum", "Angeàngs", "Barklo", "Arkloi",
                    "Aralst", "Arkloitsu", "Aro", "Arst", "Aumido", "Aurdnuf", "Aurtour",
                    "Auta", "Authaumt", "Baurik", "Bek", "Bengek", "Antseà", "Autseàmt", 
                    "Ashàrtegarstu"
                }
            }
        };
    }
    public class Language {
        public string Name;
        public List<string> Names;
    }

    public static class LanguageEin {
        public static string Name = "Ein";
        public static List<string> Names = new List<string>() {
            "Destal", "Aayo", "Adau", "Adre", "Affigen", "Aipaun", "Ame", "Amul", 
            "Aryodail", "Attiitel", "Attsyol", "Attsyolu", "Azay", "Autcho", "Bautio",
            "Bau", "Baul", "Bavo", "Bote", "Bel", "Bepe", "Bessa", "Bevee", "Beveer",
            "Bolamo", "Buumi", "Buumil", "Buunjel", "Choa", "Chol", "Chondo",
            "Dai", "Dain", "Daro", "Daru", "Daun", "Deen", "Deeyu", "Deeyur",
            "Deite", "Dela", "Demil", "Demol", "Dimion", "Dobal", "Dun", "Duruu",
            "Duun", "Ebbyan", "Ebbyanuun", "Edaa", "Eelan", "Eepe", "Eero", 
            "Eertamu", "Eirtsa", "Eltreru", "Ensya", "Ero", "Eteryo", "Faur", "Fauza", 
            "Fayamo", "Fayo", "Feezaur", "Fepir", "Fepiruun", "Feve", "Fel", "Fo",
            "Fior", "Fola", "Fotel", "Fuedaur", "Fueve", "Fuezal", "Fuitel", "Futir",
            "Grove", "Grozar", "Grorta", "Grotayombor", "Gwurra", "Ialau", "Iankel",
            "Iarnel", "Iaroi", "Iatelle", "Iatellen", "Iattsyol", "Iiryo", "Iiruu",
            "Imi", "Iro", "Iyo", "Izail", "Jan", "Jaye", "Jayu", "Kayul", "Joze",
            "Keimo", "Keitei", "Keivei", "Keron", "Kia", "Kilal", "Keemel", "Kau",
            "Jogen", "Jomen", "Koai", "Kode", "Koltel", "Kuerko", "Kottsyo", "Kueyuen",
            "Kuryon", "Kuulor", "Kwaru", "Lai"
        };
    }

    public static class LanguageRozons {
        public static string Name = "Rozons";
        public static List<string> Names = new List<string>() {
            "Aigaf", "Aigau", "Airtou", "Aizum", "Angeàngs", "Barklo"
        };
    }
}