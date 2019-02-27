﻿// License text here
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZigBeeNet.ZCL.Protocol;
using ZigBeeNet.ZCL.Field;
using ZigBeeNet.ZCL.Clusters.PollControl;

/// <summary>
 /// Check In Command value object class.
 ///
 /// Cluster: Poll Control. Command is sentFROM the server.
 /// This command is a specific command used for the Poll Control cluster.
 ///
 /// The Poll Control Cluster server sends out a Check-in command to the devices to which it is paired based on the server’s Check-inInterval
 /// attribute. It does this to find out if any of the Poll Control Cluster Clients with which it is paired are interested in having it enter fast
 /// poll mode so that it can be managed. This request is sent out based on either the Check-inInterval, or the next Check-in value in the Fast Poll
 /// Stop Request generated by the Poll Control Cluster Client. /// <br> /// The Check-in command expects a Check-in Response command to be sent back from the Poll Control Client. If the Poll Control Server does not
 /// receive a Check-in response back from the Poll Control Client up to 7.68 seconds it is free to return to polling according to the
 /// LongPollInterval. ///
 /// Code is auto-generated. Modifications may be overwritten!
 /// </summary>

namespace ZigBeeNet.ZCL.Clusters.PollControl
{
       public class CheckInCommand : ZclCommand
       {

           /// <summary>
           /// Default constructor.
           /// </summary>
           public CheckInCommand()
           {
               GenericCommand = false;
               ClusterId = 32;
               CommandId = 0;
               CommandDirection = ZclCommandDirection.SERVER_TO_CLIENT;
           }

           public override string ToString()
           {
               var builder = new StringBuilder();

               builder.Append("CheckInCommand [");
               builder.Append(base.ToString());
               builder.Append(']');

               return builder.ToString();
           }

       }
}
