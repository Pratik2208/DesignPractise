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

        private void Entry_Focused(object sender, FocusEventArgs e)
        {
            bemail.StrokeThickness = 6;
        }

        private void Entry_Focused_1(object sender, FocusEventArgs e)
        {
            
            bpassword.StrokeThickness = 6;  
        }

        private void Entry_Unfocused(object sender, FocusEventArgs e)
        {
            bemail.StrokeThickness = 3;
        }
        private void Entry_Unfocused_1(object sender, FocusEventArgs e)
        {
            bpassword.StrokeThickness=3;
        }
    }

}
