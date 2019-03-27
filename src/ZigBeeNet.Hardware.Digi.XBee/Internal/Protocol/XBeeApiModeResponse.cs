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
    /// Class to implement the XBee command " API Mode ".
    /// AT Command <b>AO</b></p>Configure the options for API. The current options select the type
    /// of receive API frame to send out the UART for received RF data packets. 0 Default API Rx
    /// Indicator enabled 1 Default API Explicit Rx Indicator - 0x91, this is for Explicit
    /// Addressing data frames. 3 Enable ZDO passthrough of ZDO requests to the serial port that are
    /// not supported by the stack, as well as Simple_Desc_req, Active_EP_req, and
    /// Match_Desc_req. 
    ///This class provides methods for processing XBee API commands.
    ///
    /// </summary>
    public class XBeeApiModeResponse : XBeeFrame, IXBeeResponse 
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
        private int _mode;
        
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
        /// Return the mode as <see cref="System.Int32"/>
        /// </summary>
        public int GetMode()
        {
            return _mode;
        }
    }
}
