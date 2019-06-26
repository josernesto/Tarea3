using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea3.ViewModels
{
   
        public class MainViewModel
        {
            #region VieModels
            public LoginViewModel Login
            {
                get;
                set;
            }
            public Tarea3ViewModel Tarea3
            {
                get;
                set;
            }
            #endregion
            #region Constructors
            public MainViewModel()
            {
                this.Login = new LoginViewModel();
            }
            #endregion

            #region Singleton
            private static MainViewModel instance;

            public static MainViewModel GetInstance()
            {
                if (instance == null)
                {
                    return new MainViewModel();
                }
                return instance;
            }
            #endregion
        }
    }

