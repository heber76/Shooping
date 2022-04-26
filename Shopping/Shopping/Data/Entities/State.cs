using System.ComponentModel.DataAnnotations;

namespace Shopping.Data.Entities
{
    public class State
    {

        public int Id { get; set; }


        [Required(ErrorMessage = "El campo {0} es obligarorio.")]
        [MaxLength(50, ErrorMessage = "El campo {0} debe tener máximo {1} caracteres.")]
        [Display(Name = "Estado")]
        public string Name { get; set; }


        public Country Country { get; set; }

        public ICollection<City> Cities { get; set; }

        [Display(Name = "Ciudades")]
        public  int CitiesNumber => Cities == null ? 0 :  Cities.Count;
    }
}
