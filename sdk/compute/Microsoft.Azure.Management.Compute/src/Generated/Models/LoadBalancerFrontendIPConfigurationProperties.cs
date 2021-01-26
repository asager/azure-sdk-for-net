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
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Describes a cloud service IP Configuration
    /// </summary>
    public partial class LoadBalancerFrontendIPConfigurationProperties
    {
        /// <summary>
        /// Initializes a new instance of the
        /// LoadBalancerFrontendIPConfigurationProperties class.
        /// </summary>
        public LoadBalancerFrontendIPConfigurationProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// LoadBalancerFrontendIPConfigurationProperties class.
        /// </summary>
        /// <param name="privateIPAddress">The private IP address referenced by
        /// the cloud service.</param>
        public LoadBalancerFrontendIPConfigurationProperties(SubResource publicIPAddress = default(SubResource), SubResource subnet = default(SubResource), string privateIPAddress = default(string))
        {
            PublicIPAddress = publicIPAddress;
            Subnet = subnet;
            PrivateIPAddress = privateIPAddress;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "publicIPAddress")]
        public SubResource PublicIPAddress { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "subnet")]
        public SubResource Subnet { get; set; }

        /// <summary>
        /// Gets or sets the private IP address referenced by the cloud
        /// service.
        /// </summary>
        [JsonProperty(PropertyName = "privateIPAddress")]
        public string PrivateIPAddress { get; set; }

    }
}