namespace SauceDemoTests.Selectors;

public static class CheckoutOverviewPage
{
    // URL
    public const string CheckoutStepTwoUrl = "https://www.saucedemo.com/checkout-step-two.html";

    // Selectors
    public const string PaymentInfoLabel = "[data-test='payment-info-label']";
    public const string PaymentInfoValue = "[data-test='payment-info-value']";
    public const string ShippingInfoLabel = "[data-test='shipping-info-label']";
    public const string ShippingInfoValue = "[data-test='shipping-info-value']";
    public const string SubtotalLabel = "[data-test='subtotal-label']";
    public const string TaxLabel = "[data-test='tax-label']";
    public const string TotalLabel = "[data-test='total-label']";
    public const string FinishButton = "#finish";

    // Expected Values
    public const string TitleText = "Checkout: Overview";
    public const string PaymentInfoLabelText = "Payment Information:";
    public const string ShippingInfoLabelText = "Shipping Information:";
    public const string FinishButtonText = "Finish";
}