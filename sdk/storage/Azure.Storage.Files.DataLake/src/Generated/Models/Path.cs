// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Storage.Files.DataLake.Models
{
    /// <summary> The Path. </summary>
    internal partial class Path
    {
        /// <summary> Initializes a new instance of Path. </summary>
        internal Path()
        {
        }

        /// <summary> Initializes a new instance of Path. </summary>
        /// <param name="name"></param>
        /// <param name="lastModified"></param>
        /// <param name="eTag"></param>
        /// <param name="owner"></param>
        /// <param name="group"></param>
        /// <param name="permissions"></param>
        /// <param name="contentLength"></param>
        /// <param name="isDirectory"></param>
        internal Path(string name, DateTimeOffset? lastModified, string eTag, string owner, string group, string permissions, string contentLength, string isDirectory)
        {
            Name = name;
            LastModified = lastModified;
            ETag = eTag;
            Owner = owner;
            Group = group;
            Permissions = permissions;
            ContentLength = contentLength;
            IsDirectory = isDirectory;
        }

        public string Name { get; }
        public DateTimeOffset? LastModified { get; }
        public string ETag { get; }
        public string Owner { get; }
        public string Group { get; }
        public string Permissions { get; }
        public string ContentLength { get; }
        public string IsDirectory { get; }
    }
}
