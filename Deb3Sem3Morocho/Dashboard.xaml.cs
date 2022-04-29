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
    public partial class Dashboard : ContentPage
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {

            try
            {


                ///Primer Parcial
                double dato1 = Convert.ToDouble(txtNotaS1.Text) * (0.3);
                double dato2 = Convert.ToDouble(txtExamen1.Text) * (0.2);

                double notaParcial1 = dato1 + dato2;

                txtNotaParcial1.Text = notaParcial1.ToString();

                ///Segundo Parcial
                double dato3 = Convert.ToDouble(txtNotaS2.Text) * (0.3);
                double dato4 = Convert.ToDouble(txtExamen2.Text) * (0.2);
                double notaParcial2 = dato3 + dato4;

                txtNotaParcial2.Text = notaParcial2.ToString();

                ///Nota Final y Estado
                double notafinal = notaParcial1 + notaParcial2;
                txtNotaFinal.Text = notafinal.ToString();

                if (notafinal >= 7)
                {
                    txtEstado.Text = "Aprobado";
                    DisplayAlert("Felicitaciones!!", "Aprobado", "Cerrar");
                }
                
                else
                {
                    txtEstado.Text = "Reprobado";
                    DisplayAlert("Suerte la proxima vez", "Reprobado", "Cerrar");
                }


            }
            catch (Exception ex)
            {
                DisplayAlert("Alerta", ex.Message, "Cerrar");


            }


        }
    }
}