using System;
using System.Collections.Generic;

using Xamarin.Forms;
using XamFormsPlayground.Services;
using XamFormsPlayground.ViewModels;

namespace XamFormsPlayground.Views
{
    public partial class GlobalStylePage : ContentPage
    {
        private readonly IWindowManager windowManager;

        public GlobalStylePage(IWindowManager windowManager)
        {
            InitializeComponent();

            this.windowManager = windowManager;

            BindingContext = new GlobalStylePageViewModel(windowManager);
        }

        public void Show()
        {
            ((GlobalStylePageViewModel)BindingContext).WindowIdentifier = windowManager.OpenWindow(this);
        }
    }
}
