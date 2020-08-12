using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AfectacionMedioAmbiente.Web.Models
{
    public class RopaFoto
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public byte[] Fotografia { get; set; }
    }
}
