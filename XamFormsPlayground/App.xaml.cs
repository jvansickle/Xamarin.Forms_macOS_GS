using System;

using Xamarin.Forms;
using XamFormsPlayground.Views;

namespace XamFormsPlayground
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new FirstPage();
        }
    }
}
