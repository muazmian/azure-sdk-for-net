// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Batch.Protocol.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// An Azure Batch job.
    /// </summary>
    public partial class CloudJob
    {
        /// <summary>
        /// Initializes a new instance of the CloudJob class.
        /// </summary>
        public CloudJob() { }

        /// <summary>
        /// Initializes a new instance of the CloudJob class.
        /// </summary>
        public CloudJob(string id = default(string), string displayName = default(string), bool? usesTaskDependencies = default(bool?), string url = default(string), string eTag = default(string), DateTime? lastModified = default(DateTime?), DateTime? creationTime = default(DateTime?), JobState? state = default(JobState?), DateTime? stateTransitionTime = default(DateTime?), JobState? previousState = default(JobState?), DateTime? previousStateTransitionTime = default(DateTime?), int? priority = default(int?), JobConstraints constraints = default(JobConstraints), JobManagerTask jobManagerTask = default(JobManagerTask), JobPreparationTask jobPreparationTask = default(JobPreparationTask), JobReleaseTask jobReleaseTask = default(JobReleaseTask), IList<EnvironmentSetting> commonEnvironmentSettings = default(IList<EnvironmentSetting>), PoolInformation poolInfo = default(PoolInformation), IList<MetadataItem> metadata = default(IList<MetadataItem>), JobExecutionInformation executionInfo = default(JobExecutionInformation), JobStatistics stats = default(JobStatistics))
        {
            Id = id;
            DisplayName = displayName;
            UsesTaskDependencies = usesTaskDependencies;
            Url = url;
            ETag = eTag;
            LastModified = lastModified;
            CreationTime = creationTime;
            State = state;
            StateTransitionTime = stateTransitionTime;
            PreviousState = previousState;
            PreviousStateTransitionTime = previousStateTransitionTime;
            Priority = priority;
            Constraints = constraints;
            JobManagerTask = jobManagerTask;
            JobPreparationTask = jobPreparationTask;
            JobReleaseTask = jobReleaseTask;
            CommonEnvironmentSettings = commonEnvironmentSettings;
            PoolInfo = poolInfo;
            Metadata = metadata;
            ExecutionInfo = executionInfo;
            Stats = stats;
        }

        /// <summary>
        /// Gets or sets a string that uniquely identifies the job within the
        /// account. The id can contain any combination of alphanumeric
        /// characters including hyphens and underscores, and cannot contain
        /// more than 64 characters. It is common to use a GUID for the id.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the display name for the job.
        /// </summary>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets the flag that determines if this job will use tasks
        /// with dependencies.
        /// </summary>
        [JsonProperty(PropertyName = "usesTaskDependencies")]
        public bool? UsesTaskDependencies { get; set; }

        /// <summary>
        /// Gets or sets the URL of the job.
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }

        /// <summary>
        /// Gets or sets the ETag of the job.
        /// </summary>
        [JsonProperty(PropertyName = "eTag")]
        public string ETag { get; set; }

        /// <summary>
        /// Gets or sets the last modified time of the job.
        /// </summary>
        [JsonProperty(PropertyName = "lastModified")]
        public DateTime? LastModified { get; set; }

        /// <summary>
        /// Gets or sets the creation time of the job.
        /// </summary>
        [JsonProperty(PropertyName = "creationTime")]
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Gets or sets the current state of the job. Possible values
        /// include: 'active', 'disabling', 'disabled', 'enabling',
        /// 'terminating', 'completed', 'deleting'
        /// </summary>
        [JsonProperty(PropertyName = "state")]
        public JobState? State { get; set; }

        /// <summary>
        /// Gets or sets the time at which the job entered its current state.
        /// </summary>
        [JsonProperty(PropertyName = "stateTransitionTime")]
        public DateTime? StateTransitionTime { get; set; }

        /// <summary>
        /// Gets or sets the previous state of the job. This property is not
        /// set if the job is in its initial Active state. Possible values
        /// include: 'active', 'disabling', 'disabled', 'enabling',
        /// 'terminating', 'completed', 'deleting'
        /// </summary>
        [JsonProperty(PropertyName = "previousState")]
        public JobState? PreviousState { get; set; }

        /// <summary>
        /// Gets or sets the time at which the job entered its previous state.
        /// This property is not set if the job is in its initial Active
        /// state.
        /// </summary>
        [JsonProperty(PropertyName = "previousStateTransitionTime")]
        public DateTime? PreviousStateTransitionTime { get; set; }

        /// <summary>
        /// Gets or sets the priority of the job. Priority values can range
        /// from -1000 to 1000, with -1000 being the lowest priority and 1000
        /// being the highest priority. The default value is 0.
        /// </summary>
        [JsonProperty(PropertyName = "priority")]
        public int? Priority { get; set; }

        /// <summary>
        /// Gets or sets the execution constraints for the job.
        /// </summary>
        [JsonProperty(PropertyName = "constraints")]
        public JobConstraints Constraints { get; set; }

        /// <summary>
        /// Gets or sets details of a Job Manager task to be launched when the
        /// job is started.
        /// </summary>
        [JsonProperty(PropertyName = "jobManagerTask")]
        public JobManagerTask JobManagerTask { get; set; }

        /// <summary>
        /// Gets or sets the Job Preparation task.
        /// </summary>
        [JsonProperty(PropertyName = "jobPreparationTask")]
        public JobPreparationTask JobPreparationTask { get; set; }

        /// <summary>
        /// Gets or sets the Job Release task.
        /// </summary>
        [JsonProperty(PropertyName = "jobReleaseTask")]
        public JobReleaseTask JobReleaseTask { get; set; }

        /// <summary>
        /// Gets or sets the list of common environment variable settings.
        /// These environment variables are set for all tasks in the job
        /// (including the Job Manager, Job Preparation and Job Release
        /// tasks).
        /// </summary>
        [JsonProperty(PropertyName = "commonEnvironmentSettings")]
        public IList<EnvironmentSetting> CommonEnvironmentSettings { get; set; }

        /// <summary>
        /// Gets or sets the pool on which the Batch service runs the jobâ€™s
        /// tasks.
        /// </summary>
        [JsonProperty(PropertyName = "poolInfo")]
        public PoolInformation PoolInfo { get; set; }

        /// <summary>
        /// Gets or sets a list of name-value pairs associated with the job as
        /// metadata.
        /// </summary>
        [JsonProperty(PropertyName = "metadata")]
        public IList<MetadataItem> Metadata { get; set; }

        /// <summary>
        /// Gets or sets the execution information for the job.
        /// </summary>
        [JsonProperty(PropertyName = "executionInfo")]
        public JobExecutionInformation ExecutionInfo { get; set; }

        /// <summary>
        /// Gets or sets resource usage statistics for the entire lifetime of
        /// the job.
        /// </summary>
        [JsonProperty(PropertyName = "stats")]
        public JobStatistics Stats { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (this.PoolInfo != null)
            {
                this.PoolInfo.Validate();
            }
            if (this.ExecutionInfo != null)
            {
                this.ExecutionInfo.Validate();
            }
            if (this.Stats != null)
            {
                this.Stats.Validate();
            }
        }
    }
}