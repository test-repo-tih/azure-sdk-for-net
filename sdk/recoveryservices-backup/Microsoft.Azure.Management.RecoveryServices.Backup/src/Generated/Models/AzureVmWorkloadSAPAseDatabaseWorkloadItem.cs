// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.RecoveryServices.Backup.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Azure VM workload-specific workload item representing SAP ASE Database.
    /// </summary>
    [Newtonsoft.Json.JsonObject("SAPAseDatabase")]
    public partial class AzureVmWorkloadSAPAseDatabaseWorkloadItem : AzureVmWorkloadItem
    {
        /// <summary>
        /// Initializes a new instance of the
        /// AzureVmWorkloadSAPAseDatabaseWorkloadItem class.
        /// </summary>
        public AzureVmWorkloadSAPAseDatabaseWorkloadItem()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// AzureVmWorkloadSAPAseDatabaseWorkloadItem class.
        /// </summary>
        /// <param name="backupManagementType">Type of backup management to
        /// backup an item.</param>
        /// <param name="workloadType">Type of workload for the backup
        /// management</param>
        /// <param name="friendlyName">Friendly name of the backup
        /// item.</param>
        /// <param name="protectionState">State of the back up item. Possible
        /// values include: 'Invalid', 'NotProtected', 'Protecting',
        /// 'Protected', 'ProtectionFailed'</param>
        /// <param name="parentName">Name for instance or AG</param>
        /// <param name="serverName">Host/Cluster Name for instance or
        /// AG</param>
        /// <param name="isAutoProtectable">Indicates if workload item is
        /// auto-protectable</param>
        /// <param name="subinquireditemcount">For instance or AG, indicates
        /// number of DBs present</param>
        /// <param name="subWorkloadItemCount">For instance or AG, indicates
        /// number of DBs to be protected</param>
        public AzureVmWorkloadSAPAseDatabaseWorkloadItem(string backupManagementType = default(string), string workloadType = default(string), string friendlyName = default(string), string protectionState = default(string), string parentName = default(string), string serverName = default(string), bool? isAutoProtectable = default(bool?), int? subinquireditemcount = default(int?), int? subWorkloadItemCount = default(int?))
            : base(backupManagementType, workloadType, friendlyName, protectionState, parentName, serverName, isAutoProtectable, subinquireditemcount, subWorkloadItemCount)
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

    }
}
