namespace fushcasinaS3.Views;

public partial class vPrincipal : ContentPage
{
	public vPrincipal(String usuario)
	{
		InitializeComponent();
		DisplayAlertAsync("Bienvenido", "Usuario: " + usuario, "Cerrar");
		lblUsuario.Text = "Usuario: " + usuario;
    }
}