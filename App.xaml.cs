using Tela_Login.Pages;

namespace Tela_Login;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new NavigationPage(new LoginUsuarioPage());
	}
}
