namespace fushcasinaS3.Views;

public partial class vRegistro : ContentPage
{
    public vRegistro()
    {
        InitializeComponent();
    }

    private async void btnGuardarUsuario_Clicked(object sender, EventArgs e)
    {
        string usuarioNuevo = txtUsuarioNuevo.Text;
        string contrasenaNueva = txtContrasenaNueva.Text;

        await Navigation.PushAsync(
            new vLogin(usuarioNuevo, contrasenaNueva));
    }

    private async void btnCancelar_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}