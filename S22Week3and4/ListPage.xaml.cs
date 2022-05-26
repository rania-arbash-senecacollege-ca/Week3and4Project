using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace S22Week3and4
{
  

    public partial class ListPage : ContentPage
    {

        public Collection<Contact> contacts = new Collection<Contact> {
            new Contact("Mary Lee", "https://images.freeimages.com/images/small-previews/25c/abstract-flowers-2-1199959.jpg"),
            new Contact("Jone Smith", "https://images.freeimages.com/images/small-previews/804/tubes-1252172.jpg"),
            new Contact("Tom Tery", "https://images.freeimages.com/images/small-previews/4d6/chugh-1171409.jpg"),
            new Contact("Rania ", "https://images.freeimages.com/images/small-previews/4d6/chugh-1171409.jpg")

        };

        public ListPage()
        {

            InitializeComponent();
            mylist.ItemsSource = contacts;
      
        }
    }
}
