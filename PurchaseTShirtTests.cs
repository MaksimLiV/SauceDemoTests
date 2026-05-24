using Microsoft.Playwright.NUnit;
using Microsoft.Playwright;
using NUnit.Framework;
using SauceDemoTests.Selectors;

namespace SauceDemoTests;

[TestFixture]
public class PurchaseTShirtTests : PageTest
{
    [SetUp]
    public async Task SetUp()
    {
        await Context.ClearCookiesAsync();
    }

    // TC-01: Purchase "Sauce Labs Bolt T-Shirt" successfully
    [Test]
    public async Task PurchaseBoltTShirt_ShouldCompleteSuccessfully()
    {
        int cartItemCount = 0;

        // Step 1 - Navigate to login page
        await Page.GotoAsync(LoginPage.BaseUrl);

        // Verify login page is displayed
        await Expect(Page.Locator(LoginPage.LoginLogo)).ToBeVisibleAsync();
        await Expect(Page.Locator(LoginPage.LoginLogo)).ToHaveTextAsync(LoginPage.LoginLogoText);
        await Expect(Page.Locator(LoginPage.UsernameInput)).ToBeVisibleAsync();
        await Expect(Page.Locator(LoginPage.PasswordInput)).ToBeVisibleAsync();
        await Expect(Page.Locator(LoginPage.LoginButton)).ToBeVisibleAsync();

        // Step 2 - Enter username
        await Page.FillAsync(LoginPage.UsernameInput, LoginPage.Username);

        // Step 3 - Enter password
        await Page.FillAsync(LoginPage.PasswordInput, LoginPage.Password);

        // Step 4 - Click Login button
        await Page.ClickAsync(LoginPage.LoginButton);

        // Step 5 - Verify Products page is displayed
        await Expect(Page).ToHaveURLAsync(InventoryPage.InventoryPageUrl);
        await Expect(Page.Locator(InventoryPage.ProductsTitle)).ToHaveTextAsync(InventoryPage.ProductsTitleText);
        await Expect(Page.Locator(InventoryPage.ProductsList)).ToBeVisibleAsync();

        // Step 6 - Select "Sauce Labs Bolt T-Shirt"
        await Page.ClickAsync($"text={TestData.ProductName}");

        // Verify product details page is displayed
        await Expect(Page).ToHaveURLAsync(InventoryItem.InventoryItemUrl);
        await Expect(Page.Locator(InventoryItem.CartIcon)).ToBeVisibleAsync();

        await Expect(Page.Locator(InventoryItem.BackButton)).ToBeVisibleAsync();
        await Expect(Page.Locator(InventoryItem.BackButton)).ToHaveTextAsync(InventoryItem.BackButtonText);

        await Expect(Page.Locator(InventoryItem.ProductName)).ToBeVisibleAsync();
        await Expect(Page.Locator(InventoryItem.ProductName)).ToHaveTextAsync(TestData.ProductName);

        await Expect(Page.Locator(InventoryItem.ProductDesc)).ToBeVisibleAsync();
        await Expect(Page.Locator(InventoryItem.ProductDesc)).ToHaveTextAsync(TestData.ProductDesc);

        await Expect(Page.Locator(InventoryItem.ProductPrice)).ToBeVisibleAsync();
        await Expect(Page.Locator(InventoryItem.ProductPrice)).ToHaveTextAsync(TestData.ProductPrice);

        await Expect(Page.Locator(InventoryItem.AddButton)).ToBeVisibleAsync();
        await Expect(Page.Locator(InventoryItem.AddButton)).ToHaveTextAsync(InventoryItem.AddButtonText);

        await Expect(Page.Locator(InventoryItem.AddButton)).ToBeVisibleAsync();
        await Expect(Page.Locator(InventoryItem.AddButton)).ToHaveTextAsync(InventoryItem.AddButtonText);

        // Step 7 - Click "Add to Cart" button
        await Page.ClickAsync(InventoryItem.AddButton);
        cartItemCount++;

        // Step 8 - Verify cart badge shows 1
        await Expect(Page.Locator(InventoryItem.CartBadge)).ToHaveTextAsync(InventoryItem.CartBadgeText(cartItemCount));

        // Step 9 - Navigate to cart
        await Page.ClickAsync(InventoryItem.CartIcon);

                // Step 10 - Verify cart page is displayed
        await Expect(Page).ToHaveURLAsync(YourCartPage.YourCartPageUrl);
        await Expect(Page.Locator(YourCartPage.CartList)).ToBeVisibleAsync();

        await Expect(Page.Locator(YourCartPage.Title)).ToBeVisibleAsync();
        await Expect(Page.Locator(YourCartPage.Title)).ToHaveTextAsync(YourCartPage.TitleText);

        await Expect(Page.Locator(YourCartPage.QTYLabel)).ToBeVisibleAsync();
        await Expect(Page.Locator(YourCartPage.QTYLabel)).ToHaveTextAsync(YourCartPage.QTYText);

        await Expect(Page.Locator(YourCartPage.DescLabel)).ToBeVisibleAsync();
        await Expect(Page.Locator(YourCartPage.DescLabel)).ToHaveTextAsync(YourCartPage.DescLabelText);

        await Expect(Page.Locator(YourCartPage.ItemTitle)).ToBeVisibleAsync();
        await Expect(Page.Locator(YourCartPage.ItemTitle)).ToHaveTextAsync(TestData.ProductName);

        await Expect(Page.Locator(YourCartPage.ItemQTY)).ToBeVisibleAsync();
        await Expect(Page.Locator(YourCartPage.ItemQTY)).ToHaveTextAsync("1");

        await Expect(Page.Locator(YourCartPage.ItemDesc)).ToBeVisibleAsync();
        await Expect(Page.Locator(YourCartPage.ItemDesc)).ToHaveTextAsync(TestData.ProductDesc);

        await Expect(Page.Locator(YourCartPage.ItemPrice)).ToBeVisibleAsync();
        await Expect(Page.Locator(YourCartPage.ItemPrice)).ToHaveTextAsync(TestData.ProductPrice);

        await Expect(Page.Locator(YourCartPage.RemoveButton)).ToBeVisibleAsync();
        await Expect(Page.Locator(YourCartPage.RemoveButton)).ToHaveTextAsync(YourCartPage.RemoveButtonText);

        await Expect(Page.Locator(YourCartPage.ContinueShoppingButton)).ToBeVisibleAsync();
        await Expect(Page.Locator(YourCartPage.ContinueShoppingButton)).ToHaveTextAsync(YourCartPage.ContinueShoppingButtonText);

        await Expect(Page.Locator(YourCartPage.CheckoutButton)).ToBeVisibleAsync();
        await Expect(Page.Locator(YourCartPage.CheckoutButton)).ToHaveTextAsync(YourCartPage.CheckoutButtonText);

                // Step 11 - Click Checkout button
        await Page.ClickAsync(YourCartPage.CheckoutButton);

        // Verify checkout information page is displayed
        await Expect(Page).ToHaveURLAsync(CheckoutPage.CheckoutStepOneUrl);
        await Expect(Page.Locator(CheckoutPage.Title)).ToHaveTextAsync(CheckoutPage.TitleText);
        await Expect(Page.Locator(CheckoutPage.CheckoutContainer)).ToBeVisibleAsync();
        await Expect(Page.Locator(CheckoutPage.FirstNameInput)).ToBeVisibleAsync();
        await Expect(Page.Locator(CheckoutPage.LastNameInput)).ToBeVisibleAsync();
        await Expect(Page.Locator(CheckoutPage.ZipCodeInput)).ToBeVisibleAsync();
        await Expect(Page.Locator(CheckoutPage.ContinueButton)).ToBeVisibleAsync();
        await Expect(Page.Locator(CheckoutPage.ContinueButton)).ToHaveTextAsync(CheckoutPage.ContinueButtonText);
        await Expect(Page.Locator(CheckoutPage.CancelButton)).ToBeVisibleAsync();
        await Expect(Page.Locator(CheckoutPage.CancelButton)).ToHaveTextAsync(CheckoutPage.CancelButtonText);
        await Expect(Page.Locator(InventoryItem.CartBadge)).ToHaveTextAsync(InventoryItem.CartBadgeText(cartItemCount));

        // Step 12 - Enter First Name
        await Page.FillAsync(CheckoutPage.FirstNameInput, TestData.FirstName);

        // Step 13 - Enter Last Name
        await Page.FillAsync(CheckoutPage.LastNameInput, TestData.LastName);

        // Step 14 - Enter Zip/Postal Code
        await Page.FillAsync(CheckoutPage.ZipCodeInput, TestData.ZipCode);

        // Step 15 - Click Continue
        await Page.ClickAsync(CheckoutPage.ContinueButton);

        // Step 16 - Verify order summary page is displayed
        await Expect(Page).ToHaveURLAsync(CheckoutOverviewPage.CheckoutStepTwoUrl);

        await Expect(Page.Locator(CheckoutOverviewPage.Title)).ToBeVisibleAsync();
        await Expect(Page.Locator(CheckoutOverviewPage.Title)).ToHaveTextAsync(CheckoutOverviewPage.TitleText);
        await Expect(Page.Locator(CheckoutOverviewPage.QTYLabel)).ToBeVisibleAsync();
        await Expect(Page.Locator(CheckoutOverviewPage.QTYLabel)).ToHaveTextAsync(CheckoutOverviewPage.QTYLabelText);

        await Expect(Page.Locator(CheckoutOverviewPage.DescLabel)).ToBeVisibleAsync();
        await Expect(Page.Locator(CheckoutOverviewPage.DescLabel)).ToHaveTextAsync(CheckoutOverviewPage.DescLabelText);

        await Expect(Page.Locator(CheckoutOverviewPage.ItemQTY)).ToBeVisibleAsync();
        await Expect(Page.Locator(CheckoutOverviewPage.ItemQTY)).ToHaveTextAsync("1");

        await Expect(Page.Locator(CheckoutOverviewPage.ItemName)).ToBeVisibleAsync();
        await Expect(Page.Locator(CheckoutOverviewPage.ItemName)).ToHaveTextAsync(TestData.ProductName);

        await Expect(Page.Locator(CheckoutOverviewPage.ItemDesc)).ToBeVisibleAsync();
        await Expect(Page.Locator(CheckoutOverviewPage.ItemDesc)).ToHaveTextAsync(TestData.ProductDesc);

        await Expect(Page.Locator(CheckoutOverviewPage.ItemPrice)).ToBeVisibleAsync();
        await Expect(Page.Locator(CheckoutOverviewPage.ItemPrice)).ToHaveTextAsync(TestData.ProductPrice);

        await Expect(Page.Locator(CheckoutOverviewPage.PaymentInfoLabel)).ToBeVisibleAsync();
        await Expect(Page.Locator(CheckoutOverviewPage.PaymentInfoLabel)).ToHaveTextAsync(CheckoutOverviewPage.PaymentInfoLabelText);

        await Expect(Page.Locator(CheckoutOverviewPage.PaymentInfoValue)).ToBeVisibleAsync();
        await Expect(Page.Locator(CheckoutOverviewPage.PaymentInfoValue)).ToHaveTextAsync(CheckoutOverviewPage.PaymentInfoValueText);

        await Expect(Page.Locator(CheckoutOverviewPage.ShippingInfoLabel)).ToBeVisibleAsync();
        await Expect(Page.Locator(CheckoutOverviewPage.ShippingInfoLabel)).ToHaveTextAsync(CheckoutOverviewPage.ShippingInfoLabelText);

        await Expect(Page.Locator(CheckoutOverviewPage.ShippingInfoValue)).ToBeVisibleAsync();
        await Expect(Page.Locator(CheckoutOverviewPage.ShippingInfoValue)).ToHaveTextAsync(CheckoutOverviewPage.ShippingInfoValueText);

        await Expect(Page.Locator(CheckoutOverviewPage.SubtotalLabel)).ToBeVisibleAsync();
        await Expect(Page.Locator(CheckoutOverviewPage.SubtotalLabel)).ToHaveTextAsync(CheckoutOverviewPage.SubtotalLabelText);

        await Expect(Page.Locator(CheckoutOverviewPage.TaxLabel)).ToBeVisibleAsync();
        await Expect(Page.Locator(CheckoutOverviewPage.TaxLabel)).ToHaveTextAsync(CheckoutOverviewPage.TaxLabelText);

        await Expect(Page.Locator(CheckoutOverviewPage.TotalLabel)).ToBeVisibleAsync();
        await Expect(Page.Locator(CheckoutOverviewPage.TotalLabel)).ToHaveTextAsync(CheckoutOverviewPage.TotalLabelText);

        await Expect(Page.Locator(CheckoutOverviewPage.FinishButton)).ToBeVisibleAsync();
        await Expect(Page.Locator(CheckoutOverviewPage.FinishButton)).ToHaveTextAsync(CheckoutOverviewPage.FinishButtonText);

        await Expect(Page.Locator(CheckoutOverviewPage.CancelButton)).ToBeVisibleAsync();
        await Expect(Page.Locator(CheckoutOverviewPage.CancelButton)).ToHaveTextAsync(CheckoutOverviewPage.CancelButtonText);

        // Step 17 - Click Finish
        await Page.ClickAsync(CheckoutOverviewPage.FinishButton);

        // Step 18 - Verify success message
        await Expect(Page).ToHaveURLAsync(CheckoutCompletePage.CheckoutCompleteUrl);
        await Expect(Page.Locator(CheckoutCompletePage.Title)).ToBeVisibleAsync();
        await Expect(Page.Locator(CheckoutCompletePage.Title)).ToHaveTextAsync(CheckoutCompletePage.TitleText);
        await Expect(Page.Locator(CheckoutCompletePage.SuccessMessage)).ToBeVisibleAsync();
        await Expect(Page.Locator(CheckoutCompletePage.SuccessMessage)).ToHaveTextAsync(CheckoutCompletePage.SuccessMessageText);
        await Expect(Page.Locator(CheckoutCompletePage.SuccessSubMessage)).ToBeVisibleAsync();
        await Expect(Page.Locator(CheckoutCompletePage.SuccessSubMessage)).ToHaveTextAsync(CheckoutCompletePage.SuccessSubMessagText);
        await Expect(Page.Locator(CheckoutCompletePage.BackHomeButton)).ToBeVisibleAsync();
        await Expect(Page.Locator(CheckoutCompletePage.BackHomeButton)).ToHaveTextAsync(CheckoutCompletePage.BackHomeButtonText);

        // Step 19 - Verify cart badge disappears after purchase
        await Expect(Page.Locator(InventoryItem.CartBadge)).ToHaveCountAsync(0);

        // Step 20 - Open burger menu
        await Page.ClickAsync("#react-burger-menu-btn");
        await Expect(Page.Locator("#logout_sidebar_link")).ToBeVisibleAsync();

        // Step 21 - Click Logout
        await Page.ClickAsync("#logout_sidebar_link");

        // Verify redirected back to login page
        await Expect(Page).ToHaveURLAsync(LoginPage.BaseUrl);
        await Expect(Page.Locator(LoginPage.LoginLogo)).ToBeVisibleAsync();
    }
}