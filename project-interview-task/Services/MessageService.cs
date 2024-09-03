using System;
using System.Threading.Tasks;
using project_interview_task.Interfaces;

namespace project_interview_task.Services
{
    public class MessageService: IMessageService
    {
        public async Task ShowAsync(string title, string message, string cancel)
        {
            await App.Current.MainPage.DisplayAlert(title, message, cancel);
        }
    }
}
