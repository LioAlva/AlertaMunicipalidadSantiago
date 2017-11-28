using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlertaSantiagoApp.ViewModels
{
    public class MainViewModel
    {
        #region Properties
        public ObservableCollection<MenuItemViewModel> Menu { get; set; }

        public LoginViewModel NewLogin { get; set; }
        //public  NewLogin 
        #endregion

        public MainViewModel()
        {
            Menu = new ObservableCollection<MenuItemViewModel>();
            LoadMenu();
            //Create Views
            NewLogin = new LoginViewModel();
        }

        private void LoadMenu()
        {
            Menu.Add(new MenuItemViewModel
            {
                Icon = "ic_action_product.png",
                PageName = "UserDataPage",
                Title = "Datos de Usuario"
            });

            Menu.Add(new MenuItemViewModel
            {
                Icon = "ic_action_customer.png",
                PageName = "UserAlertPage",
                Title = "Alerta usuario"
            });

            Menu.Add(new MenuItemViewModel
            {
                Icon = "ic_action_order.png",
                PageName = "TermsPage",
                Title = "Terminos"
            });

            Menu.Add(new MenuItemViewModel
            {
                Icon = "ic_action_delivery.png",
                PageName = "GuidePage",
                Title = "Guia"
            });

            Menu.Add(new MenuItemViewModel
            {
                Icon = "ic_action_logut.png",
                PageName = "LogutPage",
                Title = "Cerrar Sesión"
            });
        }


    }
}
