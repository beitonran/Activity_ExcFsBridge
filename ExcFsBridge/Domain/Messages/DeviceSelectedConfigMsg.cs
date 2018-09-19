﻿using System;
using GalaSoft.MvvmLight.Messaging;
using ExcFsBridge.Model;

namespace ExcFsBridge.Domain.Messages
{
    public class DeviceSlectedConfigMsg : MessageBase
    {
        public DeviceOnlyInfoModel Payload { get; set; }
        public Action<DeviceOnlyInfoModel> Callback { get; set; }
        public DeviceSlectedConfigMsg(DeviceOnlyInfoModel payload)
        {
            this.Payload = payload;
        }

        public DeviceSlectedConfigMsg(Action<DeviceOnlyInfoModel> callback)
        {
            this.Callback = callback;
        }
    }
}