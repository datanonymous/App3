using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App3
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
            slider.Value = 0.5;

            if (Device.OS == TargetPlatform.iOS)
            {
                Padding = new Thickness(0, 20, 0, 0);   //Left, top, right, bottom
            }
        }

        

        
    }
}
