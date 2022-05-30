using System;
using System.Collections.ObjectModel;

namespace S22Week3and4
{
    public class ContactCollection
    {
       public ObservableCollection<Contact> contacts { get; set; }

       public ContactCollection() {
         contacts = new ObservableCollection<Contact>();

        }

        public void addNewContact(Contact c)
        {
            contacts.Add(c);// in real apps, we have to save this Contact someware
        }

        public void deleteContact(Contact c)
        {
            contacts.Remove(c);// in real apps, we have to save this Contact someware
        }
    }
}
