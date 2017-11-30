using AlertaSantiagoApp.Pages;
using AlertaSantiagoApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using AlertaSantiagoApp.Models;
using AlertaSantiagoApp.ViewModels;

namespace AlertaSantiagoApp
{
    public partial class App : Application
    {
        #region Attributes
        public DataService dataService { get; set; }
        #endregion

        #region Properties
        public static NavigationPage Navigator { get; internal set; }
        public static MasterPage Master { get; internal set; }
        public static User CurrentUser { get; }

        //public static User CurrentUser { get; internal set; }
        #endregion

        #region Constructors
        public App()
        {
            InitializeComponent();
            dataService = new DataService();
            var user = dataService.GetUser();
            
            if (user!=null && user.IsRemembered) {

                var mainViewModel = MainViewModel.GetInstance();
                mainViewModel.LoadUser(user);
            }
            else {
                MainPage = new LoginPage();
            }

        }
        #endregion

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
