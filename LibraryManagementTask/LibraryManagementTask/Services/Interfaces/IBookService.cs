using LibraryManagementTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementTask.Services.Interfaces
{
    public interface IBookService
    {
        Book GetBookById(int id);
        List<Book> GetAllBooks();
        void CreateBook(Book book);
        void DeleteBOok(int id, bool IsSoftDelete);
    }
}
