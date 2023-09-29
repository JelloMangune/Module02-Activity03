using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PDC60Module02
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void ClickedMVM(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new View.Page1());
        }

        private async void ClickedGestureText(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new View.Gesture.gesture());
        }

        private async void ClickedGestureImage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new View.Gesture.gesture_image());
        }
        private async void ClickedCompass(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new View.Compass());
        }

    }
}

