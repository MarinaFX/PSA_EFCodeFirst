using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ExercicioEFCoreCodeFirst.PL
{
    public class Actor
    {
        [Display(Name = "Actor ID")]
        public int ActorId { get; set; }
        [Display(Name = "Actor Name")]
        [Required(ErrorMessage = "Name is required")]
        [StringLength(1000,
            MinimumLength = 0,
            ErrorMessage = "The name must not exceed 1000 characters")]
        public String Name { get; set; }
        [Display(Name = "Actor date birth")]
        public DateTime DateBirth { get; set; }

        public virtual ICollection<ActorMovie> Characters { get; set; }
    }
}
