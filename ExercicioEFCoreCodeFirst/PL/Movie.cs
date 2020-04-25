using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioEFCoreCodeFirst.PL
{
    public class Movie
    {
        public string Title { get; set; }
        public string Director { get; set; }
        public DateTime ReleaseDate { get; set; }
        public decimal Gross { get; set; }
        public double Rating { get; set; }

        public int MovieID { get; set; }

        public int GenreID { get; set; }
        public Genre Genre { get; set; }

        public virtual ICollection<ActorMovie> Characters { get; set; }
    }
}
