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
        private MemberRepository memberRepository;

        public MemberService()
        {
            memberRepository = new MemberRepository();
        }

        public List<Member> GetMembers() => memberRepository.GetMembers();

        public string GetEmailAdmin()
        {
            IConfiguration config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", true, true)
                .Build();
            var emailAdmin = config["defaultEmail"];
            return emailAdmin;
        }

        public void Create(Member member) => memberRepository.Create(member);
        public void Update(Member member) => memberRepository.Update(member);
    }
}
