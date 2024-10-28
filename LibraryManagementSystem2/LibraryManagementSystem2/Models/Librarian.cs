using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem2.Models
{
    public class Librarian : Person
    {
        public DateTime HireDate { get; set; }
        public Librarian(int id, string name, DateTime hireDate) : base(name)
        {
            HireDate = hireDate;
            Id = id;
            Name = name;
        }
    }
}
