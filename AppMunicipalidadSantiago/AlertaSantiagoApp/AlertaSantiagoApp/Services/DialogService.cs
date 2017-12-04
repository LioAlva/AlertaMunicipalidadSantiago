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
        {
            var result = await App.Current.MainPage.DisplayAlert(title, message, "Si", "No");

            return result;
        }
    }
}
