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
	[Register ("SubmitView")]
	partial class SubmitView
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField JokeTB { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField NameTB { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton SubButton { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (JokeTB != null) {
				JokeTB.Dispose ();
				JokeTB = null;
			}
			if (NameTB != null) {
				NameTB.Dispose ();
				NameTB = null;
			}
			if (SubButton != null) {
				SubButton.Dispose ();
				SubButton = null;
			}
		}
	}
}
