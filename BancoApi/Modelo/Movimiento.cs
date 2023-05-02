using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoApi.Modelo
{
    public class Movimiento
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MovimientoID { get; set; }

        [Required]
        public DateTime Fecha { get; set; }

        [Required]
        public string Tipo { get; set; }

        [Required]
        public int Valor { get; set; }

        [Required]
        public int Saldo { get; set; }

        [ForeignKey("CuentaID")]
        public int CuentaID { get; set; }
    }
}
