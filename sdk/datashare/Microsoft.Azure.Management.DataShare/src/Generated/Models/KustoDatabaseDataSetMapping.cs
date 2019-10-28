// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataShare.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// A Kusto database data set mapping
    /// </summary>
    [Newtonsoft.Json.JsonObject("KustoDatabase")]
    [Rest.Serialization.JsonTransformation]
    public partial class KustoDatabaseDataSetMapping : DataSetMapping
    {
        /// <summary>
        /// Initializes a new instance of the KustoDatabaseDataSetMapping
        /// class.
        /// </summary>
        public KustoDatabaseDataSetMapping()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the KustoDatabaseDataSetMapping
        /// class.
        /// </summary>
        /// <param name="dataSetId">The id of the source data set.</param>
        /// <param name="kustoClusterResourceId">Resource id of the sink kusto
        /// cluster.</param>
        /// <param name="id">The resource id of the azure resource</param>
        /// <param name="name">Name of the azure resource</param>
        /// <param name="type">Type of the azure resource</param>
        /// <param name="dataSetMappingStatus">Gets the status of the data set
        /// mapping. Possible values include: 'Ok', 'Broken'</param>
        /// <param name="location">Location of the sink kusto cluster.</param>
        /// <param name="provisioningState">Provisioning state of the data set
        /// mapping. Possible values include: 'Succeeded', 'Creating',
        /// 'Deleting', 'Moving', 'Failed'</param>
        public KustoDatabaseDataSetMapping(string dataSetId, string kustoClusterResourceId, string id = default(string), string name = default(string), string type = default(string), string dataSetMappingStatus = default(string), string location = default(string), string provisioningState = default(string))
            : base(id, name, type)
        {
            DataSetId = dataSetId;
            DataSetMappingStatus = dataSetMappingStatus;
            KustoClusterResourceId = kustoClusterResourceId;
            Location = location;
            ProvisioningState = provisioningState;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the id of the source data set.
        /// </summary>
        [JsonProperty(PropertyName = "properties.dataSetId")]
        public string DataSetId { get; set; }

        /// <summary>
        /// Gets the status of the data set mapping. Possible values include:
        /// 'Ok', 'Broken'
        /// </summary>
        [JsonProperty(PropertyName = "properties.dataSetMappingStatus")]
        public string DataSetMappingStatus { get; private set; }

        /// <summary>
        /// Gets or sets resource id of the sink kusto cluster.
        /// </summary>
        [JsonProperty(PropertyName = "properties.kustoClusterResourceId")]
        public string KustoClusterResourceId { get; set; }

        /// <summary>
        /// Gets location of the sink kusto cluster.
        /// </summary>
        [JsonProperty(PropertyName = "properties.location")]
        public string Location { get; private set; }

        /// <summary>
        /// Gets provisioning state of the data set mapping. Possible values
        /// include: 'Succeeded', 'Creating', 'Deleting', 'Moving', 'Failed'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (DataSetId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "DataSetId");
            }
            if (KustoClusterResourceId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "KustoClusterResourceId");
            }
        }
    }
}
