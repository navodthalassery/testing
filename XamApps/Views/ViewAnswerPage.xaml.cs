using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using XamApps.Models;
using XamApps.ViewModels;
using Xamarin.Forms;

namespace XamApps.Views
{
    public partial class ViewAnswerPage : ContentPage
    {
        public ViewAnswerPage(ObservableCollection<Answers> answers)
        {
            InitializeComponent();

            //BindingContext = new AnswerPageViewModel();
            var viewModel = (AnswerPageViewModel)BindingContext;

            viewModel.selectedAnswers(answers);
        }
    }
}
