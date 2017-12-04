using AlertaSantiagoApp.Services;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace AlertaSantiagoApp.ViewModels
{
    public class ButtonAlertViewModel
    {
        #region Attributes
        public NavigationService navigationService;
        public DialogService dialogService;
        #endregion

        #region Properties
        public AlertItemViewModel Alert{ get; set; }

        #endregion


        #region Constructors
        public ButtonAlertViewModel()
        {
            navigationService = new NavigationService();
        }
        #endregion


        #region Commands
        
        public ICommand NewAlertCommand { get { return new RelayCommand(NewAlert); } }

        private async void NewAlert()
        {
            var result = await dialogService.ShowMessageYesAndNot("Confimación", "Estas seguro de enviar la Alerta");
            if (result) {
                await navigationService.Navigate("AlertPage");
            }
        }
        
        #endregion

    }
}
