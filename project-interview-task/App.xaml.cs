namespace project_interview_task;

public partial class App : Application
{
	public App()
	{
		VersionTracking.Track();
		DependencyService.Register<Interfaces.IMessageService, Services.MessageService>();
		InitializeComponent();
		MainPage = new AppShell();
	}
}
