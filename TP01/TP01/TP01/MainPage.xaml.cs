using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TP01
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public void OkCliked()
        {

            if(lblId.Text == "admin" && lblPass.Text == "senha")
            {
                DisplayAlert("Autorizado", "Usuário logado com sucesso", "OK");
            }
            else
            {
                DisplayAlert("Não autorizado", "ID e/ou Password incorretos", "Tente novamente");
            }

        }

        public void LimparCliked()
        {
            lblId.Text = "";
            lblPass.Text = "";
            
        }

        public void CreditosCliked()
        {
            DisplayAlert("Autores: ", "Alexsandro Silva \n Paula Simão", "OK");
        }
    }
}
