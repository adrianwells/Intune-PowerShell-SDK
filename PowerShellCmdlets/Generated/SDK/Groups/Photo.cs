// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

namespace Microsoft.Intune.PowerShellGraphSDK.PowerShellCmdlets
{
    using System.Management.Automation;

    /// <summary>
    ///     <para type="synopsis">Retrieves the &quot;photo&quot; object.</para>
    ///     <para type="description">GET ~/groups/{groupId}/photo</para>
    ///     <para type="description">Retrieves the &quot;photo&quot; object (which is of type &quot;microsoft.graph.profilePhoto&quot;).</para>
    /// </summary>
    /// <para type="link" uri="https://github.com/Microsoft/Intune-PowerShell-SDK">GitHub Repository</para>
    [Cmdlet("Get", "GroupPhoto", DefaultParameterSetName = @"Get")]
    [ODataType("microsoft.graph.profilePhoto")]
    [ResourceTypePropertyName("photoODataType")]
    [ResourceReference]
    public class Get_GroupPhoto : GetCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.group&quot; object in the &quot;groups&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.group&quot; object in the &quot;groups&quot; collection.")]
        public System.String groupId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;height&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.profilePhoto&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Sortable]
        public System.Int32 height { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;width&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.profilePhoto&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Sortable]
        public System.Int32 width { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"groups/{groupId}/photo";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Updates a &quot;microsoft.graph.profilePhoto&quot;.</para>
    ///     <para type="description">PATCH ~/groups/{groupId}/photo</para>
    ///     <para type="description">Updates the &quot;photo&quot; object (which is of type &quot;microsoft.graph.profilePhoto&quot;).</para>
    /// </summary>
    /// <para type="link" uri="https://github.com/Microsoft/Intune-PowerShell-SDK">GitHub Repository</para>
    [Cmdlet("Update", "GroupPhoto", ConfirmImpact = ConfirmImpact.Medium, DefaultParameterSetName = @"microsoft.graph.profilePhoto")]
    [ODataType("microsoft.graph.profilePhoto")]
    [ResourceTypePropertyName("photoODataType")]
    public class Update_GroupPhoto : PatchCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.group&quot; object in the &quot;groups&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.group&quot; object in the &quot;groups&quot; collection.")]
        public System.String groupId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;height&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.profilePhoto&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.profilePhoto", HelpMessage = @"The &quot;height&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;height&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 height { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;width&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.profilePhoto&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Parameter(ParameterSetName = @"microsoft.graph.profilePhoto", HelpMessage = @"The &quot;width&quot; property, of type &quot;Edm.Int32&quot;.")]
        [Parameter(ParameterSetName = @"ManualTypeSelection", HelpMessage = @"The &quot;width&quot; property, of type &quot;Edm.Int32&quot;.")]
        public System.Int32 width { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"groups/{groupId}/photo";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Retrieves a &quot;photo&quot; object&apos;s data stream.</para>
    ///     <para type="description">GET ~/groups/{groupId}/photo/$value</para>
    ///     <para type="description">Retrieves the data stream from the &quot;photo&quot; object.</para>
    /// </summary>
    /// <para type="link" uri="https://github.com/Microsoft/Intune-PowerShell-SDK">GitHub Repository</para>
    [Cmdlet("Get", "GroupPhotoData")]
    [ODataType("microsoft.graph.profilePhoto")]
    [ResourceTypePropertyName("photoODataType")]
    public class Get_GroupPhotoData : GetStreamCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.group&quot; object in the &quot;groups&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.group&quot; object in the &quot;groups&quot; collection.")]
        public System.String groupId { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;height&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.profilePhoto&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Sortable]
        public System.Int32 height { get; set; }

        /// <summary>
        ///     <para type="description">The &quot;width&quot; property, of type &quot;Edm.Int32&quot;.</para>
        ///     <para type="description">This property is on the &quot;microsoft.graph.profilePhoto&quot; type.</para>
        /// </summary>
        [ODataType("Edm.Int32")]
        [Selectable]
        [Sortable]
        public System.Int32 width { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"groups/{groupId}/photo/$value";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Sets the data for the &quot;photo&quot; property.</para>
    ///     <para type="description">PUT ~/groups/{groupId}/photo/$value</para>
    ///     <para type="description">Sets the data for the &quot;photo&quot; property.</para>
    /// </summary>
    /// <para type="link" uri="https://github.com/Microsoft/Intune-PowerShell-SDK">GitHub Repository</para>
    [Cmdlet("New", "GroupPhotoData", ConfirmImpact = ConfirmImpact.Low)]
    [ODataType("microsoft.graph.profilePhoto")]
    [ResourceTypePropertyName("photoODataType")]
    public class New_GroupPhotoData : UpdateStreamCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.group&quot; object in the &quot;groups&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.group&quot; object in the &quot;groups&quot; collection.")]
        public System.String groupId { get; set; }

        internal override System.String GetHttpMethod()
        {
            return "POST";
        }

        internal override System.String GetResourcePath()
        {
            return $"groups/{groupId}/photo/$value";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Sets the data for the &quot;photo&quot; property.</para>
    ///     <para type="description">PUT ~/groups/{groupId}/photo/$value</para>
    ///     <para type="description">Sets the data for the &quot;photo&quot; property.</para>
    /// </summary>
    /// <para type="link" uri="https://github.com/Microsoft/Intune-PowerShell-SDK">GitHub Repository</para>
    [Cmdlet("Set", "GroupPhotoData", ConfirmImpact = ConfirmImpact.Low)]
    [ODataType("microsoft.graph.profilePhoto")]
    [ResourceTypePropertyName("photoODataType")]
    public class Set_GroupPhotoData : UpdateStreamCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.group&quot; object in the &quot;groups&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.group&quot; object in the &quot;groups&quot; collection.")]
        public System.String groupId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"groups/{groupId}/photo/$value";
        }
    }

    /// <summary>
    ///     <para type="synopsis">Removes the data stream from a &quot;photo&quot; object.</para>
    ///     <para type="description">DELETE ~/groups/{groupId}/photo/$value</para>
    ///     <para type="description">Removes a reference from a &quot;photo&quot; resource (which is of type &quot;microsoft.graph.profilePhoto&quot;).</para>
    /// </summary>
    /// <para type="link" uri="https://github.com/Microsoft/Intune-PowerShell-SDK">GitHub Repository</para>
    [Cmdlet("Remove", "GroupPhotoData", ConfirmImpact = ConfirmImpact.High)]
    [ODataType("microsoft.graph.profilePhoto")]
    [ResourceTypePropertyName("photoODataType")]
    public class Remove_GroupPhotoData : DeleteCmdlet
    {
        /// <summary>
        ///     <para type="description">A required ID for referencing a &quot;microsoft.graph.group&quot; object in the &quot;groups&quot; collection.</para>
        /// </summary>
        [Selectable]
        [Expandable]
        [IdParameter]
        [ValidateNotNullOrEmpty]
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = @"A required ID for referencing a &quot;microsoft.graph.group&quot; object in the &quot;groups&quot; collection.")]
        public System.String groupId { get; set; }

        internal override System.String GetResourcePath()
        {
            return $"groups/{groupId}/photo/$value";
        }
    }
}