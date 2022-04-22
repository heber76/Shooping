using System.ComponentModel.DataAnnotations;

namespace Shopping.Data.Entities
{
    public class Country
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="El campo {0} es obligarorio.")]
        [MaxLength(50,ErrorMessage ="El campo {0} debe tener máximo {1} caracteres.")]
        [Display(Name ="País")]
        public string Name { get; set; }




    }
}
