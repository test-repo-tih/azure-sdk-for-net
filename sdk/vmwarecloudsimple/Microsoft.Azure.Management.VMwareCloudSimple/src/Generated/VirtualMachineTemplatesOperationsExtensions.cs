// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.VMwareCloudSimple
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for VirtualMachineTemplatesOperations.
    /// </summary>
    public static partial class VirtualMachineTemplatesOperationsExtensions
    {
            /// <summary>
            /// Implements list of available VM templates
            /// </summary>
            /// <remarks>
            /// Returns list of virtual machine templates in region for private cloud
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='pcName'>
            /// The private cloud name
            /// </param>
            /// <param name='regionId'>
            /// The region Id (westus, eastus)
            /// </param>
            /// <param name='resourcePoolName'>
            /// Resource pool used to derive vSphere cluster which contains VM templates
            /// </param>
            public static IPage<VirtualMachineTemplate> List(this IVirtualMachineTemplatesOperations operations, string pcName, string regionId, string resourcePoolName)
            {
                return operations.ListAsync(pcName, regionId, resourcePoolName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Implements list of available VM templates
            /// </summary>
            /// <remarks>
            /// Returns list of virtual machine templates in region for private cloud
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='pcName'>
            /// The private cloud name
            /// </param>
            /// <param name='regionId'>
            /// The region Id (westus, eastus)
            /// </param>
            /// <param name='resourcePoolName'>
            /// Resource pool used to derive vSphere cluster which contains VM templates
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<VirtualMachineTemplate>> ListAsync(this IVirtualMachineTemplatesOperations operations, string pcName, string regionId, string resourcePoolName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(pcName, regionId, resourcePoolName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Implements virtual machine template GET method
            /// </summary>
            /// <remarks>
            /// Returns virtual machine templates by its name
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='regionId'>
            /// The region Id (westus, eastus)
            /// </param>
            /// <param name='pcName'>
            /// The private cloud name
            /// </param>
            /// <param name='virtualMachineTemplateName'>
            /// virtual machine template id (vsphereId)
            /// </param>
            public static VirtualMachineTemplate Get(this IVirtualMachineTemplatesOperations operations, string regionId, string pcName, string virtualMachineTemplateName)
            {
                return operations.GetAsync(regionId, pcName, virtualMachineTemplateName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Implements virtual machine template GET method
            /// </summary>
            /// <remarks>
            /// Returns virtual machine templates by its name
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='regionId'>
            /// The region Id (westus, eastus)
            /// </param>
            /// <param name='pcName'>
            /// The private cloud name
            /// </param>
            /// <param name='virtualMachineTemplateName'>
            /// virtual machine template id (vsphereId)
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<VirtualMachineTemplate> GetAsync(this IVirtualMachineTemplatesOperations operations, string regionId, string pcName, string virtualMachineTemplateName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(regionId, pcName, virtualMachineTemplateName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Implements list of available VM templates
            /// </summary>
            /// <remarks>
            /// Returns list of virtual machine templates in region for private cloud
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<VirtualMachineTemplate> ListNext(this IVirtualMachineTemplatesOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Implements list of available VM templates
            /// </summary>
            /// <remarks>
            /// Returns list of virtual machine templates in region for private cloud
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
            public static async Task<IPage<VirtualMachineTemplate>> ListNextAsync(this IVirtualMachineTemplatesOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
