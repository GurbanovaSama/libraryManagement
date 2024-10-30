using LibraryManagementTask.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementTask.Models
{
    public class Librarian : Person
    {
        public DateTime HireDate { get; set; }
        public LibrarianStatusEnum LibrarianStatus { get; set; }
        public Librarian(string name) : base(name)
        { 
            LibrarianStatus = LibrarianStatusEnum.Active;
        }
    }
}
