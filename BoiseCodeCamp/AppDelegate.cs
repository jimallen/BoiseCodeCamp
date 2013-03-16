using System;
using System.Collections.Generic;
using System.Linq;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace BoiseCodeCamp
{
    [Register("AppDelegate")]
    public partial class AppDelegate : UIApplicationDelegate
    {
        UIWindow window;
        MyViewController viewController;
		TaskViewController taskViewController;
		UINavigationController _navController;

        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            window = new UIWindow(UIScreen.MainScreen.Bounds);

			// make the window visible
			window.MakeKeyAndVisible ();
			
			// create our nav controller
			this._navController = new UINavigationController ();


            //viewController = new MyViewController();
			taskViewController = new TaskViewController ();
			// push the view controller onto the nav controller and show the window
			this._navController.PushViewController(this.taskViewController, false);
			window.RootViewController = this._navController;
			window.MakeKeyAndVisible ();

            window.MakeKeyAndVisible();

            return true;
        }
    }
}

