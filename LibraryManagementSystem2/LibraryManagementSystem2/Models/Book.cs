using LibraryManagementSystem2.ENUM;
using LibraryManagementSystem2.STRUCT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem2.Models
{
    public class Book : LibraryItem
    {
        public BookGenre Genre { get; set; }    
        public LibraryLocation Location { get; set; }
        public Book(string title, int? publicationYear,LibraryLocation location, BookGenre genre) : base(title, publicationYear)
        {
            Genre = genre;
            Location = location;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Book: {Title}, Genre: {Genre},Location: {Location} ,Year: {PublicationYear}");   
        }
    }
}
