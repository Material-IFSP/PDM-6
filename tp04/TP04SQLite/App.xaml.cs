using Xamarin.Forms;
using TP04SQLite.Model;

namespace TP04SQLite
{
    public partial class App : Application
    {
        public App()
        {
           
            MainPage = new NavigationPage(new View.Aluno.MainPage());
        }
        static Aluno alunoModel;
        public static Aluno AlunoModel
        {
            get
            {
                if (alunoModel == null)
                {
                    alunoModel = new Aluno();
                }
                return alunoModel;
            }
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
