using System.ComponentModel.DataAnnotations;

namespace practica2.Models
{
    public class Formulario
    {

        public int Id { get; set; }
        [Required]
        public string NombreCompleto { get; set; }

        [Required]
        public string Asunto { get; set; }

        [Required]
        public string Mensaje { get; set; }

    }

}