using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TP02.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class EstiloDinamico : ContentPage
	{
        public EstiloDinamico()
        {
            Device.StartTimer(TimeSpan.FromSeconds(1), OnTimerTick);

            InitializeComponent();
        }

        private void btnAlterarEstiloClicked(object sender, EventArgs e)
        {
            Random random = new Random();

            Color randomColor = Color.FromRgb(random.Next(256), random.Next(256), random.Next(256));
            labelClock.TextColor = randomColor;
            labelHour.TextColor = randomColor;
        }

        public async void OnPreviousPageButtonClicked(Object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        bool OnTimerTick()
        {
            labelClock.Text = DateTime.Now.ToString("dd / MM / yyyy HH : mm : ss");
            return true;
        }
    }
}
