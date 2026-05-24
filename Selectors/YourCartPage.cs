namespace SauceDemoTests.Selectors;

public static class YourCartPage
{
     //Url
     public const string YourCartPageUrl = "https://www.saucedemo.com/cart.html";

     // Selectors 

     public const string CartList = ".cart_list";
     public const string Title = ".title";
     public const string QTYLabel = ".cart_quantity_label";
     public const string DescLabel = ".cart_desc_label";
     public const string ItemTitle = ".inventory_item_name";
     public const string ItemQTY = "[data-test='item-quantity']";
     public const string ItemDesc = ".inventory_item_desc";
     public const string ItemPrice = ".inventory_item_price";
     public const string RemoveButton = "#remove-sauce-labs-bolt-t-shirt";
     public const string ContinueShoppingButton = "#continue-shopping";
     public const string CheckoutButton = "#checkout";

     // Expected Values
     public const string TitleText = "Your Cart";
     public const string QTYText = "QTY";
     public const string DescLabelText = "Description";
     public const string RemoveButtonText = "Remove";
     public const string ContinueShoppingButtonText = "Continue Shopping";
     public const string CheckoutButtonText = "Checkout";


}