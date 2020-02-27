using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using Betway.BASE;
using Betway.PAGE;
    

namespace Betway.STEP
{
    [Binding]
    [Scope (Tag = "betwayfavourite")]
    public class BetwayFavouritSteps : Hooks
    {
        public IWebDriver driver;
        public BetwayFavourite browser;

        [Given(@"I navigate to Betway")]
        public void GivenINavigateToBetway() 
        {
            driver = Driver;
            browser = new BetwayFavourite(driver);
            browser.NavigateToBetway();
        }
        
        [Given(@"I loged in to betway")]
        public void GivenILogedInToBetway()
        {
            browser.Login();
            browser.VerifyLogin();
        }
        
        [When(@"I click on favourites")]
        public void WhenIClickOnFavourites()
        {
            browser.ClickFavourites();
        }
        [Then(@"I checked favourites are empty")]
        public void ThenICheckedFavouritesAreEmpty()
        {
            browser.CheckFavEmpty();
        }

        [When(@"I click on home")]
        public void WhenIClickOnHome()
        {
            browser.ClickHome();
        }
        
        [When(@"I add favourites")]
        public void WhenIAddFavourites()
        {
            browser.AddFavourites();
        }    
        
        [Then(@"the game is added to the favourites")]
        public void ThenTheGameIsAddedToTheFavourites()
        {
            browser.GameAdded();
        }

       

    }
}
