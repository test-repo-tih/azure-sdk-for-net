// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.FrontDoor.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Defines the properties of an Experiment
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class Experiment : Resource
    {
        /// <summary>
        /// Initializes a new instance of the Experiment class.
        /// </summary>
        public Experiment()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Experiment class.
        /// </summary>
        /// <param name="id">Resource ID.</param>
        /// <param name="name">Resource name.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="location">Resource location.</param>
        /// <param name="tags">Resource tags.</param>
        /// <param name="description">The description of the details or intents
        /// of the Experiment</param>
        /// <param name="endpointA">The endpoint A of an experiment</param>
        /// <param name="endpointB">The endpoint B of an experiment</param>
        /// <param name="enabledState">The state of the Experiment. Possible
        /// values include: 'Enabled', 'Disabled'</param>
        /// <param name="resourceState">Resource status. Possible values
        /// include: 'Creating', 'Enabling', 'Enabled', 'Disabling',
        /// 'Disabled', 'Deleting'</param>
        /// <param name="status">The description of Experiment status from the
        /// server side</param>
        /// <param name="scriptFileUri">The uri to the Script used in the
        /// Experiment</param>
        public Experiment(string id = default(string), string name = default(string), string type = default(string), string location = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string description = default(string), Endpoint endpointA = default(Endpoint), Endpoint endpointB = default(Endpoint), string enabledState = default(string), string resourceState = default(string), string status = default(string), string scriptFileUri = default(string))
            : base(id, name, type, location, tags)
        {
            Description = description;
            EndpointA = endpointA;
            EndpointB = endpointB;
            EnabledState = enabledState;
            ResourceState = resourceState;
            Status = status;
            ScriptFileUri = scriptFileUri;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the description of the details or intents of the
        /// Experiment
        /// </summary>
        [JsonProperty(PropertyName = "properties.description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the endpoint A of an experiment
        /// </summary>
        [JsonProperty(PropertyName = "properties.endpointA")]
        public Endpoint EndpointA { get; set; }

        /// <summary>
        /// Gets or sets the endpoint B of an experiment
        /// </summary>
        [JsonProperty(PropertyName = "properties.endpointB")]
        public Endpoint EndpointB { get; set; }

        /// <summary>
        /// Gets or sets the state of the Experiment. Possible values include:
        /// 'Enabled', 'Disabled'
        /// </summary>
        [JsonProperty(PropertyName = "properties.enabledState")]
        public string EnabledState { get; set; }

        /// <summary>
        /// Gets or sets resource status. Possible values include: 'Creating',
        /// 'Enabling', 'Enabled', 'Disabling', 'Disabled', 'Deleting'
        /// </summary>
        [JsonProperty(PropertyName = "properties.resourceState")]
        public string ResourceState { get; set; }

        /// <summary>
        /// Gets the description of Experiment status from the server side
        /// </summary>
        [JsonProperty(PropertyName = "properties.status")]
        public string Status { get; private set; }

        /// <summary>
        /// Gets the uri to the Script used in the Experiment
        /// </summary>
        [JsonProperty(PropertyName = "properties.scriptFileUri")]
        public string ScriptFileUri { get; private set; }

    }
}
