using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoApi.Modelo
{
    public class Persona
    {
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Genero { get; set; }
        [Required]
        public int Edad { get; set; }
        [Required]
        public int Identificacion { get; set; }
        [Required]
        public string Direccion { get; set; }
        [Required]
        public int Telefono { get; set; }
    }
}
