using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using XamApps.Models;
using XamApps.Services;
using XamApps.Views;
using Xamarin.CommunityToolkit.Extensions;
using Xamarin.CommunityToolkit.UI.Views;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace XamApps.ViewModels
{
    public class QuestionPageViewModels: INotifyPropertyChanged
    {
        private ObservableCollection<Questions> _QuestionList;
        private ObservableCollection<Answers> _AnswersList;
        QuestionairService questionairService;

        public QuestionPageViewModels()
        {
            questionairService = new QuestionairService();
            getServiceQuestion();

            SaveCommand = new Command(() =>
            {
                // on save time
                App.Current.MainPage.Navigation.PushAsync(new ViewAnswerPage(AnswersSelected));
                //Shell.Current.GoToAsync(nameof(ViewAnswerPage));
            });
        }

        public void getServiceQuestion()
        {
            //QuestionList = await questionairService.GetQuestionListsAsync();
            QuestionList = questionairService.GetQuestionListsAsync1();

        }

        public ObservableCollection<Questions> QuestionList
        {
            get => _QuestionList;
            set
            {
                Console.WriteLine("QuestionList", _QuestionList);
                MainThread.BeginInvokeOnMainThread(() => {
                    //Application.Current.MainPage.DisplayToastAsync("","");
                });
                
                if (value == _QuestionList) return;
                _QuestionList = value;
                OnPropertyChanged();
            }
        }

        public ObservableCollection<Answers> AnswersSelected
        {
            get => _AnswersList;
            set
            {
                if (value == _AnswersList) return;
                _AnswersList = value;
                OnPropertyChanged();
            }
        }

        ObservableCollection<Answers> answers1 = new ObservableCollection<Answers>();
        public void selectedAnswers(Answers answers)
        {
            //QuestionList.ToList().ForEach(m=>m.AnswerList.ToList().Where(p=>p.Akey == answers.Akey);
            var list = QuestionList.Where(x => x.AnswerList.Any(y => y.Akey == answers.Akey)).ToList();
            //for (int i = 0; i < list[0].AnswerList.Count; i++)
            //{
            //    var data = list[0].AnswerList.Where();
            //}
            //QuestionList.ToList().ForEach(m => m.);
            //var list = QuestionList.ToList().ForEach(m => m.);
            answers1.Add(answers);
            AnswersSelected = answers1;
        }

        //Command<SelectedItemChangedEventArgs> _listViewItemSelectedCommand;

        //public Command<SelectedItemChangedEventArgs> ListViewItemSelectedCommand => _listViewItemSelectedCommand ??
        //    (_listViewItemSelectedCommand = new Command<SelectedItemChangedEventArgs>(ExecuteListViewItemSelectedCommand));

        //void ExecuteListViewItemSelectedCommand(SelectedItemChangedEventArgs e)
        //{
        //    var item = e.SelectedItem as Questions;

        //    if (item?.Qkey != null)
        //    {
        //          QuestionSelectedList.Add(item);
        //    }
        //}

        public Command SaveCommand { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
