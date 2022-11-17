using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
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

        public bool DeleteMember(Member member)
        {
            bool result = false;
            try
            {
                dbContext.Members.Remove(member);
                dbContext.SaveChanges();
                result = true;
            }
            catch (DbUpdateException due)
            {

            }
            return result;

        }

        public List<object> GetLoad()
        {
            List<object> result = new List<object>();
            var s = from mb in dbContext.Members
                    select new { mb.MemberId, mb.Email, mb.CompanyName, mb.City, mb.Country };
            foreach (var mb in s) result.Add(mb);
            return result;
        }

        public List<Member> GetMembers() => dbContext.Members.ToList();
    }
}
