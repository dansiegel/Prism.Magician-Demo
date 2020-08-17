using System;

using Android.App;
using Android.Runtime;

namespace MagicDemo.Droid
{
    [Application]
    public class MainApplication : Shiny.ShinyAndroidApplication<MainStartup>
    {
        public MainApplication(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
        {
        }
    }
}