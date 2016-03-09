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
	[Register ("FirstViewController")]
	partial class FirstViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton JokeButton { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel JokeLabel { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIPickerView JokePicker { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (JokeButton != null) {
				JokeButton.Dispose ();
				JokeButton = null;
			}
			if (JokeLabel != null) {
				JokeLabel.Dispose ();
				JokeLabel = null;
			}
			if (JokePicker != null) {
				JokePicker.Dispose ();
				JokePicker = null;
			}
		}
	}
}
