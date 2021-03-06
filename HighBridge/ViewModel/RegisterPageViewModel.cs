﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using HighBridge.Common.Commands;
using HighBridge.Common.Util;
using HighBridge.Model;
using HighBridge.View;

namespace HighBridge.ViewModel
{
    internal class RegisterPageViewModel : ViewModelBase
    {
        private string _deviceName;
        private string _userName = "";

        public RegisterPageViewModel()
        {
            ConnectCommand = new AlwaysExecutableDelegateCommand(o =>
            {
                AddUser();
            });
        }

        private void AddUser()
        {
            if (UserName == null) return;
            var newUser = new UserData();

            var res = FaceDate.GetFaceDate(VideoCaptureDeviceManager.Bitmap);
            newUser.faceId = res[0];
            newUser.image = res[1];
            newUser.name = UserName;
            AccountManager.AddUser(newUser);
        }



        public AlwaysExecutableDelegateCommand ConnectCommand { get; set; }

        public string DeviceName
        {
            get { return _deviceName; }
            set
            {
                _deviceName = value;
                OnpropertyChanged();
            }
        }

        public string UserName
        {
            get
            {
                return _userName;
            }
            set
            {
                _userName = value;
                OnpropertyChanged();
            }
        }
    }
}
