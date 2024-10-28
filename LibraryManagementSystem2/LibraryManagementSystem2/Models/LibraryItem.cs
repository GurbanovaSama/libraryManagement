using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem2.Models
{
    public abstract class LibraryItem
    {
        public string Title { get; set; }
        public int? PublicationYear { get; set; }

        protected LibraryItem(string title, int? publicationYear)
        {
            Title = title ?? throw new ArgumentNullException(nameof(title) , "Title null ola bilmez ");
            PublicationYear = publicationYear;
        }

        public abstract void DisplayInfo();
    }
}
