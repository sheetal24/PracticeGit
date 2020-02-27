using FluentAssertions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace Betway.PAGE
{
    public class BetwayFavourite
    {
        public IWebDriver Driver;

        public BetwayFavourite(IWebDriver driver)
        {
            Driver = driver;
            PageFactory.InitElements(Driver, this);
        }
        public void NavigateToBetway()
        {
            Driver.Navigate().GoToUrl("https://casino.betway.com/");
        }
        
        [FindsBy(How = How.Id, Using = ("LoginUsername"))]
        public IWebElement UserID;

        [FindsBy(How = How.CssSelector, Using = ("#LoginPassword"))]
        public IWebElement PW;

        [FindsBy(How = How.ClassName, Using = ("no-favourites"))]
        public IWebElement NoFavourite;

        public string NofavouriteString = "Click on the Heart Icons to Add Favourites";

        //this is for practice

        public void Login()
        {

            UserID.SendKeys("rt_riaz1");
            //Driver.FindElement(By.Id("LoginUsername")).SendKeys("rt_riaz1");
            Task.Delay(3000).Wait();


            PW.SendKeys("abc123");
            // Driver.FindElement(By.Id("LoginPassword")).SendKeys("abc123");
            Task.Delay(4000).Wait();

            Driver.FindElement(By.Id("login-submit-button-ajax")).Click();
            Task.Delay(4000).Wait();
        }

        public string windowsURL = "https://casino.betway.com/lobby/en/#/home";

        public void VerifyLogin()
        {
            Task.Delay(2000).Wait();

            //IWebElement AccountWidget = Driver.FindElement(By.CssSelector(".widget-item.header-account-widget > div.cf > div > h3"));
            //AccountWidget.Displayed.Should().BeTrue();

            Driver.Url.Contains(windowsURL).Should().BeTrue();
        }

        [FindsBy(How = How.ClassName, Using = "favourites-icon")]
        public IList<IWebElement> FavouriteIcon;
        public void ClickFavourites()
        {
            Task.Delay(5000).Wait();
            Driver.FindElement(By.XPath("/html[1]/body[1]/div[5]/section[1]/div[1]/header[1]/div[2]/div[1]/span[1]")).Click(); //clickfavourite
            Task.Delay(2000).Wait();
            //FavouriteIcon[0].Click();
            //foreach(var element in FavouriteIcon)
            //{
            //    element.Click();
            //}

        }

        [FindsBy(How = How.XPath, Using = "/html[1]/body[1]/div[5]/section[1]/section[1]/div[1]/div[1]/p[1]/p[1]")]
        public IWebElement emptyfav; //favempty
        [FindsBy(How = How.XPath, Using = "/html[1]/body[1]/div[5]/section[1]/section[1]/div[1]/ul[1]/li[1]/hub-game-launcher[1]/div[1]/button[1]")]
        public IWebElement isActive; //favadded

        public void CheckFavEmpty()
        {
            bool Empty = NoFavourite.Text.Contains(NofavouriteString);
            if (Empty == false)
            {
                foreach (var element in FavouriteIcon)
                {
                    element.Click();
                }
            }
        }
        public void FavEmpty()
        {
            Task.Delay(5000).Wait();
            bool emptyfav = true;
            bool isActive = true;


            if (emptyfav)
            {
                Task.Delay(4000).Wait();
                Driver.FindElement(By.XPath("/html[1]/body[1]/div[5]/section[1]/div[1]/header[1]/div[1]/ul[1]/li[1]/span[1]")).Click();//home
                Task.Delay(4000).Wait();
            }

            else if (isActive)
            {
                Driver.FindElement(By.XPath("/html[1]/body[1]/div[5]/section[1]/section[1]/div[1]/ul[1]/li[1]/hub-game-launcher[1]/div[1]/button[1]")).Click();//clear fav        
                Task.Delay(4000).Wait();
            }

        }



        public void ClickHome()
        {
            Task.Delay(2000).Wait();
            Driver.FindElement(By.XPath("/html[1]/body[1]/div[5]/section[1]/div[1]/header[1]/div[1]/ul[1]/li[1]/span[1]")).Click();
        }


        public void AddFavourites()
        {
            Task.Delay(5000).Wait();
            //Driver.FindElement(By.XPath("//p[@class='text ng-binding'][contains(text(),'0')]")).Click(); 
            Driver.FindElement(By.XPath("/html[1]/body[1]/div[5]/section[1]/section[1]/div[1]/ul[1]/li[1]/hub-game-launcher[1]/div[1]/button[1]")).Click();
        }


        public void GameAdded()
        {
            Task.Delay(2000).Wait();
            Driver.FindElement(By.XPath("//button[@class='favourites-icon active']"));
        }
    }
}


