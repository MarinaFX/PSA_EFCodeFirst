using ExercicioEFCoreCodeFirst.PL;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioEFCoreCodeFirst.BLL
{
    public class GenreDAO 
    {
        private readonly MovieContext context;

        public GenreDAO()
        {
            context = new MovieContext();
        }

        public async void CreateAsync(Genre genre)
        {
            context.Add(genre);
            await context.SaveChangesAsync();
        }

        public async System.Threading.Tasks.Task<Genre> DeleteAsync(int? id)
        {
            var genre = await context.Genres
                .FirstOrDefaultAsync(m => m.GenreID == id);
            return genre;
        }

        public async System.Threading.Tasks.Task DeleteConfirmedAsync(int? id)
        {
            var genre = await context.Genres.FindAsync(id);
            context.Genres.Remove(genre);
            await context.SaveChangesAsync();

        }

        public async System.Threading.Tasks.Task<Genre> DetailsAsync(int? id)
        {
            var genre = await context.Genres
                .FirstOrDefaultAsync(m => m.GenreID == id);
            return genre;
        }

        public async System.Threading.Tasks.Task<Genre> EditAsync(int? id)
        {
            var genre = await context.Genres.FindAsync(id);
            return genre;
        }

        public async System.Threading.Tasks.Task EditAsyncGenre(Genre genre)
        {
            context.Update(genre);
            await context.SaveChangesAsync();
        }

    }
}
