using LibraryManagementTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementTask.Services.Interfaces
{
    public interface ILibrarianService
    {
        Librarian GetLibrarianById(int id);
        List<Librarian> GetAllLibrarians();
        void CreateLibrarian(Librarian librarian);
        void DeleteLibrarian(int id, bool IsSoftDelete);
    }
}
