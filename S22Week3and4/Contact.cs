using System;
namespace S22Week3and4
{
    public class Contact
    {
       public string fullname { get; set; }
       public string imageURL { get; set; }
        
        public Contact(string fn, string iURL)
        {
            fullname = fn;
            imageURL = iURL;
        }
    }
}
