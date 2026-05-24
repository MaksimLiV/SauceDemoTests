namespace SauceDemoTests.Selectors;

public static class CheckoutCompletePage
{
    // URL
    public const string CheckoutCompleteUrl = "https://www.saucedemo.com/checkout-complete.html";

    // Selectors
    public const string Title = ".title";
    public const string SuccessMessage = ".complete-header";
    public const string SuccessSubMessage = ".complete-text";
    public const string BackHomeButton = "#back-to-products";

    // Expected Values
    public const string TitleText = "Checkout: Complete!";
    public const string SuccessMessageText = "Thank you for your order!";
    public const string SuccessSubMessagText = "Your order has been dispatched, and will arrive just as fast as the pony can get there!";
    public const string BackHomeButtonText = "Back Home";
}