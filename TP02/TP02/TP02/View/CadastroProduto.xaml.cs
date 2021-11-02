using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP02;
using TP02.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TP02.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CadastroProduto : ContentPage
    {
        public CadastroProduto()
        {
            InitializeComponent();
        }

        private async void btnSave(object sender, EventArgs e)
        {
            var id = txtId.Text;
            var descricao = txtDescricao.Text;
            var categoria = txtCategoria.Text;
            var quantidade = txtQuantidade.Text;
            var preco = txtPreco.Text;

            if (id == null || descricao == null || categoria == null || quantidade == null || preco == null)
            {
                await DisplayAlert("Alerta", "Preencha todos os campos do formulário!", "OK");
            }
            else
            {
                Produto produto = new Produto
                {
                    Id = Convert.ToInt32(id),
                    Descricao = descricao,
                    Categoria = categoria,
                    Quantidade = Convert.ToInt32(quantidade),
                    Preco = Convert.ToDecimal(preco),
                };

                DetalhesProduto detalhesProduto = new DetalhesProduto();
                detalhesProduto.BindingContext = produto;

                await Navigation.PushAsync(detalhesProduto);
            }
        }
    }
}