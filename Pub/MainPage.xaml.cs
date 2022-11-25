using Plugin.CloudFirestore;

namespace Pub;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}

    private void REG_Clicked(System.Object sender, System.EventArgs e)
    {
        Publicar();
    }
    private async void Publicar()
    {
        Usuarios usuarios = new Usuarios()
        {
            Nombre = NombreR.Text,
            Apellido_Materno = ApellidoM.Text,
            Apellido_Paterno = ApellidoP.Text,
            Numero = NumeroR.Text
        };
        await CrossCloudFirestore.Current
                         .Instance
                         .Collection("Pruba")
                         .Document("Usuarios")
                         .UpdateAsync(usuarios);
    }
}

