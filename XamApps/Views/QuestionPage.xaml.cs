using System;
using System.Collections.Generic;
using XamApps.Models;
using XamApps.ViewModels;
using Xamarin.Forms;

namespace XamApps.Views
{
    public partial class QuestionPage : ContentPage
    {
        
        public QuestionPage()
        {
            InitializeComponent();

            BindingContext = new QuestionPageViewModels();
            //ListPage.ItemSelected
        }

        void ListView_ItemSelected(System.Object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            var listView = (ListView)sender;
            var answer = listView.SelectedItem as Answers;

            if (answer == null)
                return;

            DisplayAlert("Selected ", answer.Adesc, "OK");

            var viewModel = (QuestionPageViewModels)BindingContext;

            viewModel.selectedAnswers(answer);
        }
    }
}
