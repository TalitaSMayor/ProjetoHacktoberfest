using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Graficos.Data
{
    public class Dados
    {
        public int Bloco { get; set; }
        public int Tratamentos { get; set; }
        public decimal TemperturaSolo { get; set; }
        public decimal TemperaturaSuperficieSolo { get; set; }
        public decimal TemperaturaCopa { get; set; }
        public decimal DiametroColeto { get; set; }
        public decimal AlturaPlanta { get; set; }
        public int NumeroFolhas { get; set; }
        public DateTime Data { get; set; }
        public int codigo { get; set; }
    }


}
