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
    public partial class Resumen : ContentPage
    {
        public Resumen(string usuario,string estudiante, string total)
        {

            InitializeComponent();
            
            lblUser.Text = usuario;
            
            txtEstudiante.Text = estudiante;
            txtTotal.Text = total;

        }
    }
}