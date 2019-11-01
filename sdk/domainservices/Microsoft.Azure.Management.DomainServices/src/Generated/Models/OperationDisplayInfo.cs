// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DomainServices.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The operation supported by Domain Services.
    /// </summary>
    public partial class OperationDisplayInfo
    {
        /// <summary>
        /// Initializes a new instance of the OperationDisplayInfo class.
        /// </summary>
        public OperationDisplayInfo()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the OperationDisplayInfo class.
        /// </summary>
        /// <param name="description">The description of the operation.</param>
        /// <param name="operation">The action that users can perform, based on
        /// their permission level.</param>
        /// <param name="provider">Service provider: Domain Services.</param>
        /// <param name="resource">Resource on which the operation is
        /// performed.</param>
        public OperationDisplayInfo(string description = default(string), string operation = default(string), string provider = default(string), string resource = default(string))
        {
            Description = description;
            Operation = operation;
            Provider = provider;
            Resource = resource;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the description of the operation.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the action that users can perform, based on their
        /// permission level.
        /// </summary>
        [JsonProperty(PropertyName = "operation")]
        public string Operation { get; set; }

        /// <summary>
        /// Gets or sets service provider: Domain Services.
        /// </summary>
        [JsonProperty(PropertyName = "provider")]
        public string Provider { get; set; }

        /// <summary>
        /// Gets or sets resource on which the operation is performed.
        /// </summary>
        [JsonProperty(PropertyName = "resource")]
        public string Resource { get; set; }

    }
}
