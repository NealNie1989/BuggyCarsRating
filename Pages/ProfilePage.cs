using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuggyCarsRating.Pages
{
    class ProfilePage
    {
        private IWebDriver driver;

        [FindsBy(How = How.CssSelector, Using = "[id$='gender']")]
        private IWebElement gender;

        [FindsBy(How = How.CssSelector, Using = "[id$='age']")]
        private IWebElement age;

        [FindsBy(How = How.CssSelector, Using = "[id$='address']")]
        private IWebElement address;

        [FindsBy(How = How.CssSelector, Using = "[id$='phone']")]
        private IWebElement phone;

        [FindsBy(How = How.CssSelector, Using = "[id$='hobby']")]
        private IWebElement hobby;

        public SelectElement hobbyDropDown
        {
            get { return new SelectElement(hobby);}
        }

        [FindsBy(How = How.CssSelector, Using = "[type='submit']")]
        private IWebElement saveBtn;

        [FindsBy(How = How.CssSelector, Using = "[class='result alert alert-success hidden-md-down']")]
        private IWebElement saveSuccessInfo;
        public ProfilePage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public void selectHobby(string selectOpt)
        {
            hobbyDropDown.SelectByText(selectOpt);
        }

        public void genderOption(string genderOpt)
        {
            gender.SendKeys(genderOpt);
        }

        public void ageFilling(string ageOpt)
        {
            age.SendKeys(ageOpt);
        }

        public void addressFilling(string addressOpt)
        {
            address.SendKeys(addressOpt);
        }

        public void phoneFilling(string phonesOpt)
        {
            phone.SendKeys(phonesOpt);
        }

        public void clickSave()
        {
            saveBtn.Click();
        }

        public Boolean isSaveInfoDisplayed()
        {
            return saveSuccessInfo.Displayed;
        }


    }
}
