﻿using AlertaSantiagoApp.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlertaSantiagoApp.Services
{
    public class NavigationService
    {

        public async Task Navigate(string pageName)
        {
            App.Master.IsPresented = false;
            switch (pageName)
            {
                case "UserDataPage":
                    await App.Navigator.PushAsync(new UserDataPage());
                    ; break;
                case "UserAlertPage":
                    await App.Navigator.PushAsync(new UserAlertPage());
                    ; break;
                case "TermsPage":
                    await App.Navigator.PushAsync(new TermsPage());
                    ; break;
                case "GuidePage":
                    await App.Navigator.PushAsync(new GuidePage());
                    ; break;
                case "LogutPage":
                    Logout();
                    ; break;
                default:
                    break;
            }
        }

        private void Logout()
        {
            //App.CurrentUser.IsRemembered = false; //lo dejamos de recordar por que hicimos un logut ,ahora creamos un servicio que nos ayudaraupdetear uduarios
            //dataService.UpdateUser(App.CurrentUser);
            App.Current.MainPage = new LoginPage();
        }

        //public void SetMainPage(User user)
        public void SetMainPage()
        {
            //ya tenemos el usuario y a esta instanciado en el mainviewmodel

            //var mainViewModel = MainViewModel.GetInstance();
            //mainViewModel.LoadUser(user);
            // App.CurrentUser = user;//esta propiedad creo para guardar al usduario cuando doy logout y luego pueda conectarme si internet
            App.Current.MainPage = new MasterPage();
        }
    }
}