namespace SauceDemoTests.Selectors;

public static class CheckoutPage
{
    // URL
    public const string CheckoutStepOneUrl = "https://www.saucedemo.com/checkout-step-one.html";

    // Selectors
    public const string CheckoutContainer = ".checkout_info_container";
    public const string Title = ".title";
    public const string FirstNameInput = "#first-name";
    public const string LastNameInput = "#last-name";
    public const string ZipCodeInput = "#postal-code";
    public const string ContinueButton = "#continue";
    public const string CancelButton = "#cancel";

    // Expected Values
    public const string TitleText = "Checkout: Your Information";
    public const string ContinueButtonText = "Continue";
    public const string CancelButtonText = "Cancel";
}