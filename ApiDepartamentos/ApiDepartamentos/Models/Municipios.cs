using System.ComponentModel.DataAnnotations;


namespace ApiDepartamentos.Models
{
    public class Municipios
    {
        [Key]
        public int IdMunicipio { get; set; }

        [Required]
        public string NombreDelMunicipio { get; set; }
        [Required]
        public int DistanciasALaCabeceraDelArbol { get; set; }
        [Required]
        public int CantidadPoblacional { get; set; }
        [Required]
        public string LugaresTuristicosMasVisitados { get; set; }
        [Required]
        public int IdDepartamento { get; set; }

    }
}
