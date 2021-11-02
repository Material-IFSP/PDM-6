using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TP02.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetalhesProduto : ContentPage
    {
        public DetalhesProduto()
        {
            InitializeComponent();
        }

        private async void BtnBackPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CadastroProduto());
        }
    }
}