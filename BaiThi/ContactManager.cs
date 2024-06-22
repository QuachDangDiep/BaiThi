using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BaiThi
{
    public class ContactManager
    {
          private Dictionary<string, Contact> contacts;

    public ContactManager()
    {
        contacts = new Dictionary<string, Contact>();
    }

    public void AddContact(string name, string phone)
    {
        Contact newContact = new Contact(name, phone);
        contacts[name] = newContact;
        Console.WriteLine("Contact added successfully.");
    }

    public void FindContact(string name)
    {
        if (contacts.ContainsKey(name))
        {
            Contact contact = contacts[name];
            Console.WriteLine($"Name: {contact.Name}");
            Console.WriteLine($"Phone: {contact.Phone}");
        }
        else
        {
            Console.WriteLine("Contact not found.");
        }
    }

    public void DisplayContacts()
    {
        Console.WriteLine("Address Book");
        Console.WriteLine("Contact Name\tPhone number");
        foreach (var contact in contacts.Values)
        {
            Console.WriteLine($"{contact.Name}\t\t{contact.Phone}");
        }
    }
    }
}