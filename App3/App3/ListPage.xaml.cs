using App3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App3
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ListPage : ContentPage
	{
		public ListPage ()
		{
			InitializeComponent ();
            //var names = new List<string>
            //{
            //    "Alex",
            //    "Ashley",
            //    "Stitch",
            //    "Lola"
            //}; 
            //Ctrl+shift+L to delete line

            //https://stackoverflow.com/questions/50465009/embed-image-not-showing-in-xamarin-forms
            //https://developer.xamarin.com/samples/xamarin-forms/UserInterface/ListView/CustomCells/
            //https://docs.microsoft.com/en-us/xamarin/xamarin-forms/user-interface/images?tabs=windows#Embedded_Images
            listView.ItemsSource = new List<Contact>
            {
                new Contact { Name = "Alex", EmbeddedImage = "App3.Images.alex100.png", Status="App development" },
                new Contact { Name = "Ashley", EmbeddedImage = "App3.Images.ashley100.png", Status="Playing sims"},
                new Contact { Name = "Stitch", EmbeddedImage = "App3.Images.stitch100.png", Status="Pooping on floor"},
                new Contact { Name = "Lola", EmbeddedImage = "App3.Images.lola100.png", Status="Needy for attention"}
            };
		}
	}
}