// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Reservations
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for QuotaRequestsOperations.
    /// </summary>
    public static partial class QuotaRequestsOperationsExtensions
    {
            /// <summary>
            /// Submits Quota Requests for the resources by a resource provider at the
            /// specified location.
            /// </summary>
            /// <remarks>
            /// Submits Quota change requests for the resources by a resource provider for
            /// the specified location. To use, first make a Get request to get quota
            /// information. This information consists of a list of resources and
            /// information regarding those resources. For all the resources in that list
            /// which require an update to their quotas, update their limit fields in the
            /// response from the Get request to their new values. Then, submit this
            /// updated JSON object to this quota request API. This will update the quotas
            /// to the values specified. For updating only few resources, please use Patch.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='subscriptionId'>
            /// Azure subscription id.
            /// </param>
            /// <param name='providerId'>
            /// Azure resource Provider id.
            /// </param>
            /// <param name='location'>
            /// Azure region.
            /// </param>
            /// <param name='createQuotaRequests'>
            /// Quota requests payload.
            /// </param>
            /// <param name='ifMatch'>
            /// ETag of the Entity. ETag should match the current entity state from the
            /// header response of the GET request or it should be * for unconditional
            /// update.
            /// </param>
            public static object Create(this IQuotaRequestsOperations operations, string subscriptionId, string providerId, string location, QuotaLimits createQuotaRequests, string ifMatch)
            {
                return operations.CreateAsync(subscriptionId, providerId, location, createQuotaRequests, ifMatch).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Submits Quota Requests for the resources by a resource provider at the
            /// specified location.
            /// </summary>
            /// <remarks>
            /// Submits Quota change requests for the resources by a resource provider for
            /// the specified location. To use, first make a Get request to get quota
            /// information. This information consists of a list of resources and
            /// information regarding those resources. For all the resources in that list
            /// which require an update to their quotas, update their limit fields in the
            /// response from the Get request to their new values. Then, submit this
            /// updated JSON object to this quota request API. This will update the quotas
            /// to the values specified. For updating only few resources, please use Patch.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='subscriptionId'>
            /// Azure subscription id.
            /// </param>
            /// <param name='providerId'>
            /// Azure resource Provider id.
            /// </param>
            /// <param name='location'>
            /// Azure region.
            /// </param>
            /// <param name='createQuotaRequests'>
            /// Quota requests payload.
            /// </param>
            /// <param name='ifMatch'>
            /// ETag of the Entity. ETag should match the current entity state from the
            /// header response of the GET request or it should be * for unconditional
            /// update.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> CreateAsync(this IQuotaRequestsOperations operations, string subscriptionId, string providerId, string location, QuotaLimits createQuotaRequests, string ifMatch, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateWithHttpMessagesAsync(subscriptionId, providerId, location, createQuotaRequests, ifMatch, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Submits a Quota Requests for multiple resources by a resource provider at
            /// the specified location.
            /// </summary>
            /// <remarks>
            /// Submits Quota change requests for multiple resources by a resource provider
            /// for the specified location. To use, first make a Get request to get quota
            /// information. This information consists of a list of resources and
            /// information regarding those resources. For all the resources in that list
            /// which require an update to their quotas, update their limit fields in the
            /// response from the Get request to their new values, remove the values which
            /// doesn't require any update. Then, submit this updated JSON object to this
            /// quota request API. This will update the quotas to the values specified.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='subscriptionId'>
            /// Azure subscription id.
            /// </param>
            /// <param name='providerId'>
            /// Azure resource Provider id.
            /// </param>
            /// <param name='location'>
            /// Azure region.
            /// </param>
            /// <param name='createQuotaRequests'>
            /// Quota requests payload.
            /// </param>
            /// <param name='ifMatch'>
            /// ETag of the Entity. ETag should match the current entity state from the
            /// header response of the GET request or it should be * for unconditional
            /// update.
            /// </param>
            public static object Update(this IQuotaRequestsOperations operations, string subscriptionId, string providerId, string location, QuotaLimits createQuotaRequests, string ifMatch)
            {
                return operations.UpdateAsync(subscriptionId, providerId, location, createQuotaRequests, ifMatch).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Submits a Quota Requests for multiple resources by a resource provider at
            /// the specified location.
            /// </summary>
            /// <remarks>
            /// Submits Quota change requests for multiple resources by a resource provider
            /// for the specified location. To use, first make a Get request to get quota
            /// information. This information consists of a list of resources and
            /// information regarding those resources. For all the resources in that list
            /// which require an update to their quotas, update their limit fields in the
            /// response from the Get request to their new values, remove the values which
            /// doesn't require any update. Then, submit this updated JSON object to this
            /// quota request API. This will update the quotas to the values specified.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='subscriptionId'>
            /// Azure subscription id.
            /// </param>
            /// <param name='providerId'>
            /// Azure resource Provider id.
            /// </param>
            /// <param name='location'>
            /// Azure region.
            /// </param>
            /// <param name='createQuotaRequests'>
            /// Quota requests payload.
            /// </param>
            /// <param name='ifMatch'>
            /// ETag of the Entity. ETag should match the current entity state from the
            /// header response of the GET request or it should be * for unconditional
            /// update.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> UpdateAsync(this IQuotaRequestsOperations operations, string subscriptionId, string providerId, string location, QuotaLimits createQuotaRequests, string ifMatch, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(subscriptionId, providerId, location, createQuotaRequests, ifMatch, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the Quota request status by requestId, for the specified resource
            /// provider at specified location.
            /// </summary>
            /// <remarks>
            /// Gets the QuotaRequest details and status by the quota requestId for the
            /// resources for the resource provider at a specific location. The requestId
            /// is returned as response to the Put requests for serviceLimits.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='subscriptionId'>
            /// Azure subscription id.
            /// </param>
            /// <param name='providerId'>
            /// Azure resource Provider id.
            /// </param>
            /// <param name='location'>
            /// Azure region.
            /// </param>
            public static QuotaRequestDetails GetStatus(this IQuotaRequestsOperations operations, string subscriptionId, string providerId, string location)
            {
                return operations.GetStatusAsync(subscriptionId, providerId, location).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the Quota request status by requestId, for the specified resource
            /// provider at specified location.
            /// </summary>
            /// <remarks>
            /// Gets the QuotaRequest details and status by the quota requestId for the
            /// resources for the resource provider at a specific location. The requestId
            /// is returned as response to the Put requests for serviceLimits.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='subscriptionId'>
            /// Azure subscription id.
            /// </param>
            /// <param name='providerId'>
            /// Azure resource Provider id.
            /// </param>
            /// <param name='location'>
            /// Azure region.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<QuotaRequestDetails> GetStatusAsync(this IQuotaRequestsOperations operations, string subscriptionId, string providerId, string location, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetStatusWithHttpMessagesAsync(subscriptionId, providerId, location, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// For the specified location and resource Provider, gets the quota requests
            /// under the subscription over the time
            /// period of one year ago from now to one year back, based on the filter
            /// specified.
            /// </summary>
            /// <remarks>
            /// For the specified location and Resource provider gets the current quota
            /// requests under the subscription over the time period of one year ago from
            /// now to one year back. oData filter can be used to select quota requests.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='subscriptionId'>
            /// Azure subscription id.
            /// </param>
            /// <param name='providerId'>
            /// Azure resource Provider id.
            /// </param>
            /// <param name='location'>
            /// Azure region.
            /// </param>
            /// <param name='filter'>
            /// | Field                    | Supported operators
            /// |---------------------|------------------------
            ///
            /// |requestSubmitTime | ge, le, eq, gt, lt
            /// </param>
            /// <param name='top'>
            /// Number of records to return.
            /// </param>
            /// <param name='skiptoken'>
            /// Skiptoken is only used if a previous operation returned a partial result.
            /// If a previous response contains a nextLink element, the value of the
            /// nextLink element will include a skiptoken parameter that specifies a
            /// starting point to use for subsequent calls
            /// </param>
            public static IPage<QuotaRequestDetails> ListStatus(this IQuotaRequestsOperations operations, string subscriptionId, string providerId, string location, string filter = default(string), int? top = default(int?), string skiptoken = default(string))
            {
                return operations.ListStatusAsync(subscriptionId, providerId, location, filter, top, skiptoken).GetAwaiter().GetResult();
            }

            /// <summary>
            /// For the specified location and resource Provider, gets the quota requests
            /// under the subscription over the time
            /// period of one year ago from now to one year back, based on the filter
            /// specified.
            /// </summary>
            /// <remarks>
            /// For the specified location and Resource provider gets the current quota
            /// requests under the subscription over the time period of one year ago from
            /// now to one year back. oData filter can be used to select quota requests.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='subscriptionId'>
            /// Azure subscription id.
            /// </param>
            /// <param name='providerId'>
            /// Azure resource Provider id.
            /// </param>
            /// <param name='location'>
            /// Azure region.
            /// </param>
            /// <param name='filter'>
            /// | Field                    | Supported operators
            /// |---------------------|------------------------
            ///
            /// |requestSubmitTime | ge, le, eq, gt, lt
            /// </param>
            /// <param name='top'>
            /// Number of records to return.
            /// </param>
            /// <param name='skiptoken'>
            /// Skiptoken is only used if a previous operation returned a partial result.
            /// If a previous response contains a nextLink element, the value of the
            /// nextLink element will include a skiptoken parameter that specifies a
            /// starting point to use for subsequent calls
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<QuotaRequestDetails>> ListStatusAsync(this IQuotaRequestsOperations operations, string subscriptionId, string providerId, string location, string filter = default(string), int? top = default(int?), string skiptoken = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListStatusWithHttpMessagesAsync(subscriptionId, providerId, location, filter, top, skiptoken, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Submits Quota Requests for the resources by a resource provider at the
            /// specified location.
            /// </summary>
            /// <remarks>
            /// Submits Quota change requests for the resources by a resource provider for
            /// the specified location. To use, first make a Get request to get quota
            /// information. This information consists of a list of resources and
            /// information regarding those resources. For all the resources in that list
            /// which require an update to their quotas, update their limit fields in the
            /// response from the Get request to their new values. Then, submit this
            /// updated JSON object to this quota request API. This will update the quotas
            /// to the values specified. For updating only few resources, please use Patch.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='subscriptionId'>
            /// Azure subscription id.
            /// </param>
            /// <param name='providerId'>
            /// Azure resource Provider id.
            /// </param>
            /// <param name='location'>
            /// Azure region.
            /// </param>
            /// <param name='createQuotaRequests'>
            /// Quota requests payload.
            /// </param>
            /// <param name='ifMatch'>
            /// ETag of the Entity. ETag should match the current entity state from the
            /// header response of the GET request or it should be * for unconditional
            /// update.
            /// </param>
            public static object BeginCreate(this IQuotaRequestsOperations operations, string subscriptionId, string providerId, string location, QuotaLimits createQuotaRequests, string ifMatch)
            {
                return operations.BeginCreateAsync(subscriptionId, providerId, location, createQuotaRequests, ifMatch).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Submits Quota Requests for the resources by a resource provider at the
            /// specified location.
            /// </summary>
            /// <remarks>
            /// Submits Quota change requests for the resources by a resource provider for
            /// the specified location. To use, first make a Get request to get quota
            /// information. This information consists of a list of resources and
            /// information regarding those resources. For all the resources in that list
            /// which require an update to their quotas, update their limit fields in the
            /// response from the Get request to their new values. Then, submit this
            /// updated JSON object to this quota request API. This will update the quotas
            /// to the values specified. For updating only few resources, please use Patch.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='subscriptionId'>
            /// Azure subscription id.
            /// </param>
            /// <param name='providerId'>
            /// Azure resource Provider id.
            /// </param>
            /// <param name='location'>
            /// Azure region.
            /// </param>
            /// <param name='createQuotaRequests'>
            /// Quota requests payload.
            /// </param>
            /// <param name='ifMatch'>
            /// ETag of the Entity. ETag should match the current entity state from the
            /// header response of the GET request or it should be * for unconditional
            /// update.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> BeginCreateAsync(this IQuotaRequestsOperations operations, string subscriptionId, string providerId, string location, QuotaLimits createQuotaRequests, string ifMatch, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateWithHttpMessagesAsync(subscriptionId, providerId, location, createQuotaRequests, ifMatch, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Submits a Quota Requests for multiple resources by a resource provider at
            /// the specified location.
            /// </summary>
            /// <remarks>
            /// Submits Quota change requests for multiple resources by a resource provider
            /// for the specified location. To use, first make a Get request to get quota
            /// information. This information consists of a list of resources and
            /// information regarding those resources. For all the resources in that list
            /// which require an update to their quotas, update their limit fields in the
            /// response from the Get request to their new values, remove the values which
            /// doesn't require any update. Then, submit this updated JSON object to this
            /// quota request API. This will update the quotas to the values specified.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='subscriptionId'>
            /// Azure subscription id.
            /// </param>
            /// <param name='providerId'>
            /// Azure resource Provider id.
            /// </param>
            /// <param name='location'>
            /// Azure region.
            /// </param>
            /// <param name='createQuotaRequests'>
            /// Quota requests payload.
            /// </param>
            /// <param name='ifMatch'>
            /// ETag of the Entity. ETag should match the current entity state from the
            /// header response of the GET request or it should be * for unconditional
            /// update.
            /// </param>
            public static object BeginUpdate(this IQuotaRequestsOperations operations, string subscriptionId, string providerId, string location, QuotaLimits createQuotaRequests, string ifMatch)
            {
                return operations.BeginUpdateAsync(subscriptionId, providerId, location, createQuotaRequests, ifMatch).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Submits a Quota Requests for multiple resources by a resource provider at
            /// the specified location.
            /// </summary>
            /// <remarks>
            /// Submits Quota change requests for multiple resources by a resource provider
            /// for the specified location. To use, first make a Get request to get quota
            /// information. This information consists of a list of resources and
            /// information regarding those resources. For all the resources in that list
            /// which require an update to their quotas, update their limit fields in the
            /// response from the Get request to their new values, remove the values which
            /// doesn't require any update. Then, submit this updated JSON object to this
            /// quota request API. This will update the quotas to the values specified.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='subscriptionId'>
            /// Azure subscription id.
            /// </param>
            /// <param name='providerId'>
            /// Azure resource Provider id.
            /// </param>
            /// <param name='location'>
            /// Azure region.
            /// </param>
            /// <param name='createQuotaRequests'>
            /// Quota requests payload.
            /// </param>
            /// <param name='ifMatch'>
            /// ETag of the Entity. ETag should match the current entity state from the
            /// header response of the GET request or it should be * for unconditional
            /// update.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> BeginUpdateAsync(this IQuotaRequestsOperations operations, string subscriptionId, string providerId, string location, QuotaLimits createQuotaRequests, string ifMatch, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginUpdateWithHttpMessagesAsync(subscriptionId, providerId, location, createQuotaRequests, ifMatch, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// For the specified location and resource Provider, gets the quota requests
            /// under the subscription over the time
            /// period of one year ago from now to one year back, based on the filter
            /// specified.
            /// </summary>
            /// <remarks>
            /// For the specified location and Resource provider gets the current quota
            /// requests under the subscription over the time period of one year ago from
            /// now to one year back. oData filter can be used to select quota requests.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<QuotaRequestDetails> ListStatusNext(this IQuotaRequestsOperations operations, string nextPageLink)
            {
                return operations.ListStatusNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// For the specified location and resource Provider, gets the quota requests
            /// under the subscription over the time
            /// period of one year ago from now to one year back, based on the filter
            /// specified.
            /// </summary>
            /// <remarks>
            /// For the specified location and Resource provider gets the current quota
            /// requests under the subscription over the time period of one year ago from
            /// now to one year back. oData filter can be used to select quota requests.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<QuotaRequestDetails>> ListStatusNextAsync(this IQuotaRequestsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListStatusNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
