using project_interview_task.ViewModels;

namespace project_interview_task.Views
{
    public partial class UserDeviceInfoView : ContentPage
    {
        public UserDeviceInfoView()
        {
            InitializeComponent();
            BindingContext = new UserDeviceInfoViewModel();
        }
    }
}
