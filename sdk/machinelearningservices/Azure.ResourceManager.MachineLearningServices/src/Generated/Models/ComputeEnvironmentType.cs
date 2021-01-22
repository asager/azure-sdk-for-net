// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    /// <summary> The compute environment type for the service. </summary>
    public readonly partial struct ComputeEnvironmentType : IEquatable<ComputeEnvironmentType>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="ComputeEnvironmentType"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ComputeEnvironmentType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ACIValue = "ACI";
        private const string AKSValue = "AKS";

        /// <summary> ACI. </summary>
        public static ComputeEnvironmentType ACI { get; } = new ComputeEnvironmentType(ACIValue);
        /// <summary> AKS. </summary>
        public static ComputeEnvironmentType AKS { get; } = new ComputeEnvironmentType(AKSValue);
        /// <summary> Determines if two <see cref="ComputeEnvironmentType"/> values are the same. </summary>
        public static bool operator ==(ComputeEnvironmentType left, ComputeEnvironmentType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ComputeEnvironmentType"/> values are not the same. </summary>
        public static bool operator !=(ComputeEnvironmentType left, ComputeEnvironmentType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ComputeEnvironmentType"/>. </summary>
        public static implicit operator ComputeEnvironmentType(string value) => new ComputeEnvironmentType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ComputeEnvironmentType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ComputeEnvironmentType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}