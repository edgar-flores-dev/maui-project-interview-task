using project_interview_task.ViewModels;

namespace project_interview_task.Views
{
    public partial class RotateView : ContentPage
    {
        public RotateView()
        {
            InitializeComponent();
            BindingContext = new RotateViewModel();
        }
    }
}
