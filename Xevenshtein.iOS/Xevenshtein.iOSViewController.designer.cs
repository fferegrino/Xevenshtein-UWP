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

namespace Xevenshtein.iOS
{
	[Register ("Xevenshtein_iOSViewController")]
	partial class Xevenshtein_iOSViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton ComputeButton { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField FirstWordInputText { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel ResultLabel { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField SecondWordInputText { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (ComputeButton != null) {
				ComputeButton.Dispose ();
				ComputeButton = null;
			}
			if (FirstWordInputText != null) {
				FirstWordInputText.Dispose ();
				FirstWordInputText = null;
			}
			if (ResultLabel != null) {
				ResultLabel.Dispose ();
				ResultLabel = null;
			}
			if (SecondWordInputText != null) {
				SecondWordInputText.Dispose ();
				SecondWordInputText = null;
			}
		}
	}
}
