using LibraryManagementSystem2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem2.INTERFACE
{
    public class LibrarianService : ILibrarianService
    {
        private Librarian[] librarians;
        private int count;

        public LibrarianService(int capacity)
        {
            librarians = new Librarian[capacity];
            count = 0;  
        }


        public Librarian GetLibrarianById(int id)
        {
            for (int i = 0; i < count; i++)
            {
                if(librarians[i].Id == id)
                {
                    return librarians[i];
                }
            }
            return null;
        }

        public Librarian[] GetAllLibrarians()
        {
            Librarian[] result = new Librarian[count];
            Array.Copy(librarians, result, count);  
            return result;  
        }

        public void CreateLibrarian(Librarian librarian)
        {
            if (count < librarians.Length)
            {
                librarians[count] = librarian;
                count++;
            }
            else
            {
                throw new InvalidOperationException("array doludur");
            }
        }

        public void DeleteLibrarian(Librarian librarian, bool isSoftDelete)
        {
            for (int i = 0;i < count;i++)
            {
                if (librarians[i].Id ==  librarian.Id)
                {
                    if (isSoftDelete)
                    {
                        librarians[i] = null;
                    }
                    else
                    {
                        for (int j = 0;j < count -1; j++)
                        {
                            librarians[j] = librarians[j + 1];
                        }
                        librarians[count - 1] = null;
                        count--;
                    }
                    return;
                }
            }
        }
    }
}
