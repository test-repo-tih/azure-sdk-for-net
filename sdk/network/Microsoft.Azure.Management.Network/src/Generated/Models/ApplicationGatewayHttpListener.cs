// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Network.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Http listener of an application gateway.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class ApplicationGatewayHttpListener : SubResource
    {
        /// <summary>
        /// Initializes a new instance of the ApplicationGatewayHttpListener
        /// class.
        /// </summary>
        public ApplicationGatewayHttpListener()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ApplicationGatewayHttpListener
        /// class.
        /// </summary>
        /// <param name="id">Resource ID.</param>
        /// <param name="frontendIPConfiguration">Frontend IP configuration
        /// resource of an application gateway.</param>
        /// <param name="frontendPort">Frontend port resource of an application
        /// gateway.</param>
        /// <param name="protocol">Protocol of the HTTP listener. Possible
        /// values include: 'Http', 'Https'</param>
        /// <param name="hostName">Host name of HTTP listener.</param>
        /// <param name="sslCertificate">SSL certificate resource of an
        /// application gateway.</param>
        /// <param name="requireServerNameIndication">Applicable only if
        /// protocol is https. Enables SNI for multi-hosting.</param>
        /// <param name="provisioningState">The provisioning state of the HTTP
        /// listener resource. Possible values include: 'Succeeded',
        /// 'Updating', 'Deleting', 'Failed'</param>
        /// <param name="customErrorConfigurations">Custom error configurations
        /// of the HTTP listener.</param>
        /// <param name="hostnames">List of Host names for HTTP Listener that
        /// allows special wildcard characters as well.</param>
        /// <param name="name">Name of the HTTP listener that is unique within
        /// an Application Gateway.</param>
        /// <param name="etag">A unique read-only string that changes whenever
        /// the resource is updated.</param>
        /// <param name="type">Type of the resource.</param>
        public ApplicationGatewayHttpListener(string id = default(string), SubResource frontendIPConfiguration = default(SubResource), SubResource frontendPort = default(SubResource), string protocol = default(string), string hostName = default(string), SubResource sslCertificate = default(SubResource), bool? requireServerNameIndication = default(bool?), string provisioningState = default(string), IList<ApplicationGatewayCustomError> customErrorConfigurations = default(IList<ApplicationGatewayCustomError>), IList<string> hostnames = default(IList<string>), string name = default(string), string etag = default(string), string type = default(string))
            : base(id)
        {
            FrontendIPConfiguration = frontendIPConfiguration;
            FrontendPort = frontendPort;
            Protocol = protocol;
            HostName = hostName;
            SslCertificate = sslCertificate;
            RequireServerNameIndication = requireServerNameIndication;
            ProvisioningState = provisioningState;
            CustomErrorConfigurations = customErrorConfigurations;
            Hostnames = hostnames;
            Name = name;
            Etag = etag;
            Type = type;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets frontend IP configuration resource of an application
        /// gateway.
        /// </summary>
        [JsonProperty(PropertyName = "properties.frontendIPConfiguration")]
        public SubResource FrontendIPConfiguration { get; set; }

        /// <summary>
        /// Gets or sets frontend port resource of an application gateway.
        /// </summary>
        [JsonProperty(PropertyName = "properties.frontendPort")]
        public SubResource FrontendPort { get; set; }

        /// <summary>
        /// Gets or sets protocol of the HTTP listener. Possible values
        /// include: 'Http', 'Https'
        /// </summary>
        [JsonProperty(PropertyName = "properties.protocol")]
        public string Protocol { get; set; }

        /// <summary>
        /// Gets or sets host name of HTTP listener.
        /// </summary>
        [JsonProperty(PropertyName = "properties.hostName")]
        public string HostName { get; set; }

        /// <summary>
        /// Gets or sets SSL certificate resource of an application gateway.
        /// </summary>
        [JsonProperty(PropertyName = "properties.sslCertificate")]
        public SubResource SslCertificate { get; set; }

        /// <summary>
        /// Gets or sets applicable only if protocol is https. Enables SNI for
        /// multi-hosting.
        /// </summary>
        [JsonProperty(PropertyName = "properties.requireServerNameIndication")]
        public bool? RequireServerNameIndication { get; set; }

        /// <summary>
        /// Gets or sets the provisioning state of the HTTP listener resource.
        /// Possible values include: 'Succeeded', 'Updating', 'Deleting',
        /// 'Failed'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; set; }

        /// <summary>
        /// Gets or sets custom error configurations of the HTTP listener.
        /// </summary>
        [JsonProperty(PropertyName = "properties.customErrorConfigurations")]
        public IList<ApplicationGatewayCustomError> CustomErrorConfigurations { get; set; }

        /// <summary>
        /// Gets or sets list of Host names for HTTP Listener that allows
        /// special wildcard characters as well.
        /// </summary>
        [JsonProperty(PropertyName = "properties.hostnames")]
        public IList<string> Hostnames { get; set; }

        /// <summary>
        /// Gets or sets name of the HTTP listener that is unique within an
        /// Application Gateway.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets a unique read-only string that changes whenever the
        /// resource is updated.
        /// </summary>
        [JsonProperty(PropertyName = "etag")]
        public string Etag { get; set; }

        /// <summary>
        /// Gets or sets type of the resource.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

    }
}
