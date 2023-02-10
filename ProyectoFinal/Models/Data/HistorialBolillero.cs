using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace ProyectoFinal.Data
{
    public class HistorialBolillero
    {
        [DisplayFormat(DataFormatString = "dd/MM/yyyy HH:mm:ss", ApplyFormatInEditMode = true)]
        [Required]
        [Key]
        public DateTime FechaHora { get; set; }

        [Range(1, 90)]
        [Required]
        public int NumeroBolilla { get; set; }
    }
}
