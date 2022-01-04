using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace TP04SQLite.View.Aluno
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        TP04SQLite.AlunoViewModel.AlunoViewModel vmAluno;
        public MainPage()
        {
            vmAluno = new TP04SQLite.AlunoViewModel.AlunoViewModel();
            BindingContext = vmAluno;
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            vmAluno = new TP04SQLite.AlunoViewModel.AlunoViewModel();
            BindingContext = vmAluno;
            base.OnAppearing();
        }
        private void OnNovo(object sender, EventArgs args)
        {
            Navigation.PushAsync(new NovoAlunoView());
        }
        private void OnAlunoTapped(object sender,
        ItemTappedEventArgs args)
        {
            var selecionado = args.Item as TP04SQLite.Model.Aluno;
            DisplayAlert("Aluno selecionado", "Aluno: " + selecionado.Id, "OK");
        }
    }
}