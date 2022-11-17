using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IMemberRepository
    {
        List<Member> GetMembers();
<<<<<<< HEAD
        void Create(Member member);
        void Update(Member member);
=======
        bool DeleteMember(Member member);
>>>>>>> feature/member-demo

    }
}
