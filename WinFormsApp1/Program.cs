namespace WinFormsApp1;

static class Program
{
	/// <summary>
	///  The main entry point for the application.
	/// </summary>
	[STAThread]
	static void Main()
	{
		var cts = new CancellationTokenSource();
		var args = Environment.GetCommandLineArgs();

		ApplicationConfiguration.Initialize();
		Application.Run(new Form1());
		
		cts.Cancel();
	}
}