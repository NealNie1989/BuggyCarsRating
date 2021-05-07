using BuggyCarsRating.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace BuggyCarsRating.Steps
{
    [Binding]
    public class VoteACarFunctionSteps
    {
        private IWebDriver driver;
        HomePage homePage;
        PopularModelPage popularModelPage;
        PopularMakePage popularMakePage;
        [BeforeScenario("votetest", "commenttest")]
        public void StartUp()
        {
            driver = new ChromeDriver();
            homePage = new HomePage(driver);
            popularModelPage = new PopularModelPage(driver);
            popularMakePage = new PopularMakePage(driver);
        }

        [AfterScenario("votetest", "commenttest")]
        public void TearDown()
        {
            driver.Quit();
        }

        [Given(@"go to Popular Model Page")]
        public void GivenGoToPopularModelPage()
        {
            homePage.goToHomePage();
             homePage.fillUsername(BaseTest.userName);
              homePage.fillPassword(BaseTest.getPassword());
             homePage.clickLogin();

            Thread.Sleep(2000);
            homePage.goToPopModelPage();

        }
        
        [Given(@"choose Lamborghini Diablo and comments")]
        public void GivenChooseLamborghiniDiabloAndComments()
        {
            Thread.Sleep(2000);
            popularModelPage.comments(BaseTest.getComments);
        }
        
        [When(@"press vote")]
        public void WhenPressVote()
        {
            popularModelPage.vote();
        }
        
        [Then(@"vote successfully should be displayed")]
        public void ThenVoteSuccessfullyShouldBeDisplayed()
        {
            Thread.Sleep(2000);
            Assert.IsTrue(popularModelPage.isVoteSuccessful() is true);
        }
        
        [Then(@"comment message should be display in the table")]
        public void ThenCommentMessageShouldBeDisplayInTheTable()
        {
            Thread.Sleep(2000);
            Assert.IsTrue(popularModelPage.commentsInfo().Contains(BaseTest.getComments));
        }

        [Given(@"choose Lamborghini Diablo")]
        public void GivenChooseLamborghiniDiablo()
        {
            Thread.Sleep(2000);
        }

        [When(@"browse the comments")]
        public void WhenBrowseTheComments()
        {

        }
    }
}
