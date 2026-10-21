using fushcasinaS3.Views;

namespace fushcasinaS3.Views;

public partial class vLogin : ContentPage
{
    string usuario = " ";
    string contrasena = " ";
    public vLogin()
    {
        InitializeComponent();
    }
    public vLogin(string usuarioNuevo, string contrasenaNueva)
    {
        InitializeComponent();
        usuario = usuarioNuevo;
        contrasena = contrasenaNueva;
    }

    private async void btnIniciarSesion_Clicked(object sender, EventArgs e)
    {
        try
        {
            string usuarioingresado = txtUsuario.Text;
            string contrasenaIngresada = txtcontrasena.Text;
            if (usuario == usuarioingresado && contrasena == contrasenaIngresada)
            {
                await Navigation.PushAsync(new vPrincipal(usuario));
            }
            else
            {
                await DisplayAlertAsync("ERROR", "Usuario/Contraseña Incorrectos", "Cerrar");
                txtUsuario.Text = "";
                txtcontrasena.Text = "";
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