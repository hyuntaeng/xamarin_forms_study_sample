using System;
using System.Collections.Generic;
using System.Text;

using UIKit;

namespace PlatInfo_Sap
{
    class PlatformInfoType
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
