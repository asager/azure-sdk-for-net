// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    public partial class PaginatedServiceList
    {
        internal static PaginatedServiceList DeserializePaginatedServiceList(JsonElement element)
        {
            Optional<IReadOnlyList<ServiceResource>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<ServiceResource> array = new List<ServiceResource>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ServiceResource.DeserializeServiceResource(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new PaginatedServiceList(Optional.ToList(value), nextLink.Value);
        }
    }
}