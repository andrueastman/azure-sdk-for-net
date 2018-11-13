// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Media.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for ContentKeyPolicyFairPlayRentalAndLeaseKeyType.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ContentKeyPolicyFairPlayRentalAndLeaseKeyType
    {
        /// <summary>
        /// Represents a ContentKeyPolicyFairPlayRentalAndLeaseKeyType that is
        /// unavailable in current API version.
        /// </summary>
        [EnumMember(Value = "Unknown")]
        Unknown,
        /// <summary>
        /// Key duration is not specified.
        /// </summary>
        [EnumMember(Value = "Undefined")]
        Undefined,
        /// <summary>
        /// Content key can be persisted with an unlimited duration
        /// </summary>
        [EnumMember(Value = "PersistentUnlimited")]
        PersistentUnlimited,
        /// <summary>
        /// Content key can be persisted and the valid duration is limited by
        /// the Rental Duration value
        /// </summary>
        [EnumMember(Value = "PersistentLimited")]
        PersistentLimited
    }
    internal static class ContentKeyPolicyFairPlayRentalAndLeaseKeyTypeEnumExtension
    {
        internal static string ToSerializedValue(this ContentKeyPolicyFairPlayRentalAndLeaseKeyType? value)
        {
            return value == null ? null : ((ContentKeyPolicyFairPlayRentalAndLeaseKeyType)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this ContentKeyPolicyFairPlayRentalAndLeaseKeyType value)
        {
            switch( value )
            {
                case ContentKeyPolicyFairPlayRentalAndLeaseKeyType.Unknown:
                    return "Unknown";
                case ContentKeyPolicyFairPlayRentalAndLeaseKeyType.Undefined:
                    return "Undefined";
                case ContentKeyPolicyFairPlayRentalAndLeaseKeyType.PersistentUnlimited:
                    return "PersistentUnlimited";
                case ContentKeyPolicyFairPlayRentalAndLeaseKeyType.PersistentLimited:
                    return "PersistentLimited";
            }
            return null;
        }

        internal static ContentKeyPolicyFairPlayRentalAndLeaseKeyType? ParseContentKeyPolicyFairPlayRentalAndLeaseKeyType(this string value)
        {
            switch( value )
            {
                case "Unknown":
                    return ContentKeyPolicyFairPlayRentalAndLeaseKeyType.Unknown;
                case "Undefined":
                    return ContentKeyPolicyFairPlayRentalAndLeaseKeyType.Undefined;
                case "PersistentUnlimited":
                    return ContentKeyPolicyFairPlayRentalAndLeaseKeyType.PersistentUnlimited;
                case "PersistentLimited":
                    return ContentKeyPolicyFairPlayRentalAndLeaseKeyType.PersistentLimited;
            }
            return null;
        }
    }
}