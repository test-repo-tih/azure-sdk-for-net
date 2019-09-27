// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Billing
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for InvoicesOperations.
    /// </summary>
    public static partial class InvoicesOperationsExtensions
    {
            /// <summary>
            /// List of invoices for a billing account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountName'>
            /// billing Account Id.
            /// </param>
            /// <param name='periodStartDate'>
            /// Invoice period start date.
            /// </param>
            /// <param name='periodEndDate'>
            /// Invoice period end date.
            /// </param>
            public static InvoiceListResult ListByBillingAccount(this IInvoicesOperations operations, string billingAccountName, string periodStartDate, string periodEndDate)
            {
                return operations.ListByBillingAccountAsync(billingAccountName, periodStartDate, periodEndDate).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List of invoices for a billing account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountName'>
            /// billing Account Id.
            /// </param>
            /// <param name='periodStartDate'>
            /// Invoice period start date.
            /// </param>
            /// <param name='periodEndDate'>
            /// Invoice period end date.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<InvoiceListResult> ListByBillingAccountAsync(this IInvoicesOperations operations, string billingAccountName, string periodStartDate, string periodEndDate, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByBillingAccountWithHttpMessagesAsync(billingAccountName, periodStartDate, periodEndDate, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// List of invoices for a billing profile.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountName'>
            /// billing Account Id.
            /// </param>
            /// <param name='billingProfileName'>
            /// Billing Profile Id.
            /// </param>
            /// <param name='periodStartDate'>
            /// Invoice period start date.
            /// </param>
            /// <param name='periodEndDate'>
            /// Invoice period end date.
            /// </param>
            public static InvoiceListResult ListByBillingProfile(this IInvoicesOperations operations, string billingAccountName, string billingProfileName, string periodStartDate, string periodEndDate)
            {
                return operations.ListByBillingProfileAsync(billingAccountName, billingProfileName, periodStartDate, periodEndDate).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List of invoices for a billing profile.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountName'>
            /// billing Account Id.
            /// </param>
            /// <param name='billingProfileName'>
            /// Billing Profile Id.
            /// </param>
            /// <param name='periodStartDate'>
            /// Invoice period start date.
            /// </param>
            /// <param name='periodEndDate'>
            /// Invoice period end date.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<InvoiceListResult> ListByBillingProfileAsync(this IInvoicesOperations operations, string billingAccountName, string billingProfileName, string periodStartDate, string periodEndDate, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByBillingProfileWithHttpMessagesAsync(billingAccountName, billingProfileName, periodStartDate, periodEndDate, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get the invoice by name.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountName'>
            /// billing Account Id.
            /// </param>
            /// <param name='billingProfileName'>
            /// Billing Profile Id.
            /// </param>
            /// <param name='invoiceName'>
            /// Invoice Id.
            /// </param>
            public static Invoice Get(this IInvoicesOperations operations, string billingAccountName, string billingProfileName, string invoiceName)
            {
                return operations.GetAsync(billingAccountName, billingProfileName, invoiceName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get the invoice by name.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='billingAccountName'>
            /// billing Account Id.
            /// </param>
            /// <param name='billingProfileName'>
            /// Billing Profile Id.
            /// </param>
            /// <param name='invoiceName'>
            /// Invoice Id.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Invoice> GetAsync(this IInvoicesOperations operations, string billingAccountName, string billingProfileName, string invoiceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(billingAccountName, billingProfileName, invoiceName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
