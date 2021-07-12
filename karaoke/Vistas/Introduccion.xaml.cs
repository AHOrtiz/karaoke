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
    public partial class Introduccion : ContentPage
    {
        public Introduccion()
        {
            InitializeComponent();
            Animacion();
        }
        public async Task Animacion()
        {
            imgLogo.Opacity = 0;
            await imgLogo.FadeTo(1, 2000);
            Application.Current.MainPage = new Pedidos();
        }
    }
}