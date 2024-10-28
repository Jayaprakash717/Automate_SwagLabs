using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Text.Json;

namespace AutomationProject
{
    [TestFixture]
    public class SwagLabsTest
    {
        private ChromeDriver driver;
        private SwagLabsPage swagLabsPage;

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            swagLabsPage = new SwagLabsPage(driver);
        }

        [TearDown]
        public void TearDown()
        {
            // Use Dispose to ensure proper cleanup
            if (driver != null)
            {
                driver.Dispose();  // Dispose of the ChromeDriver instance
            }
        }


        // Test method accepts input details as parameters
        [Test]
        [TestCase("standard_user", "secret_sauce", new[] { "sauce-labs-backpack", "sauce-labs-bike-light" }, new[] { "sauce-labs-backpack" }, "user", "lastname", "55555")]
        public void SwagLabsTestScenario(string username, string password, string[] itemsToAdd, string[] itemsToRemove, string firstName, string lastName, string postalCode)
        {
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");
            driver.Manage().Window.Maximize();

            // Perform login
            swagLabsPage.Login(username, password);

            // Add items to cart
            foreach (var item in itemsToAdd)
            {
                swagLabsPage.AddItemToCart(item);
            }

            // Remove items from cart
            foreach (var item in itemsToRemove)
            {
                swagLabsPage.RemoveItemFromCart(item);
            }

            // Checkout process
            swagLabsPage.GoToCart();
            swagLabsPage.ProceedToCheckout();
            swagLabsPage.EnterCheckoutInfo(firstName, lastName, postalCode);
            swagLabsPage.FinishCheckout();

            // Logout
            swagLabsPage.Logout();
        }
    }
}
