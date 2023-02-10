using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace ProyectoFinal.Data
{
    public class HistorialCartones
    {
        [DisplayFormat(DataFormatString = "dd/MM/yyyy HH:mm:ss", ApplyFormatInEditMode = true)]
        [Required]
        [Key]
        public DateTime FechaHora { get; set; }
        [Range(1, 4), AllowNull]
        public int? Carton1 { get; set; }
        [Range(1, 4), AllowNull]
        public int? Carton2 { get; set; }
        [Range(1, 4), AllowNull]
        public int? Carton3 { get; set; }
        [Range(1, 4), AllowNull]
        public int? Carton4 { get; set; }
    }
}
