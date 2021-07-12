using karaoke.VistaModelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace karaoke.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Pedidos : ContentPage
    {
        public Pedidos()
        {
            InitializeComponent();
            BindingContext = new VMcanciones();
        }
        public void BuscarCanciones()
        {
            try
            {
                VMcanciones funcion = new VMcanciones();
                PanelCanciones.ItemsSource = funcion.ListarBuscarCanciones(txtBuscar.Text);

            }
            catch (Exception ex)
            {
                DisplayAlert("Error", ex.Message, "OK");          
            }
        }

        private void txtBuscar_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
           if(txtBuscar.Text!=null)
            {
                BuscarCanciones();
            }
                
            

        }
    }
}