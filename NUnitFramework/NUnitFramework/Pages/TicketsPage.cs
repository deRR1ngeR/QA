using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V106.Cast;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitFramework.Pages
{
    public class TicketsPage
    {
        private const string BASE_URL = "https://www.aviasales.by/search/MSQ1001MOW1?request_source=search_form&expected_price_value=108&expected_price_currency=byn&expected_price_source=calendar";
        //test3
        private readonly By CheapestTicket = By.XPath("/html/body/div[5]/div/div/div[3]/div/div/div/div/div/div[2]/div[2]/div[2]/div/div/div[1]/div/div[2]/div/div/button");

        private readonly By SubmitButton = By.XPath("/html/body/div[24]/div/div/div/div/div[2]/div/div/div[1]/div[4]/div/a");

        //test5
        private readonly By _withoutTransferCheckBox = By.XPath("/html/body/div[5]/div/div/div[3]/div/div/div[2]/div/div/div[1]/div[2]/div[1]/div[2]/div[1]/div");
                            
        private readonly By _listOfAlians = By.XPath("/html/body/div[5]/div/div/div[3]/div/div/div[2]/div/div/div[1]/div[2]/div[7]/div[1]/div");

        private readonly By _specificAlians = By.XPath("/html/body/div[5]/div/div/div[3]/div/div/div[2]/div/div/div[1]/div[2]/div[7]/div[2]/div");

        private readonly By _aircompanies = By.XPath("/html/body/div[5]/div/div/div[3]/div/div/div[2]/div/div/div[1]/div[2]/div[6]/div[1]/div");

        private readonly By _withoutLowCosters = By.XPath("/html/body/div[5]/div/div/div[3]/div/div/div[2]/div/div/div[1]/div[2]/div[6]/div[2]/div[1]/div[1]");

        private readonly By _justoneaircompany = By.XPath("/html/body/div[5]/div/div/div[3]/div/div/div[2]/div/div/div[1]/div[2]/div[6]/div[2]/div[2]/div[1]");
        
        //test6 
        private readonly By _followPriceButton = By.XPath("/html/body/div[5]/div/div/div[3]/div/div/div[2]/div/div/div[1]/div[1]/button");
        private readonly By _emailInputField = By.XPath("/html/body/div[24]/div/div/div/div/div/div/form/footer/div/div/div/input");
        private readonly By _emailSubmitButton = By.XPath("/html/body/div[24]/div/div/div/div/div/div/form/footer/button");
        
        private IWebDriver _driver;

        public TicketsPage(IWebDriver driver)
        {
            this._driver = driver;
            PageFactory.InitElements(this._driver, this);
        }
        public void OpenPage()
        {
            _driver.Navigate().GoToUrl(BASE_URL);
        }

        //test3
        public void BuyCheapestTicket()
        {
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            _driver.FindElement(CheapestTicket).Click();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            _driver.FindElement(SubmitButton).Click();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

        }

        //test5
        public void WithoutTransferCheckBoxClick()
        {
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            _driver.FindElement(_withoutTransferCheckBox).Click();
        }
        public void ListOfAliansHasOpen()
        {
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            _driver.FindElement(_listOfAlians).Click();
        }
        public void ChooseTheAlians()
        {
            _driver.FindElement(_specificAlians).Click();
            _driver.FindElement(_listOfAlians).Click();

        }
        public void AircompaniesListHasOpen()
        {
            _driver.FindElement(_aircompanies).Click();

        }
        public void WithoutLowCostersClick()
        {
            _driver.FindElement(_withoutLowCosters).Click();
        }
      

        //test6

        public void FollowPriceButtonClick()
        {
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            _driver.FindElement(_followPriceButton).Click();
        }

        public void InputEmailForFollowPrice()
        {
            _driver.FindElement(_emailInputField).SendKeys("321312@mail.ru");
        }
        public void SumbitButtonClick()
        {
            _driver.FindElement(_emailSubmitButton).Click();
        }
    }
}
