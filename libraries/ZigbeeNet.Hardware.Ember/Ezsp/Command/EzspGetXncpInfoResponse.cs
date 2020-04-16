//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:3.0.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ZigBeeNet.Hardware.Ember.Ezsp.Command
{
    using ZigBeeNet.Hardware.Ember.Internal.Serializer;
    using ZigBeeNet.Hardware.Ember.Ezsp.Structure;
    
    
    /// <summary>
    /// Class to implement the Ember EZSP command " getXncpInfo ".
    /// Allows the HOST to know whether the NCP is running the XNCP library. If so, the response
    /// contains also the manufacturer ID and the version number of the XNCP application that is
    /// running on the NCP.
    /// This class provides methods for processing EZSP commands.
    /// </summary>
    public class EzspGetXncpInfoResponse : EzspFrameResponse
    {
        
        public const int FRAME_ID = 19;
        
        /// <summary>
        ///  EMBER_SUCCESS if the NCP is running the XNCP library. EMBER_INVALID_CALL otherwise.
        /// </summary>
        private EzspStatus _status;
        
        /// <summary>
        ///  The manufactured ID the user has defined in the XNCP application.
        /// </summary>
        private int _manufacturerId;
        
        /// <summary>
        ///  The version number of the XNCP application.
        /// </summary>
        private int _versionNumber;
        
        public EzspGetXncpInfoResponse(int[] inputBuffer) : 
                base(inputBuffer)
        {
            _status = deserializer.DeserializeEzspStatus();
            _manufacturerId = deserializer.DeserializeUInt16();
            _versionNumber = deserializer.DeserializeUInt16();
        }
        
        /// <summary>
        /// The status to set as <see cref="EzspStatus"/> </summary>
        public void SetStatus(EzspStatus status)
        {
            _status = status;
        }
        
        /// <summary>
        /// The manufacturerId to set as <see cref="uint16_t"/> </summary>
        public void SetManufacturerId(int manufacturerId)
        {
            _manufacturerId = manufacturerId;
        }
        
        /// <summary>
        /// The versionNumber to set as <see cref="uint16_t"/> </summary>
        public void SetVersionNumber(int versionNumber)
        {
            _versionNumber = versionNumber;
        }
        
        /// <summary>
        ///  EMBER_SUCCESS if the NCP is running the XNCP library. EMBER_INVALID_CALL otherwise.
        /// Return the status as <see cref="EzspStatus"/>
        /// </summary>
        public EzspStatus GetStatus()
        {
            return _status;
        }
        
        /// <summary>
        ///  The manufactured ID the user has defined in the XNCP application.
        /// Return the manufacturerId as <see cref="System.Int32"/>
        /// </summary>
        public int GetManufacturerId()
        {
            return _manufacturerId;
        }
        
        /// <summary>
        ///  The version number of the XNCP application.
        /// Return the versionNumber as <see cref="System.Int32"/>
        /// </summary>
        public int GetVersionNumber()
        {
            return _versionNumber;
        }
        
        public override string ToString()
        {
            System.Text.StringBuilder builder = new System.Text.StringBuilder();
            builder.Append("EzspGetXncpInfoResponse [status=");
            builder.Append(_status);
            builder.Append(", manufacturerId=");
            builder.Append(_manufacturerId);
            builder.Append(", versionNumber=");
            builder.Append(_versionNumber);
            builder.Append(']');
            return builder.ToString();
        }
    }
}