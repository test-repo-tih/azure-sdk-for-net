// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Automation
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// SoftwareUpdateConfigurationsOperations operations.
    /// </summary>
    public partial interface ISoftwareUpdateConfigurationsOperations
    {
        /// <summary>
        /// Create a new software update configuration with the name given in
        /// the URI.
        /// <see href="http://aka.ms/azureautomationsdk/softwareupdateconfigurationoperations" />
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Name of an Azure Resource group.
        /// </param>
        /// <param name='automationAccountName'>
        /// The name of the automation account.
        /// </param>
        /// <param name='softwareUpdateConfigurationName'>
        /// The name of the software update configuration to be created.
        /// </param>
        /// <param name='parameters'>
        /// Request body.
        /// </param>
        /// <param name='clientRequestId'>
        /// Identifies this specific client request.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<SoftwareUpdateConfiguration>> CreateWithHttpMessagesAsync(string resourceGroupName, string automationAccountName, string softwareUpdateConfigurationName, SoftwareUpdateConfiguration parameters, string clientRequestId = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get a single software update configuration by name.
        /// <see href="http://aka.ms/azureautomationsdk/softwareupdateconfigurationoperations" />
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Name of an Azure Resource group.
        /// </param>
        /// <param name='automationAccountName'>
        /// The name of the automation account.
        /// </param>
        /// <param name='softwareUpdateConfigurationName'>
        /// The name of the software update configuration to be created.
        /// </param>
        /// <param name='clientRequestId'>
        /// Identifies this specific client request.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<SoftwareUpdateConfiguration>> GetByNameWithHttpMessagesAsync(string resourceGroupName, string automationAccountName, string softwareUpdateConfigurationName, string clientRequestId = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Delete a specific software update configuration.
        /// <see href="http://aka.ms/azureautomationsdk/softwareupdateconfigurationoperations" />
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Name of an Azure Resource group.
        /// </param>
        /// <param name='automationAccountName'>
        /// The name of the automation account.
        /// </param>
        /// <param name='softwareUpdateConfigurationName'>
        /// The name of the software update configuration to be created.
        /// </param>
        /// <param name='clientRequestId'>
        /// Identifies this specific client request.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> DeleteWithHttpMessagesAsync(string resourceGroupName, string automationAccountName, string softwareUpdateConfigurationName, string clientRequestId = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get all software update configurations for the account.
        /// <see href="http://aka.ms/azureautomationsdk/softwareupdateconfigurationoperations" />
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Name of an Azure Resource group.
        /// </param>
        /// <param name='automationAccountName'>
        /// The name of the automation account.
        /// </param>
        /// <param name='clientRequestId'>
        /// Identifies this specific client request.
        /// </param>
        /// <param name='filter'>
        /// The filter to apply on the operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<SoftwareUpdateConfigurationCollectionItem>>> ListWithHttpMessagesAsync(string resourceGroupName, string automationAccountName, string clientRequestId = default(string), string filter = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get all software update configurations for the account.
        /// <see href="http://aka.ms/azureautomationsdk/softwareupdateconfigurationoperations" />
        /// </summary>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='clientRequestId'>
        /// Identifies this specific client request.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<SoftwareUpdateConfigurationCollectionItem>>> ListNextWithHttpMessagesAsync(string nextPageLink, string clientRequestId = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
