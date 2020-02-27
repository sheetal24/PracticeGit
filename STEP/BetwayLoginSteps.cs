using System;
using TechTalk.SpecFlow;
using Betway.BASE;
using Betway.PAGE;
using Betway.TEST;
using OpenQA.Selenium;

namespace Betway.STEP
{
    [Binding]
    [Scope(Tag = "betwaylogin")]
     
    public class BetwayLoginSteps : Hooks

    {
        public IWebDriver driver;
        public BetwayLogin select;

        [Given(@"I navigate to Betway")]
        public void GivenINavigateToBetway()
        {
            driver = Driver;
            select = new BetwayLogin(driver);
            select.NavigateToBetway();
        }
        
        [When(@"I enter login details")]
        public void WhenIEnterLoginDetails()
        {
            select.Login();
        }
        
        [Then(@"I logged In Betway")]
        public void ThenILoggedInBetway()
        {
            select.VerifyLogin();
        }
    }
}
