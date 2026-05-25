# SauceDemoTests

E2E tests for [saucedemo.com](https://www.saucedemo.com) — automated purchase flow for "Sauce Labs Bolt T-Shirt"

## Tech Stack

- .NET 10
- Playwright for .NET
- NUnit
- GitHub Actions

## Project Structure

```
SauceDemoTests/
├── .github/
│   └── workflows/
│       └── tests.yml         # GitHub Actions CI/CD pipeline
├── Selectors/
│   ├── CommonSelectors.cs    # Shared selectors used across multiple pages
│   ├── LoginPage.cs
│   ├── InventoryPage.cs
│   ├── InventoryItem.cs
│   ├── YourCartPage.cs
│   ├── CheckoutPage.cs
│   ├── CheckoutOverviewPage.cs
│   ├── CheckoutCompletePage.cs
│   └── Logout.cs
├── TestData.cs               # Test data and expected values
├── PurchaseTShirtTests.cs    # Test cases
├── .runsettings              # Local run settings (headed, slowMo)
└── ci.runsettings            # CI run settings (headless)
```

## Prerequisites

- [.NET 10 SDK](https://dotnet.microsoft.com/download)
- [PowerShell](https://github.com/PowerShell/PowerShell) (required for Playwright browser installation)

## Local Setup

**1. Clone the repository:**

```bash
git clone https://github.com/MaksimLiV/SauceDemoTests.git
cd SauceDemoTests
```

**2. Install dependencies:**

```bash
dotnet restore
```

**3. Install Playwright browsers:**

```bash
dotnet build
pwsh bin/Debug/net10.0/playwright.ps1 install
```

**4. Create a `.env` file in the project root:**

```
SECRET_USERNAME=standard_user
SECRET_PASSWORD=secret_sauce
```

> These are publicly available test credentials provided by saucedemo.com.

**5. Run the tests:**

```bash
export $(cat .env | xargs) && dotnet test --settings .runsettings
```

## CI/CD

The pipeline runs automatically on every `push` and `pull_request` to `main`, and can also be triggered manually via GitHub Actions.

Credentials are stored as GitHub Actions secrets:
- `SECRET_USERNAME`
- `SECRET_PASSWORD`

To run the pipeline manually: go to **Actions** → **Run Playwright tests** → **Run workflow**.

After the pipeline completes, the HTML test report is available under **Actions** → select the run → scroll down to **Artifacts** → download `test-report`.
