using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoAziendaliReforged.Classi
{
    public class Dipendente
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string Matricola { get; set; }
        public Dipendente(string nome, string cognome, string matricola)
        {
            Nome = nome;
            Cognome = cognome;
            Matricola = matricola;
        }
        public override string ToString()
        {
            return $"{Nome} {Cognome} - {Matricola}";
        }
    }
}
