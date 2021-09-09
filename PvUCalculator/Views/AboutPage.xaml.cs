using System;

using PvUCalculator.ViewModels;

using Windows.UI.Xaml.Controls;

namespace PvUCalculator.Views
{
    public sealed partial class AboutPage : Page
    {
        public AboutViewModel ViewModel { get; } = new AboutViewModel();

        public AboutPage()
        {
            InitializeComponent();
        }
    }
}
