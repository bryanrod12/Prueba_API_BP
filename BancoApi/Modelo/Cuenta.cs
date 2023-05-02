using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoApi.Modelo
{
    public class Cuenta
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CuentaID { get; set; }
        [Required]
        public int N_Cuenta { get; set; }
        [Required]
        public string Tipo { get; set; }
        [Required]
        public int Saldo_Inicial { get; set; }
        [Required]
        public bool Estado { get; set; }
        [ForeignKey("ClienteID")]
        public int ClienteID { get; set; }
    }
}
