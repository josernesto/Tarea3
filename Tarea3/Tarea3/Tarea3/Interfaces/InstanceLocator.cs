using System;
using System.Collections.Generic;
using System.Text;
using Tarea3.ViewModels;

namespace Tarea3.Interfaces
{
    public class InstanceLocator
    {
        #region Properties
        public MainViewModel Main
        { get; set; }

        #endregion

        #region Constructors
        public InstanceLocator()
        {
            this.Main = new MainViewModel();
        }
        #endregion

    }
}
