using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using UIKit;

namespace AppCenterXFDemo.iOS
{
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            AppCenter.LogLevel = LogLevel.Debug;

            //AppCenter.Start("",typeof(Analytics), typeof(Crashes));

            global::Xamarin.Forms.Forms.Init();

            LoadApplication(new App());

            return base.FinishedLaunching(app, options);
        }
    }
}
