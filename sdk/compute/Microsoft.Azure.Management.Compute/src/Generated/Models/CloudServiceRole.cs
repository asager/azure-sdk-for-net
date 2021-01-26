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
    /// Describes a role of the cloud service.
    /// </summary>
    public partial class CloudServiceRole
    {
        /// <summary>
        /// Initializes a new instance of the CloudServiceRole class.
        /// </summary>
        public CloudServiceRole()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CloudServiceRole class.
        /// </summary>
        /// <param name="id">Resource id</param>
        /// <param name="name">Resource name</param>
        /// <param name="type">Resource type</param>
        /// <param name="location">Resource location</param>
        public CloudServiceRole(string id = default(string), string name = default(string), string type = default(string), string location = default(string), CloudServiceRoleSku sku = default(CloudServiceRoleSku), CloudServiceRoleProperties properties = default(CloudServiceRoleProperties))
        {
            Id = id;
            Name = name;
            Type = type;
            Location = location;
            Sku = sku;
            Properties = properties;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets resource id
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; private set; }

        /// <summary>
        /// Gets resource name
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        /// <summary>
        /// Gets resource type
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; private set; }

        /// <summary>
        /// Gets resource location
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public string Location { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sku")]
        public CloudServiceRoleSku Sku { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public CloudServiceRoleProperties Properties { get; set; }

    }
}