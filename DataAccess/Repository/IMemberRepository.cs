using BusinessObject;
using System;
using System.Collections.Generic;

namespace DataAccess.Repository
{
    public interface IMemberRepository
    {
        public IEnumerable<MemberObject> GetMembers();
        public MemberObject GetMemberByID(int id);
        public void InsertMember(MemberObject mem);
        public void DeleteMember(int id);
        public void UpdateMember(MemberObject mem);
        public MemberObject GetMemberByEmail(string email);
        public List<MemberObject> GetMemberByIDAndEmail(int id, string email);
    }
}
