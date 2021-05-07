using BuggyCarsRating.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace BuggyCarsRating.Steps
{
    [Binding]
    public class RegisterUserAccountAndLogInSteps
    {

        private IWebDriver driver;
        HomePage homePage;
        RegisterPage registerPage;
        [BeforeScenario("registerTests", "loginTests")]
        public void StartUp()
        {
            driver = new ChromeDriver();
            homePage = new HomePage(driver);
            registerPage = new RegisterPage(driver);
        }

        [AfterScenario("registerTests", "loginTests")]
        public void TearDown()
        {
            driver.Quit();
        }

        [Given(@"Fill effective username")]
        public void GivenFillEffectiveUsername()
        {
            homePage.goToHomePage();
            homePage.goToRegisterPage();
            registerPage.filluserName(BaseTest.userName);
            registerPage.fillfirstName(BaseTest.getFirstName());
            registerPage.filllastName(BaseTest.getLastName());
        }
        
        [Given(@"Fill effective password")]
        public void GivenFillEffectivePassword()
        {
            registerPage.fillPassword(BaseTest.getPassword());
            registerPage.fillConfirmPassword(BaseTest.getPassword());
        }
        
        [Given(@"Fill fatal username")]
        public void GivenFillFatalUsername()
        {
            homePage.goToHomePage();
            homePage.goToRegisterPage();
            registerPage.filluserName(BaseTest.getUserName());
            registerPage.fillfirstName(BaseTest.getFirstName());
            registerPage.filllastName(BaseTest.getLastName());
        }
        
        [Given(@"Fill fatal password")]
        public void GivenFillFatalPassword()
        {
            registerPage.fillPassword(BaseTest.getFatalPassword());
            registerPage.fillConfirmPassword(BaseTest.getFatalPassword());
        }
        
        [Given(@"Fill effective registered username")]
        public void GivenFillEffectiveRegisteredUsername()
        {
            homePage.goToHomePage();
            homePage.fillUsername(BaseTest.userName);
        }
        
        [Given(@"Fill effective registered passwork")]
        public void GivenFillEffectiveRegisteredPasswork()
        {
            homePage.fillPassword(BaseTest.getPassword());
        }
        
        [When(@"press register button")]
        public void WhenPressRegisterButton()
        {
            registerPage.clickRegisterButton();
        }
        
        [When(@"press login button")]
        public void WhenPressLoginButton()
        {
            homePage.clickLogin();
        }
        
        [Then(@"register successfully information should be displayed")]
        public void ThenRegisterSuccessfullyInformationShouldBeDisplayed()
        {
            Thread.Sleep(2000);
            Assert.IsTrue(registerPage.successInfoDisplayed() is true);
        }
        
        [Then(@"register unsuccessfully information should be displayed")]
        public void ThenRegisterUnsuccessfullyInformationShouldBeDisplayed()
        {
            Thread.Sleep(2000);
            Assert.IsTrue(registerPage.errorInfoDisplayed() is true);
        }
        
        [Then(@"username  should be displayed on the system")]
        public void ThenUsernameShouldBeDisplayedOnTheSystem()
        {
            Thread.Sleep(2000);
            Assert.IsTrue(homePage.LoginSuccess() is true);
        }
    }
}
