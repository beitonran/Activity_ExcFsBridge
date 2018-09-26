using System;
using System.Windows.Input;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Windows.Threading;
using ExcFsBridge.Domain.Services.FSUIPCBridgeService;
using FSUIPC;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using NLog;

namespace ExcFsBridge.View.ShellViews.FsuipcView
{
    public class StartViewModelFsBridge : ViewModelBase
    {
        #region Private
        private static string ViewTitle = "FS Bridge View";
        private static Logger logger = LogManager.GetCurrentClassLogger();
        private DispatcherTimer timer = null;

        private bool _isConnected = false;
        private IFSBridgeSrv _fsBridgeSrvProxy;
        #endregion
        //********************************************
        #region Public
        public RelayCommand ManageFSBridgeConnection { get; private set; }
        #endregion
        //********************************************
        #region Init
        /// <summary>
        /// 
        /// </summary>
        public StartViewModelFsBridge(IFSBridgeSrv srvProxy)
        {
            _fsBridgeSrvProxy = srvProxy;
            ManageFSBridgeConnection = new RelayCommand(ManageFSBridgeConnectionHandler);


            _fsBridgeSrvProxy.Start();
        }
        #endregion
        //********************************************
        #region Handlers
        private void ManageFSBridgeConnectionHandler()
        {
            if (_isConnected)
            {
                _isConnected = false;
            }
            else
            {
                _isConnected = true;
            }
        }
        #endregion
        //********************************************
        #region Private_Methods

        #endregion
        //********************************************
    }
}
