using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using FluentAssertions;

namespace Betway.PAGE
{
    public class BetwayLogin
    {
        public IWebDriver Driver;

        public BetwayLogin(IWebDriver driver)
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

        
        

        public string windowsURL = "https://casino.betway.com/lobby/en/#/home";

        public void Login()
        {
           
            UserID.SendKeys("rt_riaz1");
            //Driver.FindElement(By.Id("LoginUsername")).SendKeys("rt_riaz1");
            Task.Delay(3000).Wait();       

            PW.SendKeys("abc123");
           // Driver.FindElement(By.Id("LoginPassword")).SendKeys("abc123");
            Task.Delay(3000).Wait();

            Driver.FindElement(By.Id("login-submit-button-ajax")).Click();
            Task.Delay(3000).Wait();
        }


        public void VerifyLogin()
        {
            Task.Delay(3000).Wait();

            //IWebElement AccountWidget = Driver.FindElement(By.CssSelector(".widget-item.header-account-widget > div.cf > div > h3"));
            //AccountWidget.Displayed.Should().BeTrue();

            Driver.Url.Contains(windowsURL).Should().BeTrue();


        }
    }
}
