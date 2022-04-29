using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Deb3Sem3Morocho
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            String Susuario = txtUsuario.Text;
            string Spassword = txtPasword.Text;

            if((Susuario == "estudiante2021") && (Spassword == "uisrael2021"))
            {
                Navigation.PushAsync(new Dashboard());
            }
            else
            {
                lblResultado.Text = "El Usuario y Password son incorrectos";
            }


        }
    }
}