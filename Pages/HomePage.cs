using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuggyCarsRating.Pages
{
    class HomePage
    {
        private IWebDriver driver;
        static String url = "https://buggy.justtestit.org";

        [FindsBy(How = How.XPath, Using = ".//a[text()='Buggy Rating']")]
        private IWebElement buggyRatingBtm;

        [FindsBy(How = How.CssSelector, Using = "[name='login']")]
        private IWebElement loginField;

        [FindsBy(How = How.CssSelector, Using = "[name='password']")]
        private IWebElement passwordField;

        [FindsBy(How = How.CssSelector, Using = "[class='btn btn-success-outline']")]
        private IWebElement registerBtm;

        [FindsBy(How = How.CssSelector, Using = "[class='btn btn-success']")]
        private IWebElement loginBtm;

        [FindsBy(How = How.XPath, Using = ".//h2[text()='Popular Make']/following-sibling::a/img")]
        private IWebElement popularMake;

        [FindsBy(How = How.XPath, Using = ".//h2[text()='Popular Model']/following-sibling::a/img")]
        private IWebElement popularModel;

        [FindsBy(How = How.XPath, Using = ".//h2[text()='Overall Rating']/following-sibling::a/img")]
        private IWebElement overallRating;

        [FindsBy(How = How.CssSelector, Using = "[class='nav-link disabled']")]
        private IWebElement nameTag;

        [FindsBy(How = How.XPath, Using = ".//a[text()='Profile']")]
        private IWebElement profileBtn;

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public void goToHomePage()
        {
            driver.Navigate().GoToUrl(url);
        }

        public void goToRegisterPage()
        {
            registerBtm.Click();
        }

        public void goToPopModelPage()
        {
            popularModel.Click();
        }

        public void goToPopMakePage()
        {
            popularMake.Click();
        }
        public void fillUsername(String username)
        {
            loginField.SendKeys(username);
        }

        public void fillPassword(String password)
        {
            passwordField.SendKeys(password);
        }

        public void clickLogin()
        {
            loginBtm.Click();
        }

        public Boolean LoginSuccess()
        {
            return nameTag.Displayed;
        }

        public void clickProfile()
        {
            profileBtn.Click();
        }

    }
}
