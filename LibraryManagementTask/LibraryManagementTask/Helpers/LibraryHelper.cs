using LibraryManagementTask.Exceptions;
using LibraryManagementTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementTask.Helpers
{
    public static class LibraryHelper
    {
        public static int CalculateAge(this LibraryItem libraryItem)
        {
            if(libraryItem.PublicationYear == null)
            {
                throw new LibraryItemException("Publication Year is null");
            }
            int age = DateTime.Now.Year - libraryItem.PublicationYear.Value;
            return age;
        }

        public static string ToTitleCase(this LibraryItem libraryItem)
        {
            string str = libraryItem.Title[0].ToString().ToUpper() + libraryItem.Title.Substring(1).ToLower();
            return str;
        }
    }
}
