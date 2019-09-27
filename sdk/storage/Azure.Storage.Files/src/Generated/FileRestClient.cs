// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// This file was automatically generated.  Do not edit.

#pragma warning disable IDE0016 // Null check can be simplified
#pragma warning disable IDE0017 // Variable declaration can be inlined
#pragma warning disable IDE0018 // Object initialization can be simplified
#pragma warning disable SA1402  // File may only contain a single type

#region Service
namespace Azure.Storage.Files
{
    /// <summary>
    /// Azure File Storage
    /// </summary>
    internal static partial class FileRestClient
    {
        #region Service operations
        /// <summary>
        /// Service operations for Azure File Storage
        /// </summary>
        public static partial class Service
        {
            #region Service.SetPropertiesAsync
            /// <summary>
            /// Sets properties for a storage account's File service endpoint, including properties for Storage Analytics metrics and CORS (Cross-Origin Resource Sharing) rules.
            /// </summary>
            /// <param name="pipeline">The pipeline used for sending requests.</param>
            /// <param name="resourceUri">The URL of the service account, share, directory or file that is the target of the desired operation.</param>
            /// <param name="properties">The StorageService properties.</param>
            /// <param name="timeout">The timeout parameter is expressed in seconds. For more information, see <a href="https://docs.microsoft.com/en-us/rest/api/storageservices/Setting-Timeouts-for-File-Service-Operations?redirectedfrom=MSDN">Setting Timeouts for File Service Operations.</a></param>
            /// <param name="async">Whether to invoke the operation asynchronously.  The default value is true.</param>
            /// <param name="clientDiagnostics">The ClientDiagnostics instance used for operation reporting.</param>
            /// <param name="operationName">Operation name.</param>
            /// <param name="cancellationToken">Cancellation token.</param>
            /// <returns>Azure.Response</returns>
            public static async System.Threading.Tasks.ValueTask<Azure.Response> SetPropertiesAsync(
                Azure.Core.Pipeline.ClientDiagnostics clientDiagnostics,
                Azure.Core.Pipeline.HttpPipeline pipeline,
                System.Uri resourceUri,
                Azure.Storage.Files.Models.FileServiceProperties properties,
                int? timeout = default,
                bool async = true,
                string operationName = "Azure.Storage.Files.ServiceClient.SetProperties",
                System.Threading.CancellationToken cancellationToken = default)
            {
                Azure.Core.Pipeline.DiagnosticScope _scope = clientDiagnostics.CreateScope(operationName);
                try
                {
                    _scope.AddAttribute("url", resourceUri);
                    _scope.Start();
                    using (Azure.Core.HttpMessage _message = SetPropertiesAsync_CreateMessage(
                        pipeline,
                        resourceUri,
                        properties,
                        timeout))
                    {
                        if (async)
                        {
                            // Send the request asynchronously if we're being called via an async path
                            await pipeline.SendAsync(_message, cancellationToken).ConfigureAwait(false);
                        }
                        else
                        {
                            // Send the request synchronously through the API that blocks if we're being called via a sync path
                            // (this is safe because the Task will complete before the user can call Wait)
                            pipeline.Send(_message, cancellationToken);
                        }
                        Azure.Response _response = _message.Response;
                        cancellationToken.ThrowIfCancellationRequested();
                        return SetPropertiesAsync_CreateResponse(_response);
                    }
                }
                catch (System.Exception ex)
                {
                    _scope.Failed(ex);
                    throw;
                }
                finally
                {
                    _scope.Dispose();
                }
            }

            /// <summary>
            /// Create the Service.SetPropertiesAsync request.
            /// </summary>
            /// <param name="pipeline">The pipeline used for sending requests.</param>
            /// <param name="resourceUri">The URL of the service account, share, directory or file that is the target of the desired operation.</param>
            /// <param name="properties">The StorageService properties.</param>
            /// <param name="timeout">The timeout parameter is expressed in seconds. For more information, see <a href="https://docs.microsoft.com/en-us/rest/api/storageservices/Setting-Timeouts-for-File-Service-Operations?redirectedfrom=MSDN">Setting Timeouts for File Service Operations.</a></param>
            /// <returns>The Service.SetPropertiesAsync Message.</returns>
            internal static Azure.Core.HttpMessage SetPropertiesAsync_CreateMessage(
                Azure.Core.Pipeline.HttpPipeline pipeline,
                System.Uri resourceUri,
                Azure.Storage.Files.Models.FileServiceProperties properties,
                int? timeout = default)
            {
                // Validation
                if (resourceUri == null)
                {
                    throw new System.ArgumentNullException(nameof(resourceUri));
                }
                if (properties == null)
                {
                    throw new System.ArgumentNullException(nameof(properties));
                }

                // Create the request
                Azure.Core.HttpMessage _message = pipeline.CreateMessage();
                Azure.Core.Request _request = _message.Request;

                // Set the endpoint
                _request.Method = Azure.Core.RequestMethod.Put;
                _request.Uri.Reset(resourceUri);
                _request.Uri.AppendQuery("restype", "service");
                _request.Uri.AppendQuery("comp", "properties");
                if (timeout != null) { _request.Uri.AppendQuery("timeout", System.Uri.EscapeDataString(timeout.Value.ToString(System.Globalization.CultureInfo.InvariantCulture))); }

                // Add request headers
                _request.Headers.SetValue("x-ms-version", "2019-02-02");

                // Create the body
                System.Xml.Linq.XElement _body = Azure.Storage.Files.Models.FileServiceProperties.ToXml(properties, "StorageServiceProperties", "");
                string _text = _body.ToString(System.Xml.Linq.SaveOptions.DisableFormatting);
                _request.Headers.SetValue("Content-Type", "application/xml");
                _request.Headers.SetValue("Content-Length", _text.Length.ToString(System.Globalization.CultureInfo.InvariantCulture));
                _request.Content = Azure.Core.RequestContent.Create(System.Text.Encoding.UTF8.GetBytes(_text));

                return _message;
            }

            /// <summary>
            /// Create the Service.SetPropertiesAsync response or throw a failure exception.
            /// </summary>
            /// <param name="response">The raw Response.</param>
            /// <returns>The Service.SetPropertiesAsync Azure.Response.</returns>
            internal static Azure.Response SetPropertiesAsync_CreateResponse(
                Azure.Response response)
            {
                // Process the response
                switch (response.Status)
                {
                    case 202:
                    {
                        return response;
                    }
                    default:
                    {
                        // Create the result
                        System.Xml.Linq.XDocument _xml = System.Xml.Linq.XDocument.Load(response.ContentStream, System.Xml.Linq.LoadOptions.PreserveWhitespace);
                        Azure.Storage.Files.Models.StorageError _value = Azure.Storage.Files.Models.StorageError.FromXml(_xml.Root);

                        throw _value.CreateException(response);
                    }
                }
            }
            #endregion Service.SetPropertiesAsync

            #region Service.GetPropertiesAsync
            /// <summary>
            /// Gets the properties of a storage account's File service, including properties for Storage Analytics metrics and CORS (Cross-Origin Resource Sharing) rules.
            /// </summary>
            /// <param name="pipeline">The pipeline used for sending requests.</param>
            /// <param name="resourceUri">The URL of the service account, share, directory or file that is the target of the desired operation.</param>
            /// <param name="timeout">The timeout parameter is expressed in seconds. For more information, see <a href="https://docs.microsoft.com/en-us/rest/api/storageservices/Setting-Timeouts-for-File-Service-Operations?redirectedfrom=MSDN">Setting Timeouts for File Service Operations.</a></param>
            /// <param name="async">Whether to invoke the operation asynchronously.  The default value is true.</param>
            /// <param name="clientDiagnostics">The ClientDiagnostics instance used for operation reporting.</param>
            /// <param name="operationName">Operation name.</param>
            /// <param name="cancellationToken">Cancellation token.</param>
            /// <returns>Storage service properties.</returns>
            public static async System.Threading.Tasks.ValueTask<Azure.Response<Azure.Storage.Files.Models.FileServiceProperties>> GetPropertiesAsync(
                Azure.Core.Pipeline.ClientDiagnostics clientDiagnostics,
                Azure.Core.Pipeline.HttpPipeline pipeline,
                System.Uri resourceUri,
                int? timeout = default,
                bool async = true,
                string operationName = "Azure.Storage.Files.ServiceClient.GetProperties",
                System.Threading.CancellationToken cancellationToken = default)
            {
                Azure.Core.Pipeline.DiagnosticScope _scope = clientDiagnostics.CreateScope(operationName);
                try
                {
                    _scope.AddAttribute("url", resourceUri);
                    _scope.Start();
                    using (Azure.Core.HttpMessage _message = GetPropertiesAsync_CreateMessage(
                        pipeline,
                        resourceUri,
                        timeout))
                    {
                        if (async)
                        {
                            // Send the request asynchronously if we're being called via an async path
                            await pipeline.SendAsync(_message, cancellationToken).ConfigureAwait(false);
                        }
                        else
                        {
                            // Send the request synchronously through the API that blocks if we're being called via a sync path
                            // (this is safe because the Task will complete before the user can call Wait)
                            pipeline.Send(_message, cancellationToken);
                        }
                        Azure.Response _response = _message.Response;
                        cancellationToken.ThrowIfCancellationRequested();
                        return GetPropertiesAsync_CreateResponse(_response);
                    }
                }
                catch (System.Exception ex)
                {
                    _scope.Failed(ex);
                    throw;
                }
                finally
                {
                    _scope.Dispose();
                }
            }

            /// <summary>
            /// Create the Service.GetPropertiesAsync request.
            /// </summary>
            /// <param name="pipeline">The pipeline used for sending requests.</param>
            /// <param name="resourceUri">The URL of the service account, share, directory or file that is the target of the desired operation.</param>
            /// <param name="timeout">The timeout parameter is expressed in seconds. For more information, see <a href="https://docs.microsoft.com/en-us/rest/api/storageservices/Setting-Timeouts-for-File-Service-Operations?redirectedfrom=MSDN">Setting Timeouts for File Service Operations.</a></param>
            /// <returns>The Service.GetPropertiesAsync Message.</returns>
            internal static Azure.Core.HttpMessage GetPropertiesAsync_CreateMessage(
                Azure.Core.Pipeline.HttpPipeline pipeline,
                System.Uri resourceUri,
                int? timeout = default)
            {
                // Validation
                if (resourceUri == null)
                {
                    throw new System.ArgumentNullException(nameof(resourceUri));
                }

                // Create the request
                Azure.Core.HttpMessage _message = pipeline.CreateMessage();
                Azure.Core.Request _request = _message.Request;

                // Set the endpoint
                _request.Method = Azure.Core.RequestMethod.Get;
                _request.Uri.Reset(resourceUri);
                _request.Uri.AppendQuery("restype", "service");
                _request.Uri.AppendQuery("comp", "properties");
                if (timeout != null) { _request.Uri.AppendQuery("timeout", System.Uri.EscapeDataString(timeout.Value.ToString(System.Globalization.CultureInfo.InvariantCulture))); }

                // Add request headers
                _request.Headers.SetValue("x-ms-version", "2019-02-02");

                return _message;
            }

            /// <summary>
            /// Create the Service.GetPropertiesAsync response or throw a failure exception.
            /// </summary>
            /// <param name="response">The raw Response.</param>
            /// <returns>The Service.GetPropertiesAsync Azure.Response{Azure.Storage.Files.Models.FileServiceProperties}.</returns>
            internal static Azure.Response<Azure.Storage.Files.Models.FileServiceProperties> GetPropertiesAsync_CreateResponse(
                Azure.Response response)
            {
                // Process the response
                switch (response.Status)
                {
                    case 200:
                    {
                        // Create the result
                        System.Xml.Linq.XDocument _xml = System.Xml.Linq.XDocument.Load(response.ContentStream, System.Xml.Linq.LoadOptions.PreserveWhitespace);
                        Azure.Storage.Files.Models.FileServiceProperties _value = Azure.Storage.Files.Models.FileServiceProperties.FromXml(_xml.Root);

                        // Create the response
                        return Response.FromValue(_value, response);
                    }
                    default:
                    {
                        // Create the result
                        System.Xml.Linq.XDocument _xml = System.Xml.Linq.XDocument.Load(response.ContentStream, System.Xml.Linq.LoadOptions.PreserveWhitespace);
                        Azure.Storage.Files.Models.StorageError _value = Azure.Storage.Files.Models.StorageError.FromXml(_xml.Root);

                        throw _value.CreateException(response);
                    }
                }
            }
            #endregion Service.GetPropertiesAsync

            #region Service.ListSharesSegmentAsync
            /// <summary>
            /// The List Shares Segment operation returns a list of the shares and share snapshots under the specified account.
            /// </summary>
            /// <param name="pipeline">The pipeline used for sending requests.</param>
            /// <param name="resourceUri">The URL of the service account, share, directory or file that is the target of the desired operation.</param>
            /// <param name="prefix">Filters the results to return only entries whose name begins with the specified prefix.</param>
            /// <param name="marker">A string value that identifies the portion of the list to be returned with the next list operation. The operation returns a marker value within the response body if the list returned was not complete. The marker value may then be used in a subsequent call to request the next set of list items. The marker value is opaque to the client.</param>
            /// <param name="maxresults">Specifies the maximum number of entries to return. If the request does not specify maxresults, or specifies a value greater than 5,000, the server will return up to 5,000 items.</param>
            /// <param name="include">Include this parameter to specify one or more datasets to include in the response.</param>
            /// <param name="timeout">The timeout parameter is expressed in seconds. For more information, see <a href="https://docs.microsoft.com/en-us/rest/api/storageservices/Setting-Timeouts-for-File-Service-Operations?redirectedfrom=MSDN">Setting Timeouts for File Service Operations.</a></param>
            /// <param name="async">Whether to invoke the operation asynchronously.  The default value is true.</param>
            /// <param name="clientDiagnostics">The ClientDiagnostics instance used for operation reporting.</param>
            /// <param name="operationName">Operation name.</param>
            /// <param name="cancellationToken">Cancellation token.</param>
            /// <returns>An enumeration of shares.</returns>
            public static async System.Threading.Tasks.ValueTask<Azure.Response<Azure.Storage.Files.Models.SharesSegment>> ListSharesSegmentAsync(
                Azure.Core.Pipeline.ClientDiagnostics clientDiagnostics,
                Azure.Core.Pipeline.HttpPipeline pipeline,
                System.Uri resourceUri,
                string prefix = default,
                string marker = default,
                int? maxresults = default,
                System.Collections.Generic.IEnumerable<Azure.Storage.Files.Models.ListSharesIncludeType> include = default,
                int? timeout = default,
                bool async = true,
                string operationName = "Azure.Storage.Files.ServiceClient.ListSharesSegment",
                System.Threading.CancellationToken cancellationToken = default)
            {
                Azure.Core.Pipeline.DiagnosticScope _scope = clientDiagnostics.CreateScope(operationName);
                try
                {
                    _scope.AddAttribute("url", resourceUri);
                    _scope.Start();
                    using (Azure.Core.HttpMessage _message = ListSharesSegmentAsync_CreateMessage(
                        pipeline,
                        resourceUri,
                        prefix,
                        marker,
                        maxresults,
                        include,
                        timeout))
                    {
                        if (async)
                        {
                            // Send the request asynchronously if we're being called via an async path
                            await pipeline.SendAsync(_message, cancellationToken).ConfigureAwait(false);
                        }
                        else
                        {
                            // Send the request synchronously through the API that blocks if we're being called via a sync path
                            // (this is safe because the Task will complete before the user can call Wait)
                            pipeline.Send(_message, cancellationToken);
                        }
                        Azure.Response _response = _message.Response;
                        cancellationToken.ThrowIfCancellationRequested();
                        return ListSharesSegmentAsync_CreateResponse(_response);
                    }
                }
                catch (System.Exception ex)
                {
                    _scope.Failed(ex);
                    throw;
                }
                finally
                {
                    _scope.Dispose();
                }
            }

            /// <summary>
            /// Create the Service.ListSharesSegmentAsync request.
            /// </summary>
            /// <param name="pipeline">The pipeline used for sending requests.</param>
            /// <param name="resourceUri">The URL of the service account, share, directory or file that is the target of the desired operation.</param>
            /// <param name="prefix">Filters the results to return only entries whose name begins with the specified prefix.</param>
            /// <param name="marker">A string value that identifies the portion of the list to be returned with the next list operation. The operation returns a marker value within the response body if the list returned was not complete. The marker value may then be used in a subsequent call to request the next set of list items. The marker value is opaque to the client.</param>
            /// <param name="maxresults">Specifies the maximum number of entries to return. If the request does not specify maxresults, or specifies a value greater than 5,000, the server will return up to 5,000 items.</param>
            /// <param name="include">Include this parameter to specify one or more datasets to include in the response.</param>
            /// <param name="timeout">The timeout parameter is expressed in seconds. For more information, see <a href="https://docs.microsoft.com/en-us/rest/api/storageservices/Setting-Timeouts-for-File-Service-Operations?redirectedfrom=MSDN">Setting Timeouts for File Service Operations.</a></param>
            /// <returns>The Service.ListSharesSegmentAsync Message.</returns>
            internal static Azure.Core.HttpMessage ListSharesSegmentAsync_CreateMessage(
                Azure.Core.Pipeline.HttpPipeline pipeline,
                System.Uri resourceUri,
                string prefix = default,
                string marker = default,
                int? maxresults = default,
                System.Collections.Generic.IEnumerable<Azure.Storage.Files.Models.ListSharesIncludeType> include = default,
                int? timeout = default)
            {
                // Validation
                if (resourceUri == null)
                {
                    throw new System.ArgumentNullException(nameof(resourceUri));
                }

                // Create the request
                Azure.Core.HttpMessage _message = pipeline.CreateMessage();
                Azure.Core.Request _request = _message.Request;

                // Set the endpoint
                _request.Method = Azure.Core.RequestMethod.Get;
                _request.Uri.Reset(resourceUri);
                _request.Uri.AppendQuery("comp", "list");
                if (prefix != null) { _request.Uri.AppendQuery("prefix", System.Uri.EscapeDataString(prefix)); }
                if (marker != null) { _request.Uri.AppendQuery("marker", System.Uri.EscapeDataString(marker)); }
                if (maxresults != null) { _request.Uri.AppendQuery("maxresults", System.Uri.EscapeDataString(maxresults.Value.ToString(System.Globalization.CultureInfo.InvariantCulture))); }
                if (include != null) { _request.Uri.AppendQuery("include", System.Uri.EscapeDataString(string.Join(",", System.Linq.Enumerable.Select(include, item => Azure.Storage.Files.FileRestClient.Serialization.ToString(item))))); }
                if (timeout != null) { _request.Uri.AppendQuery("timeout", System.Uri.EscapeDataString(timeout.Value.ToString(System.Globalization.CultureInfo.InvariantCulture))); }

                // Add request headers
                _request.Headers.SetValue("x-ms-version", "2019-02-02");

                return _message;
            }

            /// <summary>
            /// Create the Service.ListSharesSegmentAsync response or throw a failure exception.
            /// </summary>
            /// <param name="response">The raw Response.</param>
            /// <returns>The Service.ListSharesSegmentAsync Azure.Response{Azure.Storage.Files.Models.SharesSegment}.</returns>
            internal static Azure.Response<Azure.Storage.Files.Models.SharesSegment> ListSharesSegmentAsync_CreateResponse(
                Azure.Response response)
            {
                // Process the response
                switch (response.Status)
                {
                    case 200:
                    {
                        // Create the result
                        System.Xml.Linq.XDocument _xml = System.Xml.Linq.XDocument.Load(response.ContentStream, System.Xml.Linq.LoadOptions.PreserveWhitespace);
                        Azure.Storage.Files.Models.SharesSegment _value = Azure.Storage.Files.Models.SharesSegment.FromXml(_xml.Root);

                        // Create the response
                        return Response.FromValue(_value, response);
                    }
                    default:
                    {
                        // Create the result
                        System.Xml.Linq.XDocument _xml = System.Xml.Linq.XDocument.Load(response.ContentStream, System.Xml.Linq.LoadOptions.PreserveWhitespace);
                        Azure.Storage.Files.Models.StorageError _value = Azure.Storage.Files.Models.StorageError.FromXml(_xml.Root);

                        throw _value.CreateException(response);
                    }
                }
            }
            #endregion Service.ListSharesSegmentAsync
        }
        #endregion Service operations

        #region Share operations
        /// <summary>
        /// Share operations for Azure File Storage
        /// </summary>
        public static partial class Share
        {
            #region Share.CreateAsync
            /// <summary>
            /// Creates a new share under the specified account. If the share with the same name already exists, the operation fails.
            /// </summary>
            /// <param name="pipeline">The pipeline used for sending requests.</param>
            /// <param name="resourceUri">The URL of the service account, share, directory or file that is the target of the desired operation.</param>
            /// <param name="timeout">The timeout parameter is expressed in seconds. For more information, see <a href="https://docs.microsoft.com/en-us/rest/api/storageservices/Setting-Timeouts-for-File-Service-Operations?redirectedfrom=MSDN">Setting Timeouts for File Service Operations.</a></param>
            /// <param name="metadata">A name-value pair to associate with a file storage object.</param>
            /// <param name="quota">Specifies the maximum size of the share, in gigabytes.</param>
            /// <param name="async">Whether to invoke the operation asynchronously.  The default value is true.</param>
            /// <param name="clientDiagnostics">The ClientDiagnostics instance used for operation reporting.</param>
            /// <param name="operationName">Operation name.</param>
            /// <param name="cancellationToken">Cancellation token.</param>
            /// <returns>Azure.Response{Azure.Storage.Files.Models.ShareInfo}</returns>
            public static async System.Threading.Tasks.ValueTask<Azure.Response<Azure.Storage.Files.Models.ShareInfo>> CreateAsync(
                Azure.Core.Pipeline.ClientDiagnostics clientDiagnostics,
                Azure.Core.Pipeline.HttpPipeline pipeline,
                System.Uri resourceUri,
                int? timeout = default,
                System.Collections.Generic.IDictionary<string, string> metadata = default,
                int? quota = default,
                bool async = true,
                string operationName = "Azure.Storage.Files.ShareClient.Create",
                System.Threading.CancellationToken cancellationToken = default)
            {
                Azure.Core.Pipeline.DiagnosticScope _scope = clientDiagnostics.CreateScope(operationName);
                try
                {
                    _scope.AddAttribute("url", resourceUri);
                    _scope.Start();
                    using (Azure.Core.HttpMessage _message = CreateAsync_CreateMessage(
                        pipeline,
                        resourceUri,
                        timeout,
                        metadata,
                        quota))
                    {
                        if (async)
                        {
                            // Send the request asynchronously if we're being called via an async path
                            await pipeline.SendAsync(_message, cancellationToken).ConfigureAwait(false);
                        }
                        else
                        {
                            // Send the request synchronously through the API that blocks if we're being called via a sync path
                            // (this is safe because the Task will complete before the user can call Wait)
                            pipeline.Send(_message, cancellationToken);
                        }
                        Azure.Response _response = _message.Response;
                        cancellationToken.ThrowIfCancellationRequested();
                        return CreateAsync_CreateResponse(_response);
                    }
                }
                catch (System.Exception ex)
                {
                    _scope.Failed(ex);
                    throw;
                }
                finally
                {
                    _scope.Dispose();
                }
            }

            /// <summary>
            /// Create the Share.CreateAsync request.
            /// </summary>
            /// <param name="pipeline">The pipeline used for sending requests.</param>
            /// <param name="resourceUri">The URL of the service account, share, directory or file that is the target of the desired operation.</param>
            /// <param name="timeout">The timeout parameter is expressed in seconds. For more information, see <a href="https://docs.microsoft.com/en-us/rest/api/storageservices/Setting-Timeouts-for-File-Service-Operations?redirectedfrom=MSDN">Setting Timeouts for File Service Operations.</a></param>
            /// <param name="metadata">A name-value pair to associate with a file storage object.</param>
            /// <param name="quota">Specifies the maximum size of the share, in gigabytes.</param>
            /// <returns>The Share.CreateAsync Message.</returns>
            internal static Azure.Core.HttpMessage CreateAsync_CreateMessage(
                Azure.Core.Pipeline.HttpPipeline pipeline,
                System.Uri resourceUri,
                int? timeout = default,
                System.Collections.Generic.IDictionary<string, string> metadata = default,
                int? quota = default)
            {
                // Validation
                if (resourceUri == null)
                {
                    throw new System.ArgumentNullException(nameof(resourceUri));
                }

                // Create the request
                Azure.Core.HttpMessage _message = pipeline.CreateMessage();
                Azure.Core.Request _request = _message.Request;

                // Set the endpoint
                _request.Method = Azure.Core.RequestMethod.Put;
                _request.Uri.Reset(resourceUri);
                _request.Uri.AppendQuery("restype", "share");
                if (timeout != null) { _request.Uri.AppendQuery("timeout", System.Uri.EscapeDataString(timeout.Value.ToString(System.Globalization.CultureInfo.InvariantCulture))); }

                // Add request headers
                _request.Headers.SetValue("x-ms-version", "2019-02-02");
                if (metadata != null) {
                    foreach (System.Collections.Generic.KeyValuePair<string, string> _pair in metadata)
                    {
                        _request.Headers.SetValue("x-ms-meta-" + _pair.Key, _pair.Value);
                    }
                }
                if (quota != null) { _request.Headers.SetValue("x-ms-share-quota", quota.Value.ToString(System.Globalization.CultureInfo.InvariantCulture)); }

                return _message;
            }

            /// <summary>
            /// Create the Share.CreateAsync response or throw a failure exception.
            /// </summary>
            /// <param name="response">The raw Response.</param>
            /// <returns>The Share.CreateAsync Azure.Response{Azure.Storage.Files.Models.ShareInfo}.</returns>
            internal static Azure.Response<Azure.Storage.Files.Models.ShareInfo> CreateAsync_CreateResponse(
                Azure.Response response)
            {
                // Process the response
                switch (response.Status)
                {
                    case 201:
                    {
                        // Create the result
                        Azure.Storage.Files.Models.ShareInfo _value = new Azure.Storage.Files.Models.ShareInfo();

                        // Get response headers
                        string _header;
                        if (response.Headers.TryGetValue("ETag", out _header))
                        {
                            _value.ETag = new Azure.ETag(_header);
                        }
                        if (response.Headers.TryGetValue("Last-Modified", out _header))
                        {
                            _value.LastModified = System.DateTimeOffset.Parse(_header, System.Globalization.CultureInfo.InvariantCulture);
                        }

                        // Create the response
                        return Response.FromValue(_value, response);
                    }
                    default:
                    {
                        // Create the result
                        System.Xml.Linq.XDocument _xml = System.Xml.Linq.XDocument.Load(response.ContentStream, System.Xml.Linq.LoadOptions.PreserveWhitespace);
                        Azure.Storage.Files.Models.StorageError _value = Azure.Storage.Files.Models.StorageError.FromXml(_xml.Root);

                        throw _value.CreateException(response);
                    }
                }
            }
            #endregion Share.CreateAsync

            #region Share.GetPropertiesAsync
            /// <summary>
            /// Returns all user-defined metadata and system properties for the specified share or share snapshot. The data returned does not include the share's list of files.
            /// </summary>
            /// <param name="pipeline">The pipeline used for sending requests.</param>
            /// <param name="resourceUri">The URL of the service account, share, directory or file that is the target of the desired operation.</param>
            /// <param name="sharesnapshot">The snapshot parameter is an opaque DateTime value that, when present, specifies the share snapshot to query.</param>
            /// <param name="timeout">The timeout parameter is expressed in seconds. For more information, see <a href="https://docs.microsoft.com/en-us/rest/api/storageservices/Setting-Timeouts-for-File-Service-Operations?redirectedfrom=MSDN">Setting Timeouts for File Service Operations.</a></param>
            /// <param name="async">Whether to invoke the operation asynchronously.  The default value is true.</param>
            /// <param name="clientDiagnostics">The ClientDiagnostics instance used for operation reporting.</param>
            /// <param name="operationName">Operation name.</param>
            /// <param name="cancellationToken">Cancellation token.</param>
            /// <returns>Azure.Response{Azure.Storage.Files.Models.ShareProperties}</returns>
            public static async System.Threading.Tasks.ValueTask<Azure.Response<Azure.Storage.Files.Models.ShareProperties>> GetPropertiesAsync(
                Azure.Core.Pipeline.ClientDiagnostics clientDiagnostics,
                Azure.Core.Pipeline.HttpPipeline pipeline,
                System.Uri resourceUri,
                string sharesnapshot = default,
                int? timeout = default,
                bool async = true,
                string operationName = "Azure.Storage.Files.ShareClient.GetProperties",
                System.Threading.CancellationToken cancellationToken = default)
            {
                Azure.Core.Pipeline.DiagnosticScope _scope = clientDiagnostics.CreateScope(operationName);
                try
                {
                    _scope.AddAttribute("url", resourceUri);
                    _scope.Start();
                    using (Azure.Core.HttpMessage _message = GetPropertiesAsync_CreateMessage(
                        pipeline,
                        resourceUri,
                        sharesnapshot,
                        timeout))
                    {
                        if (async)
                        {
                            // Send the request asynchronously if we're being called via an async path
                            await pipeline.SendAsync(_message, cancellationToken).ConfigureAwait(false);
                        }
                        else
                        {
                            // Send the request synchronously through the API that blocks if we're being called via a sync path
                            // (this is safe because the Task will complete before the user can call Wait)
                            pipeline.Send(_message, cancellationToken);
                        }
                        Azure.Response _response = _message.Response;
                        cancellationToken.ThrowIfCancellationRequested();
                        return GetPropertiesAsync_CreateResponse(_response);
                    }
                }
                catch (System.Exception ex)
                {
                    _scope.Failed(ex);
                    throw;
                }
                finally
                {
                    _scope.Dispose();
                }
            }

            /// <summary>
            /// Create the Share.GetPropertiesAsync request.
            /// </summary>
            /// <param name="pipeline">The pipeline used for sending requests.</param>
            /// <param name="resourceUri">The URL of the service account, share, directory or file that is the target of the desired operation.</param>
            /// <param name="sharesnapshot">The snapshot parameter is an opaque DateTime value that, when present, specifies the share snapshot to query.</param>
            /// <param name="timeout">The timeout parameter is expressed in seconds. For more information, see <a href="https://docs.microsoft.com/en-us/rest/api/storageservices/Setting-Timeouts-for-File-Service-Operations?redirectedfrom=MSDN">Setting Timeouts for File Service Operations.</a></param>
            /// <returns>The Share.GetPropertiesAsync Message.</returns>
            internal static Azure.Core.HttpMessage GetPropertiesAsync_CreateMessage(
                Azure.Core.Pipeline.HttpPipeline pipeline,
                System.Uri resourceUri,
                string sharesnapshot = default,
                int? timeout = default)
            {
                // Validation
                if (resourceUri == null)
                {
                    throw new System.ArgumentNullException(nameof(resourceUri));
                }

                // Create the request
                Azure.Core.HttpMessage _message = pipeline.CreateMessage();
                Azure.Core.Request _request = _message.Request;

                // Set the endpoint
                _request.Method = Azure.Core.RequestMethod.Get;
                _request.Uri.Reset(resourceUri);
                _request.Uri.AppendQuery("restype", "share");
                if (sharesnapshot != null) { _request.Uri.AppendQuery("sharesnapshot", System.Uri.EscapeDataString(sharesnapshot)); }
                if (timeout != null) { _request.Uri.AppendQuery("timeout", System.Uri.EscapeDataString(timeout.Value.ToString(System.Globalization.CultureInfo.InvariantCulture))); }

                // Add request headers
                _request.Headers.SetValue("x-ms-version", "2019-02-02");

                return _message;
            }

            /// <summary>
            /// Create the Share.GetPropertiesAsync response or throw a failure exception.
            /// </summary>
            /// <param name="response">The raw Response.</param>
            /// <returns>The Share.GetPropertiesAsync Azure.Response{Azure.Storage.Files.Models.ShareProperties}.</returns>
            internal static Azure.Response<Azure.Storage.Files.Models.ShareProperties> GetPropertiesAsync_CreateResponse(
                Azure.Response response)
            {
                // Process the response
                switch (response.Status)
                {
                    case 200:
                    {
                        // Create the result
                        Azure.Storage.Files.Models.ShareProperties _value = new Azure.Storage.Files.Models.ShareProperties();

                        // Get response headers
                        string _header;
                        _value.Metadata = new System.Collections.Generic.Dictionary<string, string>(System.StringComparer.OrdinalIgnoreCase);
                        foreach (Azure.Core.HttpHeader _headerPair in response.Headers)
                        {
                            if (_headerPair.Name.StartsWith("x-ms-meta-", System.StringComparison.InvariantCulture))
                            {
                                _value.Metadata[_headerPair.Name.Substring(10)] = _headerPair.Value;
                            }
                        }
                        if (response.Headers.TryGetValue("ETag", out _header))
                        {
                            _value.ETag = new Azure.ETag(_header);
                        }
                        if (response.Headers.TryGetValue("Last-Modified", out _header))
                        {
                            _value.LastModified = System.DateTimeOffset.Parse(_header, System.Globalization.CultureInfo.InvariantCulture);
                        }
                        if (response.Headers.TryGetValue("x-ms-share-quota", out _header))
                        {
                            _value.Quota = int.Parse(_header, System.Globalization.CultureInfo.InvariantCulture);
                        }

                        // Create the response
                        return Response.FromValue(_value, response);
                    }
                    default:
                    {
                        // Create the result
                        System.Xml.Linq.XDocument _xml = System.Xml.Linq.XDocument.Load(response.ContentStream, System.Xml.Linq.LoadOptions.PreserveWhitespace);
                        Azure.Storage.Files.Models.StorageError _value = Azure.Storage.Files.Models.StorageError.FromXml(_xml.Root);

                        throw _value.CreateException(response);
                    }
                }
            }
            #endregion Share.GetPropertiesAsync

            #region Share.DeleteAsync
            /// <summary>
            /// Operation marks the specified share or share snapshot for deletion. The share or share snapshot and any files contained within it are later deleted during garbage collection.
            /// </summary>
            /// <param name="pipeline">The pipeline used for sending requests.</param>
            /// <param name="resourceUri">The URL of the service account, share, directory or file that is the target of the desired operation.</param>
            /// <param name="sharesnapshot">The snapshot parameter is an opaque DateTime value that, when present, specifies the share snapshot to query.</param>
            /// <param name="timeout">The timeout parameter is expressed in seconds. For more information, see <a href="https://docs.microsoft.com/en-us/rest/api/storageservices/Setting-Timeouts-for-File-Service-Operations?redirectedfrom=MSDN">Setting Timeouts for File Service Operations.</a></param>
            /// <param name="deleteSnapshots">Specifies the option include to delete the base share and all of its snapshots.</param>
            /// <param name="async">Whether to invoke the operation asynchronously.  The default value is true.</param>
            /// <param name="clientDiagnostics">The ClientDiagnostics instance used for operation reporting.</param>
            /// <param name="operationName">Operation name.</param>
            /// <param name="cancellationToken">Cancellation token.</param>
            /// <returns>Azure.Response</returns>
            public static async System.Threading.Tasks.ValueTask<Azure.Response> DeleteAsync(
                Azure.Core.Pipeline.ClientDiagnostics clientDiagnostics,
                Azure.Core.Pipeline.HttpPipeline pipeline,
                System.Uri resourceUri,
                string sharesnapshot = default,
                int? timeout = default,
                Azure.Storage.Files.Models.DeleteSnapshotsOptionType? deleteSnapshots = default,
                bool async = true,
                string operationName = "Azure.Storage.Files.ShareClient.Delete",
                System.Threading.CancellationToken cancellationToken = default)
            {
                Azure.Core.Pipeline.DiagnosticScope _scope = clientDiagnostics.CreateScope(operationName);
                try
                {
                    _scope.AddAttribute("url", resourceUri);
                    _scope.Start();
                    using (Azure.Core.HttpMessage _message = DeleteAsync_CreateMessage(
                        pipeline,
                        resourceUri,
                        sharesnapshot,
                        timeout,
                        deleteSnapshots))
                    {
                        if (async)
                        {
                            // Send the request asynchronously if we're being called via an async path
                            await pipeline.SendAsync(_message, cancellationToken).ConfigureAwait(false);
                        }
                        else
                        {
                            // Send the request synchronously through the API that blocks if we're being called via a sync path
                            // (this is safe because the Task will complete before the user can call Wait)
                            pipeline.Send(_message, cancellationToken);
                        }
                        Azure.Response _response = _message.Response;
                        cancellationToken.ThrowIfCancellationRequested();
                        return DeleteAsync_CreateResponse(_response);
                    }
                }
                catch (System.Exception ex)
                {
                    _scope.Failed(ex);
                    throw;
                }
                finally
                {
                    _scope.Dispose();
                }
            }

            /// <summary>
            /// Create the Share.DeleteAsync request.
            /// </summary>
            /// <param name="pipeline">The pipeline used for sending requests.</param>
            /// <param name="resourceUri">The URL of the service account, share, directory or file that is the target of the desired operation.</param>
            /// <param name="sharesnapshot">The snapshot parameter is an opaque DateTime value that, when present, specifies the share snapshot to query.</param>
            /// <param name="timeout">The timeout parameter is expressed in seconds. For more information, see <a href="https://docs.microsoft.com/en-us/rest/api/storageservices/Setting-Timeouts-for-File-Service-Operations?redirectedfrom=MSDN">Setting Timeouts for File Service Operations.</a></param>
            /// <param name="deleteSnapshots">Specifies the option include to delete the base share and all of its snapshots.</param>
            /// <returns>The Share.DeleteAsync Message.</returns>
            internal static Azure.Core.HttpMessage DeleteAsync_CreateMessage(
                Azure.Core.Pipeline.HttpPipeline pipeline,
                System.Uri resourceUri,
                string sharesnapshot = default,
                int? timeout = default,
                Azure.Storage.Files.Models.DeleteSnapshotsOptionType? deleteSnapshots = default)
            {
                // Validation
                if (resourceUri == null)
                {
                    throw new System.ArgumentNullException(nameof(resourceUri));
                }

                // Create the request
                Azure.Core.HttpMessage _message = pipeline.CreateMessage();
                Azure.Core.Request _request = _message.Request;

                // Set the endpoint
                _request.Method = Azure.Core.RequestMethod.Delete;
                _request.Uri.Reset(resourceUri);
                _request.Uri.AppendQuery("restype", "share");
                if (sharesnapshot != null) { _request.Uri.AppendQuery("sharesnapshot", System.Uri.EscapeDataString(sharesnapshot)); }
                if (timeout != null) { _request.Uri.AppendQuery("timeout", System.Uri.EscapeDataString(timeout.Value.ToString(System.Globalization.CultureInfo.InvariantCulture))); }

                // Add request headers
                _request.Headers.SetValue("x-ms-version", "2019-02-02");
                if (deleteSnapshots != null) { _request.Headers.SetValue("x-ms-delete-snapshots", Azure.Storage.Files.FileRestClient.Serialization.ToString(deleteSnapshots.Value)); }

                return _message;
            }

            /// <summary>
            /// Create the Share.DeleteAsync response or throw a failure exception.
            /// </summary>
            /// <param name="response">The raw Response.</param>
            /// <returns>The Share.DeleteAsync Azure.Response.</returns>
            internal static Azure.Response DeleteAsync_CreateResponse(
                Azure.Response response)
            {
                // Process the response
                switch (response.Status)
                {
                    case 202:
                    {
                        return response;
                    }
                    default:
                    {
                        // Create the result
                        System.Xml.Linq.XDocument _xml = System.Xml.Linq.XDocument.Load(response.ContentStream, System.Xml.Linq.LoadOptions.PreserveWhitespace);
                        Azure.Storage.Files.Models.StorageError _value = Azure.Storage.Files.Models.StorageError.FromXml(_xml.Root);

                        throw _value.CreateException(response);
                    }
                }
            }
            #endregion Share.DeleteAsync

            #region Share.CreateSnapshotAsync
            /// <summary>
            /// Creates a read-only snapshot of a share.
            /// </summary>
            /// <param name="pipeline">The pipeline used for sending requests.</param>
            /// <param name="resourceUri">The URL of the service account, share, directory or file that is the target of the desired operation.</param>
            /// <param name="timeout">The timeout parameter is expressed in seconds. For more information, see <a href="https://docs.microsoft.com/en-us/rest/api/storageservices/Setting-Timeouts-for-File-Service-Operations?redirectedfrom=MSDN">Setting Timeouts for File Service Operations.</a></param>
            /// <param name="metadata">A name-value pair to associate with a file storage object.</param>
            /// <param name="async">Whether to invoke the operation asynchronously.  The default value is true.</param>
            /// <param name="clientDiagnostics">The ClientDiagnostics instance used for operation reporting.</param>
            /// <param name="operationName">Operation name.</param>
            /// <param name="cancellationToken">Cancellation token.</param>
            /// <returns>Azure.Response{Azure.Storage.Files.Models.ShareSnapshotInfo}</returns>
            public static async System.Threading.Tasks.ValueTask<Azure.Response<Azure.Storage.Files.Models.ShareSnapshotInfo>> CreateSnapshotAsync(
                Azure.Core.Pipeline.ClientDiagnostics clientDiagnostics,
                Azure.Core.Pipeline.HttpPipeline pipeline,
                System.Uri resourceUri,
                int? timeout = default,
                System.Collections.Generic.IDictionary<string, string> metadata = default,
                bool async = true,
                string operationName = "Azure.Storage.Files.ShareClient.CreateSnapshot",
                System.Threading.CancellationToken cancellationToken = default)
            {
                Azure.Core.Pipeline.DiagnosticScope _scope = clientDiagnostics.CreateScope(operationName);
                try
                {
                    _scope.AddAttribute("url", resourceUri);
                    _scope.Start();
                    using (Azure.Core.HttpMessage _message = CreateSnapshotAsync_CreateMessage(
                        pipeline,
                        resourceUri,
                        timeout,
                        metadata))
                    {
                        if (async)
                        {
                            // Send the request asynchronously if we're being called via an async path
                            await pipeline.SendAsync(_message, cancellationToken).ConfigureAwait(false);
                        }
                        else
                        {
                            // Send the request synchronously through the API that blocks if we're being called via a sync path
                            // (this is safe because the Task will complete before the user can call Wait)
                            pipeline.Send(_message, cancellationToken);
                        }
                        Azure.Response _response = _message.Response;
                        cancellationToken.ThrowIfCancellationRequested();
                        return CreateSnapshotAsync_CreateResponse(_response);
                    }
                }
                catch (System.Exception ex)
                {
                    _scope.Failed(ex);
                    throw;
                }
                finally
                {
                    _scope.Dispose();
                }
            }

            /// <summary>
            /// Create the Share.CreateSnapshotAsync request.
            /// </summary>
            /// <param name="pipeline">The pipeline used for sending requests.</param>
            /// <param name="resourceUri">The URL of the service account, share, directory or file that is the target of the desired operation.</param>
            /// <param name="timeout">The timeout parameter is expressed in seconds. For more information, see <a href="https://docs.microsoft.com/en-us/rest/api/storageservices/Setting-Timeouts-for-File-Service-Operations?redirectedfrom=MSDN">Setting Timeouts for File Service Operations.</a></param>
            /// <param name="metadata">A name-value pair to associate with a file storage object.</param>
            /// <returns>The Share.CreateSnapshotAsync Message.</returns>
            internal static Azure.Core.HttpMessage CreateSnapshotAsync_CreateMessage(
                Azure.Core.Pipeline.HttpPipeline pipeline,
                System.Uri resourceUri,
                int? timeout = default,
                System.Collections.Generic.IDictionary<string, string> metadata = default)
            {
                // Validation
                if (resourceUri == null)
                {
                    throw new System.ArgumentNullException(nameof(resourceUri));
                }

                // Create the request
                Azure.Core.HttpMessage _message = pipeline.CreateMessage();
                Azure.Core.Request _request = _message.Request;

                // Set the endpoint
                _request.Method = Azure.Core.RequestMethod.Put;
                _request.Uri.Reset(resourceUri);
                _request.Uri.AppendQuery("restype", "share");
                _request.Uri.AppendQuery("comp", "snapshot");
                if (timeout != null) { _request.Uri.AppendQuery("timeout", System.Uri.EscapeDataString(timeout.Value.ToString(System.Globalization.CultureInfo.InvariantCulture))); }

                // Add request headers
                _request.Headers.SetValue("x-ms-version", "2019-02-02");
                if (metadata != null) {
                    foreach (System.Collections.Generic.KeyValuePair<string, string> _pair in metadata)
                    {
                        _request.Headers.SetValue("x-ms-meta-" + _pair.Key, _pair.Value);
                    }
                }

                return _message;
            }

            /// <summary>
            /// Create the Share.CreateSnapshotAsync response or throw a failure exception.
            /// </summary>
            /// <param name="response">The raw Response.</param>
            /// <returns>The Share.CreateSnapshotAsync Azure.Response{Azure.Storage.Files.Models.ShareSnapshotInfo}.</returns>
            internal static Azure.Response<Azure.Storage.Files.Models.ShareSnapshotInfo> CreateSnapshotAsync_CreateResponse(
                Azure.Response response)
            {
                // Process the response
                switch (response.Status)
                {
                    case 201:
                    {
                        // Create the result
                        Azure.Storage.Files.Models.ShareSnapshotInfo _value = new Azure.Storage.Files.Models.ShareSnapshotInfo();

                        // Get response headers
                        string _header;
                        if (response.Headers.TryGetValue("x-ms-snapshot", out _header))
                        {
                            _value.Snapshot = _header;
                        }
                        if (response.Headers.TryGetValue("ETag", out _header))
                        {
                            _value.ETag = new Azure.ETag(_header);
                        }
                        if (response.Headers.TryGetValue("Last-Modified", out _header))
                        {
                            _value.LastModified = System.DateTimeOffset.Parse(_header, System.Globalization.CultureInfo.InvariantCulture);
                        }

                        // Create the response
                        return Response.FromValue(_value, response);
                    }
                    default:
                    {
                        // Create the result
                        System.Xml.Linq.XDocument _xml = System.Xml.Linq.XDocument.Load(response.ContentStream, System.Xml.Linq.LoadOptions.PreserveWhitespace);
                        Azure.Storage.Files.Models.StorageError _value = Azure.Storage.Files.Models.StorageError.FromXml(_xml.Root);

                        throw _value.CreateException(response);
                    }
                }
            }
            #endregion Share.CreateSnapshotAsync

            #region Share.CreatePermissionAsync
            /// <summary>
            /// Create a permission (a security descriptor).
            /// </summary>
            /// <param name="pipeline">The pipeline used for sending requests.</param>
            /// <param name="resourceUri">The URL of the service account, share, directory or file that is the target of the desired operation.</param>
            /// <param name="sharePermissionJson">A permission (a security descriptor) at the share level.</param>
            /// <param name="timeout">The timeout parameter is expressed in seconds. For more information, see <a href="https://docs.microsoft.com/en-us/rest/api/storageservices/Setting-Timeouts-for-File-Service-Operations?redirectedfrom=MSDN">Setting Timeouts for File Service Operations.</a></param>
            /// <param name="async">Whether to invoke the operation asynchronously.  The default value is true.</param>
            /// <param name="clientDiagnostics">The ClientDiagnostics instance used for operation reporting.</param>
            /// <param name="operationName">Operation name.</param>
            /// <param name="cancellationToken">Cancellation token.</param>
            /// <returns>Azure.Response{Azure.Storage.Files.Models.PermissionInfo}</returns>
            public static async System.Threading.Tasks.ValueTask<Azure.Response<Azure.Storage.Files.Models.PermissionInfo>> CreatePermissionAsync(
                Azure.Core.Pipeline.ClientDiagnostics clientDiagnostics,
                Azure.Core.Pipeline.HttpPipeline pipeline,
                System.Uri resourceUri,
                string sharePermissionJson,
                int? timeout = default,
                bool async = true,
                string operationName = "Azure.Storage.Files.ShareClient.CreatePermission",
                System.Threading.CancellationToken cancellationToken = default)
            {
                Azure.Core.Pipeline.DiagnosticScope _scope = clientDiagnostics.CreateScope(operationName);
                try
                {
                    _scope.AddAttribute("url", resourceUri);
                    _scope.Start();
                    using (Azure.Core.HttpMessage _message = CreatePermissionAsync_CreateMessage(
                        pipeline,
                        resourceUri,
                        sharePermissionJson,
                        timeout))
                    {
                        if (async)
                        {
                            // Send the request asynchronously if we're being called via an async path
                            await pipeline.SendAsync(_message, cancellationToken).ConfigureAwait(false);
                        }
                        else
                        {
                            // Send the request synchronously through the API that blocks if we're being called via a sync path
                            // (this is safe because the Task will complete before the user can call Wait)
                            pipeline.Send(_message, cancellationToken);
                        }
                        Azure.Response _response = _message.Response;
                        cancellationToken.ThrowIfCancellationRequested();
                        return CreatePermissionAsync_CreateResponse(_response);
                    }
                }
                catch (System.Exception ex)
                {
                    _scope.Failed(ex);
                    throw;
                }
                finally
                {
                    _scope.Dispose();
                }
            }

            /// <summary>
            /// Create the Share.CreatePermissionAsync request.
            /// </summary>
            /// <param name="pipeline">The pipeline used for sending requests.</param>
            /// <param name="resourceUri">The URL of the service account, share, directory or file that is the target of the desired operation.</param>
            /// <param name="sharePermissionJson">A permission (a security descriptor) at the share level.</param>
            /// <param name="timeout">The timeout parameter is expressed in seconds. For more information, see <a href="https://docs.microsoft.com/en-us/rest/api/storageservices/Setting-Timeouts-for-File-Service-Operations?redirectedfrom=MSDN">Setting Timeouts for File Service Operations.</a></param>
            /// <returns>The Share.CreatePermissionAsync Message.</returns>
            internal static Azure.Core.HttpMessage CreatePermissionAsync_CreateMessage(
                Azure.Core.Pipeline.HttpPipeline pipeline,
                System.Uri resourceUri,
                string sharePermissionJson,
                int? timeout = default)
            {
                // Validation
                if (resourceUri == null)
                {
                    throw new System.ArgumentNullException(nameof(resourceUri));
                }
                if (sharePermissionJson == null)
                {
                    throw new System.ArgumentNullException(nameof(sharePermissionJson));
                }

                // Create the request
                Azure.Core.HttpMessage _message = pipeline.CreateMessage();
                Azure.Core.Request _request = _message.Request;

                // Set the endpoint
                _request.Method = Azure.Core.RequestMethod.Put;
                _request.Uri.Reset(resourceUri);
                _request.Uri.AppendQuery("restype", "share");
                _request.Uri.AppendQuery("comp", "filepermission");
                if (timeout != null) { _request.Uri.AppendQuery("timeout", System.Uri.EscapeDataString(timeout.Value.ToString(System.Globalization.CultureInfo.InvariantCulture))); }

                // Add request headers
                _request.Headers.SetValue("x-ms-version", "2019-02-02");

                // Create the body
                string _text = sharePermissionJson;
                _request.Headers.SetValue("Content-Type", "application/json");
                _request.Headers.SetValue("Content-Length", _text.Length.ToString(System.Globalization.CultureInfo.InvariantCulture));
                _request.Content = Azure.Core.RequestContent.Create(System.Text.Encoding.UTF8.GetBytes(_text));

                return _message;
            }

            /// <summary>
            /// Create the Share.CreatePermissionAsync response or throw a failure exception.
            /// </summary>
            /// <param name="response">The raw Response.</param>
            /// <returns>The Share.CreatePermissionAsync Azure.Response{Azure.Storage.Files.Models.PermissionInfo}.</returns>
            internal static Azure.Response<Azure.Storage.Files.Models.PermissionInfo> CreatePermissionAsync_CreateResponse(
                Azure.Response response)
            {
                // Process the response
                switch (response.Status)
                {
                    case 201:
                    {
                        // Create the result
                        Azure.Storage.Files.Models.PermissionInfo _value = new Azure.Storage.Files.Models.PermissionInfo();

                        // Get response headers
                        string _header;
                        if (response.Headers.TryGetValue("x-ms-file-permission-key", out _header))
                        {
                            _value.FilePermissionKey = _header;
                        }

                        // Create the response
                        return Response.FromValue(_value, response);
                    }
                    default:
                    {
                        // Create the result
                        System.Xml.Linq.XDocument _xml = System.Xml.Linq.XDocument.Load(response.ContentStream, System.Xml.Linq.LoadOptions.PreserveWhitespace);
                        Azure.Storage.Files.Models.StorageError _value = Azure.Storage.Files.Models.StorageError.FromXml(_xml.Root);

                        throw _value.CreateException(response);
                    }
                }
            }
            #endregion Share.CreatePermissionAsync

            #region Share.GetPermissionAsync
            /// <summary>
            /// Returns the permission (security descriptor) for a given key
            /// </summary>
            /// <param name="pipeline">The pipeline used for sending requests.</param>
            /// <param name="resourceUri">The URL of the service account, share, directory or file that is the target of the desired operation.</param>
            /// <param name="filePermissionKey">Key of the permission to be set for the directory/file.</param>
            /// <param name="timeout">The timeout parameter is expressed in seconds. For more information, see <a href="https://docs.microsoft.com/en-us/rest/api/storageservices/Setting-Timeouts-for-File-Service-Operations?redirectedfrom=MSDN">Setting Timeouts for File Service Operations.</a></param>
            /// <param name="async">Whether to invoke the operation asynchronously.  The default value is true.</param>
            /// <param name="clientDiagnostics">The ClientDiagnostics instance used for operation reporting.</param>
            /// <param name="operationName">Operation name.</param>
            /// <param name="cancellationToken">Cancellation token.</param>
            /// <returns>A permission (a security descriptor) at the share level.</returns>
            public static async System.Threading.Tasks.ValueTask<Azure.Response<string>> GetPermissionAsync(
                Azure.Core.Pipeline.ClientDiagnostics clientDiagnostics,
                Azure.Core.Pipeline.HttpPipeline pipeline,
                System.Uri resourceUri,
                string filePermissionKey,
                int? timeout = default,
                bool async = true,
                string operationName = "Azure.Storage.Files.ShareClient.GetPermission",
                System.Threading.CancellationToken cancellationToken = default)
            {
                Azure.Core.Pipeline.DiagnosticScope _scope = clientDiagnostics.CreateScope(operationName);
                try
                {
                    _scope.AddAttribute("url", resourceUri);
                    _scope.Start();
                    using (Azure.Core.HttpMessage _message = GetPermissionAsync_CreateMessage(
                        pipeline,
                        resourceUri,
                        filePermissionKey,
                        timeout))
                    {
                        if (async)
                        {
                            // Send the request asynchronously if we're being called via an async path
                            await pipeline.SendAsync(_message, cancellationToken).ConfigureAwait(false);
                        }
                        else
                        {
                            // Send the request synchronously through the API that blocks if we're being called via a sync path
                            // (this is safe because the Task will complete before the user can call Wait)
                            pipeline.Send(_message, cancellationToken);
                        }
                        Azure.Response _response = _message.Response;
                        cancellationToken.ThrowIfCancellationRequested();
                        return GetPermissionAsync_CreateResponse(_response);
                    }
                }
                catch (System.Exception ex)
                {
                    _scope.Failed(ex);
                    throw;
                }
                finally
                {
                    _scope.Dispose();
                }
            }

            /// <summary>
            /// Create the Share.GetPermissionAsync request.
            /// </summary>
            /// <param name="pipeline">The pipeline used for sending requests.</param>
            /// <param name="resourceUri">The URL of the service account, share, directory or file that is the target of the desired operation.</param>
            /// <param name="filePermissionKey">Key of the permission to be set for the directory/file.</param>
            /// <param name="timeout">The timeout parameter is expressed in seconds. For more information, see <a href="https://docs.microsoft.com/en-us/rest/api/storageservices/Setting-Timeouts-for-File-Service-Operations?redirectedfrom=MSDN">Setting Timeouts for File Service Operations.</a></param>
            /// <returns>The Share.GetPermissionAsync Message.</returns>
            internal static Azure.Core.HttpMessage GetPermissionAsync_CreateMessage(
                Azure.Core.Pipeline.HttpPipeline pipeline,
                System.Uri resourceUri,
                string filePermissionKey,
                int? timeout = default)
            {
                // Validation
                if (resourceUri == null)
                {
                    throw new System.ArgumentNullException(nameof(resourceUri));
                }
                if (filePermissionKey == null)
                {
                    throw new System.ArgumentNullException(nameof(filePermissionKey));
                }

                // Create the request
                Azure.Core.HttpMessage _message = pipeline.CreateMessage();
                Azure.Core.Request _request = _message.Request;

                // Set the endpoint
                _request.Method = Azure.Core.RequestMethod.Get;
                _request.Uri.Reset(resourceUri);
                _request.Uri.AppendQuery("restype", "share");
                _request.Uri.AppendQuery("comp", "filepermission");
                if (timeout != null) { _request.Uri.AppendQuery("timeout", System.Uri.EscapeDataString(timeout.Value.ToString(System.Globalization.CultureInfo.InvariantCulture))); }

                // Add request headers
                _request.Headers.SetValue("x-ms-file-permission-key", filePermissionKey);
                _request.Headers.SetValue("x-ms-version", "2019-02-02");

                return _message;
            }

            /// <summary>
            /// Create the Share.GetPermissionAsync response or throw a failure exception.
            /// </summary>
            /// <param name="response">The raw Response.</param>
            /// <returns>The Share.GetPermissionAsync Azure.Response{string}.</returns>
            internal static Azure.Response<string> GetPermissionAsync_CreateResponse(
                Azure.Response response)
            {
                // Process the response
                switch (response.Status)
                {
                    case 200:
                    {
                        // Create the result
                        string _value;
                        using (System.IO.StreamReader _streamReader = new System.IO.StreamReader(response.ContentStream))
                        {
                            _value = _streamReader.ReadToEnd();
                        }

                        // Create the response
                        return Response.FromValue(_value, response);
                    }
                    default:
                    {
                        // Create the result
                        System.Xml.Linq.XDocument _xml = System.Xml.Linq.XDocument.Load(response.ContentStream, System.Xml.Linq.LoadOptions.PreserveWhitespace);
                        Azure.Storage.Files.Models.StorageError _value = Azure.Storage.Files.Models.StorageError.FromXml(_xml.Root);

                        throw _value.CreateException(response);
                    }
                }
            }
            #endregion Share.GetPermissionAsync

            #region Share.SetQuotaAsync
            /// <summary>
            /// Sets quota for the specified share.
            /// </summary>
            /// <param name="pipeline">The pipeline used for sending requests.</param>
            /// <param name="resourceUri">The URL of the service account, share, directory or file that is the target of the desired operation.</param>
            /// <param name="timeout">The timeout parameter is expressed in seconds. For more information, see <a href="https://docs.microsoft.com/en-us/rest/api/storageservices/Setting-Timeouts-for-File-Service-Operations?redirectedfrom=MSDN">Setting Timeouts for File Service Operations.</a></param>
            /// <param name="quota">Specifies the maximum size of the share, in gigabytes.</param>
            /// <param name="async">Whether to invoke the operation asynchronously.  The default value is true.</param>
            /// <param name="clientDiagnostics">The ClientDiagnostics instance used for operation reporting.</param>
            /// <param name="operationName">Operation name.</param>
            /// <param name="cancellationToken">Cancellation token.</param>
            /// <returns>Azure.Response{Azure.Storage.Files.Models.ShareInfo}</returns>
            public static async System.Threading.Tasks.ValueTask<Azure.Response<Azure.Storage.Files.Models.ShareInfo>> SetQuotaAsync(
                Azure.Core.Pipeline.ClientDiagnostics clientDiagnostics,
                Azure.Core.Pipeline.HttpPipeline pipeline,
                System.Uri resourceUri,
                int? timeout = default,
                int? quota = default,
                bool async = true,
                string operationName = "Azure.Storage.Files.ShareClient.SetQuota",
                System.Threading.CancellationToken cancellationToken = default)
            {
                Azure.Core.Pipeline.DiagnosticScope _scope = clientDiagnostics.CreateScope(operationName);
                try
                {
                    _scope.AddAttribute("url", resourceUri);
                    _scope.Start();
                    using (Azure.Core.HttpMessage _message = SetQuotaAsync_CreateMessage(
                        pipeline,
                        resourceUri,
                        timeout,
                        quota))
                    {
                        if (async)
                        {
                            // Send the request asynchronously if we're being called via an async path
                            await pipeline.SendAsync(_message, cancellationToken).ConfigureAwait(false);
                        }
                        else
                        {
                            // Send the request synchronously through the API that blocks if we're being called via a sync path
                            // (this is safe because the Task will complete before the user can call Wait)
                            pipeline.Send(_message, cancellationToken);
                        }
                        Azure.Response _response = _message.Response;
                        cancellationToken.ThrowIfCancellationRequested();
                        return SetQuotaAsync_CreateResponse(_response);
                    }
                }
                catch (System.Exception ex)
                {
                    _scope.Failed(ex);
                    throw;
                }
                finally
                {
                    _scope.Dispose();
                }
            }

            /// <summary>
            /// Create the Share.SetQuotaAsync request.
            /// </summary>
            /// <param name="pipeline">The pipeline used for sending requests.</param>
            /// <param name="resourceUri">The URL of the service account, share, directory or file that is the target of the desired operation.</param>
            /// <param name="timeout">The timeout parameter is expressed in seconds. For more information, see <a href="https://docs.microsoft.com/en-us/rest/api/storageservices/Setting-Timeouts-for-File-Service-Operations?redirectedfrom=MSDN">Setting Timeouts for File Service Operations.</a></param>
            /// <param name="quota">Specifies the maximum size of the share, in gigabytes.</param>
            /// <returns>The Share.SetQuotaAsync Message.</returns>
            internal static Azure.Core.HttpMessage SetQuotaAsync_CreateMessage(
                Azure.Core.Pipeline.HttpPipeline pipeline,
                System.Uri resourceUri,
                int? timeout = default,
                int? quota = default)
            {
                // Validation
                if (resourceUri == null)
                {
                    throw new System.ArgumentNullException(nameof(resourceUri));
                }

                // Create the request
                Azure.Core.HttpMessage _message = pipeline.CreateMessage();
                Azure.Core.Request _request = _message.Request;

                // Set the endpoint
                _request.Method = Azure.Core.RequestMethod.Put;
                _request.Uri.Reset(resourceUri);
                _request.Uri.AppendQuery("restype", "share");
                _request.Uri.AppendQuery("comp", "properties");
                if (timeout != null) { _request.Uri.AppendQuery("timeout", System.Uri.EscapeDataString(timeout.Value.ToString(System.Globalization.CultureInfo.InvariantCulture))); }

                // Add request headers
                _request.Headers.SetValue("x-ms-version", "2019-02-02");
                if (quota != null) { _request.Headers.SetValue("x-ms-share-quota", quota.Value.ToString(System.Globalization.CultureInfo.InvariantCulture)); }

                return _message;
            }

            /// <summary>
            /// Create the Share.SetQuotaAsync response or throw a failure exception.
            /// </summary>
            /// <param name="response">The raw Response.</param>
            /// <returns>The Share.SetQuotaAsync Azure.Response{Azure.Storage.Files.Models.ShareInfo}.</returns>
            internal static Azure.Response<Azure.Storage.Files.Models.ShareInfo> SetQuotaAsync_CreateResponse(
                Azure.Response response)
            {
                // Process the response
                switch (response.Status)
                {
                    case 200:
                    {
                        // Create the result
                        Azure.Storage.Files.Models.ShareInfo _value = new Azure.Storage.Files.Models.ShareInfo();

                        // Get response headers
                        string _header;
                        if (response.Headers.TryGetValue("ETag", out _header))
                        {
                            _value.ETag = new Azure.ETag(_header);
                        }
                        if (response.Headers.TryGetValue("Last-Modified", out _header))
                        {
                            _value.LastModified = System.DateTimeOffset.Parse(_header, System.Globalization.CultureInfo.InvariantCulture);
                        }

                        // Create the response
                        return Response.FromValue(_value, response);
                    }
                    default:
                    {
                        // Create the result
                        System.Xml.Linq.XDocument _xml = System.Xml.Linq.XDocument.Load(response.ContentStream, System.Xml.Linq.LoadOptions.PreserveWhitespace);
                        Azure.Storage.Files.Models.StorageError _value = Azure.Storage.Files.Models.StorageError.FromXml(_xml.Root);

                        throw _value.CreateException(response);
                    }
                }
            }
            #endregion Share.SetQuotaAsync

            #region Share.SetMetadataAsync
            /// <summary>
            /// Sets one or more user-defined name-value pairs for the specified share.
            /// </summary>
            /// <param name="pipeline">The pipeline used for sending requests.</param>
            /// <param name="resourceUri">The URL of the service account, share, directory or file that is the target of the desired operation.</param>
            /// <param name="timeout">The timeout parameter is expressed in seconds. For more information, see <a href="https://docs.microsoft.com/en-us/rest/api/storageservices/Setting-Timeouts-for-File-Service-Operations?redirectedfrom=MSDN">Setting Timeouts for File Service Operations.</a></param>
            /// <param name="metadata">A name-value pair to associate with a file storage object.</param>
            /// <param name="async">Whether to invoke the operation asynchronously.  The default value is true.</param>
            /// <param name="clientDiagnostics">The ClientDiagnostics instance used for operation reporting.</param>
            /// <param name="operationName">Operation name.</param>
            /// <param name="cancellationToken">Cancellation token.</param>
            /// <returns>Azure.Response{Azure.Storage.Files.Models.ShareInfo}</returns>
            public static async System.Threading.Tasks.ValueTask<Azure.Response<Azure.Storage.Files.Models.ShareInfo>> SetMetadataAsync(
                Azure.Core.Pipeline.ClientDiagnostics clientDiagnostics,
                Azure.Core.Pipeline.HttpPipeline pipeline,
                System.Uri resourceUri,
                int? timeout = default,
                System.Collections.Generic.IDictionary<string, string> metadata = default,
                bool async = true,
                string operationName = "Azure.Storage.Files.ShareClient.SetMetadata",
                System.Threading.CancellationToken cancellationToken = default)
            {
                Azure.Core.Pipeline.DiagnosticScope _scope = clientDiagnostics.CreateScope(operationName);
                try
                {
                    _scope.AddAttribute("url", resourceUri);
                    _scope.Start();
                    using (Azure.Core.HttpMessage _message = SetMetadataAsync_CreateMessage(
                        pipeline,
                        resourceUri,
                        timeout,
                        metadata))
                    {
                        if (async)
                        {
                            // Send the request asynchronously if we're being called via an async path
                            await pipeline.SendAsync(_message, cancellationToken).ConfigureAwait(false);
                        }
                        else
                        {
                            // Send the request synchronously through the API that blocks if we're being called via a sync path
                            // (this is safe because the Task will complete before the user can call Wait)
                            pipeline.Send(_message, cancellationToken);
                        }
                        Azure.Response _response = _message.Response;
                        cancellationToken.ThrowIfCancellationRequested();
                        return SetMetadataAsync_CreateResponse(_response);
                    }
                }
                catch (System.Exception ex)
                {
                    _scope.Failed(ex);
                    throw;
                }
                finally
                {
                    _scope.Dispose();
                }
            }

            /// <summary>
            /// Create the Share.SetMetadataAsync request.
            /// </summary>
            /// <param name="pipeline">The pipeline used for sending requests.</param>
            /// <param name="resourceUri">The URL of the service account, share, directory or file that is the target of the desired operation.</param>
            /// <param name="timeout">The timeout parameter is expressed in seconds. For more information, see <a href="https://docs.microsoft.com/en-us/rest/api/storageservices/Setting-Timeouts-for-File-Service-Operations?redirectedfrom=MSDN">Setting Timeouts for File Service Operations.</a></param>
            /// <param name="metadata">A name-value pair to associate with a file storage object.</param>
            /// <returns>The Share.SetMetadataAsync Message.</returns>
            internal static Azure.Core.HttpMessage SetMetadataAsync_CreateMessage(
                Azure.Core.Pipeline.HttpPipeline pipeline,
                System.Uri resourceUri,
                int? timeout = default,
                System.Collections.Generic.IDictionary<string, string> metadata = default)
            {
                // Validation
                if (resourceUri == null)
                {
                    throw new System.ArgumentNullException(nameof(resourceUri));
                }

                // Create the request
                Azure.Core.HttpMessage _message = pipeline.CreateMessage();
                Azure.Core.Request _request = _message.Request;

                // Set the endpoint
                _request.Method = Azure.Core.RequestMethod.Put;
                _request.Uri.Reset(resourceUri);
                _request.Uri.AppendQuery("restype", "share");
                _request.Uri.AppendQuery("comp", "metadata");
                if (timeout != null) { _request.Uri.AppendQuery("timeout", System.Uri.EscapeDataString(timeout.Value.ToString(System.Globalization.CultureInfo.InvariantCulture))); }

                // Add request headers
                _request.Headers.SetValue("x-ms-version", "2019-02-02");
                if (metadata != null) {
                    foreach (System.Collections.Generic.KeyValuePair<string, string> _pair in metadata)
                    {
                        _request.Headers.SetValue("x-ms-meta-" + _pair.Key, _pair.Value);
                    }
                }

                return _message;
            }

            /// <summary>
            /// Create the Share.SetMetadataAsync response or throw a failure exception.
            /// </summary>
            /// <param name="response">The raw Response.</param>
            /// <returns>The Share.SetMetadataAsync Azure.Response{Azure.Storage.Files.Models.ShareInfo}.</returns>
            internal static Azure.Response<Azure.Storage.Files.Models.ShareInfo> SetMetadataAsync_CreateResponse(
                Azure.Response response)
            {
                // Process the response
                switch (response.Status)
                {
                    case 200:
                    {
                        // Create the result
                        Azure.Storage.Files.Models.ShareInfo _value = new Azure.Storage.Files.Models.ShareInfo();

                        // Get response headers
                        string _header;
                        if (response.Headers.TryGetValue("ETag", out _header))
                        {
                            _value.ETag = new Azure.ETag(_header);
                        }
                        if (response.Headers.TryGetValue("Last-Modified", out _header))
                        {
                            _value.LastModified = System.DateTimeOffset.Parse(_header, System.Globalization.CultureInfo.InvariantCulture);
                        }

                        // Create the response
                        return Response.FromValue(_value, response);
                    }
                    default:
                    {
                        // Create the result
                        System.Xml.Linq.XDocument _xml = System.Xml.Linq.XDocument.Load(response.ContentStream, System.Xml.Linq.LoadOptions.PreserveWhitespace);
                        Azure.Storage.Files.Models.StorageError _value = Azure.Storage.Files.Models.StorageError.FromXml(_xml.Root);

                        throw _value.CreateException(response);
                    }
                }
            }
            #endregion Share.SetMetadataAsync

            #region Share.GetAccessPolicyAsync
            /// <summary>
            /// Returns information about stored access policies specified on the share.
            /// </summary>
            /// <param name="pipeline">The pipeline used for sending requests.</param>
            /// <param name="resourceUri">The URL of the service account, share, directory or file that is the target of the desired operation.</param>
            /// <param name="timeout">The timeout parameter is expressed in seconds. For more information, see <a href="https://docs.microsoft.com/en-us/rest/api/storageservices/Setting-Timeouts-for-File-Service-Operations?redirectedfrom=MSDN">Setting Timeouts for File Service Operations.</a></param>
            /// <param name="async">Whether to invoke the operation asynchronously.  The default value is true.</param>
            /// <param name="clientDiagnostics">The ClientDiagnostics instance used for operation reporting.</param>
            /// <param name="operationName">Operation name.</param>
            /// <param name="cancellationToken">Cancellation token.</param>
            /// <returns>A collection of signed identifiers.</returns>
            public static async System.Threading.Tasks.ValueTask<Azure.Response<System.Collections.Generic.IEnumerable<Azure.Storage.Files.Models.SignedIdentifier>>> GetAccessPolicyAsync(
                Azure.Core.Pipeline.ClientDiagnostics clientDiagnostics,
                Azure.Core.Pipeline.HttpPipeline pipeline,
                System.Uri resourceUri,
                int? timeout = default,
                bool async = true,
                string operationName = "Azure.Storage.Files.ShareClient.GetAccessPolicy",
                System.Threading.CancellationToken cancellationToken = default)
            {
                Azure.Core.Pipeline.DiagnosticScope _scope = clientDiagnostics.CreateScope(operationName);
                try
                {
                    _scope.AddAttribute("url", resourceUri);
                    _scope.Start();
                    using (Azure.Core.HttpMessage _message = GetAccessPolicyAsync_CreateMessage(
                        pipeline,
                        resourceUri,
                        timeout))
                    {
                        if (async)
                        {
                            // Send the request asynchronously if we're being called via an async path
                            await pipeline.SendAsync(_message, cancellationToken).ConfigureAwait(false);
                        }
                        else
                        {
                            // Send the request synchronously through the API that blocks if we're being called via a sync path
                            // (this is safe because the Task will complete before the user can call Wait)
                            pipeline.Send(_message, cancellationToken);
                        }
                        Azure.Response _response = _message.Response;
                        cancellationToken.ThrowIfCancellationRequested();
                        return GetAccessPolicyAsync_CreateResponse(_response);
                    }
                }
                catch (System.Exception ex)
                {
                    _scope.Failed(ex);
                    throw;
                }
                finally
                {
                    _scope.Dispose();
                }
            }

            /// <summary>
            /// Create the Share.GetAccessPolicyAsync request.
            /// </summary>
            /// <param name="pipeline">The pipeline used for sending requests.</param>
            /// <param name="resourceUri">The URL of the service account, share, directory or file that is the target of the desired operation.</param>
            /// <param name="timeout">The timeout parameter is expressed in seconds. For more information, see <a href="https://docs.microsoft.com/en-us/rest/api/storageservices/Setting-Timeouts-for-File-Service-Operations?redirectedfrom=MSDN">Setting Timeouts for File Service Operations.</a></param>
            /// <returns>The Share.GetAccessPolicyAsync Message.</returns>
            internal static Azure.Core.HttpMessage GetAccessPolicyAsync_CreateMessage(
                Azure.Core.Pipeline.HttpPipeline pipeline,
                System.Uri resourceUri,
                int? timeout = default)
            {
                // Validation
                if (resourceUri == null)
                {
                    throw new System.ArgumentNullException(nameof(resourceUri));
                }

                // Create the request
                Azure.Core.HttpMessage _message = pipeline.CreateMessage();
                Azure.Core.Request _request = _message.Request;

                // Set the endpoint
                _request.Method = Azure.Core.RequestMethod.Get;
                _request.Uri.Reset(resourceUri);
                _request.Uri.AppendQuery("restype", "share");
                _request.Uri.AppendQuery("comp", "acl");
                if (timeout != null) { _request.Uri.AppendQuery("timeout", System.Uri.EscapeDataString(timeout.Value.ToString(System.Globalization.CultureInfo.InvariantCulture))); }

                // Add request headers
                _request.Headers.SetValue("x-ms-version", "2019-02-02");

                return _message;
            }

            /// <summary>
            /// Create the Share.GetAccessPolicyAsync response or throw a failure exception.
            /// </summary>
            /// <param name="response">The raw Response.</param>
            /// <returns>The Share.GetAccessPolicyAsync Azure.Response{System.Collections.Generic.IEnumerable{Azure.Storage.Files.Models.SignedIdentifier}}.</returns>
            internal static Azure.Response<System.Collections.Generic.IEnumerable<Azure.Storage.Files.Models.SignedIdentifier>> GetAccessPolicyAsync_CreateResponse(
                Azure.Response response)
            {
                // Process the response
                switch (response.Status)
                {
                    case 200:
                    {
                        // Create the result
                        System.Xml.Linq.XDocument _xml = System.Xml.Linq.XDocument.Load(response.ContentStream, System.Xml.Linq.LoadOptions.PreserveWhitespace);
                        System.Collections.Generic.IEnumerable<Azure.Storage.Files.Models.SignedIdentifier> _value =
                            System.Linq.Enumerable.ToList(
                                System.Linq.Enumerable.Select(
                                    _xml.Element(System.Xml.Linq.XName.Get("SignedIdentifiers", "")).Elements(System.Xml.Linq.XName.Get("SignedIdentifier", "")),
                                    Azure.Storage.Files.Models.SignedIdentifier.FromXml));

                        // Create the response
                        return Response.FromValue(_value, response);
                    }
                    default:
                    {
                        // Create the result
                        System.Xml.Linq.XDocument _xml = System.Xml.Linq.XDocument.Load(response.ContentStream, System.Xml.Linq.LoadOptions.PreserveWhitespace);
                        Azure.Storage.Files.Models.StorageError _value = Azure.Storage.Files.Models.StorageError.FromXml(_xml.Root);

                        throw _value.CreateException(response);
                    }
                }
            }
            #endregion Share.GetAccessPolicyAsync

            #region Share.SetAccessPolicyAsync
            /// <summary>
            /// Sets a stored access policy for use with shared access signatures.
            /// </summary>
            /// <param name="pipeline">The pipeline used for sending requests.</param>
            /// <param name="resourceUri">The URL of the service account, share, directory or file that is the target of the desired operation.</param>
            /// <param name="permissions">The ACL for the share.</param>
            /// <param name="timeout">The timeout parameter is expressed in seconds. For more information, see <a href="https://docs.microsoft.com/en-us/rest/api/storageservices/Setting-Timeouts-for-File-Service-Operations?redirectedfrom=MSDN">Setting Timeouts for File Service Operations.</a></param>
            /// <param name="async">Whether to invoke the operation asynchronously.  The default value is true.</param>
            /// <param name="clientDiagnostics">The ClientDiagnostics instance used for operation reporting.</param>
            /// <param name="operationName">Operation name.</param>
            /// <param name="cancellationToken">Cancellation token.</param>
            /// <returns>Azure.Response{Azure.Storage.Files.Models.ShareInfo}</returns>
            public static async System.Threading.Tasks.ValueTask<Azure.Response<Azure.Storage.Files.Models.ShareInfo>> SetAccessPolicyAsync(
                Azure.Core.Pipeline.ClientDiagnostics clientDiagnostics,
                Azure.Core.Pipeline.HttpPipeline pipeline,
                System.Uri resourceUri,
                System.Collections.Generic.IEnumerable<Azure.Storage.Files.Models.SignedIdentifier> permissions = default,
                int? timeout = default,
                bool async = true,
                string operationName = "Azure.Storage.Files.ShareClient.SetAccessPolicy",
                System.Threading.CancellationToken cancellationToken = default)
            {
                Azure.Core.Pipeline.DiagnosticScope _scope = clientDiagnostics.CreateScope(operationName);
                try
                {
                    _scope.AddAttribute("url", resourceUri);
                    _scope.Start();
                    using (Azure.Core.HttpMessage _message = SetAccessPolicyAsync_CreateMessage(
                        pipeline,
                        resourceUri,
                        permissions,
                        timeout))
                    {
                        if (async)
                        {
                            // Send the request asynchronously if we're being called via an async path
                            await pipeline.SendAsync(_message, cancellationToken).ConfigureAwait(false);
                        }
                        else
                        {
                            // Send the request synchronously through the API that blocks if we're being called via a sync path
                            // (this is safe because the Task will complete before the user can call Wait)
                            pipeline.Send(_message, cancellationToken);
                        }
                        Azure.Response _response = _message.Response;
                        cancellationToken.ThrowIfCancellationRequested();
                        return SetAccessPolicyAsync_CreateResponse(_response);
                    }
                }
                catch (System.Exception ex)
                {
                    _scope.Failed(ex);
                    throw;
                }
                finally
                {
                    _scope.Dispose();
                }
            }

            /// <summary>
            /// Create the Share.SetAccessPolicyAsync request.
            /// </summary>
            /// <param name="pipeline">The pipeline used for sending requests.</param>
            /// <param name="resourceUri">The URL of the service account, share, directory or file that is the target of the desired operation.</param>
            /// <param name="permissions">The ACL for the share.</param>
            /// <param name="timeout">The timeout parameter is expressed in seconds. For more information, see <a href="https://docs.microsoft.com/en-us/rest/api/storageservices/Setting-Timeouts-for-File-Service-Operations?redirectedfrom=MSDN">Setting Timeouts for File Service Operations.</a></param>
            /// <returns>The Share.SetAccessPolicyAsync Message.</returns>
            internal static Azure.Core.HttpMessage SetAccessPolicyAsync_CreateMessage(
                Azure.Core.Pipeline.HttpPipeline pipeline,
                System.Uri resourceUri,
                System.Collections.Generic.IEnumerable<Azure.Storage.Files.Models.SignedIdentifier> permissions = default,
                int? timeout = default)
            {
                // Validation
                if (resourceUri == null)
                {
                    throw new System.ArgumentNullException(nameof(resourceUri));
                }

                // Create the request
                Azure.Core.HttpMessage _message = pipeline.CreateMessage();
                Azure.Core.Request _request = _message.Request;

                // Set the endpoint
                _request.Method = Azure.Core.RequestMethod.Put;
                _request.Uri.Reset(resourceUri);
                _request.Uri.AppendQuery("restype", "share");
                _request.Uri.AppendQuery("comp", "acl");
                if (timeout != null) { _request.Uri.AppendQuery("timeout", System.Uri.EscapeDataString(timeout.Value.ToString(System.Globalization.CultureInfo.InvariantCulture))); }

                // Add request headers
                _request.Headers.SetValue("x-ms-version", "2019-02-02");

                // Create the body
                System.Xml.Linq.XElement _body = new System.Xml.Linq.XElement(System.Xml.Linq.XName.Get("SignedIdentifiers", ""));
                if (permissions != null)
                {
                    foreach (Azure.Storage.Files.Models.SignedIdentifier _child in permissions)
                    {
                        _body.Add(Azure.Storage.Files.Models.SignedIdentifier.ToXml(_child));
                    }
                }
                string _text = _body.ToString(System.Xml.Linq.SaveOptions.DisableFormatting);
                _request.Headers.SetValue("Content-Type", "application/xml");
                _request.Headers.SetValue("Content-Length", _text.Length.ToString(System.Globalization.CultureInfo.InvariantCulture));
                _request.Content = Azure.Core.RequestContent.Create(System.Text.Encoding.UTF8.GetBytes(_text));

                return _message;
            }

            /// <summary>
            /// Create the Share.SetAccessPolicyAsync response or throw a failure exception.
            /// </summary>
            /// <param name="response">The raw Response.</param>
            /// <returns>The Share.SetAccessPolicyAsync Azure.Response{Azure.Storage.Files.Models.ShareInfo}.</returns>
            internal static Azure.Response<Azure.Storage.Files.Models.ShareInfo> SetAccessPolicyAsync_CreateResponse(
                Azure.Response response)
            {
                // Process the response
                switch (response.Status)
                {
                    case 200:
                    {
                        // Create the result
                        Azure.Storage.Files.Models.ShareInfo _value = new Azure.Storage.Files.Models.ShareInfo();

                        // Get response headers
                        string _header;
                        if (response.Headers.TryGetValue("ETag", out _header))
                        {
                            _value.ETag = new Azure.ETag(_header);
                        }
                        if (response.Headers.TryGetValue("Last-Modified", out _header))
                        {
                            _value.LastModified = System.DateTimeOffset.Parse(_header, System.Globalization.CultureInfo.InvariantCulture);
                        }

                        // Create the response
                        return Response.FromValue(_value, response);
                    }
                    default:
                    {
                        // Create the result
                        System.Xml.Linq.XDocument _xml = System.Xml.Linq.XDocument.Load(response.ContentStream, System.Xml.Linq.LoadOptions.PreserveWhitespace);
                        Azure.Storage.Files.Models.StorageError _value = Azure.Storage.Files.Models.StorageError.FromXml(_xml.Root);

                        throw _value.CreateException(response);
                    }
                }
            }
            #endregion Share.SetAccessPolicyAsync

            #region Share.GetStatisticsAsync
            /// <summary>
            /// Retrieves statistics related to the share.
            /// </summary>
            /// <param name="pipeline">The pipeline used for sending requests.</param>
            /// <param name="resourceUri">The URL of the service account, share, directory or file that is the target of the desired operation.</param>
            /// <param name="timeout">The timeout parameter is expressed in seconds. For more information, see <a href="https://docs.microsoft.com/en-us/rest/api/storageservices/Setting-Timeouts-for-File-Service-Operations?redirectedfrom=MSDN">Setting Timeouts for File Service Operations.</a></param>
            /// <param name="async">Whether to invoke the operation asynchronously.  The default value is true.</param>
            /// <param name="clientDiagnostics">The ClientDiagnostics instance used for operation reporting.</param>
            /// <param name="operationName">Operation name.</param>
            /// <param name="cancellationToken">Cancellation token.</param>
            /// <returns>Stats for the share.</returns>
            public static async System.Threading.Tasks.ValueTask<Azure.Response<Azure.Storage.Files.Models.ShareStatistics>> GetStatisticsAsync(
                Azure.Core.Pipeline.ClientDiagnostics clientDiagnostics,
                Azure.Core.Pipeline.HttpPipeline pipeline,
                System.Uri resourceUri,
                int? timeout = default,
                bool async = true,
                string operationName = "Azure.Storage.Files.ShareClient.GetStatistics",
                System.Threading.CancellationToken cancellationToken = default)
            {
                Azure.Core.Pipeline.DiagnosticScope _scope = clientDiagnostics.CreateScope(operationName);
                try
                {
                    _scope.AddAttribute("url", resourceUri);
                    _scope.Start();
                    using (Azure.Core.HttpMessage _message = GetStatisticsAsync_CreateMessage(
                        pipeline,
                        resourceUri,
                        timeout))
                    {
                        if (async)
                        {
                            // Send the request asynchronously if we're being called via an async path
                            await pipeline.SendAsync(_message, cancellationToken).ConfigureAwait(false);
                        }
                        else
                        {
                            // Send the request synchronously through the API that blocks if we're being called via a sync path
                            // (this is safe because the Task will complete before the user can call Wait)
                            pipeline.Send(_message, cancellationToken);
                        }
                        Azure.Response _response = _message.Response;
                        cancellationToken.ThrowIfCancellationRequested();
                        return GetStatisticsAsync_CreateResponse(_response);
                    }
                }
                catch (System.Exception ex)
                {
                    _scope.Failed(ex);
                    throw;
                }
                finally
                {
                    _scope.Dispose();
                }
            }

            /// <summary>
            /// Create the Share.GetStatisticsAsync request.
            /// </summary>
            /// <param name="pipeline">The pipeline used for sending requests.</param>
            /// <param name="resourceUri">The URL of the service account, share, directory or file that is the target of the desired operation.</param>
            /// <param name="timeout">The timeout parameter is expressed in seconds. For more information, see <a href="https://docs.microsoft.com/en-us/rest/api/storageservices/Setting-Timeouts-for-File-Service-Operations?redirectedfrom=MSDN">Setting Timeouts for File Service Operations.</a></param>
            /// <returns>The Share.GetStatisticsAsync Message.</returns>
            internal static Azure.Core.HttpMessage GetStatisticsAsync_CreateMessage(
                Azure.Core.Pipeline.HttpPipeline pipeline,
                System.Uri resourceUri,
                int? timeout = default)
            {
                // Validation
                if (resourceUri == null)
                {
                    throw new System.ArgumentNullException(nameof(resourceUri));
                }

                // Create the request
                Azure.Core.HttpMessage _message = pipeline.CreateMessage();
                Azure.Core.Request _request = _message.Request;

                // Set the endpoint
                _request.Method = Azure.Core.RequestMethod.Get;
                _request.Uri.Reset(resourceUri);
                _request.Uri.AppendQuery("restype", "share");
                _request.Uri.AppendQuery("comp", "stats");
                if (timeout != null) { _request.Uri.AppendQuery("timeout", System.Uri.EscapeDataString(timeout.Value.ToString(System.Globalization.CultureInfo.InvariantCulture))); }

                // Add request headers
                _request.Headers.SetValue("x-ms-version", "2019-02-02");

                return _message;
            }

            /// <summary>
            /// Create the Share.GetStatisticsAsync response or throw a failure exception.
            /// </summary>
            /// <param name="response">The raw Response.</param>
            /// <returns>The Share.GetStatisticsAsync Azure.Response{Azure.Storage.Files.Models.ShareStatistics}.</returns>
            internal static Azure.Response<Azure.Storage.Files.Models.ShareStatistics> GetStatisticsAsync_CreateResponse(
                Azure.Response response)
            {
                // Process the response
                switch (response.Status)
                {
                    case 200:
                    {
                        // Create the result
                        System.Xml.Linq.XDocument _xml = System.Xml.Linq.XDocument.Load(response.ContentStream, System.Xml.Linq.LoadOptions.PreserveWhitespace);
                        Azure.Storage.Files.Models.ShareStatistics _value = Azure.Storage.Files.Models.ShareStatistics.FromXml(_xml.Root);

                        // Create the response
                        return Response.FromValue(_value, response);
                    }
                    default:
                    {
                        // Create the result
                        System.Xml.Linq.XDocument _xml = System.Xml.Linq.XDocument.Load(response.ContentStream, System.Xml.Linq.LoadOptions.PreserveWhitespace);
                        Azure.Storage.Files.Models.StorageError _value = Azure.Storage.Files.Models.StorageError.FromXml(_xml.Root);

                        throw _value.CreateException(response);
                    }
                }
            }
            #endregion Share.GetStatisticsAsync
        }
        #endregion Share operations

        #region Directory operations
        /// <summary>
        /// Directory operations for Azure File Storage
        /// </summary>
        public static partial class Directory
        {
            #region Directory.CreateAsync
            /// <summary>
            /// Creates a new directory under the specified share or parent directory.
            /// </summary>
            /// <param name="pipeline">The pipeline used for sending requests.</param>
            /// <param name="resourceUri">The URL of the service account, share, directory or file that is the target of the desired operation.</param>
            /// <param name="fileAttributes">If specified, the provided file attributes shall be set. Default value: ‘Archive’ for file and ‘Directory’ for directory. ‘None’ can also be specified as default.</param>
            /// <param name="fileCreationTime">Creation time for the file/directory. Default value: Now.</param>
            /// <param name="fileLastWriteTime">Last write time for the file/directory. Default value: Now.</param>
            /// <param name="timeout">The timeout parameter is expressed in seconds. For more information, see <a href="https://docs.microsoft.com/en-us/rest/api/storageservices/Setting-Timeouts-for-File-Service-Operations?redirectedfrom=MSDN">Setting Timeouts for File Service Operations.</a></param>
            /// <param name="metadata">A name-value pair to associate with a file storage object.</param>
            /// <param name="filePermission">If specified the permission (security descriptor) shall be set for the directory/file. This header can be used if Permission size is &lt;= 8KB, else x-ms-file-permission-key header shall be used. Default value: Inherit. If SDDL is specified as input, it must have owner, group and dacl. Note: Only one of the x-ms-file-permission or x-ms-file-permission-key should be specified.</param>
            /// <param name="filePermissionKey">Key of the permission to be set for the directory/file. Note: Only one of the x-ms-file-permission or x-ms-file-permission-key should be specified.</param>
            /// <param name="async">Whether to invoke the operation asynchronously.  The default value is true.</param>
            /// <param name="clientDiagnostics">The ClientDiagnostics instance used for operation reporting.</param>
            /// <param name="operationName">Operation name.</param>
            /// <param name="cancellationToken">Cancellation token.</param>
            /// <returns>Azure.Response{Azure.Storage.Files.Models.RawStorageDirectoryInfo}</returns>
            public static async System.Threading.Tasks.ValueTask<Azure.Response<Azure.Storage.Files.Models.RawStorageDirectoryInfo>> CreateAsync(
                Azure.Core.Pipeline.ClientDiagnostics clientDiagnostics,
                Azure.Core.Pipeline.HttpPipeline pipeline,
                System.Uri resourceUri,
                string fileAttributes,
                string fileCreationTime,
                string fileLastWriteTime,
                int? timeout = default,
                System.Collections.Generic.IDictionary<string, string> metadata = default,
                string filePermission = default,
                string filePermissionKey = default,
                bool async = true,
                string operationName = "Azure.Storage.Files.DirectoryClient.Create",
                System.Threading.CancellationToken cancellationToken = default)
            {
                Azure.Core.Pipeline.DiagnosticScope _scope = clientDiagnostics.CreateScope(operationName);
                try
                {
                    _scope.AddAttribute("url", resourceUri);
                    _scope.Start();
                    using (Azure.Core.HttpMessage _message = CreateAsync_CreateMessage(
                        pipeline,
                        resourceUri,
                        fileAttributes,
                        fileCreationTime,
                        fileLastWriteTime,
                        timeout,
                        metadata,
                        filePermission,
                        filePermissionKey))
                    {
                        if (async)
                        {
                            // Send the request asynchronously if we're being called via an async path
                            await pipeline.SendAsync(_message, cancellationToken).ConfigureAwait(false);
                        }
                        else
                        {
                            // Send the request synchronously through the API that blocks if we're being called via a sync path
                            // (this is safe because the Task will complete before the user can call Wait)
                            pipeline.Send(_message, cancellationToken);
                        }
                        Azure.Response _response = _message.Response;
                        cancellationToken.ThrowIfCancellationRequested();
                        return CreateAsync_CreateResponse(_response);
                    }
                }
                catch (System.Exception ex)
                {
                    _scope.Failed(ex);
                    throw;
                }
                finally
                {
                    _scope.Dispose();
                }
            }

            /// <summary>
            /// Create the Directory.CreateAsync request.
            /// </summary>
            /// <param name="pipeline">The pipeline used for sending requests.</param>
            /// <param name="resourceUri">The URL of the service account, share, directory or file that is the target of the desired operation.</param>
            /// <param name="fileAttributes">If specified, the provided file attributes shall be set. Default value: ‘Archive’ for file and ‘Directory’ for directory. ‘None’ can also be specified as default.</param>
            /// <param name="fileCreationTime">Creation time for the file/directory. Default value: Now.</param>
            /// <param name="fileLastWriteTime">Last write time for the file/directory. Default value: Now.</param>
            /// <param name="timeout">The timeout parameter is expressed in seconds. For more information, see <a href="https://docs.microsoft.com/en-us/rest/api/storageservices/Setting-Timeouts-for-File-Service-Operations?redirectedfrom=MSDN">Setting Timeouts for File Service Operations.</a></param>
            /// <param name="metadata">A name-value pair to associate with a file storage object.</param>
            /// <param name="filePermission">If specified the permission (security descriptor) shall be set for the directory/file. This header can be used if Permission size is &lt;= 8KB, else x-ms-file-permission-key header shall be used. Default value: Inherit. If SDDL is specified as input, it must have owner, group and dacl. Note: Only one of the x-ms-file-permission or x-ms-file-permission-key should be specified.</param>
            /// <param name="filePermissionKey">Key of the permission to be set for the directory/file. Note: Only one of the x-ms-file-permission or x-ms-file-permission-key should be specified.</param>
            /// <returns>The Directory.CreateAsync Message.</returns>
            internal static Azure.Core.HttpMessage CreateAsync_CreateMessage(
                Azure.Core.Pipeline.HttpPipeline pipeline,
                System.Uri resourceUri,
                string fileAttributes,
                string fileCreationTime,
                string fileLastWriteTime,
                int? timeout = default,
                System.Collections.Generic.IDictionary<string, string> metadata = default,
                string filePermission = default,
                string filePermissionKey = default)
            {
                // Validation
                if (resourceUri == null)
                {
                    throw new System.ArgumentNullException(nameof(resourceUri));
                }
                if (fileAttributes == null)
                {
                    throw new System.ArgumentNullException(nameof(fileAttributes));
                }
                if (fileCreationTime == null)
                {
                    throw new System.ArgumentNullException(nameof(fileCreationTime));
                }
                if (fileLastWriteTime == null)
                {
                    throw new System.ArgumentNullException(nameof(fileLastWriteTime));
                }

                // Create the request
                Azure.Core.HttpMessage _message = pipeline.CreateMessage();
                Azure.Core.Request _request = _message.Request;

                // Set the endpoint
                _request.Method = Azure.Core.RequestMethod.Put;
                _request.Uri.Reset(resourceUri);
                _request.Uri.AppendQuery("restype", "directory");
                if (timeout != null) { _request.Uri.AppendQuery("timeout", System.Uri.EscapeDataString(timeout.Value.ToString(System.Globalization.CultureInfo.InvariantCulture))); }

                // Add request headers
                _request.Headers.SetValue("x-ms-version", "2019-02-02");
                _request.Headers.SetValue("x-ms-file-attributes", fileAttributes);
                _request.Headers.SetValue("x-ms-file-creation-time", fileCreationTime);
                _request.Headers.SetValue("x-ms-file-last-write-time", fileLastWriteTime);
                if (metadata != null) {
                    foreach (System.Collections.Generic.KeyValuePair<string, string> _pair in metadata)
                    {
                        _request.Headers.SetValue("x-ms-meta-" + _pair.Key, _pair.Value);
                    }
                }
                if (filePermission != null) { _request.Headers.SetValue("x-ms-file-permission", filePermission); }
                if (filePermissionKey != null) { _request.Headers.SetValue("x-ms-file-permission-key", filePermissionKey); }

                return _message;
            }

            /// <summary>
            /// Create the Directory.CreateAsync response or throw a failure exception.
            /// </summary>
            /// <param name="response">The raw Response.</param>
            /// <returns>The Directory.CreateAsync Azure.Response{Azure.Storage.Files.Models.RawStorageDirectoryInfo}.</returns>
            internal static Azure.Response<Azure.Storage.Files.Models.RawStorageDirectoryInfo> CreateAsync_CreateResponse(
                Azure.Response response)
            {
                // Process the response
                switch (response.Status)
                {
                    case 201:
                    {
                        // Create the result
                        Azure.Storage.Files.Models.RawStorageDirectoryInfo _value = new Azure.Storage.Files.Models.RawStorageDirectoryInfo();

                        // Get response headers
                        string _header;
                        if (response.Headers.TryGetValue("ETag", out _header))
                        {
                            _value.ETag = new Azure.ETag(_header);
                        }
                        if (response.Headers.TryGetValue("Last-Modified", out _header))
                        {
                            _value.LastModified = System.DateTimeOffset.Parse(_header, System.Globalization.CultureInfo.InvariantCulture);
                        }
                        if (response.Headers.TryGetValue("x-ms-file-permission-key", out _header))
                        {
                            _value.FilePermissionKey = _header;
                        }
                        if (response.Headers.TryGetValue("x-ms-file-attributes", out _header))
                        {
                            _value.FileAttributes = _header;
                        }
                        if (response.Headers.TryGetValue("x-ms-file-creation-time", out _header))
                        {
                            _value.FileCreationTime = System.DateTimeOffset.Parse(_header, System.Globalization.CultureInfo.InvariantCulture);
                        }
                        if (response.Headers.TryGetValue("x-ms-file-last-write-time", out _header))
                        {
                            _value.FileLastWriteTime = System.DateTimeOffset.Parse(_header, System.Globalization.CultureInfo.InvariantCulture);
                        }
                        if (response.Headers.TryGetValue("x-ms-file-change-time", out _header))
                        {
                            _value.FileChangeTime = System.DateTimeOffset.Parse(_header, System.Globalization.CultureInfo.InvariantCulture);
                        }
                        if (response.Headers.TryGetValue("x-ms-file-id", out _header))
                        {
                            _value.FileId = _header;
                        }
                        if (response.Headers.TryGetValue("x-ms-file-parent-id", out _header))
                        {
                            _value.FileParentId = _header;
                        }

                        // Create the response
                        return Response.FromValue(_value, response);
                    }
                    default:
                    {
                        // Create the result
                        System.Xml.Linq.XDocument _xml = System.Xml.Linq.XDocument.Load(response.ContentStream, System.Xml.Linq.LoadOptions.PreserveWhitespace);
                        Azure.Storage.Files.Models.StorageError _value = Azure.Storage.Files.Models.StorageError.FromXml(_xml.Root);

                        throw _value.CreateException(response);
                    }
                }
            }
            #endregion Directory.CreateAsync

            #region Directory.GetPropertiesAsync
            /// <summary>
            /// Returns all system properties for the specified directory, and can also be used to check the existence of a directory. The data returned does not include the files in the directory or any subdirectories.
            /// </summary>
            /// <param name="pipeline">The pipeline used for sending requests.</param>
            /// <param name="resourceUri">The URL of the service account, share, directory or file that is the target of the desired operation.</param>
            /// <param name="sharesnapshot">The snapshot parameter is an opaque DateTime value that, when present, specifies the share snapshot to query.</param>
            /// <param name="timeout">The timeout parameter is expressed in seconds. For more information, see <a href="https://docs.microsoft.com/en-us/rest/api/storageservices/Setting-Timeouts-for-File-Service-Operations?redirectedfrom=MSDN">Setting Timeouts for File Service Operations.</a></param>
            /// <param name="async">Whether to invoke the operation asynchronously.  The default value is true.</param>
            /// <param name="clientDiagnostics">The ClientDiagnostics instance used for operation reporting.</param>
            /// <param name="operationName">Operation name.</param>
            /// <param name="cancellationToken">Cancellation token.</param>
            /// <returns>Azure.Response{Azure.Storage.Files.Models.RawStorageDirectoryProperties}</returns>
            public static async System.Threading.Tasks.ValueTask<Azure.Response<Azure.Storage.Files.Models.RawStorageDirectoryProperties>> GetPropertiesAsync(
                Azure.Core.Pipeline.ClientDiagnostics clientDiagnostics,
                Azure.Core.Pipeline.HttpPipeline pipeline,
                System.Uri resourceUri,
                string sharesnapshot = default,
                int? timeout = default,
                bool async = true,
                string operationName = "Azure.Storage.Files.DirectoryClient.GetProperties",
                System.Threading.CancellationToken cancellationToken = default)
            {
                Azure.Core.Pipeline.DiagnosticScope _scope = clientDiagnostics.CreateScope(operationName);
                try
                {
                    _scope.AddAttribute("url", resourceUri);
                    _scope.Start();
                    using (Azure.Core.HttpMessage _message = GetPropertiesAsync_CreateMessage(
                        pipeline,
                        resourceUri,
                        sharesnapshot,
                        timeout))
                    {
                        if (async)
                        {
                            // Send the request asynchronously if we're being called via an async path
                            await pipeline.SendAsync(_message, cancellationToken).ConfigureAwait(false);
                        }
                        else
                        {
                            // Send the request synchronously through the API that blocks if we're being called via a sync path
                            // (this is safe because the Task will complete before the user can call Wait)
                            pipeline.Send(_message, cancellationToken);
                        }
                        Azure.Response _response = _message.Response;
                        cancellationToken.ThrowIfCancellationRequested();
                        return GetPropertiesAsync_CreateResponse(_response);
                    }
                }
                catch (System.Exception ex)
                {
                    _scope.Failed(ex);
                    throw;
                }
                finally
                {
                    _scope.Dispose();
                }
            }

            /// <summary>
            /// Create the Directory.GetPropertiesAsync request.
            /// </summary>
            /// <param name="pipeline">The pipeline used for sending requests.</param>
            /// <param name="resourceUri">The URL of the service account, share, directory or file that is the target of the desired operation.</param>
            /// <param name="sharesnapshot">The snapshot parameter is an opaque DateTime value that, when present, specifies the share snapshot to query.</param>
            /// <param name="timeout">The timeout parameter is expressed in seconds. For more information, see <a href="https://docs.microsoft.com/en-us/rest/api/storageservices/Setting-Timeouts-for-File-Service-Operations?redirectedfrom=MSDN">Setting Timeouts for File Service Operations.</a></param>
            /// <returns>The Directory.GetPropertiesAsync Message.</returns>
            internal static Azure.Core.HttpMessage GetPropertiesAsync_CreateMessage(
                Azure.Core.Pipeline.HttpPipeline pipeline,
                System.Uri resourceUri,
                string sharesnapshot = default,
                int? timeout = default)
            {
                // Validation
                if (resourceUri == null)
                {
                    throw new System.ArgumentNullException(nameof(resourceUri));
                }

                // Create the request
                Azure.Core.HttpMessage _message = pipeline.CreateMessage();
                Azure.Core.Request _request = _message.Request;

                // Set the endpoint
                _request.Method = Azure.Core.RequestMethod.Get;
                _request.Uri.Reset(resourceUri);
                _request.Uri.AppendQuery("restype", "directory");
                if (sharesnapshot != null) { _request.Uri.AppendQuery("sharesnapshot", System.Uri.EscapeDataString(sharesnapshot)); }
                if (timeout != null) { _request.Uri.AppendQuery("timeout", System.Uri.EscapeDataString(timeout.Value.ToString(System.Globalization.CultureInfo.InvariantCulture))); }

                // Add request headers
                _request.Headers.SetValue("x-ms-version", "2019-02-02");

                return _message;
            }

            /// <summary>
            /// Create the Directory.GetPropertiesAsync response or throw a failure exception.
            /// </summary>
            /// <param name="response">The raw Response.</param>
            /// <returns>The Directory.GetPropertiesAsync Azure.Response{Azure.Storage.Files.Models.RawStorageDirectoryProperties}.</returns>
            internal static Azure.Response<Azure.Storage.Files.Models.RawStorageDirectoryProperties> GetPropertiesAsync_CreateResponse(
                Azure.Response response)
            {
                // Process the response
                switch (response.Status)
                {
                    case 200:
                    {
                        // Create the result
                        Azure.Storage.Files.Models.RawStorageDirectoryProperties _value = new Azure.Storage.Files.Models.RawStorageDirectoryProperties();

                        // Get response headers
                        string _header;
                        _value.Metadata = new System.Collections.Generic.Dictionary<string, string>(System.StringComparer.OrdinalIgnoreCase);
                        foreach (Azure.Core.HttpHeader _headerPair in response.Headers)
                        {
                            if (_headerPair.Name.StartsWith("x-ms-meta-", System.StringComparison.InvariantCulture))
                            {
                                _value.Metadata[_headerPair.Name.Substring(10)] = _headerPair.Value;
                            }
                        }
                        if (response.Headers.TryGetValue("ETag", out _header))
                        {
                            _value.ETag = new Azure.ETag(_header);
                        }
                        if (response.Headers.TryGetValue("Last-Modified", out _header))
                        {
                            _value.LastModified = System.DateTimeOffset.Parse(_header, System.Globalization.CultureInfo.InvariantCulture);
                        }
                        if (response.Headers.TryGetValue("x-ms-server-encrypted", out _header))
                        {
                            _value.IsServerEncrypted = bool.Parse(_header);
                        }
                        if (response.Headers.TryGetValue("x-ms-file-attributes", out _header))
                        {
                            _value.FileAttributes = _header;
                        }
                        if (response.Headers.TryGetValue("x-ms-file-creation-time", out _header))
                        {
                            _value.FileCreationTime = System.DateTimeOffset.Parse(_header, System.Globalization.CultureInfo.InvariantCulture);
                        }
                        if (response.Headers.TryGetValue("x-ms-file-last-write-time", out _header))
                        {
                            _value.FileLastWriteTime = System.DateTimeOffset.Parse(_header, System.Globalization.CultureInfo.InvariantCulture);
                        }
                        if (response.Headers.TryGetValue("x-ms-file-change-time", out _header))
                        {
                            _value.FileChangeTime = System.DateTimeOffset.Parse(_header, System.Globalization.CultureInfo.InvariantCulture);
                        }
                        if (response.Headers.TryGetValue("x-ms-file-permission-key", out _header))
                        {
                            _value.FilePermissionKey = _header;
                        }
                        if (response.Headers.TryGetValue("x-ms-file-id", out _header))
                        {
                            _value.FileId = _header;
                        }
                        if (response.Headers.TryGetValue("x-ms-file-parent-id", out _header))
                        {
                            _value.FileParentId = _header;
                        }

                        // Create the response
                        return Response.FromValue(_value, response);
                    }
                    default:
                    {
                        // Create the result
                        System.Xml.Linq.XDocument _xml = System.Xml.Linq.XDocument.Load(response.ContentStream, System.Xml.Linq.LoadOptions.PreserveWhitespace);
                        Azure.Storage.Files.Models.StorageError _value = Azure.Storage.Files.Models.StorageError.FromXml(_xml.Root);

                        throw _value.CreateException(response);
                    }
                }
            }
            #endregion Directory.GetPropertiesAsync

            #region Directory.DeleteAsync
            /// <summary>
            /// Removes the specified empty directory. Note that the directory must be empty before it can be deleted.
            /// </summary>
            /// <param name="pipeline">The pipeline used for sending requests.</param>
            /// <param name="resourceUri">The URL of the service account, share, directory or file that is the target of the desired operation.</param>
            /// <param name="timeout">The timeout parameter is expressed in seconds. For more information, see <a href="https://docs.microsoft.com/en-us/rest/api/storageservices/Setting-Timeouts-for-File-Service-Operations?redirectedfrom=MSDN">Setting Timeouts for File Service Operations.</a></param>
            /// <param name="async">Whether to invoke the operation asynchronously.  The default value is true.</param>
            /// <param name="clientDiagnostics">The ClientDiagnostics instance used for operation reporting.</param>
            /// <param name="operationName">Operation name.</param>
            /// <param name="cancellationToken">Cancellation token.</param>
            /// <returns>Azure.Response</returns>
            public static async System.Threading.Tasks.ValueTask<Azure.Response> DeleteAsync(
                Azure.Core.Pipeline.ClientDiagnostics clientDiagnostics,
                Azure.Core.Pipeline.HttpPipeline pipeline,
                System.Uri resourceUri,
                int? timeout = default,
                bool async = true,
                string operationName = "Azure.Storage.Files.DirectoryClient.Delete",
                System.Threading.CancellationToken cancellationToken = default)
            {
                Azure.Core.Pipeline.DiagnosticScope _scope = clientDiagnostics.CreateScope(operationName);
                try
                {
                    _scope.AddAttribute("url", resourceUri);
                    _scope.Start();
                    using (Azure.Core.HttpMessage _message = DeleteAsync_CreateMessage(
                        pipeline,
                        resourceUri,
                        timeout))
                    {
                        if (async)
                        {
                            // Send the request asynchronously if we're being called via an async path
                            await pipeline.SendAsync(_message, cancellationToken).ConfigureAwait(false);
                        }
                        else
                        {
                            // Send the request synchronously through the API that blocks if we're being called via a sync path
                            // (this is safe because the Task will complete before the user can call Wait)
                            pipeline.Send(_message, cancellationToken);
                        }
                        Azure.Response _response = _message.Response;
                        cancellationToken.ThrowIfCancellationRequested();
                        return DeleteAsync_CreateResponse(_response);
                    }
                }
                catch (System.Exception ex)
                {
                    _scope.Failed(ex);
                    throw;
                }
                finally
                {
                    _scope.Dispose();
                }
            }

            /// <summary>
            /// Create the Directory.DeleteAsync request.
            /// </summary>
            /// <param name="pipeline">The pipeline used for sending requests.</param>
            /// <param name="resourceUri">The URL of the service account, share, directory or file that is the target of the desired operation.</param>
            /// <param name="timeout">The timeout parameter is expressed in seconds. For more information, see <a href="https://docs.microsoft.com/en-us/rest/api/storageservices/Setting-Timeouts-for-File-Service-Operations?redirectedfrom=MSDN">Setting Timeouts for File Service Operations.</a></param>
            /// <returns>The Directory.DeleteAsync Message.</returns>
            internal static Azure.Core.HttpMessage DeleteAsync_CreateMessage(
                Azure.Core.Pipeline.HttpPipeline pipeline,
                System.Uri resourceUri,
                int? timeout = default)
            {
                // Validation
                if (resourceUri == null)
                {
                    throw new System.ArgumentNullException(nameof(resourceUri));
                }

                // Create the request
                Azure.Core.HttpMessage _message = pipeline.CreateMessage();
                Azure.Core.Request _request = _message.Request;

                // Set the endpoint
                _request.Method = Azure.Core.RequestMethod.Delete;
                _request.Uri.Reset(resourceUri);
                _request.Uri.AppendQuery("restype", "directory");
                if (timeout != null) { _request.Uri.AppendQuery("timeout", System.Uri.EscapeDataString(timeout.Value.ToString(System.Globalization.CultureInfo.InvariantCulture))); }

                // Add request headers
                _request.Headers.SetValue("x-ms-version", "2019-02-02");

                return _message;
            }

            /// <summary>
            /// Create the Directory.DeleteAsync response or throw a failure exception.
            /// </summary>
            /// <param name="response">The raw Response.</param>
            /// <returns>The Directory.DeleteAsync Azure.Response.</returns>
            internal static Azure.Response DeleteAsync_CreateResponse(
                Azure.Response response)
            {
                // Process the response
                switch (response.Status)
                {
                    case 202:
                    {
                        return response;
                    }
                    default:
                    {
                        // Create the result
                        System.Xml.Linq.XDocument _xml = System.Xml.Linq.XDocument.Load(response.ContentStream, System.Xml.Linq.LoadOptions.PreserveWhitespace);
                        Azure.Storage.Files.Models.StorageError _value = Azure.Storage.Files.Models.StorageError.FromXml(_xml.Root);

                        throw _value.CreateException(response);
                    }
                }
            }
            #endregion Directory.DeleteAsync

            #region Directory.SetPropertiesAsync
            /// <summary>
            /// Sets properties on the directory.
            /// </summary>
            /// <param name="pipeline">The pipeline used for sending requests.</param>
            /// <param name="resourceUri">The URL of the service account, share, directory or file that is the target of the desired operation.</param>
            /// <param name="fileAttributes">If specified, the provided file attributes shall be set. Default value: ‘Archive’ for file and ‘Directory’ for directory. ‘None’ can also be specified as default.</param>
            /// <param name="fileCreationTime">Creation time for the file/directory. Default value: Now.</param>
            /// <param name="fileLastWriteTime">Last write time for the file/directory. Default value: Now.</param>
            /// <param name="timeout">The timeout parameter is expressed in seconds. For more information, see <a href="https://docs.microsoft.com/en-us/rest/api/storageservices/Setting-Timeouts-for-File-Service-Operations?redirectedfrom=MSDN">Setting Timeouts for File Service Operations.</a></param>
            /// <param name="filePermission">If specified the permission (security descriptor) shall be set for the directory/file. This header can be used if Permission size is &lt;= 8KB, else x-ms-file-permission-key header shall be used. Default value: Inherit. If SDDL is specified as input, it must have owner, group and dacl. Note: Only one of the x-ms-file-permission or x-ms-file-permission-key should be specified.</param>
            /// <param name="filePermissionKey">Key of the permission to be set for the directory/file. Note: Only one of the x-ms-file-permission or x-ms-file-permission-key should be specified.</param>
            /// <param name="async">Whether to invoke the operation asynchronously.  The default value is true.</param>
            /// <param name="clientDiagnostics">The ClientDiagnostics instance used for operation reporting.</param>
            /// <param name="operationName">Operation name.</param>
            /// <param name="cancellationToken">Cancellation token.</param>
            /// <returns>Azure.Response{Azure.Storage.Files.Models.RawStorageDirectoryInfo}</returns>
            public static async System.Threading.Tasks.ValueTask<Azure.Response<Azure.Storage.Files.Models.RawStorageDirectoryInfo>> SetPropertiesAsync(
                Azure.Core.Pipeline.ClientDiagnostics clientDiagnostics,
                Azure.Core.Pipeline.HttpPipeline pipeline,
                System.Uri resourceUri,
                string fileAttributes,
                string fileCreationTime,
                string fileLastWriteTime,
                int? timeout = default,
                string filePermission = default,
                string filePermissionKey = default,
                bool async = true,
                string operationName = "Azure.Storage.Files.DirectoryClient.SetProperties",
                System.Threading.CancellationToken cancellationToken = default)
            {
                Azure.Core.Pipeline.DiagnosticScope _scope = clientDiagnostics.CreateScope(operationName);
                try
                {
                    _scope.AddAttribute("url", resourceUri);
                    _scope.Start();
                    using (Azure.Core.HttpMessage _message = SetPropertiesAsync_CreateMessage(
                        pipeline,
                        resourceUri,
                        fileAttributes,
                        fileCreationTime,
                        fileLastWriteTime,
                        timeout,
                        filePermission,
                        filePermissionKey))
                    {
                        if (async)
                        {
                            // Send the request asynchronously if we're being called via an async path
                            await pipeline.SendAsync(_message, cancellationToken).ConfigureAwait(false);
                        }
                        else
                        {
                            // Send the request synchronously through the API that blocks if we're being called via a sync path
                            // (this is safe because the Task will complete before the user can call Wait)
                            pipeline.Send(_message, cancellationToken);
                        }
                        Azure.Response _response = _message.Response;
                        cancellationToken.ThrowIfCancellationRequested();
                        return SetPropertiesAsync_CreateResponse(_response);
                    }
                }
                catch (System.Exception ex)
                {
                    _scope.Failed(ex);
                    throw;
                }
                finally
                {
                    _scope.Dispose();
                }
            }

            /// <summary>
            /// Create the Directory.SetPropertiesAsync request.
            /// </summary>
            /// <param name="pipeline">The pipeline used for sending requests.</param>
            /// <param name="resourceUri">The URL of the service account, share, directory or file that is the target of the desired operation.</param>
            /// <param name="fileAttributes">If specified, the provided file attributes shall be set. Default value: ‘Archive’ for file and ‘Directory’ for directory. ‘None’ can also be specified as default.</param>
            /// <param name="fileCreationTime">Creation time for the file/directory. Default value: Now.</param>
            /// <param name="fileLastWriteTime">Last write time for the file/directory. Default value: Now.</param>
            /// <param name="timeout">The timeout parameter is expressed in seconds. For more information, see <a href="https://docs.microsoft.com/en-us/rest/api/storageservices/Setting-Timeouts-for-File-Service-Operations?redirectedfrom=MSDN">Setting Timeouts for File Service Operations.</a></param>
            /// <param name="filePermission">If specified the permission (security descriptor) shall be set for the directory/file. This header can be used if Permission size is &lt;= 8KB, else x-ms-file-permission-key header shall be used. Default value: Inherit. If SDDL is specified as input, it must have owner, group and dacl. Note: Only one of the x-ms-file-permission or x-ms-file-permission-key should be specified.</param>
            /// <param name="filePermissionKey">Key of the permission to be set for the directory/file. Note: Only one of the x-ms-file-permission or x-ms-file-permission-key should be specified.</param>
            /// <returns>The Directory.SetPropertiesAsync Message.</returns>
            internal static Azure.Core.HttpMessage SetPropertiesAsync_CreateMessage(
                Azure.Core.Pipeline.HttpPipeline pipeline,
                System.Uri resourceUri,
                string fileAttributes,
                string fileCreationTime,
                string fileLastWriteTime,
                int? timeout = default,
                string filePermission = default,
                string filePermissionKey = default)
            {
                // Validation
                if (resourceUri == null)
                {
                    throw new System.ArgumentNullException(nameof(resourceUri));
                }
                if (fileAttributes == null)
                {
                    throw new System.ArgumentNullException(nameof(fileAttributes));
                }
                if (fileCreationTime == null)
                {
                    throw new System.ArgumentNullException(nameof(fileCreationTime));
                }
                if (fileLastWriteTime == null)
                {
                    throw new System.ArgumentNullException(nameof(fileLastWriteTime));
                }

                // Create the request
                Azure.Core.HttpMessage _message = pipeline.CreateMessage();
                Azure.Core.Request _request = _message.Request;

                // Set the endpoint
                _request.Method = Azure.Core.RequestMethod.Put;
                _request.Uri.Reset(resourceUri);
                _request.Uri.AppendQuery("restype", "directory");
                _request.Uri.AppendQuery("comp", "properties");
                if (timeout != null) { _request.Uri.AppendQuery("timeout", System.Uri.EscapeDataString(timeout.Value.ToString(System.Globalization.CultureInfo.InvariantCulture))); }

                // Add request headers
                _request.Headers.SetValue("x-ms-version", "2019-02-02");
                _request.Headers.SetValue("x-ms-file-attributes", fileAttributes);
                _request.Headers.SetValue("x-ms-file-creation-time", fileCreationTime);
                _request.Headers.SetValue("x-ms-file-last-write-time", fileLastWriteTime);
                if (filePermission != null) { _request.Headers.SetValue("x-ms-file-permission", filePermission); }
                if (filePermissionKey != null) { _request.Headers.SetValue("x-ms-file-permission-key", filePermissionKey); }

                return _message;
            }

            /// <summary>
            /// Create the Directory.SetPropertiesAsync response or throw a failure exception.
            /// </summary>
            /// <param name="response">The raw Response.</param>
            /// <returns>The Directory.SetPropertiesAsync Azure.Response{Azure.Storage.Files.Models.RawStorageDirectoryInfo}.</returns>
            internal static Azure.Response<Azure.Storage.Files.Models.RawStorageDirectoryInfo> SetPropertiesAsync_CreateResponse(
                Azure.Response response)
            {
                // Process the response
                switch (response.Status)
                {
                    case 200:
                    {
                        // Create the result
                        Azure.Storage.Files.Models.RawStorageDirectoryInfo _value = new Azure.Storage.Files.Models.RawStorageDirectoryInfo();

                        // Get response headers
                        string _header;
                        if (response.Headers.TryGetValue("ETag", out _header))
                        {
                            _value.ETag = new Azure.ETag(_header);
                        }
                        if (response.Headers.TryGetValue("Last-Modified", out _header))
                        {
                            _value.LastModified = System.DateTimeOffset.Parse(_header, System.Globalization.CultureInfo.InvariantCulture);
                        }
                        if (response.Headers.TryGetValue("x-ms-file-permission-key", out _header))
                        {
                            _value.FilePermissionKey = _header;
                        }
                        if (response.Headers.TryGetValue("x-ms-file-attributes", out _header))
                        {
                            _value.FileAttributes = _header;
                        }
                        if (response.Headers.TryGetValue("x-ms-file-creation-time", out _header))
                        {
                            _value.FileCreationTime = System.DateTimeOffset.Parse(_header, System.Globalization.CultureInfo.InvariantCulture);
                        }
                        if (response.Headers.TryGetValue("x-ms-file-last-write-time", out _header))
                        {
                            _value.FileLastWriteTime = System.DateTimeOffset.Parse(_header, System.Globalization.CultureInfo.InvariantCulture);
                        }
                        if (response.Headers.TryGetValue("x-ms-file-change-time", out _header))
                        {
                            _value.FileChangeTime = System.DateTimeOffset.Parse(_header, System.Globalization.CultureInfo.InvariantCulture);
                        }
                        if (response.Headers.TryGetValue("x-ms-file-id", out _header))
                        {
                            _value.FileId = _header;
                        }
                        if (response.Headers.TryGetValue("x-ms-file-parent-id", out _header))
                        {
                            _value.FileParentId = _header;
                        }

                        // Create the response
                        return Response.FromValue(_value, response);
                    }
                    default:
                    {
                        // Create the result
                        System.Xml.Linq.XDocument _xml = System.Xml.Linq.XDocument.Load(response.ContentStream, System.Xml.Linq.LoadOptions.PreserveWhitespace);
                        Azure.Storage.Files.Models.StorageError _value = Azure.Storage.Files.Models.StorageError.FromXml(_xml.Root);

                        throw _value.CreateException(response);
                    }
                }
            }
            #endregion Directory.SetPropertiesAsync

            #region Directory.SetMetadataAsync
            /// <summary>
            /// Updates user defined metadata for the specified directory.
            /// </summary>
            /// <param name="pipeline">The pipeline used for sending requests.</param>
            /// <param name="resourceUri">The URL of the service account, share, directory or file that is the target of the desired operation.</param>
            /// <param name="timeout">The timeout parameter is expressed in seconds. For more information, see <a href="https://docs.microsoft.com/en-us/rest/api/storageservices/Setting-Timeouts-for-File-Service-Operations?redirectedfrom=MSDN">Setting Timeouts for File Service Operations.</a></param>
            /// <param name="metadata">A name-value pair to associate with a file storage object.</param>
            /// <param name="async">Whether to invoke the operation asynchronously.  The default value is true.</param>
            /// <param name="clientDiagnostics">The ClientDiagnostics instance used for operation reporting.</param>
            /// <param name="operationName">Operation name.</param>
            /// <param name="cancellationToken">Cancellation token.</param>
            /// <returns>Azure.Response{Azure.Storage.Files.Models.RawStorageDirectoryInfo}</returns>
            public static async System.Threading.Tasks.ValueTask<Azure.Response<Azure.Storage.Files.Models.RawStorageDirectoryInfo>> SetMetadataAsync(
                Azure.Core.Pipeline.ClientDiagnostics clientDiagnostics,
                Azure.Core.Pipeline.HttpPipeline pipeline,
                System.Uri resourceUri,
                int? timeout = default,
                System.Collections.Generic.IDictionary<string, string> metadata = default,
                bool async = true,
                string operationName = "Azure.Storage.Files.DirectoryClient.SetMetadata",
                System.Threading.CancellationToken cancellationToken = default)
            {
                Azure.Core.Pipeline.DiagnosticScope _scope = clientDiagnostics.CreateScope(operationName);
                try
                {
                    _scope.AddAttribute("url", resourceUri);
                    _scope.Start();
                    using (Azure.Core.HttpMessage _message = SetMetadataAsync_CreateMessage(
                        pipeline,
                        resourceUri,
                        timeout,
                        metadata))
                    {
                        if (async)
                        {
                            // Send the request asynchronously if we're being called via an async path
                            await pipeline.SendAsync(_message, cancellationToken).ConfigureAwait(false);
                        }
                        else
                        {
                            // Send the request synchronously through the API that blocks if we're being called via a sync path
                            // (this is safe because the Task will complete before the user can call Wait)
                            pipeline.Send(_message, cancellationToken);
                        }
                        Azure.Response _response = _message.Response;
                        cancellationToken.ThrowIfCancellationRequested();
                        return SetMetadataAsync_CreateResponse(_response);
                    }
                }
                catch (System.Exception ex)
                {
                    _scope.Failed(ex);
                    throw;
                }
                finally
                {
                    _scope.Dispose();
                }
            }

            /// <summary>
            /// Create the Directory.SetMetadataAsync request.
            /// </summary>
            /// <param name="pipeline">The pipeline used for sending requests.</param>
            /// <param name="resourceUri">The URL of the service account, share, directory or file that is the target of the desired operation.</param>
            /// <param name="timeout">The timeout parameter is expressed in seconds. For more information, see <a href="https://docs.microsoft.com/en-us/rest/api/storageservices/Setting-Timeouts-for-File-Service-Operations?redirectedfrom=MSDN">Setting Timeouts for File Service Operations.</a></param>
            /// <param name="metadata">A name-value pair to associate with a file storage object.</param>
            /// <returns>The Directory.SetMetadataAsync Message.</returns>
            internal static Azure.Core.HttpMessage SetMetadataAsync_CreateMessage(
                Azure.Core.Pipeline.HttpPipeline pipeline,
                System.Uri resourceUri,
                int? timeout = default,
                System.Collections.Generic.IDictionary<string, string> metadata = default)
            {
                // Validation
                if (resourceUri == null)
                {
                    throw new System.ArgumentNullException(nameof(resourceUri));
                }

                // Create the request
                Azure.Core.HttpMessage _message = pipeline.CreateMessage();
                Azure.Core.Request _request = _message.Request;

                // Set the endpoint
                _request.Method = Azure.Core.RequestMethod.Put;
                _request.Uri.Reset(resourceUri);
                _request.Uri.AppendQuery("restype", "directory");
                _request.Uri.AppendQuery("comp", "metadata");
                if (timeout != null) { _request.Uri.AppendQuery("timeout", System.Uri.EscapeDataString(timeout.Value.ToString(System.Globalization.CultureInfo.InvariantCulture))); }

                // Add request headers
                _request.Headers.SetValue("x-ms-version", "2019-02-02");
                if (metadata != null) {
                    foreach (System.Collections.Generic.KeyValuePair<string, string> _pair in metadata)
                    {
                        _request.Headers.SetValue("x-ms-meta-" + _pair.Key, _pair.Value);
                    }
                }

                return _message;
            }

            /// <summary>
            /// Create the Directory.SetMetadataAsync response or throw a failure exception.
            /// </summary>
            /// <param name="response">The raw Response.</param>
            /// <returns>The Directory.SetMetadataAsync Azure.Response{Azure.Storage.Files.Models.RawStorageDirectoryInfo}.</returns>
            internal static Azure.Response<Azure.Storage.Files.Models.RawStorageDirectoryInfo> SetMetadataAsync_CreateResponse(
                Azure.Response response)
            {
                // Process the response
                switch (response.Status)
                {
                    case 200:
                    {
                        // Create the result
                        Azure.Storage.Files.Models.RawStorageDirectoryInfo _value = new Azure.Storage.Files.Models.RawStorageDirectoryInfo();

                        // Get response headers
                        string _header;
                        if (response.Headers.TryGetValue("ETag", out _header))
                        {
                            _value.ETag = new Azure.ETag(_header);
                        }
                        if (response.Headers.TryGetValue("Last-Modified", out _header))
                        {
                            _value.LastModified = System.DateTimeOffset.Parse(_header, System.Globalization.CultureInfo.InvariantCulture);
                        }

                        // Create the response
                        return Response.FromValue(_value, response);
                    }
                    default:
                    {
                        // Create the result
                        System.Xml.Linq.XDocument _xml = System.Xml.Linq.XDocument.Load(response.ContentStream, System.Xml.Linq.LoadOptions.PreserveWhitespace);
                        Azure.Storage.Files.Models.StorageError _value = Azure.Storage.Files.Models.StorageError.FromXml(_xml.Root);

                        throw _value.CreateException(response);
                    }
                }
            }
            #endregion Directory.SetMetadataAsync

            #region Directory.ListFilesAndDirectoriesSegmentAsync
            /// <summary>
            /// Returns a list of files or directories under the specified share or directory. It lists the contents only for a single level of the directory hierarchy.
            /// </summary>
            /// <param name="pipeline">The pipeline used for sending requests.</param>
            /// <param name="resourceUri">The URL of the service account, share, directory or file that is the target of the desired operation.</param>
            /// <param name="prefix">Filters the results to return only entries whose name begins with the specified prefix.</param>
            /// <param name="sharesnapshot">The snapshot parameter is an opaque DateTime value that, when present, specifies the share snapshot to query.</param>
            /// <param name="marker">A string value that identifies the portion of the list to be returned with the next list operation. The operation returns a marker value within the response body if the list returned was not complete. The marker value may then be used in a subsequent call to request the next set of list items. The marker value is opaque to the client.</param>
            /// <param name="maxresults">Specifies the maximum number of entries to return. If the request does not specify maxresults, or specifies a value greater than 5,000, the server will return up to 5,000 items.</param>
            /// <param name="timeout">The timeout parameter is expressed in seconds. For more information, see <a href="https://docs.microsoft.com/en-us/rest/api/storageservices/Setting-Timeouts-for-File-Service-Operations?redirectedfrom=MSDN">Setting Timeouts for File Service Operations.</a></param>
            /// <param name="async">Whether to invoke the operation asynchronously.  The default value is true.</param>
            /// <param name="clientDiagnostics">The ClientDiagnostics instance used for operation reporting.</param>
            /// <param name="operationName">Operation name.</param>
            /// <param name="cancellationToken">Cancellation token.</param>
            /// <returns>An enumeration of directories and files.</returns>
            public static async System.Threading.Tasks.ValueTask<Azure.Response<Azure.Storage.Files.Models.FilesAndDirectoriesSegment>> ListFilesAndDirectoriesSegmentAsync(
                Azure.Core.Pipeline.ClientDiagnostics clientDiagnostics,
                Azure.Core.Pipeline.HttpPipeline pipeline,
                System.Uri resourceUri,
                string prefix = default,
                string sharesnapshot = default,
                string marker = default,
                int? maxresults = default,
                int? timeout = default,
                bool async = true,
                string operationName = "Azure.Storage.Files.DirectoryClient.ListFilesAndDirectoriesSegment",
                System.Threading.CancellationToken cancellationToken = default)
            {
                Azure.Core.Pipeline.DiagnosticScope _scope = clientDiagnostics.CreateScope(operationName);
                try
                {
                    _scope.AddAttribute("url", resourceUri);
                    _scope.Start();
                    using (Azure.Core.HttpMessage _message = ListFilesAndDirectoriesSegmentAsync_CreateMessage(
                        pipeline,
                        resourceUri,
                        prefix,
                        sharesnapshot,
                        marker,
                        maxresults,
                        timeout))
                    {
                        if (async)
                        {
                            // Send the request asynchronously if we're being called via an async path
                            await pipeline.SendAsync(_message, cancellationToken).ConfigureAwait(false);
                        }
                        else
                        {
                            // Send the request synchronously through the API that blocks if we're being called via a sync path
                            // (this is safe because the Task will complete before the user can call Wait)
                            pipeline.Send(_message, cancellationToken);
                        }
                        Azure.Response _response = _message.Response;
                        cancellationToken.ThrowIfCancellationRequested();
                        return ListFilesAndDirectoriesSegmentAsync_CreateResponse(_response);
                    }
                }
                catch (System.Exception ex)
                {
                    _scope.Failed(ex);
                    throw;
                }
                finally
                {
                    _scope.Dispose();
                }
            }

            /// <summary>
            /// Create the Directory.ListFilesAndDirectoriesSegmentAsync request.
            /// </summary>
            /// <param name="pipeline">The pipeline used for sending requests.</param>
            /// <param name="resourceUri">The URL of the service account, share, directory or file that is the target of the desired operation.</param>
            /// <param name="prefix">Filters the results to return only entries whose name begins with the specified prefix.</param>
            /// <param name="sharesnapshot">The snapshot parameter is an opaque DateTime value that, when present, specifies the share snapshot to query.</param>
            /// <param name="marker">A string value that identifies the portion of the list to be returned with the next list operation. The operation returns a marker value within the response body if the list returned was not complete. The marker value may then be used in a subsequent call to request the next set of list items. The marker value is opaque to the client.</param>
            /// <param name="maxresults">Specifies the maximum number of entries to return. If the request does not specify maxresults, or specifies a value greater than 5,000, the server will return up to 5,000 items.</param>
            /// <param name="timeout">The timeout parameter is expressed in seconds. For more information, see <a href="https://docs.microsoft.com/en-us/rest/api/storageservices/Setting-Timeouts-for-File-Service-Operations?redirectedfrom=MSDN">Setting Timeouts for File Service Operations.</a></param>
            /// <returns>The Directory.ListFilesAndDirectoriesSegmentAsync Message.</returns>
            internal static Azure.Core.HttpMessage ListFilesAndDirectoriesSegmentAsync_CreateMessage(
                Azure.Core.Pipeline.HttpPipeline pipeline,
                System.Uri resourceUri,
                string prefix = default,
                string sharesnapshot = default,
                string marker = default,
                int? maxresults = default,
                int? timeout = default)
            {
                // Validation
                if (resourceUri == null)
                {
                    throw new System.ArgumentNullException(nameof(resourceUri));
                }

                // Create the request
                Azure.Core.HttpMessage _message = pipeline.CreateMessage();
                Azure.Core.Request _request = _message.Request;

                // Set the endpoint
                _request.Method = Azure.Core.RequestMethod.Get;
                _request.Uri.Reset(resourceUri);
                _request.Uri.AppendQuery("restype", "directory");
                _request.Uri.AppendQuery("comp", "list");
                if (prefix != null) { _request.Uri.AppendQuery("prefix", System.Uri.EscapeDataString(prefix)); }
                if (sharesnapshot != null) { _request.Uri.AppendQuery("sharesnapshot", System.Uri.EscapeDataString(sharesnapshot)); }
                if (marker != null) { _request.Uri.AppendQuery("marker", System.Uri.EscapeDataString(marker)); }
                if (maxresults != null) { _request.Uri.AppendQuery("maxresults", System.Uri.EscapeDataString(maxresults.Value.ToString(System.Globalization.CultureInfo.InvariantCulture))); }
                if (timeout != null) { _request.Uri.AppendQuery("timeout", System.Uri.EscapeDataString(timeout.Value.ToString(System.Globalization.CultureInfo.InvariantCulture))); }

                // Add request headers
                _request.Headers.SetValue("x-ms-version", "2019-02-02");

                return _message;
            }

            /// <summary>
            /// Create the Directory.ListFilesAndDirectoriesSegmentAsync response or throw a failure exception.
            /// </summary>
            /// <param name="response">The raw Response.</param>
            /// <returns>The Directory.ListFilesAndDirectoriesSegmentAsync Azure.Response{Azure.Storage.Files.Models.FilesAndDirectoriesSegment}.</returns>
            internal static Azure.Response<Azure.Storage.Files.Models.FilesAndDirectoriesSegment> ListFilesAndDirectoriesSegmentAsync_CreateResponse(
                Azure.Response response)
            {
                // Process the response
                switch (response.Status)
                {
                    case 200:
                    {
                        // Create the result
                        System.Xml.Linq.XDocument _xml = System.Xml.Linq.XDocument.Load(response.ContentStream, System.Xml.Linq.LoadOptions.PreserveWhitespace);
                        Azure.Storage.Files.Models.FilesAndDirectoriesSegment _value = Azure.Storage.Files.Models.FilesAndDirectoriesSegment.FromXml(_xml.Root);

                        // Create the response
                        return Response.FromValue(_value, response);
                    }
                    default:
                    {
                        // Create the result
                        System.Xml.Linq.XDocument _xml = System.Xml.Linq.XDocument.Load(response.ContentStream, System.Xml.Linq.LoadOptions.PreserveWhitespace);
                        Azure.Storage.Files.Models.StorageError _value = Azure.Storage.Files.Models.StorageError.FromXml(_xml.Root);

                        throw _value.CreateException(response);
                    }
                }
            }
            #endregion Directory.ListFilesAndDirectoriesSegmentAsync

            #region Directory.ListHandlesAsync
            /// <summary>
            /// Lists handles for directory.
            /// </summary>
            /// <param name="pipeline">The pipeline used for sending requests.</param>
            /// <param name="resourceUri">The URL of the service account, share, directory or file that is the target of the desired operation.</param>
            /// <param name="marker">A string value that identifies the portion of the list to be returned with the next list operation. The operation returns a marker value within the response body if the list returned was not complete. The marker value may then be used in a subsequent call to request the next set of list items. The marker value is opaque to the client.</param>
            /// <param name="maxresults">Specifies the maximum number of entries to return. If the request does not specify maxresults, or specifies a value greater than 5,000, the server will return up to 5,000 items.</param>
            /// <param name="timeout">The timeout parameter is expressed in seconds. For more information, see <a href="https://docs.microsoft.com/en-us/rest/api/storageservices/Setting-Timeouts-for-File-Service-Operations?redirectedfrom=MSDN">Setting Timeouts for File Service Operations.</a></param>
            /// <param name="sharesnapshot">The snapshot parameter is an opaque DateTime value that, when present, specifies the share snapshot to query.</param>
            /// <param name="recursive">Specifies operation should apply to the directory specified in the URI, its files, its subdirectories and their files.</param>
            /// <param name="async">Whether to invoke the operation asynchronously.  The default value is true.</param>
            /// <param name="clientDiagnostics">The ClientDiagnostics instance used for operation reporting.</param>
            /// <param name="operationName">Operation name.</param>
            /// <param name="cancellationToken">Cancellation token.</param>
            /// <returns>An enumeration of handles.</returns>
            public static async System.Threading.Tasks.ValueTask<Azure.Response<Azure.Storage.Files.Models.StorageHandlesSegment>> ListHandlesAsync(
                Azure.Core.Pipeline.ClientDiagnostics clientDiagnostics,
                Azure.Core.Pipeline.HttpPipeline pipeline,
                System.Uri resourceUri,
                string marker = default,
                int? maxresults = default,
                int? timeout = default,
                string sharesnapshot = default,
                bool? recursive = default,
                bool async = true,
                string operationName = "Azure.Storage.Files.DirectoryClient.ListHandles",
                System.Threading.CancellationToken cancellationToken = default)
            {
                Azure.Core.Pipeline.DiagnosticScope _scope = clientDiagnostics.CreateScope(operationName);
                try
                {
                    _scope.AddAttribute("url", resourceUri);
                    _scope.Start();
                    using (Azure.Core.HttpMessage _message = ListHandlesAsync_CreateMessage(
                        pipeline,
                        resourceUri,
                        marker,
                        maxresults,
                        timeout,
                        sharesnapshot,
                        recursive))
                    {
                        if (async)
                        {
                            // Send the request asynchronously if we're being called via an async path
                            await pipeline.SendAsync(_message, cancellationToken).ConfigureAwait(false);
                        }
                        else
                        {
                            // Send the request synchronously through the API that blocks if we're being called via a sync path
                            // (this is safe because the Task will complete before the user can call Wait)
                            pipeline.Send(_message, cancellationToken);
                        }
                        Azure.Response _response = _message.Response;
                        cancellationToken.ThrowIfCancellationRequested();
                        return ListHandlesAsync_CreateResponse(_response);
                    }
                }
                catch (System.Exception ex)
                {
                    _scope.Failed(ex);
                    throw;
                }
                finally
                {
                    _scope.Dispose();
                }
            }

            /// <summary>
            /// Create the Directory.ListHandlesAsync request.
            /// </summary>
            /// <param name="pipeline">The pipeline used for sending requests.</param>
            /// <param name="resourceUri">The URL of the service account, share, directory or file that is the target of the desired operation.</param>
            /// <param name="marker">A string value that identifies the portion of the list to be returned with the next list operation. The operation returns a marker value within the response body if the list returned was not complete. The marker value may then be used in a subsequent call to request the next set of list items. The marker value is opaque to the client.</param>
            /// <param name="maxresults">Specifies the maximum number of entries to return. If the request does not specify maxresults, or specifies a value greater than 5,000, the server will return up to 5,000 items.</param>
            /// <param name="timeout">The timeout parameter is expressed in seconds. For more information, see <a href="https://docs.microsoft.com/en-us/rest/api/storageservices/Setting-Timeouts-for-File-Service-Operations?redirectedfrom=MSDN">Setting Timeouts for File Service Operations.</a></param>
            /// <param name="sharesnapshot">The snapshot parameter is an opaque DateTime value that, when present, specifies the share snapshot to query.</param>
            /// <param name="recursive">Specifies operation should apply to the directory specified in the URI, its files, its subdirectories and their files.</param>
            /// <returns>The Directory.ListHandlesAsync Message.</returns>
            internal static Azure.Core.HttpMessage ListHandlesAsync_CreateMessage(
                Azure.Core.Pipeline.HttpPipeline pipeline,
                System.Uri resourceUri,
                string marker = default,
                int? maxresults = default,
                int? timeout = default,
                string sharesnapshot = default,
                bool? recursive = default)
            {
                // Validation
                if (resourceUri == null)
                {
                    throw new System.ArgumentNullException(nameof(resourceUri));
                }

                // Create the request
                Azure.Core.HttpMessage _message = pipeline.CreateMessage();
                Azure.Core.Request _request = _message.Request;

                // Set the endpoint
                _request.Method = Azure.Core.RequestMethod.Get;
                _request.Uri.Reset(resourceUri);
                _request.Uri.AppendQuery("comp", "listhandles");
                if (marker != null) { _request.Uri.AppendQuery("marker", System.Uri.EscapeDataString(marker)); }
                if (maxresults != null) { _request.Uri.AppendQuery("maxresults", System.Uri.EscapeDataString(maxresults.Value.ToString(System.Globalization.CultureInfo.InvariantCulture))); }
                if (timeout != null) { _request.Uri.AppendQuery("timeout", System.Uri.EscapeDataString(timeout.Value.ToString(System.Globalization.CultureInfo.InvariantCulture))); }
                if (sharesnapshot != null) { _request.Uri.AppendQuery("sharesnapshot", System.Uri.EscapeDataString(sharesnapshot)); }

                // Add request headers
                _request.Headers.SetValue("x-ms-version", "2019-02-02");
                if (recursive != null) {
                #pragma warning disable CA1308 // Normalize strings to uppercase
                _request.Headers.SetValue("x-ms-recursive", recursive.Value.ToString(System.Globalization.CultureInfo.InvariantCulture).ToLowerInvariant());
                #pragma warning restore CA1308 // Normalize strings to uppercase
                }

                return _message;
            }

            /// <summary>
            /// Create the Directory.ListHandlesAsync response or throw a failure exception.
            /// </summary>
            /// <param name="response">The raw Response.</param>
            /// <returns>The Directory.ListHandlesAsync Azure.Response{Azure.Storage.Files.Models.StorageHandlesSegment}.</returns>
            internal static Azure.Response<Azure.Storage.Files.Models.StorageHandlesSegment> ListHandlesAsync_CreateResponse(
                Azure.Response response)
            {
                // Process the response
                switch (response.Status)
                {
                    case 200:
                    {
                        // Create the result
                        System.Xml.Linq.XDocument _xml = System.Xml.Linq.XDocument.Load(response.ContentStream, System.Xml.Linq.LoadOptions.PreserveWhitespace);
                        Azure.Storage.Files.Models.StorageHandlesSegment _value = Azure.Storage.Files.Models.StorageHandlesSegment.FromXml(_xml.Root);

                        // Create the response
                        return Response.FromValue(_value, response);
                    }
                    default:
                    {
                        // Create the result
                        System.Xml.Linq.XDocument _xml = System.Xml.Linq.XDocument.Load(response.ContentStream, System.Xml.Linq.LoadOptions.PreserveWhitespace);
                        Azure.Storage.Files.Models.StorageError _value = Azure.Storage.Files.Models.StorageError.FromXml(_xml.Root);

                        throw _value.CreateException(response);
                    }
                }
            }
            #endregion Directory.ListHandlesAsync

            #region Directory.ForceCloseHandlesAsync
            /// <summary>
            /// Closes all handles open for given directory.
            /// </summary>
            /// <param name="pipeline">The pipeline used for sending requests.</param>
            /// <param name="resourceUri">The URL of the service account, share, directory or file that is the target of the desired operation.</param>
            /// <param name="handleId">Specifies handle ID opened on the file or directory to be closed. Asterix (‘*’) is a wildcard that specifies all handles.</param>
            /// <param name="timeout">The timeout parameter is expressed in seconds. For more information, see <a href="https://docs.microsoft.com/en-us/rest/api/storageservices/Setting-Timeouts-for-File-Service-Operations?redirectedfrom=MSDN">Setting Timeouts for File Service Operations.</a></param>
            /// <param name="marker">A string value that identifies the portion of the list to be returned with the next list operation. The operation returns a marker value within the response body if the list returned was not complete. The marker value may then be used in a subsequent call to request the next set of list items. The marker value is opaque to the client.</param>
            /// <param name="sharesnapshot">The snapshot parameter is an opaque DateTime value that, when present, specifies the share snapshot to query.</param>
            /// <param name="recursive">Specifies operation should apply to the directory specified in the URI, its files, its subdirectories and their files.</param>
            /// <param name="async">Whether to invoke the operation asynchronously.  The default value is true.</param>
            /// <param name="clientDiagnostics">The ClientDiagnostics instance used for operation reporting.</param>
            /// <param name="operationName">Operation name.</param>
            /// <param name="cancellationToken">Cancellation token.</param>
            /// <returns>Azure.Response{Azure.Storage.Files.Models.StorageClosedHandlesSegment}</returns>
            public static async System.Threading.Tasks.ValueTask<Azure.Response<Azure.Storage.Files.Models.StorageClosedHandlesSegment>> ForceCloseHandlesAsync(
                Azure.Core.Pipeline.ClientDiagnostics clientDiagnostics,
                Azure.Core.Pipeline.HttpPipeline pipeline,
                System.Uri resourceUri,
                string handleId,
                int? timeout = default,
                string marker = default,
                string sharesnapshot = default,
                bool? recursive = default,
                bool async = true,
                string operationName = "Azure.Storage.Files.DirectoryClient.ForceCloseHandles",
                System.Threading.CancellationToken cancellationToken = default)
            {
                Azure.Core.Pipeline.DiagnosticScope _scope = clientDiagnostics.CreateScope(operationName);
                try
                {
                    _scope.AddAttribute("url", resourceUri);
                    _scope.Start();
                    using (Azure.Core.HttpMessage _message = ForceCloseHandlesAsync_CreateMessage(
                        pipeline,
                        resourceUri,
                        handleId,
                        timeout,
                        marker,
                        sharesnapshot,
                        recursive))
                    {
                        if (async)
                        {
                            // Send the request asynchronously if we're being called via an async path
                            await pipeline.SendAsync(_message, cancellationToken).ConfigureAwait(false);
                        }
                        else
                        {
                            // Send the request synchronously through the API that blocks if we're being called via a sync path
                            // (this is safe because the Task will complete before the user can call Wait)
                            pipeline.Send(_message, cancellationToken);
                        }
                        Azure.Response _response = _message.Response;
                        cancellationToken.ThrowIfCancellationRequested();
                        return ForceCloseHandlesAsync_CreateResponse(_response);
                    }
                }
                catch (System.Exception ex)
                {
                    _scope.Failed(ex);
                    throw;
                }
                finally
                {
                    _scope.Dispose();
                }
            }

            /// <summary>
            /// Create the Directory.ForceCloseHandlesAsync request.
            /// </summary>
            /// <param name="pipeline">The pipeline used for sending requests.</param>
            /// <param name="resourceUri">The URL of the service account, share, directory or file that is the target of the desired operation.</param>
            /// <param name="handleId">Specifies handle ID opened on the file or directory to be closed. Asterix (‘*’) is a wildcard that specifies all handles.</param>
            /// <param name="timeout">The timeout parameter is expressed in seconds. For more information, see <a href="https://docs.microsoft.com/en-us/rest/api/storageservices/Setting-Timeouts-for-File-Service-Operations?redirectedfrom=MSDN">Setting Timeouts for File Service Operations.</a></param>
            /// <param name="marker">A string value that identifies the portion of the list to be returned with the next list operation. The operation returns a marker value within the response body if the list returned was not complete. The marker value may then be used in a subsequent call to request the next set of list items. The marker value is opaque to the client.</param>
            /// <param name="sharesnapshot">The snapshot parameter is an opaque DateTime value that, when present, specifies the share snapshot to query.</param>
            /// <param name="recursive">Specifies operation should apply to the directory specified in the URI, its files, its subdirectories and their files.</param>
            /// <returns>The Directory.ForceCloseHandlesAsync Message.</returns>
            internal static Azure.Core.HttpMessage ForceCloseHandlesAsync_CreateMessage(
                Azure.Core.Pipeline.HttpPipeline pipeline,
                System.Uri resourceUri,
                string handleId,
                int? timeout = default,
                string marker = default,
                string sharesnapshot = default,
                bool? recursive = default)
            {
                // Validation
                if (resourceUri == null)
                {
                    throw new System.ArgumentNullException(nameof(resourceUri));
                }
                if (handleId == null)
                {
                    throw new System.ArgumentNullException(nameof(handleId));
                }

                // Create the request
                Azure.Core.HttpMessage _message = pipeline.CreateMessage();
                Azure.Core.Request _request = _message.Request;

                // Set the endpoint
                _request.Method = Azure.Core.RequestMethod.Put;
                _request.Uri.Reset(resourceUri);
                _request.Uri.AppendQuery("comp", "forceclosehandles");
                if (timeout != null) { _request.Uri.AppendQuery("timeout", System.Uri.EscapeDataString(timeout.Value.ToString(System.Globalization.CultureInfo.InvariantCulture))); }
                if (marker != null) { _request.Uri.AppendQuery("marker", System.Uri.EscapeDataString(marker)); }
                if (sharesnapshot != null) { _request.Uri.AppendQuery("sharesnapshot", System.Uri.EscapeDataString(sharesnapshot)); }

                // Add request headers
                _request.Headers.SetValue("x-ms-handle-id", handleId);
                _request.Headers.SetValue("x-ms-version", "2019-02-02");
                if (recursive != null) {
                #pragma warning disable CA1308 // Normalize strings to uppercase
                _request.Headers.SetValue("x-ms-recursive", recursive.Value.ToString(System.Globalization.CultureInfo.InvariantCulture).ToLowerInvariant());
                #pragma warning restore CA1308 // Normalize strings to uppercase
                }

                return _message;
            }

            /// <summary>
            /// Create the Directory.ForceCloseHandlesAsync response or throw a failure exception.
            /// </summary>
            /// <param name="response">The raw Response.</param>
            /// <returns>The Directory.ForceCloseHandlesAsync Azure.Response{Azure.Storage.Files.Models.StorageClosedHandlesSegment}.</returns>
            internal static Azure.Response<Azure.Storage.Files.Models.StorageClosedHandlesSegment> ForceCloseHandlesAsync_CreateResponse(
                Azure.Response response)
            {
                // Process the response
                switch (response.Status)
                {
                    case 200:
                    {
                        // Create the result
                        Azure.Storage.Files.Models.StorageClosedHandlesSegment _value = new Azure.Storage.Files.Models.StorageClosedHandlesSegment();

                        // Get response headers
                        string _header;
                        if (response.Headers.TryGetValue("x-ms-marker", out _header))
                        {
                            _value.Marker = _header;
                        }
                        if (response.Headers.TryGetValue("x-ms-number-of-handles-closed", out _header))
                        {
                            _value.NumberOfHandlesClosed = int.Parse(_header, System.Globalization.CultureInfo.InvariantCulture);
                        }

                        // Create the response
                        return Response.FromValue(_value, response);
                    }
                    default:
                    {
                        // Create the result
                        System.Xml.Linq.XDocument _xml = System.Xml.Linq.XDocument.Load(response.ContentStream, System.Xml.Linq.LoadOptions.PreserveWhitespace);
                        Azure.Storage.Files.Models.StorageError _value = Azure.Storage.Files.Models.StorageError.FromXml(_xml.Root);

                        throw _value.CreateException(response);
                    }
                }
            }
            #endregion Directory.ForceCloseHandlesAsync
        }
        #endregion Directory operations

        #region File operations
        /// <summary>
        /// File operations for Azure File Storage
        /// </summary>
        public static partial class File
        {
            #region File.CreateAsync
            /// <summary>
            /// Creates a new file or replaces a file. Note it only initializes the file with no content.
            /// </summary>
            /// <param name="pipeline">The pipeline used for sending requests.</param>
            /// <param name="resourceUri">The URL of the service account, share, directory or file that is the target of the desired operation.</param>
            /// <param name="fileContentLength">Specifies the maximum size for the file, up to 1 TB.</param>
            /// <param name="fileAttributes">If specified, the provided file attributes shall be set. Default value: ‘Archive’ for file and ‘Directory’ for directory. ‘None’ can also be specified as default.</param>
            /// <param name="fileCreationTime">Creation time for the file/directory. Default value: Now.</param>
            /// <param name="fileLastWriteTime">Last write time for the file/directory. Default value: Now.</param>
            /// <param name="timeout">The timeout parameter is expressed in seconds. For more information, see <a href="https://docs.microsoft.com/en-us/rest/api/storageservices/Setting-Timeouts-for-File-Service-Operations?redirectedfrom=MSDN">Setting Timeouts for File Service Operations.</a></param>
            /// <param name="fileContentType">Sets the MIME content type of the file. The default type is 'application/octet-stream'.</param>
            /// <param name="fileContentEncoding">Specifies which content encodings have been applied to the file.</param>
            /// <param name="fileContentLanguage">Specifies the natural languages used by this resource.</param>
            /// <param name="fileCacheControl">Sets the file's cache control. The File service stores this value but does not use or modify it.</param>
            /// <param name="fileContentHash">Sets the file's MD5 hash.</param>
            /// <param name="fileContentDisposition">Sets the file's Content-Disposition header.</param>
            /// <param name="metadata">A name-value pair to associate with a file storage object.</param>
            /// <param name="filePermission">If specified the permission (security descriptor) shall be set for the directory/file. This header can be used if Permission size is &lt;= 8KB, else x-ms-file-permission-key header shall be used. Default value: Inherit. If SDDL is specified as input, it must have owner, group and dacl. Note: Only one of the x-ms-file-permission or x-ms-file-permission-key should be specified.</param>
            /// <param name="filePermissionKey">Key of the permission to be set for the directory/file. Note: Only one of the x-ms-file-permission or x-ms-file-permission-key should be specified.</param>
            /// <param name="async">Whether to invoke the operation asynchronously.  The default value is true.</param>
            /// <param name="clientDiagnostics">The ClientDiagnostics instance used for operation reporting.</param>
            /// <param name="operationName">Operation name.</param>
            /// <param name="cancellationToken">Cancellation token.</param>
            /// <returns>Azure.Response{Azure.Storage.Files.Models.RawStorageFileInfo}</returns>
            public static async System.Threading.Tasks.ValueTask<Azure.Response<Azure.Storage.Files.Models.RawStorageFileInfo>> CreateAsync(
                Azure.Core.Pipeline.ClientDiagnostics clientDiagnostics,
                Azure.Core.Pipeline.HttpPipeline pipeline,
                System.Uri resourceUri,
                long fileContentLength,
                string fileAttributes,
                string fileCreationTime,
                string fileLastWriteTime,
                int? timeout = default,
                string fileContentType = default,
                System.Collections.Generic.IEnumerable<string> fileContentEncoding = default,
                System.Collections.Generic.IEnumerable<string> fileContentLanguage = default,
                string fileCacheControl = default,
                byte[] fileContentHash = default,
                string fileContentDisposition = default,
                System.Collections.Generic.IDictionary<string, string> metadata = default,
                string filePermission = default,
                string filePermissionKey = default,
                bool async = true,
                string operationName = "Azure.Storage.Files.FileClient.Create",
                System.Threading.CancellationToken cancellationToken = default)
            {
                Azure.Core.Pipeline.DiagnosticScope _scope = clientDiagnostics.CreateScope(operationName);
                try
                {
                    _scope.AddAttribute("url", resourceUri);
                    _scope.Start();
                    using (Azure.Core.HttpMessage _message = CreateAsync_CreateMessage(
                        pipeline,
                        resourceUri,
                        fileContentLength,
                        fileAttributes,
                        fileCreationTime,
                        fileLastWriteTime,
                        timeout,
                        fileContentType,
                        fileContentEncoding,
                        fileContentLanguage,
                        fileCacheControl,
                        fileContentHash,
                        fileContentDisposition,
                        metadata,
                        filePermission,
                        filePermissionKey))
                    {
                        if (async)
                        {
                            // Send the request asynchronously if we're being called via an async path
                            await pipeline.SendAsync(_message, cancellationToken).ConfigureAwait(false);
                        }
                        else
                        {
                            // Send the request synchronously through the API that blocks if we're being called via a sync path
                            // (this is safe because the Task will complete before the user can call Wait)
                            pipeline.Send(_message, cancellationToken);
                        }
                        Azure.Response _response = _message.Response;
                        cancellationToken.ThrowIfCancellationRequested();
                        return CreateAsync_CreateResponse(_response);
                    }
                }
                catch (System.Exception ex)
                {
                    _scope.Failed(ex);
                    throw;
                }
                finally
                {
                    _scope.Dispose();
                }
            }

            /// <summary>
            /// Create the File.CreateAsync request.
            /// </summary>
            /// <param name="pipeline">The pipeline used for sending requests.</param>
            /// <param name="resourceUri">The URL of the service account, share, directory or file that is the target of the desired operation.</param>
            /// <param name="fileContentLength">Specifies the maximum size for the file, up to 1 TB.</param>
            /// <param name="fileAttributes">If specified, the provided file attributes shall be set. Default value: ‘Archive’ for file and ‘Directory’ for directory. ‘None’ can also be specified as default.</param>
            /// <param name="fileCreationTime">Creation time for the file/directory. Default value: Now.</param>
            /// <param name="fileLastWriteTime">Last write time for the file/directory. Default value: Now.</param>
            /// <param name="timeout">The timeout parameter is expressed in seconds. For more information, see <a href="https://docs.microsoft.com/en-us/rest/api/storageservices/Setting-Timeouts-for-File-Service-Operations?redirectedfrom=MSDN">Setting Timeouts for File Service Operations.</a></param>
            /// <param name="fileContentType">Sets the MIME content type of the file. The default type is 'application/octet-stream'.</param>
            /// <param name="fileContentEncoding">Specifies which content encodings have been applied to the file.</param>
            /// <param name="fileContentLanguage">Specifies the natural languages used by this resource.</param>
            /// <param name="fileCacheControl">Sets the file's cache control. The File service stores this value but does not use or modify it.</param>
            /// <param name="fileContentHash">Sets the file's MD5 hash.</param>
            /// <param name="fileContentDisposition">Sets the file's Content-Disposition header.</param>
            /// <param name="metadata">A name-value pair to associate with a file storage object.</param>
            /// <param name="filePermission">If specified the permission (security descriptor) shall be set for the directory/file. This header can be used if Permission size is &lt;= 8KB, else x-ms-file-permission-key header shall be used. Default value: Inherit. If SDDL is specified as input, it must have owner, group and dacl. Note: Only one of the x-ms-file-permission or x-ms-file-permission-key should be specified.</param>
            /// <param name="filePermissionKey">Key of the permission to be set for the directory/file. Note: Only one of the x-ms-file-permission or x-ms-file-permission-key should be specified.</param>
            /// <returns>The File.CreateAsync Message.</returns>
            internal static Azure.Core.HttpMessage CreateAsync_CreateMessage(
                Azure.Core.Pipeline.HttpPipeline pipeline,
                System.Uri resourceUri,
                long fileContentLength,
                string fileAttributes,
                string fileCreationTime,
                string fileLastWriteTime,
                int? timeout = default,
                string fileContentType = default,
                System.Collections.Generic.IEnumerable<string> fileContentEncoding = default,
                System.Collections.Generic.IEnumerable<string> fileContentLanguage = default,
                string fileCacheControl = default,
                byte[] fileContentHash = default,
                string fileContentDisposition = default,
                System.Collections.Generic.IDictionary<string, string> metadata = default,
                string filePermission = default,
                string filePermissionKey = default)
            {
                // Validation
                if (resourceUri == null)
                {
                    throw new System.ArgumentNullException(nameof(resourceUri));
                }
                if (fileAttributes == null)
                {
                    throw new System.ArgumentNullException(nameof(fileAttributes));
                }
                if (fileCreationTime == null)
                {
                    throw new System.ArgumentNullException(nameof(fileCreationTime));
                }
                if (fileLastWriteTime == null)
                {
                    throw new System.ArgumentNullException(nameof(fileLastWriteTime));
                }

                // Create the request
                Azure.Core.HttpMessage _message = pipeline.CreateMessage();
                Azure.Core.Request _request = _message.Request;

                // Set the endpoint
                _request.Method = Azure.Core.RequestMethod.Put;
                _request.Uri.Reset(resourceUri);
                if (timeout != null) { _request.Uri.AppendQuery("timeout", System.Uri.EscapeDataString(timeout.Value.ToString(System.Globalization.CultureInfo.InvariantCulture))); }

                // Add request headers
                _request.Headers.SetValue("x-ms-version", "2019-02-02");
                _request.Headers.SetValue("x-ms-content-length", fileContentLength.ToString(System.Globalization.CultureInfo.InvariantCulture));
                _request.Headers.SetValue("x-ms-type", "file");
                _request.Headers.SetValue("x-ms-file-attributes", fileAttributes);
                _request.Headers.SetValue("x-ms-file-creation-time", fileCreationTime);
                _request.Headers.SetValue("x-ms-file-last-write-time", fileLastWriteTime);
                if (fileContentType != null) { _request.Headers.SetValue("x-ms-content-type", fileContentType); }
                if (fileContentEncoding != null) {
                    foreach (string _item in fileContentEncoding)
                    {
                        _request.Headers.SetValue("x-ms-content-encoding", _item);
                    }
                }
                if (fileContentLanguage != null) {
                    foreach (string _item in fileContentLanguage)
                    {
                        _request.Headers.SetValue("x-ms-content-language", _item);
                    }
                }
                if (fileCacheControl != null) { _request.Headers.SetValue("x-ms-cache-control", fileCacheControl); }
                if (fileContentHash != null) { _request.Headers.SetValue("x-ms-content-md5", System.Convert.ToBase64String(fileContentHash)); }
                if (fileContentDisposition != null) { _request.Headers.SetValue("x-ms-content-disposition", fileContentDisposition); }
                if (metadata != null) {
                    foreach (System.Collections.Generic.KeyValuePair<string, string> _pair in metadata)
                    {
                        _request.Headers.SetValue("x-ms-meta-" + _pair.Key, _pair.Value);
                    }
                }
                if (filePermission != null) { _request.Headers.SetValue("x-ms-file-permission", filePermission); }
                if (filePermissionKey != null) { _request.Headers.SetValue("x-ms-file-permission-key", filePermissionKey); }

                return _message;
            }

            /// <summary>
            /// Create the File.CreateAsync response or throw a failure exception.
            /// </summary>
            /// <param name="response">The raw Response.</param>
            /// <returns>The File.CreateAsync Azure.Response{Azure.Storage.Files.Models.RawStorageFileInfo}.</returns>
            internal static Azure.Response<Azure.Storage.Files.Models.RawStorageFileInfo> CreateAsync_CreateResponse(
                Azure.Response response)
            {
                // Process the response
                switch (response.Status)
                {
                    case 201:
                    {
                        // Create the result
                        Azure.Storage.Files.Models.RawStorageFileInfo _value = new Azure.Storage.Files.Models.RawStorageFileInfo();

                        // Get response headers
                        string _header;
                        if (response.Headers.TryGetValue("ETag", out _header))
                        {
                            _value.ETag = new Azure.ETag(_header);
                        }
                        if (response.Headers.TryGetValue("Last-Modified", out _header))
                        {
                            _value.LastModified = System.DateTimeOffset.Parse(_header, System.Globalization.CultureInfo.InvariantCulture);
                        }
                        if (response.Headers.TryGetValue("x-ms-request-server-encrypted", out _header))
                        {
                            _value.IsServerEncrypted = bool.Parse(_header);
                        }
                        if (response.Headers.TryGetValue("x-ms-file-permission-key", out _header))
                        {
                            _value.FilePermissionKey = _header;
                        }
                        if (response.Headers.TryGetValue("x-ms-file-attributes", out _header))
                        {
                            _value.FileAttributes = _header;
                        }
                        if (response.Headers.TryGetValue("x-ms-file-creation-time", out _header))
                        {
                            _value.FileCreationTime = System.DateTimeOffset.Parse(_header, System.Globalization.CultureInfo.InvariantCulture);
                        }
                        if (response.Headers.TryGetValue("x-ms-file-last-write-time", out _header))
                        {
                            _value.FileLastWriteTime = System.DateTimeOffset.Parse(_header, System.Globalization.CultureInfo.InvariantCulture);
                        }
                        if (response.Headers.TryGetValue("x-ms-file-change-time", out _header))
                        {
                            _value.FileChangeTime = System.DateTimeOffset.Parse(_header, System.Globalization.CultureInfo.InvariantCulture);
                        }
                        if (response.Headers.TryGetValue("x-ms-file-id", out _header))
                        {
                            _value.FileId = _header;
                        }
                        if (response.Headers.TryGetValue("x-ms-file-parent-id", out _header))
                        {
                            _value.FileParentId = _header;
                        }

                        // Create the response
                        return Response.FromValue(_value, response);
                    }
                    default:
                    {
                        // Create the result
                        System.Xml.Linq.XDocument _xml = System.Xml.Linq.XDocument.Load(response.ContentStream, System.Xml.Linq.LoadOptions.PreserveWhitespace);
                        Azure.Storage.Files.Models.StorageError _value = Azure.Storage.Files.Models.StorageError.FromXml(_xml.Root);

                        throw _value.CreateException(response);
                    }
                }
            }
            #endregion File.CreateAsync

            #region File.DownloadAsync
            /// <summary>
            /// Reads or downloads a file from the system, including its metadata and properties.
            /// </summary>
            /// <param name="pipeline">The pipeline used for sending requests.</param>
            /// <param name="resourceUri">The URL of the service account, share, directory or file that is the target of the desired operation.</param>
            /// <param name="timeout">The timeout parameter is expressed in seconds. For more information, see <a href="https://docs.microsoft.com/en-us/rest/api/storageservices/Setting-Timeouts-for-File-Service-Operations?redirectedfrom=MSDN">Setting Timeouts for File Service Operations.</a></param>
            /// <param name="range">Return file data only from the specified byte range.</param>
            /// <param name="rangeGetContentHash">When this header is set to true and specified together with the Range header, the service returns the MD5 hash for the range, as long as the range is less than or equal to 4 MB in size.</param>
            /// <param name="async">Whether to invoke the operation asynchronously.  The default value is true.</param>
            /// <param name="clientDiagnostics">The ClientDiagnostics instance used for operation reporting.</param>
            /// <param name="operationName">Operation name.</param>
            /// <param name="cancellationToken">Cancellation token.</param>
            /// <returns>Azure.Response{Azure.Storage.Files.Models.FlattenedStorageFileProperties}</returns>
            public static async System.Threading.Tasks.ValueTask<(Azure.Response<Azure.Storage.Files.Models.FlattenedStorageFileProperties>, System.IO.Stream)> DownloadAsync(
                Azure.Core.Pipeline.ClientDiagnostics clientDiagnostics,
                Azure.Core.Pipeline.HttpPipeline pipeline,
                System.Uri resourceUri,
                int? timeout = default,
                string range = default,
                bool? rangeGetContentHash = default,
                bool async = true,
                string operationName = "Azure.Storage.Files.FileClient.Download",
                System.Threading.CancellationToken cancellationToken = default)
            {
                Azure.Core.Pipeline.DiagnosticScope _scope = clientDiagnostics.CreateScope(operationName);
                try
                {
                    _scope.AddAttribute("url", resourceUri);
                    _scope.Start();
                    using (Azure.Core.HttpMessage _message = DownloadAsync_CreateMessage(
                        pipeline,
                        resourceUri,
                        timeout,
                        range,
                        rangeGetContentHash))
                    {
                        // Avoid buffering if stream is going to be returned to the caller
                        _message.BufferResponse = false;
                        if (async)
                        {
                            // Send the request asynchronously if we're being called via an async path
                            await pipeline.SendAsync(_message, cancellationToken).ConfigureAwait(false);
                        }
                        else
                        {
                            // Send the request synchronously through the API that blocks if we're being called via a sync path
                            // (this is safe because the Task will complete before the user can call Wait)
                            pipeline.Send(_message, cancellationToken);
                        }
                        Azure.Response _response = _message.Response;
                        cancellationToken.ThrowIfCancellationRequested();
                        return (DownloadAsync_CreateResponse(_response), _message.ExtractResponseContent());
                    }
                }
                catch (System.Exception ex)
                {
                    _scope.Failed(ex);
                    throw;
                }
                finally
                {
                    _scope.Dispose();
                }
            }

            /// <summary>
            /// Create the File.DownloadAsync request.
            /// </summary>
            /// <param name="pipeline">The pipeline used for sending requests.</param>
            /// <param name="resourceUri">The URL of the service account, share, directory or file that is the target of the desired operation.</param>
            /// <param name="timeout">The timeout parameter is expressed in seconds. For more information, see <a href="https://docs.microsoft.com/en-us/rest/api/storageservices/Setting-Timeouts-for-File-Service-Operations?redirectedfrom=MSDN">Setting Timeouts for File Service Operations.</a></param>
            /// <param name="range">Return file data only from the specified byte range.</param>
            /// <param name="rangeGetContentHash">When this header is set to true and specified together with the Range header, the service returns the MD5 hash for the range, as long as the range is less than or equal to 4 MB in size.</param>
            /// <returns>The File.DownloadAsync Message.</returns>
            internal static Azure.Core.HttpMessage DownloadAsync_CreateMessage(
                Azure.Core.Pipeline.HttpPipeline pipeline,
                System.Uri resourceUri,
                int? timeout = default,
                string range = default,
                bool? rangeGetContentHash = default)
            {
                // Validation
                if (resourceUri == null)
                {
                    throw new System.ArgumentNullException(nameof(resourceUri));
                }

                // Create the request
                Azure.Core.HttpMessage _message = pipeline.CreateMessage();
                Azure.Core.Request _request = _message.Request;

                // Set the endpoint
                _request.Method = Azure.Core.RequestMethod.Get;
                _request.Uri.Reset(resourceUri);
                if (timeout != null) { _request.Uri.AppendQuery("timeout", System.Uri.EscapeDataString(timeout.Value.ToString(System.Globalization.CultureInfo.InvariantCulture))); }

                // Add request headers
                _request.Headers.SetValue("x-ms-version", "2019-02-02");
                if (range != null) { _request.Headers.SetValue("x-ms-range", range); }
                if (rangeGetContentHash != null) {
                #pragma warning disable CA1308 // Normalize strings to uppercase
                _request.Headers.SetValue("x-ms-range-get-content-md5", rangeGetContentHash.Value.ToString(System.Globalization.CultureInfo.InvariantCulture).ToLowerInvariant());
                #pragma warning restore CA1308 // Normalize strings to uppercase
                }

                return _message;
            }

            /// <summary>
            /// Create the File.DownloadAsync response or throw a failure exception.
            /// </summary>
            /// <param name="response">The raw Response.</param>
            /// <returns>The File.DownloadAsync Azure.Response{Azure.Storage.Files.Models.FlattenedStorageFileProperties}.</returns>
            internal static Azure.Response<Azure.Storage.Files.Models.FlattenedStorageFileProperties> DownloadAsync_CreateResponse(
                Azure.Response response)
            {
                // Process the response
                switch (response.Status)
                {
                    case 200:
                    {
                        // Create the result
                        Azure.Storage.Files.Models.FlattenedStorageFileProperties _value = new Azure.Storage.Files.Models.FlattenedStorageFileProperties();
                        _value.Content = response.ContentStream; // You should manually wrap with RetriableStream!

                        // Get response headers
                        string _header;
                        if (response.Headers.TryGetValue("Last-Modified", out _header))
                        {
                            _value.LastModified = System.DateTimeOffset.Parse(_header, System.Globalization.CultureInfo.InvariantCulture);
                        }
                        _value.Metadata = new System.Collections.Generic.Dictionary<string, string>(System.StringComparer.OrdinalIgnoreCase);
                        foreach (Azure.Core.HttpHeader _headerPair in response.Headers)
                        {
                            if (_headerPair.Name.StartsWith("x-ms-meta-", System.StringComparison.InvariantCulture))
                            {
                                _value.Metadata[_headerPair.Name.Substring(10)] = _headerPair.Value;
                            }
                        }
                        if (response.Headers.TryGetValue("Content-Length", out _header))
                        {
                            _value.ContentLength = long.Parse(_header, System.Globalization.CultureInfo.InvariantCulture);
                        }
                        if (response.Headers.TryGetValue("Content-Type", out _header))
                        {
                            _value.ContentType = _header;
                        }
                        if (response.Headers.TryGetValue("Content-Range", out _header))
                        {
                            _value.ContentRange = _header;
                        }
                        if (response.Headers.TryGetValue("ETag", out _header))
                        {
                            _value.ETag = new Azure.ETag(_header);
                        }
                        if (response.Headers.TryGetValue("Content-MD5", out _header))
                        {
                            _value.ContentHash = System.Convert.FromBase64String(_header);
                        }
                        if (response.Headers.TryGetValue("Content-Encoding", out _header))
                        {
                            _value.ContentEncoding = (_header ?? "").Split(',');
                        }
                        if (response.Headers.TryGetValue("Cache-Control", out _header))
                        {
                            _value.CacheControl = _header;
                        }
                        if (response.Headers.TryGetValue("Content-Disposition", out _header))
                        {
                            _value.ContentDisposition = _header;
                        }
                        if (response.Headers.TryGetValue("Content-Language", out _header))
                        {
                            _value.ContentLanguage = (_header ?? "").Split(',');
                        }
                        if (response.Headers.TryGetValue("Accept-Ranges", out _header))
                        {
                            _value.AcceptRanges = _header;
                        }
                        if (response.Headers.TryGetValue("x-ms-copy-completion-time", out _header))
                        {
                            _value.CopyCompletionTime = System.DateTimeOffset.Parse(_header, System.Globalization.CultureInfo.InvariantCulture);
                        }
                        if (response.Headers.TryGetValue("x-ms-copy-status-description", out _header))
                        {
                            _value.CopyStatusDescription = _header;
                        }
                        if (response.Headers.TryGetValue("x-ms-copy-id", out _header))
                        {
                            _value.CopyId = _header;
                        }
                        if (response.Headers.TryGetValue("x-ms-copy-progress", out _header))
                        {
                            _value.CopyProgress = _header;
                        }
                        if (response.Headers.TryGetValue("x-ms-copy-source", out _header))
                        {
                            _value.CopySource = new System.Uri(_header);
                        }
                        if (response.Headers.TryGetValue("x-ms-copy-status", out _header))
                        {
                            _value.CopyStatus = Azure.Storage.Files.FileRestClient.Serialization.ParseCopyStatus(_header);
                        }
                        if (response.Headers.TryGetValue("x-ms-content-md5", out _header))
                        {
                            _value.FileContentHash = System.Convert.FromBase64String(_header);
                        }
                        if (response.Headers.TryGetValue("x-ms-server-encrypted", out _header))
                        {
                            _value.IsServerEncrypted = bool.Parse(_header);
                        }
                        if (response.Headers.TryGetValue("x-ms-file-attributes", out _header))
                        {
                            _value.FileAttributes = _header;
                        }
                        if (response.Headers.TryGetValue("x-ms-file-creation-time", out _header))
                        {
                            _value.FileCreationTime = System.DateTimeOffset.Parse(_header, System.Globalization.CultureInfo.InvariantCulture);
                        }
                        if (response.Headers.TryGetValue("x-ms-file-last-write-time", out _header))
                        {
                            _value.FileLastWriteTime = System.DateTimeOffset.Parse(_header, System.Globalization.CultureInfo.InvariantCulture);
                        }
                        if (response.Headers.TryGetValue("x-ms-file-change-time", out _header))
                        {
                            _value.FileChangeTime = System.DateTimeOffset.Parse(_header, System.Globalization.CultureInfo.InvariantCulture);
                        }
                        if (response.Headers.TryGetValue("x-ms-file-permission-key", out _header))
                        {
                            _value.FilePermissionKey = _header;
                        }
                        if (response.Headers.TryGetValue("x-ms-file-id", out _header))
                        {
                            _value.FileId = _header;
                        }
                        if (response.Headers.TryGetValue("x-ms-file-parent-id", out _header))
                        {
                            _value.FileParentId = _header;
                        }

                        // Create the response
                        return Response.FromValue(_value, response);
                    }
                    case 206:
                    {
                        // Create the result
                        Azure.Storage.Files.Models.FlattenedStorageFileProperties _value = new Azure.Storage.Files.Models.FlattenedStorageFileProperties();
                        _value.Content = response.ContentStream; // You should manually wrap with RetriableStream!

                        // Get response headers
                        string _header;
                        if (response.Headers.TryGetValue("Last-Modified", out _header))
                        {
                            _value.LastModified = System.DateTimeOffset.Parse(_header, System.Globalization.CultureInfo.InvariantCulture);
                        }
                        _value.Metadata = new System.Collections.Generic.Dictionary<string, string>(System.StringComparer.OrdinalIgnoreCase);
                        foreach (Azure.Core.HttpHeader _headerPair in response.Headers)
                        {
                            if (_headerPair.Name.StartsWith("x-ms-meta-", System.StringComparison.InvariantCulture))
                            {
                                _value.Metadata[_headerPair.Name.Substring(10)] = _headerPair.Value;
                            }
                        }
                        if (response.Headers.TryGetValue("Content-Length", out _header))
                        {
                            _value.ContentLength = long.Parse(_header, System.Globalization.CultureInfo.InvariantCulture);
                        }
                        if (response.Headers.TryGetValue("Content-Type", out _header))
                        {
                            _value.ContentType = _header;
                        }
                        if (response.Headers.TryGetValue("Content-Range", out _header))
                        {
                            _value.ContentRange = _header;
                        }
                        if (response.Headers.TryGetValue("ETag", out _header))
                        {
                            _value.ETag = new Azure.ETag(_header);
                        }
                        if (response.Headers.TryGetValue("Content-MD5", out _header))
                        {
                            _value.ContentHash = System.Convert.FromBase64String(_header);
                        }
                        if (response.Headers.TryGetValue("Content-Encoding", out _header))
                        {
                            _value.ContentEncoding = (_header ?? "").Split(',');
                        }
                        if (response.Headers.TryGetValue("Cache-Control", out _header))
                        {
                            _value.CacheControl = _header;
                        }
                        if (response.Headers.TryGetValue("Content-Disposition", out _header))
                        {
                            _value.ContentDisposition = _header;
                        }
                        if (response.Headers.TryGetValue("Content-Language", out _header))
                        {
                            _value.ContentLanguage = (_header ?? "").Split(',');
                        }
                        if (response.Headers.TryGetValue("Accept-Ranges", out _header))
                        {
                            _value.AcceptRanges = _header;
                        }
                        if (response.Headers.TryGetValue("x-ms-copy-completion-time", out _header))
                        {
                            _value.CopyCompletionTime = System.DateTimeOffset.Parse(_header, System.Globalization.CultureInfo.InvariantCulture);
                        }
                        if (response.Headers.TryGetValue("x-ms-copy-status-description", out _header))
                        {
                            _value.CopyStatusDescription = _header;
                        }
                        if (response.Headers.TryGetValue("x-ms-copy-id", out _header))
                        {
                            _value.CopyId = _header;
                        }
                        if (response.Headers.TryGetValue("x-ms-copy-progress", out _header))
                        {
                            _value.CopyProgress = _header;
                        }
                        if (response.Headers.TryGetValue("x-ms-copy-source", out _header))
                        {
                            _value.CopySource = new System.Uri(_header);
                        }
                        if (response.Headers.TryGetValue("x-ms-copy-status", out _header))
                        {
                            _value.CopyStatus = Azure.Storage.Files.FileRestClient.Serialization.ParseCopyStatus(_header);
                        }
                        if (response.Headers.TryGetValue("x-ms-content-md5", out _header))
                        {
                            _value.FileContentHash = System.Convert.FromBase64String(_header);
                        }
                        if (response.Headers.TryGetValue("x-ms-server-encrypted", out _header))
                        {
                            _value.IsServerEncrypted = bool.Parse(_header);
                        }
                        if (response.Headers.TryGetValue("x-ms-file-attributes", out _header))
                        {
                            _value.FileAttributes = _header;
                        }
                        if (response.Headers.TryGetValue("x-ms-file-creation-time", out _header))
                        {
                            _value.FileCreationTime = System.DateTimeOffset.Parse(_header, System.Globalization.CultureInfo.InvariantCulture);
                        }
                        if (response.Headers.TryGetValue("x-ms-file-last-write-time", out _header))
                        {
                            _value.FileLastWriteTime = System.DateTimeOffset.Parse(_header, System.Globalization.CultureInfo.InvariantCulture);
                        }
                        if (response.Headers.TryGetValue("x-ms-file-change-time", out _header))
                        {
                            _value.FileChangeTime = System.DateTimeOffset.Parse(_header, System.Globalization.CultureInfo.InvariantCulture);
                        }
                        if (response.Headers.TryGetValue("x-ms-file-permission-key", out _header))
                        {
                            _value.FilePermissionKey = _header;
                        }
                        if (response.Headers.TryGetValue("x-ms-file-id", out _header))
                        {
                            _value.FileId = _header;
                        }
                        if (response.Headers.TryGetValue("x-ms-file-parent-id", out _header))
                        {
                            _value.FileParentId = _header;
                        }

                        // Create the response
                        return Response.FromValue(_value, response);
                    }
                    default:
                    {
                        // Create the result
                        System.Xml.Linq.XDocument _xml = System.Xml.Linq.XDocument.Load(response.ContentStream, System.Xml.Linq.LoadOptions.PreserveWhitespace);
                        Azure.Storage.Files.Models.StorageError _value = Azure.Storage.Files.Models.StorageError.FromXml(_xml.Root);

                        throw _value.CreateException(response);
                    }
                }
            }
            #endregion File.DownloadAsync

            #region File.GetPropertiesAsync
            /// <summary>
            /// Returns all user-defined metadata, standard HTTP properties, and system properties for the file. It does not return the content of the file.
            /// </summary>
            /// <param name="pipeline">The pipeline used for sending requests.</param>
            /// <param name="resourceUri">The URL of the service account, share, directory or file that is the target of the desired operation.</param>
            /// <param name="sharesnapshot">The snapshot parameter is an opaque DateTime value that, when present, specifies the share snapshot to query.</param>
            /// <param name="timeout">The timeout parameter is expressed in seconds. For more information, see <a href="https://docs.microsoft.com/en-us/rest/api/storageservices/Setting-Timeouts-for-File-Service-Operations?redirectedfrom=MSDN">Setting Timeouts for File Service Operations.</a></param>
            /// <param name="async">Whether to invoke the operation asynchronously.  The default value is true.</param>
            /// <param name="clientDiagnostics">The ClientDiagnostics instance used for operation reporting.</param>
            /// <param name="operationName">Operation name.</param>
            /// <param name="cancellationToken">Cancellation token.</param>
            /// <returns>Azure.Response{Azure.Storage.Files.Models.RawStorageFileProperties}</returns>
            public static async System.Threading.Tasks.ValueTask<Azure.Response<Azure.Storage.Files.Models.RawStorageFileProperties>> GetPropertiesAsync(
                Azure.Core.Pipeline.ClientDiagnostics clientDiagnostics,
                Azure.Core.Pipeline.HttpPipeline pipeline,
                System.Uri resourceUri,
                string sharesnapshot = default,
                int? timeout = default,
                bool async = true,
                string operationName = "Azure.Storage.Files.FileClient.GetProperties",
                System.Threading.CancellationToken cancellationToken = default)
            {
                Azure.Core.Pipeline.DiagnosticScope _scope = clientDiagnostics.CreateScope(operationName);
                try
                {
                    _scope.AddAttribute("url", resourceUri);
                    _scope.Start();
                    using (Azure.Core.HttpMessage _message = GetPropertiesAsync_CreateMessage(
                        pipeline,
                        resourceUri,
                        sharesnapshot,
                        timeout))
                    {
                        if (async)
                        {
                            // Send the request asynchronously if we're being called via an async path
                            await pipeline.SendAsync(_message, cancellationToken).ConfigureAwait(false);
                        }
                        else
                        {
                            // Send the request synchronously through the API that blocks if we're being called via a sync path
                            // (this is safe because the Task will complete before the user can call Wait)
                            pipeline.Send(_message, cancellationToken);
                        }
                        Azure.Response _response = _message.Response;
                        cancellationToken.ThrowIfCancellationRequested();
                        return GetPropertiesAsync_CreateResponse(_response);
                    }
                }
                catch (System.Exception ex)
                {
                    _scope.Failed(ex);
                    throw;
                }
                finally
                {
                    _scope.Dispose();
                }
            }

            /// <summary>
            /// Create the File.GetPropertiesAsync request.
            /// </summary>
            /// <param name="pipeline">The pipeline used for sending requests.</param>
            /// <param name="resourceUri">The URL of the service account, share, directory or file that is the target of the desired operation.</param>
            /// <param name="sharesnapshot">The snapshot parameter is an opaque DateTime value that, when present, specifies the share snapshot to query.</param>
            /// <param name="timeout">The timeout parameter is expressed in seconds. For more information, see <a href="https://docs.microsoft.com/en-us/rest/api/storageservices/Setting-Timeouts-for-File-Service-Operations?redirectedfrom=MSDN">Setting Timeouts for File Service Operations.</a></param>
            /// <returns>The File.GetPropertiesAsync Message.</returns>
            internal static Azure.Core.HttpMessage GetPropertiesAsync_CreateMessage(
                Azure.Core.Pipeline.HttpPipeline pipeline,
                System.Uri resourceUri,
                string sharesnapshot = default,
                int? timeout = default)
            {
                // Validation
                if (resourceUri == null)
                {
                    throw new System.ArgumentNullException(nameof(resourceUri));
                }

                // Create the request
                Azure.Core.HttpMessage _message = pipeline.CreateMessage();
                Azure.Core.Request _request = _message.Request;

                // Set the endpoint
                _request.Method = Azure.Core.RequestMethod.Head;
                _request.Uri.Reset(resourceUri);
                if (sharesnapshot != null) { _request.Uri.AppendQuery("sharesnapshot", System.Uri.EscapeDataString(sharesnapshot)); }
                if (timeout != null) { _request.Uri.AppendQuery("timeout", System.Uri.EscapeDataString(timeout.Value.ToString(System.Globalization.CultureInfo.InvariantCulture))); }

                // Add request headers
                _request.Headers.SetValue("x-ms-version", "2019-02-02");

                return _message;
            }

            /// <summary>
            /// Create the File.GetPropertiesAsync response or throw a failure exception.
            /// </summary>
            /// <param name="response">The raw Response.</param>
            /// <returns>The File.GetPropertiesAsync Azure.Response{Azure.Storage.Files.Models.RawStorageFileProperties}.</returns>
            internal static Azure.Response<Azure.Storage.Files.Models.RawStorageFileProperties> GetPropertiesAsync_CreateResponse(
                Azure.Response response)
            {
                // Process the response
                switch (response.Status)
                {
                    case 200:
                    {
                        // Create the result
                        Azure.Storage.Files.Models.RawStorageFileProperties _value = new Azure.Storage.Files.Models.RawStorageFileProperties();

                        // Get response headers
                        string _header;
                        if (response.Headers.TryGetValue("Last-Modified", out _header))
                        {
                            _value.LastModified = System.DateTimeOffset.Parse(_header, System.Globalization.CultureInfo.InvariantCulture);
                        }
                        _value.Metadata = new System.Collections.Generic.Dictionary<string, string>(System.StringComparer.OrdinalIgnoreCase);
                        foreach (Azure.Core.HttpHeader _headerPair in response.Headers)
                        {
                            if (_headerPair.Name.StartsWith("x-ms-meta-", System.StringComparison.InvariantCulture))
                            {
                                _value.Metadata[_headerPair.Name.Substring(10)] = _headerPair.Value;
                            }
                        }
                        if (response.Headers.TryGetValue("x-ms-type", out _header))
                        {
                            _value.FileType = (Azure.Storage.Files.Models.Header)System.Enum.Parse(typeof(Azure.Storage.Files.Models.Header), _header, false);
                        }
                        if (response.Headers.TryGetValue("Content-Length", out _header))
                        {
                            _value.ContentLength = long.Parse(_header, System.Globalization.CultureInfo.InvariantCulture);
                        }
                        if (response.Headers.TryGetValue("Content-Type", out _header))
                        {
                            _value.ContentType = _header;
                        }
                        if (response.Headers.TryGetValue("ETag", out _header))
                        {
                            _value.ETag = new Azure.ETag(_header);
                        }
                        if (response.Headers.TryGetValue("Content-MD5", out _header))
                        {
                            _value.ContentHash = System.Convert.FromBase64String(_header);
                        }
                        if (response.Headers.TryGetValue("Content-Encoding", out _header))
                        {
                            _value.ContentEncoding = (_header ?? "").Split(',');
                        }
                        if (response.Headers.TryGetValue("Cache-Control", out _header))
                        {
                            _value.CacheControl = _header;
                        }
                        if (response.Headers.TryGetValue("Content-Disposition", out _header))
                        {
                            _value.ContentDisposition = _header;
                        }
                        if (response.Headers.TryGetValue("Content-Language", out _header))
                        {
                            _value.ContentLanguage = (_header ?? "").Split(',');
                        }
                        if (response.Headers.TryGetValue("x-ms-copy-completion-time", out _header))
                        {
                            _value.CopyCompletionTime = System.DateTimeOffset.Parse(_header, System.Globalization.CultureInfo.InvariantCulture);
                        }
                        if (response.Headers.TryGetValue("x-ms-copy-status-description", out _header))
                        {
                            _value.CopyStatusDescription = _header;
                        }
                        if (response.Headers.TryGetValue("x-ms-copy-id", out _header))
                        {
                            _value.CopyId = _header;
                        }
                        if (response.Headers.TryGetValue("x-ms-copy-progress", out _header))
                        {
                            _value.CopyProgress = _header;
                        }
                        if (response.Headers.TryGetValue("x-ms-copy-source", out _header))
                        {
                            _value.CopySource = _header;
                        }
                        if (response.Headers.TryGetValue("x-ms-copy-status", out _header))
                        {
                            _value.CopyStatus = Azure.Storage.Files.FileRestClient.Serialization.ParseCopyStatus(_header);
                        }
                        if (response.Headers.TryGetValue("x-ms-server-encrypted", out _header))
                        {
                            _value.IsServerEncrypted = bool.Parse(_header);
                        }
                        if (response.Headers.TryGetValue("x-ms-file-attributes", out _header))
                        {
                            _value.FileAttributes = _header;
                        }
                        if (response.Headers.TryGetValue("x-ms-file-creation-time", out _header))
                        {
                            _value.FileCreationTime = System.DateTimeOffset.Parse(_header, System.Globalization.CultureInfo.InvariantCulture);
                        }
                        if (response.Headers.TryGetValue("x-ms-file-last-write-time", out _header))
                        {
                            _value.FileLastWriteTime = System.DateTimeOffset.Parse(_header, System.Globalization.CultureInfo.InvariantCulture);
                        }
                        if (response.Headers.TryGetValue("x-ms-file-change-time", out _header))
                        {
                            _value.FileChangeTime = System.DateTimeOffset.Parse(_header, System.Globalization.CultureInfo.InvariantCulture);
                        }
                        if (response.Headers.TryGetValue("x-ms-file-permission-key", out _header))
                        {
                            _value.FilePermissionKey = _header;
                        }
                        if (response.Headers.TryGetValue("x-ms-file-id", out _header))
                        {
                            _value.FileId = _header;
                        }
                        if (response.Headers.TryGetValue("x-ms-file-parent-id", out _header))
                        {
                            _value.FileParentId = _header;
                        }

                        // Create the response
                        return Response.FromValue(_value, response);
                    }
                    default:
                    {
                        // Create the result
                        Azure.Storage.Files.Models.FailureNoContent _value = new Azure.Storage.Files.Models.FailureNoContent();

                        // Get response headers
                        string _header;
                        if (response.Headers.TryGetValue("x-ms-error-code", out _header))
                        {
                            _value.ErrorCode = _header;
                        }

                        throw _value.CreateException(response);
                    }
                }
            }
            #endregion File.GetPropertiesAsync

            #region File.DeleteAsync
            /// <summary>
            /// removes the file from the storage account.
            /// </summary>
            /// <param name="pipeline">The pipeline used for sending requests.</param>
            /// <param name="resourceUri">The URL of the service account, share, directory or file that is the target of the desired operation.</param>
            /// <param name="timeout">The timeout parameter is expressed in seconds. For more information, see <a href="https://docs.microsoft.com/en-us/rest/api/storageservices/Setting-Timeouts-for-File-Service-Operations?redirectedfrom=MSDN">Setting Timeouts for File Service Operations.</a></param>
            /// <param name="async">Whether to invoke the operation asynchronously.  The default value is true.</param>
            /// <param name="clientDiagnostics">The ClientDiagnostics instance used for operation reporting.</param>
            /// <param name="operationName">Operation name.</param>
            /// <param name="cancellationToken">Cancellation token.</param>
            /// <returns>Azure.Response</returns>
            public static async System.Threading.Tasks.ValueTask<Azure.Response> DeleteAsync(
                Azure.Core.Pipeline.ClientDiagnostics clientDiagnostics,
                Azure.Core.Pipeline.HttpPipeline pipeline,
                System.Uri resourceUri,
                int? timeout = default,
                bool async = true,
                string operationName = "Azure.Storage.Files.FileClient.Delete",
                System.Threading.CancellationToken cancellationToken = default)
            {
                Azure.Core.Pipeline.DiagnosticScope _scope = clientDiagnostics.CreateScope(operationName);
                try
                {
                    _scope.AddAttribute("url", resourceUri);
                    _scope.Start();
                    using (Azure.Core.HttpMessage _message = DeleteAsync_CreateMessage(
                        pipeline,
                        resourceUri,
                        timeout))
                    {
                        if (async)
                        {
                            // Send the request asynchronously if we're being called via an async path
                            await pipeline.SendAsync(_message, cancellationToken).ConfigureAwait(false);
                        }
                        else
                        {
                            // Send the request synchronously through the API that blocks if we're being called via a sync path
                            // (this is safe because the Task will complete before the user can call Wait)
                            pipeline.Send(_message, cancellationToken);
                        }
                        Azure.Response _response = _message.Response;
                        cancellationToken.ThrowIfCancellationRequested();
                        return DeleteAsync_CreateResponse(_response);
                    }
                }
                catch (System.Exception ex)
                {
                    _scope.Failed(ex);
                    throw;
                }
                finally
                {
                    _scope.Dispose();
                }
            }

            /// <summary>
            /// Create the File.DeleteAsync request.
            /// </summary>
            /// <param name="pipeline">The pipeline used for sending requests.</param>
            /// <param name="resourceUri">The URL of the service account, share, directory or file that is the target of the desired operation.</param>
            /// <param name="timeout">The timeout parameter is expressed in seconds. For more information, see <a href="https://docs.microsoft.com/en-us/rest/api/storageservices/Setting-Timeouts-for-File-Service-Operations?redirectedfrom=MSDN">Setting Timeouts for File Service Operations.</a></param>
            /// <returns>The File.DeleteAsync Message.</returns>
            internal static Azure.Core.HttpMessage DeleteAsync_CreateMessage(
                Azure.Core.Pipeline.HttpPipeline pipeline,
                System.Uri resourceUri,
                int? timeout = default)
            {
                // Validation
                if (resourceUri == null)
                {
                    throw new System.ArgumentNullException(nameof(resourceUri));
                }

                // Create the request
                Azure.Core.HttpMessage _message = pipeline.CreateMessage();
                Azure.Core.Request _request = _message.Request;

                // Set the endpoint
                _request.Method = Azure.Core.RequestMethod.Delete;
                _request.Uri.Reset(resourceUri);
                if (timeout != null) { _request.Uri.AppendQuery("timeout", System.Uri.EscapeDataString(timeout.Value.ToString(System.Globalization.CultureInfo.InvariantCulture))); }

                // Add request headers
                _request.Headers.SetValue("x-ms-version", "2019-02-02");

                return _message;
            }

            /// <summary>
            /// Create the File.DeleteAsync response or throw a failure exception.
            /// </summary>
            /// <param name="response">The raw Response.</param>
            /// <returns>The File.DeleteAsync Azure.Response.</returns>
            internal static Azure.Response DeleteAsync_CreateResponse(
                Azure.Response response)
            {
                // Process the response
                switch (response.Status)
                {
                    case 202:
                    {
                        return response;
                    }
                    default:
                    {
                        // Create the result
                        System.Xml.Linq.XDocument _xml = System.Xml.Linq.XDocument.Load(response.ContentStream, System.Xml.Linq.LoadOptions.PreserveWhitespace);
                        Azure.Storage.Files.Models.StorageError _value = Azure.Storage.Files.Models.StorageError.FromXml(_xml.Root);

                        throw _value.CreateException(response);
                    }
                }
            }
            #endregion File.DeleteAsync

            #region File.SetPropertiesAsync
            /// <summary>
            /// Sets HTTP headers on the file.
            /// </summary>
            /// <param name="pipeline">The pipeline used for sending requests.</param>
            /// <param name="resourceUri">The URL of the service account, share, directory or file that is the target of the desired operation.</param>
            /// <param name="fileAttributes">If specified, the provided file attributes shall be set. Default value: ‘Archive’ for file and ‘Directory’ for directory. ‘None’ can also be specified as default.</param>
            /// <param name="fileCreationTime">Creation time for the file/directory. Default value: Now.</param>
            /// <param name="fileLastWriteTime">Last write time for the file/directory. Default value: Now.</param>
            /// <param name="timeout">The timeout parameter is expressed in seconds. For more information, see <a href="https://docs.microsoft.com/en-us/rest/api/storageservices/Setting-Timeouts-for-File-Service-Operations?redirectedfrom=MSDN">Setting Timeouts for File Service Operations.</a></param>
            /// <param name="fileContentLength">Resizes a file to the specified size. If the specified byte value is less than the current size of the file, then all ranges above the specified byte value are cleared.</param>
            /// <param name="fileContentType">Sets the MIME content type of the file. The default type is 'application/octet-stream'.</param>
            /// <param name="fileContentEncoding">Specifies which content encodings have been applied to the file.</param>
            /// <param name="fileContentLanguage">Specifies the natural languages used by this resource.</param>
            /// <param name="fileCacheControl">Sets the file's cache control. The File service stores this value but does not use or modify it.</param>
            /// <param name="fileContentHash">Sets the file's MD5 hash.</param>
            /// <param name="fileContentDisposition">Sets the file's Content-Disposition header.</param>
            /// <param name="filePermission">If specified the permission (security descriptor) shall be set for the directory/file. This header can be used if Permission size is &lt;= 8KB, else x-ms-file-permission-key header shall be used. Default value: Inherit. If SDDL is specified as input, it must have owner, group and dacl. Note: Only one of the x-ms-file-permission or x-ms-file-permission-key should be specified.</param>
            /// <param name="filePermissionKey">Key of the permission to be set for the directory/file. Note: Only one of the x-ms-file-permission or x-ms-file-permission-key should be specified.</param>
            /// <param name="async">Whether to invoke the operation asynchronously.  The default value is true.</param>
            /// <param name="clientDiagnostics">The ClientDiagnostics instance used for operation reporting.</param>
            /// <param name="operationName">Operation name.</param>
            /// <param name="cancellationToken">Cancellation token.</param>
            /// <returns>Azure.Response{Azure.Storage.Files.Models.RawStorageFileInfo}</returns>
            public static async System.Threading.Tasks.ValueTask<Azure.Response<Azure.Storage.Files.Models.RawStorageFileInfo>> SetPropertiesAsync(
                Azure.Core.Pipeline.ClientDiagnostics clientDiagnostics,
                Azure.Core.Pipeline.HttpPipeline pipeline,
                System.Uri resourceUri,
                string fileAttributes,
                string fileCreationTime,
                string fileLastWriteTime,
                int? timeout = default,
                long? fileContentLength = default,
                string fileContentType = default,
                System.Collections.Generic.IEnumerable<string> fileContentEncoding = default,
                System.Collections.Generic.IEnumerable<string> fileContentLanguage = default,
                string fileCacheControl = default,
                byte[] fileContentHash = default,
                string fileContentDisposition = default,
                string filePermission = default,
                string filePermissionKey = default,
                bool async = true,
                string operationName = "Azure.Storage.Files.FileClient.SetProperties",
                System.Threading.CancellationToken cancellationToken = default)
            {
                Azure.Core.Pipeline.DiagnosticScope _scope = clientDiagnostics.CreateScope(operationName);
                try
                {
                    _scope.AddAttribute("url", resourceUri);
                    _scope.Start();
                    using (Azure.Core.HttpMessage _message = SetPropertiesAsync_CreateMessage(
                        pipeline,
                        resourceUri,
                        fileAttributes,
                        fileCreationTime,
                        fileLastWriteTime,
                        timeout,
                        fileContentLength,
                        fileContentType,
                        fileContentEncoding,
                        fileContentLanguage,
                        fileCacheControl,
                        fileContentHash,
                        fileContentDisposition,
                        filePermission,
                        filePermissionKey))
                    {
                        if (async)
                        {
                            // Send the request asynchronously if we're being called via an async path
                            await pipeline.SendAsync(_message, cancellationToken).ConfigureAwait(false);
                        }
                        else
                        {
                            // Send the request synchronously through the API that blocks if we're being called via a sync path
                            // (this is safe because the Task will complete before the user can call Wait)
                            pipeline.Send(_message, cancellationToken);
                        }
                        Azure.Response _response = _message.Response;
                        cancellationToken.ThrowIfCancellationRequested();
                        return SetPropertiesAsync_CreateResponse(_response);
                    }
                }
                catch (System.Exception ex)
                {
                    _scope.Failed(ex);
                    throw;
                }
                finally
                {
                    _scope.Dispose();
                }
            }

            /// <summary>
            /// Create the File.SetPropertiesAsync request.
            /// </summary>
            /// <param name="pipeline">The pipeline used for sending requests.</param>
            /// <param name="resourceUri">The URL of the service account, share, directory or file that is the target of the desired operation.</param>
            /// <param name="fileAttributes">If specified, the provided file attributes shall be set. Default value: ‘Archive’ for file and ‘Directory’ for directory. ‘None’ can also be specified as default.</param>
            /// <param name="fileCreationTime">Creation time for the file/directory. Default value: Now.</param>
            /// <param name="fileLastWriteTime">Last write time for the file/directory. Default value: Now.</param>
            /// <param name="timeout">The timeout parameter is expressed in seconds. For more information, see <a href="https://docs.microsoft.com/en-us/rest/api/storageservices/Setting-Timeouts-for-File-Service-Operations?redirectedfrom=MSDN">Setting Timeouts for File Service Operations.</a></param>
            /// <param name="fileContentLength">Resizes a file to the specified size. If the specified byte value is less than the current size of the file, then all ranges above the specified byte value are cleared.</param>
            /// <param name="fileContentType">Sets the MIME content type of the file. The default type is 'application/octet-stream'.</param>
            /// <param name="fileContentEncoding">Specifies which content encodings have been applied to the file.</param>
            /// <param name="fileContentLanguage">Specifies the natural languages used by this resource.</param>
            /// <param name="fileCacheControl">Sets the file's cache control. The File service stores this value but does not use or modify it.</param>
            /// <param name="fileContentHash">Sets the file's MD5 hash.</param>
            /// <param name="fileContentDisposition">Sets the file's Content-Disposition header.</param>
            /// <param name="filePermission">If specified the permission (security descriptor) shall be set for the directory/file. This header can be used if Permission size is &lt;= 8KB, else x-ms-file-permission-key header shall be used. Default value: Inherit. If SDDL is specified as input, it must have owner, group and dacl. Note: Only one of the x-ms-file-permission or x-ms-file-permission-key should be specified.</param>
            /// <param name="filePermissionKey">Key of the permission to be set for the directory/file. Note: Only one of the x-ms-file-permission or x-ms-file-permission-key should be specified.</param>
            /// <returns>The File.SetPropertiesAsync Message.</returns>
            internal static Azure.Core.HttpMessage SetPropertiesAsync_CreateMessage(
                Azure.Core.Pipeline.HttpPipeline pipeline,
                System.Uri resourceUri,
                string fileAttributes,
                string fileCreationTime,
                string fileLastWriteTime,
                int? timeout = default,
                long? fileContentLength = default,
                string fileContentType = default,
                System.Collections.Generic.IEnumerable<string> fileContentEncoding = default,
                System.Collections.Generic.IEnumerable<string> fileContentLanguage = default,
                string fileCacheControl = default,
                byte[] fileContentHash = default,
                string fileContentDisposition = default,
                string filePermission = default,
                string filePermissionKey = default)
            {
                // Validation
                if (resourceUri == null)
                {
                    throw new System.ArgumentNullException(nameof(resourceUri));
                }
                if (fileAttributes == null)
                {
                    throw new System.ArgumentNullException(nameof(fileAttributes));
                }
                if (fileCreationTime == null)
                {
                    throw new System.ArgumentNullException(nameof(fileCreationTime));
                }
                if (fileLastWriteTime == null)
                {
                    throw new System.ArgumentNullException(nameof(fileLastWriteTime));
                }

                // Create the request
                Azure.Core.HttpMessage _message = pipeline.CreateMessage();
                Azure.Core.Request _request = _message.Request;

                // Set the endpoint
                _request.Method = Azure.Core.RequestMethod.Put;
                _request.Uri.Reset(resourceUri);
                _request.Uri.AppendQuery("comp", "properties");
                if (timeout != null) { _request.Uri.AppendQuery("timeout", System.Uri.EscapeDataString(timeout.Value.ToString(System.Globalization.CultureInfo.InvariantCulture))); }

                // Add request headers
                _request.Headers.SetValue("x-ms-version", "2019-02-02");
                _request.Headers.SetValue("x-ms-file-attributes", fileAttributes);
                _request.Headers.SetValue("x-ms-file-creation-time", fileCreationTime);
                _request.Headers.SetValue("x-ms-file-last-write-time", fileLastWriteTime);
                if (fileContentLength != null) { _request.Headers.SetValue("x-ms-content-length", fileContentLength.Value.ToString(System.Globalization.CultureInfo.InvariantCulture)); }
                if (fileContentType != null) { _request.Headers.SetValue("x-ms-content-type", fileContentType); }
                if (fileContentEncoding != null) {
                    foreach (string _item in fileContentEncoding)
                    {
                        _request.Headers.SetValue("x-ms-content-encoding", _item);
                    }
                }
                if (fileContentLanguage != null) {
                    foreach (string _item in fileContentLanguage)
                    {
                        _request.Headers.SetValue("x-ms-content-language", _item);
                    }
                }
                if (fileCacheControl != null) { _request.Headers.SetValue("x-ms-cache-control", fileCacheControl); }
                if (fileContentHash != null) { _request.Headers.SetValue("x-ms-content-md5", System.Convert.ToBase64String(fileContentHash)); }
                if (fileContentDisposition != null) { _request.Headers.SetValue("x-ms-content-disposition", fileContentDisposition); }
                if (filePermission != null) { _request.Headers.SetValue("x-ms-file-permission", filePermission); }
                if (filePermissionKey != null) { _request.Headers.SetValue("x-ms-file-permission-key", filePermissionKey); }

                return _message;
            }

            /// <summary>
            /// Create the File.SetPropertiesAsync response or throw a failure exception.
            /// </summary>
            /// <param name="response">The raw Response.</param>
            /// <returns>The File.SetPropertiesAsync Azure.Response{Azure.Storage.Files.Models.RawStorageFileInfo}.</returns>
            internal static Azure.Response<Azure.Storage.Files.Models.RawStorageFileInfo> SetPropertiesAsync_CreateResponse(
                Azure.Response response)
            {
                // Process the response
                switch (response.Status)
                {
                    case 200:
                    {
                        // Create the result
                        Azure.Storage.Files.Models.RawStorageFileInfo _value = new Azure.Storage.Files.Models.RawStorageFileInfo();

                        // Get response headers
                        string _header;
                        if (response.Headers.TryGetValue("ETag", out _header))
                        {
                            _value.ETag = new Azure.ETag(_header);
                        }
                        if (response.Headers.TryGetValue("Last-Modified", out _header))
                        {
                            _value.LastModified = System.DateTimeOffset.Parse(_header, System.Globalization.CultureInfo.InvariantCulture);
                        }
                        if (response.Headers.TryGetValue("x-ms-request-server-encrypted", out _header))
                        {
                            _value.IsServerEncrypted = bool.Parse(_header);
                        }
                        if (response.Headers.TryGetValue("x-ms-file-permission-key", out _header))
                        {
                            _value.FilePermissionKey = _header;
                        }
                        if (response.Headers.TryGetValue("x-ms-file-attributes", out _header))
                        {
                            _value.FileAttributes = _header;
                        }
                        if (response.Headers.TryGetValue("x-ms-file-creation-time", out _header))
                        {
                            _value.FileCreationTime = System.DateTimeOffset.Parse(_header, System.Globalization.CultureInfo.InvariantCulture);
                        }
                        if (response.Headers.TryGetValue("x-ms-file-last-write-time", out _header))
                        {
                            _value.FileLastWriteTime = System.DateTimeOffset.Parse(_header, System.Globalization.CultureInfo.InvariantCulture);
                        }
                        if (response.Headers.TryGetValue("x-ms-file-change-time", out _header))
                        {
                            _value.FileChangeTime = System.DateTimeOffset.Parse(_header, System.Globalization.CultureInfo.InvariantCulture);
                        }
                        if (response.Headers.TryGetValue("x-ms-file-id", out _header))
                        {
                            _value.FileId = _header;
                        }
                        if (response.Headers.TryGetValue("x-ms-file-parent-id", out _header))
                        {
                            _value.FileParentId = _header;
                        }

                        // Create the response
                        return Response.FromValue(_value, response);
                    }
                    default:
                    {
                        // Create the result
                        System.Xml.Linq.XDocument _xml = System.Xml.Linq.XDocument.Load(response.ContentStream, System.Xml.Linq.LoadOptions.PreserveWhitespace);
                        Azure.Storage.Files.Models.StorageError _value = Azure.Storage.Files.Models.StorageError.FromXml(_xml.Root);

                        throw _value.CreateException(response);
                    }
                }
            }
            #endregion File.SetPropertiesAsync

            #region File.SetMetadataAsync
            /// <summary>
            /// Updates user-defined metadata for the specified file.
            /// </summary>
            /// <param name="pipeline">The pipeline used for sending requests.</param>
            /// <param name="resourceUri">The URL of the service account, share, directory or file that is the target of the desired operation.</param>
            /// <param name="timeout">The timeout parameter is expressed in seconds. For more information, see <a href="https://docs.microsoft.com/en-us/rest/api/storageservices/Setting-Timeouts-for-File-Service-Operations?redirectedfrom=MSDN">Setting Timeouts for File Service Operations.</a></param>
            /// <param name="metadata">A name-value pair to associate with a file storage object.</param>
            /// <param name="async">Whether to invoke the operation asynchronously.  The default value is true.</param>
            /// <param name="clientDiagnostics">The ClientDiagnostics instance used for operation reporting.</param>
            /// <param name="operationName">Operation name.</param>
            /// <param name="cancellationToken">Cancellation token.</param>
            /// <returns>Azure.Response{Azure.Storage.Files.Models.RawStorageFileInfo}</returns>
            public static async System.Threading.Tasks.ValueTask<Azure.Response<Azure.Storage.Files.Models.RawStorageFileInfo>> SetMetadataAsync(
                Azure.Core.Pipeline.ClientDiagnostics clientDiagnostics,
                Azure.Core.Pipeline.HttpPipeline pipeline,
                System.Uri resourceUri,
                int? timeout = default,
                System.Collections.Generic.IDictionary<string, string> metadata = default,
                bool async = true,
                string operationName = "Azure.Storage.Files.FileClient.SetMetadata",
                System.Threading.CancellationToken cancellationToken = default)
            {
                Azure.Core.Pipeline.DiagnosticScope _scope = clientDiagnostics.CreateScope(operationName);
                try
                {
                    _scope.AddAttribute("url", resourceUri);
                    _scope.Start();
                    using (Azure.Core.HttpMessage _message = SetMetadataAsync_CreateMessage(
                        pipeline,
                        resourceUri,
                        timeout,
                        metadata))
                    {
                        if (async)
                        {
                            // Send the request asynchronously if we're being called via an async path
                            await pipeline.SendAsync(_message, cancellationToken).ConfigureAwait(false);
                        }
                        else
                        {
                            // Send the request synchronously through the API that blocks if we're being called via a sync path
                            // (this is safe because the Task will complete before the user can call Wait)
                            pipeline.Send(_message, cancellationToken);
                        }
                        Azure.Response _response = _message.Response;
                        cancellationToken.ThrowIfCancellationRequested();
                        return SetMetadataAsync_CreateResponse(_response);
                    }
                }
                catch (System.Exception ex)
                {
                    _scope.Failed(ex);
                    throw;
                }
                finally
                {
                    _scope.Dispose();
                }
            }

            /// <summary>
            /// Create the File.SetMetadataAsync request.
            /// </summary>
            /// <param name="pipeline">The pipeline used for sending requests.</param>
            /// <param name="resourceUri">The URL of the service account, share, directory or file that is the target of the desired operation.</param>
            /// <param name="timeout">The timeout parameter is expressed in seconds. For more information, see <a href="https://docs.microsoft.com/en-us/rest/api/storageservices/Setting-Timeouts-for-File-Service-Operations?redirectedfrom=MSDN">Setting Timeouts for File Service Operations.</a></param>
            /// <param name="metadata">A name-value pair to associate with a file storage object.</param>
            /// <returns>The File.SetMetadataAsync Message.</returns>
            internal static Azure.Core.HttpMessage SetMetadataAsync_CreateMessage(
                Azure.Core.Pipeline.HttpPipeline pipeline,
                System.Uri resourceUri,
                int? timeout = default,
                System.Collections.Generic.IDictionary<string, string> metadata = default)
            {
                // Validation
                if (resourceUri == null)
                {
                    throw new System.ArgumentNullException(nameof(resourceUri));
                }

                // Create the request
                Azure.Core.HttpMessage _message = pipeline.CreateMessage();
                Azure.Core.Request _request = _message.Request;

                // Set the endpoint
                _request.Method = Azure.Core.RequestMethod.Put;
                _request.Uri.Reset(resourceUri);
                _request.Uri.AppendQuery("comp", "metadata");
                if (timeout != null) { _request.Uri.AppendQuery("timeout", System.Uri.EscapeDataString(timeout.Value.ToString(System.Globalization.CultureInfo.InvariantCulture))); }

                // Add request headers
                _request.Headers.SetValue("x-ms-version", "2019-02-02");
                if (metadata != null) {
                    foreach (System.Collections.Generic.KeyValuePair<string, string> _pair in metadata)
                    {
                        _request.Headers.SetValue("x-ms-meta-" + _pair.Key, _pair.Value);
                    }
                }

                return _message;
            }

            /// <summary>
            /// Create the File.SetMetadataAsync response or throw a failure exception.
            /// </summary>
            /// <param name="response">The raw Response.</param>
            /// <returns>The File.SetMetadataAsync Azure.Response{Azure.Storage.Files.Models.RawStorageFileInfo}.</returns>
            internal static Azure.Response<Azure.Storage.Files.Models.RawStorageFileInfo> SetMetadataAsync_CreateResponse(
                Azure.Response response)
            {
                // Process the response
                switch (response.Status)
                {
                    case 200:
                    {
                        // Create the result
                        Azure.Storage.Files.Models.RawStorageFileInfo _value = new Azure.Storage.Files.Models.RawStorageFileInfo();

                        // Get response headers
                        string _header;
                        if (response.Headers.TryGetValue("ETag", out _header))
                        {
                            _value.ETag = new Azure.ETag(_header);
                        }
                        if (response.Headers.TryGetValue("x-ms-request-server-encrypted", out _header))
                        {
                            _value.IsServerEncrypted = bool.Parse(_header);
                        }
                        if (response.Headers.TryGetValue("Last-Modified", out _header))
                        {
                            _value.LastModified = System.DateTimeOffset.Parse(_header, System.Globalization.CultureInfo.InvariantCulture);
                        }

                        // Create the response
                        return Response.FromValue(_value, response);
                    }
                    default:
                    {
                        // Create the result
                        System.Xml.Linq.XDocument _xml = System.Xml.Linq.XDocument.Load(response.ContentStream, System.Xml.Linq.LoadOptions.PreserveWhitespace);
                        Azure.Storage.Files.Models.StorageError _value = Azure.Storage.Files.Models.StorageError.FromXml(_xml.Root);

                        throw _value.CreateException(response);
                    }
                }
            }
            #endregion File.SetMetadataAsync

            #region File.UploadRangeAsync
            /// <summary>
            /// Upload a range of bytes to a file.
            /// </summary>
            /// <param name="pipeline">The pipeline used for sending requests.</param>
            /// <param name="resourceUri">The URL of the service account, share, directory or file that is the target of the desired operation.</param>
            /// <param name="range">Specifies the range of bytes to be written. Both the start and end of the range must be specified. For an update operation, the range can be up to 4 MB in size. For a clear operation, the range can be up to the value of the file's full size. The File service accepts only a single byte range for the Range and 'x-ms-range' headers, and the byte range must be specified in the following format: bytes=startByte-endByte.</param>
            /// <param name="fileRangeWrite">Specify one of the following options: - Update: Writes the bytes specified by the request body into the specified range. The Range and Content-Length headers must match to perform the update. - Clear: Clears the specified range and releases the space used in storage for that range. To clear a range, set the Content-Length header to zero, and set the Range header to a value that indicates the range to clear, up to maximum file size.</param>
            /// <param name="contentLength">Specifies the number of bytes being transmitted in the request body. When the x-ms-write header is set to clear, the value of this header must be set to zero.</param>
            /// <param name="optionalbody">Initial data.</param>
            /// <param name="timeout">The timeout parameter is expressed in seconds. For more information, see <a href="https://docs.microsoft.com/en-us/rest/api/storageservices/Setting-Timeouts-for-File-Service-Operations?redirectedfrom=MSDN">Setting Timeouts for File Service Operations.</a></param>
            /// <param name="contentHash">An MD5 hash of the content. This hash is used to verify the integrity of the data during transport. When the Content-MD5 header is specified, the File service compares the hash of the content that has arrived with the header value that was sent. If the two hashes do not match, the operation will fail with error code 400 (Bad Request).</param>
            /// <param name="async">Whether to invoke the operation asynchronously.  The default value is true.</param>
            /// <param name="clientDiagnostics">The ClientDiagnostics instance used for operation reporting.</param>
            /// <param name="operationName">Operation name.</param>
            /// <param name="cancellationToken">Cancellation token.</param>
            /// <returns>Azure.Response{Azure.Storage.Files.Models.StorageFileUploadInfo}</returns>
            public static async System.Threading.Tasks.ValueTask<Azure.Response<Azure.Storage.Files.Models.StorageFileUploadInfo>> UploadRangeAsync(
                Azure.Core.Pipeline.ClientDiagnostics clientDiagnostics,
                Azure.Core.Pipeline.HttpPipeline pipeline,
                System.Uri resourceUri,
                string range,
                Azure.Storage.Files.Models.FileRangeWriteType fileRangeWrite,
                long contentLength,
                System.IO.Stream optionalbody = default,
                int? timeout = default,
                byte[] contentHash = default,
                bool async = true,
                string operationName = "Azure.Storage.Files.FileClient.UploadRange",
                System.Threading.CancellationToken cancellationToken = default)
            {
                Azure.Core.Pipeline.DiagnosticScope _scope = clientDiagnostics.CreateScope(operationName);
                try
                {
                    _scope.AddAttribute("url", resourceUri);
                    _scope.Start();
                    using (Azure.Core.HttpMessage _message = UploadRangeAsync_CreateMessage(
                        pipeline,
                        resourceUri,
                        range,
                        fileRangeWrite,
                        contentLength,
                        optionalbody,
                        timeout,
                        contentHash))
                    {
                        if (async)
                        {
                            // Send the request asynchronously if we're being called via an async path
                            await pipeline.SendAsync(_message, cancellationToken).ConfigureAwait(false);
                        }
                        else
                        {
                            // Send the request synchronously through the API that blocks if we're being called via a sync path
                            // (this is safe because the Task will complete before the user can call Wait)
                            pipeline.Send(_message, cancellationToken);
                        }
                        Azure.Response _response = _message.Response;
                        cancellationToken.ThrowIfCancellationRequested();
                        return UploadRangeAsync_CreateResponse(_response);
                    }
                }
                catch (System.Exception ex)
                {
                    _scope.Failed(ex);
                    throw;
                }
                finally
                {
                    _scope.Dispose();
                }
            }

            /// <summary>
            /// Create the File.UploadRangeAsync request.
            /// </summary>
            /// <param name="pipeline">The pipeline used for sending requests.</param>
            /// <param name="resourceUri">The URL of the service account, share, directory or file that is the target of the desired operation.</param>
            /// <param name="range">Specifies the range of bytes to be written. Both the start and end of the range must be specified. For an update operation, the range can be up to 4 MB in size. For a clear operation, the range can be up to the value of the file's full size. The File service accepts only a single byte range for the Range and 'x-ms-range' headers, and the byte range must be specified in the following format: bytes=startByte-endByte.</param>
            /// <param name="fileRangeWrite">Specify one of the following options: - Update: Writes the bytes specified by the request body into the specified range. The Range and Content-Length headers must match to perform the update. - Clear: Clears the specified range and releases the space used in storage for that range. To clear a range, set the Content-Length header to zero, and set the Range header to a value that indicates the range to clear, up to maximum file size.</param>
            /// <param name="contentLength">Specifies the number of bytes being transmitted in the request body. When the x-ms-write header is set to clear, the value of this header must be set to zero.</param>
            /// <param name="optionalbody">Initial data.</param>
            /// <param name="timeout">The timeout parameter is expressed in seconds. For more information, see <a href="https://docs.microsoft.com/en-us/rest/api/storageservices/Setting-Timeouts-for-File-Service-Operations?redirectedfrom=MSDN">Setting Timeouts for File Service Operations.</a></param>
            /// <param name="contentHash">An MD5 hash of the content. This hash is used to verify the integrity of the data during transport. When the Content-MD5 header is specified, the File service compares the hash of the content that has arrived with the header value that was sent. If the two hashes do not match, the operation will fail with error code 400 (Bad Request).</param>
            /// <returns>The File.UploadRangeAsync Message.</returns>
            internal static Azure.Core.HttpMessage UploadRangeAsync_CreateMessage(
                Azure.Core.Pipeline.HttpPipeline pipeline,
                System.Uri resourceUri,
                string range,
                Azure.Storage.Files.Models.FileRangeWriteType fileRangeWrite,
                long contentLength,
                System.IO.Stream optionalbody = default,
                int? timeout = default,
                byte[] contentHash = default)
            {
                // Validation
                if (resourceUri == null)
                {
                    throw new System.ArgumentNullException(nameof(resourceUri));
                }
                if (range == null)
                {
                    throw new System.ArgumentNullException(nameof(range));
                }

                // Create the request
                Azure.Core.HttpMessage _message = pipeline.CreateMessage();
                Azure.Core.Request _request = _message.Request;

                // Set the endpoint
                _request.Method = Azure.Core.RequestMethod.Put;
                _request.Uri.Reset(resourceUri);
                _request.Uri.AppendQuery("comp", "range");
                if (timeout != null) { _request.Uri.AppendQuery("timeout", System.Uri.EscapeDataString(timeout.Value.ToString(System.Globalization.CultureInfo.InvariantCulture))); }

                // Add request headers
                _request.Headers.SetValue("x-ms-range", range);
                _request.Headers.SetValue("x-ms-write", Azure.Storage.Files.FileRestClient.Serialization.ToString(fileRangeWrite));
                _request.Headers.SetValue("Content-Length", contentLength.ToString(System.Globalization.CultureInfo.InvariantCulture));
                _request.Headers.SetValue("x-ms-version", "2019-02-02");
                if (contentHash != null) { _request.Headers.SetValue("Content-MD5", System.Convert.ToBase64String(contentHash)); }

                // Create the body
                _request.Content = Azure.Core.RequestContent.Create(optionalbody);

                return _message;
            }

            /// <summary>
            /// Create the File.UploadRangeAsync response or throw a failure exception.
            /// </summary>
            /// <param name="response">The raw Response.</param>
            /// <returns>The File.UploadRangeAsync Azure.Response{Azure.Storage.Files.Models.StorageFileUploadInfo}.</returns>
            internal static Azure.Response<Azure.Storage.Files.Models.StorageFileUploadInfo> UploadRangeAsync_CreateResponse(
                Azure.Response response)
            {
                // Process the response
                switch (response.Status)
                {
                    case 201:
                    {
                        // Create the result
                        Azure.Storage.Files.Models.StorageFileUploadInfo _value = new Azure.Storage.Files.Models.StorageFileUploadInfo();

                        // Get response headers
                        string _header;
                        if (response.Headers.TryGetValue("ETag", out _header))
                        {
                            _value.ETag = new Azure.ETag(_header);
                        }
                        if (response.Headers.TryGetValue("Last-Modified", out _header))
                        {
                            _value.LastModified = System.DateTimeOffset.Parse(_header, System.Globalization.CultureInfo.InvariantCulture);
                        }
                        if (response.Headers.TryGetValue("Content-MD5", out _header))
                        {
                            _value.ContentHash = System.Convert.FromBase64String(_header);
                        }
                        if (response.Headers.TryGetValue("x-ms-request-server-encrypted", out _header))
                        {
                            _value.IsServerEncrypted = bool.Parse(_header);
                        }

                        // Create the response
                        return Response.FromValue(_value, response);
                    }
                    default:
                    {
                        // Create the result
                        System.Xml.Linq.XDocument _xml = System.Xml.Linq.XDocument.Load(response.ContentStream, System.Xml.Linq.LoadOptions.PreserveWhitespace);
                        Azure.Storage.Files.Models.StorageError _value = Azure.Storage.Files.Models.StorageError.FromXml(_xml.Root);

                        throw _value.CreateException(response);
                    }
                }
            }
            #endregion File.UploadRangeAsync

            #region File.UploadRangeFromURLAsync
            /// <summary>
            /// Upload a range of bytes to a file where the contents are read from a URL.
            /// </summary>
            /// <param name="pipeline">The pipeline used for sending requests.</param>
            /// <param name="resourceUri">The URL of the service account, share, directory or file that is the target of the desired operation.</param>
            /// <param name="range">Writes data to the specified byte range in the file.</param>
            /// <param name="copySource">Specifies the URL of the source file or blob, up to 2 KB in length. To copy a file to another file within the same storage account, you may use Shared Key to authenticate the source file. If you are copying a file from another storage account, or if you are copying a blob from the same storage account or another storage account, then you must authenticate the source file or blob using a shared access signature. If the source is a public blob, no authentication is required to perform the copy operation. A file in a share snapshot can also be specified as a copy source.</param>
            /// <param name="contentLength">Specifies the number of bytes being transmitted in the request body. When the x-ms-write header is set to clear, the value of this header must be set to zero.</param>
            /// <param name="timeout">The timeout parameter is expressed in seconds. For more information, see <a href="https://docs.microsoft.com/en-us/rest/api/storageservices/Setting-Timeouts-for-File-Service-Operations?redirectedfrom=MSDN">Setting Timeouts for File Service Operations.</a></param>
            /// <param name="sourceRange">Bytes of source data in the specified range.</param>
            /// <param name="sourceContentCrc64">Specify the crc64 calculated for the range of bytes that must be read from the copy source.</param>
            /// <param name="sourceIfMatchCrc64">Specify the crc64 value to operate only on range with a matching crc64 checksum.</param>
            /// <param name="sourceIfNoneMatchCrc64">Specify the crc64 value to operate only on range without a matching crc64 checksum.</param>
            /// <param name="async">Whether to invoke the operation asynchronously.  The default value is true.</param>
            /// <param name="clientDiagnostics">The ClientDiagnostics instance used for operation reporting.</param>
            /// <param name="operationName">Operation name.</param>
            /// <param name="cancellationToken">Cancellation token.</param>
            /// <returns>Azure.Response{Azure.Storage.Files.Models.FileUploadRangeFromURLResult}</returns>
            public static async System.Threading.Tasks.ValueTask<Azure.Response<Azure.Storage.Files.Models.FileUploadRangeFromURLResult>> UploadRangeFromURLAsync(
                Azure.Core.Pipeline.ClientDiagnostics clientDiagnostics,
                Azure.Core.Pipeline.HttpPipeline pipeline,
                System.Uri resourceUri,
                string range,
                System.Uri copySource,
                long contentLength,
                int? timeout = default,
                string sourceRange = default,
                byte[] sourceContentCrc64 = default,
                byte[] sourceIfMatchCrc64 = default,
                byte[] sourceIfNoneMatchCrc64 = default,
                bool async = true,
                string operationName = "Azure.Storage.Files.FileClient.UploadRangeFromURL",
                System.Threading.CancellationToken cancellationToken = default)
            {
                Azure.Core.Pipeline.DiagnosticScope _scope = clientDiagnostics.CreateScope(operationName);
                try
                {
                    _scope.AddAttribute("url", resourceUri);
                    _scope.Start();
                    using (Azure.Core.HttpMessage _message = UploadRangeFromURLAsync_CreateMessage(
                        pipeline,
                        resourceUri,
                        range,
                        copySource,
                        contentLength,
                        timeout,
                        sourceRange,
                        sourceContentCrc64,
                        sourceIfMatchCrc64,
                        sourceIfNoneMatchCrc64))
                    {
                        if (async)
                        {
                            // Send the request asynchronously if we're being called via an async path
                            await pipeline.SendAsync(_message, cancellationToken).ConfigureAwait(false);
                        }
                        else
                        {
                            // Send the request synchronously through the API that blocks if we're being called via a sync path
                            // (this is safe because the Task will complete before the user can call Wait)
                            pipeline.Send(_message, cancellationToken);
                        }
                        Azure.Response _response = _message.Response;
                        cancellationToken.ThrowIfCancellationRequested();
                        return UploadRangeFromURLAsync_CreateResponse(_response);
                    }
                }
                catch (System.Exception ex)
                {
                    _scope.Failed(ex);
                    throw;
                }
                finally
                {
                    _scope.Dispose();
                }
            }

            /// <summary>
            /// Create the File.UploadRangeFromURLAsync request.
            /// </summary>
            /// <param name="pipeline">The pipeline used for sending requests.</param>
            /// <param name="resourceUri">The URL of the service account, share, directory or file that is the target of the desired operation.</param>
            /// <param name="range">Writes data to the specified byte range in the file.</param>
            /// <param name="copySource">Specifies the URL of the source file or blob, up to 2 KB in length. To copy a file to another file within the same storage account, you may use Shared Key to authenticate the source file. If you are copying a file from another storage account, or if you are copying a blob from the same storage account or another storage account, then you must authenticate the source file or blob using a shared access signature. If the source is a public blob, no authentication is required to perform the copy operation. A file in a share snapshot can also be specified as a copy source.</param>
            /// <param name="contentLength">Specifies the number of bytes being transmitted in the request body. When the x-ms-write header is set to clear, the value of this header must be set to zero.</param>
            /// <param name="timeout">The timeout parameter is expressed in seconds. For more information, see <a href="https://docs.microsoft.com/en-us/rest/api/storageservices/Setting-Timeouts-for-File-Service-Operations?redirectedfrom=MSDN">Setting Timeouts for File Service Operations.</a></param>
            /// <param name="sourceRange">Bytes of source data in the specified range.</param>
            /// <param name="sourceContentCrc64">Specify the crc64 calculated for the range of bytes that must be read from the copy source.</param>
            /// <param name="sourceIfMatchCrc64">Specify the crc64 value to operate only on range with a matching crc64 checksum.</param>
            /// <param name="sourceIfNoneMatchCrc64">Specify the crc64 value to operate only on range without a matching crc64 checksum.</param>
            /// <returns>The File.UploadRangeFromURLAsync Message.</returns>
            internal static Azure.Core.HttpMessage UploadRangeFromURLAsync_CreateMessage(
                Azure.Core.Pipeline.HttpPipeline pipeline,
                System.Uri resourceUri,
                string range,
                System.Uri copySource,
                long contentLength,
                int? timeout = default,
                string sourceRange = default,
                byte[] sourceContentCrc64 = default,
                byte[] sourceIfMatchCrc64 = default,
                byte[] sourceIfNoneMatchCrc64 = default)
            {
                // Validation
                if (resourceUri == null)
                {
                    throw new System.ArgumentNullException(nameof(resourceUri));
                }
                if (range == null)
                {
                    throw new System.ArgumentNullException(nameof(range));
                }
                if (copySource == null)
                {
                    throw new System.ArgumentNullException(nameof(copySource));
                }

                // Create the request
                Azure.Core.HttpMessage _message = pipeline.CreateMessage();
                Azure.Core.Request _request = _message.Request;

                // Set the endpoint
                _request.Method = Azure.Core.RequestMethod.Put;
                _request.Uri.Reset(resourceUri);
                _request.Uri.AppendQuery("comp", "range");
                if (timeout != null) { _request.Uri.AppendQuery("timeout", System.Uri.EscapeDataString(timeout.Value.ToString(System.Globalization.CultureInfo.InvariantCulture))); }

                // Add request headers
                _request.Headers.SetValue("x-ms-range", range);
                _request.Headers.SetValue("x-ms-copy-source", copySource.ToString());
                _request.Headers.SetValue("x-ms-write", "update");
                _request.Headers.SetValue("Content-Length", contentLength.ToString(System.Globalization.CultureInfo.InvariantCulture));
                _request.Headers.SetValue("x-ms-version", "2019-02-02");
                if (sourceRange != null) { _request.Headers.SetValue("x-ms-source-range", sourceRange); }
                if (sourceContentCrc64 != null) { _request.Headers.SetValue("x-ms-source-content-crc64", System.Convert.ToBase64String(sourceContentCrc64)); }
                if (sourceIfMatchCrc64 != null) { _request.Headers.SetValue("x-ms-source-if-match-crc64", System.Convert.ToBase64String(sourceIfMatchCrc64)); }
                if (sourceIfNoneMatchCrc64 != null) { _request.Headers.SetValue("x-ms-source-if-none-match-crc64", System.Convert.ToBase64String(sourceIfNoneMatchCrc64)); }

                return _message;
            }

            /// <summary>
            /// Create the File.UploadRangeFromURLAsync response or throw a failure exception.
            /// </summary>
            /// <param name="response">The raw Response.</param>
            /// <returns>The File.UploadRangeFromURLAsync Azure.Response{Azure.Storage.Files.Models.FileUploadRangeFromURLResult}.</returns>
            internal static Azure.Response<Azure.Storage.Files.Models.FileUploadRangeFromURLResult> UploadRangeFromURLAsync_CreateResponse(
                Azure.Response response)
            {
                // Process the response
                switch (response.Status)
                {
                    case 201:
                    {
                        // Create the result
                        Azure.Storage.Files.Models.FileUploadRangeFromURLResult _value = new Azure.Storage.Files.Models.FileUploadRangeFromURLResult();

                        // Get response headers
                        string _header;
                        if (response.Headers.TryGetValue("ETag", out _header))
                        {
                            _value.ETag = new Azure.ETag(_header);
                        }
                        if (response.Headers.TryGetValue("Last-Modified", out _header))
                        {
                            _value.LastModified = System.DateTimeOffset.Parse(_header, System.Globalization.CultureInfo.InvariantCulture);
                        }
                        if (response.Headers.TryGetValue("x-ms-content-crc64", out _header))
                        {
                            _value.XMSContentCrc64 = System.Convert.FromBase64String(_header);
                        }
                        if (response.Headers.TryGetValue("x-ms-request-server-encrypted", out _header))
                        {
                            _value.IsServerEncrypted = bool.Parse(_header);
                        }

                        // Create the response
                        return Response.FromValue(_value, response);
                    }
                    default:
                    {
                        // Create the result
                        System.Xml.Linq.XDocument _xml = System.Xml.Linq.XDocument.Load(response.ContentStream, System.Xml.Linq.LoadOptions.PreserveWhitespace);
                        Azure.Storage.Files.Models.StorageError _value = Azure.Storage.Files.Models.StorageError.FromXml(_xml.Root);

                        throw _value.CreateException(response);
                    }
                }
            }
            #endregion File.UploadRangeFromURLAsync

            #region File.GetRangeListAsync
            /// <summary>
            /// Returns the list of valid ranges for a file.
            /// </summary>
            /// <param name="pipeline">The pipeline used for sending requests.</param>
            /// <param name="resourceUri">The URL of the service account, share, directory or file that is the target of the desired operation.</param>
            /// <param name="sharesnapshot">The snapshot parameter is an opaque DateTime value that, when present, specifies the share snapshot to query.</param>
            /// <param name="timeout">The timeout parameter is expressed in seconds. For more information, see <a href="https://docs.microsoft.com/en-us/rest/api/storageservices/Setting-Timeouts-for-File-Service-Operations?redirectedfrom=MSDN">Setting Timeouts for File Service Operations.</a></param>
            /// <param name="range">Specifies the range of bytes over which to list ranges, inclusively.</param>
            /// <param name="async">Whether to invoke the operation asynchronously.  The default value is true.</param>
            /// <param name="clientDiagnostics">The ClientDiagnostics instance used for operation reporting.</param>
            /// <param name="operationName">Operation name.</param>
            /// <param name="cancellationToken">Cancellation token.</param>
            /// <returns>Azure.Response{Azure.Storage.Files.Models.StorageFileRangeInfo}</returns>
            public static async System.Threading.Tasks.ValueTask<Azure.Response<Azure.Storage.Files.Models.StorageFileRangeInfo>> GetRangeListAsync(
                Azure.Core.Pipeline.ClientDiagnostics clientDiagnostics,
                Azure.Core.Pipeline.HttpPipeline pipeline,
                System.Uri resourceUri,
                string sharesnapshot = default,
                int? timeout = default,
                string range = default,
                bool async = true,
                string operationName = "Azure.Storage.Files.FileClient.GetRangeList",
                System.Threading.CancellationToken cancellationToken = default)
            {
                Azure.Core.Pipeline.DiagnosticScope _scope = clientDiagnostics.CreateScope(operationName);
                try
                {
                    _scope.AddAttribute("url", resourceUri);
                    _scope.Start();
                    using (Azure.Core.HttpMessage _message = GetRangeListAsync_CreateMessage(
                        pipeline,
                        resourceUri,
                        sharesnapshot,
                        timeout,
                        range))
                    {
                        if (async)
                        {
                            // Send the request asynchronously if we're being called via an async path
                            await pipeline.SendAsync(_message, cancellationToken).ConfigureAwait(false);
                        }
                        else
                        {
                            // Send the request synchronously through the API that blocks if we're being called via a sync path
                            // (this is safe because the Task will complete before the user can call Wait)
                            pipeline.Send(_message, cancellationToken);
                        }
                        Azure.Response _response = _message.Response;
                        cancellationToken.ThrowIfCancellationRequested();
                        return GetRangeListAsync_CreateResponse(_response);
                    }
                }
                catch (System.Exception ex)
                {
                    _scope.Failed(ex);
                    throw;
                }
                finally
                {
                    _scope.Dispose();
                }
            }

            /// <summary>
            /// Create the File.GetRangeListAsync request.
            /// </summary>
            /// <param name="pipeline">The pipeline used for sending requests.</param>
            /// <param name="resourceUri">The URL of the service account, share, directory or file that is the target of the desired operation.</param>
            /// <param name="sharesnapshot">The snapshot parameter is an opaque DateTime value that, when present, specifies the share snapshot to query.</param>
            /// <param name="timeout">The timeout parameter is expressed in seconds. For more information, see <a href="https://docs.microsoft.com/en-us/rest/api/storageservices/Setting-Timeouts-for-File-Service-Operations?redirectedfrom=MSDN">Setting Timeouts for File Service Operations.</a></param>
            /// <param name="range">Specifies the range of bytes over which to list ranges, inclusively.</param>
            /// <returns>The File.GetRangeListAsync Message.</returns>
            internal static Azure.Core.HttpMessage GetRangeListAsync_CreateMessage(
                Azure.Core.Pipeline.HttpPipeline pipeline,
                System.Uri resourceUri,
                string sharesnapshot = default,
                int? timeout = default,
                string range = default)
            {
                // Validation
                if (resourceUri == null)
                {
                    throw new System.ArgumentNullException(nameof(resourceUri));
                }

                // Create the request
                Azure.Core.HttpMessage _message = pipeline.CreateMessage();
                Azure.Core.Request _request = _message.Request;

                // Set the endpoint
                _request.Method = Azure.Core.RequestMethod.Get;
                _request.Uri.Reset(resourceUri);
                _request.Uri.AppendQuery("comp", "rangelist");
                if (sharesnapshot != null) { _request.Uri.AppendQuery("sharesnapshot", System.Uri.EscapeDataString(sharesnapshot)); }
                if (timeout != null) { _request.Uri.AppendQuery("timeout", System.Uri.EscapeDataString(timeout.Value.ToString(System.Globalization.CultureInfo.InvariantCulture))); }

                // Add request headers
                _request.Headers.SetValue("x-ms-version", "2019-02-02");
                if (range != null) { _request.Headers.SetValue("x-ms-range", range); }

                return _message;
            }

            /// <summary>
            /// Create the File.GetRangeListAsync response or throw a failure exception.
            /// </summary>
            /// <param name="response">The raw Response.</param>
            /// <returns>The File.GetRangeListAsync Azure.Response{Azure.Storage.Files.Models.StorageFileRangeInfo}.</returns>
            internal static Azure.Response<Azure.Storage.Files.Models.StorageFileRangeInfo> GetRangeListAsync_CreateResponse(
                Azure.Response response)
            {
                // Process the response
                switch (response.Status)
                {
                    case 200:
                    {
                        // Create the result
                        System.Xml.Linq.XDocument _xml = System.Xml.Linq.XDocument.Load(response.ContentStream, System.Xml.Linq.LoadOptions.PreserveWhitespace);
                        Azure.Storage.Files.Models.StorageFileRangeInfo _value = new Azure.Storage.Files.Models.StorageFileRangeInfo();
                        _value.Ranges =
                            System.Linq.Enumerable.ToList(
                                System.Linq.Enumerable.Select(
                                    _xml.Element(System.Xml.Linq.XName.Get("Ranges", "")).Elements(System.Xml.Linq.XName.Get("Range", "")),
                                    Azure.Storage.Files.Models.Range.FromXml));

                        // Get response headers
                        string _header;
                        if (response.Headers.TryGetValue("Last-Modified", out _header))
                        {
                            _value.LastModified = System.DateTimeOffset.Parse(_header, System.Globalization.CultureInfo.InvariantCulture);
                        }
                        if (response.Headers.TryGetValue("ETag", out _header))
                        {
                            _value.ETag = new Azure.ETag(_header);
                        }
                        if (response.Headers.TryGetValue("x-ms-content-length", out _header))
                        {
                            _value.FileContentLength = long.Parse(_header, System.Globalization.CultureInfo.InvariantCulture);
                        }

                        // Create the response
                        return Response.FromValue(_value, response);
                    }
                    default:
                    {
                        // Create the result
                        System.Xml.Linq.XDocument _xml = System.Xml.Linq.XDocument.Load(response.ContentStream, System.Xml.Linq.LoadOptions.PreserveWhitespace);
                        Azure.Storage.Files.Models.StorageError _value = Azure.Storage.Files.Models.StorageError.FromXml(_xml.Root);

                        throw _value.CreateException(response);
                    }
                }
            }
            #endregion File.GetRangeListAsync

            #region File.StartCopyAsync
            /// <summary>
            /// Copies a blob or file to a destination file within the storage account.
            /// </summary>
            /// <param name="pipeline">The pipeline used for sending requests.</param>
            /// <param name="resourceUri">The URL of the service account, share, directory or file that is the target of the desired operation.</param>
            /// <param name="copySource">Specifies the URL of the source file or blob, up to 2 KB in length. To copy a file to another file within the same storage account, you may use Shared Key to authenticate the source file. If you are copying a file from another storage account, or if you are copying a blob from the same storage account or another storage account, then you must authenticate the source file or blob using a shared access signature. If the source is a public blob, no authentication is required to perform the copy operation. A file in a share snapshot can also be specified as a copy source.</param>
            /// <param name="timeout">The timeout parameter is expressed in seconds. For more information, see <a href="https://docs.microsoft.com/en-us/rest/api/storageservices/Setting-Timeouts-for-File-Service-Operations?redirectedfrom=MSDN">Setting Timeouts for File Service Operations.</a></param>
            /// <param name="metadata">A name-value pair to associate with a file storage object.</param>
            /// <param name="async">Whether to invoke the operation asynchronously.  The default value is true.</param>
            /// <param name="clientDiagnostics">The ClientDiagnostics instance used for operation reporting.</param>
            /// <param name="operationName">Operation name.</param>
            /// <param name="cancellationToken">Cancellation token.</param>
            /// <returns>Azure.Response{Azure.Storage.Files.Models.StorageFileCopyInfo}</returns>
            public static async System.Threading.Tasks.ValueTask<Azure.Response<Azure.Storage.Files.Models.StorageFileCopyInfo>> StartCopyAsync(
                Azure.Core.Pipeline.ClientDiagnostics clientDiagnostics,
                Azure.Core.Pipeline.HttpPipeline pipeline,
                System.Uri resourceUri,
                System.Uri copySource,
                int? timeout = default,
                System.Collections.Generic.IDictionary<string, string> metadata = default,
                bool async = true,
                string operationName = "Azure.Storage.Files.FileClient.StartCopy",
                System.Threading.CancellationToken cancellationToken = default)
            {
                Azure.Core.Pipeline.DiagnosticScope _scope = clientDiagnostics.CreateScope(operationName);
                try
                {
                    _scope.AddAttribute("url", resourceUri);
                    _scope.Start();
                    using (Azure.Core.HttpMessage _message = StartCopyAsync_CreateMessage(
                        pipeline,
                        resourceUri,
                        copySource,
                        timeout,
                        metadata))
                    {
                        if (async)
                        {
                            // Send the request asynchronously if we're being called via an async path
                            await pipeline.SendAsync(_message, cancellationToken).ConfigureAwait(false);
                        }
                        else
                        {
                            // Send the request synchronously through the API that blocks if we're being called via a sync path
                            // (this is safe because the Task will complete before the user can call Wait)
                            pipeline.Send(_message, cancellationToken);
                        }
                        Azure.Response _response = _message.Response;
                        cancellationToken.ThrowIfCancellationRequested();
                        return StartCopyAsync_CreateResponse(_response);
                    }
                }
                catch (System.Exception ex)
                {
                    _scope.Failed(ex);
                    throw;
                }
                finally
                {
                    _scope.Dispose();
                }
            }

            /// <summary>
            /// Create the File.StartCopyAsync request.
            /// </summary>
            /// <param name="pipeline">The pipeline used for sending requests.</param>
            /// <param name="resourceUri">The URL of the service account, share, directory or file that is the target of the desired operation.</param>
            /// <param name="copySource">Specifies the URL of the source file or blob, up to 2 KB in length. To copy a file to another file within the same storage account, you may use Shared Key to authenticate the source file. If you are copying a file from another storage account, or if you are copying a blob from the same storage account or another storage account, then you must authenticate the source file or blob using a shared access signature. If the source is a public blob, no authentication is required to perform the copy operation. A file in a share snapshot can also be specified as a copy source.</param>
            /// <param name="timeout">The timeout parameter is expressed in seconds. For more information, see <a href="https://docs.microsoft.com/en-us/rest/api/storageservices/Setting-Timeouts-for-File-Service-Operations?redirectedfrom=MSDN">Setting Timeouts for File Service Operations.</a></param>
            /// <param name="metadata">A name-value pair to associate with a file storage object.</param>
            /// <returns>The File.StartCopyAsync Message.</returns>
            internal static Azure.Core.HttpMessage StartCopyAsync_CreateMessage(
                Azure.Core.Pipeline.HttpPipeline pipeline,
                System.Uri resourceUri,
                System.Uri copySource,
                int? timeout = default,
                System.Collections.Generic.IDictionary<string, string> metadata = default)
            {
                // Validation
                if (resourceUri == null)
                {
                    throw new System.ArgumentNullException(nameof(resourceUri));
                }
                if (copySource == null)
                {
                    throw new System.ArgumentNullException(nameof(copySource));
                }

                // Create the request
                Azure.Core.HttpMessage _message = pipeline.CreateMessage();
                Azure.Core.Request _request = _message.Request;

                // Set the endpoint
                _request.Method = Azure.Core.RequestMethod.Put;
                _request.Uri.Reset(resourceUri);
                if (timeout != null) { _request.Uri.AppendQuery("timeout", System.Uri.EscapeDataString(timeout.Value.ToString(System.Globalization.CultureInfo.InvariantCulture))); }

                // Add request headers
                _request.Headers.SetValue("x-ms-version", "2019-02-02");
                _request.Headers.SetValue("x-ms-copy-source", copySource.ToString());
                if (metadata != null) {
                    foreach (System.Collections.Generic.KeyValuePair<string, string> _pair in metadata)
                    {
                        _request.Headers.SetValue("x-ms-meta-" + _pair.Key, _pair.Value);
                    }
                }

                return _message;
            }

            /// <summary>
            /// Create the File.StartCopyAsync response or throw a failure exception.
            /// </summary>
            /// <param name="response">The raw Response.</param>
            /// <returns>The File.StartCopyAsync Azure.Response{Azure.Storage.Files.Models.StorageFileCopyInfo}.</returns>
            internal static Azure.Response<Azure.Storage.Files.Models.StorageFileCopyInfo> StartCopyAsync_CreateResponse(
                Azure.Response response)
            {
                // Process the response
                switch (response.Status)
                {
                    case 202:
                    {
                        // Create the result
                        Azure.Storage.Files.Models.StorageFileCopyInfo _value = new Azure.Storage.Files.Models.StorageFileCopyInfo();

                        // Get response headers
                        string _header;
                        if (response.Headers.TryGetValue("ETag", out _header))
                        {
                            _value.ETag = new Azure.ETag(_header);
                        }
                        if (response.Headers.TryGetValue("Last-Modified", out _header))
                        {
                            _value.LastModified = System.DateTimeOffset.Parse(_header, System.Globalization.CultureInfo.InvariantCulture);
                        }
                        if (response.Headers.TryGetValue("x-ms-copy-id", out _header))
                        {
                            _value.CopyId = _header;
                        }
                        if (response.Headers.TryGetValue("x-ms-copy-status", out _header))
                        {
                            _value.CopyStatus = Azure.Storage.Files.FileRestClient.Serialization.ParseCopyStatus(_header);
                        }

                        // Create the response
                        return Response.FromValue(_value, response);
                    }
                    default:
                    {
                        // Create the result
                        System.Xml.Linq.XDocument _xml = System.Xml.Linq.XDocument.Load(response.ContentStream, System.Xml.Linq.LoadOptions.PreserveWhitespace);
                        Azure.Storage.Files.Models.StorageError _value = Azure.Storage.Files.Models.StorageError.FromXml(_xml.Root);

                        throw _value.CreateException(response);
                    }
                }
            }
            #endregion File.StartCopyAsync

            #region File.AbortCopyAsync
            /// <summary>
            /// Aborts a pending Copy File operation, and leaves a destination file with zero length and full metadata.
            /// </summary>
            /// <param name="pipeline">The pipeline used for sending requests.</param>
            /// <param name="resourceUri">The URL of the service account, share, directory or file that is the target of the desired operation.</param>
            /// <param name="copyId">The copy identifier provided in the x-ms-copy-id header of the original Copy File operation.</param>
            /// <param name="timeout">The timeout parameter is expressed in seconds. For more information, see <a href="https://docs.microsoft.com/en-us/rest/api/storageservices/Setting-Timeouts-for-File-Service-Operations?redirectedfrom=MSDN">Setting Timeouts for File Service Operations.</a></param>
            /// <param name="async">Whether to invoke the operation asynchronously.  The default value is true.</param>
            /// <param name="clientDiagnostics">The ClientDiagnostics instance used for operation reporting.</param>
            /// <param name="operationName">Operation name.</param>
            /// <param name="cancellationToken">Cancellation token.</param>
            /// <returns>Azure.Response</returns>
            public static async System.Threading.Tasks.ValueTask<Azure.Response> AbortCopyAsync(
                Azure.Core.Pipeline.ClientDiagnostics clientDiagnostics,
                Azure.Core.Pipeline.HttpPipeline pipeline,
                System.Uri resourceUri,
                string copyId,
                int? timeout = default,
                bool async = true,
                string operationName = "Azure.Storage.Files.FileClient.AbortCopy",
                System.Threading.CancellationToken cancellationToken = default)
            {
                Azure.Core.Pipeline.DiagnosticScope _scope = clientDiagnostics.CreateScope(operationName);
                try
                {
                    _scope.AddAttribute("url", resourceUri);
                    _scope.Start();
                    using (Azure.Core.HttpMessage _message = AbortCopyAsync_CreateMessage(
                        pipeline,
                        resourceUri,
                        copyId,
                        timeout))
                    {
                        if (async)
                        {
                            // Send the request asynchronously if we're being called via an async path
                            await pipeline.SendAsync(_message, cancellationToken).ConfigureAwait(false);
                        }
                        else
                        {
                            // Send the request synchronously through the API that blocks if we're being called via a sync path
                            // (this is safe because the Task will complete before the user can call Wait)
                            pipeline.Send(_message, cancellationToken);
                        }
                        Azure.Response _response = _message.Response;
                        cancellationToken.ThrowIfCancellationRequested();
                        return AbortCopyAsync_CreateResponse(_response);
                    }
                }
                catch (System.Exception ex)
                {
                    _scope.Failed(ex);
                    throw;
                }
                finally
                {
                    _scope.Dispose();
                }
            }

            /// <summary>
            /// Create the File.AbortCopyAsync request.
            /// </summary>
            /// <param name="pipeline">The pipeline used for sending requests.</param>
            /// <param name="resourceUri">The URL of the service account, share, directory or file that is the target of the desired operation.</param>
            /// <param name="copyId">The copy identifier provided in the x-ms-copy-id header of the original Copy File operation.</param>
            /// <param name="timeout">The timeout parameter is expressed in seconds. For more information, see <a href="https://docs.microsoft.com/en-us/rest/api/storageservices/Setting-Timeouts-for-File-Service-Operations?redirectedfrom=MSDN">Setting Timeouts for File Service Operations.</a></param>
            /// <returns>The File.AbortCopyAsync Message.</returns>
            internal static Azure.Core.HttpMessage AbortCopyAsync_CreateMessage(
                Azure.Core.Pipeline.HttpPipeline pipeline,
                System.Uri resourceUri,
                string copyId,
                int? timeout = default)
            {
                // Validation
                if (resourceUri == null)
                {
                    throw new System.ArgumentNullException(nameof(resourceUri));
                }
                if (copyId == null)
                {
                    throw new System.ArgumentNullException(nameof(copyId));
                }

                // Create the request
                Azure.Core.HttpMessage _message = pipeline.CreateMessage();
                Azure.Core.Request _request = _message.Request;

                // Set the endpoint
                _request.Method = Azure.Core.RequestMethod.Put;
                _request.Uri.Reset(resourceUri);
                _request.Uri.AppendQuery("comp", "copy");
                _request.Uri.AppendQuery("copyid", System.Uri.EscapeDataString(copyId));
                if (timeout != null) { _request.Uri.AppendQuery("timeout", System.Uri.EscapeDataString(timeout.Value.ToString(System.Globalization.CultureInfo.InvariantCulture))); }

                // Add request headers
                _request.Headers.SetValue("x-ms-copy-action", "abort");
                _request.Headers.SetValue("x-ms-version", "2019-02-02");

                return _message;
            }

            /// <summary>
            /// Create the File.AbortCopyAsync response or throw a failure exception.
            /// </summary>
            /// <param name="response">The raw Response.</param>
            /// <returns>The File.AbortCopyAsync Azure.Response.</returns>
            internal static Azure.Response AbortCopyAsync_CreateResponse(
                Azure.Response response)
            {
                // Process the response
                switch (response.Status)
                {
                    case 204:
                    {
                        return response;
                    }
                    default:
                    {
                        // Create the result
                        System.Xml.Linq.XDocument _xml = System.Xml.Linq.XDocument.Load(response.ContentStream, System.Xml.Linq.LoadOptions.PreserveWhitespace);
                        Azure.Storage.Files.Models.StorageError _value = Azure.Storage.Files.Models.StorageError.FromXml(_xml.Root);

                        throw _value.CreateException(response);
                    }
                }
            }
            #endregion File.AbortCopyAsync

            #region File.ListHandlesAsync
            /// <summary>
            /// Lists handles for file
            /// </summary>
            /// <param name="pipeline">The pipeline used for sending requests.</param>
            /// <param name="resourceUri">The URL of the service account, share, directory or file that is the target of the desired operation.</param>
            /// <param name="marker">A string value that identifies the portion of the list to be returned with the next list operation. The operation returns a marker value within the response body if the list returned was not complete. The marker value may then be used in a subsequent call to request the next set of list items. The marker value is opaque to the client.</param>
            /// <param name="maxresults">Specifies the maximum number of entries to return. If the request does not specify maxresults, or specifies a value greater than 5,000, the server will return up to 5,000 items.</param>
            /// <param name="timeout">The timeout parameter is expressed in seconds. For more information, see <a href="https://docs.microsoft.com/en-us/rest/api/storageservices/Setting-Timeouts-for-File-Service-Operations?redirectedfrom=MSDN">Setting Timeouts for File Service Operations.</a></param>
            /// <param name="sharesnapshot">The snapshot parameter is an opaque DateTime value that, when present, specifies the share snapshot to query.</param>
            /// <param name="async">Whether to invoke the operation asynchronously.  The default value is true.</param>
            /// <param name="clientDiagnostics">The ClientDiagnostics instance used for operation reporting.</param>
            /// <param name="operationName">Operation name.</param>
            /// <param name="cancellationToken">Cancellation token.</param>
            /// <returns>An enumeration of handles.</returns>
            public static async System.Threading.Tasks.ValueTask<Azure.Response<Azure.Storage.Files.Models.StorageHandlesSegment>> ListHandlesAsync(
                Azure.Core.Pipeline.ClientDiagnostics clientDiagnostics,
                Azure.Core.Pipeline.HttpPipeline pipeline,
                System.Uri resourceUri,
                string marker = default,
                int? maxresults = default,
                int? timeout = default,
                string sharesnapshot = default,
                bool async = true,
                string operationName = "Azure.Storage.Files.FileClient.ListHandles",
                System.Threading.CancellationToken cancellationToken = default)
            {
                Azure.Core.Pipeline.DiagnosticScope _scope = clientDiagnostics.CreateScope(operationName);
                try
                {
                    _scope.AddAttribute("url", resourceUri);
                    _scope.Start();
                    using (Azure.Core.HttpMessage _message = ListHandlesAsync_CreateMessage(
                        pipeline,
                        resourceUri,
                        marker,
                        maxresults,
                        timeout,
                        sharesnapshot))
                    {
                        if (async)
                        {
                            // Send the request asynchronously if we're being called via an async path
                            await pipeline.SendAsync(_message, cancellationToken).ConfigureAwait(false);
                        }
                        else
                        {
                            // Send the request synchronously through the API that blocks if we're being called via a sync path
                            // (this is safe because the Task will complete before the user can call Wait)
                            pipeline.Send(_message, cancellationToken);
                        }
                        Azure.Response _response = _message.Response;
                        cancellationToken.ThrowIfCancellationRequested();
                        return ListHandlesAsync_CreateResponse(_response);
                    }
                }
                catch (System.Exception ex)
                {
                    _scope.Failed(ex);
                    throw;
                }
                finally
                {
                    _scope.Dispose();
                }
            }

            /// <summary>
            /// Create the File.ListHandlesAsync request.
            /// </summary>
            /// <param name="pipeline">The pipeline used for sending requests.</param>
            /// <param name="resourceUri">The URL of the service account, share, directory or file that is the target of the desired operation.</param>
            /// <param name="marker">A string value that identifies the portion of the list to be returned with the next list operation. The operation returns a marker value within the response body if the list returned was not complete. The marker value may then be used in a subsequent call to request the next set of list items. The marker value is opaque to the client.</param>
            /// <param name="maxresults">Specifies the maximum number of entries to return. If the request does not specify maxresults, or specifies a value greater than 5,000, the server will return up to 5,000 items.</param>
            /// <param name="timeout">The timeout parameter is expressed in seconds. For more information, see <a href="https://docs.microsoft.com/en-us/rest/api/storageservices/Setting-Timeouts-for-File-Service-Operations?redirectedfrom=MSDN">Setting Timeouts for File Service Operations.</a></param>
            /// <param name="sharesnapshot">The snapshot parameter is an opaque DateTime value that, when present, specifies the share snapshot to query.</param>
            /// <returns>The File.ListHandlesAsync Message.</returns>
            internal static Azure.Core.HttpMessage ListHandlesAsync_CreateMessage(
                Azure.Core.Pipeline.HttpPipeline pipeline,
                System.Uri resourceUri,
                string marker = default,
                int? maxresults = default,
                int? timeout = default,
                string sharesnapshot = default)
            {
                // Validation
                if (resourceUri == null)
                {
                    throw new System.ArgumentNullException(nameof(resourceUri));
                }

                // Create the request
                Azure.Core.HttpMessage _message = pipeline.CreateMessage();
                Azure.Core.Request _request = _message.Request;

                // Set the endpoint
                _request.Method = Azure.Core.RequestMethod.Get;
                _request.Uri.Reset(resourceUri);
                _request.Uri.AppendQuery("comp", "listhandles");
                if (marker != null) { _request.Uri.AppendQuery("marker", System.Uri.EscapeDataString(marker)); }
                if (maxresults != null) { _request.Uri.AppendQuery("maxresults", System.Uri.EscapeDataString(maxresults.Value.ToString(System.Globalization.CultureInfo.InvariantCulture))); }
                if (timeout != null) { _request.Uri.AppendQuery("timeout", System.Uri.EscapeDataString(timeout.Value.ToString(System.Globalization.CultureInfo.InvariantCulture))); }
                if (sharesnapshot != null) { _request.Uri.AppendQuery("sharesnapshot", System.Uri.EscapeDataString(sharesnapshot)); }

                // Add request headers
                _request.Headers.SetValue("x-ms-version", "2019-02-02");

                return _message;
            }

            /// <summary>
            /// Create the File.ListHandlesAsync response or throw a failure exception.
            /// </summary>
            /// <param name="response">The raw Response.</param>
            /// <returns>The File.ListHandlesAsync Azure.Response{Azure.Storage.Files.Models.StorageHandlesSegment}.</returns>
            internal static Azure.Response<Azure.Storage.Files.Models.StorageHandlesSegment> ListHandlesAsync_CreateResponse(
                Azure.Response response)
            {
                // Process the response
                switch (response.Status)
                {
                    case 200:
                    {
                        // Create the result
                        System.Xml.Linq.XDocument _xml = System.Xml.Linq.XDocument.Load(response.ContentStream, System.Xml.Linq.LoadOptions.PreserveWhitespace);
                        Azure.Storage.Files.Models.StorageHandlesSegment _value = Azure.Storage.Files.Models.StorageHandlesSegment.FromXml(_xml.Root);

                        // Create the response
                        return Response.FromValue(_value, response);
                    }
                    default:
                    {
                        // Create the result
                        System.Xml.Linq.XDocument _xml = System.Xml.Linq.XDocument.Load(response.ContentStream, System.Xml.Linq.LoadOptions.PreserveWhitespace);
                        Azure.Storage.Files.Models.StorageError _value = Azure.Storage.Files.Models.StorageError.FromXml(_xml.Root);

                        throw _value.CreateException(response);
                    }
                }
            }
            #endregion File.ListHandlesAsync

            #region File.ForceCloseHandlesAsync
            /// <summary>
            /// Closes all handles open for given file
            /// </summary>
            /// <param name="pipeline">The pipeline used for sending requests.</param>
            /// <param name="resourceUri">The URL of the service account, share, directory or file that is the target of the desired operation.</param>
            /// <param name="handleId">Specifies handle ID opened on the file or directory to be closed. Asterix (‘*’) is a wildcard that specifies all handles.</param>
            /// <param name="timeout">The timeout parameter is expressed in seconds. For more information, see <a href="https://docs.microsoft.com/en-us/rest/api/storageservices/Setting-Timeouts-for-File-Service-Operations?redirectedfrom=MSDN">Setting Timeouts for File Service Operations.</a></param>
            /// <param name="marker">A string value that identifies the portion of the list to be returned with the next list operation. The operation returns a marker value within the response body if the list returned was not complete. The marker value may then be used in a subsequent call to request the next set of list items. The marker value is opaque to the client.</param>
            /// <param name="sharesnapshot">The snapshot parameter is an opaque DateTime value that, when present, specifies the share snapshot to query.</param>
            /// <param name="async">Whether to invoke the operation asynchronously.  The default value is true.</param>
            /// <param name="clientDiagnostics">The ClientDiagnostics instance used for operation reporting.</param>
            /// <param name="operationName">Operation name.</param>
            /// <param name="cancellationToken">Cancellation token.</param>
            /// <returns>Azure.Response{Azure.Storage.Files.Models.StorageClosedHandlesSegment}</returns>
            public static async System.Threading.Tasks.ValueTask<Azure.Response<Azure.Storage.Files.Models.StorageClosedHandlesSegment>> ForceCloseHandlesAsync(
                Azure.Core.Pipeline.ClientDiagnostics clientDiagnostics,
                Azure.Core.Pipeline.HttpPipeline pipeline,
                System.Uri resourceUri,
                string handleId,
                int? timeout = default,
                string marker = default,
                string sharesnapshot = default,
                bool async = true,
                string operationName = "Azure.Storage.Files.FileClient.ForceCloseHandles",
                System.Threading.CancellationToken cancellationToken = default)
            {
                Azure.Core.Pipeline.DiagnosticScope _scope = clientDiagnostics.CreateScope(operationName);
                try
                {
                    _scope.AddAttribute("url", resourceUri);
                    _scope.Start();
                    using (Azure.Core.HttpMessage _message = ForceCloseHandlesAsync_CreateMessage(
                        pipeline,
                        resourceUri,
                        handleId,
                        timeout,
                        marker,
                        sharesnapshot))
                    {
                        if (async)
                        {
                            // Send the request asynchronously if we're being called via an async path
                            await pipeline.SendAsync(_message, cancellationToken).ConfigureAwait(false);
                        }
                        else
                        {
                            // Send the request synchronously through the API that blocks if we're being called via a sync path
                            // (this is safe because the Task will complete before the user can call Wait)
                            pipeline.Send(_message, cancellationToken);
                        }
                        Azure.Response _response = _message.Response;
                        cancellationToken.ThrowIfCancellationRequested();
                        return ForceCloseHandlesAsync_CreateResponse(_response);
                    }
                }
                catch (System.Exception ex)
                {
                    _scope.Failed(ex);
                    throw;
                }
                finally
                {
                    _scope.Dispose();
                }
            }

            /// <summary>
            /// Create the File.ForceCloseHandlesAsync request.
            /// </summary>
            /// <param name="pipeline">The pipeline used for sending requests.</param>
            /// <param name="resourceUri">The URL of the service account, share, directory or file that is the target of the desired operation.</param>
            /// <param name="handleId">Specifies handle ID opened on the file or directory to be closed. Asterix (‘*’) is a wildcard that specifies all handles.</param>
            /// <param name="timeout">The timeout parameter is expressed in seconds. For more information, see <a href="https://docs.microsoft.com/en-us/rest/api/storageservices/Setting-Timeouts-for-File-Service-Operations?redirectedfrom=MSDN">Setting Timeouts for File Service Operations.</a></param>
            /// <param name="marker">A string value that identifies the portion of the list to be returned with the next list operation. The operation returns a marker value within the response body if the list returned was not complete. The marker value may then be used in a subsequent call to request the next set of list items. The marker value is opaque to the client.</param>
            /// <param name="sharesnapshot">The snapshot parameter is an opaque DateTime value that, when present, specifies the share snapshot to query.</param>
            /// <returns>The File.ForceCloseHandlesAsync Message.</returns>
            internal static Azure.Core.HttpMessage ForceCloseHandlesAsync_CreateMessage(
                Azure.Core.Pipeline.HttpPipeline pipeline,
                System.Uri resourceUri,
                string handleId,
                int? timeout = default,
                string marker = default,
                string sharesnapshot = default)
            {
                // Validation
                if (resourceUri == null)
                {
                    throw new System.ArgumentNullException(nameof(resourceUri));
                }
                if (handleId == null)
                {
                    throw new System.ArgumentNullException(nameof(handleId));
                }

                // Create the request
                Azure.Core.HttpMessage _message = pipeline.CreateMessage();
                Azure.Core.Request _request = _message.Request;

                // Set the endpoint
                _request.Method = Azure.Core.RequestMethod.Put;
                _request.Uri.Reset(resourceUri);
                _request.Uri.AppendQuery("comp", "forceclosehandles");
                if (timeout != null) { _request.Uri.AppendQuery("timeout", System.Uri.EscapeDataString(timeout.Value.ToString(System.Globalization.CultureInfo.InvariantCulture))); }
                if (marker != null) { _request.Uri.AppendQuery("marker", System.Uri.EscapeDataString(marker)); }
                if (sharesnapshot != null) { _request.Uri.AppendQuery("sharesnapshot", System.Uri.EscapeDataString(sharesnapshot)); }

                // Add request headers
                _request.Headers.SetValue("x-ms-handle-id", handleId);
                _request.Headers.SetValue("x-ms-version", "2019-02-02");

                return _message;
            }

            /// <summary>
            /// Create the File.ForceCloseHandlesAsync response or throw a failure exception.
            /// </summary>
            /// <param name="response">The raw Response.</param>
            /// <returns>The File.ForceCloseHandlesAsync Azure.Response{Azure.Storage.Files.Models.StorageClosedHandlesSegment}.</returns>
            internal static Azure.Response<Azure.Storage.Files.Models.StorageClosedHandlesSegment> ForceCloseHandlesAsync_CreateResponse(
                Azure.Response response)
            {
                // Process the response
                switch (response.Status)
                {
                    case 200:
                    {
                        // Create the result
                        Azure.Storage.Files.Models.StorageClosedHandlesSegment _value = new Azure.Storage.Files.Models.StorageClosedHandlesSegment();

                        // Get response headers
                        string _header;
                        if (response.Headers.TryGetValue("x-ms-marker", out _header))
                        {
                            _value.Marker = _header;
                        }
                        if (response.Headers.TryGetValue("x-ms-number-of-handles-closed", out _header))
                        {
                            _value.NumberOfHandlesClosed = int.Parse(_header, System.Globalization.CultureInfo.InvariantCulture);
                        }

                        // Create the response
                        return Response.FromValue(_value, response);
                    }
                    default:
                    {
                        // Create the result
                        System.Xml.Linq.XDocument _xml = System.Xml.Linq.XDocument.Load(response.ContentStream, System.Xml.Linq.LoadOptions.PreserveWhitespace);
                        Azure.Storage.Files.Models.StorageError _value = Azure.Storage.Files.Models.StorageError.FromXml(_xml.Root);

                        throw _value.CreateException(response);
                    }
                }
            }
            #endregion File.ForceCloseHandlesAsync
        }
        #endregion File operations
    }
}
#endregion Service

#region Models
#region class AccessPolicy
namespace Azure.Storage.Files.Models
{
    /// <summary>
    /// An Access policy.
    /// </summary>
    public partial class AccessPolicy
    {
        /// <summary>
        /// The date-time the policy is active.
        /// </summary>
        public System.DateTimeOffset? Start { get; set; }

        /// <summary>
        /// The date-time the policy expires.
        /// </summary>
        public System.DateTimeOffset? Expiry { get; set; }

        /// <summary>
        /// The permissions for the ACL policy.
        /// </summary>
        public string Permission { get; set; }

        /// <summary>
        /// Prevent direct instantiation of AccessPolicy instances.
        /// You can use FilesModelFactory.AccessPolicy instead.
        /// </summary>
        internal AccessPolicy() { }

        /// <summary>
        /// Serialize a AccessPolicy instance as XML.
        /// </summary>
        /// <param name="value">The AccessPolicy instance to serialize.</param>
        /// <param name="name">An optional name to use for the root element instead of "AccessPolicy".</param>
        /// <param name="ns">An optional namespace to use for the root element instead of "".</param>
        /// <returns>The serialized XML element.</returns>
        internal static System.Xml.Linq.XElement ToXml(Azure.Storage.Files.Models.AccessPolicy value, string name = "AccessPolicy", string ns = "")
        {
            System.Diagnostics.Debug.Assert(value != null);
            System.Xml.Linq.XElement _element = new System.Xml.Linq.XElement(System.Xml.Linq.XName.Get(name, ns));
            if (value.Start != null)
            {
                _element.Add(new System.Xml.Linq.XElement(
                    System.Xml.Linq.XName.Get("Start", ""),
                    value.Start.Value.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.fffffffZ", System.Globalization.CultureInfo.InvariantCulture)));
            }
            if (value.Expiry != null)
            {
                _element.Add(new System.Xml.Linq.XElement(
                    System.Xml.Linq.XName.Get("Expiry", ""),
                    value.Expiry.Value.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.fffffffZ", System.Globalization.CultureInfo.InvariantCulture)));
            }
            if (value.Permission != null)
            {
                _element.Add(new System.Xml.Linq.XElement(
                    System.Xml.Linq.XName.Get("Permission", ""),
                    value.Permission));
            }
            return _element;
        }

        /// <summary>
        /// Deserializes XML into a new AccessPolicy instance.
        /// </summary>
        /// <param name="element">The XML element to deserialize.</param>
        /// <returns>A deserialized AccessPolicy instance.</returns>
        internal static Azure.Storage.Files.Models.AccessPolicy FromXml(System.Xml.Linq.XElement element)
        {
            System.Diagnostics.Debug.Assert(element != null);
            System.Xml.Linq.XElement _child;
            Azure.Storage.Files.Models.AccessPolicy _value = new Azure.Storage.Files.Models.AccessPolicy();
            _child = element.Element(System.Xml.Linq.XName.Get("Start", ""));
            if (_child != null)
            {
                _value.Start = System.DateTimeOffset.Parse(_child.Value, System.Globalization.CultureInfo.InvariantCulture);
            }
            _child = element.Element(System.Xml.Linq.XName.Get("Expiry", ""));
            if (_child != null)
            {
                _value.Expiry = System.DateTimeOffset.Parse(_child.Value, System.Globalization.CultureInfo.InvariantCulture);
            }
            _child = element.Element(System.Xml.Linq.XName.Get("Permission", ""));
            if (_child != null)
            {
                _value.Permission = _child.Value;
            }
            CustomizeFromXml(element, _value);
            return _value;
        }

        static partial void CustomizeFromXml(System.Xml.Linq.XElement element, Azure.Storage.Files.Models.AccessPolicy value);
    }
}
#endregion class AccessPolicy

#region enum CopyStatus
namespace Azure.Storage.Files.Models
{
    /// <summary>
    /// State of the copy operation identified by 'x-ms-copy-id'.
    /// </summary>
    #pragma warning disable CA1717 // Only FlagsAttribute enums should have plural names
    public enum CopyStatus
    #pragma warning restore CA1717 // Only FlagsAttribute enums should have plural names
    {
        /// <summary>
        /// pending
        /// </summary>
        Pending,

        /// <summary>
        /// success
        /// </summary>
        Success,

        /// <summary>
        /// aborted
        /// </summary>
        Aborted,

        /// <summary>
        /// failed
        /// </summary>
        Failed
    }
}

namespace Azure.Storage.Files
{
    internal static partial class FileRestClient
    {
        public static partial class Serialization
        {
            public static string ToString(Azure.Storage.Files.Models.CopyStatus value)
            {
                return value switch
                {
                    Azure.Storage.Files.Models.CopyStatus.Pending => "pending",
                    Azure.Storage.Files.Models.CopyStatus.Success => "success",
                    Azure.Storage.Files.Models.CopyStatus.Aborted => "aborted",
                    Azure.Storage.Files.Models.CopyStatus.Failed => "failed",
                    _ => throw new System.ArgumentOutOfRangeException(nameof(value), value, "Unknown Azure.Storage.Files.Models.CopyStatus value.")
                };
            }

            public static Azure.Storage.Files.Models.CopyStatus ParseCopyStatus(string value)
            {
                return value switch
                {
                    "pending" => Azure.Storage.Files.Models.CopyStatus.Pending,
                    "success" => Azure.Storage.Files.Models.CopyStatus.Success,
                    "aborted" => Azure.Storage.Files.Models.CopyStatus.Aborted,
                    "failed" => Azure.Storage.Files.Models.CopyStatus.Failed,
                    _ => throw new System.ArgumentOutOfRangeException(nameof(value), value, "Unknown Azure.Storage.Files.Models.CopyStatus value.")
                };
            }
        }
    }
}
#endregion enum CopyStatus

#region enum DeleteSnapshotsOptionType
namespace Azure.Storage.Files.Models
{
    /// <summary>
    /// Specifies the option include to delete the base share and all of its snapshots.
    /// </summary>
    public enum DeleteSnapshotsOptionType
    {
        /// <summary>
        /// include
        /// </summary>
        Include
    }
}

namespace Azure.Storage.Files
{
    internal static partial class FileRestClient
    {
        public static partial class Serialization
        {
            public static string ToString(Azure.Storage.Files.Models.DeleteSnapshotsOptionType value)
            {
                return value switch
                {
                    Azure.Storage.Files.Models.DeleteSnapshotsOptionType.Include => "include",
                    _ => throw new System.ArgumentOutOfRangeException(nameof(value), value, "Unknown Azure.Storage.Files.Models.DeleteSnapshotsOptionType value.")
                };
            }

            public static Azure.Storage.Files.Models.DeleteSnapshotsOptionType ParseDeleteSnapshotsOptionType(string value)
            {
                return value switch
                {
                    "include" => Azure.Storage.Files.Models.DeleteSnapshotsOptionType.Include,
                    _ => throw new System.ArgumentOutOfRangeException(nameof(value), value, "Unknown Azure.Storage.Files.Models.DeleteSnapshotsOptionType value.")
                };
            }
        }
    }
}
#endregion enum DeleteSnapshotsOptionType

#region class DirectoryItem
namespace Azure.Storage.Files.Models
{
    /// <summary>
    /// A listed directory item.
    /// </summary>
    internal partial class DirectoryItem
    {
        /// <summary>
        /// Name
        /// </summary>
        public string Name { get; internal set; }

        /// <summary>
        /// Prevent direct instantiation of DirectoryItem instances.
        /// You can use FilesModelFactory.DirectoryItem instead.
        /// </summary>
        internal DirectoryItem() { }

        /// <summary>
        /// Deserializes XML into a new DirectoryItem instance.
        /// </summary>
        /// <param name="element">The XML element to deserialize.</param>
        /// <returns>A deserialized DirectoryItem instance.</returns>
        internal static Azure.Storage.Files.Models.DirectoryItem FromXml(System.Xml.Linq.XElement element)
        {
            System.Diagnostics.Debug.Assert(element != null);
            System.Xml.Linq.XElement _child;
            Azure.Storage.Files.Models.DirectoryItem _value = new Azure.Storage.Files.Models.DirectoryItem();
            _child = element.Element(System.Xml.Linq.XName.Get("Name", ""));
            if (_child != null)
            {
                _value.Name = _child.Value;
            }
            CustomizeFromXml(element, _value);
            return _value;
        }

        static partial void CustomizeFromXml(System.Xml.Linq.XElement element, Azure.Storage.Files.Models.DirectoryItem value);
    }
}
#endregion class DirectoryItem

#region class FailureNoContent
namespace Azure.Storage.Files.Models
{
    /// <summary>
    /// FailureNoContent
    /// </summary>
    internal partial class FailureNoContent
    {
        /// <summary>
        /// x-ms-error-code
        /// </summary>
        public string ErrorCode { get; internal set; }

        /// <summary>
        /// Prevent direct instantiation of FailureNoContent instances.
        /// You can use FilesModelFactory.FailureNoContent instead.
        /// </summary>
        internal FailureNoContent() { }
    }
}
#endregion class FailureNoContent

#region class FileUploadRangeFromURLResult
namespace Azure.Storage.Files.Models
{
    /// <summary>
    /// File UploadRangeFromURLResult
    /// </summary>
    internal partial class FileUploadRangeFromURLResult
    {
        /// <summary>
        /// The ETag contains a value which represents the version of the file, in quotes.
        /// </summary>
        public Azure.ETag ETag { get; internal set; }

        /// <summary>
        /// Returns the date and time the directory was last modified. Any operation that modifies the share or its properties or metadata updates the last modified time. Operations on files do not affect the last modified time of the share.
        /// </summary>
        public System.DateTimeOffset LastModified { get; internal set; }

        /// <summary>
        /// This header is returned so that the client can check for message content integrity. The value of this header is computed by the File service; it is not necessarily the same value as may have been specified in the request headers.
        /// </summary>
        #pragma warning disable CA1819 // Properties should not return arrays
        public byte[] XMSContentCrc64 { get; internal set; }
        #pragma warning restore CA1819 // Properties should not return arrays

        /// <summary>
        /// The value of this header is set to true if the contents of the request are successfully encrypted using the specified algorithm, and false otherwise.
        /// </summary>
        public bool IsServerEncrypted { get; internal set; }

        /// <summary>
        /// Prevent direct instantiation of FileUploadRangeFromURLResult instances.
        /// You can use FilesModelFactory.FileUploadRangeFromURLResult instead.
        /// </summary>
        internal FileUploadRangeFromURLResult() { }
    }
}
#endregion class FileUploadRangeFromURLResult

#region class FileCorsRule
namespace Azure.Storage.Files.Models
{
    /// <summary>
    /// CORS is an HTTP feature that enables a web application running under one domain to access resources in another domain. Web browsers implement a security restriction known as same-origin policy that prevents a web page from calling APIs in a different domain; CORS provides a secure way to allow one domain (the origin domain) to call APIs in another domain.
    /// </summary>
    public partial class FileCorsRule
    {
        /// <summary>
        /// The origin domains that are permitted to make a request against the storage service via CORS. The origin domain is the domain from which the request originates. Note that the origin must be an exact case-sensitive match with the origin that the user age sends to the service. You can also use the wildcard character '*' to allow all origin domains to make requests via CORS.
        /// </summary>
        public string AllowedOrigins { get; set; }

        /// <summary>
        /// The methods (HTTP request verbs) that the origin domain may use for a CORS request. (comma separated)
        /// </summary>
        public string AllowedMethods { get; set; }

        /// <summary>
        /// The request headers that the origin domain may specify on the CORS request.
        /// </summary>
        public string AllowedHeaders { get; set; }

        /// <summary>
        /// The response headers that may be sent in the response to the CORS request and exposed by the browser to the request issuer.
        /// </summary>
        public string ExposedHeaders { get; set; }

        /// <summary>
        /// The maximum amount time that a browser should cache the preflight OPTIONS request.
        /// </summary>
        public int MaxAgeInSeconds { get; set; }

        /// <summary>
        /// Prevent direct instantiation of FileCorsRule instances.
        /// You can use FilesModelFactory.FileCorsRule instead.
        /// </summary>
        internal FileCorsRule() { }

        /// <summary>
        /// Serialize a FileCorsRule instance as XML.
        /// </summary>
        /// <param name="value">The FileCorsRule instance to serialize.</param>
        /// <param name="name">An optional name to use for the root element instead of "CorsRule".</param>
        /// <param name="ns">An optional namespace to use for the root element instead of "".</param>
        /// <returns>The serialized XML element.</returns>
        internal static System.Xml.Linq.XElement ToXml(Azure.Storage.Files.Models.FileCorsRule value, string name = "CorsRule", string ns = "")
        {
            System.Diagnostics.Debug.Assert(value != null);
            System.Xml.Linq.XElement _element = new System.Xml.Linq.XElement(System.Xml.Linq.XName.Get(name, ns));
            _element.Add(new System.Xml.Linq.XElement(
                System.Xml.Linq.XName.Get("AllowedOrigins", ""),
                value.AllowedOrigins));
            _element.Add(new System.Xml.Linq.XElement(
                System.Xml.Linq.XName.Get("AllowedMethods", ""),
                value.AllowedMethods));
            _element.Add(new System.Xml.Linq.XElement(
                System.Xml.Linq.XName.Get("AllowedHeaders", ""),
                value.AllowedHeaders));
            _element.Add(new System.Xml.Linq.XElement(
                System.Xml.Linq.XName.Get("ExposedHeaders", ""),
                value.ExposedHeaders));
            _element.Add(new System.Xml.Linq.XElement(
                System.Xml.Linq.XName.Get("MaxAgeInSeconds", ""),
                value.MaxAgeInSeconds.ToString(System.Globalization.CultureInfo.InvariantCulture)));
            return _element;
        }

        /// <summary>
        /// Deserializes XML into a new FileCorsRule instance.
        /// </summary>
        /// <param name="element">The XML element to deserialize.</param>
        /// <returns>A deserialized FileCorsRule instance.</returns>
        internal static Azure.Storage.Files.Models.FileCorsRule FromXml(System.Xml.Linq.XElement element)
        {
            System.Diagnostics.Debug.Assert(element != null);
            System.Xml.Linq.XElement _child;
            Azure.Storage.Files.Models.FileCorsRule _value = new Azure.Storage.Files.Models.FileCorsRule();
            _child = element.Element(System.Xml.Linq.XName.Get("AllowedOrigins", ""));
            if (_child != null)
            {
                _value.AllowedOrigins = _child.Value;
            }
            _child = element.Element(System.Xml.Linq.XName.Get("AllowedMethods", ""));
            if (_child != null)
            {
                _value.AllowedMethods = _child.Value;
            }
            _child = element.Element(System.Xml.Linq.XName.Get("AllowedHeaders", ""));
            if (_child != null)
            {
                _value.AllowedHeaders = _child.Value;
            }
            _child = element.Element(System.Xml.Linq.XName.Get("ExposedHeaders", ""));
            if (_child != null)
            {
                _value.ExposedHeaders = _child.Value;
            }
            _child = element.Element(System.Xml.Linq.XName.Get("MaxAgeInSeconds", ""));
            if (_child != null)
            {
                _value.MaxAgeInSeconds = int.Parse(_child.Value, System.Globalization.CultureInfo.InvariantCulture);
            }
            CustomizeFromXml(element, _value);
            return _value;
        }

        static partial void CustomizeFromXml(System.Xml.Linq.XElement element, Azure.Storage.Files.Models.FileCorsRule value);
    }
}
#endregion class FileCorsRule

#region enum strings FileErrorCode
namespace Azure.Storage.Files.Models
{
    /// <summary>
    /// Error codes returned by the service
    /// </summary>
    public partial struct FileErrorCode : System.IEquatable<FileErrorCode>
    {
        #pragma warning disable CA2211 // Non-constant fields should not be visible
        /// <summary>
        /// AccountAlreadyExists
        /// </summary>
        public static Azure.Storage.Files.Models.FileErrorCode AccountAlreadyExists { get; } = @"AccountAlreadyExists";

        /// <summary>
        /// AccountBeingCreated
        /// </summary>
        public static Azure.Storage.Files.Models.FileErrorCode AccountBeingCreated { get; } = @"AccountBeingCreated";

        /// <summary>
        /// AccountIsDisabled
        /// </summary>
        public static Azure.Storage.Files.Models.FileErrorCode AccountIsDisabled { get; } = @"AccountIsDisabled";

        /// <summary>
        /// AuthenticationFailed
        /// </summary>
        public static Azure.Storage.Files.Models.FileErrorCode AuthenticationFailed { get; } = @"AuthenticationFailed";

        /// <summary>
        /// AuthorizationFailure
        /// </summary>
        public static Azure.Storage.Files.Models.FileErrorCode AuthorizationFailure { get; } = @"AuthorizationFailure";

        /// <summary>
        /// ConditionHeadersNotSupported
        /// </summary>
        public static Azure.Storage.Files.Models.FileErrorCode ConditionHeadersNotSupported { get; } = @"ConditionHeadersNotSupported";

        /// <summary>
        /// ConditionNotMet
        /// </summary>
        public static Azure.Storage.Files.Models.FileErrorCode ConditionNotMet { get; } = @"ConditionNotMet";

        /// <summary>
        /// EmptyMetadataKey
        /// </summary>
        public static Azure.Storage.Files.Models.FileErrorCode EmptyMetadataKey { get; } = @"EmptyMetadataKey";

        /// <summary>
        /// InsufficientAccountPermissions
        /// </summary>
        public static Azure.Storage.Files.Models.FileErrorCode InsufficientAccountPermissions { get; } = @"InsufficientAccountPermissions";

        /// <summary>
        /// InternalError
        /// </summary>
        public static Azure.Storage.Files.Models.FileErrorCode InternalError { get; } = @"InternalError";

        /// <summary>
        /// InvalidAuthenticationInfo
        /// </summary>
        public static Azure.Storage.Files.Models.FileErrorCode InvalidAuthenticationInfo { get; } = @"InvalidAuthenticationInfo";

        /// <summary>
        /// InvalidHeaderValue
        /// </summary>
        public static Azure.Storage.Files.Models.FileErrorCode InvalidHeaderValue { get; } = @"InvalidHeaderValue";

        /// <summary>
        /// InvalidHttpVerb
        /// </summary>
        public static Azure.Storage.Files.Models.FileErrorCode InvalidHttpVerb { get; } = @"InvalidHttpVerb";

        /// <summary>
        /// InvalidInput
        /// </summary>
        public static Azure.Storage.Files.Models.FileErrorCode InvalidInput { get; } = @"InvalidInput";

        /// <summary>
        /// InvalidMd5
        /// </summary>
        public static Azure.Storage.Files.Models.FileErrorCode InvalidMd5 { get; } = @"InvalidMd5";

        /// <summary>
        /// InvalidMetadata
        /// </summary>
        public static Azure.Storage.Files.Models.FileErrorCode InvalidMetadata { get; } = @"InvalidMetadata";

        /// <summary>
        /// InvalidQueryParameterValue
        /// </summary>
        public static Azure.Storage.Files.Models.FileErrorCode InvalidQueryParameterValue { get; } = @"InvalidQueryParameterValue";

        /// <summary>
        /// InvalidRange
        /// </summary>
        public static Azure.Storage.Files.Models.FileErrorCode InvalidRange { get; } = @"InvalidRange";

        /// <summary>
        /// InvalidResourceName
        /// </summary>
        public static Azure.Storage.Files.Models.FileErrorCode InvalidResourceName { get; } = @"InvalidResourceName";

        /// <summary>
        /// InvalidUri
        /// </summary>
        public static Azure.Storage.Files.Models.FileErrorCode InvalidUri { get; } = @"InvalidUri";

        /// <summary>
        /// InvalidXmlDocument
        /// </summary>
        public static Azure.Storage.Files.Models.FileErrorCode InvalidXmlDocument { get; } = @"InvalidXmlDocument";

        /// <summary>
        /// InvalidXmlNodeValue
        /// </summary>
        public static Azure.Storage.Files.Models.FileErrorCode InvalidXmlNodeValue { get; } = @"InvalidXmlNodeValue";

        /// <summary>
        /// Md5Mismatch
        /// </summary>
        public static Azure.Storage.Files.Models.FileErrorCode Md5Mismatch { get; } = @"Md5Mismatch";

        /// <summary>
        /// MetadataTooLarge
        /// </summary>
        public static Azure.Storage.Files.Models.FileErrorCode MetadataTooLarge { get; } = @"MetadataTooLarge";

        /// <summary>
        /// MissingContentLengthHeader
        /// </summary>
        public static Azure.Storage.Files.Models.FileErrorCode MissingContentLengthHeader { get; } = @"MissingContentLengthHeader";

        /// <summary>
        /// MissingRequiredQueryParameter
        /// </summary>
        public static Azure.Storage.Files.Models.FileErrorCode MissingRequiredQueryParameter { get; } = @"MissingRequiredQueryParameter";

        /// <summary>
        /// MissingRequiredHeader
        /// </summary>
        public static Azure.Storage.Files.Models.FileErrorCode MissingRequiredHeader { get; } = @"MissingRequiredHeader";

        /// <summary>
        /// MissingRequiredXmlNode
        /// </summary>
        public static Azure.Storage.Files.Models.FileErrorCode MissingRequiredXmlNode { get; } = @"MissingRequiredXmlNode";

        /// <summary>
        /// MultipleConditionHeadersNotSupported
        /// </summary>
        public static Azure.Storage.Files.Models.FileErrorCode MultipleConditionHeadersNotSupported { get; } = @"MultipleConditionHeadersNotSupported";

        /// <summary>
        /// OperationTimedOut
        /// </summary>
        public static Azure.Storage.Files.Models.FileErrorCode OperationTimedOut { get; } = @"OperationTimedOut";

        /// <summary>
        /// OutOfRangeInput
        /// </summary>
        public static Azure.Storage.Files.Models.FileErrorCode OutOfRangeInput { get; } = @"OutOfRangeInput";

        /// <summary>
        /// OutOfRangeQueryParameterValue
        /// </summary>
        public static Azure.Storage.Files.Models.FileErrorCode OutOfRangeQueryParameterValue { get; } = @"OutOfRangeQueryParameterValue";

        /// <summary>
        /// RequestBodyTooLarge
        /// </summary>
        public static Azure.Storage.Files.Models.FileErrorCode RequestBodyTooLarge { get; } = @"RequestBodyTooLarge";

        /// <summary>
        /// ResourceTypeMismatch
        /// </summary>
        public static Azure.Storage.Files.Models.FileErrorCode ResourceTypeMismatch { get; } = @"ResourceTypeMismatch";

        /// <summary>
        /// RequestUrlFailedToParse
        /// </summary>
        public static Azure.Storage.Files.Models.FileErrorCode RequestUrlFailedToParse { get; } = @"RequestUrlFailedToParse";

        /// <summary>
        /// ResourceAlreadyExists
        /// </summary>
        public static Azure.Storage.Files.Models.FileErrorCode ResourceAlreadyExists { get; } = @"ResourceAlreadyExists";

        /// <summary>
        /// ResourceNotFound
        /// </summary>
        public static Azure.Storage.Files.Models.FileErrorCode ResourceNotFound { get; } = @"ResourceNotFound";

        /// <summary>
        /// ServerBusy
        /// </summary>
        public static Azure.Storage.Files.Models.FileErrorCode ServerBusy { get; } = @"ServerBusy";

        /// <summary>
        /// UnsupportedHeader
        /// </summary>
        public static Azure.Storage.Files.Models.FileErrorCode UnsupportedHeader { get; } = @"UnsupportedHeader";

        /// <summary>
        /// UnsupportedXmlNode
        /// </summary>
        public static Azure.Storage.Files.Models.FileErrorCode UnsupportedXmlNode { get; } = @"UnsupportedXmlNode";

        /// <summary>
        /// UnsupportedQueryParameter
        /// </summary>
        public static Azure.Storage.Files.Models.FileErrorCode UnsupportedQueryParameter { get; } = @"UnsupportedQueryParameter";

        /// <summary>
        /// UnsupportedHttpVerb
        /// </summary>
        public static Azure.Storage.Files.Models.FileErrorCode UnsupportedHttpVerb { get; } = @"UnsupportedHttpVerb";

        /// <summary>
        /// CannotDeleteFileOrDirectory
        /// </summary>
        public static Azure.Storage.Files.Models.FileErrorCode CannotDeleteFileOrDirectory { get; } = @"CannotDeleteFileOrDirectory";

        /// <summary>
        /// ClientCacheFlushDelay
        /// </summary>
        public static Azure.Storage.Files.Models.FileErrorCode ClientCacheFlushDelay { get; } = @"ClientCacheFlushDelay";

        /// <summary>
        /// DeletePending
        /// </summary>
        public static Azure.Storage.Files.Models.FileErrorCode DeletePending { get; } = @"DeletePending";

        /// <summary>
        /// DirectoryNotEmpty
        /// </summary>
        public static Azure.Storage.Files.Models.FileErrorCode DirectoryNotEmpty { get; } = @"DirectoryNotEmpty";

        /// <summary>
        /// FileLockConflict
        /// </summary>
        public static Azure.Storage.Files.Models.FileErrorCode FileLockConflict { get; } = @"FileLockConflict";

        /// <summary>
        /// InvalidFileOrDirectoryPathName
        /// </summary>
        public static Azure.Storage.Files.Models.FileErrorCode InvalidFileOrDirectoryPathName { get; } = @"InvalidFileOrDirectoryPathName";

        /// <summary>
        /// ParentNotFound
        /// </summary>
        public static Azure.Storage.Files.Models.FileErrorCode ParentNotFound { get; } = @"ParentNotFound";

        /// <summary>
        /// ReadOnlyAttribute
        /// </summary>
        public static Azure.Storage.Files.Models.FileErrorCode ReadOnlyAttribute { get; } = @"ReadOnlyAttribute";

        /// <summary>
        /// ShareAlreadyExists
        /// </summary>
        public static Azure.Storage.Files.Models.FileErrorCode ShareAlreadyExists { get; } = @"ShareAlreadyExists";

        /// <summary>
        /// ShareBeingDeleted
        /// </summary>
        public static Azure.Storage.Files.Models.FileErrorCode ShareBeingDeleted { get; } = @"ShareBeingDeleted";

        /// <summary>
        /// ShareDisabled
        /// </summary>
        public static Azure.Storage.Files.Models.FileErrorCode ShareDisabled { get; } = @"ShareDisabled";

        /// <summary>
        /// ShareNotFound
        /// </summary>
        public static Azure.Storage.Files.Models.FileErrorCode ShareNotFound { get; } = @"ShareNotFound";

        /// <summary>
        /// SharingViolation
        /// </summary>
        public static Azure.Storage.Files.Models.FileErrorCode SharingViolation { get; } = @"SharingViolation";

        /// <summary>
        /// ShareSnapshotInProgress
        /// </summary>
        public static Azure.Storage.Files.Models.FileErrorCode ShareSnapshotInProgress { get; } = @"ShareSnapshotInProgress";

        /// <summary>
        /// ShareSnapshotCountExceeded
        /// </summary>
        public static Azure.Storage.Files.Models.FileErrorCode ShareSnapshotCountExceeded { get; } = @"ShareSnapshotCountExceeded";

        /// <summary>
        /// ShareSnapshotOperationNotSupported
        /// </summary>
        public static Azure.Storage.Files.Models.FileErrorCode ShareSnapshotOperationNotSupported { get; } = @"ShareSnapshotOperationNotSupported";

        /// <summary>
        /// ShareHasSnapshots
        /// </summary>
        public static Azure.Storage.Files.Models.FileErrorCode ShareHasSnapshots { get; } = @"ShareHasSnapshots";

        /// <summary>
        /// ContainerQuotaDowngradeNotAllowed
        /// </summary>
        public static Azure.Storage.Files.Models.FileErrorCode ContainerQuotaDowngradeNotAllowed { get; } = @"ContainerQuotaDowngradeNotAllowed";

        /// <summary>
        /// AuthorizationSourceIPMismatch
        /// </summary>
        public static Azure.Storage.Files.Models.FileErrorCode AuthorizationSourceIPMismatch { get; } = @"AuthorizationSourceIPMismatch";

        /// <summary>
        /// AuthorizationProtocolMismatch
        /// </summary>
        public static Azure.Storage.Files.Models.FileErrorCode AuthorizationProtocolMismatch { get; } = @"AuthorizationProtocolMismatch";

        /// <summary>
        /// AuthorizationPermissionMismatch
        /// </summary>
        public static Azure.Storage.Files.Models.FileErrorCode AuthorizationPermissionMismatch { get; } = @"AuthorizationPermissionMismatch";

        /// <summary>
        /// AuthorizationServiceMismatch
        /// </summary>
        public static Azure.Storage.Files.Models.FileErrorCode AuthorizationServiceMismatch { get; } = @"AuthorizationServiceMismatch";

        /// <summary>
        /// AuthorizationResourceTypeMismatch
        /// </summary>
        public static Azure.Storage.Files.Models.FileErrorCode AuthorizationResourceTypeMismatch { get; } = @"AuthorizationResourceTypeMismatch";

        /// <summary>
        /// FeatureVersionMismatch
        /// </summary>
        public static Azure.Storage.Files.Models.FileErrorCode FeatureVersionMismatch { get; } = @"FeatureVersionMismatch";
        #pragma warning restore CA2211 // Non-constant fields should not be visible

        /// <summary>
        /// The FileErrorCode value.
        /// </summary>
        private readonly string _value;

        /// <summary>
        /// Creates a new FileErrorCode instance.
        /// </summary>
        /// <param name="value">The FileErrorCode value.</param>
        private FileErrorCode(string value) { _value = value; }

        /// <summary>
        /// Check if two FileErrorCode instances are equal.
        /// </summary>
        /// <param name="other">The instance to compare to.</param>
        /// <returns>True if they're equal, false otherwise.</returns>
        public bool Equals(Azure.Storage.Files.Models.FileErrorCode other) => _value.Equals(other._value, System.StringComparison.InvariantCulture);

        /// <summary>
        /// Check if two FileErrorCode instances are equal.
        /// </summary>
        /// <param name="o">The instance to compare to.</param>
        /// <returns>True if they're equal, false otherwise.</returns>
        public override bool Equals(object o) => o is Azure.Storage.Files.Models.FileErrorCode other && Equals(other);

        /// <summary>
        /// Get a hash code for the FileErrorCode.
        /// </summary>
        /// <returns>Hash code for the FileErrorCode.</returns>
        public override int GetHashCode() => _value.GetHashCode();

        /// <summary>
        /// Convert the FileErrorCode to a string.
        /// </summary>
        /// <returns>String representation of the FileErrorCode.</returns>
        public override string ToString() => _value;

        #pragma warning disable CA2225 // Operator overloads have named alternates
        /// <summary>
        /// Convert a string a FileErrorCode.
        /// </summary>
        /// <param name="value">The string to convert.</param>
        /// <returns>The FileErrorCode value.</returns>
        public static implicit operator FileErrorCode(string value) => new Azure.Storage.Files.Models.FileErrorCode(value);
        #pragma warning restore CA2225 // Operator overloads have named alternates

        /// <summary>
        /// Convert an FileErrorCode to a string.
        /// </summary>
        /// <param name="value">The FileErrorCode value.</param>
        /// <returns>String representation of the FileErrorCode value.</returns>
        public static implicit operator string(Azure.Storage.Files.Models.FileErrorCode value) => value._value;

        /// <summary>
        /// Check if two FileErrorCode instances are equal.
        /// </summary>
        /// <param name="left">The first instance to compare.</param>
        /// <param name="right">The second instance to compare.</param>
        /// <returns>True if they're equal, false otherwise.</returns>
        public static bool operator ==(Azure.Storage.Files.Models.FileErrorCode left, Azure.Storage.Files.Models.FileErrorCode right) => left.Equals(right);

        /// <summary>
        /// Check if two FileErrorCode instances are not equal.
        /// </summary>
        /// <param name="left">The first instance to compare.</param>
        /// <param name="right">The second instance to compare.</param>
        /// <returns>True if they're not equal, false otherwise.</returns>
        public static bool operator !=(Azure.Storage.Files.Models.FileErrorCode left, Azure.Storage.Files.Models.FileErrorCode right) => !left.Equals(right);
    }
}
#endregion enum strings FileErrorCode

#region class FileItem
namespace Azure.Storage.Files.Models
{
    /// <summary>
    /// A listed file item.
    /// </summary>
    internal partial class FileItem
    {
        /// <summary>
        /// Name
        /// </summary>
        public string Name { get; internal set; }

        /// <summary>
        /// File properties.
        /// </summary>
        public Azure.Storage.Files.Models.FileProperty Properties { get; internal set; }

        /// <summary>
        /// Creates a new FileItem instance
        /// </summary>
        public FileItem()
            : this(false)
        {
        }

        /// <summary>
        /// Creates a new FileItem instance
        /// </summary>
        /// <param name="skipInitialization">Whether to skip initializing nested objects.</param>
        internal FileItem(bool skipInitialization)
        {
            if (!skipInitialization)
            {
                Properties = new Azure.Storage.Files.Models.FileProperty();
            }
        }

        /// <summary>
        /// Deserializes XML into a new FileItem instance.
        /// </summary>
        /// <param name="element">The XML element to deserialize.</param>
        /// <returns>A deserialized FileItem instance.</returns>
        internal static Azure.Storage.Files.Models.FileItem FromXml(System.Xml.Linq.XElement element)
        {
            System.Diagnostics.Debug.Assert(element != null);
            System.Xml.Linq.XElement _child;
            Azure.Storage.Files.Models.FileItem _value = new Azure.Storage.Files.Models.FileItem(true);
            _child = element.Element(System.Xml.Linq.XName.Get("Name", ""));
            if (_child != null)
            {
                _value.Name = _child.Value;
            }
            _child = element.Element(System.Xml.Linq.XName.Get("Properties", ""));
            if (_child != null)
            {
                _value.Properties = Azure.Storage.Files.Models.FileProperty.FromXml(_child);
            }
            CustomizeFromXml(element, _value);
            return _value;
        }

        static partial void CustomizeFromXml(System.Xml.Linq.XElement element, Azure.Storage.Files.Models.FileItem value);
    }
}
#endregion class FileItem

#region class FileMetrics
namespace Azure.Storage.Files.Models
{
    /// <summary>
    /// Storage Analytics metrics for file service.
    /// </summary>
    public partial class FileMetrics
    {
        /// <summary>
        /// The version of Storage Analytics to configure.
        /// </summary>
        public string Version { get; set; }

        /// <summary>
        /// Indicates whether metrics are enabled for the File service.
        /// </summary>
        public bool Enabled { get; set; }

        /// <summary>
        /// Indicates whether metrics should generate summary statistics for called API operations.
        /// </summary>
        public bool? IncludeAPIs { get; set; }

        /// <summary>
        /// The retention policy.
        /// </summary>
        public Azure.Storage.Files.Models.RetentionPolicy RetentionPolicy { get; set; }

        /// <summary>
        /// Creates a new FileMetrics instance
        /// </summary>
        public FileMetrics()
            : this(false)
        {
        }

        /// <summary>
        /// Creates a new FileMetrics instance
        /// </summary>
        /// <param name="skipInitialization">Whether to skip initializing nested objects.</param>
        internal FileMetrics(bool skipInitialization)
        {
            if (!skipInitialization)
            {
                RetentionPolicy = new Azure.Storage.Files.Models.RetentionPolicy();
            }
        }

        /// <summary>
        /// Serialize a FileMetrics instance as XML.
        /// </summary>
        /// <param name="value">The FileMetrics instance to serialize.</param>
        /// <param name="name">An optional name to use for the root element instead of "Metrics".</param>
        /// <param name="ns">An optional namespace to use for the root element instead of "".</param>
        /// <returns>The serialized XML element.</returns>
        internal static System.Xml.Linq.XElement ToXml(Azure.Storage.Files.Models.FileMetrics value, string name = "Metrics", string ns = "")
        {
            System.Diagnostics.Debug.Assert(value != null);
            System.Xml.Linq.XElement _element = new System.Xml.Linq.XElement(System.Xml.Linq.XName.Get(name, ns));
            _element.Add(new System.Xml.Linq.XElement(
                System.Xml.Linq.XName.Get("Version", ""),
                value.Version));
            _element.Add(new System.Xml.Linq.XElement(
                System.Xml.Linq.XName.Get("Enabled", ""),
                #pragma warning disable CA1308 // Normalize strings to uppercase
                value.Enabled.ToString(System.Globalization.CultureInfo.InvariantCulture).ToLowerInvariant()));
                #pragma warning restore CA1308 // Normalize strings to uppercase
            if (value.IncludeAPIs != null)
            {
                _element.Add(new System.Xml.Linq.XElement(
                    System.Xml.Linq.XName.Get("IncludeAPIs", ""),
                    #pragma warning disable CA1308 // Normalize strings to uppercase
                    value.IncludeAPIs.Value.ToString(System.Globalization.CultureInfo.InvariantCulture).ToLowerInvariant()));
                    #pragma warning restore CA1308 // Normalize strings to uppercase
            }
            if (value.RetentionPolicy != null)
            {
                _element.Add(Azure.Storage.Files.Models.RetentionPolicy.ToXml(value.RetentionPolicy, "RetentionPolicy", ""));
            }
            return _element;
        }

        /// <summary>
        /// Deserializes XML into a new FileMetrics instance.
        /// </summary>
        /// <param name="element">The XML element to deserialize.</param>
        /// <returns>A deserialized FileMetrics instance.</returns>
        internal static Azure.Storage.Files.Models.FileMetrics FromXml(System.Xml.Linq.XElement element)
        {
            System.Diagnostics.Debug.Assert(element != null);
            System.Xml.Linq.XElement _child;
            Azure.Storage.Files.Models.FileMetrics _value = new Azure.Storage.Files.Models.FileMetrics(true);
            _child = element.Element(System.Xml.Linq.XName.Get("Version", ""));
            if (_child != null)
            {
                _value.Version = _child.Value;
            }
            _child = element.Element(System.Xml.Linq.XName.Get("Enabled", ""));
            if (_child != null)
            {
                _value.Enabled = bool.Parse(_child.Value);
            }
            _child = element.Element(System.Xml.Linq.XName.Get("IncludeAPIs", ""));
            if (_child != null)
            {
                _value.IncludeAPIs = bool.Parse(_child.Value);
            }
            _child = element.Element(System.Xml.Linq.XName.Get("RetentionPolicy", ""));
            if (_child != null)
            {
                _value.RetentionPolicy = Azure.Storage.Files.Models.RetentionPolicy.FromXml(_child);
            }
            CustomizeFromXml(element, _value);
            return _value;
        }

        static partial void CustomizeFromXml(System.Xml.Linq.XElement element, Azure.Storage.Files.Models.FileMetrics value);
    }
}
#endregion class FileMetrics

#region class FileProperty
namespace Azure.Storage.Files.Models
{
    /// <summary>
    /// File properties.
    /// </summary>
    internal partial class FileProperty
    {
        /// <summary>
        /// Content length of the file. This value may not be up-to-date since an SMB client may have modified the file locally. The value of Content-Length may not reflect that fact until the handle is closed or the op-lock is broken. To retrieve current property values, call Get File Properties.
        /// </summary>
        public long ContentLength { get; internal set; }

        /// <summary>
        /// Prevent direct instantiation of FileProperty instances.
        /// You can use FilesModelFactory.FileProperty instead.
        /// </summary>
        internal FileProperty() { }

        /// <summary>
        /// Deserializes XML into a new FileProperty instance.
        /// </summary>
        /// <param name="element">The XML element to deserialize.</param>
        /// <returns>A deserialized FileProperty instance.</returns>
        internal static Azure.Storage.Files.Models.FileProperty FromXml(System.Xml.Linq.XElement element)
        {
            System.Diagnostics.Debug.Assert(element != null);
            System.Xml.Linq.XElement _child;
            Azure.Storage.Files.Models.FileProperty _value = new Azure.Storage.Files.Models.FileProperty();
            _child = element.Element(System.Xml.Linq.XName.Get("Content-Length", ""));
            if (_child != null)
            {
                _value.ContentLength = long.Parse(_child.Value, System.Globalization.CultureInfo.InvariantCulture);
            }
            CustomizeFromXml(element, _value);
            return _value;
        }

        static partial void CustomizeFromXml(System.Xml.Linq.XElement element, Azure.Storage.Files.Models.FileProperty value);
    }
}
#endregion class FileProperty

#region enum FileRangeWriteType
namespace Azure.Storage.Files.Models
{
    /// <summary>
    /// Specify one of the following options: - Update: Writes the bytes specified by the request body into the specified range. The Range and Content-Length headers must match to perform the update. - Clear: Clears the specified range and releases the space used in storage for that range. To clear a range, set the Content-Length header to zero, and set the Range header to a value that indicates the range to clear, up to maximum file size.
    /// </summary>
    public enum FileRangeWriteType
    {
        /// <summary>
        /// update
        /// </summary>
        Update,

        /// <summary>
        /// clear
        /// </summary>
        Clear
    }
}

namespace Azure.Storage.Files
{
    internal static partial class FileRestClient
    {
        public static partial class Serialization
        {
            public static string ToString(Azure.Storage.Files.Models.FileRangeWriteType value)
            {
                return value switch
                {
                    Azure.Storage.Files.Models.FileRangeWriteType.Update => "update",
                    Azure.Storage.Files.Models.FileRangeWriteType.Clear => "clear",
                    _ => throw new System.ArgumentOutOfRangeException(nameof(value), value, "Unknown Azure.Storage.Files.Models.FileRangeWriteType value.")
                };
            }

            public static Azure.Storage.Files.Models.FileRangeWriteType ParseFileRangeWriteType(string value)
            {
                return value switch
                {
                    "update" => Azure.Storage.Files.Models.FileRangeWriteType.Update,
                    "clear" => Azure.Storage.Files.Models.FileRangeWriteType.Clear,
                    _ => throw new System.ArgumentOutOfRangeException(nameof(value), value, "Unknown Azure.Storage.Files.Models.FileRangeWriteType value.")
                };
            }
        }
    }
}
#endregion enum FileRangeWriteType

#region class FileServiceProperties
namespace Azure.Storage.Files.Models
{
    /// <summary>
    /// Storage service properties.
    /// </summary>
    public partial class FileServiceProperties
    {
        /// <summary>
        /// A summary of request statistics grouped by API in hourly aggregates for files.
        /// </summary>
        public Azure.Storage.Files.Models.FileMetrics HourMetrics { get; set; }

        /// <summary>
        /// A summary of request statistics grouped by API in minute aggregates for files.
        /// </summary>
        public Azure.Storage.Files.Models.FileMetrics MinuteMetrics { get; set; }

        /// <summary>
        /// The set of CORS rules.
        /// </summary>
        public System.Collections.Generic.IList<Azure.Storage.Files.Models.FileCorsRule> Cors { get; set; }

        /// <summary>
        /// Creates a new FileServiceProperties instance
        /// </summary>
        public FileServiceProperties()
            : this(false)
        {
        }

        /// <summary>
        /// Creates a new FileServiceProperties instance
        /// </summary>
        /// <param name="skipInitialization">Whether to skip initializing nested objects.</param>
        internal FileServiceProperties(bool skipInitialization)
        {
            if (!skipInitialization)
            {
                HourMetrics = new Azure.Storage.Files.Models.FileMetrics();
                MinuteMetrics = new Azure.Storage.Files.Models.FileMetrics();
            }
        }

        /// <summary>
        /// Serialize a FileServiceProperties instance as XML.
        /// </summary>
        /// <param name="value">The FileServiceProperties instance to serialize.</param>
        /// <param name="name">An optional name to use for the root element instead of "StorageServiceProperties".</param>
        /// <param name="ns">An optional namespace to use for the root element instead of "".</param>
        /// <returns>The serialized XML element.</returns>
        internal static System.Xml.Linq.XElement ToXml(Azure.Storage.Files.Models.FileServiceProperties value, string name = "StorageServiceProperties", string ns = "")
        {
            System.Diagnostics.Debug.Assert(value != null);
            System.Xml.Linq.XElement _element = new System.Xml.Linq.XElement(System.Xml.Linq.XName.Get(name, ns));
            if (value.HourMetrics != null)
            {
                _element.Add(Azure.Storage.Files.Models.FileMetrics.ToXml(value.HourMetrics, "HourMetrics", ""));
            }
            if (value.MinuteMetrics != null)
            {
                _element.Add(Azure.Storage.Files.Models.FileMetrics.ToXml(value.MinuteMetrics, "MinuteMetrics", ""));
            }
            if (value.Cors != null)
            {
                System.Xml.Linq.XElement _elements = new System.Xml.Linq.XElement(System.Xml.Linq.XName.Get("Cors", ""));
                foreach (Azure.Storage.Files.Models.FileCorsRule _child in value.Cors)
                {
                    _elements.Add(Azure.Storage.Files.Models.FileCorsRule.ToXml(_child));
                }
                _element.Add(_elements);
            }
            return _element;
        }

        /// <summary>
        /// Deserializes XML into a new FileServiceProperties instance.
        /// </summary>
        /// <param name="element">The XML element to deserialize.</param>
        /// <returns>A deserialized FileServiceProperties instance.</returns>
        internal static Azure.Storage.Files.Models.FileServiceProperties FromXml(System.Xml.Linq.XElement element)
        {
            System.Diagnostics.Debug.Assert(element != null);
            System.Xml.Linq.XElement _child;
            Azure.Storage.Files.Models.FileServiceProperties _value = new Azure.Storage.Files.Models.FileServiceProperties(true);
            _child = element.Element(System.Xml.Linq.XName.Get("HourMetrics", ""));
            if (_child != null)
            {
                _value.HourMetrics = Azure.Storage.Files.Models.FileMetrics.FromXml(_child);
            }
            _child = element.Element(System.Xml.Linq.XName.Get("MinuteMetrics", ""));
            if (_child != null)
            {
                _value.MinuteMetrics = Azure.Storage.Files.Models.FileMetrics.FromXml(_child);
            }
            _child = element.Element(System.Xml.Linq.XName.Get("Cors", ""));
            if (_child != null)
            {
                _value.Cors = System.Linq.Enumerable.ToList(
                    System.Linq.Enumerable.Select(
                        _child.Elements(System.Xml.Linq.XName.Get("CorsRule", "")),
                        e => Azure.Storage.Files.Models.FileCorsRule.FromXml(e)));
            }
            else
            {
                _value.Cors = new System.Collections.Generic.List<Azure.Storage.Files.Models.FileCorsRule>();
            }
            CustomizeFromXml(element, _value);
            return _value;
        }

        static partial void CustomizeFromXml(System.Xml.Linq.XElement element, Azure.Storage.Files.Models.FileServiceProperties value);
    }
}
#endregion class FileServiceProperties

#region class FilesAndDirectoriesSegment
namespace Azure.Storage.Files.Models
{
    /// <summary>
    /// An enumeration of directories and files.
    /// </summary>
    internal partial class FilesAndDirectoriesSegment
    {
        /// <summary>
        /// ServiceEndpoint
        /// </summary>
        public string ServiceEndpoint { get; internal set; }

        /// <summary>
        /// ShareName
        /// </summary>
        public string ShareName { get; internal set; }

        /// <summary>
        /// ShareSnapshot
        /// </summary>
        public string ShareSnapshot { get; internal set; }

        /// <summary>
        /// DirectoryPath
        /// </summary>
        public string DirectoryPath { get; internal set; }

        /// <summary>
        /// Prefix
        /// </summary>
        public string Prefix { get; internal set; }

        /// <summary>
        /// Marker
        /// </summary>
        public string Marker { get; internal set; }

        /// <summary>
        /// MaxResults
        /// </summary>
        public int? MaxResults { get; internal set; }

        /// <summary>
        /// NextMarker
        /// </summary>
        public string NextMarker { get; internal set; }

        /// <summary>
        /// DirectoryItems
        /// </summary>
        public System.Collections.Generic.IEnumerable<Azure.Storage.Files.Models.DirectoryItem> DirectoryItems { get; internal set; }

        /// <summary>
        /// FileItems
        /// </summary>
        public System.Collections.Generic.IEnumerable<Azure.Storage.Files.Models.FileItem> FileItems { get; internal set; }

        /// <summary>
        /// Creates a new FilesAndDirectoriesSegment instance
        /// </summary>
        public FilesAndDirectoriesSegment()
            : this(false)
        {
        }

        /// <summary>
        /// Creates a new FilesAndDirectoriesSegment instance
        /// </summary>
        /// <param name="skipInitialization">Whether to skip initializing nested objects.</param>
        internal FilesAndDirectoriesSegment(bool skipInitialization)
        {
            if (!skipInitialization)
            {
                DirectoryItems = new System.Collections.Generic.List<Azure.Storage.Files.Models.DirectoryItem>();
                FileItems = new System.Collections.Generic.List<Azure.Storage.Files.Models.FileItem>();
            }
        }

        /// <summary>
        /// Deserializes XML into a new FilesAndDirectoriesSegment instance.
        /// </summary>
        /// <param name="element">The XML element to deserialize.</param>
        /// <returns>A deserialized FilesAndDirectoriesSegment instance.</returns>
        internal static Azure.Storage.Files.Models.FilesAndDirectoriesSegment FromXml(System.Xml.Linq.XElement element)
        {
            System.Diagnostics.Debug.Assert(element != null);
            System.Xml.Linq.XElement _child;
            System.Xml.Linq.XAttribute _attribute;
            Azure.Storage.Files.Models.FilesAndDirectoriesSegment _value = new Azure.Storage.Files.Models.FilesAndDirectoriesSegment(true);
            _attribute = element.Attribute(System.Xml.Linq.XName.Get("ServiceEndpoint", ""));
            if (_attribute != null)
            {
                _value.ServiceEndpoint = _attribute.Value;
            }
            _attribute = element.Attribute(System.Xml.Linq.XName.Get("ShareName", ""));
            if (_attribute != null)
            {
                _value.ShareName = _attribute.Value;
            }
            _attribute = element.Attribute(System.Xml.Linq.XName.Get("ShareSnapshot", ""));
            if (_attribute != null)
            {
                _value.ShareSnapshot = _attribute.Value;
            }
            _attribute = element.Attribute(System.Xml.Linq.XName.Get("DirectoryPath", ""));
            if (_attribute != null)
            {
                _value.DirectoryPath = _attribute.Value;
            }
            _child = element.Element(System.Xml.Linq.XName.Get("Prefix", ""));
            if (_child != null)
            {
                _value.Prefix = _child.Value;
            }
            _child = element.Element(System.Xml.Linq.XName.Get("Marker", ""));
            if (_child != null)
            {
                _value.Marker = _child.Value;
            }
            _child = element.Element(System.Xml.Linq.XName.Get("MaxResults", ""));
            if (_child != null)
            {
                _value.MaxResults = int.Parse(_child.Value, System.Globalization.CultureInfo.InvariantCulture);
            }
            _child = element.Element(System.Xml.Linq.XName.Get("NextMarker", ""));
            if (_child != null)
            {
                _value.NextMarker = _child.Value;
            }
            _child = element.Element(System.Xml.Linq.XName.Get("Entries", ""));
            if (_child != null)
            {
                _value.DirectoryItems = System.Linq.Enumerable.ToList(
                    System.Linq.Enumerable.Select(
                        _child.Elements(System.Xml.Linq.XName.Get("Directory", "")),
                        e => Azure.Storage.Files.Models.DirectoryItem.FromXml(e)));
            }
            else
            {
                _value.DirectoryItems = new System.Collections.Generic.List<Azure.Storage.Files.Models.DirectoryItem>();
            }
            _child = element.Element(System.Xml.Linq.XName.Get("Entries", ""));
            if (_child != null)
            {
                _value.FileItems = System.Linq.Enumerable.ToList(
                    System.Linq.Enumerable.Select(
                        _child.Elements(System.Xml.Linq.XName.Get("File", "")),
                        e => Azure.Storage.Files.Models.FileItem.FromXml(e)));
            }
            else
            {
                _value.FileItems = new System.Collections.Generic.List<Azure.Storage.Files.Models.FileItem>();
            }
            CustomizeFromXml(element, _value);
            return _value;
        }

        static partial void CustomizeFromXml(System.Xml.Linq.XElement element, Azure.Storage.Files.Models.FilesAndDirectoriesSegment value);
    }
}
#endregion class FilesAndDirectoriesSegment

#region class FlattenedStorageFileProperties
namespace Azure.Storage.Files.Models
{
    /// <summary>
    /// FlattenedStorageFileProperties
    /// </summary>
    internal partial class FlattenedStorageFileProperties
    {
        /// <summary>
        /// Returns the date and time the file was last modified. Any operation that modifies the file or its properties updates the last modified time.
        /// </summary>
        public System.DateTimeOffset LastModified { get; internal set; }

        /// <summary>
        /// A set of name-value pairs associated with this file as user-defined metadata.
        /// </summary>
        public System.Collections.Generic.IDictionary<string, string> Metadata { get; internal set; }

        /// <summary>
        /// The number of bytes present in the response body.
        /// </summary>
        public long ContentLength { get; internal set; }

        /// <summary>
        /// The content type specified for the file. The default content type is 'application/octet-stream'
        /// </summary>
        public string ContentType { get; internal set; }

        /// <summary>
        /// Indicates the range of bytes returned if the client requested a subset of the file by setting the Range request header.
        /// </summary>
        public string ContentRange { get; internal set; }

        /// <summary>
        /// The ETag contains a value that you can use to perform operations conditionally, in quotes.
        /// </summary>
        public Azure.ETag ETag { get; internal set; }

        /// <summary>
        /// If the file has an MD5 hash and the request is to read the full file, this response header is returned so that the client can check for message content integrity. If the request is to read a specified range and the 'x-ms-range-get-content-md5' is set to true, then the request returns an MD5 hash for the range, as long as the range size is less than or equal to 4 MB. If neither of these sets of conditions is true, then no value is returned for the 'Content-MD5' header.
        /// </summary>
        #pragma warning disable CA1819 // Properties should not return arrays
        public byte[] ContentHash { get; internal set; }
        #pragma warning restore CA1819 // Properties should not return arrays

        /// <summary>
        /// Returns the value that was specified for the Content-Encoding request header.
        /// </summary>
        public System.Collections.Generic.IEnumerable<string> ContentEncoding { get; internal set; }

        /// <summary>
        /// Returned if it was previously specified for the file.
        /// </summary>
        public string CacheControl { get; internal set; }

        /// <summary>
        /// Returns the value that was specified for the 'x-ms-content-disposition' header and specifies how to process the response.
        /// </summary>
        public string ContentDisposition { get; internal set; }

        /// <summary>
        /// Returns the value that was specified for the Content-Language request header.
        /// </summary>
        public System.Collections.Generic.IEnumerable<string> ContentLanguage { get; internal set; }

        /// <summary>
        /// Indicates that the service supports requests for partial file content.
        /// </summary>
        public string AcceptRanges { get; internal set; }

        /// <summary>
        /// Conclusion time of the last attempted Copy File operation where this file was the destination file. This value can specify the time of a completed, aborted, or failed copy attempt.
        /// </summary>
        public System.DateTimeOffset CopyCompletionTime { get; internal set; }

        /// <summary>
        /// Only appears when x-ms-copy-status is failed or pending. Describes cause of fatal or non-fatal copy operation failure.
        /// </summary>
        public string CopyStatusDescription { get; internal set; }

        /// <summary>
        /// String identifier for the last attempted Copy File operation where this file was the destination file.
        /// </summary>
        public string CopyId { get; internal set; }

        /// <summary>
        /// Contains the number of bytes copied and the total bytes in the source in the last attempted Copy File operation where this file was the destination file. Can show between 0 and Content-Length bytes copied.
        /// </summary>
        public string CopyProgress { get; internal set; }

        /// <summary>
        /// URL up to 2KB in length that specifies the source file used in the last attempted Copy File operation where this file was the destination file.
        /// </summary>
        public System.Uri CopySource { get; internal set; }

        /// <summary>
        /// State of the copy operation identified by 'x-ms-copy-id'.
        /// </summary>
        public Azure.Storage.Files.Models.CopyStatus CopyStatus { get; internal set; }

        /// <summary>
        /// If the file has a MD5 hash, and if request contains range header (Range or x-ms-range), this response header is returned with the value of the whole file's MD5 value. This value may or may not be equal to the value returned in Content-MD5 header, with the latter calculated from the requested range.
        /// </summary>
        #pragma warning disable CA1819 // Properties should not return arrays
        public byte[] FileContentHash { get; internal set; }
        #pragma warning restore CA1819 // Properties should not return arrays

        /// <summary>
        /// The value of this header is set to true if the file data and application metadata are completely encrypted using the specified algorithm. Otherwise, the value is set to false (when the file is unencrypted, or if only parts of the file/application metadata are encrypted).
        /// </summary>
        public bool IsServerEncrypted { get; internal set; }

        /// <summary>
        /// Attributes set for the file.
        /// </summary>
        public string FileAttributes { get; internal set; }

        /// <summary>
        /// Creation time for the file.
        /// </summary>
        public System.DateTimeOffset FileCreationTime { get; internal set; }

        /// <summary>
        /// Last write time for the file.
        /// </summary>
        public System.DateTimeOffset FileLastWriteTime { get; internal set; }

        /// <summary>
        /// Change time for the file.
        /// </summary>
        public System.DateTimeOffset FileChangeTime { get; internal set; }

        /// <summary>
        /// Key of the permission set for the file.
        /// </summary>
        public string FilePermissionKey { get; internal set; }

        /// <summary>
        /// The fileId of the file.
        /// </summary>
        public string FileId { get; internal set; }

        /// <summary>
        /// The parent fileId of the file.
        /// </summary>
        public string FileParentId { get; internal set; }

        /// <summary>
        /// Content
        /// </summary>
        public System.IO.Stream Content { get; internal set; }

        /// <summary>
        /// Creates a new FlattenedStorageFileProperties instance
        /// </summary>
        public FlattenedStorageFileProperties()
        {
            Metadata = new System.Collections.Generic.Dictionary<string, string>(System.StringComparer.OrdinalIgnoreCase);
            ContentEncoding = new System.Collections.Generic.List<string>();
            ContentLanguage = new System.Collections.Generic.List<string>();
        }
    }
}
#endregion class FlattenedStorageFileProperties

#region enum ListSharesIncludeType
namespace Azure.Storage.Files.Models
{
    /// <summary>
    /// ListSharesIncludeType values
    /// </summary>
    public enum ListSharesIncludeType
    {
        /// <summary>
        /// snapshots
        /// </summary>
        Snapshots,

        /// <summary>
        /// metadata
        /// </summary>
        Metadata
    }
}

namespace Azure.Storage.Files
{
    internal static partial class FileRestClient
    {
        public static partial class Serialization
        {
            public static string ToString(Azure.Storage.Files.Models.ListSharesIncludeType value)
            {
                return value switch
                {
                    Azure.Storage.Files.Models.ListSharesIncludeType.Snapshots => "snapshots",
                    Azure.Storage.Files.Models.ListSharesIncludeType.Metadata => "metadata",
                    _ => throw new System.ArgumentOutOfRangeException(nameof(value), value, "Unknown Azure.Storage.Files.Models.ListSharesIncludeType value.")
                };
            }

            public static Azure.Storage.Files.Models.ListSharesIncludeType ParseListSharesIncludeType(string value)
            {
                return value switch
                {
                    "snapshots" => Azure.Storage.Files.Models.ListSharesIncludeType.Snapshots,
                    "metadata" => Azure.Storage.Files.Models.ListSharesIncludeType.Metadata,
                    _ => throw new System.ArgumentOutOfRangeException(nameof(value), value, "Unknown Azure.Storage.Files.Models.ListSharesIncludeType value.")
                };
            }
        }
    }
}
#endregion enum ListSharesIncludeType

#region class PermissionInfo
namespace Azure.Storage.Files.Models
{
    /// <summary>
    /// PermissionInfo
    /// </summary>
    public partial class PermissionInfo
    {
        /// <summary>
        /// Key of the permission set for the directory/file.
        /// </summary>
        public string FilePermissionKey { get; internal set; }

        /// <summary>
        /// Prevent direct instantiation of PermissionInfo instances.
        /// You can use FilesModelFactory.PermissionInfo instead.
        /// </summary>
        internal PermissionInfo() { }
    }

    /// <summary>
    /// FilesModelFactory provides utilities for mocking.
    /// </summary>
    public static partial class FilesModelFactory
    {
        /// <summary>
        /// Creates a new PermissionInfo instance for mocking.
        /// </summary>
        public static PermissionInfo PermissionInfo(
            string filePermissionKey)
        {
            return new PermissionInfo()
            {
                FilePermissionKey = filePermissionKey,
            };
        }
    }
}
#endregion class PermissionInfo

#region class Range
namespace Azure.Storage.Files.Models
{
    /// <summary>
    /// An Azure Storage file range.
    /// </summary>
    public partial class Range
    {
        /// <summary>
        /// Start of the range.
        /// </summary>
        public long Start { get; internal set; }

        /// <summary>
        /// End of the range.
        /// </summary>
        public long End { get; internal set; }

        /// <summary>
        /// Prevent direct instantiation of Range instances.
        /// You can use FilesModelFactory.Range instead.
        /// </summary>
        internal Range() { }

        /// <summary>
        /// Deserializes XML into a new Range instance.
        /// </summary>
        /// <param name="element">The XML element to deserialize.</param>
        /// <returns>A deserialized Range instance.</returns>
        internal static Azure.Storage.Files.Models.Range FromXml(System.Xml.Linq.XElement element)
        {
            System.Diagnostics.Debug.Assert(element != null);
            System.Xml.Linq.XElement _child;
            Azure.Storage.Files.Models.Range _value = new Azure.Storage.Files.Models.Range();
            _child = element.Element(System.Xml.Linq.XName.Get("Start", ""));
            if (_child != null)
            {
                _value.Start = long.Parse(_child.Value, System.Globalization.CultureInfo.InvariantCulture);
            }
            _child = element.Element(System.Xml.Linq.XName.Get("End", ""));
            if (_child != null)
            {
                _value.End = long.Parse(_child.Value, System.Globalization.CultureInfo.InvariantCulture);
            }
            CustomizeFromXml(element, _value);
            return _value;
        }

        static partial void CustomizeFromXml(System.Xml.Linq.XElement element, Azure.Storage.Files.Models.Range value);
    }

    /// <summary>
    /// FilesModelFactory provides utilities for mocking.
    /// </summary>
    public static partial class FilesModelFactory
    {
        /// <summary>
        /// Creates a new Range instance for mocking.
        /// </summary>
        public static Range Range(
            long start,
            long end)
        {
            return new Range()
            {
                Start = start,
                End = end,
            };
        }
    }
}
#endregion class Range

#region class RawStorageDirectoryInfo
namespace Azure.Storage.Files.Models
{
    /// <summary>
    /// RawStorageDirectoryInfo
    /// </summary>
    internal partial class RawStorageDirectoryInfo
    {
        /// <summary>
        /// The ETag contains a value which represents the version of the directory, in quotes.
        /// </summary>
        public Azure.ETag ETag { get; internal set; }

        /// <summary>
        /// Returns the date and time the share was last modified. Any operation that modifies the directory or its properties updates the last modified time. Operations on files do not affect the last modified time of the directory.
        /// </summary>
        public System.DateTimeOffset LastModified { get; internal set; }

        /// <summary>
        /// Key of the permission set for the directory.
        /// </summary>
        public string FilePermissionKey { get; internal set; }

        /// <summary>
        /// Attributes set for the directory.
        /// </summary>
        public string FileAttributes { get; internal set; }

        /// <summary>
        /// Creation time for the directory.
        /// </summary>
        public System.DateTimeOffset FileCreationTime { get; internal set; }

        /// <summary>
        /// Last write time for the directory.
        /// </summary>
        public System.DateTimeOffset FileLastWriteTime { get; internal set; }

        /// <summary>
        /// Change time for the directory.
        /// </summary>
        public System.DateTimeOffset FileChangeTime { get; internal set; }

        /// <summary>
        /// The fileId of the directory.
        /// </summary>
        public string FileId { get; internal set; }

        /// <summary>
        /// The parent fileId of the directory.
        /// </summary>
        public string FileParentId { get; internal set; }

        /// <summary>
        /// Prevent direct instantiation of RawStorageDirectoryInfo instances.
        /// You can use FilesModelFactory.RawStorageDirectoryInfo instead.
        /// </summary>
        internal RawStorageDirectoryInfo() { }
    }
}
#endregion class RawStorageDirectoryInfo

#region class RawStorageDirectoryProperties
namespace Azure.Storage.Files.Models
{
    /// <summary>
    /// RawStorageDirectoryProperties
    /// </summary>
    internal partial class RawStorageDirectoryProperties
    {
        /// <summary>
        /// A set of name-value pairs that contain metadata for the directory.
        /// </summary>
        public System.Collections.Generic.IDictionary<string, string> Metadata { get; internal set; }

        /// <summary>
        /// The ETag contains a value that you can use to perform operations conditionally, in quotes.
        /// </summary>
        public Azure.ETag ETag { get; internal set; }

        /// <summary>
        /// Returns the date and time the Directory was last modified. Operations on files within the directory do not affect the last modified time of the directory.
        /// </summary>
        public System.DateTimeOffset LastModified { get; internal set; }

        /// <summary>
        /// The value of this header is set to true if the directory metadata is completely encrypted using the specified algorithm. Otherwise, the value is set to false.
        /// </summary>
        public bool IsServerEncrypted { get; internal set; }

        /// <summary>
        /// Attributes set for the directory.
        /// </summary>
        public string FileAttributes { get; internal set; }

        /// <summary>
        /// Creation time for the directory.
        /// </summary>
        public System.DateTimeOffset FileCreationTime { get; internal set; }

        /// <summary>
        /// Last write time for the directory.
        /// </summary>
        public System.DateTimeOffset FileLastWriteTime { get; internal set; }

        /// <summary>
        /// Change time for the directory.
        /// </summary>
        public System.DateTimeOffset FileChangeTime { get; internal set; }

        /// <summary>
        /// Key of the permission set for the directory.
        /// </summary>
        public string FilePermissionKey { get; internal set; }

        /// <summary>
        /// The fileId of the directory.
        /// </summary>
        public string FileId { get; internal set; }

        /// <summary>
        /// The parent fileId of the directory.
        /// </summary>
        public string FileParentId { get; internal set; }

        /// <summary>
        /// Creates a new RawStorageDirectoryProperties instance
        /// </summary>
        public RawStorageDirectoryProperties()
        {
            Metadata = new System.Collections.Generic.Dictionary<string, string>(System.StringComparer.OrdinalIgnoreCase);
        }
    }
}
#endregion class RawStorageDirectoryProperties

#region class RawStorageFileInfo
namespace Azure.Storage.Files.Models
{
    /// <summary>
    /// RawStorageFileInfo
    /// </summary>
    internal partial class RawStorageFileInfo
    {
        /// <summary>
        /// The ETag contains a value which represents the version of the file, in quotes.
        /// </summary>
        public Azure.ETag ETag { get; internal set; }

        /// <summary>
        /// Returns the date and time the share was last modified. Any operation that modifies the directory or its properties updates the last modified time. Operations on files do not affect the last modified time of the directory.
        /// </summary>
        public System.DateTimeOffset LastModified { get; internal set; }

        /// <summary>
        /// The value of this header is set to true if the contents of the request are successfully encrypted using the specified algorithm, and false otherwise.
        /// </summary>
        public bool IsServerEncrypted { get; internal set; }

        /// <summary>
        /// Key of the permission set for the file.
        /// </summary>
        public string FilePermissionKey { get; internal set; }

        /// <summary>
        /// Attributes set for the file.
        /// </summary>
        public string FileAttributes { get; internal set; }

        /// <summary>
        /// Creation time for the file.
        /// </summary>
        public System.DateTimeOffset FileCreationTime { get; internal set; }

        /// <summary>
        /// Last write time for the file.
        /// </summary>
        public System.DateTimeOffset FileLastWriteTime { get; internal set; }

        /// <summary>
        /// Change time for the file.
        /// </summary>
        public System.DateTimeOffset FileChangeTime { get; internal set; }

        /// <summary>
        /// The fileId of the file.
        /// </summary>
        public string FileId { get; internal set; }

        /// <summary>
        /// The parent fileId of the file.
        /// </summary>
        public string FileParentId { get; internal set; }

        /// <summary>
        /// Prevent direct instantiation of RawStorageFileInfo instances.
        /// You can use FilesModelFactory.RawStorageFileInfo instead.
        /// </summary>
        internal RawStorageFileInfo() { }
    }
}
#endregion class RawStorageFileInfo

#region class RawStorageFileProperties
namespace Azure.Storage.Files.Models
{
    /// <summary>
    /// RawStorageFileProperties
    /// </summary>
    internal partial class RawStorageFileProperties
    {
        /// <summary>
        /// Returns the date and time the file was last modified. The date format follows RFC 1123. Any operation that modifies the file or its properties updates the last modified time.
        /// </summary>
        public System.DateTimeOffset LastModified { get; internal set; }

        /// <summary>
        /// A set of name-value pairs associated with this file as user-defined metadata.
        /// </summary>
        public System.Collections.Generic.IDictionary<string, string> Metadata { get; internal set; }

        /// <summary>
        /// Returns the type File. Reserved for future use.
        /// </summary>
        public Azure.Storage.Files.Models.Header FileType { get; internal set; }

        /// <summary>
        /// The size of the file in bytes. This header returns the value of the 'x-ms-content-length' header that is stored with the file.
        /// </summary>
        public long ContentLength { get; internal set; }

        /// <summary>
        /// The content type specified for the file. The default content type is 'application/octet-stream'
        /// </summary>
        public string ContentType { get; internal set; }

        /// <summary>
        /// The ETag contains a value that you can use to perform operations conditionally, in quotes.
        /// </summary>
        public Azure.ETag ETag { get; internal set; }

        /// <summary>
        /// If the Content-MD5 header has been set for the file, the Content-MD5 response header is returned so that the client can check for message content integrity.
        /// </summary>
        #pragma warning disable CA1819 // Properties should not return arrays
        public byte[] ContentHash { get; internal set; }
        #pragma warning restore CA1819 // Properties should not return arrays

        /// <summary>
        /// If the Content-Encoding request header has previously been set for the file, the Content-Encoding value is returned in this header.
        /// </summary>
        public System.Collections.Generic.IEnumerable<string> ContentEncoding { get; internal set; }

        /// <summary>
        /// If the Cache-Control request header has previously been set for the file, the Cache-Control value is returned in this header.
        /// </summary>
        public string CacheControl { get; internal set; }

        /// <summary>
        /// Returns the value that was specified for the 'x-ms-content-disposition' header and specifies how to process the response.
        /// </summary>
        public string ContentDisposition { get; internal set; }

        /// <summary>
        /// Returns the value that was specified for the Content-Language request header.
        /// </summary>
        public System.Collections.Generic.IEnumerable<string> ContentLanguage { get; internal set; }

        /// <summary>
        /// Conclusion time of the last attempted Copy File operation where this file was the destination file. This value can specify the time of a completed, aborted, or failed copy attempt.
        /// </summary>
        public System.DateTimeOffset CopyCompletionTime { get; internal set; }

        /// <summary>
        /// Only appears when x-ms-copy-status is failed or pending. Describes cause of fatal or non-fatal copy operation failure.
        /// </summary>
        public string CopyStatusDescription { get; internal set; }

        /// <summary>
        /// String identifier for the last attempted Copy File operation where this file was the destination file.
        /// </summary>
        public string CopyId { get; internal set; }

        /// <summary>
        /// Contains the number of bytes copied and the total bytes in the source in the last attempted Copy File operation where this file was the destination file. Can show between 0 and Content-Length bytes copied.
        /// </summary>
        public string CopyProgress { get; internal set; }

        /// <summary>
        /// URL up to 2KB in length that specifies the source file used in the last attempted Copy File operation where this file was the destination file.
        /// </summary>
        public string CopySource { get; internal set; }

        /// <summary>
        /// State of the copy operation identified by 'x-ms-copy-id'.
        /// </summary>
        public Azure.Storage.Files.Models.CopyStatus CopyStatus { get; internal set; }

        /// <summary>
        /// The value of this header is set to true if the file data and application metadata are completely encrypted using the specified algorithm. Otherwise, the value is set to false (when the file is unencrypted, or if only parts of the file/application metadata are encrypted).
        /// </summary>
        public bool IsServerEncrypted { get; internal set; }

        /// <summary>
        /// Attributes set for the file.
        /// </summary>
        public string FileAttributes { get; internal set; }

        /// <summary>
        /// Creation time for the file.
        /// </summary>
        public System.DateTimeOffset FileCreationTime { get; internal set; }

        /// <summary>
        /// Last write time for the file.
        /// </summary>
        public System.DateTimeOffset FileLastWriteTime { get; internal set; }

        /// <summary>
        /// Change time for the file.
        /// </summary>
        public System.DateTimeOffset FileChangeTime { get; internal set; }

        /// <summary>
        /// Key of the permission set for the file.
        /// </summary>
        public string FilePermissionKey { get; internal set; }

        /// <summary>
        /// The fileId of the file.
        /// </summary>
        public string FileId { get; internal set; }

        /// <summary>
        /// The parent fileId of the file.
        /// </summary>
        public string FileParentId { get; internal set; }

        /// <summary>
        /// Creates a new RawStorageFileProperties instance
        /// </summary>
        public RawStorageFileProperties()
        {
            Metadata = new System.Collections.Generic.Dictionary<string, string>(System.StringComparer.OrdinalIgnoreCase);
            ContentEncoding = new System.Collections.Generic.List<string>();
            ContentLanguage = new System.Collections.Generic.List<string>();
        }
    }
}
#endregion class RawStorageFileProperties

#region class RetentionPolicy
namespace Azure.Storage.Files.Models
{
    /// <summary>
    /// The retention policy.
    /// </summary>
    public partial class RetentionPolicy
    {
        /// <summary>
        /// Indicates whether a retention policy is enabled for the File service. If false, metrics data is retained, and the user is responsible for deleting it.
        /// </summary>
        public bool Enabled { get; set; }

        /// <summary>
        /// Indicates the number of days that metrics data should be retained. All data older than this value will be deleted. Metrics data is deleted on a best-effort basis after the retention period expires.
        /// </summary>
        public int? Days { get; set; }

        /// <summary>
        /// Prevent direct instantiation of RetentionPolicy instances.
        /// You can use FilesModelFactory.RetentionPolicy instead.
        /// </summary>
        internal RetentionPolicy() { }

        /// <summary>
        /// Serialize a RetentionPolicy instance as XML.
        /// </summary>
        /// <param name="value">The RetentionPolicy instance to serialize.</param>
        /// <param name="name">An optional name to use for the root element instead of "RetentionPolicy".</param>
        /// <param name="ns">An optional namespace to use for the root element instead of "".</param>
        /// <returns>The serialized XML element.</returns>
        internal static System.Xml.Linq.XElement ToXml(Azure.Storage.Files.Models.RetentionPolicy value, string name = "RetentionPolicy", string ns = "")
        {
            System.Diagnostics.Debug.Assert(value != null);
            System.Xml.Linq.XElement _element = new System.Xml.Linq.XElement(System.Xml.Linq.XName.Get(name, ns));
            _element.Add(new System.Xml.Linq.XElement(
                System.Xml.Linq.XName.Get("Enabled", ""),
                #pragma warning disable CA1308 // Normalize strings to uppercase
                value.Enabled.ToString(System.Globalization.CultureInfo.InvariantCulture).ToLowerInvariant()));
                #pragma warning restore CA1308 // Normalize strings to uppercase
            if (value.Days != null)
            {
                _element.Add(new System.Xml.Linq.XElement(
                    System.Xml.Linq.XName.Get("Days", ""),
                    value.Days.Value.ToString(System.Globalization.CultureInfo.InvariantCulture)));
            }
            return _element;
        }

        /// <summary>
        /// Deserializes XML into a new RetentionPolicy instance.
        /// </summary>
        /// <param name="element">The XML element to deserialize.</param>
        /// <returns>A deserialized RetentionPolicy instance.</returns>
        internal static Azure.Storage.Files.Models.RetentionPolicy FromXml(System.Xml.Linq.XElement element)
        {
            System.Diagnostics.Debug.Assert(element != null);
            System.Xml.Linq.XElement _child;
            Azure.Storage.Files.Models.RetentionPolicy _value = new Azure.Storage.Files.Models.RetentionPolicy();
            _child = element.Element(System.Xml.Linq.XName.Get("Enabled", ""));
            if (_child != null)
            {
                _value.Enabled = bool.Parse(_child.Value);
            }
            _child = element.Element(System.Xml.Linq.XName.Get("Days", ""));
            if (_child != null)
            {
                _value.Days = int.Parse(_child.Value, System.Globalization.CultureInfo.InvariantCulture);
            }
            CustomizeFromXml(element, _value);
            return _value;
        }

        static partial void CustomizeFromXml(System.Xml.Linq.XElement element, Azure.Storage.Files.Models.RetentionPolicy value);
    }
}
#endregion class RetentionPolicy

#region class ShareInfo
namespace Azure.Storage.Files.Models
{
    /// <summary>
    /// ShareInfo
    /// </summary>
    public partial class ShareInfo
    {
        /// <summary>
        /// The ETag contains a value which represents the version of the share, in quotes.
        /// </summary>
        public Azure.ETag ETag { get; internal set; }

        /// <summary>
        /// Returns the date and time the share was last modified. Any operation that modifies the share or its properties or metadata updates the last modified time. Operations on files do not affect the last modified time of the share.
        /// </summary>
        public System.DateTimeOffset LastModified { get; internal set; }

        /// <summary>
        /// Prevent direct instantiation of ShareInfo instances.
        /// You can use FilesModelFactory.ShareInfo instead.
        /// </summary>
        internal ShareInfo() { }
    }

    /// <summary>
    /// FilesModelFactory provides utilities for mocking.
    /// </summary>
    public static partial class FilesModelFactory
    {
        /// <summary>
        /// Creates a new ShareInfo instance for mocking.
        /// </summary>
        public static ShareInfo ShareInfo(
            Azure.ETag eTag,
            System.DateTimeOffset lastModified)
        {
            return new ShareInfo()
            {
                ETag = eTag,
                LastModified = lastModified,
            };
        }
    }
}
#endregion class ShareInfo

#region class ShareItem
namespace Azure.Storage.Files.Models
{
    /// <summary>
    /// A listed Azure Storage share item.
    /// </summary>
    public partial class ShareItem
    {
        /// <summary>
        /// Name
        /// </summary>
        public string Name { get; internal set; }

        /// <summary>
        /// Snapshot
        /// </summary>
        public string Snapshot { get; internal set; }

        /// <summary>
        /// Properties of a share.
        /// </summary>
        public Azure.Storage.Files.Models.ShareItemProperties Properties { get; internal set; }

        /// <summary>
        /// Metadata
        /// </summary>
        public System.Collections.Generic.IDictionary<string, string> Metadata { get; internal set; }

        /// <summary>
        /// Creates a new ShareItem instance
        /// </summary>
        public ShareItem()
            : this(false)
        {
        }

        /// <summary>
        /// Creates a new ShareItem instance
        /// </summary>
        /// <param name="skipInitialization">Whether to skip initializing nested objects.</param>
        internal ShareItem(bool skipInitialization)
        {
            if (!skipInitialization)
            {
                Properties = new Azure.Storage.Files.Models.ShareItemProperties();
                Metadata = new System.Collections.Generic.Dictionary<string, string>(System.StringComparer.OrdinalIgnoreCase);
            }
        }

        /// <summary>
        /// Deserializes XML into a new ShareItem instance.
        /// </summary>
        /// <param name="element">The XML element to deserialize.</param>
        /// <returns>A deserialized ShareItem instance.</returns>
        internal static Azure.Storage.Files.Models.ShareItem FromXml(System.Xml.Linq.XElement element)
        {
            System.Diagnostics.Debug.Assert(element != null);
            System.Xml.Linq.XElement _child;
            Azure.Storage.Files.Models.ShareItem _value = new Azure.Storage.Files.Models.ShareItem(true);
            _child = element.Element(System.Xml.Linq.XName.Get("Name", ""));
            if (_child != null)
            {
                _value.Name = _child.Value;
            }
            _child = element.Element(System.Xml.Linq.XName.Get("Snapshot", ""));
            if (_child != null)
            {
                _value.Snapshot = _child.Value;
            }
            _child = element.Element(System.Xml.Linq.XName.Get("Properties", ""));
            if (_child != null)
            {
                _value.Properties = Azure.Storage.Files.Models.ShareItemProperties.FromXml(_child);
            }
            _value.Metadata = new System.Collections.Generic.Dictionary<string, string>(System.StringComparer.OrdinalIgnoreCase);
            _child = element.Element(System.Xml.Linq.XName.Get("Metadata", ""));
            if (_child != null)
            {
                foreach (System.Xml.Linq.XElement _pair in _child.Elements())
                {
                    _value.Metadata[_pair.Name.LocalName] = _pair.Value;
                }
            }
            CustomizeFromXml(element, _value);
            return _value;
        }

        static partial void CustomizeFromXml(System.Xml.Linq.XElement element, Azure.Storage.Files.Models.ShareItem value);
    }

    /// <summary>
    /// FilesModelFactory provides utilities for mocking.
    /// </summary>
    public static partial class FilesModelFactory
    {
        /// <summary>
        /// Creates a new ShareItem instance for mocking.
        /// </summary>
        public static ShareItem ShareItem(
            string name,
            Azure.Storage.Files.Models.ShareItemProperties properties,
            string snapshot = default,
            System.Collections.Generic.IDictionary<string, string> metadata = default)
        {
            return new ShareItem()
            {
                Name = name,
                Properties = properties,
                Snapshot = snapshot,
                Metadata = metadata,
            };
        }
    }
}
#endregion class ShareItem

#region class ShareItemProperties
namespace Azure.Storage.Files.Models
{
    /// <summary>
    /// Properties of a share.
    /// </summary>
    public partial class ShareItemProperties
    {
        /// <summary>
        /// Last-Modified
        /// </summary>
        public System.DateTimeOffset? LastModified { get; internal set; }

        /// <summary>
        /// Etag
        /// </summary>
        public Azure.ETag? Etag { get; internal set; }

        /// <summary>
        /// Quota
        /// </summary>
        public int? Quota { get; internal set; }

        /// <summary>
        /// Prevent direct instantiation of ShareItemProperties instances.
        /// You can use FilesModelFactory.ShareItemProperties instead.
        /// </summary>
        internal ShareItemProperties() { }

        /// <summary>
        /// Deserializes XML into a new ShareItemProperties instance.
        /// </summary>
        /// <param name="element">The XML element to deserialize.</param>
        /// <returns>A deserialized ShareItemProperties instance.</returns>
        internal static Azure.Storage.Files.Models.ShareItemProperties FromXml(System.Xml.Linq.XElement element)
        {
            System.Diagnostics.Debug.Assert(element != null);
            System.Xml.Linq.XElement _child;
            Azure.Storage.Files.Models.ShareItemProperties _value = new Azure.Storage.Files.Models.ShareItemProperties();
            _child = element.Element(System.Xml.Linq.XName.Get("Last-Modified", ""));
            if (_child != null)
            {
                _value.LastModified = System.DateTimeOffset.Parse(_child.Value, System.Globalization.CultureInfo.InvariantCulture);
            }
            _child = element.Element(System.Xml.Linq.XName.Get("Etag", ""));
            if (_child != null)
            {
                _value.Etag = new Azure.ETag(_child.Value);
            }
            _child = element.Element(System.Xml.Linq.XName.Get("Quota", ""));
            if (_child != null)
            {
                _value.Quota = int.Parse(_child.Value, System.Globalization.CultureInfo.InvariantCulture);
            }
            CustomizeFromXml(element, _value);
            return _value;
        }

        static partial void CustomizeFromXml(System.Xml.Linq.XElement element, Azure.Storage.Files.Models.ShareItemProperties value);
    }

    /// <summary>
    /// FilesModelFactory provides utilities for mocking.
    /// </summary>
    public static partial class FilesModelFactory
    {
        /// <summary>
        /// Creates a new ShareItemProperties instance for mocking.
        /// </summary>
        public static ShareItemProperties ShareItemProperties(
            System.DateTimeOffset? lastModified = default,
            Azure.ETag? etag = default,
            int? quota = default)
        {
            return new ShareItemProperties()
            {
                LastModified = lastModified,
                Etag = etag,
                Quota = quota,
            };
        }
    }
}
#endregion class ShareItemProperties

#region class ShareProperties
namespace Azure.Storage.Files.Models
{
    /// <summary>
    /// ShareProperties
    /// </summary>
    public partial class ShareProperties
    {
        /// <summary>
        /// A set of name-value pairs that contain the user-defined metadata of the share.
        /// </summary>
        public System.Collections.Generic.IDictionary<string, string> Metadata { get; internal set; }

        /// <summary>
        /// The ETag contains a value that you can use to perform operations conditionally, in quotes.
        /// </summary>
        public Azure.ETag ETag { get; internal set; }

        /// <summary>
        /// Returns the date and time the share was last modified. Any operation that modifies the share or its properties updates the last modified time. Operations on files do not affect the last modified time of the share.
        /// </summary>
        public System.DateTimeOffset LastModified { get; internal set; }

        /// <summary>
        /// Returns the current share quota in GB.
        /// </summary>
        public int Quota { get; internal set; }

        /// <summary>
        /// Creates a new ShareProperties instance
        /// </summary>
        public ShareProperties()
        {
            Metadata = new System.Collections.Generic.Dictionary<string, string>(System.StringComparer.OrdinalIgnoreCase);
        }
    }

    /// <summary>
    /// FilesModelFactory provides utilities for mocking.
    /// </summary>
    public static partial class FilesModelFactory
    {
        /// <summary>
        /// Creates a new ShareProperties instance for mocking.
        /// </summary>
        public static ShareProperties ShareProperties(
            System.Collections.Generic.IDictionary<string, string> metadata,
            Azure.ETag eTag,
            System.DateTimeOffset lastModified,
            int quota)
        {
            return new ShareProperties()
            {
                Metadata = metadata,
                ETag = eTag,
                LastModified = lastModified,
                Quota = quota,
            };
        }
    }
}
#endregion class ShareProperties

#region class ShareSnapshotInfo
namespace Azure.Storage.Files.Models
{
    /// <summary>
    /// ShareSnapshotInfo
    /// </summary>
    public partial class ShareSnapshotInfo
    {
        /// <summary>
        /// This header is a DateTime value that uniquely identifies the share snapshot. The value of this header may be used in subsequent requests to access the share snapshot. This value is opaque.
        /// </summary>
        public string Snapshot { get; internal set; }

        /// <summary>
        /// The ETag contains a value which represents the version of the share snapshot, in quotes. A share snapshot cannot be modified, so the ETag of a given share snapshot never changes. However, if new metadata was supplied with the Snapshot Share request then the ETag of the share snapshot differs from that of the base share. If no metadata was specified with the request, the ETag of the share snapshot is identical to that of the base share at the time the share snapshot was taken.
        /// </summary>
        public Azure.ETag ETag { get; internal set; }

        /// <summary>
        /// Returns the date and time the share was last modified. A share snapshot cannot be modified, so the last modified time of a given share snapshot never changes. However, if new metadata was supplied with the Snapshot Share request then the last modified time of the share snapshot differs from that of the base share. If no metadata was specified with the request, the last modified time of the share snapshot is identical to that of the base share at the time the share snapshot was taken.
        /// </summary>
        public System.DateTimeOffset LastModified { get; internal set; }

        /// <summary>
        /// Prevent direct instantiation of ShareSnapshotInfo instances.
        /// You can use FilesModelFactory.ShareSnapshotInfo instead.
        /// </summary>
        internal ShareSnapshotInfo() { }
    }

    /// <summary>
    /// FilesModelFactory provides utilities for mocking.
    /// </summary>
    public static partial class FilesModelFactory
    {
        /// <summary>
        /// Creates a new ShareSnapshotInfo instance for mocking.
        /// </summary>
        public static ShareSnapshotInfo ShareSnapshotInfo(
            string snapshot,
            Azure.ETag eTag,
            System.DateTimeOffset lastModified)
        {
            return new ShareSnapshotInfo()
            {
                Snapshot = snapshot,
                ETag = eTag,
                LastModified = lastModified,
            };
        }
    }
}
#endregion class ShareSnapshotInfo

#region class ShareStatistics
namespace Azure.Storage.Files.Models
{
    /// <summary>
    /// Stats for the share.
    /// </summary>
    public partial class ShareStatistics
    {
        /// <summary>
        /// The approximate size of the data stored in bytes, rounded up to the nearest gigabyte. Note that this value may not include all recently created or recently resized files.
        /// </summary>
        public int ShareUsageBytes { get; internal set; }

        /// <summary>
        /// Prevent direct instantiation of ShareStatistics instances.
        /// You can use FilesModelFactory.ShareStatistics instead.
        /// </summary>
        internal ShareStatistics() { }

        /// <summary>
        /// Deserializes XML into a new ShareStatistics instance.
        /// </summary>
        /// <param name="element">The XML element to deserialize.</param>
        /// <returns>A deserialized ShareStatistics instance.</returns>
        internal static Azure.Storage.Files.Models.ShareStatistics FromXml(System.Xml.Linq.XElement element)
        {
            System.Diagnostics.Debug.Assert(element != null);
            System.Xml.Linq.XElement _child;
            Azure.Storage.Files.Models.ShareStatistics _value = new Azure.Storage.Files.Models.ShareStatistics();
            _child = element.Element(System.Xml.Linq.XName.Get("ShareUsageBytes", ""));
            if (_child != null)
            {
                _value.ShareUsageBytes = int.Parse(_child.Value, System.Globalization.CultureInfo.InvariantCulture);
            }
            CustomizeFromXml(element, _value);
            return _value;
        }

        static partial void CustomizeFromXml(System.Xml.Linq.XElement element, Azure.Storage.Files.Models.ShareStatistics value);
    }

    /// <summary>
    /// FilesModelFactory provides utilities for mocking.
    /// </summary>
    public static partial class FilesModelFactory
    {
        /// <summary>
        /// Creates a new ShareStatistics instance for mocking.
        /// </summary>
        public static ShareStatistics ShareStatistics(
            int shareUsageBytes)
        {
            return new ShareStatistics()
            {
                ShareUsageBytes = shareUsageBytes,
            };
        }
    }
}
#endregion class ShareStatistics

#region class SharesSegment
namespace Azure.Storage.Files.Models
{
    /// <summary>
    /// An enumeration of shares.
    /// </summary>
    internal partial class SharesSegment
    {
        /// <summary>
        /// ServiceEndpoint
        /// </summary>
        public string ServiceEndpoint { get; internal set; }

        /// <summary>
        /// Prefix
        /// </summary>
        public string Prefix { get; internal set; }

        /// <summary>
        /// Marker
        /// </summary>
        public string Marker { get; internal set; }

        /// <summary>
        /// MaxResults
        /// </summary>
        public int? MaxResults { get; internal set; }

        /// <summary>
        /// ShareItems
        /// </summary>
        public System.Collections.Generic.IEnumerable<Azure.Storage.Files.Models.ShareItem> ShareItems { get; internal set; }

        /// <summary>
        /// NextMarker
        /// </summary>
        public string NextMarker { get; internal set; }

        /// <summary>
        /// Creates a new SharesSegment instance
        /// </summary>
        public SharesSegment()
            : this(false)
        {
        }

        /// <summary>
        /// Creates a new SharesSegment instance
        /// </summary>
        /// <param name="skipInitialization">Whether to skip initializing nested objects.</param>
        internal SharesSegment(bool skipInitialization)
        {
            if (!skipInitialization)
            {
                ShareItems = new System.Collections.Generic.List<Azure.Storage.Files.Models.ShareItem>();
            }
        }

        /// <summary>
        /// Deserializes XML into a new SharesSegment instance.
        /// </summary>
        /// <param name="element">The XML element to deserialize.</param>
        /// <returns>A deserialized SharesSegment instance.</returns>
        internal static Azure.Storage.Files.Models.SharesSegment FromXml(System.Xml.Linq.XElement element)
        {
            System.Diagnostics.Debug.Assert(element != null);
            System.Xml.Linq.XElement _child;
            System.Xml.Linq.XAttribute _attribute;
            Azure.Storage.Files.Models.SharesSegment _value = new Azure.Storage.Files.Models.SharesSegment(true);
            _attribute = element.Attribute(System.Xml.Linq.XName.Get("ServiceEndpoint", ""));
            if (_attribute != null)
            {
                _value.ServiceEndpoint = _attribute.Value;
            }
            _child = element.Element(System.Xml.Linq.XName.Get("Prefix", ""));
            if (_child != null)
            {
                _value.Prefix = _child.Value;
            }
            _child = element.Element(System.Xml.Linq.XName.Get("Marker", ""));
            if (_child != null)
            {
                _value.Marker = _child.Value;
            }
            _child = element.Element(System.Xml.Linq.XName.Get("MaxResults", ""));
            if (_child != null)
            {
                _value.MaxResults = int.Parse(_child.Value, System.Globalization.CultureInfo.InvariantCulture);
            }
            _child = element.Element(System.Xml.Linq.XName.Get("Shares", ""));
            if (_child != null)
            {
                _value.ShareItems = System.Linq.Enumerable.ToList(
                    System.Linq.Enumerable.Select(
                        _child.Elements(System.Xml.Linq.XName.Get("Share", "")),
                        e => Azure.Storage.Files.Models.ShareItem.FromXml(e)));
            }
            else
            {
                _value.ShareItems = new System.Collections.Generic.List<Azure.Storage.Files.Models.ShareItem>();
            }
            _child = element.Element(System.Xml.Linq.XName.Get("NextMarker", ""));
            if (_child != null)
            {
                _value.NextMarker = _child.Value;
            }
            CustomizeFromXml(element, _value);
            return _value;
        }

        static partial void CustomizeFromXml(System.Xml.Linq.XElement element, Azure.Storage.Files.Models.SharesSegment value);
    }
}
#endregion class SharesSegment

#region class SignedIdentifier
namespace Azure.Storage.Files.Models
{
    /// <summary>
    /// Signed identifier.
    /// </summary>
    public partial class SignedIdentifier
    {
        /// <summary>
        /// A unique id.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// The access policy.
        /// </summary>
        public Azure.Storage.Files.Models.AccessPolicy AccessPolicy { get; set; }

        /// <summary>
        /// Creates a new SignedIdentifier instance
        /// </summary>
        public SignedIdentifier()
            : this(false)
        {
        }

        /// <summary>
        /// Creates a new SignedIdentifier instance
        /// </summary>
        /// <param name="skipInitialization">Whether to skip initializing nested objects.</param>
        internal SignedIdentifier(bool skipInitialization)
        {
            if (!skipInitialization)
            {
                AccessPolicy = new Azure.Storage.Files.Models.AccessPolicy();
            }
        }

        /// <summary>
        /// Serialize a SignedIdentifier instance as XML.
        /// </summary>
        /// <param name="value">The SignedIdentifier instance to serialize.</param>
        /// <param name="name">An optional name to use for the root element instead of "SignedIdentifier".</param>
        /// <param name="ns">An optional namespace to use for the root element instead of "".</param>
        /// <returns>The serialized XML element.</returns>
        internal static System.Xml.Linq.XElement ToXml(Azure.Storage.Files.Models.SignedIdentifier value, string name = "SignedIdentifier", string ns = "")
        {
            System.Diagnostics.Debug.Assert(value != null);
            System.Xml.Linq.XElement _element = new System.Xml.Linq.XElement(System.Xml.Linq.XName.Get(name, ns));
            _element.Add(new System.Xml.Linq.XElement(
                System.Xml.Linq.XName.Get("Id", ""),
                value.Id));
            if (value.AccessPolicy != null)
            {
                _element.Add(Azure.Storage.Files.Models.AccessPolicy.ToXml(value.AccessPolicy, "AccessPolicy", ""));
            }
            return _element;
        }

        /// <summary>
        /// Deserializes XML into a new SignedIdentifier instance.
        /// </summary>
        /// <param name="element">The XML element to deserialize.</param>
        /// <returns>A deserialized SignedIdentifier instance.</returns>
        internal static Azure.Storage.Files.Models.SignedIdentifier FromXml(System.Xml.Linq.XElement element)
        {
            System.Diagnostics.Debug.Assert(element != null);
            System.Xml.Linq.XElement _child;
            Azure.Storage.Files.Models.SignedIdentifier _value = new Azure.Storage.Files.Models.SignedIdentifier(true);
            _child = element.Element(System.Xml.Linq.XName.Get("Id", ""));
            if (_child != null)
            {
                _value.Id = _child.Value;
            }
            _child = element.Element(System.Xml.Linq.XName.Get("AccessPolicy", ""));
            if (_child != null)
            {
                _value.AccessPolicy = Azure.Storage.Files.Models.AccessPolicy.FromXml(_child);
            }
            CustomizeFromXml(element, _value);
            return _value;
        }

        static partial void CustomizeFromXml(System.Xml.Linq.XElement element, Azure.Storage.Files.Models.SignedIdentifier value);
    }
}
#endregion class SignedIdentifier

#region class StorageClosedHandlesSegment
namespace Azure.Storage.Files.Models
{
    /// <summary>
    /// StorageClosedHandlesSegment
    /// </summary>
    public partial class StorageClosedHandlesSegment
    {
        /// <summary>
        /// A string describing next handle to be closed. It is returned when more handles need to be closed to complete the request.
        /// </summary>
        public string Marker { get; internal set; }

        /// <summary>
        /// Contains count of number of handles closed.
        /// </summary>
        public int NumberOfHandlesClosed { get; internal set; }

        /// <summary>
        /// Prevent direct instantiation of StorageClosedHandlesSegment instances.
        /// You can use FilesModelFactory.StorageClosedHandlesSegment instead.
        /// </summary>
        internal StorageClosedHandlesSegment() { }
    }

    /// <summary>
    /// FilesModelFactory provides utilities for mocking.
    /// </summary>
    public static partial class FilesModelFactory
    {
        /// <summary>
        /// Creates a new StorageClosedHandlesSegment instance for mocking.
        /// </summary>
        public static StorageClosedHandlesSegment StorageClosedHandlesSegment(
            string marker,
            int numberOfHandlesClosed)
        {
            return new StorageClosedHandlesSegment()
            {
                Marker = marker,
                NumberOfHandlesClosed = numberOfHandlesClosed,
            };
        }
    }
}
#endregion class StorageClosedHandlesSegment

#region class StorageError
namespace Azure.Storage.Files.Models
{
    /// <summary>
    /// StorageError
    /// </summary>
    internal partial class StorageError
    {
        /// <summary>
        /// Message
        /// </summary>
        public string Message { get; internal set; }

        /// <summary>
        /// Code
        /// </summary>
        public string Code { get; internal set; }

        /// <summary>
        /// Prevent direct instantiation of StorageError instances.
        /// You can use FilesModelFactory.StorageError instead.
        /// </summary>
        internal StorageError() { }

        /// <summary>
        /// Deserializes XML into a new StorageError instance.
        /// </summary>
        /// <param name="element">The XML element to deserialize.</param>
        /// <returns>A deserialized StorageError instance.</returns>
        internal static Azure.Storage.Files.Models.StorageError FromXml(System.Xml.Linq.XElement element)
        {
            System.Diagnostics.Debug.Assert(element != null);
            System.Xml.Linq.XElement _child;
            Azure.Storage.Files.Models.StorageError _value = new Azure.Storage.Files.Models.StorageError();
            _child = element.Element(System.Xml.Linq.XName.Get("Message", ""));
            if (_child != null)
            {
                _value.Message = _child.Value;
            }
            _child = element.Element(System.Xml.Linq.XName.Get("Code", ""));
            if (_child != null)
            {
                _value.Code = _child.Value;
            }
            CustomizeFromXml(element, _value);
            return _value;
        }

        static partial void CustomizeFromXml(System.Xml.Linq.XElement element, Azure.Storage.Files.Models.StorageError value);
    }
}
#endregion class StorageError

#region class StorageFileCopyInfo
namespace Azure.Storage.Files.Models
{
    /// <summary>
    /// StorageFileCopyInfo
    /// </summary>
    public partial class StorageFileCopyInfo
    {
        /// <summary>
        /// If the copy is completed, contains the ETag of the destination file. If the copy is not complete, contains the ETag of the empty file created at the start of the copy.
        /// </summary>
        public Azure.ETag ETag { get; internal set; }

        /// <summary>
        /// Returns the date/time that the copy operation to the destination file completed.
        /// </summary>
        public System.DateTimeOffset LastModified { get; internal set; }

        /// <summary>
        /// String identifier for this copy operation. Use with Get File or Get File Properties to check the status of this copy operation, or pass to Abort Copy File to abort a pending copy.
        /// </summary>
        public string CopyId { get; internal set; }

        /// <summary>
        /// State of the copy operation identified by x-ms-copy-id.
        /// </summary>
        public Azure.Storage.Files.Models.CopyStatus CopyStatus { get; internal set; }

        /// <summary>
        /// Prevent direct instantiation of StorageFileCopyInfo instances.
        /// You can use FilesModelFactory.StorageFileCopyInfo instead.
        /// </summary>
        internal StorageFileCopyInfo() { }
    }

    /// <summary>
    /// FilesModelFactory provides utilities for mocking.
    /// </summary>
    public static partial class FilesModelFactory
    {
        /// <summary>
        /// Creates a new StorageFileCopyInfo instance for mocking.
        /// </summary>
        public static StorageFileCopyInfo StorageFileCopyInfo(
            Azure.ETag eTag,
            System.DateTimeOffset lastModified,
            string copyId,
            Azure.Storage.Files.Models.CopyStatus copyStatus)
        {
            return new StorageFileCopyInfo()
            {
                ETag = eTag,
                LastModified = lastModified,
                CopyId = copyId,
                CopyStatus = copyStatus,
            };
        }
    }
}
#endregion class StorageFileCopyInfo

#region class StorageFileRangeInfo
namespace Azure.Storage.Files.Models
{
    /// <summary>
    /// StorageFileRangeInfo
    /// </summary>
    public partial class StorageFileRangeInfo
    {
        /// <summary>
        /// The date/time that the file was last modified. Any operation that modifies the file, including an update of the file's metadata or properties, changes the file's last modified time.
        /// </summary>
        public System.DateTimeOffset LastModified { get; internal set; }

        /// <summary>
        /// The ETag contains a value which represents the version of the file, in quotes.
        /// </summary>
        public Azure.ETag ETag { get; internal set; }

        /// <summary>
        /// The size of the file in bytes.
        /// </summary>
        public long FileContentLength { get; internal set; }

        /// <summary>
        /// A list of non-overlapping valid ranges, sorted by increasing address range.
        /// </summary>
        public System.Collections.Generic.IEnumerable<Azure.Storage.Files.Models.Range> Ranges { get; internal set; }

        /// <summary>
        /// Creates a new StorageFileRangeInfo instance
        /// </summary>
        public StorageFileRangeInfo()
        {
            Ranges = new System.Collections.Generic.List<Azure.Storage.Files.Models.Range>();
        }
    }

    /// <summary>
    /// FilesModelFactory provides utilities for mocking.
    /// </summary>
    public static partial class FilesModelFactory
    {
        /// <summary>
        /// Creates a new StorageFileRangeInfo instance for mocking.
        /// </summary>
        public static StorageFileRangeInfo StorageFileRangeInfo(
            System.DateTimeOffset lastModified,
            Azure.ETag eTag,
            long fileContentLength,
            System.Collections.Generic.IEnumerable<Azure.Storage.Files.Models.Range> ranges)
        {
            return new StorageFileRangeInfo()
            {
                LastModified = lastModified,
                ETag = eTag,
                FileContentLength = fileContentLength,
                Ranges = ranges,
            };
        }
    }
}
#endregion class StorageFileRangeInfo

#region class StorageFileUploadInfo
namespace Azure.Storage.Files.Models
{
    /// <summary>
    /// StorageFileUploadInfo
    /// </summary>
    public partial class StorageFileUploadInfo
    {
        /// <summary>
        /// The ETag contains a value which represents the version of the file, in quotes.
        /// </summary>
        public Azure.ETag ETag { get; internal set; }

        /// <summary>
        /// Returns the date and time the directory was last modified. Any operation that modifies the share or its properties or metadata updates the last modified time. Operations on files do not affect the last modified time of the share.
        /// </summary>
        public System.DateTimeOffset LastModified { get; internal set; }

        /// <summary>
        /// This header is returned so that the client can check for message content integrity. The value of this header is computed by the File service; it is not necessarily the same value as may have been specified in the request headers.
        /// </summary>
        #pragma warning disable CA1819 // Properties should not return arrays
        public byte[] ContentHash { get; internal set; }
        #pragma warning restore CA1819 // Properties should not return arrays

        /// <summary>
        /// The value of this header is set to true if the contents of the request are successfully encrypted using the specified algorithm, and false otherwise.
        /// </summary>
        public bool IsServerEncrypted { get; internal set; }

        /// <summary>
        /// Prevent direct instantiation of StorageFileUploadInfo instances.
        /// You can use FilesModelFactory.StorageFileUploadInfo instead.
        /// </summary>
        internal StorageFileUploadInfo() { }
    }

    /// <summary>
    /// FilesModelFactory provides utilities for mocking.
    /// </summary>
    public static partial class FilesModelFactory
    {
        /// <summary>
        /// Creates a new StorageFileUploadInfo instance for mocking.
        /// </summary>
        public static StorageFileUploadInfo StorageFileUploadInfo(
            Azure.ETag eTag,
            System.DateTimeOffset lastModified,
            byte[] contentHash,
            bool isServerEncrypted)
        {
            return new StorageFileUploadInfo()
            {
                ETag = eTag,
                LastModified = lastModified,
                ContentHash = contentHash,
                IsServerEncrypted = isServerEncrypted,
            };
        }
    }
}
#endregion class StorageFileUploadInfo

#region class StorageHandle
namespace Azure.Storage.Files.Models
{
    /// <summary>
    /// A listed Azure Storage handle item.
    /// </summary>
    public partial class StorageHandle
    {
        /// <summary>
        /// XSMB service handle ID
        /// </summary>
        public string HandleId { get; internal set; }

        /// <summary>
        /// File or directory name including full path starting from share root
        /// </summary>
        public string Path { get; internal set; }

        /// <summary>
        /// FileId uniquely identifies the file or directory.
        /// </summary>
        public string FileId { get; internal set; }

        /// <summary>
        /// ParentId uniquely identifies the parent directory of the object.
        /// </summary>
        public string ParentId { get; internal set; }

        /// <summary>
        /// SMB session ID in context of which the file handle was opened
        /// </summary>
        public string SessionId { get; internal set; }

        /// <summary>
        /// Client IP that opened the handle
        /// </summary>
        public string ClientIp { get; internal set; }

        /// <summary>
        /// Time when the session that previously opened the handle has last been reconnected. (UTC)
        /// </summary>
        public System.DateTimeOffset OpenTime { get; internal set; }

        /// <summary>
        /// Time handle was last connected to (UTC)
        /// </summary>
        public System.DateTimeOffset? LastReconnectTime { get; internal set; }

        /// <summary>
        /// Prevent direct instantiation of StorageHandle instances.
        /// You can use FilesModelFactory.StorageHandle instead.
        /// </summary>
        internal StorageHandle() { }

        /// <summary>
        /// Deserializes XML into a new StorageHandle instance.
        /// </summary>
        /// <param name="element">The XML element to deserialize.</param>
        /// <returns>A deserialized StorageHandle instance.</returns>
        internal static Azure.Storage.Files.Models.StorageHandle FromXml(System.Xml.Linq.XElement element)
        {
            System.Diagnostics.Debug.Assert(element != null);
            System.Xml.Linq.XElement _child;
            Azure.Storage.Files.Models.StorageHandle _value = new Azure.Storage.Files.Models.StorageHandle();
            _child = element.Element(System.Xml.Linq.XName.Get("HandleId", ""));
            if (_child != null)
            {
                _value.HandleId = _child.Value;
            }
            _child = element.Element(System.Xml.Linq.XName.Get("Path", ""));
            if (_child != null)
            {
                _value.Path = _child.Value;
            }
            _child = element.Element(System.Xml.Linq.XName.Get("FileId", ""));
            if (_child != null)
            {
                _value.FileId = _child.Value;
            }
            _child = element.Element(System.Xml.Linq.XName.Get("ParentId", ""));
            if (_child != null)
            {
                _value.ParentId = _child.Value;
            }
            _child = element.Element(System.Xml.Linq.XName.Get("SessionId", ""));
            if (_child != null)
            {
                _value.SessionId = _child.Value;
            }
            _child = element.Element(System.Xml.Linq.XName.Get("ClientIp", ""));
            if (_child != null)
            {
                _value.ClientIp = _child.Value;
            }
            _child = element.Element(System.Xml.Linq.XName.Get("OpenTime", ""));
            if (_child != null)
            {
                _value.OpenTime = System.DateTimeOffset.Parse(_child.Value, System.Globalization.CultureInfo.InvariantCulture);
            }
            _child = element.Element(System.Xml.Linq.XName.Get("LastReconnectTime", ""));
            if (_child != null)
            {
                _value.LastReconnectTime = System.DateTimeOffset.Parse(_child.Value, System.Globalization.CultureInfo.InvariantCulture);
            }
            CustomizeFromXml(element, _value);
            return _value;
        }

        static partial void CustomizeFromXml(System.Xml.Linq.XElement element, Azure.Storage.Files.Models.StorageHandle value);
    }

    /// <summary>
    /// FilesModelFactory provides utilities for mocking.
    /// </summary>
    public static partial class FilesModelFactory
    {
        /// <summary>
        /// Creates a new StorageHandle instance for mocking.
        /// </summary>
        public static StorageHandle StorageHandle(
            string handleId,
            string path,
            string fileId,
            string sessionId,
            string clientIp,
            System.DateTimeOffset openTime,
            string parentId = default,
            System.DateTimeOffset? lastReconnectTime = default)
        {
            return new StorageHandle()
            {
                HandleId = handleId,
                Path = path,
                FileId = fileId,
                SessionId = sessionId,
                ClientIp = clientIp,
                OpenTime = openTime,
                ParentId = parentId,
                LastReconnectTime = lastReconnectTime,
            };
        }
    }
}
#endregion class StorageHandle

#region class StorageHandlesSegment
namespace Azure.Storage.Files.Models
{
    /// <summary>
    /// An enumeration of handles.
    /// </summary>
    internal partial class StorageHandlesSegment
    {
        /// <summary>
        /// NextMarker
        /// </summary>
        public string NextMarker { get; internal set; }

        /// <summary>
        /// Handles
        /// </summary>
        public System.Collections.Generic.IEnumerable<Azure.Storage.Files.Models.StorageHandle> Handles { get; internal set; }

        /// <summary>
        /// Creates a new StorageHandlesSegment instance
        /// </summary>
        public StorageHandlesSegment()
            : this(false)
        {
        }

        /// <summary>
        /// Creates a new StorageHandlesSegment instance
        /// </summary>
        /// <param name="skipInitialization">Whether to skip initializing nested objects.</param>
        internal StorageHandlesSegment(bool skipInitialization)
        {
            if (!skipInitialization)
            {
                Handles = new System.Collections.Generic.List<Azure.Storage.Files.Models.StorageHandle>();
            }
        }

        /// <summary>
        /// Deserializes XML into a new StorageHandlesSegment instance.
        /// </summary>
        /// <param name="element">The XML element to deserialize.</param>
        /// <returns>A deserialized StorageHandlesSegment instance.</returns>
        internal static Azure.Storage.Files.Models.StorageHandlesSegment FromXml(System.Xml.Linq.XElement element)
        {
            System.Diagnostics.Debug.Assert(element != null);
            System.Xml.Linq.XElement _child;
            Azure.Storage.Files.Models.StorageHandlesSegment _value = new Azure.Storage.Files.Models.StorageHandlesSegment(true);
            _child = element.Element(System.Xml.Linq.XName.Get("NextMarker", ""));
            if (_child != null)
            {
                _value.NextMarker = _child.Value;
            }
            _child = element.Element(System.Xml.Linq.XName.Get("Entries", ""));
            if (_child != null)
            {
                _value.Handles = System.Linq.Enumerable.ToList(
                    System.Linq.Enumerable.Select(
                        _child.Elements(System.Xml.Linq.XName.Get("Handle", "")),
                        e => Azure.Storage.Files.Models.StorageHandle.FromXml(e)));
            }
            else
            {
                _value.Handles = new System.Collections.Generic.List<Azure.Storage.Files.Models.StorageHandle>();
            }
            CustomizeFromXml(element, _value);
            return _value;
        }

        static partial void CustomizeFromXml(System.Xml.Linq.XElement element, Azure.Storage.Files.Models.StorageHandlesSegment value);
    }
}
#endregion class StorageHandlesSegment

#region enum Header
namespace Azure.Storage.Files.Models
{
    /// <summary>
    /// Returns the type File. Reserved for future use.
    /// </summary>
    public enum Header
    {
        /// <summary>
        /// File
        /// </summary>
        File
    }
}
#endregion enum Header
#endregion Models

