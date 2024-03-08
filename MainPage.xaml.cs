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

        async void ShowPopupButton1_Clicked(object sender, EventArgs e)
        {
            TestPopup1 popup = new TestPopup1();
            Application.Current!.MainPage!.ShowPopup(popup);

            await popup.Load();

        }

        async void ShowPopupButton2_Clicked(object sender, EventArgs e)
        {
            TestPopup2 popup = new TestPopup2();
            Application.Current!.MainPage!.ShowPopup(popup);

            await popup.Load();

        }

        async void ShowPopupButton3_Clicked(object sender, EventArgs e)
        {
            TestPopup3 popup = new TestPopup3();
            Application.Current!.MainPage!.ShowPopup(popup);

            await popup.Load();

        }

        private async void ShowPopupButtonWorkaround_Clicked(object sender, EventArgs e)
        {
            TestPopupWorkaround popup = new TestPopupWorkaround();
            Application.Current!.MainPage!.ShowPopup(popup);

            await popup.Load();
        }


        private async void ShowPopupButton2Workaround_Clicked(object sender, EventArgs e)
        {
            TestPopup2workaround popup = new TestPopup2workaround();
            Application.Current!.MainPage!.ShowPopup(popup);

            await popup.Load();
        }

        private async void ShowPopupButton3Workaround_Clicked(object sender, EventArgs e)
        {
            TestPopup3workaround popup = new TestPopup3workaround();
            Application.Current!.MainPage!.ShowPopup(popup);

            await popup.Load();
        }
    }

}