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


        public List<Member> GetMembers() => dbContext.Members.ToList();

        public void Create(Member member)
        {
            if (member is not null)
            {
                dbContext.Add(member);
                dbContext.SaveChanges();
                  
            }
        }

        public void Update(Member member)
        {
            if (member is not null)
            {
                dbContext.Update(member);
                dbContext.SaveChanges();
            }
        }
    }
}
