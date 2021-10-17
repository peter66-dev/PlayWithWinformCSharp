using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class MemberRepository : IMemberRepository
    {
        public void DeleteMember(int id) => MemberDAO.Instance.DeleteMember(id);
        public MemberObject GetMemberByEmail(string email) => MemberDAO.Instance.GetMemberByEmail(email);
        public MemberObject GetMemberByID(int id) => MemberDAO.Instance.GetMemberByID(id);
        public List<MemberObject> GetMemberByIDAndEmail(int id, string email) => MemberDAO.Instance.GetMemberByIDAndEmail(id, email);
        public IEnumerable<MemberObject> GetMembers() => MemberDAO.Instance.GetMemberList();
        public void InsertMember(MemberObject mem) => MemberDAO.Instance.InsertMember(mem);
        public void UpdateMember(MemberObject mem) => MemberDAO.Instance.UpdateMember(mem);
    }
}
