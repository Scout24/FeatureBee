﻿namespace FeatureBee.ConfigSection
{
    using System.Configuration;

    internal class FeatureBeeTrayConfig : ConfigurationElement
    {
        [ConfigurationProperty("showTrayIconOnPages", DefaultValue = false, IsRequired = false)]
        public bool ShowTrayIconOnPages
        {
            get { return (bool) this["showTrayIconOnPages"]; }
            set { this["showTrayIconOnPages"] = value; }
        }
    }
}