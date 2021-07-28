using System;
using System.Collections.ObjectModel;
using XamApps.Models;
using System.Threading.Tasks;

namespace XamApps.Services.Interfaces
{
    public interface IQuestionairServices
    {
        Task<ObservableCollection<Questions>> GetQuestionListsAsync();
        ObservableCollection<Questions> GetQuestionListsAsync1();
    }
}
