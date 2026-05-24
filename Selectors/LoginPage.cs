namespace SauceDemoTests.Selectors;

public static class LoginPage
{

    //Url 
    public const string BaseUrl = "https://www.saucedemo.com/";

    // Selectors
    public const string LoginLogo = ".login_logo";
    public const string UsernameInput = "#user-name";
    public const string PasswordInput = "#password";
    public const string LoginButton = "#login-button";

    // Test Data

    public const string Username = "standard_user";
    public const string Password = "secret_sauce";

    // Expected Values
    public const string LoginLogoText = "Swag Labs";
}