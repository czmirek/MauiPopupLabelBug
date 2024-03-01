public static class Ext
{
    public static double GetWidthDpi(this IDeviceDisplay deviceDisplay)
    {
        return deviceDisplay.MainDisplayInfo.Width / deviceDisplay.MainDisplayInfo.Density;
    }
}