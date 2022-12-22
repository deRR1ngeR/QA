using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitFramework.Pages
{

    public class MapPage
    {
        private IWebDriver _driver;

        private const string BASE_URL = "https://www.aviasales.by/map";
        public MapPage(IWebDriver driver)
        {
            this._driver = driver;
            PageFactory.InitElements(this._driver, this);
        }


        //test10
        private readonly By _NoCorontineButton = By.XPath("/html/body/div[6]/div/div[22]/div/div/div[2]/div[1]/button[2]/div");
        private readonly By _NoTransfersButton = By.XPath("/html/body/div[6]/div/div[22]/div/div/div[2]/div[1]/button[3]/div");
        private readonly By _georgyaButton = By.XPath("/html/body/div[6]/div/div[22]/div/div/div[1]/div/ul/li[2]/button");
        private readonly By _BatumiButton = By.XPath("/html/body/div[6]/div/div[22]/div/div/div[1]/div/ul/li[2]/button");
        private readonly By _GraphOfThePricecButton = By.XPath("/html/body/div[6]/div/div[5]/div/section/div/ul/li[1]/div/button");


        public void OpenPage()
        {
            _driver.Navigate().GoToUrl(BASE_URL);
        }
        public IWebDriver FindTicketOnTheMap()
        {

            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            _driver.FindElement(_NoCorontineButton).Click();
            _driver.FindElement(_NoTransfersButton).Click();
            _driver.FindElement(_georgyaButton).Click();
            _driver.FindElement(_BatumiButton).Click();
            _driver.FindElement(_GraphOfThePricecButton).Click();
            return _driver;
        }
    }

  
}
