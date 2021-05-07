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
    public class AddtitionalInfoInProfileSteps
    {
        private IWebDriver driver;
        HomePage homePage;
        ProfilePage profilePage;
        [BeforeScenario("addingInfo")]
        public void StartUp()
        {
            driver = new ChromeDriver();
            homePage = new HomePage(driver);
            profilePage = new ProfilePage(driver);
        }

        [AfterScenario("addingInfo")]
        public void TearDown()
        {
            driver.Quit();
        }


        [Given(@"Login successfully and go to profile page")]
        public void GivenLoginSuccessfullyAndGoToProfilePage()
        {
            homePage.goToHomePage();
            homePage.fillUsername(BaseTest.userName);
            homePage.fillPassword(BaseTest.getPassword());
            homePage.clickLogin();

            Thread.Sleep(2000);
            homePage.clickProfile();

        }
        
        [Given(@"Fill all fields in addtitional info module")]
        public void GivenFillAllFieldsInAddtitionalInfoModule()
        {
            Thread.Sleep(2000);
            profilePage.genderOption("Male");
            Thread.Sleep(2000);
            profilePage.ageFilling("23");
            Thread.Sleep(2000);
            profilePage.addressFilling("One street, NZ");
            Thread.Sleep(2000);
            profilePage.phoneFilling("123456789");
            Thread.Sleep(3000);
            profilePage.selectHobby("Reading");
        }
        
        [When(@"Press the save button")]
        public void WhenPressTheSaveButton()
        {
            profilePage.clickSave();
        }
        
        [Then(@"Save successfully information shoud be displayed")]
        public void ThenSaveSuccessfullyInformationShoudBeDisplayed()
        {
            Thread.Sleep(2000);
            Assert.IsTrue(profilePage.isSaveInfoDisplayed() is true);
        }
    }
}
