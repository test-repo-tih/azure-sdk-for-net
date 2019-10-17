// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Compute.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Describes a Virtual Machine Scale Set.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class VirtualMachineScaleSetUpdate : UpdateResource
    {
        /// <summary>
        /// Initializes a new instance of the VirtualMachineScaleSetUpdate
        /// class.
        /// </summary>
        public VirtualMachineScaleSetUpdate()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the VirtualMachineScaleSetUpdate
        /// class.
        /// </summary>
        /// <param name="tags">Resource tags</param>
        /// <param name="sku">The virtual machine scale set sku.</param>
        /// <param name="plan">The purchase plan when deploying a virtual
        /// machine scale set from VM Marketplace images.</param>
        /// <param name="upgradePolicy">The upgrade policy.</param>
        /// <param name="virtualMachineProfile">The virtual machine
        /// profile.</param>
        /// <param name="overprovision">Specifies whether the Virtual Machine
        /// Scale Set should be overprovisioned.</param>
        /// <param name="doNotRunExtensionsOnOverprovisionedVMs">When
        /// Overprovision is enabled, extensions are launched only on the
        /// requested number of VMs which are finally kept. This property will
        /// hence ensure that the extensions do not run on the extra
        /// overprovisioned VMs.</param>
        /// <param name="singlePlacementGroup">When true this limits the scale
        /// set to a single placement group, of max size 100 virtual
        /// machines.</param>
        /// <param name="additionalCapabilities">Specifies additional
        /// capabilities enabled or disabled on the Virtual Machines in the
        /// Virtual Machine Scale Set. For instance: whether the Virtual
        /// Machines have the capability to support attaching managed data
        /// disks with UltraSSD_LRS storage account type.</param>
        /// <param name="scaleInPolicy">Specifies the scale-in policy that
        /// decides which virtual machines are chosen for removal when a
        /// Virtual Machine Scale Set is scaled-in.</param>
        /// <param name="identity">The identity of the virtual machine scale
        /// set, if configured.</param>
        public VirtualMachineScaleSetUpdate(IDictionary<string, string> tags = default(IDictionary<string, string>), Sku sku = default(Sku), Plan plan = default(Plan), UpgradePolicy upgradePolicy = default(UpgradePolicy), VirtualMachineScaleSetUpdateVMProfile virtualMachineProfile = default(VirtualMachineScaleSetUpdateVMProfile), bool? overprovision = default(bool?), bool? doNotRunExtensionsOnOverprovisionedVMs = default(bool?), bool? singlePlacementGroup = default(bool?), AdditionalCapabilities additionalCapabilities = default(AdditionalCapabilities), ScaleInPolicy scaleInPolicy = default(ScaleInPolicy), VirtualMachineScaleSetIdentity identity = default(VirtualMachineScaleSetIdentity))
            : base(tags)
        {
            Sku = sku;
            Plan = plan;
            UpgradePolicy = upgradePolicy;
            VirtualMachineProfile = virtualMachineProfile;
            Overprovision = overprovision;
            DoNotRunExtensionsOnOverprovisionedVMs = doNotRunExtensionsOnOverprovisionedVMs;
            SinglePlacementGroup = singlePlacementGroup;
            AdditionalCapabilities = additionalCapabilities;
            ScaleInPolicy = scaleInPolicy;
            Identity = identity;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the virtual machine scale set sku.
        /// </summary>
        [JsonProperty(PropertyName = "sku")]
        public Sku Sku { get; set; }

        /// <summary>
        /// Gets or sets the purchase plan when deploying a virtual machine
        /// scale set from VM Marketplace images.
        /// </summary>
        [JsonProperty(PropertyName = "plan")]
        public Plan Plan { get; set; }

        /// <summary>
        /// Gets or sets the upgrade policy.
        /// </summary>
        [JsonProperty(PropertyName = "properties.upgradePolicy")]
        public UpgradePolicy UpgradePolicy { get; set; }

        /// <summary>
        /// Gets or sets the virtual machine profile.
        /// </summary>
        [JsonProperty(PropertyName = "properties.virtualMachineProfile")]
        public VirtualMachineScaleSetUpdateVMProfile VirtualMachineProfile { get; set; }

        /// <summary>
        /// Gets or sets specifies whether the Virtual Machine Scale Set should
        /// be overprovisioned.
        /// </summary>
        [JsonProperty(PropertyName = "properties.overprovision")]
        public bool? Overprovision { get; set; }

        /// <summary>
        /// Gets or sets when Overprovision is enabled, extensions are launched
        /// only on the requested number of VMs which are finally kept. This
        /// property will hence ensure that the extensions do not run on the
        /// extra overprovisioned VMs.
        /// </summary>
        [JsonProperty(PropertyName = "properties.doNotRunExtensionsOnOverprovisionedVMs")]
        public bool? DoNotRunExtensionsOnOverprovisionedVMs { get; set; }

        /// <summary>
        /// Gets or sets when true this limits the scale set to a single
        /// placement group, of max size 100 virtual machines.
        /// </summary>
        [JsonProperty(PropertyName = "properties.singlePlacementGroup")]
        public bool? SinglePlacementGroup { get; set; }

        /// <summary>
        /// Gets or sets specifies additional capabilities enabled or disabled
        /// on the Virtual Machines in the Virtual Machine Scale Set. For
        /// instance: whether the Virtual Machines have the capability to
        /// support attaching managed data disks with UltraSSD_LRS storage
        /// account type.
        /// </summary>
        [JsonProperty(PropertyName = "properties.additionalCapabilities")]
        public AdditionalCapabilities AdditionalCapabilities { get; set; }

        /// <summary>
        /// Gets or sets specifies the scale-in policy that decides which
        /// virtual machines are chosen for removal when a Virtual Machine
        /// Scale Set is scaled-in.
        /// </summary>
        [JsonProperty(PropertyName = "properties.scaleInPolicy")]
        public ScaleInPolicy ScaleInPolicy { get; set; }

        /// <summary>
        /// Gets or sets the identity of the virtual machine scale set, if
        /// configured.
        /// </summary>
        [JsonProperty(PropertyName = "identity")]
        public VirtualMachineScaleSetIdentity Identity { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (UpgradePolicy != null)
            {
                UpgradePolicy.Validate();
            }
        }
    }
}
