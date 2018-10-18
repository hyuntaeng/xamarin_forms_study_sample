using System;
using System.Collections.Generic;
using System.Text;

using Foundation;
using UIKit;

[assembly: Dependency(typeof(PlatformInfo.iOS.PlatformInfo))]
namespace PlatformInfo.iOS
{
    class PlatformInfo : MyPatformInfo
    {
        UIDevice device = new UIDevice();

        public string GetModel()
        {
            return device.Model.ToString();
        }

        public string GetVersion()
        {
            return String.Format("{0} {1}", device.SystemName,
                                            device.SystemVersion);
        }
    }
}
