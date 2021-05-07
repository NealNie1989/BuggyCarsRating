using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuggyCarsRating.Pages
{
    class PopularMakePage
    {
        private IWebDriver driver;

        [FindsBy(How = How.XPath, Using = ".//table[@class='cars table table-hover']/tbody/tr[1]/td[2]/a")]
        private IWebElement diabloModel;

        public PopularMakePage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public void gotoDiablo()
        {
            diabloModel.Click();
        }

    }
}
