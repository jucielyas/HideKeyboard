using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace EscondendoTeclado
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnEsconderTeclado_Clicked(object sender, EventArgs e)
        {
            DependencyService.Get<IHideKeyboard>().HideKeyboard();
        }
    }
}
