using CommunityToolkit.Mvvm.Input;

namespace DesignPractise.Pages
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
        {
            img2.IsVisible = false;
            img.IsVisible = true;
        }

        private void TapGestureRecognizer_Tapped_1(object sender, TappedEventArgs e)
        {
            img.IsVisible = false;
            img2.IsVisible = true;
        }
    }

}
