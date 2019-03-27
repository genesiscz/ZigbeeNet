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
    /// Class to implement the XBee command " ZigBee Stack Profile ".
    /// AT Command <b>ZS</b></p>Set or read the Zigbee stack profile value. This must be the same on
    /// all devices that will join the same network. Effective with release 4x5E, changing ZS to a
    /// different value causes all current parameters to be written to persistent storage. 
    ///This class provides methods for processing XBee API commands.
    ///
    /// </summary>
    public class XBeeZigbeeStackProfileResponse : XBeeFrame, IXBeeResponse 
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
        private int _stackProfile;
        
        /// <summary>
        /// Return the frameId as <see cref="System.Int32"/>
        /// </summary>
        public int GetFrameId()
        {
            return _frameId;
        }
        
        /// <summary>
        /// Return the commandStatus as <see cref="CommandStatus"/>
        /// </summary>
        public CommandStatus GetCommandStatus()
        {
            return _commandStatus;
        }
        
        /// <summary>
        /// Return the stackProfile as <see cref="System.Int32"/>
        /// </summary>
        public int GetStackProfile()
        {
            return _stackProfile;
        }
    }
}
