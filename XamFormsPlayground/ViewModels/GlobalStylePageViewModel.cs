using System;
using System.Windows.Input;
using Xamarin.Forms;
using XamFormsPlayground.Services;

namespace XamFormsPlayground.ViewModels
{
    public class GlobalStylePageViewModel
    {
        public string WindowIdentifier { get; set; }

        public ICommand ClosePage { get { return new Command(() => { if (!string.IsNullOrEmpty(WindowIdentifier)) { windowManager.CloseWindow(WindowIdentifier); } }); } }

        private readonly IWindowManager windowManager;

        public GlobalStylePageViewModel(IWindowManager windowManager)
        {
            this.windowManager = windowManager;
        }
    }
}
