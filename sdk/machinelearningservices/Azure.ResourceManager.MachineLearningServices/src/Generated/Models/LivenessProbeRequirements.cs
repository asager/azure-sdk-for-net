// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    /// <summary> The liveness probe requirements. </summary>
    public partial class LivenessProbeRequirements
    {
        /// <summary> Initializes a new instance of LivenessProbeRequirements. </summary>
        public LivenessProbeRequirements()
        {
        }

        /// <summary> Initializes a new instance of LivenessProbeRequirements. </summary>
        /// <param name="failureThreshold"> The number of failures to allow before returning an unhealthy status. </param>
        /// <param name="successThreshold"> The number of successful probes before returning a healthy status. </param>
        /// <param name="timeoutSeconds"> The probe timeout in seconds. </param>
        /// <param name="periodSeconds"> The length of time between probes in seconds. </param>
        /// <param name="initialDelaySeconds"> The delay before the first probe in seconds. </param>
        internal LivenessProbeRequirements(int? failureThreshold, int? successThreshold, int? timeoutSeconds, int? periodSeconds, int? initialDelaySeconds)
        {
            FailureThreshold = failureThreshold;
            SuccessThreshold = successThreshold;
            TimeoutSeconds = timeoutSeconds;
            PeriodSeconds = periodSeconds;
            InitialDelaySeconds = initialDelaySeconds;
        }

        /// <summary> The number of failures to allow before returning an unhealthy status. </summary>
        public int? FailureThreshold { get; set; }
        /// <summary> The number of successful probes before returning a healthy status. </summary>
        public int? SuccessThreshold { get; set; }
        /// <summary> The probe timeout in seconds. </summary>
        public int? TimeoutSeconds { get; set; }
        /// <summary> The length of time between probes in seconds. </summary>
        public int? PeriodSeconds { get; set; }
        /// <summary> The delay before the first probe in seconds. </summary>
        public int? InitialDelaySeconds { get; set; }
    }
}