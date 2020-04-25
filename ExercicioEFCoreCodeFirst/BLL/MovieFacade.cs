using ExercicioEFCoreCodeFirst.PL;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioEFCoreCodeFirst.BLL
{
    public class MovieFacade//genre
    {
        private readonly GenreDAO movieDAO;
        
        public MovieFacade()
        {
            movieDAO = new GenreDAO();
        }

        public void addGenre(Genre genre)
        {
            movieDAO.CreateAsync(genre);
        }

        public async System.Threading.Tasks.Task<Genre> editAsync(int? id)
        {
            var genre = await movieDAO.EditAsync(id);
            return genre;
        }

        public async System.Threading.Tasks.Task EditAsyncGenre(Genre genre)
        {
            await movieDAO.EditAsyncGenre(genre);
        }

        public async Task<Genre> DetailsAsync(int? id)
        {
            var genre = await movieDAO.DetailsAsync(id);
            return genre;
        }

        public async Task<Genre> DeleteAsync(int? id)
        {
            var genre = await movieDAO.DeleteAsync(id);
            return genre;
        }

        public async Task DeleteConfirmedAsync(int? id)
        {
            await movieDAO.DeleteConfirmedAsync(id);
        }
    }
}
