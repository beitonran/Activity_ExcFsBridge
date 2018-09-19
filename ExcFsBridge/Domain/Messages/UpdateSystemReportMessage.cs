using System;
using ExcFsBridge.Model;

namespace ExcFsBridge.Domain.Messages
{
    public class UpdateSystemReportMessage
    {
        public SystemInfoModel systemInfoModelReport { get; set; }
    }
}
