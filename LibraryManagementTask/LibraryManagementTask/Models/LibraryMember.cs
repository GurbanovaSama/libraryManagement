using LibraryManagementTask.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementTask.Models
{
    public sealed class LibraryMember : Person
    {
        public DateTime MembershipDate { get; set; }
        public LibraryMemberStatusEnum LibraryMemberStatus { get; internal set; }

        public LibraryMember( string name) : base(name)
        {
        }
    }
}
