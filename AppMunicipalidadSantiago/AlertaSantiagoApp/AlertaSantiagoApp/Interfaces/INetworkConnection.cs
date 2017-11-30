using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlertaSantiagoApp.Interfaces
{
    public interface INetworkConnection//interfaz de coneccion de red
    {
        bool IsConnected { get; }
        void CheckNetworkConnection();
    }
}
