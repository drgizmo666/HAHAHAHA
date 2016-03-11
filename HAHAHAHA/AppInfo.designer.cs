// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace HAHAHAHA
{
	[Register ("AppInfo")]
	partial class AppInfo
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel infoLabel { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (infoLabel != null) {
				infoLabel.Dispose ();
				infoLabel = null;
			}
		}
	}
}
