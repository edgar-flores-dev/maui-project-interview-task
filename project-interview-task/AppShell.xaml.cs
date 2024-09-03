using project_interview_task.ViewModels;
using project_interview_task.Views;

namespace project_interview_task;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		Routing.RegisterRoute(nameof(ModalView), typeof(ModalView));
	}
}
