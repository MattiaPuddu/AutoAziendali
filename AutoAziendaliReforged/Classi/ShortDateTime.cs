using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoAziendaliReforged.Classi
{
    public class ShortDateTime
    {
        public DateTime Data { get; set; }
        public ShortDateTime(DateTime data)
        {
            Data = data;
        }
        public override string ToString()
        {
            return $"{Data.Day}/{Data.Month}/{Data.Year}";
        }
    }
}
