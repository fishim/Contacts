﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Maui.Models
{
    public static class ContactRepository
    {
        public static List<Contact> _contacts = new List<Contact>()
        {
            new Contact() { ContactId = 1, Name = "Карась Максим", Email ="someone@gmail.com" },
            new Contact() { ContactId = 2, Name = "Карась Олена", Email ="someone@gmail.com" },
        };

        public static List<Contact> GetContacts() => _contacts;

        public static Contact GetContactById(int contactId)
        {
            return _contacts.FirstOrDefault(x => x.ContactId == contactId);
        }
    }
}
