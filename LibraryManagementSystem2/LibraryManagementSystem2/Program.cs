using LibraryManagementSystem2.INTERFACE;

namespace LibraryManagementSystem2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ILibrarianService librarianService = new LibrarianService();

            Console.WriteLine("KItbaxanacilarin hamisi");
            foreach(var librarian in librarianService.GetAllLibrarians())
            {
                Console.WriteLine($"Id:{librarian.Id}, Name:{librarian.Name}, Hire Date: {librarian.HireDate}");
            }


            
        }
    }
}
