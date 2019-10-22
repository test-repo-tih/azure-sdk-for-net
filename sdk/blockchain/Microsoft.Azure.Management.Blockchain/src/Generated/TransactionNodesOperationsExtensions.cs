// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Blockchain
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for TransactionNodesOperations.
    /// </summary>
    public static partial class TransactionNodesOperationsExtensions
    {
            /// <summary>
            /// Get the details of the transaction node.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='blockchainMemberName'>
            /// Blockchain member name.
            /// </param>
            /// <param name='transactionNodeName'>
            /// Transaction node name.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            public static TransactionNode Get(this ITransactionNodesOperations operations, string blockchainMemberName, string transactionNodeName, string resourceGroupName)
            {
                return operations.GetAsync(blockchainMemberName, transactionNodeName, resourceGroupName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get the details of the transaction node.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='blockchainMemberName'>
            /// Blockchain member name.
            /// </param>
            /// <param name='transactionNodeName'>
            /// Transaction node name.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<TransactionNode> GetAsync(this ITransactionNodesOperations operations, string blockchainMemberName, string transactionNodeName, string resourceGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(blockchainMemberName, transactionNodeName, resourceGroupName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create or update the transaction node.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='blockchainMemberName'>
            /// Blockchain member name.
            /// </param>
            /// <param name='transactionNodeName'>
            /// Transaction node name.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='transactionNode'>
            /// Payload to create the transaction node.
            /// </param>
            public static TransactionNode Create(this ITransactionNodesOperations operations, string blockchainMemberName, string transactionNodeName, string resourceGroupName, TransactionNode transactionNode = default(TransactionNode))
            {
                return operations.CreateAsync(blockchainMemberName, transactionNodeName, resourceGroupName, transactionNode).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create or update the transaction node.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='blockchainMemberName'>
            /// Blockchain member name.
            /// </param>
            /// <param name='transactionNodeName'>
            /// Transaction node name.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='transactionNode'>
            /// Payload to create the transaction node.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<TransactionNode> CreateAsync(this ITransactionNodesOperations operations, string blockchainMemberName, string transactionNodeName, string resourceGroupName, TransactionNode transactionNode = default(TransactionNode), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateWithHttpMessagesAsync(blockchainMemberName, transactionNodeName, resourceGroupName, transactionNode, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete the transaction node.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='blockchainMemberName'>
            /// Blockchain member name.
            /// </param>
            /// <param name='transactionNodeName'>
            /// Transaction node name.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            public static void Delete(this ITransactionNodesOperations operations, string blockchainMemberName, string transactionNodeName, string resourceGroupName)
            {
                operations.DeleteAsync(blockchainMemberName, transactionNodeName, resourceGroupName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete the transaction node.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='blockchainMemberName'>
            /// Blockchain member name.
            /// </param>
            /// <param name='transactionNodeName'>
            /// Transaction node name.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this ITransactionNodesOperations operations, string blockchainMemberName, string transactionNodeName, string resourceGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(blockchainMemberName, transactionNodeName, resourceGroupName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Update the transaction node.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='blockchainMemberName'>
            /// Blockchain member name.
            /// </param>
            /// <param name='transactionNodeName'>
            /// Transaction node name.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='password'>
            /// Sets the transaction node dns endpoint basic auth password.
            /// </param>
            /// <param name='firewallRules'>
            /// Gets or sets the firewall rules.
            /// </param>
            public static TransactionNode Update(this ITransactionNodesOperations operations, string blockchainMemberName, string transactionNodeName, string resourceGroupName, string password = default(string), IList<FirewallRule> firewallRules = default(IList<FirewallRule>))
            {
                return operations.UpdateAsync(blockchainMemberName, transactionNodeName, resourceGroupName, password, firewallRules).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Update the transaction node.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='blockchainMemberName'>
            /// Blockchain member name.
            /// </param>
            /// <param name='transactionNodeName'>
            /// Transaction node name.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='password'>
            /// Sets the transaction node dns endpoint basic auth password.
            /// </param>
            /// <param name='firewallRules'>
            /// Gets or sets the firewall rules.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<TransactionNode> UpdateAsync(this ITransactionNodesOperations operations, string blockchainMemberName, string transactionNodeName, string resourceGroupName, string password = default(string), IList<FirewallRule> firewallRules = default(IList<FirewallRule>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(blockchainMemberName, transactionNodeName, resourceGroupName, password, firewallRules, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists the transaction nodes for a blockchain member.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='blockchainMemberName'>
            /// Blockchain member name.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            public static IPage<TransactionNode> List(this ITransactionNodesOperations operations, string blockchainMemberName, string resourceGroupName)
            {
                return operations.ListAsync(blockchainMemberName, resourceGroupName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists the transaction nodes for a blockchain member.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='blockchainMemberName'>
            /// Blockchain member name.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<TransactionNode>> ListAsync(this ITransactionNodesOperations operations, string blockchainMemberName, string resourceGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(blockchainMemberName, resourceGroupName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// List the API keys for the transaction node.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='blockchainMemberName'>
            /// Blockchain member name.
            /// </param>
            /// <param name='transactionNodeName'>
            /// Transaction node name.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            public static ApiKeyCollection ListApiKeys(this ITransactionNodesOperations operations, string blockchainMemberName, string transactionNodeName, string resourceGroupName)
            {
                return operations.ListApiKeysAsync(blockchainMemberName, transactionNodeName, resourceGroupName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List the API keys for the transaction node.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='blockchainMemberName'>
            /// Blockchain member name.
            /// </param>
            /// <param name='transactionNodeName'>
            /// Transaction node name.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ApiKeyCollection> ListApiKeysAsync(this ITransactionNodesOperations operations, string blockchainMemberName, string transactionNodeName, string resourceGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListApiKeysWithHttpMessagesAsync(blockchainMemberName, transactionNodeName, resourceGroupName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Regenerate the API keys for the blockchain member.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='blockchainMemberName'>
            /// Blockchain member name.
            /// </param>
            /// <param name='transactionNodeName'>
            /// Transaction node name.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='keyName'>
            /// Gets or sets the API key name.
            /// </param>
            /// <param name='value'>
            /// Gets or sets the API key value.
            /// </param>
            public static ApiKeyCollection RegenerateApiKeys(this ITransactionNodesOperations operations, string blockchainMemberName, string transactionNodeName, string resourceGroupName, string keyName = default(string), string value = default(string))
            {
                return operations.RegenerateApiKeysAsync(blockchainMemberName, transactionNodeName, resourceGroupName, keyName, value).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Regenerate the API keys for the blockchain member.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='blockchainMemberName'>
            /// Blockchain member name.
            /// </param>
            /// <param name='transactionNodeName'>
            /// Transaction node name.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='keyName'>
            /// Gets or sets the API key name.
            /// </param>
            /// <param name='value'>
            /// Gets or sets the API key value.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ApiKeyCollection> RegenerateApiKeysAsync(this ITransactionNodesOperations operations, string blockchainMemberName, string transactionNodeName, string resourceGroupName, string keyName = default(string), string value = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.RegenerateApiKeysWithHttpMessagesAsync(blockchainMemberName, transactionNodeName, resourceGroupName, keyName, value, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create or update the transaction node.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='blockchainMemberName'>
            /// Blockchain member name.
            /// </param>
            /// <param name='transactionNodeName'>
            /// Transaction node name.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='transactionNode'>
            /// Payload to create the transaction node.
            /// </param>
            public static TransactionNode BeginCreate(this ITransactionNodesOperations operations, string blockchainMemberName, string transactionNodeName, string resourceGroupName, TransactionNode transactionNode = default(TransactionNode))
            {
                return operations.BeginCreateAsync(blockchainMemberName, transactionNodeName, resourceGroupName, transactionNode).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create or update the transaction node.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='blockchainMemberName'>
            /// Blockchain member name.
            /// </param>
            /// <param name='transactionNodeName'>
            /// Transaction node name.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='transactionNode'>
            /// Payload to create the transaction node.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<TransactionNode> BeginCreateAsync(this ITransactionNodesOperations operations, string blockchainMemberName, string transactionNodeName, string resourceGroupName, TransactionNode transactionNode = default(TransactionNode), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateWithHttpMessagesAsync(blockchainMemberName, transactionNodeName, resourceGroupName, transactionNode, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete the transaction node.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='blockchainMemberName'>
            /// Blockchain member name.
            /// </param>
            /// <param name='transactionNodeName'>
            /// Transaction node name.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            public static void BeginDelete(this ITransactionNodesOperations operations, string blockchainMemberName, string transactionNodeName, string resourceGroupName)
            {
                operations.BeginDeleteAsync(blockchainMemberName, transactionNodeName, resourceGroupName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete the transaction node.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='blockchainMemberName'>
            /// Blockchain member name.
            /// </param>
            /// <param name='transactionNodeName'>
            /// Transaction node name.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeleteAsync(this ITransactionNodesOperations operations, string blockchainMemberName, string transactionNodeName, string resourceGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginDeleteWithHttpMessagesAsync(blockchainMemberName, transactionNodeName, resourceGroupName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Lists the transaction nodes for a blockchain member.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<TransactionNode> ListNext(this ITransactionNodesOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists the transaction nodes for a blockchain member.
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
            public static async Task<IPage<TransactionNode>> ListNextAsync(this ITransactionNodesOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
