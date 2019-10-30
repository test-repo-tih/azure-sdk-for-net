// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ResourceManager.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class ParameterValuesValue
    {
        /// <summary>
        /// Initializes a new instance of the ParameterValuesValue class.
        /// </summary>
        public ParameterValuesValue()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ParameterValuesValue class.
        /// </summary>
        /// <param name="value">The value of the parameter.</param>
        public ParameterValuesValue(object value = default(object))
        {
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the value of the parameter.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public object Value { get; set; }

    }
}
