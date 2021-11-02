using System;
using TP02.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TP02.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Home : ContentPage
	{
		public Home ()
		{
            InitializeComponent();
        }

        private async void btnSave(object sender, EventArgs e)
        {
            var contato = new Contato
            {
                Nome = Nome.Text,
                Idade = int.Parse(Idade.Text),
                Profissao = Profissao.Text,
                Pais = Pais.Text
            };

            var detalhesContato = new DetalhesContato();
            detalhesContato.BindingContext = contato;
            await Navigation.PushAsync(detalhesContato);
        }
    }
}