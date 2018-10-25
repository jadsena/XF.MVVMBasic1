using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XF.MVVMBasic.ViewModel;

namespace XF.MVVMBasic.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class NovoAlunoView : ContentPage
	{
        AlunoViewModel viewModel = new AlunoViewModel();
        public NovoAlunoView()
        {
            BindingContext = viewModel;
            InitializeComponent();
        }

    }
}