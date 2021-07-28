using System;
using System.Collections.ObjectModel;
using System.Net.Http;
using XamApps.Models;
using XamApps.Services.Interfaces;
using System.Threading.Tasks;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;
using Xamarin.Forms;
using Xamarin.Essentials;
using System.Reflection;

namespace XamApps.Services
{
    public class Constants
    {
        public Constants()
        {
            //string documentBasePath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            Assembly assembly = Assembly.GetExecutingAssembly();
            TodoItemsUrl = assembly.GetManifestResourceStream("XamApps.Datas.QuestionJSON.json");
        }
        public Stream TodoItemsUrl { get; set; }
    }

    public class QuestionairService: IQuestionairServices
    {
        HttpClient client;
        public QuestionairService()
        {
            client = new HttpClient();
        }

        public async Task<ObservableCollection<Questions>> GetQuestionListsAsync()
        {
            var constants = new Constants();
            var QuestionList = new ObservableCollection<Questions>();
            //Uri uri = new Uri(string.Format(constants.TodoItemsUrl, string.Empty));
            using (var reader = new System.IO.StreamReader(constants.TodoItemsUrl))
            {
                var json = await reader.ReadToEndAsync();
                QuestionList = JsonConvert.DeserializeObject<ObservableCollection<Questions>>(json);
            }
            return QuestionList;
        }

        public ObservableCollection<Questions> GetQuestionListsAsync1()
        {
            List<Questions> questions = new List<Questions>();
            DataLists dataLists = new DataLists();

            questions = dataLists.GetJsonData();
            ObservableCollection<Questions> collection = new ObservableCollection<Questions>(questions);

            return collection;
        }
    }
}
