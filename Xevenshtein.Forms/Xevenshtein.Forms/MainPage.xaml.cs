using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Xevenshtein.Forms
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void OnComputeButtonClicked(object sender, EventArgs e)
        {
            var resilt = Xevenshtein.Core.Levenshtein.Compute(FirstWordTextInput.Text, SecondWordTextInput.Text);
            ResultTextView.Text = resilt.ToString();
        }
    }
}
