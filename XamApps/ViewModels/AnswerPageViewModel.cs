using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using XamApps.Models;
using Xamarin.Forms;

namespace XamApps.ViewModels
{
    public class AnswerPageViewModel: INotifyPropertyChanged
    {
        private ObservableCollection<Answers> _AnswersList;
        public AnswerPageViewModel()
        {

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

        public void selectedAnswers(ObservableCollection<Answers> answers)
        {
            if (answers != null)
            {
                AnswersSelected = answers;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
