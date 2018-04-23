using System;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;
using XamFormsPlayground.Services;
using XamFormsPlayground.Views;

namespace XamFormsPlayground.ViewModels
{
    public class FirstPageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public ICommand OpenGlobalStyleWindow { get { return new Command((obj) => { new GlobalStylePage(App.WindowManager).Show(); }); } }

        public FirstPageViewModel()
        {
        }

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
