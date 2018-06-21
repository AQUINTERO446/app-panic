﻿using System.Collections.ObjectModel;

namespace DemoPanic.ViewModels
{
    public class MainViewModel
    {
        #region Properties
        public string Token
        {
            get;
            set;
        }

        public string TokenType
        {
            get;
            set;
        }
        public ObservableCollection<MenuItemViewModel> Menus
        {
            get;
            set;
        }
        #endregion

        #region ViewModels
        public StartViewModel Start
        {
            get;
            set;
        }
        public EmergencysViewModel Emergencys
        {
            get;
            set;
        }
        public LoginViewModel Login
        {
            get;
            set;
        }
        public WorkerViewModel Worker
        {
            get;
            set;
        }
        public SettingsViewModel Settings
        {
            get;
            set;
        }
        public UbicationsViewModel Ubications
        {
            get;
            set;
        }
        public RegisterViewModel Register
        {
            get;
            set;
        }
        #endregion

        #region Constructors
        public MainViewModel()
        {
            instance = this;
            this.Start = new StartViewModel();
            this.LoadMenu();
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

        #region Methods
        private void LoadMenu()
        {
            this.Menus = new ObservableCollection<MenuItemViewModel>();
            this.Menus.Add(new MenuItemViewModel
            {
                Icon = "ic_worker",
                PageName = "WorkerPage",
                Title = "Trabajadores"
            });
            this.Menus.Add(new MenuItemViewModel
            {
                Icon = "ic_settings",
                PageName = "SettingsPage",
                Title = "Configuracion"
            });
            this.Menus.Add(new MenuItemViewModel
            {
                Icon = "ic_exit",
                PageName = "LoginPage",
                Title = "Cerrar Sesión"
            });
        }
        #endregion
    }
}
