// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.MachineLearning.CommitmentPlans
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for CommitmentAssociationsOperations.
    /// </summary>
    public static partial class CommitmentAssociationsOperationsExtensions
    {
            /// <summary>
            /// Get a commitment association.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='commitmentPlanName'>
            /// The Azure ML commitment plan name.
            /// </param>
            /// <param name='commitmentAssociationName'>
            /// The commitment association name.
            /// </param>
            public static CommitmentAssociation Get(this ICommitmentAssociationsOperations operations, string resourceGroupName, string commitmentPlanName, string commitmentAssociationName)
            {
                return operations.GetAsync(resourceGroupName, commitmentPlanName, commitmentAssociationName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get a commitment association.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='commitmentPlanName'>
            /// The Azure ML commitment plan name.
            /// </param>
            /// <param name='commitmentAssociationName'>
            /// The commitment association name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<CommitmentAssociation> GetAsync(this ICommitmentAssociationsOperations operations, string resourceGroupName, string commitmentPlanName, string commitmentAssociationName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, commitmentPlanName, commitmentAssociationName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get all commitment associations for a parent commitment plan.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='commitmentPlanName'>
            /// The Azure ML commitment plan name.
            /// </param>
            /// <param name='skipToken'>
            /// Continuation token for pagination.
            /// </param>
            public static IPage<CommitmentAssociation> List(this ICommitmentAssociationsOperations operations, string resourceGroupName, string commitmentPlanName, string skipToken = default(string))
            {
                return operations.ListAsync(resourceGroupName, commitmentPlanName, skipToken).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get all commitment associations for a parent commitment plan.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='commitmentPlanName'>
            /// The Azure ML commitment plan name.
            /// </param>
            /// <param name='skipToken'>
            /// Continuation token for pagination.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<CommitmentAssociation>> ListAsync(this ICommitmentAssociationsOperations operations, string resourceGroupName, string commitmentPlanName, string skipToken = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, commitmentPlanName, skipToken, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Re-parent a commitment association from one commitment plan to another.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='commitmentPlanName'>
            /// The Azure ML commitment plan name.
            /// </param>
            /// <param name='commitmentAssociationName'>
            /// The commitment association name.
            /// </param>
            /// <param name='destinationPlanId'>
            /// The ARM ID of the commitment plan to re-parent the commitment association
            /// to.
            /// </param>
            public static CommitmentAssociation Move(this ICommitmentAssociationsOperations operations, string resourceGroupName, string commitmentPlanName, string commitmentAssociationName, string destinationPlanId = default(string))
            {
                return operations.MoveAsync(resourceGroupName, commitmentPlanName, commitmentAssociationName, destinationPlanId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Re-parent a commitment association from one commitment plan to another.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='commitmentPlanName'>
            /// The Azure ML commitment plan name.
            /// </param>
            /// <param name='commitmentAssociationName'>
            /// The commitment association name.
            /// </param>
            /// <param name='destinationPlanId'>
            /// The ARM ID of the commitment plan to re-parent the commitment association
            /// to.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<CommitmentAssociation> MoveAsync(this ICommitmentAssociationsOperations operations, string resourceGroupName, string commitmentPlanName, string commitmentAssociationName, string destinationPlanId = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.MoveWithHttpMessagesAsync(resourceGroupName, commitmentPlanName, commitmentAssociationName, destinationPlanId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get all commitment associations for a parent commitment plan.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<CommitmentAssociation> ListNext(this ICommitmentAssociationsOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get all commitment associations for a parent commitment plan.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<CommitmentAssociation>> ListNextAsync(this ICommitmentAssociationsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
