using LibraryManagementSystem2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem2.INTERFACE
{
    internal interface ILibrarianService
    {
        Librarian GetLibrarianById(int id);
        Librarian[] GetAllLibrarians();
        void CreateLibrarian(Librarian librarian);
        void DeleteLibrarian(Librarian librarian, bool isSoftDelete);
    }
}
