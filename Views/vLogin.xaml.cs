using fushcasinaS3.Views;

namespace fushcasinaS3.Views;

public partial class vLogin : ContentPage
{
    string usuario = "";
    string contrasenia = "";

    public vLogin()
    {
        InitializeComponent();
    }

    public vLogin(string UsuarionNuevo, string contraseniaNueva)
    {
        InitializeComponent();
        usuario = UsuarionNuevo;
        contrasenia = contraseniaNueva;
    }

    private async void btnIniciarSesion_Clicked(object sender, EventArgs e)
    {
        try
        {
            string usuarioIngresado = txtUsuario.Text;
            string contraseniaIngresada = txtContrasenia.Text;

            if (usuario == usuarioIngresado && contrasenia == contraseniaIngresada)
            {
                await Navigation.PushAsync(new vPrincipal(usuario));
            }
            else
            {
                await DisplayAlertAsync("ERROR", "Usuario/Contrasenia incorrectos", "Cerrar");
                txtUsuario.Text = "";
                txtContrasenia.Text = "";
            }

        }
        catch (Exception ex)
        {

            await DisplayAlertAsync("ERROR", ex.Message, "Cerrar");

        }
    }

    private async void btnRegistrarUsuario_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new vRegistro());
    }
}