using System;

using Xamarin.Forms;
using XamFormsPlayground.Services;
using XamFormsPlayground.Views;

namespace XamFormsPlayground
{
    public partial class App : Application
    {
        public static IWindowManager WindowManager { get; private set; }

        public App(IWindowManager windowManager)
        {
            InitializeComponent();

            WindowManager = windowManager;

            MainPage = new FirstPage();
        }
    }
}
