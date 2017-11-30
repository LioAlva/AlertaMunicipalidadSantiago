using AlertaSantiagoApp.Models;
using AlertaSantiagoApp.Services;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace AlertaSantiagoApp.ViewModels
{
    public class MainViewModel
    {
        #region Attribute
        public DialogService dialogService { get; set; }
        public NavigationService navigationService { get; set; }
        #endregion

        #region Properties
        public ObservableCollection<MenuItemViewModel> Menu { get; set; }

        public LoginViewModel NewLogin { get; set; }

        public UserViewModel UserLoged { get; set; }

        //RegisteredCommand
        //public  NewLogin 
        #endregion

        #region Singleton

        static MainViewModel instance;

        public static MainViewModel GetInstance()
        {
            if (instance == null)
            {
                instance = new MainViewModel();
            }

            return instance;
        }

        #endregion

        #region  Constructors
        public MainViewModel()
        {
            instance = this;

            Menu = new ObservableCollection<MenuItemViewModel>();
            UserLoged = new UserViewModel();
            dialogService = new DialogService();
            navigationService = new NavigationService();
            LoadMenu();
            //Create Views
            NewLogin = new LoginViewModel();
        }
        #endregion


        #region Commands
        public ICommand AlertCommand { get { return new RelayCommand(Alert); } }

        private async void Alert()
        {
            var response =await dialogService.ShowMessageOnYesNo();
            if (response) {
               await navigationService.Navigate("DetailAlertPage");
            }
        }

    

        #endregion

        #region Methods


        public void LoadUser(User user)
        {
           // var user = dataService.GetUser();  //aca muere
            //alinicio en nuevo cell sale error porque no hay usuario y asignas user null a fullname y photofullpth
            if (user != null)
            {
                UserLoged.FullName = user.FullName;
                //112 ahora mostramos la photo
                UserLoged.Photo = user.PhotoFullPath;
              
            }
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

        #endregion

        


    }
}
