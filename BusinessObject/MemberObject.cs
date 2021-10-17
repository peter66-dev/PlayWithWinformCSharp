using System;

namespace BusinessObject
{
    public class MemberObject
    {
        public int MemberID { get; set; }
        public string Email { get; set; }
        public string CompanyName { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public MemberObject()
        {
            MemberID = 0;
            Email = "";
            CompanyName = "";
            City = "";
            Country = "";
            Password = "";
            Role = "";
        }

        public MemberObject(int id, string email, string comName, string city, string country, string psw, string role)
        {
            MemberID = id;
            Email = email;
            CompanyName = comName;
            City = city;
            Country = country;
            Password = psw;
            Role = role;
        }
    }
}
