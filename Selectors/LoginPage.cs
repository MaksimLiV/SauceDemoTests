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

    public static readonly string Username = Environment.GetEnvironmentVariable("SECRET_USERNAME")
        ?? throw new InvalidOperationException("SECRET_USERNAME environment variable is not set");
    public static readonly string Password = Environment.GetEnvironmentVariable("SECRET_PASSWORD")
        ?? throw new InvalidOperationException("SECRET_PASSWORD environment variable is not set");

    // Expected Values
    public const string LoginLogoText = "Swag Labs";
}