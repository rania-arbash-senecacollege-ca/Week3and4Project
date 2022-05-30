using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace S22Week3and4
{
    public partial class AddNewContactPage : ContentPage
    {
        ContactCollection AddPageContactCollection;
        public AddNewContactPage(ContactCollection cc)
        {
            InitializeComponent();
            AddPageContactCollection = cc;
        }

        async void save_Clicked(System.Object sender, System.EventArgs e)
        {
            if (name.Text != null && numer.Text != null)
            {
                
                Contact c = new Contact(name.Text, numer.Text, "https://images.freeimages.com/images/small-previews/804/tubes-1252172.jpg");
                AddPageContactCollection.addNewContact(c);
                await Navigation.PopModalAsync();
            }
            else
                await DisplayAlert("Error", "Missing Info", "OK");


        }

       async void cancel_Clicked(System.Object sender, System.EventArgs e)
        {
           await Navigation.PopModalAsync();
        }
    }
}
