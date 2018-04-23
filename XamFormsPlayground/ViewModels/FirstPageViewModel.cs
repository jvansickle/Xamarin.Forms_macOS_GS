using System;
using System.ComponentModel;

namespace XamFormsPlayground.ViewModels
{
    public class FirstPageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public FirstPageViewModel()
        {
        }

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
