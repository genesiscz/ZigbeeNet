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
    
    
    /// <summary>
    /// Class to implement the Ember EZSP command " noCallbacks ".
    /// Indicates that there are currently no pending callbacks.
    /// This class provides methods for processing EZSP commands.
    /// </summary>
    public class EzspNoCallbacksResponse : EzspFrameResponse
    {
        
        public const int FRAME_ID = 7;
        
        public EzspNoCallbacksResponse(int[] inputBuffer) : 
                base(inputBuffer)
        {
        }
        
        public override string ToString()
        {
            return base.ToString();
        }
    }
}