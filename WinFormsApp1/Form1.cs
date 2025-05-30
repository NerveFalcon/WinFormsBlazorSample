using Microsoft.AspNetCore.Components.WebView.WindowsForms;
using Microsoft.Extensions.DependencyInjection;
using WinFormsApp1.Pages;

namespace WinFormsApp1;

public partial class Form1 : Form
{
	public Form1()
	{
		InitializeComponent();
		
		var services = new ServiceCollection();
		services.AddWindowsFormsBlazorWebView();
		services.AddSingleton(this);
		// blazorWebView1.HostPage = "wwwroot/index.html";
		blazorWebView1.Services = services.BuildServiceProvider();
		blazorWebView1.RootComponents.Add<Counter>("#app");
	}

	public void SendMessage(string message)
	{
		MessageBox.Show(message);
	}
}