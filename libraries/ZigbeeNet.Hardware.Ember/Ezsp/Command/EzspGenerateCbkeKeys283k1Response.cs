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
    /// Class to implement the Ember EZSP command " generateCbkeKeys283k1 ".
    /// This call starts the generation of the ECC 283k1 curve Ephemeral Public/Private key pair.
    /// When complete it stores the private key. The results are returned via
    /// ezspGenerateCbkeKeys283k1Handler().
    /// This class provides methods for processing EZSP commands.
    /// </summary>
    public class EzspGenerateCbkeKeys283k1Response : EzspFrameResponse
    {
        
        public const int FRAME_ID = 232;
        
        /// <summary>
        ///  The result of the CBKE operation.
        /// </summary>
        private EmberStatus _status;
        
        public EzspGenerateCbkeKeys283k1Response(int[] inputBuffer) : 
                base(inputBuffer)
        {
            _status = deserializer.DeserializeEmberStatus();
        }
        
        /// <summary>
        /// The status to set as <see cref="EmberStatus"/> </summary>
        public void SetStatus(EmberStatus status)
        {
            _status = status;
        }
        
        /// <summary>
        ///  The result of the CBKE operation.
        /// Return the status as <see cref="EmberStatus"/>
        /// </summary>
        public EmberStatus GetStatus()
        {
            return _status;
        }
        
        public override string ToString()
        {
            System.Text.StringBuilder builder = new System.Text.StringBuilder();
            builder.Append("EzspGenerateCbkeKeys283k1Response [status=");
            builder.Append(_status);
            builder.Append(']');
            return builder.ToString();
        }
    }
}