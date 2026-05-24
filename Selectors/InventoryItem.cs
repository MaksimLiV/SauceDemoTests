namespace SauceDemoTests.Selectors;

public static class InventoryItem
{
    // URL
    public const string InventoryItemUrl = "https://www.saucedemo.com/inventory-item.html?id=1";

    // Selectors
    public const string ProductName = ".inventory_details_name";
    public const string ProductDesc = ".inventory_details_desc.large_size";
    public const string ProductPrice = ".inventory_details_price";
    public const string AddButton = "#add-to-cart";
    public const string BackButton = "#back-to-products";

    // Expected Values
    public const string AddButtonText = "Add to cart";
    public const string BackButtonText = "Back to products";
    public static string CartBadgeText(int count) => count.ToString();
}