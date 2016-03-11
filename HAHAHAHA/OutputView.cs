using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace HAHAHAHA
{
	partial class OutputView : UIViewController
	{
		public string Name;

		public OutputView (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			string outputString = "Thank You " + Name + " Your Joke was Very Funny";
			OutPutLabel.Text = outputString;
		}
			
	}
}
