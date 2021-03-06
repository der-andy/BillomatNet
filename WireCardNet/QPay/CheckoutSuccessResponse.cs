﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace WireCardNet.QPay
{
    /// <summary>
    /// This class represents a response from QPay if the payment was successful
    /// </summary>
    public class CheckoutSuccessResponse : CheckoutResponse
    {
        internal CheckoutSuccessResponse()
        {
        }

        /// <summary>
        /// Amount the consumer paid
        /// </summary>
        public Decimal Amount { get; internal set; }

        /// <summary>
        /// Code for the currency in which the transation was carried out
        /// </summary>
        public string Currency { get; internal set; }

        /// <summary>
        /// Type of payment in which the authorisation was carried out
        /// </summary>
        public PaymentType PaymentType { get; internal set; }

        /// <summary>
        /// Financial institution that was used (credit card type)
        /// </summary>
        public string FinancialInstitution { get; internal set; }

        /// <summary>
        /// Language code that was used
        /// </summary>
        public string Language { get; internal set; }

        /// <summary>
        /// Payment number that uniquely identifies the transaction
        /// </summary>
        public string OrderNumber { get; internal set; }

        /// <summary>
        /// The last four digits of the card number (only CC transactions)
        /// </summary>
        public string AnonymousPan { get; internal set; }

        /// <summary>
        /// Has the cardholder successfully authenticated himself? (only CC transactions)
        /// </summary>
        public bool? Authenticated { get; internal set; }

        /// <summary>
        /// Error message
        /// </summary>
        public string Message { get; internal set; }

        /// <summary>
        /// Expiration date of the credit card using the format MM/YYYY
        /// </summary>
        public string Expiry { get; internal set; }

        /// <summary>
        /// Name of the credit card holder
        /// </summary>
        public string Cardholder { get; internal set; }

        /// <summary>
        /// PCI compliant masked number: First 6 and last 4 digits of the card number with asterisks
        /// in between.
        /// </summary>
        public string MaskedPan { get; internal set; }

        /// <summary>
        /// Reference number of the processor/acquirer: Use this value as GuWID on server requests
        /// if you need to refer to a payment which was done via QPay (i.e. recurring payments via
        /// server API, but initial payment via QPay)
        /// </summary>
        public string GatewayReferenceNumber { get; internal set; }

        /// <summary>
        /// Contract number of the processor/acquirer: Use this value as Business Case Signature on
        /// server requests if you need to refer to a payment which was done via QPay (i.e. recurring
        /// payments via server API, but initial payment via QPay)
        /// </summary>
        public string GatewayContractNumber { get; internal set; }

        /// <summary>
        /// Name of the account holder returned by the iDEAL issuer
        /// </summary>
        public string IDealConsumerName { get; internal set; }

        /// <summary>
        /// City of the account holder returned by the iDEAL issuer
        /// </summary>
        public string IDealConsumerCity { get; internal set; }

        /// <summary>
        /// Number of the account returned by the iDEAL issuer
        /// </summary>
        public string IDealConsumerAccountNumber { get; internal set; }

        /// <summary>
        /// ID of the consumer returned by PayPal
        /// </summary>
        public string PayPalPayerID { get; internal set; }

        /// <summary>
        /// Email address of the consumer returned by PayPal
        /// </summary>
        public string PayPalPayerEMail { get; internal set; }

        /// <summary>
        /// Last name of the consumer returned by PayPal
        /// </summary>
        public string PayPalPayerLastName { get; internal set; }

        /// <summary>
        /// First name of the consumer returned by PayPal
        /// </summary>
        public string PayPalPayerFirstName { get; internal set; }

        /// <summary>
        /// Returns true if the fingerprint is valid
        /// </summary>
        public bool IsValid { get; internal set; }
    }
}