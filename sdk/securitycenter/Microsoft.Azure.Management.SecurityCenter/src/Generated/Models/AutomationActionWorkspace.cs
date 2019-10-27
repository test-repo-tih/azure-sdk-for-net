// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Security.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The Log Analytics Workspace to which event data will be exported.
    /// Security alerts data will reside in the 'SecurityAlert' table and the
    /// assessments data will reside in the 'SecurityRecommendation' table
    /// (under the 'Security'/'SecurityCenterFree' solutions). Note that in
    /// order to view the data in the workspace, the Security Center Log
    /// Analytics free/standard solution needs to be enabled on that workspace.
    /// </summary>
    [Newtonsoft.Json.JsonObject("Workspace")]
    public partial class AutomationActionWorkspace : AutomationAction
    {
        /// <summary>
        /// Initializes a new instance of the AutomationActionWorkspace class.
        /// </summary>
        public AutomationActionWorkspace()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AutomationActionWorkspace class.
        /// </summary>
        /// <param name="workspaceResourceId">The fully qualified Log Analytics
        /// Workspace Azure Resource ID.</param>
        /// <param name="workspaceId">The Log Analytics Workspace ID in a GUID
        /// format.</param>
        public AutomationActionWorkspace(string workspaceResourceId = default(string), string workspaceId = default(string))
        {
            WorkspaceResourceId = workspaceResourceId;
            WorkspaceId = workspaceId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the fully qualified Log Analytics Workspace Azure
        /// Resource ID.
        /// </summary>
        [JsonProperty(PropertyName = "workspaceResourceId")]
        public string WorkspaceResourceId { get; set; }

        /// <summary>
        /// Gets or sets the Log Analytics Workspace ID in a GUID format.
        /// </summary>
        [JsonProperty(PropertyName = "workspaceId")]
        public string WorkspaceId { get; set; }

    }
}
