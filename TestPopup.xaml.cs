using CommunityToolkit.Maui.Views;

namespace MauiPopupTest;

public partial class TestPopup : Popup
{
    public TestPopup()
    {
        InitializeComponent();
        RootBorder.WidthRequest = 0.9 * DeviceDisplay.Current.GetWidthDpi();
    }

    public async Task Load()
    {
        await Task.Delay(1000);
        
        LoadingActivityIndicator.IsRunning = false;
        LoadingActivityIndicator.IsVisible = false;

        LabelContent.Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Morbi lobortis leo id tortor dignissim, eu tincidunt neque viverra. Sed rutrum porttitor magna id dictum. Aliquam tincidunt vel neque non euismod. Vivamus elementum ante felis, in tempus tortor finibus ut. Nulla nulla massa, sollicitudin imperdiet nisl ac, consectetur varius dui. Suspendisse congue neque a pellentesque euismod. Nam non ultricies mi. Aenean sagittis risus nibh, ut iaculis ipsum iaculis dictum.";
    }
}

public static class Ext
{
    public static double GetWidthDpi(this IDeviceDisplay deviceDisplay)
    {
        return deviceDisplay.MainDisplayInfo.Width / deviceDisplay.MainDisplayInfo.Density;
    }
}