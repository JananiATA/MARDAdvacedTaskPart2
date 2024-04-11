using OpenQA.Selenium;
using SpecFlowProject1.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject1.Pages.Components.HomePageComponents
{
    public class SearchSkillComponent : CommonDriver
    {
        private IWebElement searchSkillIcon;
        private IWebElement categoryName;
        private IWebElement subCategoryName;
        private IWebElement messageTextBox;
        private IWebElement requestButton;
        private IWebElement lastPageNumber;
        private IWebElement sharedTitle;
        private IWebElement yesButton;



        public void RenderSearchSkillIcon()
        {
            try
            {

                searchSkillIcon = driver.FindElement(By.XPath("//*[@class='search link icon']"));

            }

            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void SearchByCategory(string category, string subCategory)
        {
            RenderSearchSkillIcon();
            searchSkillIcon.Click();
            Thread.Sleep(2000);
            categoryName = driver.FindElement(By.LinkText(category));
            categoryName.Click();
            Thread.Sleep(2000);
            subCategoryName = driver.FindElement(By.LinkText(subCategory));
            subCategoryName.Click();

        }

        public void RenderLastPageNumber()
        {
            try
            {
                Wait.WaitToBeClickable(driver, "XPath", "//*[@id=\"service-search-section\"]/div[2]/div/section/div/div[2]/div/div[3]/div[2]/div/button[last()-1]", 5);
                lastPageNumber = driver.FindElement(By.XPath("//*[@id=\"service-search-section\"]/div[2]/div/section/div/div[2]/div/div[3]/div[2]/div/button[last()-1]"));
            }

            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public void GoToLastPage()
        {
            RenderLastPageNumber();
            lastPageNumber.Click();
            Thread.Sleep(2000);
        }

        public void RenderSharedTitle()
        {
            try
            {
                Wait.WaitToBeVisible(driver, "XPath", "//*[@id=\"service-search-section\"]/div[2]/div/section/div/div[2]/div/div[2]/div/div/div[last()]/div[1]/a[2]/p", 5);
                sharedTitle = driver.FindElement(By.XPath("//*[@id=\"service-search-section\"]/div[2]/div/section/div/div[2]/div/div[2]/div/div/div[last()]/div[1]/a[2]/p"));

            }

            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public void ClickOnTheSkill()
        {
            RenderSharedTitle();
            sharedTitle.Click();
        }

        public void RenderRequestSkillTradeElements()
        {
            messageTextBox = driver.FindElement(By.XPath("//*[@id=\"service-detail-section\"]/div[2]/div/div[2]/div[2]/div[2]/div/div[2]/div/div[1]/textarea"));
            requestButton = driver.FindElement(By.XPath("//*[@id=\"service-detail-section\"]/div[2]/div/div[2]/div[2]/div[2]/div/div[2]/div/div[3]"));
        }

        public void RenderYesButton()
        {
            yesButton = driver.FindElement(By.XPath("/html/body/div[4]/div/div[3]/button[1]"));
        }
        public void SendRequest(string category, string subCategory, string message)
        {
            SearchByCategory(category,subCategory);
            GoToLastPage();
            ClickOnTheSkill();
            Thread.Sleep(1000);
            RenderRequestSkillTradeElements();
            messageTextBox.SendKeys(message);
            requestButton.Click();
            RenderYesButton();
            yesButton.Click();


        }
    }
}
