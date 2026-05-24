namespace SauceDemoTests.Selectors;

public static class CheckoutOverviewPage
{
    // URL
    public const string CheckoutStepTwoUrl = "https://www.saucedemo.com/checkout-step-two.html";

    // Selectors
    public const string Title = ".title";// 
    public const string QTYLabel = ".cart_quantity_label"; // 
    public const string DescLabel = ".cart_desc_label"; //
    public const string ItemName = ".inventory_item_name"; // 
    public const string ItemDesc = ".inventory_item_desc"; // 
    public const string ItemPrice = ".inventory_item_price"; //
    public const string ItemQTY = "[data-test='item-quantity']"; // 
    public const string PaymentInfoLabel = "[data-test='payment-info-label']";
    public const string PaymentInfoValue = "[data-test='payment-info-value']";
    public const string ShippingInfoLabel = "[data-test='shipping-info-label']";
    public const string ShippingInfoValue = "[data-test='shipping-info-value']";
    public const string SubtotalLabel = "[data-test='subtotal-label']";
    public const string TaxLabel = "[data-test='tax-label']";
    public const string TotalLabel = "[data-test='total-label']";
    public const string FinishButton = "#finish";
    public const string CancelButton = "#cancel";

    // Expected Values
    public const string TitleText = "Checkout: Overview";
    public const string QTYLabelText = "QTY";
    public const string DescLabelText = "Description";
    public const string PaymentInfoLabelText = "Payment Information:";
    public const string PaymentInfoValueText = "SauceCard #31337";
    public const string ShippingInfoLabelText = "Shipping Information:";
    public const string ShippingInfoValueText = "Free Pony Express Delivery!";
    public const string SubtotalLabelText = "Item total: $15.99";
    public const string TaxLabelText = "Tax: $1.28";
    public const string TotalLabelText = "Total: $17.27";
    public const string FinishButtonText = "Finish";
    public const string CancelButtonText = "Cancel";
}