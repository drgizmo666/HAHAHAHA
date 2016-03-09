using System;

using UIKit;

namespace HAHAHAHA
{
	public partial class FirstViewController : UIViewController, IUIPickerViewDataSource
	{
		public static string[] JokeCategories = {"Animal", "Blonde", "Cross the Road", 
													"Dark Humor", "Fat", "Gross", "Insults", 
														"Marriage", "Pick-up Lines", "School", 
															"Technology", "Work", "YO' Mama"};
		public FirstViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			// Perform any additional setup after loading the view, typically from a nib.
			//Fill the picker
			JokePicker.Delegate = new PickerViewDelegate();
			JokePicker.DataSource = this;
		}

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}

		public nint GetComponentCount (UIPickerView pickerView, nint component)
		{
			return 1;
		}

		public nint GetRowsInComponent (UIPickerView pickerView, nint component)
		{
			return JokeCategories.Length;
		}

		class PickerViewDelegate : UIPickerViewDelegate
		{
			public override string GetTitle(UIPickerView pview, nint row, nint component)
			{
				return FirstViewController.JokeCategories[row];
			}
		}
	}
}

