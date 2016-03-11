using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace HAHAHAHA
{
	partial class SubmitView : UIViewController
	{

		public SubmitView (IntPtr handle) : base (handle)
		{
		}

		public override void PrepareForSegue (UIStoryboardSegue segue, NSObject sender)
		{
			base.PrepareForSegue (segue, sender);
		
			var OutputControler = segue.DestinationViewController as OutputView;

			if (OutputControler != null) {
				OutputControler.Name = NameTB.Text;
			}
		}


		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}
