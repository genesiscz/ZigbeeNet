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
    using ZigBeeNet.IeeeAddress;
    
    
    /// <summary>
    /// Class to implement the XBee command " Receive Packet ".
    /// When a device configured with a standard API Rx Indicator (AO = 0) receives an RF data packet,
    /// it sends it out the serial interface using this message type. 
    ///This class provides methods for processing XBee API commands.
    ///
    /// </summary>
    public class XBeeReceivePacketEvent : XBeeFrame, IXBeeEvent
    {
        
        /// <summary>
        /// Response field
        /// The sender's 64-bit address. MSB first, LSB last. 
        ///
        /// </summary>
        private IeeeAddress _ieeeAddress;
        
        /// <summary>
        /// Response field
        /// The sender's 16-bit address.
        ///
        /// </summary>
        private int _networkAddress;
        
        /// <summary>
        /// Response field
        ///
        /// </summary>
        private ReceiveOptions _receiveOptions;
        
        /// <summary>
        /// Response field
        /// The RF data that the device receives.
        ///
        /// </summary>
        private int _data;
    }
}
