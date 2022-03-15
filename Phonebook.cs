using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneApp
{
    internal class Phonebook
    {
        private List<Entry> contacts; //declaration only

        public Phonebook()
        {
            contacts = new List<Entry>(); //allocate the memory, define it here.
        }
        public Phonebook(Phonebook book)
        {
            contacts = new List<Entry>(book.contacts); //it is a kind of copy from another book
        }
        public void addEntry(string name, string phoneNumber, string email = null,
            DateTime? dateOfBirth= null)
        {
            bool isEmailNull = (email == null) ? true : false;
            bool isDateOfBirthNull = (dateOfBirth == null) ? true : false;
            if (isEmailNull && isDateOfBirthNull)
                contacts.Add(new Entry(name, phoneNumber));
            else if (isEmailNull)
                contacts.Add(new Entry(name, phoneNumber, dateOfBirth));
            else if (isDateOfBirthNull)
                contacts.Add(new Entry(name, phoneNumber, email));
            else
                contacts.Add(new Entry(name, phoneNumber, email, dateOfBirth));
        }


    }
}
