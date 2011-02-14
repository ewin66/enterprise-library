﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.Practices.EnterpriseLibrary.Logging.MsmqDistributor.Properties {
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
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.Practices.EnterpriseLibrary.Logging.MsmqDistributor.Properties.Resource" +
                            "s", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to Application.
        /// </summary>
        internal static string ApplicationLogName {
            get {
                return ResourceManager.GetString("ApplicationLogName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Message: 
        ///.
        /// </summary>
        internal static string DistEventLoggerMessagePrefix {
            get {
                return ResourceManager.GetString("DistEventLoggerMessagePrefix", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Enterprise Library Distributor Service.
        /// </summary>
        internal static string DistributorEventLoggerDefaultApplicationName {
            get {
                return ResourceManager.GetString("DistributorEventLoggerDefaultApplicationName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to name.
        /// </summary>
        internal static string DistributorServiceNameTag {
            get {
                return ResourceManager.GetString("DistributorServiceNameTag", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error initializing the service. See EventLog for error details..
        /// </summary>
        internal static string ErrorInitializingService {
            get {
                return ResourceManager.GetString("ErrorInitializingService", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error loading Logging Distributor configuration file..
        /// </summary>
        internal static string ErrorLoadingDistributorConfiguration {
            get {
                return ResourceManager.GetString("ErrorLoadingDistributorConfiguration", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to exception.
        /// </summary>
        internal static string Exception {
            get {
                return ResourceManager.GetString("Exception", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to deserialize message with id {0} from queue {1}. Please make sure only LogEntries are traced and a BinaryFormatter is used to format the message. The offending message has been removed from the queue..
        /// </summary>
        internal static string ExceptionCouldNotDeserializeMessageFromQueue {
            get {
                return ResourceManager.GetString("ExceptionCouldNotDeserializeMessageFromQueue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The {0} section could not be found in the service&apos;s configuration file..
        /// </summary>
        internal static string ExceptionCouldNotFindConfigurationSection {
            get {
                return ResourceManager.GetString("ExceptionCouldNotFindConfigurationSection", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The Windows service initialization sequence is complete. No errors have occurred..
        /// </summary>
        internal static string InitializeComponentCompleted {
            get {
                return ResourceManager.GetString("InitializeComponentCompleted", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to InitializeComponent - end.
        /// </summary>
        internal static string InitializeComponentCompletedMessage {
            get {
                return ResourceManager.GetString("InitializeComponentCompletedMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The Windows service initialization sequence has started..
        /// </summary>
        internal static string InitializeComponentStarted {
            get {
                return ResourceManager.GetString("InitializeComponentStarted", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to InitializeComponent - begin.
        /// </summary>
        internal static string InitializeComponentStartedMessage {
            get {
                return ResourceManager.GetString("InitializeComponentStartedMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to InitializeStartupSequence - error.
        /// </summary>
        internal static string InitializeStartupSequenceErrorMessage {
            get {
                return ResourceManager.GetString("InitializeStartupSequenceErrorMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to InitializeStartupSequence - end.
        /// </summary>
        internal static string InitializeStartupSequenceFinishedMessage {
            get {
                return ResourceManager.GetString("InitializeStartupSequenceFinishedMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to InitializeStartupSequence - begin.
        /// </summary>
        internal static string InitializeStartupSequenceStartedMessage {
            get {
                return ResourceManager.GetString("InitializeStartupSequenceStartedMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to locate serviceName in distributor configuration file.
        /// </summary>
        internal static string InstallerCannotReadServiceName {
            get {
                return ResourceManager.GetString("InstallerCannotReadServiceName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The queue listener could not be successfully stopped. No errors occurred. Note: it took [{0}] tries to stop the queue listener. The queue listener might be busy, please retry..
        /// </summary>
        internal static string ListenerCannotStop {
            get {
                return ResourceManager.GetString("ListenerCannotStop", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The queue listener has started successfully. Note: the listener timer is set to [{0}] milliseconds..
        /// </summary>
        internal static string ListenerStartComplete {
            get {
                return ResourceManager.GetString("ListenerStartComplete", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to StartListener - end.
        /// </summary>
        internal static string ListenerStartCompleteMessage {
            get {
                return ResourceManager.GetString("ListenerStartCompleteMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An error occurred while trying to start the queue listener. See &apos;Exception Information Detail&apos; below for more information..
        /// </summary>
        internal static string ListenerStartError {
            get {
                return ResourceManager.GetString("ListenerStartError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to StartListener - error.
        /// </summary>
        internal static string ListenerStartErrorMessage {
            get {
                return ResourceManager.GetString("ListenerStartErrorMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Attempting to start the queue listener..
        /// </summary>
        internal static string ListenerStarting {
            get {
                return ResourceManager.GetString("ListenerStarting", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to StartListener - begin.
        /// </summary>
        internal static string ListenerStartingMessage {
            get {
                return ResourceManager.GetString("ListenerStartingMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The queue listener was successfully stopped. No errors occurred. Note: it took [{0}] tries to stop the queue listener..
        /// </summary>
        internal static string ListenerStopCompleted {
            get {
                return ResourceManager.GetString("ListenerStopCompleted", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to StopListener - end.
        /// </summary>
        internal static string ListenerStopCompletedMessage {
            get {
                return ResourceManager.GetString("ListenerStopCompletedMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An error occurred while trying to stop the queue listener. See &apos;Exception Information Detail&apos; below for more information..
        /// </summary>
        internal static string ListenerStopError {
            get {
                return ResourceManager.GetString("ListenerStopError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to StopListener - error.
        /// </summary>
        internal static string ListenerStopErrorMessage {
            get {
                return ResourceManager.GetString("ListenerStopErrorMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Attempting to stop the queue listener..
        /// </summary>
        internal static string ListenerStopStarted {
            get {
                return ResourceManager.GetString("ListenerStopStarted", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to StopListener - begin.
        /// </summary>
        internal static string ListenerStopStartedMessage {
            get {
                return ResourceManager.GetString("ListenerStopStartedMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Access denied to the DistributorMSMQ queue &apos;{0}&apos;. Identity trying to access the queue : {1}.   See &apos;Exception Information Details&apos; below for more information..
        /// </summary>
        internal static string MsmqAccessDenied {
            get {
                return ResourceManager.GetString("MsmqAccessDenied", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The MSMQDistributor queue &apos;{0}&apos; returned an invalid transaction usage error.  See &apos;Exception Information Details&apos; below for more information..
        /// </summary>
        internal static string MsmqInvalidTransactionUsage {
            get {
                return ResourceManager.GetString("MsmqInvalidTransactionUsage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Log received by MSMQ Log Distributor.  
        ///
        ///Message: {0}.
        /// </summary>
        internal static string MsmqLogReceived {
            get {
                return ResourceManager.GetString("MsmqLogReceived", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An error occurred while receiving a message from the queue &apos;{0}&apos;.  See &apos;Exception Information Details&apos; below for more information..
        /// </summary>
        internal static string MsmqReceiveError {
            get {
                return ResourceManager.GetString("MsmqReceiveError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A general error occurred while receiving a message from the queue &apos;{0}&apos;..
        /// </summary>
        internal static string MsmqReceiveGeneralError {
            get {
                return ResourceManager.GetString("MsmqReceiveGeneralError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The DistributorMSMQ queue  &apos;{0}&apos;  encountered a receive timeout error.  See &apos;Exception Information Details&apos; below for more information..
        /// </summary>
        internal static string MsmqReceiveTimeout {
            get {
                return ResourceManager.GetString("MsmqReceiveTimeout", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to See &apos;Exception Information Details&apos; below for more information..
        /// </summary>
        internal static string ProcessQMsgSeeDetails {
            get {
                return ResourceManager.GetString("ProcessQMsgSeeDetails", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An error occurred while receiving message(s) from the queue. The service will be stopped..
        /// </summary>
        internal static string QueueTimedEventError {
            get {
                return ResourceManager.GetString("QueueTimedEventError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The Service Controller could not stop the service &apos;{0}&apos;. Make sure the service name listed in the Service Management Console is the same as {0}.
        /// To solve this problem, stop the service manually and uninstall it. Try the installation procedure again and make sure the same application configuration file is available when the service is started..
        /// </summary>
        internal static string ServiceControllerStopError {
            get {
                return ResourceManager.GetString("ServiceControllerStopError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot stop the service &apos;{0}&apos;..
        /// </summary>
        internal static string ServiceControllerStopException {
            get {
                return ResourceManager.GetString("ServiceControllerStopException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The service &apos;{0}&apos; was paused correctly..
        /// </summary>
        internal static string ServicePausedSuccess {
            get {
                return ResourceManager.GetString("ServicePausedSuccess", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The service &apos;{0}&apos; did not pause correctly.
        ///See &apos;Summary for {0}&apos; and additional &apos;Exception Information Details&apos; below for more information. The service will be stopped..
        /// </summary>
        internal static string ServicePauseError {
            get {
                return ResourceManager.GetString("ServicePauseError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The service &apos;{0}&apos; did not pause gracefully. 
        ///See &apos;Summary for {0}&apos; and additional &apos;Exception Information Details&apos; below for more information..
        /// </summary>
        internal static string ServicePauseWarning {
            get {
                return ResourceManager.GetString("ServicePauseWarning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to  The service &apos;{0}&apos; resumed correctly..
        /// </summary>
        internal static string ServiceResumeComplete {
            get {
                return ResourceManager.GetString("ServiceResumeComplete", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to  The service &apos;{0}&apos; was not resumed correctly.
        ///See &apos;Summary for {0}&apos; and additional &apos;Exception Information Details&apos; below for more information. The service will be stopped..
        /// </summary>
        internal static string ServiceResumeError {
            get {
                return ResourceManager.GetString("ServiceResumeError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The service &apos;{0}&apos; started correctly..
        /// </summary>
        internal static string ServiceStartComplete {
            get {
                return ResourceManager.GetString("ServiceStartComplete", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An error occurred while starting the service {0}.
        ///See &apos;Summary for {0}&apos; and additional &apos;Exception Information Details&apos; below for more information. The service needs to be stopped..
        /// </summary>
        internal static string ServiceStartError {
            get {
                return ResourceManager.GetString("ServiceStartError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The service &apos;{0}&apos; stopped correctly..
        /// </summary>
        internal static string ServiceStopComplete {
            get {
                return ResourceManager.GetString("ServiceStopComplete", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The service &apos;{0}&apos; did not stop correctly.
        ///See &apos;Summary for {0}&apos; and additional &apos;Exception Information Details&apos; below for more information. The service will be stopped..
        /// </summary>
        internal static string ServiceStopError {
            get {
                return ResourceManager.GetString("ServiceStopError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The service &apos;{0}&apos; did not stop gracefully. 
        ///See &apos;Summary for {0}&apos; and additional &apos;Exception Information Details&apos; below for more information..
        /// </summary>
        internal static string ServiceStopWarning {
            get {
                return ResourceManager.GetString("ServiceStopWarning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An error occurred while trying to shut down the service {0}. This error will disable the ability for this service to shut itself down..
        /// </summary>
        internal static string ServiceUnableToShutdown {
            get {
                return ResourceManager.GetString("ServiceUnableToShutdown", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to StopListener - warning.
        /// </summary>
        internal static string StopListenerWarningMessage {
            get {
                return ResourceManager.GetString("StopListenerWarningMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An unknown error has occurred..
        /// </summary>
        internal static string UnknownError {
            get {
                return ResourceManager.GetString("UnknownError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The validation sequence is complete. No errors have occurred..
        /// </summary>
        internal static string ValidationComplete {
            get {
                return ResourceManager.GetString("ValidationComplete", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An error occurred in one of the validation sequences. See &apos;Exception Information Details&apos; below for more information. The service will be stopped..
        /// </summary>
        internal static string ValidationError {
            get {
                return ResourceManager.GetString("ValidationError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The validation sequence has been started..
        /// </summary>
        internal static string ValidationStarted {
            get {
                return ResourceManager.GetString("ValidationStarted", resourceCulture);
            }
        }
    }
}
