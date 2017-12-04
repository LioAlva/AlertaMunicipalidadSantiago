using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlertaSantiagoApp.ViewModels
{
    public class AlertItemViewModel
    {
        #region Properties

        public ObservableCollection<EmergencyItemViewModel> Emergency { get; set; }

        #endregion

        #region Constructors
        public AlertItemViewModel()
        {
            Emergency = new ObservableCollection<EmergencyItemViewModel>();
            LoadEmergency();
        }

        private void LoadEmergency()
        {
            Emergency.Add(new EmergencyItemViewModel {
                EmergencyId=1,
                Name="Primeros Auxilios"
            });

            Emergency.Add(new EmergencyItemViewModel
            {
                EmergencyId = 2,
                Name = "Robo"
            });

            Emergency.Add(new EmergencyItemViewModel
            {
                EmergencyId = 3,
                Name = "Asalto a mano Armada"
            });

        }
        #endregion
    }
}
