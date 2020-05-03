using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ExercicioEFCoreCodeFirst.PL;

namespace ExercicioEFCoreCodeFirst.BLL
{
    public interface DAOInterface
    {
        Task CreateAsync(Genre o);
        void DetailsAsync(int id);
        Genre EditAsync(int id);
        void EditAsyncGenre(Genre genre);
        Task<Genre> DeleteAsync(int id);
        Task<Genre> DeleteConfirmedAsync(int id);
    }
}