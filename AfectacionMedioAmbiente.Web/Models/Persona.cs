using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AfectacionMedioAmbiente.Web.Models
{
    public class Persona
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public List<Camiseta> Camisetas { get; set; } = new List<Camiseta>(); 
    }
}
