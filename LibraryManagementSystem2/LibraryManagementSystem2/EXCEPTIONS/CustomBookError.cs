using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem2.EXCEPTIONS
{
    public class CustomBookError: Exception
    {
        public CustomBookError(string message) : base(message) { }
    }
}
