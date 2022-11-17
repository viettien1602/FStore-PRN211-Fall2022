using DataAccess.Models;
using DataAccess.Repository;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject.Services
{
    public class MemberService
    {
        private MemberRepository _memberRepository;

        public MemberService()
        {
            _memberRepository = new MemberRepository();
        }

        public List<Member> GetMembers() => _memberRepository.GetMembers();

        public string GetEmailAdmin()
        {
            IConfiguration config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", true, true)
                .Build();
            var emailAdmin = config["defaultEmail"];
            return emailAdmin;
        }

        public bool DeleteMember(Member member) => _memberRepository.DeleteMember(member); 
    }
}
