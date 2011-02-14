﻿using System;
using System.Collections.Generic;
using System.Net;
using System.Threading;
using System.Windows;
using System.Windows.Markup;
using Microsoft.Practices.EnterpriseLibrary.Common.Properties;
using Microsoft.Practices.ServiceLocation;

namespace Microsoft.Practices.EnterpriseLibrary.Common.Configuration
{
    public static partial class EnterpriseLibraryContainer
    {
        private static int downloadInProgress = 0;

        /// <summary>
        /// Event fired on the completion of asynchronous configuration of
        /// Enterprise Library started by a call to <see cref="ConfigureAsync"/>.
        /// This event is fired on success or failure of the configuration.
        /// Once this event is fired, all Enterprise Library capabilities are
        /// ready to use.
        /// </summary>
        public static event EventHandler<EnterpriseLibraryConfigurationCompletedEventArgs>
            EnterpriseLibraryConfigurationCompleted;

        /// <summary>
        /// Configure Enterprise Library by asynchronously downloading a configuration XAML
        /// from the given URI.
        /// </summary>
        /// <param name="uri">URI to download the XAML from.</param>
        /// <param name="state">Extra information given by the caller. This will be passed
        /// through in the eventargs of the <see cref="EnterpriseLibraryConfigurationCompleted"/>
        /// event.</param>
        public static void ConfigureAsync(Uri uri, object state = null)
        {
            if (Interlocked.Exchange(ref downloadInProgress, 1) == 1)
            {
                throw new InvalidOperationException(Resources.CannotStartConfigurationDownload);
            }

            Current = new UnconfiguredLocator();

            var client = new WebClient();

            client.DownloadStringCompleted += (sender, e) =>
            {
                EnterpriseLibraryConfigurationCompletedEventArgs resultArgs;
                try
                {
                    if (e.Error != null)
                    {
                        resultArgs = new EnterpriseLibraryConfigurationCompletedEventArgs(e.Error);
                    }
                    else
                    {
                        var configXaml = (ResourceDictionary)XamlReader.Load(e.Result);
                        var configSource = new ResourceDictionaryConfigurationSource(configXaml);
                        Current = CreateDefaultContainer(configSource);
                        resultArgs = new EnterpriseLibraryConfigurationCompletedEventArgs(state);
                    }
                }
                catch (Exception ex)
                {
                    resultArgs = new EnterpriseLibraryConfigurationCompletedEventArgs(ex, state);
                    Current = null;
                }

                Interlocked.Exchange(ref downloadInProgress, 0);

                var handlers = EnterpriseLibraryConfigurationCompleted;
                if (handlers != null)
                {
                    handlers(null, resultArgs);
                }
            };

            client.DownloadStringAsync(uri);
        }

        #region Nested type: UnconfiguredLocator

        private class UnconfiguredLocator : ServiceLocatorImplBase
        {
            protected override object DoGetInstance(Type serviceType, string key)
            {
                throw new InvalidOperationException(Resources.EntlibNotYetConfigured);
            }

            protected override IEnumerable<object> DoGetAllInstances(Type serviceType)
            {
                throw new InvalidOperationException(Resources.EntlibNotYetConfigured);
            }
        }

        #endregion
    }

    /// <summary>
    /// Event args class used to signal when Enterprise Library has completed an asynchronous
    /// configuration.
    /// </summary>
    public class EnterpriseLibraryConfigurationCompletedEventArgs : EventArgs
    {
        /// <summary>
        /// Construct a new instance of <see cref="EnterpriseLibraryConfigurationCompletedEventArgs"/>
        /// that indicates that configuration was successful and Enterprise Library
        /// is now ready to use.
        /// </summary>
        /// <param name="state">State object used by caller to track asynchronous operations.</param>
        public EnterpriseLibraryConfigurationCompletedEventArgs(object state)
            : this(null, state)
        {
            Error = null;
        }

        /// <summary>
        /// Construct a new instance of <see cref="EnterpriseLibraryConfigurationCompletedEventArgs"/>
        /// that indicates that the asynchronous configuration failed, and includes the exception
        /// that reported the failure.
        /// </summary>
        /// <param name="error">Exception indicating what went wrong.</param>
        /// <param name="state">State object used by caller to track asynchronous operations.</param>
        public EnterpriseLibraryConfigurationCompletedEventArgs(Exception error, object state)
        {
            Error = error;
            State = state;
        }

        /// <summary>
        /// Exception that occurred during the configuration. If configuration is
        /// successful this will be null.
        /// </summary>
        public Exception Error { get; private set; }

        /// <summary>
        /// Did the configuration complete successfully? Yes if true, false if not.
        /// </summary>
        public bool ConfiguredSuccessfully
        {
            get { return Error == null; }
        }

        /// <summary>
        /// The state object passed to the original ConfigureAsync call.
        /// </summary>
        public object State { get; private set; }
    }
}