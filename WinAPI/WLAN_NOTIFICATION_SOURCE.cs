﻿// Modified work copyright (c) 2013 Runxia Electronics Co. Ltd

using System;

namespace AQWiFi
{
    /// <summary>
    /// Specifies where the notification comes from.
    /// </summary>
    [Flags]
    public enum WLAN_NOTIFICATION_SOURCE : uint
    {
        None = 0,
        /// <summary>
        /// All notifications, including those generated by the 802.1X module.
        /// </summary>
        All = 0X0000FFFF,
        /// <summary>
        /// Notifications generated by the auto configuration module.
        /// </summary>
        ACM = 0X00000008,
        /// <summary>
        /// Notifications generated by MSM.
        /// </summary>
        MSM = 0X00000010,
        /// <summary>
        /// Notifications generated by the security module.
        /// </summary>
        Security = 0X00000020,
        /// <summary>
        /// Notifications generated by independent hardware vendors (IHV).
        /// </summary>
        IHV = 0X00000040
    } 
}