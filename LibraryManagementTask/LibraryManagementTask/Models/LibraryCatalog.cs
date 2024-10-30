using LibraryManagementTask.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementTask.Models
{
    public class LibraryCatalog
    {
        public List<Book> Books { get; set; }

        public Book this[int id] 
        {
            get { 
              
                int index = -1;
                for (int i = 0; i < Books.Count; i++)
                {
                    if ( id == Books[i].Id )
                    {
                      index = i;
                      break;
                    }
                }
                if ( index != -1)
                {
                    return Books[index];
                }
                else
                {
                    throw new LibraryItemException($"Kataloqda gonderilen id-e {id} uygun deyer tapimadi");
                }
            }  
        }

        public LibraryCatalog(List<Book> books)
        {
            Books = books;
        }
    }
}
