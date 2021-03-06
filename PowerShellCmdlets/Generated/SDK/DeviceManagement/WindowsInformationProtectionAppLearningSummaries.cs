// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Retrieves &quot;microsoft.graph.windowsInformationProtectionAppLearningSummary&quot; objects.</para>
    ///     <para type="description">GET ~/deviceManagement/windowsInformationProtectionAppLearningSummaries</para>
    ///     <para type="description">Retrieves &quot;microsoft.graph.windowsInformationProtectionAppLearningSummary&quot; objects in the &quot;windowsInformationProtectionAppLearningSummaries&quot; collection.</para>
    ///     <para type="description">The windows information protection app learning summaries.</para>
    /// </summary>
    /// <para type="link" uri="https://github.com/Microsoft/Intune-PowerShell-SDK">GitHub Repository</para>
    [Cmdlet("Get", "IntuneWindowsInformationProtectionAppLearningSummary", DefaultParameterSetName = @"Search")]
    [ODataType("microsoft.graph.windowsInformationProtectionAppLearningSummary")]
    [ResourceTypePropertyName("windowsInformationProtectionAppLearningSummaryODataType")]
    [ResourceReference]
    public class Get_IntuneWindowsInformationProtectionAppLearningSummary : GetOrSearchCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.windowsInformationProtectionAppLearningSummary&quot; object in the &quot;windowsInformationProtectionAppLearningSummaries&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ResourceIdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(ParameterSetName = @"Get", Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.windowsInformationProtectionAppLearningSummary&quot; object in the &quot;windowsInformationProtectionAppLearningSummaries&quot; collection.")]
        public System.String windowsInformationProtectionAppLearningSummaryId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;applicationName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionAppLearningSummary&quot; type.</para>
        ///     <para type="description">Application Name</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Sortable]
        public System.String applicationName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;applicationType&quot; property, of type &quot;microsoft.graph.applicationType&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionAppLearningSummary&quot; type.</para>
        ///     <para type="description">Application Type</para>
        /// </summary>
        [ODataType("microsoft.graph.applicationType")]
        [Selectable]
        [Sortable]
        public System.String applicationType { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionAppLearningSummary&quot; type.</para>
        ///     <para type="description">Device Count</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Sortable]
        public System.Int32 deviceCount { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceManagement/windowsInformationProtectionAppLearningSummaries/{windowsInformationProtectionAppLearningSummaryId ?? string.Empty}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Creates a &quot;microsoft.graph.windowsInformationProtectionAppLearningSummary&quot; object.</para>
    ///     <para type="description">POST ~/deviceManagement/windowsInformationProtectionAppLearningSummaries</para>
    ///     <para type="description">Adds a &quot;microsoft.graph.windowsInformationProtectionAppLearningSummary&quot; object to the &quot;windowsInformationProtectionAppLearningSummaries&quot; collection.</para>
    ///     <para type="description">The windows information protection app learning summaries.</para>
    /// </summary>
    /// <para type="link" uri="https://github.com/Microsoft/Intune-PowerShell-SDK">GitHub Repository</para>
    [Cmdlet("New", "IntuneWindowsInformationProtectionAppLearningSummary", ConfirmImpact = ConfirmImpact.Low, DefaultParameterSetName = @"microsoft.graph.windowsInformationProtectionAppLearningSummary")]
    [ODataType("microsoft.graph.windowsInformationProtectionAppLearningSummary")]
    [ResourceTypePropertyName("windowsInformationProtectionAppLearningSummaryODataType")]
    [ResourceReference]
    public class New_IntuneWindowsInformationProtectionAppLearningSummary : PostCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.windowsInformationProtectionAppLearningSummary&quot; object in the &quot;windowsInformationProtectionAppLearningSummaries&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ResourceIdParameter]
        public System.String windowsInformationProtectionAppLearningSummaryId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;applicationName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionAppLearningSummary&quot; type.</para>
        ///     <para type="description">Application Name</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.windowsInformationProtectionAppLearningSummary", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;applicationName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;applicationName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String applicationName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;applicationType&quot; property, of type &quot;microsoft.graph.applicationType&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionAppLearningSummary&quot; type.</para>
        ///     <para type="description">Application Type</para>
        ///     <para type="description">
        ///          Valid values: &apos;universal&apos;, &apos;desktop&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.applicationType")]
        [Selectable]
        [ValidateSet(@"universal", @"desktop")]
        [Parameter(ParameterSetName = @"microsoft.graph.windowsInformationProtectionAppLearningSummary", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;applicationType&quot; property, of type &quot;microsoft.graph.applicationType&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;applicationType&quot; property, of type &quot;microsoft.graph.applicationType&quot;.")]
        public System.String applicationType { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionAppLearningSummary&quot; type.</para>
        ///     <para type="description">Device Count</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.windowsInformationProtectionAppLearningSummary", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;deviceCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", ValueFromPipelineByPropertyName = true, HelpMessage = @"The &quot;deviceCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 deviceCount { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceManagement/windowsInformationProtectionAppLearningSummaries/{windowsInformationProtectionAppLearningSummaryId}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Updates a &quot;microsoft.graph.windowsInformationProtectionAppLearningSummary&quot;.</para>
    ///     <para type="description">PATCH ~/deviceManagement/windowsInformationProtectionAppLearningSummaries</para>
    ///     <para type="description">Updates a &quot;microsoft.graph.windowsInformationProtectionAppLearningSummary&quot; object in the &quot;windowsInformationProtectionAppLearningSummaries&quot; collection.</para>
    ///     <para type="description">The windows information protection app learning summaries.</para>
    /// </summary>
    /// <para type="link" uri="https://github.com/Microsoft/Intune-PowerShell-SDK">GitHub Repository</para>
    [Cmdlet("Update", "IntuneWindowsInformationProtectionAppLearningSummary", ConfirmImpact = ConfirmImpact.Medium, DefaultParameterSetName = @"microsoft.graph.windowsInformationProtectionAppLearningSummary")]
    [ODataType("microsoft.graph.windowsInformationProtectionAppLearningSummary")]
    [ResourceTypePropertyName("windowsInformationProtectionAppLearningSummaryODataType")]
    public class Update_IntuneWindowsInformationProtectionAppLearningSummary : PatchCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.windowsInformationProtectionAppLearningSummary&quot; object in the &quot;windowsInformationProtectionAppLearningSummaries&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ResourceIdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.windowsInformationProtectionAppLearningSummary&quot; object in the &quot;windowsInformationProtectionAppLearningSummaries&quot; collection.")]
        public System.String windowsInformationProtectionAppLearningSummaryId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;applicationName&quot; property, of type &quot;Edm.String&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionAppLearningSummary&quot; type.</para>
        ///     <para type="description">Application Name</para>
        /// </summary>
        [ODataType("Edm.String")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.windowsInformationProtectionAppLearningSummary", HelpMessage = @"The &quot;applicationName&quot; property, of type &quot;Edm.String&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;applicationName&quot; property, of type &quot;Edm.String&quot;.")]
        public System.String applicationName { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;applicationType&quot; property, of type &quot;microsoft.graph.applicationType&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionAppLearningSummary&quot; type.</para>
        ///     <para type="description">Application Type</para>
        ///     <para type="description">
        ///          Valid values: &apos;universal&apos;, &apos;desktop&apos;
        ///     </para>
        /// </summary>
        [ODataType("microsoft.graph.applicationType")]
        [Selectable]
        [ValidateSet(@"universal", @"desktop")]
        [Parameter(ParameterSetName = @"microsoft.graph.windowsInformationProtectionAppLearningSummary", HelpMessage = @"The &quot;applicationType&quot; property, of type &quot;microsoft.graph.applicationType&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;applicationType&quot; property, of type &quot;microsoft.graph.applicationType&quot;.")]
        public System.String applicationType { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;deviceCount&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.windowsInformationProtectionAppLearningSummary&quot; type.</para>
        ///     <para type="description">Device Count</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.windowsInformationProtectionAppLearningSummary", HelpMessage = @"The &quot;deviceCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;deviceCount&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 deviceCount { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceManagement/windowsInformationProtectionAppLearningSummaries/{windowsInformationProtectionAppLearningSummaryId}";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Removes a &quot;microsoft.graph.windowsInformationProtectionAppLearningSummary&quot; object.</para>
    ///     <para type="description">DELETE ~/deviceManagement/windowsInformationProtectionAppLearningSummaries/windowsInformationProtectionAppLearningSummaryId</para>
    ///     <para type="description">Removes a &quot;microsoft.graph.windowsInformationProtectionAppLearningSummary&quot; object from the &quot;windowsInformationProtectionAppLearningSummaries&quot; collection.</para>
    ///     <para type="description">The windows information protection app learning summaries.</para>
    /// </summary>
    /// <para type="link" uri="https://github.com/Microsoft/Intune-PowerShell-SDK">GitHub Repository</para>
    [Cmdlet("Remove", "IntuneWindowsInformationProtectionAppLearningSummary", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.windowsInformationProtectionAppLearningSummary")]
    [ResourceTypePropertyName("windowsInformationProtectionAppLearningSummaryODataType")]
    public class Remove_IntuneWindowsInformationProtectionAppLearningSummary : DeleteCmdlet
    {
        /// <summary>
        ///     <para type="description">The ID for a &quot;microsoft.graph.windowsInformationProtectionAppLearningSummary&quot; object in the &quot;windowsInformationProtectionAppLearningSummaries&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ResourceIdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"The ID for a &quot;microsoft.graph.windowsInformationProtectionAppLearningSummary&quot; object in the &quot;windowsInformationProtectionAppLearningSummaries&quot; collection.")]
        public System.String windowsInformationProtectionAppLearningSummaryId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"deviceManagement/windowsInformationProtectionAppLearningSummaries/{windowsInformationProtectionAppLearningSummaryId}";
        }
    }
}