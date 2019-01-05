﻿namespace Staaworks.PaymentIntegrator.Paystack.Extensions
{
    public interface IPaystackInitializationOptionsProvider
    {
        string SecretKey { get; }
        string ProviderName { get; }

        string BanksListUrl { get; }
        string BankAccountNameQueryUrl { get; }

        string PaymentVerificationUrl { get; }
        string PaymentInitializationUrl { get; }
        string PaymentChargeAuthorizationUrl { get; }
        string PaymentReauthorizationUrl { get; }
        string PaymentCheckAuthorizationUrl { get; }

        string SubscriptionInitializationUrl { get; }
        string SubscriptionActivationUrl { get; }
        string SubscriptionDeactivationUrl { get; }
        string SubscriptionPlanCreationUrl { get; }
        string SubscriptionPlanQueryUrl { get; }
        string SubscriptionQueryUrl { get; }

        string BankTransferRecipientCreationUrl { get; }
        string BankTransferInitiationUrl { get; }
    }
}
