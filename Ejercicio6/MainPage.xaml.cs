namespace Ejercicio6
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            listaPersonas listaPersonas = new listaPersonas();
            InitializeComponent();
            Lista.ItemsSource = listaPersonas.ListadoPersona();
        }

    }
}