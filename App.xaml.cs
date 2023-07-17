using SQLite;
using Tela_Login.Data;
using Tela_Login.Model;
using Tela_Login.Pages;

namespace Tela_Login;

public partial class App : Application
{	
	public static Usuario Usuario { get; set; }
	public App()
	{
		InitializeComponent();

		MainPage = new NavigationPage(new LoginUsuarioPage());
	}
}
