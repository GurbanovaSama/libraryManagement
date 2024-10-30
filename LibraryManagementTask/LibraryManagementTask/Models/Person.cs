using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementTask.Models
{
    public abstract class Person
    {
        private static int _counter;
        public int Id { get; set; }
        public string Name { get; set; }
        protected Person(string name)
        {
            _counter++;
            Id = _counter;
            Name = name;
        }
    }
}
