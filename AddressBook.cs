using System;
using System.Collections.Generic;

namespace Address_book{
    class AddressBook{
    private List<Contact> contacts=new List<Contact>();
    public void AddContact(Contact contact){
        contacts.Add(contact);
    }
    public Contact GetByEmail(string email){
        foreach(Contact contact in contacts){
            if(email==contact.Email){
                return contact;
            }
        }
        return null;
    }
}
}