using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlertaSantiagoApp.Services
{
    public class DialogService
    {
        public async Task ShowMessage(string title, string message)
        {
            await App.Current.MainPage.DisplayAlert(title, message, "Aceptar");
        }

        public async Task<bool> ShowMessageYesAndNot(string title, string message)
        {//DisplayAlert("Question","Do you want to reset the search-options?", "Yes", "No");
            var result = await App.Current.MainPage.DisplayAlert(title, message, "Si", "No");

            return result;
        }
    }
}
