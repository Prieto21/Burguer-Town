using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Proyecto
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class perfil : ContentPage
    {
        public perfil()
        {
            InitializeComponent();
        }

        private void btnEditar_Clicked(object sender, EventArgs e)
        {
            var Men = "Estamos Trabajando En Eso...";
            if (!string.IsNullOrEmpty(Men))
            {
                DisplayAlert("Mensaje", Men, "Aceptar");
            }

        }
    }
}