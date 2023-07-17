using Tela_Login.Data;

namespace Tela_Login.Pages;

public partial class LoginUsuarioPage : ContentPage
{
	public LoginUsuarioPage()
	{
		InitializeComponent();
	}

    private void btnRegistrar_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new EditaUsuarioPage());
    }

    private async void btnEntrar_Clicked(object sender, EventArgs e)
    {
        string email = txtEmail.Text;
        string senha = txtSenha.Text;

        if (!string.IsNullOrWhiteSpace(email) && !string.IsNullOrWhiteSpace(senha))
        {
            var usuario = await new UsuarioData(SQLiteData.BancoDados).ObtemUsuario(email, senha);

            if (usuario == null)
            {
                await DisplayAlert("Atenção", "E-mail ou Senha invalidos", "Fechar");
                return;
            }
        }
        else
        {
            await DisplayAlert("Atenção", "Preencha todas as informações", "Fechar");
            return;
        }
    }
}