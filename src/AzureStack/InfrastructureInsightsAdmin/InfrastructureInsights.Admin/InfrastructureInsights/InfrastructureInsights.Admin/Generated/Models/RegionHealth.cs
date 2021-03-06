// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.AzureStack.Management.InfrastructureInsights.Admin.Models
{
    using Microsoft.AzureStack;
    using Microsoft.AzureStack.Management;
    using Microsoft.AzureStack.Management.InfrastructureInsights;
    using Microsoft.AzureStack.Management.InfrastructureInsights.Admin;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Contains information related to a regions health.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class RegionHealth : Resource
    {
        /// <summary>
        /// Initializes a new instance of the RegionHealth class.
        /// </summary>
        public RegionHealth()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RegionHealth class.
        /// </summary>
        /// <param name="id">URI of the resource.</param>
        /// <param name="name">Name of the resource.</param>
        /// <param name="type">Type of resource.</param>
        /// <param name="location">Location where resource is location.</param>
        /// <param name="tags">List of key value pairs.</param>
        /// <param name="alertSummary">Summary of alerts.</param>
        /// <param name="usageMetrics">List of usage metrics for this
        /// region.</param>
        public RegionHealth(string id = default(string), string name = default(string), string type = default(string), string location = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), AlertSummary alertSummary = default(AlertSummary), IList<UsageMetrics> usageMetrics = default(IList<UsageMetrics>))
            : base(id, name, type, location, tags)
        {
            AlertSummary = alertSummary;
            UsageMetrics = usageMetrics;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets summary of alerts.
        /// </summary>
        [JsonProperty(PropertyName = "properties.alertSummary")]
        public AlertSummary AlertSummary { get; set; }

        /// <summary>
        /// Gets or sets list of usage metrics for this region.
        /// </summary>
        [JsonProperty(PropertyName = "properties.usageMetrics")]
        public IList<UsageMetrics> UsageMetrics { get; set; }

    }
}
