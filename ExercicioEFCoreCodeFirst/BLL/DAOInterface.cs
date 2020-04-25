using System;
using System.Collections.Generic;
using System.Text;
using ExercicioEFCoreCodeFirst.PL;

namespace ExercicioEFCoreCodeFirst.BLL
{
    public interface DAOInterface
    {
        void CreateAsync(Genre o);
        void DetailsAsync(int id);
        Genre EditAsync(int id);
        void EditAsyncGenre(Genre genre);
        System.Threading.Tasks.Task<Genre> DeleteAsync(int id);
        System.Threading.Tasks.Task<Genre> DeleteConfirmedAsync(int id);
    }
}