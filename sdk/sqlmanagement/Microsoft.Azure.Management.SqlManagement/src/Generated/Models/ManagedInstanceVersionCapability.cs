// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Sql.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The managed instance capability
    /// </summary>
    public partial class ManagedInstanceVersionCapability
    {
        /// <summary>
        /// Initializes a new instance of the ManagedInstanceVersionCapability
        /// class.
        /// </summary>
        public ManagedInstanceVersionCapability()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ManagedInstanceVersionCapability
        /// class.
        /// </summary>
        /// <param name="name">The server version name.</param>
        /// <param name="supportedEditions">The list of supported managed
        /// instance editions.</param>
        /// <param name="supportedInstancePoolEditions">The list of supported
        /// instance pool editions.</param>
        /// <param name="status">The status of the capability. Possible values
        /// include: 'Visible', 'Available', 'Default', 'Disabled'</param>
        /// <param name="reason">The reason for the capability not being
        /// available.</param>
        public ManagedInstanceVersionCapability(string name = default(string), IList<ManagedInstanceEditionCapability> supportedEditions = default(IList<ManagedInstanceEditionCapability>), IList<InstancePoolEditionCapability> supportedInstancePoolEditions = default(IList<InstancePoolEditionCapability>), CapabilityStatus? status = default(CapabilityStatus?), string reason = default(string))
        {
            Name = name;
            SupportedEditions = supportedEditions;
            SupportedInstancePoolEditions = supportedInstancePoolEditions;
            Status = status;
            Reason = reason;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the server version name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        /// <summary>
        /// Gets the list of supported managed instance editions.
        /// </summary>
        [JsonProperty(PropertyName = "supportedEditions")]
        public IList<ManagedInstanceEditionCapability> SupportedEditions { get; private set; }

        /// <summary>
        /// Gets the list of supported instance pool editions.
        /// </summary>
        [JsonProperty(PropertyName = "supportedInstancePoolEditions")]
        public IList<InstancePoolEditionCapability> SupportedInstancePoolEditions { get; private set; }

        /// <summary>
        /// Gets the status of the capability. Possible values include:
        /// 'Visible', 'Available', 'Default', 'Disabled'
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public CapabilityStatus? Status { get; private set; }

        /// <summary>
        /// Gets or sets the reason for the capability not being available.
        /// </summary>
        [JsonProperty(PropertyName = "reason")]
        public string Reason { get; set; }

    }
}