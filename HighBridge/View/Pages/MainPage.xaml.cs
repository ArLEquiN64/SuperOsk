﻿using System.Windows.Controls;
using AForge.Video;
using HighBridge.Common.Util;
using HighBridge.Model;
using Microsoft.Win32;
using HighBridge.ViewModel;

namespace HighBridge.View.Pages
{
    /// <summary>
    /// MainPage.xaml の相互作用ロジック
    /// </summary>
    public partial class MainPage : Page
    {
        private MainPageViewModel ViewModel { get; set; }
        public MainPage()
        {
            InitializeComponent();
            //VideoCaptureDeviceManager.NewFrameGot += CamDeviceCtrlNewFrameGot;
            DataContext=ViewModel=new MainPageViewModel();
            
        }

        private void Reference_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.FileName = "";
            ofd.DefaultExt = "*.*";
            if (ofd.ShowDialog() == true)
            {
                TextBox.Text = ofd.FileName;
            }

        }
        //private void CamDeviceCtrlNewFrameGot(object sender, NewFrameEventArgs eventArgs)
        //{
        //    ViewModel.ImageSource = eventArgs.Frame;
        //    Picture.Dispatcher.Invoke(() =>
        //    { if (Picture != null) Picture.Source = BitmapToBitmapFrame.Convert(eventArgs.Frame); });
        //}
    }
}
