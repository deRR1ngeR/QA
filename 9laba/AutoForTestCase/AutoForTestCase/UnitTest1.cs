using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace FunctionalTests
{
    public class Tests
    {
        [Test]
        public void ViewScoreboardOfMinskStation()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.aviasales.by/search/MSQ0612MOW1?request_source=best_prices";
            driver.Manage().Window.Maximize();
            driver.FindElement(By.XPath("/html/body/div[5]/div/div/div[3]/div/div/div/div/div/div[2]/div[2]/div[2]/div/div/div[1]/div/div[2]/div/div/button")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.XPath("/html/body/div[23]/div/div/div/div/div[2]/div/div/div[1]/div[4]/div/a")).Click();
            driver.Close();
        }


    }
}