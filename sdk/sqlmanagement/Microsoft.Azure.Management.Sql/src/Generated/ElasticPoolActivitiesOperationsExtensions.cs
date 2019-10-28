// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Sql
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for ElasticPoolActivitiesOperations.
    /// </summary>
    public static partial class ElasticPoolActivitiesOperationsExtensions
    {
            /// <summary>
            /// Returns elastic pool activities.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='elasticPoolName'>
            /// The name of the elastic pool for which to get the current activity.
            /// </param>
            public static IEnumerable<ElasticPoolActivity> ListByElasticPool(this IElasticPoolActivitiesOperations operations, string resourceGroupName, string serverName, string elasticPoolName)
            {
                return operations.ListByElasticPoolAsync(resourceGroupName, serverName, elasticPoolName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns elastic pool activities.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='elasticPoolName'>
            /// The name of the elastic pool for which to get the current activity.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IEnumerable<ElasticPoolActivity>> ListByElasticPoolAsync(this IElasticPoolActivitiesOperations operations, string resourceGroupName, string serverName, string elasticPoolName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByElasticPoolWithHttpMessagesAsync(resourceGroupName, serverName, elasticPoolName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
