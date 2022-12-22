using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;
 using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.DevTools.V106.Network;

namespace NUnitFramework.Pages
{
public class MainPage
{
    private const string BASE_URL = "https://www.aviasales.by/";

    private IWebDriver _driver;
    //test1
    private readonly By InputEmail = By.XPath("/html/body/div[8]/div[2]/div/form/div[2]/div/div[1]/div/div/input");
      
    //test2
    private readonly By inputField = By.XPath("/html/body/div[5]/div/div/div[3]/div/div[1]/div[3]/div/div/form/div[2]/div/div/input");
    private readonly By dataIcon = By.XPath("/html/body/div[5]/div/div/div[3]/div/div[1]/div[3]/div/div/form/div[3]/div/div[1]/div");
    private readonly By secondIcon = By.XPath("/html/body/div[5]/div/div/div[2]/div/div/div[2]/div/div/form/div[3]/div/div[1]/div");
    private readonly By chooseDate = By.XPath("/html/body/div[5]/div/div/div[2]/div/div/div[2]/div/div/form/div[3]/div/div[3]/div/div/div[2]/div[2]/div/div/div/div[2]/div[2]/div[3]/div[4]/div[3]/div/div[1]");
    private readonly By findTicket = By.XPath("/html/body/div[5]/div/div/div[2]/div/div/div[2]/div/div/form/div[5]/button");
      
      
    //test4
    private readonly By SwitchToHotelButton = By.XPath("/html/body/div[5]/div/div/div[3]/div/div[1]/div[2]/ul/li[2]/a/div");
    private readonly By HotelOrTownInputField = By.XPath("/html/body/div[5]/div/div/div[3]/div/div[1]/div[3]/div/div/form/div[1]/div/div/input");
    private readonly By HotelDataIcon = By.XPath("/html/body/div[5]/div/div/div[3]/div/div[1]/div[3]/div/div/form/div[2]/div/div[1]/div");
    private readonly By chooseHotelDate = By.XPath("/html/body/div[5]/div/div/div[3]/div/div[1]/div[3]/div/div/form/div[2]/div/div[3]/div/div/div[2]/div[2]/div/div/div/div[2]/div[2]/div[3]/div[3]/div[3]/div");
    private readonly By secondHotelDataIcon = By.XPath("/html/body/div[5]/div/div/div[3]/div/div[1]/div[3]/div/div/form/div[2]/div/div[2]/div");
        private readonly By secondChooseHotelDate = By.XPath("/html/body/div[5]/div/div/div[3]/div/div[1]/div[3]/div/div/form/div[2]/div/div[3]/div/div/div[2]/div[2]/div/div/div/div[2]/div[1]/div[3]/div[4]/div[6]/div");
    private readonly By findHotel = By.XPath("/html/body/div[5]/div/div/div[3]/div/div[1]/div[3]/div/div/form/div[4]/button");

        //test7
        private readonly By _currencyButton = By.XPath("/html/body/div[2]/div/div/div[2]/div[3]/div/button");
        private readonly By _switchCurrencyToRuble = By.XPath("/html/body/div[2]/div/div/div[2]/div[3]/div/div/div[1]/div/div/div[2]/div/ul/li[4]");

        //test8
        private readonly By _difficultRoute = By.XPath("/html/body/div[5]/div/div/div[3]/div/div[1]/div[3]/div/div/form/div[6]/a");
        private readonly By _firstInputFieldTo = By.XPath("/html/body/div[5]/div/div/div[3]/div/div[1]/div[3]/div/div/form/div[1]/div[2]/div/div/input");
        private readonly By _secondInputFieldTo = By.XPath("/html/body/div[5]/div/div/div[3]/div/div[1]/div[3]/div/div/form/div[2]/div[2]/div/div/input");
        private readonly By _secondInputFieldFrom = By.XPath("/html/body/div[5]/div/div/div[3]/div/div[1]/div[3]/div/div/form/div[2]/div[1]/div/div/input");
        private readonly By _firstDifficultRouteDataIcon = By.XPath("/html/body/div[5]/div/div/div[3]/div/div[1]/div[3]/div/div/form/div[1]/div[3]/div/div[1]/div");
        private readonly By _firstDifficultRouteDate= By.XPath("/html/body/div[5]/div/div/div[3]/div/div[1]/div[3]/div/div/form/div[1]/div[3]/div/div[2]/div/div/div/div/div/div/div/div[2]/div/div[3]/div[5]/div[5]/div/div");
        private readonly By _secondDifficultRouteDataIcon = By.XPath("/html/body/div[5]/div/div/div[3]/div/div[1]/div[3]/div/div/form/div[2]/div[3]/div/div[1]/div");
        private readonly By _secondDifficultRouteDate = By.XPath("/html/body/div[5]/div/div/div[3]/div/div[1]/div[3]/div/div/form/div[2]/div[3]/div/div[2]/div/div/div/div/div/div/div/div[2]/div/div[3]/div[5]/div[6]/div/div");
        private readonly By _findDifficultRouteButton = By.XPath("/html/body/div[5]/div/div/div[3]/div/div[1]/div[3]/div/div/form/div[3]/button");

