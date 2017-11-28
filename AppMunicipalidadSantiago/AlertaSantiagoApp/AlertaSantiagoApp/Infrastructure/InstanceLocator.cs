using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AlertaSantiagoApp.ViewModels;

namespace AlertaSantiagoApp.Infrastructure
{
    public class InstanceLocator
    {
        public MainViewModel Main { get; set; }

        public InstanceLocator()
        {
            Main = new MainViewModel();
        }
    }

}
