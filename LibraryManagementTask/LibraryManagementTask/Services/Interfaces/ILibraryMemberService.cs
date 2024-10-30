using LibraryManagementTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementTask.Services.Interfaces
{
    public interface ILibraryMemberService
    {
        LibraryMember GetLibraryMemberById(int id);
        List<LibraryMember> GetAllLibraryMembers();
        void CreateLibraryMember(LibraryMember libraryMember);
        void DeleteLibraryMember(int id, bool IsSoftDelete);
    }
}
