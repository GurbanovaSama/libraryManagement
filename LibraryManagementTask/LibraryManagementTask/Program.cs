using LibraryManagementTask.Models;
using LibraryManagementTask.Services.Concretes;
using LibraryManagementTask.Services.Interfaces;

ILibrarianService service = new LibrarianService();
Librarian librarian = new Librarian("Xedice")
{
    HireDate = DateTime.Now,
};

service.CreateLibrarian(librarian);
try
{
    Librarian baseLibrarian = service.GetLibrarianById(1);
    service.DeleteLibrarian(1, true);
    Console.WriteLine(baseLibrarian.LibrarianStatus);

    List<Librarian> librarians = service.GetAllLibrarians();
    foreach (var item in librarians)
    {
        Console.WriteLine(item.Name);
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}



