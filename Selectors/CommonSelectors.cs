namespace SauceDemoTests.Selectors;

public static class CommonSelectors
{
    public const string Title = ".title";
    public const string CartIcon = ".shopping_cart_link";
    public const string CartBadge = ".shopping_cart_badge";
    public const string ItemName = ".inventory_item_name";
    public const string ItemDesc = ".inventory_item_desc";
    public const string ItemPrice = ".inventory_item_price";
    public const string ItemQTY = "[data-test='item-quantity']";
    public const string QTYLabel = ".cart_quantity_label";
    public const string DescLabel = ".cart_desc_label";

    // Buttons
    public const string CancelButton = "#cancel";

    // Expected Values
    public const string QTYLabelText = "QTY";
    public const string DescLabelText = "Description";
    public const string CancelButtonText = "Cancel";
}