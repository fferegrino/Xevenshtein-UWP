using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Xevenshtein
{
    public class App : Application
    {
        Button computeButton;
        Label firstStringLabel, secondStringLabel, computationResultLabel;
        Entry firstStringEntry, secondStringEntry;

        // Class constructor
        public App()
        {
            ContentPage xevenshteinMainPage = new ContentPage();
            StackLayout mainLayout = new StackLayout();
            // ... Above is the instatiation of mainLayout

            computeButton = new Button { Text = "Compute" };
            firstStringLabel = new Label { Text = "First string" };
            secondStringLabel = new Label { Text = "Second string" };
            computationResultLabel = new Label { Text = "No distance calculated yet" };
            firstStringEntry = new Entry();
            secondStringEntry = new Entry();
            // ... Above is the instatiation of secondStringEntry

            mainLayout.Children.Add(firstStringLabel);
            mainLayout.Children.Add(firstStringEntry);
            mainLayout.Children.Add(secondStringLabel);
            mainLayout.Children.Add(secondStringEntry);
            mainLayout.Children.Add(computeButton);
            mainLayout.Children.Add(computationResultLabel);
			computeButton.Clicked += ComputeButton_Clicked;

            xevenshteinMainPage.Content = mainLayout;
            MainPage = xevenshteinMainPage;


			computeButton.Clicked += ComputeButton_Clicked;
        }

        void ComputeButton_Clicked (object sender, EventArgs e)
		{
			string str1 = firstStringEntry.Text;
			string str2 = secondStringEntry.Text;
			int distance = Xevenshtein.Algorithm.LevenshteinDistance.Compute(str1, str2);
			computationResultLabel.Text = "Distance: " + distance;
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
