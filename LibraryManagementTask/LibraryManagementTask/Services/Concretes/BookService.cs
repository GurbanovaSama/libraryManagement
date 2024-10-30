using LibraryManagementTask.Models;
using LibraryManagementTask.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementTask.Services.Concretes
{
    public class BookService : IBookService
    {
        public static List<Book> Books;
        public BookService()
        {
            Books = new List<Book>();
        }

        public void CreateBook(Book book)
        {
            Books.Add(book);
        }

        public void DeleteBOok(int id, bool IsSoftDelete)
        {
            int index = -1;
            for (int i = 0; i < Books.Count; i++)
            {
                if (id == Books[i].Id)
                {
                    index = i;
                    break;
                }
            }

            if (index != -1)
            {
                if (IsSoftDelete)
                {
                    Books[index].BookStatus = Enums.BookStatusEnum.Removed;
                }
                else
                {

                    Books.Remove(Books[index]);
                }
            }
            else
            {
                throw new Exception($"Books list daxilinde gonderilen id-e({id}) uygun deyer tapilmadi, bu sebebden Delete prosesi yekunlasmadi");
            }
        }

        public List<Book> GetAllBooks()
        {
            return Books;
        }

        public Book GetBookById(int id)
        {
            int index = -1;
            for (int i = 0; i < Books.Count; i++)
            {
                if (id == Books[i].Id)
                {
                    index = i;
                    break;
                }
            }

            if (index != -1)
            {
                return Books[index];
            }
            else
            {
                throw new Exception($"Books list daxilinde gonderilen id-e({id}) uygun deyer tapilmadi, bu sebebden geriye deyer qaytarila bilmedi.");
            }
        }

      
    }
}
