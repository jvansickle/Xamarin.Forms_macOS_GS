using Xamarin.Forms;
using XamFormsPlayground.ViewModels;

namespace XamFormsPlayground.Views
{
    public partial class FirstPage : ContentPage
    {
        public FirstPage()
        {
            InitializeComponent();

            BindingContext = new FirstPageViewModel();
        }
    }
}
