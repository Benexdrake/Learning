using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS_SQL
{
    public class Person
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }

        public string LoadPersonInfo()
        {
            string info = $"ID: {ID}, Firstname: {FirstName} Lastname: {LastName} Email: {EmailAddress} Phone: {PhoneNumber}";
            return info;
        }
    }
}
