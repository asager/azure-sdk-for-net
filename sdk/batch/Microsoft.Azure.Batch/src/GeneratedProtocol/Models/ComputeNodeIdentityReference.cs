// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Batch.Protocol.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The reference to a user assigned identity associated with the Batch
    /// pool which a compute node will use.
    /// </summary>
    public partial class ComputeNodeIdentityReference
    {
        /// <summary>
        /// Initializes a new instance of the ComputeNodeIdentityReference
        /// class.
        /// </summary>
        public ComputeNodeIdentityReference()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ComputeNodeIdentityReference
        /// class.
        /// </summary>
        /// <param name="resourceId">The ARM resource id of the user assigned
        /// identity.</param>
        public ComputeNodeIdentityReference(string resourceId = default(string))
        {
            ResourceId = resourceId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the ARM resource id of the user assigned identity.
        /// </summary>
        [JsonProperty(PropertyName = "resourceId")]
        public string ResourceId { get; set; }

    }
}
