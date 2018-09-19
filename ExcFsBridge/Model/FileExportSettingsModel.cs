using System;
using ExcFsBridge.Domain.UtilServices;
using ExcFsBridge.Infrastructure.Util;

namespace ExcFsBridge.Model
{
    [Serializable]
    public class FileExportSettingsModel : SingletonBase<FileExportSettingsModel>
    {
        public FileExportSettingsModel()
        {

        }

        public string[] getFileExtensions = { ".TXT", ".CSV" };
    }
}
