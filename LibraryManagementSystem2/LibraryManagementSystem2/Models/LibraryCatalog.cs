using LibraryManagementSystem2.EXCEPTIONS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem2.Models
{
    public class LibraryCatalog
    {
        private string[] books;

        public LibraryCatalog(string[] books)
        {
            this.books = books;
        }

        public int this[int id]
        {
            get
            {
                for (int i = 0; i < books.Length; i++)
                {
                    if (books[i].Id == id)
                    {
                        return i;
                    }
                    continue;
                }
                return -1;
            }
        }
    }
}
