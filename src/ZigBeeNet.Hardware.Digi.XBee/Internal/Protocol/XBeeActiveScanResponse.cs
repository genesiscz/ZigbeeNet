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
    using ZigBeeNet.ExtendedPanId;
    
    
    /// <summary>
    /// Class to implement the XBee command " Active Scan ".
    /// AT Command <b>AS</b></p>Scans the neighborhood for beacon responses. The AS command is
    /// only valid as a local command. 
    ///This class provides methods for processing XBee API commands.
    ///
    /// </summary>
    public class XBeeActiveScanResponse : XBeeFrame, IXBeeResponse 
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
        private int _asType;
        
        /// <summary>
        /// Response field
        ///
        /// </summary>
        private int _channel;
        
        /// <summary>
        /// Response field
        ///
        /// </summary>
        private ExtendedPanId _extendedPanId;
        
        /// <summary>
        /// Response field
        ///
        /// </summary>
        private bool _allowJoin;
        
        /// <summary>
        /// Response field
        ///
        /// </summary>
        private int _stackProfile;
        
        /// <summary>
        /// Response field
        ///
        /// </summary>
        private int _lqi;
        
        /// <summary>
        /// Response field
        ///
        /// </summary>
        private int _rssi;
    }
}
