using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AfectacionMedioAmbiente.Web.Models
{
    public class Fabrica
    {
        public Camiseta CrearCamiseta(string marca = "cuello", string modelo ="polo")
        {
            Camiseta camiseta = new Camiseta(marca, modelo);
            return camiseta;
        }
    }
}
