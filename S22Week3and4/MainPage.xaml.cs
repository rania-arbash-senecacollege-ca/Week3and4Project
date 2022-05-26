using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace S22Week3and4
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            resulttext.Text = "";
        }

        void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            String num = ((Button)sender).Text;
            resulttext.Text += " "  + num;
        }
    }
}
