using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ExamenLeonardoSanchez
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registro : ContentPage
    {
        private string user;
        private string pass;

        public Registro(string user, string pass)
        {
            InitializeComponent();
            string usuario = lblUser.Text;
            lblUser.Text = usuario + user;

        }

        private async void btnCalcular_Clicked(object sender, EventArgs e)
        {
            
            string alumno = txtEstudiante.Text;
            double avance = Convert.ToDouble(txtAbono.Text);
            double saldo = Convert.ToDouble(txtSaldoPendiente.Text);
            double mensualidades = Convert.ToDouble(txtMensualidades.Text);
            double total = Convert.ToDouble(txtTotal.Text);

            double cuenta = 1800 - avance;
            txtSaldoPendiente.Text = cuenta.ToString();

            double cuotas = (cuenta / 3) * 0.05 + (cuenta / 3);
            txtMensualidades.Text = cuotas.ToString();

            double pagoTotal = (cuotas * 3) + avance;
            txtTotal.Text = pagoTotal.ToString();

            DisplayAlert("Ingreso Correcto", "Almacenado Correctamente", "OK");
            
        }

        private async void btnEnviar_Clicked(object sender, EventArgs e)
        {
            string estudiante = txtEstudiante.Text;
            string total = txtTotal.Text;
            string usuario = lblUser.Text;
            lblUser.Text = usuario + user;


            await Navigation.PushAsync(new Resumen(usuario,estudiante, total));
        }
    }
}