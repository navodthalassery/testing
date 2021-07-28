using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using XamApps.Models;
using XamApps.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamApps.Views.Partials
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public class AnswerPartial : ContentView
    {
        //public List<T> QuestionDataList { get; set; }
        public static readonly BindableProperty QuestionDataListProperty =
            BindableProperty.Create(
                nameof(QuestionDataList),
                typeof(ObservableCollection<Questions>),
                typeof(AnswerPartial),
                defaultValue: null,
                defaultBindingMode: BindingMode.OneWay,
                propertyChanged: QuestionDataListChangedProperty);

        private static void QuestionDataListChangedProperty(BindableObject bindable,
            object oldValue, object newValue)
        {
            var control = (AnswerPartial)bindable;
            var list = (ObservableCollection<Questions>) newValue;
            //control.listView. = list;
            AnswerPartial answerPartial = new AnswerPartial();
            Task.Run(() => control.listViewDatabind(list));
            //Task.Run(() => answerPartial.ChangeView(list));

        }

        public ObservableCollection<Questions> QuestionDataList
        {
            get => (ObservableCollection<Questions>)GetValue(QuestionDataListProperty);
            set => SetValue(QuestionDataListProperty, value);
        }

        internal AnswerPartial()
        {
        }

        public void listViewDatabind(ObservableCollection<Questions> QuestionList1)
        {
            var listView = new ListView() { HasUnevenRows=true,HeightRequest=50 };
            listView.ItemTemplate = new DataTemplate(typeof(Label));
            //var list1 = new ObservableCollection<Questions>() {
            //    new Answers() {
            //        Akey = "1",
            //        Adesc = "sample"
            //    }
            //};
            var list1 = new List<Label>() {
                new Label() {
                    Text = "1",
                },
                new Label() {
                    Text = "2",
                }
            };
            listView.ItemsSource = list1;

            Content = new StackLayout()
            {
                Padding = new Thickness(0, 20, 0, 0),
                Children =
                {
                    new Label
                    {
                        Text = "Sample12345",
                        FontAttributes = FontAttributes.Bold,
                        HorizontalOptions = LayoutOptions.Center
                    },
                    //listView
                }
            };
        }
    }
}

