using WarrantyTracker.Pages;

namespace WarrantyTracker
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
        {
            Shell.Current.GoToAsync(nameof(DetailsPage)); // Switch between views
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Shell.Current.GoToAsync(nameof(EditorPage));
        }
    }
}
