using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlertaSantiagoApp.ViewModels
{
    public class AlertItemViewModel: INotifyPropertyChanged
    {
        #region Properties

        public ObservableCollection<EmergencyItemViewModel> Emergencys { get; set; }

        #endregion

        #region Constructors
        public AlertItemViewModel()
        {
            Emergencys = new ObservableCollection<EmergencyItemViewModel>();
            LoadEmergency();
        }

        #region Events
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion

        private void LoadEmergency()
        {
            Emergencys.Add(new EmergencyItemViewModel {
                EmergencyId=1,
                Name="Primeros Auxilios"
            });

            Emergencys.Add(new EmergencyItemViewModel
            {
                EmergencyId = 2,
                Name = "Robo"
            });

            Emergencys.Add(new EmergencyItemViewModel
            {
                EmergencyId = 3,
                Name = "Asalto a mano Armada"
            });

        }
        #endregion
    }
}
