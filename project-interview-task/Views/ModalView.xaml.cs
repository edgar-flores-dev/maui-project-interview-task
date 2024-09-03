using project_interview_task.ViewModels;
namespace project_interview_task.Views
{
    public partial class ModalView : ContentPage
    {
        public ModalView()
        {
            InitializeComponent();
            BindingContext = new ModalViewModel();
        }
    }
}
