using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XF.MVVMBasic.ViewModel;

[assembly: XamlCompilation (XamlCompilationOptions.Compile)]
namespace XF.MVVMBasic
{
	public partial class App : Application
	{
        public static AlunoViewModel alunoViewModel = new AlunoViewModel();
        public App ()
		{
			InitializeComponent();

            //MainPage = new MainPage();
            MainPage = new NavigationPage(new View.AlunoView()
            { BindingContext = alunoViewModel });
        }

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
