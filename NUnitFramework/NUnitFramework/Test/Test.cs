using NUnit.Framework;
using OpenQA.Selenium;

namespace NUnitFramework
{
    [TestFixture]
    public class SmokeTests
    {
        private Steps.Steps steps = new Steps.Steps();
        private const string USERNAME = "testautomationuser";
        private const string PASSWORD = "Time4Death!";
        private const int REPOSITORY_RANDOM_POSTFIX_LENGTH = 6;

        [SetUp]
        public void Init()
        {
            steps.InitBrowser();
        }

      //[TearDown]
      //public void Cleanup()
      //{
      //    steps.CloseBrowser();
      //}

        [Test]
        public void SignNotif()
        {
            steps.SignNotif();
        }

        [Test]
        public void FieldDataAndFindTicket()
        {
            steps.FieldDataAndTicket();
        }

        [Test]
        public void BuyCheapestTicket()
        {
            steps.BuyCheapestTicket();
        }
        [Test]
        public void FindHotelTest()
        {
            steps.FindHotel();
           
        }
        [Test]

        public void TicketPageManipulationTest()
        {
            steps.TicketsPageManipulation();
        }
        [Test]
        public void FollowPriceTest()
        {
            steps.FollowPrice();
        }

        [Test]
        public void SwitchCurrencyTest()
        {
            IWebDriver _driver;
           _driver =  steps.SwitchCurrency();
            Assert.AreEqual("https://www.aviasales.by/?currency=rub&params=MSQ1", _driver.Url);

        }

        [Test]
        public void ComplexRouteBuildingTest()
        {
           IWebDriver _driver = steps.ComplexRouteBuilding();
            Assert.AreEqual("https://www.aviasales.by/search/MSQ3012MOW3112KIV1?request_source=search_form", _driver.Url);
        }
        [Test]
        public void FindPopularDestTest()
        {
          IWebDriver driver =  steps.FindPopularDest();
            Assert.AreEqual("https://www.aviasales.by/map?params=MSQANYWHERE1", driver.Url);
        }

        [Test]
        public void FindTicketOnMapTest()
        {
            IWebDriver driver = steps.FindTicketOnMap();
            Assert.AreEqual("в одну сторону\r\nтуда и обратно", driver.FindElement(By.XPath("/html/body/div[9]/div/div/div/div/div[2]/div/h2/label")).Text);
        }

    }
}
