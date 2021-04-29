using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoAziendaliReforged.Classi
{
    public static class GestioneFiles
    {
        public const string pathMacchine = @"D:\macchine.json";
        public const string pathDipendenti = @"D:\dipendenti.json";

        public static List<Auto> GetCars()
        {
            var jsonCars = File.ReadAllText(pathMacchine);

            return string.IsNullOrEmpty(jsonCars) ? new List<Auto>() : JsonConvert.DeserializeObject<List<Auto>>(jsonCars);
        }
        public static List<Dipendente> GetDipendenti()
        {
            var jsonDipendenti = File.ReadAllText(pathDipendenti);

            return string.IsNullOrEmpty(jsonDipendenti) ? new List<Dipendente>() : JsonConvert.DeserializeObject<List<Dipendente>>(jsonDipendenti);
        }
        public static void SaveCars(List<Auto> auto)
        {
            var jsonCars = JsonConvert.SerializeObject(auto);

            File.WriteAllText(pathMacchine, jsonCars);
        }
    }
}
