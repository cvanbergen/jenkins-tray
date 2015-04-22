﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hudson.TrayTracker {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class HudsonTrayTrackerResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal HudsonTrayTrackerResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Hudson.TrayTracker.HudsonTrayTrackerResources", typeof(HudsonTrayTrackerResources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Jenkins Tray updates.
        /// </summary>
        internal static string ApplicationUpdates_Caption {
            get {
                return ResourceManager.GetString("ApplicationUpdates_Caption", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A new version is available: v{0}.
        ///Do you want to download it now (the application will be closed)?.
        /// </summary>
        internal static string ApplicationUpdates_NewVersion_Text {
            get {
                return ResourceManager.GetString("ApplicationUpdates_NewVersion_Text", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No update available..
        /// </summary>
        internal static string ApplicationUpdates_NoUpdate_Text {
            get {
                return ResourceManager.GetString("ApplicationUpdates_NoUpdate_Text", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Project: {0}.
        /// </summary>
        internal static string AuthenticateToken_ProjectName {
            get {
                return ResourceManager.GetString("AuthenticateToken_ProjectName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Broken by {0}. .
        /// </summary>
        internal static string BuildDetails_BrokenBy {
            get {
                return ResourceManager.GetString("BuildDetails_BrokenBy", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Started by multiple sources. .
        /// </summary>
        internal static string BuildDetails_Cause_MultipleSources {
            get {
                return ResourceManager.GetString("BuildDetails_Cause_MultipleSources", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Started remotely. .
        /// </summary>
        internal static string BuildDetails_Cause_RemoteHost {
            get {
                return ResourceManager.GetString("BuildDetails_Cause_RemoteHost", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Changes by {0} persons. .
        /// </summary>
        internal static string BuildDetails_Cause_SCM_Multiple {
            get {
                return ResourceManager.GetString("BuildDetails_Cause_SCM_Multiple", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Changes by {0}. .
        /// </summary>
        internal static string BuildDetails_Cause_SCM_Single {
            get {
                return ResourceManager.GetString("BuildDetails_Cause_SCM_Single", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Started by SCM change. .
        /// </summary>
        internal static string BuildDetails_Cause_SCM_Unknown {
            get {
                return ResourceManager.GetString("BuildDetails_Cause_SCM_Unknown", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Scheduled. .
        /// </summary>
        internal static string BuildDetails_Cause_Timer {
            get {
                return ResourceManager.GetString("BuildDetails_Cause_Timer", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Started by upstream project. .
        /// </summary>
        internal static string BuildDetails_Cause_UpstreamProject {
            get {
                return ResourceManager.GetString("BuildDetails_Cause_UpstreamProject", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Started by {0}. .
        /// </summary>
        internal static string BuildDetails_Cause_User {
            get {
                return ResourceManager.GetString("BuildDetails_Cause_User", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Took less than a minute. .
        /// </summary>
        internal static string BuildDetails_Duration_0M {
            get {
                return ResourceManager.GetString("BuildDetails_Duration_0M", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Took {0:D1} hour(s) {1:D1} minutes. .
        /// </summary>
        internal static string BuildDetails_Duration_HHMM {
            get {
                return ResourceManager.GetString("BuildDetails_Duration_HHMM", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Took {0:D1} minutes. .
        /// </summary>
        internal static string BuildDetails_Duration_MM {
            get {
                return ResourceManager.GetString("BuildDetails_Duration_MM", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0:D1} hours {1:D1} minutes longer than usual. .
        /// </summary>
        internal static string BuildDetails_EstimatedDuration_HHMM_LongerThanUsual {
            get {
                return ResourceManager.GetString("BuildDetails_EstimatedDuration_HHMM_LongerThanUsual", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0:D1} hour(s) {1:D1} minutes remaining. .
        /// </summary>
        internal static string BuildDetails_EstimatedDuration_HHMM_Remaining {
            get {
                return ResourceManager.GetString("BuildDetails_EstimatedDuration_HHMM_Remaining", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0:D1} minutes longer than usual. .
        /// </summary>
        internal static string BuildDetails_EstimatedDuration_MM_LongerThanUsual {
            get {
                return ResourceManager.GetString("BuildDetails_EstimatedDuration_MM_LongerThanUsual", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0:D1} minutes remaining. .
        /// </summary>
        internal static string BuildDetails_EstimatedDuration_MM_Remaining {
            get {
                return ResourceManager.GetString("BuildDetails_EstimatedDuration_MM_Remaining", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} - {1} ({2}).
        /// </summary>
        internal static string BuildDetails_Format_DisplayName_NumberDate {
            get {
                return ResourceManager.GetString("BuildDetails_Format_DisplayName_NumberDate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} ({1}).
        /// </summary>
        internal static string BuildDetails_Format_NumberDate {
            get {
                return ResourceManager.GetString("BuildDetails_Format_NumberDate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} ({1}, {2}).
        /// </summary>
        internal static string BuildDetails_Format_NumberDateUsers {
            get {
                return ResourceManager.GetString("BuildDetails_Format_NumberDateUsers", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Subsequent build is queued..
        /// </summary>
        internal static string BuildDetails_InQueue {
            get {
                return ResourceManager.GetString("BuildDetails_InQueue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to  In queue since {0}..
        /// </summary>
        internal static string BuildDetails_InQueue_Since {
            get {
                return ResourceManager.GetString("BuildDetails_InQueue_Since", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}..
        /// </summary>
        internal static string BuildDetails_InQueue_Why {
            get {
                return ResourceManager.GetString("BuildDetails_InQueue_Why", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to , .
        /// </summary>
        internal static string BuildDetails_UserSeparator {
            get {
                return ResourceManager.GetString("BuildDetails_UserSeparator", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Build failed.
        /// </summary>
        internal static string BuildFailed_Caption {
            get {
                return ResourceManager.GetString("BuildFailed_Caption", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Projects regressed.
        /// </summary>
        internal static string BuildRegressions_Caption {
            get {
                return ResourceManager.GetString("BuildRegressions_Caption", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Build was aborted.
        /// </summary>
        internal static string BuildStatus_Aborted {
            get {
                return ResourceManager.GetString("BuildStatus_Aborted", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Build was aborted. Build is stuck..
        /// </summary>
        internal static string BuildStatus_Aborted_Stuck {
            get {
                return ResourceManager.GetString("BuildStatus_Aborted_Stuck", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Project disabled.
        /// </summary>
        internal static string BuildStatus_Disabled {
            get {
                return ResourceManager.GetString("BuildStatus_Disabled", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Project disabled. Build in progress..
        /// </summary>
        internal static string BuildStatus_Disabled_BuildInProgress {
            get {
                return ResourceManager.GetString("BuildStatus_Disabled_BuildInProgress", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Project disabled. Build is stuck..
        /// </summary>
        internal static string BuildStatus_Disabled_Stuck {
            get {
                return ResourceManager.GetString("BuildStatus_Disabled_Stuck", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Build failed.
        /// </summary>
        internal static string BuildStatus_Failed {
            get {
                return ResourceManager.GetString("BuildStatus_Failed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Last build failed. Build in progress..
        /// </summary>
        internal static string BuildStatus_Failed_BuildInProgress {
            get {
                return ResourceManager.GetString("BuildStatus_Failed_BuildInProgress", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Last build failed. Build is stuck..
        /// </summary>
        internal static string BuildStatus_Failed_Stuck {
            get {
                return ResourceManager.GetString("BuildStatus_Failed_Stuck", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Indeterminate: no build done..
        /// </summary>
        internal static string BuildStatus_Indeterminate {
            get {
                return ResourceManager.GetString("BuildStatus_Indeterminate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Indeterminate: no build done. Build in progress..
        /// </summary>
        internal static string BuildStatus_Indeterminate_BuildInProgress {
            get {
                return ResourceManager.GetString("BuildStatus_Indeterminate_BuildInProgress", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Indeterminate: no build done. Build is stuck..
        /// </summary>
        internal static string BuildStatus_Indeterminate_Stuck {
            get {
                return ResourceManager.GetString("BuildStatus_Indeterminate_Stuck", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Successful.
        /// </summary>
        internal static string BuildStatus_Successful {
            get {
                return ResourceManager.GetString("BuildStatus_Successful", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Successful. Build in progress..
        /// </summary>
        internal static string BuildStatus_Successful_BuildInProgress {
            get {
                return ResourceManager.GetString("BuildStatus_Successful_BuildInProgress", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Successful. Build is stuck..
        /// </summary>
        internal static string BuildStatus_Successful_Stuck {
            get {
                return ResourceManager.GetString("BuildStatus_Successful_Stuck", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unknown status.
        /// </summary>
        internal static string BuildStatus_Unknown {
            get {
                return ResourceManager.GetString("BuildStatus_Unknown", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unstable: some tests failed..
        /// </summary>
        internal static string BuildStatus_Unstable {
            get {
                return ResourceManager.GetString("BuildStatus_Unstable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unstable: some tests failed. Build in progress..
        /// </summary>
        internal static string BuildStatus_Unstable_BuildInProgress {
            get {
                return ResourceManager.GetString("BuildStatus_Unstable_BuildInProgress", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unstable: some tests failed. Build is stuck..
        /// </summary>
        internal static string BuildStatus_Unstable_Stuck {
            get {
                return ResourceManager.GetString("BuildStatus_Unstable_Stuck", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Build status.
        /// </summary>
        internal static string DisplayBuildStatus_Caption {
            get {
                return ResourceManager.GetString("DisplayBuildStatus_Caption", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No projects configured.
        /// </summary>
        internal static string DisplayBuildStatus_NoProjects {
            get {
                return ResourceManager.GetString("DisplayBuildStatus_NoProjects", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An error occurred.
        /// </summary>
        internal static string ErrorBoxCaption {
            get {
                return ResourceManager.GetString("ErrorBoxCaption", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The following error occurred:
        ///
        ///Message: {0}.
        /// </summary>
        internal static string ErrorBoxMessage {
            get {
                return ResourceManager.GetString("ErrorBoxMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error.
        /// </summary>
        internal static string FailedLoadingIcons_Caption {
            get {
                return ResourceManager.GetString("FailedLoadingIcons_Caption", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed loading icons for the tray notifier..
        /// </summary>
        internal static string FailedLoadingIcons_Text {
            get {
                return ResourceManager.GetString("FailedLoadingIcons_Text", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error loading projects from {0}.
        /// </summary>
        internal static string FailedLoadingProjects_FormatString {
            get {
                return ResourceManager.GetString("FailedLoadingProjects_FormatString", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A fatal error occurred.
        /// </summary>
        internal static string FatalError_Caption {
            get {
                return ResourceManager.GetString("FatalError_Caption", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Fatal error.
        ///
        ///Please refer to the log files for more details..
        /// </summary>
        internal static string FatalError_Message {
            get {
                return ResourceManager.GetString("FatalError_Message", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Last check: {0}.
        /// </summary>
        internal static string LastCheck_Format {
            get {
                return ResourceManager.GetString("LastCheck_Format", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Loading projects from {0}.
        /// </summary>
        internal static string LoadingProjects_FormatString {
            get {
                return ResourceManager.GetString("LoadingProjects_FormatString", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Build failed.
        /// </summary>
        internal static string NotificationSettings_Failed {
            get {
                return ResourceManager.GetString("NotificationSettings_Failed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Build fixed.
        /// </summary>
        internal static string NotificationSettings_Fixed {
            get {
                return ResourceManager.GetString("NotificationSettings_Fixed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Build still failing.
        /// </summary>
        internal static string NotificationSettings_StillFailing {
            get {
                return ResourceManager.GetString("NotificationSettings_StillFailing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Build succeeded.
        /// </summary>
        internal static string NotificationSettings_Succeeded {
            get {
                return ResourceManager.GetString("NotificationSettings_Succeeded", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error.
        /// </summary>
        internal static string RunBuildFailed_Caption {
            get {
                return ResourceManager.GetString("RunBuildFailed_Caption", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed running build: {0}..
        /// </summary>
        internal static string RunBuildFailed_Text {
            get {
                return ResourceManager.GetString("RunBuildFailed_Text", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The following error occurred:
        ///
        ///Type: {0}
        ///Message: {1}
        ///
        ///Please refer to the log files for more details.
        ///
        ///The application will now be closed..
        /// </summary>
        internal static string SeriousErrorBoxMessage {
            get {
                return ResourceManager.GetString("SeriousErrorBoxMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to All builds are good..
        /// </summary>
        internal static string Tooltip_AllGood {
            get {
                return ResourceManager.GetString("Tooltip_AllGood", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}: {1}..
        /// </summary>
        internal static string Tooltip_BuildStatus {
            get {
                return ResourceManager.GetString("Tooltip_BuildStatus", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}: Failed and in progress..
        /// </summary>
        internal static string Tooltip_Failed_And_InProgress {
            get {
                return ResourceManager.GetString("Tooltip_Failed_And_InProgress", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}: In progress..
        /// </summary>
        internal static string Tooltip_InProgress {
            get {
                return ResourceManager.GetString("Tooltip_InProgress", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Version {0}.
        /// </summary>
        internal static string Version_Format {
            get {
                return ResourceManager.GetString("Version_Format", resourceCulture);
            }
        }
    }
}
