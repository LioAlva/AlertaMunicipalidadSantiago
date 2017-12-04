using AlertaSantiagoApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms.Maps;

namespace AlertaSantiagoApp.ViewModels
{
    public class MainViewModel
    {
        #region Properties
        public ObservableCollection<MenuItemViewModel> Menu { get; set; }

        public LoginViewModel NewLogin { get; set; }

        public UserViewModel UserLoged { get; set; }
        //public  NewLogin 
        public ObservableCollection<Pin> Pins { get; set; }

        public ButtonAlertViewModel ViewButtonContext { get; set; }

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
            Pins = new ObservableCollection<Pin>();
            ViewButtonContext = new ButtonAlertViewModel();
            LoadMenu();
            //Create Views
            NewLogin = new LoginViewModel();
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


        public void SetGeolocation()
        {
            var position1 = new Position(6.2652880, -75.5098530);
            var pin1 = new Pin
            {
                Type = PinType.Place,
                Position = position1,
                Label = "Pin1",
                Address = "prueba pin1"
            };
            Pins.Add(pin1);

            var position2 = new Position(6.2652880, -75.4598530);
            var pin2 = new Pin
            {
                Type = PinType.Place,
                Position = position2,
                Label = "Pin2",
                Address = "prueba pin2"
            };
            Pins.Add(pin2);

            var position3 = new Position(6.2652880, -75.4898530);
            var pin3 = new Pin
            {
                Type = PinType.Place,
                Position = position3,
                Label = "Pin3",
                Address = "prueba pin3"
            };
            Pins.Add(pin3);
        }




    }
}
