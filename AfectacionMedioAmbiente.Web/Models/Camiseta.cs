using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AfectacionMedioAmbiente.Web.Models
{
    public class Camiseta
    {
        public Camiseta() { }
        
        public Camiseta(string marca, string modelo)
        {
            Marca = marca;
            Modelo = modelo;
        }
        [System.ComponentModel.DataAnnotations.Display(Description = "Esta es la marca")]
        public int Id { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
    }
    
}
