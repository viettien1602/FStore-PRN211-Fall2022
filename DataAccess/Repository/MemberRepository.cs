using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class MemberRepository : IMemberRepository
    {
        private readonly FStoreDBContext dbContext;

        public MemberRepository()
        {
            dbContext = new FStoreDBContext();
        }
        public List<Member> GetMembers() => dbContext.Members.ToList();
    }
}
