using LibraryManagementTask.Exceptions;
using LibraryManagementTask.Models;
using LibraryManagementTask.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace LibraryManagementTask.Services.Concretes
{
    public class LibrarianService : ILibrarianService
    {
        public static List<Librarian> Librarians;
        public LibrarianService()
        {
            Librarians = new List<Librarian>();
        }

        public void CreateLibrarian(Librarian librarian)
        {
            Librarians.Add(librarian);
        }

        public void DeleteLibrarian(int id, bool IsSoftDelete)
        {
            int index = -1;
            for(int i = 0; i < Librarians.Count; i++)
                {
                if (id == Librarians[i].Id)
                {
                    index = i;
                    break;
                }
            }

            if (index != -1)
            {
                if (IsSoftDelete)
                {
                }
                else
                {
                    Librarians.Remove(Librarians[index]);
                }
            }
            else
            {
                throw new Exception($"Librarians list daxilinde gonderilen id-e {id} uygun deyer tapimadi,bu sebebden Delete prosesi yekunlasmadi");
            }
        }

        public List<Librarian> GetAllLibrarians()
        {
            return Librarians;
        }

        public Librarian GetLibrarianById(int id)
        {
            int index = -1;
            for (int i = 0; i < Librarians.Count; i++)
            {
                if (id == Librarians[i].Id)
                {
                    index = i;
                    break;
                }
            }

            if (index != -1)
            {
                return Librarians[index];
            }
            else
            {
                throw new Exception($"Librarians list daxilinde gonderilen id-e {id} uygun deyer tapimadi,bu sebebden geriye deyer qaytarila bilmedi");
            }
        }
    }
}
