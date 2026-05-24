namespace SauceDemoTests.Selectors;

public static class InventoryItem
{
    // URLs
    public const string InventoryItemUrl = "https://www.saucedemo.com/inventory-item.html?id=1";

    // Selectors
    public const string CartIcon = ".shopping_cart_link"; 
    public const string CartBadge = ".shopping_cart_badge";
    public const string BackButton = "#back-to-products"; 
    public const string ProductName = ".inventory_details_name";
    public const string ProductDesc = ".inventory_details_desc.large_size";
    public const string ProductPrice = ".inventory_details_price";
    public const string AddButton ="#add-to-cart"; 
    

    // Expected Values
    
    public const string BackButtonText = "Back to products";
    public const string AddButtonText = "Add to cart"; 
    public static string CartBadgeText(int count) => count.ToString();
}

