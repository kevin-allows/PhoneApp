using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneApp
{
    internal class Entry
    {
        public string Name { get; private set; }
        public string PhoneNumber { get; private set; }
        public string Email { get; private set; }
        public DateTime? DateOfBirth { get; private set; }
        public Entry(string name, string phoneNumber)
        {
            Name = name;
            PhoneNumber = ConvertPhoneNumber.toHungarianFormat(phoneNumber);
        }
        public Entry(string name, string number, string email)
            : this(name, number)
        {
            Email = email;
        }
        public Entry(string name, string number, DateTime? dateOfBirth)
        : this(name, number)
        {
            DateOfBirth = dateOfBirth;
        }
        public Entry(string name, string number, string email, DateTime? dateOfBirth)
        : this(name, number, email)
        {
            DateOfBirth = dateOfBirth;
        }
    }
}