        //test9
        private readonly By _menuButton = By.XPath("/html/body/div[2]/div/div/div[2]/div[4]/div/button");
        private readonly By _darkThemButton = By.XPath("/html/body/div[2]/div/div/div[2]/div[4]/div/div/div[1]/div/nav/ul/li[1]/label/div[2]");
        private readonly By _WhereWeCanGoButton = By.XPath("/html/body/div[2]/div/div/div[2]/div[4]/div/div/div[1]/div/nav/ul/li[2]/a/div[2]");

        public MainPage(IWebDriver driver)
    {
        this._driver = driver;
        PageFactory.InitElements(this._driver, this);
    }

    public void OpenPage()
    {
        _driver.Navigate().GoToUrl(BASE_URL);
    }

    public void SignNotification()
    {
        _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        _driver.FindElement(InputEmail).SendKeys("123@mail.ru");
        _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
    }

    public void InputFieldData()
    {
        _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

        _driver.FindElement(inputField).SendKeys("Москва");

    }

    public void DataIcon()
    {
        _driver.FindElement(dataIcon).Click();
        _driver.FindElement(secondIcon).Click();

    }

    public void TakeDate()
    {
        _driver.FindElement(chooseDate).Click();
    }
    public void FindTicket()
    {
        _driver.FindElement(findTicket).Click();
    }

    public void SwitchToHotelClick()
    {
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            _driver.FindElement(SwitchToHotelButton).Click();
    }
        public void InputHotelField()
        {
            _driver.FindElement(HotelOrTownInputField).SendKeys("Минск");

        }
        public void HotelDataIconClick()
        {
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            _driver.FindElement(HotelDataIcon).Click();
        }
        public void TakeHotelDate()
        {
            _driver.FindElement(chooseHotelDate).Click();
            _driver.FindElement(secondHotelDataIcon).Click();
            _driver.FindElement(secondChooseHotelDate).Click();
        }
        public void FindHotel()
        {
            _driver.FindElement(findHotel).Click();
        }
        public void CurrencyButtonClick()
        {
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            _driver.FindElement(_currencyButton).Click();
        }
        public IWebDriver SwitchCurrencyToRuble()
        {
            _driver.FindElement(_switchCurrencyToRuble).Click();
            return _driver;
        }


        //test8
        public void DifficultRouteClick()
        {
            _driver.Manage().Timeouts().ImplicitWait.Add(TimeSpan.FromSeconds(15));

            _driver.FindElement(_difficultRoute).Click();
        }
        public void InputFirstFieldTo()
        {
            _driver.Manage().Timeouts().ImplicitWait.Add(TimeSpan.FromSeconds(5));

            _driver.FindElement(_firstInputFieldTo).SendKeys("Москва");
        }
        public void InputSecondFieldFrom()
        {
            
            _driver.FindElement(_secondInputFieldFrom).SendKeys("Москва");

        }
        public void InputSecondFieldTo()
        {
            _driver.FindElement(_secondInputFieldTo).SendKeys("Кишинёв");
            _driver.FindElement(_secondInputFieldTo).Click();
        }
        public void FirstDifficultRouteDataIconClick()
        {
            _driver.FindElement(_firstDifficultRouteDataIcon).Click();
        }
        public void FirstDifficultRouteDateTaken()
        {
            _driver.FindElement(_firstDifficultRouteDate).Click();
        }
        public void SecondDifficultRouteDataIconClick()
        {
            _driver.FindElement(_secondDifficultRouteDataIcon).Click();
        }
        public void SecondDifficultRouteDateTaken()
        {
            _driver.FindElement(_secondDifficultRouteDate).Click();
        }
        public IWebDriver FindComplexRoute()
        {
            _driver.FindElement(_findDifficultRouteButton).Click();
            return _driver;

        }
        //test9
        public IWebDriver FindPopularDestination() { 
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            _driver.FindElement(_menuButton).Click();
            _driver.FindElement(_darkThemButton).Click();
            _driver.FindElement(_WhereWeCanGoButton).Click();
            return _driver;
        }
    }
}
