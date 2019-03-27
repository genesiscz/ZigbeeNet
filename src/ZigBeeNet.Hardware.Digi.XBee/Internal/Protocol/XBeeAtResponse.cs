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
    /// Class to implement the XBee command " AT ".
    /// A device sends this frame in response to an AT Command (0x08 or 0x09) frame. Some commands send
    /// back multiple frames; for example, the ND command. 
    ///This class provides methods for processing XBee API commands.
    ///
    /// </summary>
    public class XBeeAtResponse : XBeeFrame, IXBeeResponse 
    {
        
        /// <summary>
        /// Response field
        /// The frame Id 
        ///
        /// </summary>
        private int _frameId;
        
        /// <summary>
        /// Response field
        /// Command name: two ASCII characters that identify the command. 
        ///
        /// </summary>
        private string _atCommand;
        
        /// <summary>
        /// Response field
        ///
        /// </summary>
        private CommandStatus _commandStatus;
        
        /// <summary>
        /// Response field
        /// The register data in binary format. If the host sets the register, the device does not return
        /// this field. 
        ///
        /// </summary>
        private int _commandData;
        
        /// <summary>
        /// Return the frameId as <see cref="System.Int32"/>
        /// </summary>
        public int GetFrameId()
        {
            return _frameId;
        }
        
        /// <summary>
        /// Return the atCommand as <see cref="System.String"/>
        /// </summary>
        public string GetAtCommand()
        {
            return _atCommand;
        }
        
        /// <summary>
        /// Return the commandStatus as <see cref="CommandStatus"/>
        /// </summary>
        public CommandStatus GetCommandStatus()
        {
            return _commandStatus;
        }
        
        /// <summary>
        /// Return the commandData as <see cref="System.Int32"/>
        /// </summary>
        public int GetCommandData()
        {
            return _commandData;
        }
    }
}
