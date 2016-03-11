﻿using System;

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


		public nint GetRowsInComponent (UIPickerView pickerView, nint component)
		{
			return JokeCategories.Length;
		}

		public nint GetComponentCount (UIPickerView pickerView)
		{
			return 1;
		}

		partial void JokeButton_TouchUpInside (UIButton sender)
		{
			nint row = JokePicker.SelectedRowInComponent(0);
			Random r = new Random();
			JokesClass Jokes = new JokesClass();

			switch(row)
			{
				case 0:
				JokeLabel.Text = Jokes.AnimalJoke(r.Next(5));
				break;
				case 1:
				JokeLabel.Text = Jokes.BlondeJoke(r.Next(5));
				break;
				case 2:
				JokeLabel.Text = Jokes.RoadJoke(r.Next(5));
				break;
				case 3:
				JokeLabel.Text = Jokes.DarkJoke(r.Next(5));
				break;
				case 4:
				JokeLabel.Text = Jokes.FatJoke(r.Next(5));
				break;
				case 5:
				JokeLabel.Text = Jokes.GrossJoke(r.Next(5));
				break;
				case 6:
				JokeLabel.Text = Jokes.InsultsJoke(r.Next(5));
				break;
				case 7:
				JokeLabel.Text = Jokes.MarriageJoke(r.Next(5));
				break;
				case 8:
				JokeLabel.Text = Jokes.PickUpJoke(r.Next(5));
				break;
				case 9:
				JokeLabel.Text = Jokes.SchoolJoke(r.Next(5));
				break;
				case 10:
				JokeLabel.Text = Jokes.TechJoke(r.Next(5));
				break;
				case 11:
				JokeLabel.Text = Jokes.WorkJoke(r.Next(5));
				break;
				case 12:
				JokeLabel.Text = Jokes.MamaJoke(r.Next(5));
				break;
				default:
				JokeLabel.Text = "Please Pick a Category";
				break;

			}

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

