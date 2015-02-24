using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;
using System.Net.Http;
using System.Net;
using HttpRepro.PCL;
using HttpRepro.PCL49;

namespace HttpRepro
{
	// The UIApplicationDelegate for the application. This class is responsible for launching the
	// User Interface of the application, as well as listening (and optionally responding) to
	// application events from iOS.
	[Register ("AppDelegate")]
	public partial class AppDelegate : UIApplicationDelegate
	{
		// class-level declarations
		UIWindow window;
		HttpClient httpClient;
		//
		// This method is invoked when the application has loaded and is ready to run. In this
		// method you should instantiate the window, load the UI into it and then make the window
		// visible.
		//
		// You have 17 seconds to return from this method, or iOS will terminate your application.
		//
		public override bool FinishedLaunching (UIApplication app, NSDictionary options)
		{
			// create a new window instance based on the screen size
			window = new UIWindow (UIScreen.MainScreen.Bounds);
			
			// If you have defined a root view controller, set it here:
			// window.RootViewController = myViewController;

			var handler = new HttpClientHandler();
			if (handler.SupportsAutomaticDecompression)
			{
				handler.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
			}
			httpClient = new HttpClient(handler);

			var repro = new Repro ();

			var repro49 = new Repro49 ();

			// make the window visible
			window.MakeKeyAndVisible ();
			
			return true;
		}
	}
}

