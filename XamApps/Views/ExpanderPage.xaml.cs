using System;
using System.Collections.Generic;
using XamApps.ViewModels;
using Xamarin.Forms;

namespace XamApps.Views
{
    public partial class ExpanderPage : ContentPage
    {
        public ExpanderPage()
        {
            InitializeComponent();

            BindingContext = new ExpanderViewModel();
        }
    }
}
