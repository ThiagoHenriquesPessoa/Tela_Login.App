using Tela_Login.Data;
using Tela_Login.Model;
using Tela_Login.Pages;

namespace Tela_Login;

public partial class App : Application
{
	static SQLiteData _bancoDados;
	public static SQLiteData BancoDados
	{
		get
		{
			if (_bancoDados == null)
			{
				_bancoDados = new SQLiteData(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Dados.db3"));

                //_bancoDados = new SQLiteData(DependencyService.Get<ISQLiteDB>().SQLiteLocalPath("Dados.db3"));	
			}
            return _bancoDados;
        }
	}
	public static Usuario Usuario { get; set; }
	public App()
	{
		InitializeComponent();

		MainPage = new NavigationPage(new LoginUsuarioPage());
	}
}
