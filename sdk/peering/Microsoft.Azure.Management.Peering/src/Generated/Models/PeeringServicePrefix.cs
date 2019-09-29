// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Peering.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The peering service prefix class.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class PeeringServicePrefix : Resource
    {
        /// <summary>
        /// Initializes a new instance of the PeeringServicePrefix class.
        /// </summary>
        public PeeringServicePrefix()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PeeringServicePrefix class.
        /// </summary>
        /// <param name="name">The name of the resource.</param>
        /// <param name="id">The ID of the resource.</param>
        /// <param name="type">The type of the resource.</param>
        /// <param name="prefix">Valid route prefix</param>
        /// <param name="prefixValidationState">The prefix validation state.
        /// Possible values include: 'None', 'Invalid', 'Verified', 'Failed',
        /// 'Pending', 'Unknown'</param>
        /// <param name="learnedType">The prefix learned type. Possible values
        /// include: 'None', 'ViaPartner', 'ViaSession'</param>
        /// <param name="provisioningState">The provisioning state of the
        /// resource. Possible values include: 'Succeeded', 'Updating',
        /// 'Deleting', 'Failed'</param>
        public PeeringServicePrefix(string name = default(string), string id = default(string), string type = default(string), string prefix = default(string), string prefixValidationState = default(string), string learnedType = default(string), string provisioningState = default(string))
            : base(name, id, type)
        {
            Prefix = prefix;
            PrefixValidationState = prefixValidationState;
            LearnedType = learnedType;
            ProvisioningState = provisioningState;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets valid route prefix
        /// </summary>
        [JsonProperty(PropertyName = "properties.prefix")]
        public string Prefix { get; set; }

        /// <summary>
        /// Gets or sets the prefix validation state. Possible values include:
        /// 'None', 'Invalid', 'Verified', 'Failed', 'Pending', 'Unknown'
        /// </summary>
        [JsonProperty(PropertyName = "properties.prefixValidationState")]
        public string PrefixValidationState { get; set; }

        /// <summary>
        /// Gets or sets the prefix learned type. Possible values include:
        /// 'None', 'ViaPartner', 'ViaSession'
        /// </summary>
        [JsonProperty(PropertyName = "properties.learnedType")]
        public string LearnedType { get; set; }

        /// <summary>
        /// Gets the provisioning state of the resource. Possible values
        /// include: 'Succeeded', 'Updating', 'Deleting', 'Failed'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

    }
}
