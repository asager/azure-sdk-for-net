// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    /// <summary> Compute binding definition. </summary>
    public partial class ComputeBinding
    {
        /// <summary> Initializes a new instance of ComputeBinding. </summary>
        public ComputeBinding()
        {
        }

        /// <summary> Initializes a new instance of ComputeBinding. </summary>
        /// <param name="computeId"> Resource ID of the compute resource. </param>
        /// <param name="nodeCount"> Number of nodes. </param>
        /// <param name="isLocal"> Set to true for jobs running on local compute. </param>
        internal ComputeBinding(string computeId, int? nodeCount, bool? isLocal)
        {
            ComputeId = computeId;
            NodeCount = nodeCount;
            IsLocal = isLocal;
        }

        /// <summary> Resource ID of the compute resource. </summary>
        public string ComputeId { get; set; }
        /// <summary> Number of nodes. </summary>
        public int? NodeCount { get; set; }
        /// <summary> Set to true for jobs running on local compute. </summary>
        public bool? IsLocal { get; set; }
    }
}