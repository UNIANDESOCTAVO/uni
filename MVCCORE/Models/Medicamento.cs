using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace MVCCORE.Models
{
    public class Medicamento
    {
        [Key]
        public int MedicamentoId { get; set; }
        [Required(ErrorMessage ="El nombre del medicamneto es requerido")]
        [Display(Name = "Nombre de Medicamento")]
        [StringLength(220,MinimumLength = 3, ErrorMessage = "El nombre del medicamento no esta dentro del rango 3 a 220")]
        public String Nombre_Medicamento { get; set; }
        [Required(ErrorMessage = "la fecha no es valida")]
        [Display(Name = "Fecha de expiracion")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0;yyyy-MM-dd}",ApplyFormatInEditMode = true)]
        public DataType Fech_Expira { get; set; }
        [Required(ErrorMessage = "la fecha no es valida")]
        [Display(Name = "Fecha de fabricasion")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0;yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime fecha_fabricado { get; set; }
        [Required(ErrorMessage = "la fecha no es valida")]
        [Display(Name = "Fecha de increso")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0;yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime fecha_Ingreso { get; set; }
    }
}
