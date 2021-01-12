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
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The configuration for virtual machine extensions.
    /// </summary>
    public partial class VMExtension
    {
        /// <summary>
        /// Initializes a new instance of the VMExtension class.
        /// </summary>
        public VMExtension()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the VMExtension class.
        /// </summary>
        /// <param name="name">The name of the virtual machine
        /// extension.</param>
        /// <param name="publisher">The name of the extension handler
        /// publisher.</param>
        /// <param name="type">The type of the extensions.</param>
        /// <param name="typeHandlerVersion">The version of script
        /// handler.</param>
        /// <param name="autoUpgradeMinorVersion">Indicates whether the
        /// extension should use a newer minor version if one is available at
        /// deployment time. Once deployed, however, the extension will not
        /// upgrade minor versions unless redeployed, even with this property
        /// set to true.</param>
        /// <param name="settings">JSON formatted public settings for the
        /// extension.</param>
        /// <param name="protectedSettings">The extension can contain either
        /// protectedSettings or protectedSettingsFromKeyVault or no protected
        /// settings at all. </param>
        /// <param name="provisionAfterExtensions">The collection of extension
        /// names.</param>
        public VMExtension(string name, string publisher, string type, string typeHandlerVersion = default(string), bool? autoUpgradeMinorVersion = default(bool?), object settings = default(object), object protectedSettings = default(object), IList<string> provisionAfterExtensions = default(IList<string>))
        {
            Name = name;
            Publisher = publisher;
            Type = type;
            TypeHandlerVersion = typeHandlerVersion;
            AutoUpgradeMinorVersion = autoUpgradeMinorVersion;
            Settings = settings;
            ProtectedSettings = protectedSettings;
            ProvisionAfterExtensions = provisionAfterExtensions;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name of the virtual machine extension.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the name of the extension handler publisher.
        /// </summary>
        [JsonProperty(PropertyName = "publisher")]
        public string Publisher { get; set; }

        /// <summary>
        /// Gets or sets the type of the extensions.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the version of script handler.
        /// </summary>
        [JsonProperty(PropertyName = "typeHandlerVersion")]
        public string TypeHandlerVersion { get; set; }

        /// <summary>
        /// Gets or sets indicates whether the extension should use a newer
        /// minor version if one is available at deployment time. Once
        /// deployed, however, the extension will not upgrade minor versions
        /// unless redeployed, even with this property set to true.
        /// </summary>
        [JsonProperty(PropertyName = "autoUpgradeMinorVersion")]
        public bool? AutoUpgradeMinorVersion { get; set; }

        /// <summary>
        /// Gets or sets JSON formatted public settings for the extension.
        /// </summary>
        [JsonProperty(PropertyName = "settings")]
        public object Settings { get; set; }

        /// <summary>
        /// Gets or sets the extension can contain either protectedSettings or
        /// protectedSettingsFromKeyVault or no protected settings at all.
        /// </summary>
        [JsonProperty(PropertyName = "protectedSettings")]
        public object ProtectedSettings { get; set; }

        /// <summary>
        /// Gets or sets the collection of extension names.
        /// </summary>
        /// <remarks>
        /// Collection of extension names after which this extension needs to
        /// be provisioned.
        /// </remarks>
        [JsonProperty(PropertyName = "provisionAfterExtensions")]
        public IList<string> ProvisionAfterExtensions { get; set; }

    }
}