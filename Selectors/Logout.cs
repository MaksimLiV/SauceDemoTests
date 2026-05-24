namespace SauceDemoTests.Selectors;

public static class BurgerMenuPage
{
    // Selectors
    public const string MenuButton = "#react-burger-menu-btn";
    public const string CloseButton = "#react-burger-cross-btn";
    public const string AllItemsButton = "#inventory_sidebar_link";
    public const string AboutButton = "#about_sidebar_link";
    public const string LogoutButton = "#logout_sidebar_link";
    public const string ResetAppButton = "#reset_sidebar_link";

    // Expected Values
    public const string AllItemsButtonText = "All Items";
    public const string AboutButtonText = "About";
    public const string LogoutButtonText = "Logout";
    public const string ResetAppButtonText = "Reset App State";
}