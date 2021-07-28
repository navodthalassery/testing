using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using XamApps.Models;
using Xamarin.Forms;

namespace XamApps.Views.Partials
{
    public partial class AnswerPartial1 : ContentView
    {
        public AnswerPartial1()
        {
            InitializeComponent();

            
        }

        public static readonly BindableProperty QuestionDataListProperty =
            BindableProperty.Create(
                nameof(QuestionDataList),
                typeof(ObservableCollection<Questions>),
                typeof(AnswerPartial1),
                defaultValue: null,
                defaultBindingMode: BindingMode.Default,
                propertyChanged: QuestionDataListChangedProperty);

        public static readonly BindableProperty QIdProperty =
            BindableProperty.Create(
                nameof(QId),
                typeof(int),
                typeof(AnswerPartial1),
                defaultValue: null,
                defaultBindingMode: BindingMode.Default,
                propertyChanged: QIdChangedProperty);

        private static void QuestionDataListChangedProperty(BindableObject bindable,
            object oldValue, object newValue)
        {
            var viewControl = (AnswerPartial1)bindable;
            var list = (ObservableCollection<Questions>)newValue;
            //control.listView. = list;
            if (viewControl != null)
            {
                viewControl.QuestionDataList1 = list;
                //viewControl.listViewDatabind();
            }
        }

        private static void QIdChangedProperty(BindableObject bindable,
            object oldValue, object newValue)
        {
            var viewControl = (AnswerPartial1)bindable;
            var id = (int)newValue;
            //control.listView. = list;
            if (viewControl != null)
            {
                viewControl.QId1 = id;
                viewControl.listViewDatabind();
            }
        }

        public ObservableCollection<Questions> QuestionDataList
        {
            get => (ObservableCollection<Questions>)GetValue(QuestionDataListProperty);
            set => SetValue(QuestionDataListProperty, value);
        }

        public int QId
        {
            get => (int)GetValue(QIdProperty);
            set => SetValue(QIdProperty, value);
        }

        public ObservableCollection<Questions> QuestionDataList1 { get; set; }
        public int QId1 {  get; set; }

        public void listViewDatabind()
        {
            ListView listView = new ListView();
            listView.ItemsSource = QuestionDataList1[QId1-1].AnswerList;
            listView.ItemTemplate = new DataTemplate(typeof(ViewCell));
            listView.ItemTemplate.SetBinding(TextCell.TextProperty, "Adesc");
            listView.ItemTemplate.SetBinding(TextCell.DetailProperty, "Adesc");

            //listView.Header = new StackLayout {
            //    Padding = new Thickness(5, 10, 5, 0),
            //    BackgroundColor = Color.FromHex("#cccccc"),
            //    Children = {
            //        new Label { Text="Header" },
            //        new Label { Text="Subhead", FontSize = Device.GetNamedSize(NamedSize.Small, typeof(Label)) }
            //    }
            //};

            //listView.Footer = new Label { Text = "Footer" };

            #region children add to content
            this.mainView.Content = new StackLayout()
            {
                Padding = new Thickness(0, 20, 0, 0),
                Children =
                {
                    //new Label
                    //{
                    //    Text = "Navod",
                    //    FontAttributes = FontAttributes.Bold,
                    //    HorizontalOptions = LayoutOptions.Center,
                    //    BackgroundColor = Color.Red
                    //},
                    listView
                }
            };
            #endregion
        }
    }
}
