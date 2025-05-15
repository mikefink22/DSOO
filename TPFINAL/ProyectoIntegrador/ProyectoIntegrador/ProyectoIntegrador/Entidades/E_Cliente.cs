using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoIntegrador.Entidades
{
    
    public class E_Cliente
    {
        public int DocC { get; set; }
        public string? TDocC { get; set; }
        public string? NombreC { get; set; }
        public string? ApellidoC { get; set; }
        public DateTime? FechaNac { get; set; }
    }
}
