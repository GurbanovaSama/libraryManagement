using LibraryManagementTask.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementTask.Models
{
    public class Book : LibraryItem
    {
        private static int _counter;
        public int Id { get; set; } 
        public BookGenreEnum Genre { get; set; }
        public LibraryLocation LibraryLocation { get; set; }
        public BookStatusEnum BookStatus { get; internal set; }

        public Book(string title, int? publicationYear) : base(title, publicationYear)
        {
            _counter++;
            Id = _counter;  
        }

        
        public override void DisplayInfo()
        {
            Console.WriteLine();
        }
    }
}
