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
    public class AlertViewModel
    {

        public string Hola { get; set; }


        #region Attributes
        public NavigationService navigationService;
        #endregion

        

        

        #region Attributes
        private GelocatorService gelocatorService;
        #endregion

        #region Constructor
        public AlertViewModel()
        {
            gelocatorService = new GelocatorService();
            navigationService = new NavigationService();
           // LoadAlert();
        }

        #region Commands
        public ICommand AlertCommand { get { return new RelayCommand(NAlert); } }

        private async void NAlert()
        {
            //var response =await dialogService.ShowMessageOnYesNo();
            //if (response) {

            //var customerItemViewModel = new CustomerItemViewModel
            //{
            //    Address = Address,
            //    City = City,
            //    CityId = CityId,
            //    CompanyCustomers = CompanyCustomers,
            //    CustomerId = CustomerId,
            //    Department = Department,
            //    DepartmentId = DepartmentId,
            //    FirstName = FirstName,
            //    IsUpdated = IsUpdated,
            //    LastName = LastName,
            //    Latitude = Latitude,
            //    Longitude = Longitude,
            //    orders = orders,
            //    phone = phone,
            //    photo = photo,
            //    sales = sales,
            //    username = username
            //    //};

            //    var mainViewModel = MainViewModel.GetInstance();//obtenemos una instacia del mainview model por que a ella 
            //                                                    //le tengo que establecer el usuario
            //   // mainViewModel.SetCurrentCustomer(customerItemViewModel);


            //    await navigationService.Navigate("DetailAlertPage");
            //}
            await navigationService.Navigate("AlertPage");
        }



        #endregion


        //private void LoadAlert()
        //{
        //    Hola="Que tall maestro";

        //}
        #endregion

        #region Methods

        #endregion

        #region Commands

        #endregion



    }
}
