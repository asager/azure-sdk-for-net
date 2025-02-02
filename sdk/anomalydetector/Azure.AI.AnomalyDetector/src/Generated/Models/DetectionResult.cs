// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.AI.AnomalyDetector.Models
{
    /// <summary> Anomaly Response of one detection corresponds to a resultId. </summary>
    public partial class DetectionResult
    {
        /// <summary> Initializes a new instance of DetectionResult. </summary>
        /// <param name="resultId"></param>
        /// <param name="summary"> Multivariate anomaly detection status. </param>
        /// <param name="results"> anomaly status of each timestamp. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="summary"/> or <paramref name="results"/> is null. </exception>
        internal DetectionResult(Guid resultId, DetectionResultSummary summary, IEnumerable<AnomalyState> results)
        {
            if (summary == null)
            {
                throw new ArgumentNullException(nameof(summary));
            }
            if (results == null)
            {
                throw new ArgumentNullException(nameof(results));
            }

            ResultId = resultId;
            Summary = summary;
            Results = results.ToList();
        }

        /// <summary> Initializes a new instance of DetectionResult. </summary>
        /// <param name="resultId"></param>
        /// <param name="summary"> Multivariate anomaly detection status. </param>
        /// <param name="results"> anomaly status of each timestamp. </param>
        internal DetectionResult(Guid resultId, DetectionResultSummary summary, IReadOnlyList<AnomalyState> results)
        {
            ResultId = resultId;
            Summary = summary;
            Results = results;
        }

        public Guid ResultId { get; }
        /// <summary> Multivariate anomaly detection status. </summary>
        public DetectionResultSummary Summary { get; }
        /// <summary> anomaly status of each timestamp. </summary>
        public IReadOnlyList<AnomalyState> Results { get; }
    }
}
