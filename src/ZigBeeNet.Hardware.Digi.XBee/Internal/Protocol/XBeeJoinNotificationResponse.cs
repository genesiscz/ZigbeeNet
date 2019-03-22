//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ZigBeeNet.Hardware.Digi.XBee.Internal.Protocol
{
    
    
    /// <summary>
    /// Class to implement the XBee command " Join Notification ".
    /// AT Command <b>JN</b></p>Set or read the join notification setting. If enabled, the device
    /// transmits a broadcast node identification packet on power up and when joining. This action
    /// blinks the Associate LED rapidly on all devices that receive the transmission, and sends an
    /// API frame out the serial port of API devices. Digi recommends you disable this feature for
    /// large networks to prevent excessive broadcasts. 
    ///This class provides methods for processing XBee API commands.
    ///
    /// </summary>
    public class XBeeJoinNotificationResponse : XBeeFrame, IXBeeResponse 
    {
        
        /// <summary>
        /// Response field
        ///
        /// </summary>
        private int _frameId;
        
        /// <summary>
        /// Response field
        ///
        /// </summary>
        private CommandStatus _commandStatus;
        
        /// <summary>
        /// Response field
        ///
        /// </summary>
        private bool _enableNotification;
    }
}
