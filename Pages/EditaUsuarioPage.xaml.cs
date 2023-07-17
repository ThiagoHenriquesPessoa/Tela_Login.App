using Microsoft.Maui.ApplicationModel.Communication;
using Tela_Login.Data;
using Tela_Login.Model;

namespace Tela_Login.Pages;

public partial class EditaUsuarioPage : ContentPage
{
	Usuario _usuario;
	public EditaUsuarioPage()
	{
		InitializeComponent();
		_usuario = new Usuario();
		this.BindingContext = _usuario;
	}

    private async void btnCadastrar_Clicked(object sender, EventArgs e)
    {
		if (string.IsNullOrWhiteSpace(_usuario.Email) && string.IsNullOrWhiteSpace(_usuario.Senha))
		{
			await DisplayAlert("Atenção", "Preencha todas as informações", "Fechar");
			return;
		}
		var cadastro = await SQLiteData.BancoDados.CreateTableAsync<Usuario>();
		//if (cadastro>0)
  //      {
  //          await Navigation.PopAsync();
		//}
		var usuario = new Usuario 
		{ 
			Email = _usuario.Email, 
			Senha = _usuario.Senha 
		};
        await new UsuarioData(SQLiteData.BancoDados).SalvaUsuarios(usuario);
    }

    private async void btnVoltar_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}