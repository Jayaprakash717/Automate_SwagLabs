using OpenQA.Selenium;

public class SwagLabsPage
{
    private readonly IWebDriver _driver;

    public SwagLabsPage(IWebDriver driver)
    {
        _driver = driver;
    }

    // Locators
    private IWebElement UsernameField => _driver.FindElement(By.CssSelector("*[data-test=\"username\"]"));
    private IWebElement PasswordField => _driver.FindElement(By.CssSelector("*[data-test=\"password\"]"));
    private IWebElement LoginButton => _driver.FindElement(By.CssSelector("*[data-test=\"login-button\"]"));
    private IWebElement CheckoutButton => _driver.FindElement(By.CssSelector("*[data-test=\"checkout\"]"));
    private IWebElement FirstNameField => _driver.FindElement(By.CssSelector("*[data-test=\"firstName\"]"));
    private IWebElement LastNameField => _driver.FindElement(By.CssSelector("*[data-test=\"lastName\"]"));
    private IWebElement PostalCodeField => _driver.FindElement(By.CssSelector("*[data-test=\"postalCode\"]"));
    private IWebElement ContinueButton => _driver.FindElement(By.CssSelector("*[data-test=\"continue\"]"));
    private IWebElement FinishButton => _driver.FindElement(By.CssSelector("*[data-test=\"finish\"]"));
    private IWebElement MenuButton => _driver.FindElement(By.CssSelector("#react-burger-menu-btn"));
    private IWebElement LogoutLink => _driver.FindElement(By.CssSelector("*[data-test=\"logout-sidebar-link\"]"));

    // Methods for actions
    public void Login(string username, string password)
    {
        UsernameField.SendKeys(username);
        PasswordField.SendKeys(password);
        LoginButton.Click();
    }

    public void AddItemToCart(string item)
    {
        _driver.FindElement(By.CssSelector($"*[data-test=\"add-to-cart-{item}\"]")).Click();
    }

    public void RemoveItemFromCart(string item)
    {
        _driver.FindElement(By.CssSelector($"*[data-test=\"remove-{item}\"]")).Click();
    }

    public void GoToCart()
    {
        _driver.FindElement(By.CssSelector(".shopping_cart_link")).Click();
    }


    public void ProceedToCheckout()
    {
        CheckoutButton.Click();
    }

    public void EnterCheckoutInfo(string firstName, string lastName, string postalCode)
    {
        FirstNameField.SendKeys(firstName);
        LastNameField.SendKeys(lastName);
        PostalCodeField.SendKeys(postalCode);
        ContinueButton.Click();
    }

    public void FinishCheckout()
    {
        FinishButton.Click();
    }

    public void Logout()
    {
        MenuButton.Click();
        Thread.Sleep(TimeSpan.FromSeconds(3));
        LogoutLink.Click();
    }
}
