using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppTareaSemana2MiguelPisuna
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private async void btnIngresar_Clicked(object sender, EventArgs e)
        {
            string usuario = txtuser.Text;
            string contraseña = txtPass.Text;
            Boolean bandera = false;

            if (usuario == "estudiante2022")
            {

                bandera = true;
            }

            else
            {

                _ = DisplayAlert("Advertencia", "Usuario no existente", "Salir");
                txtuser.Text = "";
                bandera = false;
            }

            if (contraseña == "uisrael2022")
            {

                bandera = true;
            }

            else
            {
                _ = DisplayAlert("Advertencia", "Contraseña incorrecta", "Salir");
                txtPass.Text = "";
                bandera = false;
            }

            if (bandera == true)

            {
                await Navigation.PushAsync(new MainPage(usuario, contraseña));

            }

        }
    }
}