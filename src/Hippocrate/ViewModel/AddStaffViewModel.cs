﻿using GalaSoft.MvvmLight;
using System.Windows.Controls;
using Hippocrate.ServiceUser;
using System;

namespace Hippocrate.ViewModel
{
    /// <summary>
    /// This class contains properties that a View can data bind to.
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class AddStaffViewModel : ViewModelBase, IUserConnectedChangedEventHandler
    {
        private UserControl _windowContent;

        public UserControl WindowContent
        {
            get { return _windowContent; }
            set
            {
                _windowContent = value;
                RaisePropertyChanged("WindowContent");
            }
        }
        /// <summary>
        /// Initializes a new instance of the AddStaffViewModel class.
        /// </summary>
        public AddStaffViewModel()
        {
            // WindowContent = new View.AddStaffView();
            // WindowContent.DataContext = this;
        }

        public void UserConnectedChangedEventHandler(object sender, User e)
        {
        }
    }
}