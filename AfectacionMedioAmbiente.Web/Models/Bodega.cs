using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AfectacionMedioAmbiente.Web.Models
{
    public class Bodega
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public Persona Bodeguero { get; set; }
        public List<Pantalon> Pantalones { get; set; }
        public List<Polin> Polines { get; set; }
        public List<Boxer> Boxeres { get; set; }
        public List<Top> Tops { get; set; }
    }
}
