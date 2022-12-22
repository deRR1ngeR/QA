using OpenQA.Selenium;

namespace NUnitFramework.Steps
{
    public class Steps
    {
        IWebDriver driver;


        public void InitBrowser()
        {
            driver = Driver.DriverInstance.GetInstance();
        }


        public void CloseBrowser()
        {
            Driver.DriverInstance.CloseBrowser();
        }

        public void SignNotif()
        {
            Pages.MainPage mainPage = new Pages.MainPage(driver);
            mainPage.OpenPage();
            mainPage.SignNotification();
        }

        public void FieldDataAndTicket()
        {
            Pages.MainPage mainPage = new Pages.MainPage(driver);
            mainPage.OpenPage();
            mainPage.InputFieldData();
            mainPage.DataIcon();
            mainPage.TakeDate();
            mainPage.FindTicket();
        }

        public void BuyCheapestTicket()
        {
            Pages.TicketsPage ticketPage = new Pages.TicketsPage(driver);
            ticketPage.OpenPage();
            ticketPage.BuyCheapestTicket();
        }

        public void FindHotel()
        {
            Pages.MainPage mainPage = new Pages.MainPage(driver);
            mainPage.OpenPage();
            mainPage.SwitchToHotelClick();
            mainPage.InputHotelField();
            mainPage.HotelDataIconClick();
            mainPage.TakeHotelDate();
            mainPage.FindHotel();
        }

        public void TicketsPageManipulation()
        {
            Pages.TicketsPage ticketsPage = new Pages.TicketsPage(driver);
            ticketsPage.OpenPage();
            ticketsPage.WithoutTransferCheckBoxClick();
            ticketsPage.ListOfAliansHasOpen();
            ticketsPage.ChooseTheAlians();
            ticketsPage.AircompaniesListHasOpen();
            ticketsPage.WithoutLowCostersClick();
           
        }

        public void FollowPrice()
        {
            Pages.TicketsPage ticketsPage = new Pages.TicketsPage(driver);
            ticketsPage.OpenPage();
            ticketsPage.FollowPriceButtonClick();
            ticketsPage.InputEmailForFollowPrice();
            ticketsPage.SumbitButtonClick();
        }

        public IWebDriver SwitchCurrency()
        {
            IWebDriver _driver;
            Pages.MainPage mainPage = new Pages.MainPage(driver);
            mainPage.OpenPage();
            mainPage.CurrencyButtonClick();
           _driver =  mainPage.SwitchCurrencyToRuble();
           return _driver;
        }

        public IWebDriver ComplexRouteBuilding()
        {
            Pages.MainPage mainPage = new Pages.MainPage(driver);
            mainPage.OpenPage();
            mainPage.DifficultRouteClick();
            mainPage.FirstDifficultRouteDataIconClick();
            mainPage.FirstDifficultRouteDateTaken();
            mainPage.SecondDifficultRouteDataIconClick();
            mainPage.SecondDifficultRouteDateTaken();
            mainPage.InputFirstFieldTo();
            mainPage.InputSecondFieldFrom();
            mainPage.InputSecondFieldTo();
            return mainPage.FindComplexRoute();
        }

        public IWebDriver FindPopularDest()
        {
            Pages.MainPage mainPage = new Pages.MainPage(driver);
            mainPage.OpenPage();
          return  mainPage.FindPopularDestination();
        }

        public IWebDriver FindTicketOnMap()
        {
            Pages.MapPage mapPage = new Pages.MapPage(driver);
            mapPage.OpenPage();
            return mapPage.FindTicketOnTheMap();
        }
    }
}
