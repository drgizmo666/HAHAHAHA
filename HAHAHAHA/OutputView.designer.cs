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
	[Register ("OutputView")]
	partial class OutputView
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel OutPutLabel { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (OutPutLabel != null) {
				OutPutLabel.Dispose ();
				OutPutLabel = null;
			}
		}
	}
}
