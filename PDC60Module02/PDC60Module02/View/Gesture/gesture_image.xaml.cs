using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PDC60Module02.View.Gesture
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class gesture_image : ContentPage
    {
        public gesture_image()
        {
            InitializeComponent();
        }
        async void OnCorrectDrop(object sender, DropEventArgs e)
        {
            await DisplayAlert("Correct", "You are right!", "OK");
        }
        void OnIncorrectDragOver(object sender, DragEventArgs e)
        {
            e.AcceptedOperation = DataPackageOperation.None;
        }
    }
}