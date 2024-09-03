using System;
using System.Threading.Tasks;

namespace project_interview_task.Interfaces
{
    public interface IMessageService
    {
        Task ShowAsync(string title, string message, string cancel);
    }
}
