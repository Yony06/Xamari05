namespace Xamari05
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        

        private void Button_Clicked(object sender, EventArgs e)
        {
            (sender as Button).Text = "presioname de nuevo";
        }
    }

}
