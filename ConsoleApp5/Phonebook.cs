using ConsoleApp5.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class Phonebook : Contact, ContactAdd, DeleteContact, ShowInfo, SearchForContact, ShowOne, SearchByKey
    {
        public List<Contact> contacts;
        public Phonebook()  { contacts = new List<Contact>(); }

        public void AddContact(Contact n){ contacts.Add(n); }

        public void DeleteContact(Contact n){ contacts.Remove(n); }

        public Contact Search(String n)
        {
            foreach (Contact c in contacts)
            {
                if (c.id == n || c.phoneNumber == n || c.adress == n || c.email == n || c.name == n) return c;
            }
            return null;
        }

        public void ShowOne(Contact c)
        {
            Console.WriteLine($"ID: {c.id}\nName: {c.name}\nPhone number: {c.phoneNumber}\nE-mail: {c.email}\nAdress: {c.adress}\n\n");
        }
        public void Show()
        {
            foreach (Contact c in contacts)
            {
                ShowOne(c);
            }
        }

        public Contact SearchByKey(String key, List<Contact> list)
        {
            foreach (Contact c in list)
            {
                if (c.id == key || c.name == key) return c;
            }
            return null;
        }
    }
}
