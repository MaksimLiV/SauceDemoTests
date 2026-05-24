namespace SauceDemoTests.Selectors;

public static class YourCartPage
{
     // URL
     public const string YourCartPageUrl = "https://www.saucedemo.com/cart.html";

     // Selectors
     public const string CartList = ".cart_list";
     public const string RemoveButton = "#remove-sauce-labs-bolt-t-shirt";
     public const string ContinueShoppingButton = "#continue-shopping";
     public const string CheckoutButton = "#checkout";

     // Expected Values
     public const string TitleText = "Your Cart";
     public const string RemoveButtonText = "Remove";
     public const string ContinueShoppingButtonText = "Continue Shopping";
     public const string CheckoutButtonText = "Checkout";
}