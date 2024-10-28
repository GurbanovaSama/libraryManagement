using LibraryManagementSystem2.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem2.Helpers
{
    public static class LibraryHelper
    {
        public static int CalculateAge(this LibraryItem item)
        {
            if (item.PublicationYear.HasValue )
            {
                return DateTime.Now.Year - item.PublicationYear.Value;
            }
            return 0;
           
        }

        public static string ToTitleCase(this LibraryItem item)
        {
            if (string.IsNullOrEmpty(item.Title))
            {
                return item.Title;
            }
            return null;
        }
    }
}
