namespace fushcasinaS3.Views;

public partial class vLogin : ContentPage
{
    string usuario = "";
    string contrasena = "";

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

    private async void btnIniciarSesion(object sender, EventArgs e)
    {
        string usuarioIngresado = txtUsuario.Text;
        string contrasenaIngresada = txtContrasena.Text;

        if (usuarioIngresado == usuario &&
            contrasenaIngresada == contrasena)
        {
            await Navigation.PushAsync(new vPrincipal(usuario));
        }
        else
        {
            await DisplayAlertAsync("Error",
                "Usuario o contraseña incorrectos",
                "OK");
        }
    }

    private async void btnRegistrarUsuario(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new vRegistro());
    }
}