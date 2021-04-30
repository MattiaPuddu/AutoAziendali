using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoAziendaliReforged.Classi
{
    public class Auto
    {
        public string Marca { get; set; }
        public string Modello { get; set; }
        public string Targa { get; set; }
        public string Cilindrata { get; set; }
        public DateTime ScadenzAssicurazione { get; set; }
        public Stato Disponibilita { get; set; } = Stato.DISPONIBILE;
        public Dipendente Owner { get; set; }

        public Auto(string marca, string modello, string targa, string cilindrata, DateTime scadAssic)
        {
            Marca = marca;
            Modello = modello;
            Targa = targa;
            Cilindrata = cilindrata;
            ScadenzAssicurazione = scadAssic;
        }
        public override string ToString()
        {
            return $"{Marca} - {Modello} - {Targa} - {ScadenzAssicurazione.ToString("dd/MM/yyyy")} - {Disponibilita} - {Owner}";
        }
    }
}
