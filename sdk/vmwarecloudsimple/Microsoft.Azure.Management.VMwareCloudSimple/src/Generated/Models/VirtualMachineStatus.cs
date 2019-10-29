// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.VMwareCloudSimple.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for VirtualMachineStatus.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum VirtualMachineStatus
    {
        [EnumMember(Value = "running")]
        Running,
        [EnumMember(Value = "suspended")]
        Suspended,
        [EnumMember(Value = "poweredoff")]
        Poweredoff,
        [EnumMember(Value = "updating")]
        Updating,
        [EnumMember(Value = "deallocating")]
        Deallocating,
        [EnumMember(Value = "deleting")]
        Deleting
    }
    internal static class VirtualMachineStatusEnumExtension
    {
        internal static string ToSerializedValue(this VirtualMachineStatus? value)
        {
            return value == null ? null : ((VirtualMachineStatus)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this VirtualMachineStatus value)
        {
            switch( value )
            {
                case VirtualMachineStatus.Running:
                    return "running";
                case VirtualMachineStatus.Suspended:
                    return "suspended";
                case VirtualMachineStatus.Poweredoff:
                    return "poweredoff";
                case VirtualMachineStatus.Updating:
                    return "updating";
                case VirtualMachineStatus.Deallocating:
                    return "deallocating";
                case VirtualMachineStatus.Deleting:
                    return "deleting";
            }
            return null;
        }

        internal static VirtualMachineStatus? ParseVirtualMachineStatus(this string value)
        {
            switch( value )
            {
                case "running":
                    return VirtualMachineStatus.Running;
                case "suspended":
                    return VirtualMachineStatus.Suspended;
                case "poweredoff":
                    return VirtualMachineStatus.Poweredoff;
                case "updating":
                    return VirtualMachineStatus.Updating;
                case "deallocating":
                    return VirtualMachineStatus.Deallocating;
                case "deleting":
                    return VirtualMachineStatus.Deleting;
            }
            return null;
        }
    }
}
