using MvvmHelpers;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Sol_Demo.ViewModels
{
    public class MainPageViewModel : BaseViewModel
    {
        public MainPageViewModel()
        {
            App.Current.Resources["defaultLable"] = App.Current.Resources["lableOrange"];

            ChangeResource = new Command(() => this.OnChangeResource());
        }

        public ICommand ChangeResource { get; set; }

        private bool originalStyle = true;

        private void OnChangeResource()
        {
            if (originalStyle)
            {
                App.Current.Resources["defaultLable"] = App.Current.Resources["lableGreen"];
                App.Current.Resources["Name"] = "Eshaan";
                originalStyle = false;
            }
            else
            {
                App.Current.Resources["defaultLable"] = App.Current.Resources["lableOrange"];
                App.Current.Resources["Name"] = "Kishor";
                originalStyle = true;
            }
        }
    }
}