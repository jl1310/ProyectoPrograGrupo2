using System.ComponentModel.DataAnnotations;

namespace ApiDepartamentos.Models
{
    public class Departamentos
    {
        [Key]
        public int IdDepartamento { get; set; }

        [Required]
        public string NombreDelDepartamento { get; set; }
        [Required]
        public int DistanciaQueExisteEntreCiudadCapital { get; set; }
        [Required]
        public int CantidadPoblacional { get; set; }
        [Required]
        public int CantidadDeMunicipios { get; set; }
        [Required]
        public string LugaresTuristicosMasVisitados { get; set; }


    }
}
