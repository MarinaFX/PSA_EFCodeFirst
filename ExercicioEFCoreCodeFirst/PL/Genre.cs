using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ExercicioEFCoreCodeFirst.PL
{
    public class Genre
    {
        
        public int GenreID { get; set; }

        [Display(Name = "Name")]
        [Required(ErrorMessage = "Name is required")]
        [StringLength (25, 
            MinimumLength =3,
            ErrorMessage = "The name must have between 3 and 25 characters")]
        public string Name { get; set; }

        [Display(Name = "Description")]
        [Required(ErrorMessage = "Description is required")]
        [StringLength(1000,
           MinimumLength = 50,
           ErrorMessage = "The description must have between 50 and 1000 characters")]
        public string Description { get; set; }
        public ICollection<Movie> Movies { get; set; }
    }
}
