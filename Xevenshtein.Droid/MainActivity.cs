using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Xevenshtein.Core;

namespace Xevenshtein.Droid
{
    [Activity(Label = "Xevenshtein for Android",
        MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        private Button computeButton;
        private EditText firstWordTextInput, secondWordTextInput;
        private TextView resultTextView;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            computeButton = FindViewById<Button>(Resource.Id.ComputeButton);
            firstWordTextInput = FindViewById<EditText>(Resource.Id.FirstWordTextInput);
            secondWordTextInput = FindViewById<EditText>(Resource.Id.SecondWordTextInput);
            resultTextView = FindViewById<TextView>(Resource.Id.ResultTextView);

            computeButton.Click += (s, a) =>
            {
                var resultado = Levenshtein.Compute(firstWordTextInput.Text, secondWordTextInput.Text);
                resultTextView.Text = resultado.ToString();
            };
        }
    }
}

