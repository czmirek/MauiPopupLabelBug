using CommunityToolkit.Maui.Views;

namespace MauiPopupTest
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        async void ShowPopupButton_Clicked(object sender, EventArgs e)
        {
            TestPopup popup = new TestPopup();
            Application.Current!.MainPage!.ShowPopup(popup);

            await popup.Load();
            
        }
    }

}