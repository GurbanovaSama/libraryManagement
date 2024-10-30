using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementTask.Exceptions
{
    public class LibraryItemException : Exception
    {
        public LibraryItemException() : base("There is a library item exception")
        {
            
        }
        public LibraryItemException(string message) : base(message)
        {

        }
        
            
        }
    }

