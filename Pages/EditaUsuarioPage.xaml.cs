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
		var cadastro = await App.BancoDados.UsusarioDatable.SalvaUsuarios(_usuario);
		if (cadastro>0)
		{
			await Navigation.PopAsync();
		}
    }

    private async void btnVoltar_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}