using System.ComponentModel.DataAnnotations;

namespace practica2.Models
{
    public class Formulario
    {

        [Required]
        public string Nombre{ get; set; }

 [Required]
        public int Celular { get; set; }

 [Required]
        public string Comentario { get; set; }

    }

}