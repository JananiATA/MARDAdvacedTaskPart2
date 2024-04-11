using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpecFlowProject1.Utilities;

namespace SpecFlowProject1.Pages.Components.HomePageComponents.NavigationMenuComponents
{
    public class ManageListingComponent : CommonDriver
    {
        private IWebElement manageListingTab;
        private IWebElement title;
        private IWebElement description;
        private IWebElement category;
        private IWebElement subCategory;
        private IWebElement tags;
        private IWebElement serviceTypeHourlyBasis;
        private IWebElement serviceTypeOneOff;
        private IWebElement locationTypeOnsite;
        private IWebElement locationTypeOnline;
        private IWebElement startDate;
        private IWebElement endDate;
        private IWebElement skillTradeSkillExchange;
        private IWebElement skillTradeCredit;
        private IWebElement skillExchange;
        private IWebElement credit;
        private IWebElement activeStatus;
        private IWebElement hiddenStatus;
        private IWebElement saveButton;
        private IWebElement messageWindow;
        private IWebElement shareSkillButton;
        private IWebElement expectedCategory;
        private IWebElement expectedTitle;
        private IWebElement expectedDescription;
        private IWebElement editIcon;
        private IWebElement viewIcon;
        private IWebElement skillTitle;
        private IWebElement deleteIcon;
        private IWebElement yesButton;
        private IWebElement toggleIcon;

        public void RenderManageListingTab()
        {
            manageListingTab = driver.FindElement(By.LinkText("Manage Listings"));
        }

        public void ClickManageListings()
        {
            RenderManageListingTab();
            manageListingTab.Click();
        }

        public void RenderShareSkillButton()
        {
            try
            {
                shareSkillButton = driver.FindElement(By.XPath("//*[contains(text(),'Share Skill')]"));
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void RenderShareSkillElements()
        {
            try
            {
                Wait.WaitToBeVisible(driver, "XPath", "//*[@value='Save']", 5);
                title = driver.FindElement(By.Name("title"));
                description = driver.FindElement(By.Name("description"));
                category = driver.FindElement(By.Name("categoryId"));
                tags = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[4]/div[2]/div/div/div/div/input"));
                serviceTypeHourlyBasis = driver.FindElement(By.XPath("//input[@name='serviceType' and @value ='0']"));
                serviceTypeOneOff = driver.FindElement(By.XPath("//input[@name='serviceType' and @value ='1']"));
                locationTypeOnsite = driver.FindElement(By.XPath("//input[@name='locationType' and @value ='0']"));
                locationTypeOnline = driver.FindElement(By.XPath("//input[@name='locationType' and @value ='1']"));
                startDate = driver.FindElement(By.XPath("//*[@placeholder='Start date']"));
                endDate = driver.FindElement(By.XPath("//*[@placeholder='End date']"));
                skillTradeSkillExchange = driver.FindElement(By.XPath("//input[@name='skillTrades' and @value ='true']"));
                skillTradeCredit = driver.FindElement(By.XPath("//input[@name='skillTrades' and @value ='false']"));
                skillExchange = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[8]/div[4]/div/div/div/div/div/input"));
                activeStatus = driver.FindElement(By.XPath("//input[@name='isActive' and @value ='true']"));
                hiddenStatus = driver.FindElement(By.XPath("//input[@name='isActive' and @value ='false']"));
                saveButton = driver.FindElement(By.XPath("//*[@value='Save']"));

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void RenderEditIcon()
        {
            editIcon = driver.FindElement(By.XPath("//*[@id=\"listing-management-section\"]/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[8]/div/button[2]/i"));

        }

        public void ClickEditIcon()
        {
            RenderEditIcon();
            editIcon.Click();
        }

        public void RenderViewIcon()
        {
            viewIcon = driver.FindElement(By.XPath("//*[@id=\"listing-management-section\"]/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[8]/div/button[1]/i"));
        }

        public void ViewListing()
        {
            RenderViewIcon();
            viewIcon.Click();

        }

        public void RenderDeleteIcon()
        {
            deleteIcon = driver.FindElement(By.XPath("//*[@id=\"listing-management-section\"]/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[8]/div/button[3]/i"));
        }

        public void RenderYesButton()
        {
            yesButton = driver.FindElement(By.XPath("//*[@class='ui icon positive right labeled button']"));
        }

        public void DeleteListing()
        {
            RenderDeleteIcon();
            deleteIcon.Click();
            Thread.Sleep(1000);
            RenderYesButton();
            yesButton.Click();
           
        }

        public void RenderSkillTitle()
        {
            skillTitle = driver.FindElement(By.XPath("//*[@class='skill-title']"));
        }
        
        public string SkillTitle()
        {
            RenderSkillTitle();
            return skillTitle.Text;
        }

        public void RenderToggle()
        {
           
            toggleIcon = driver.FindElement(By.XPath("//*[@id=\"listing-management-section\"]/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[7]/div/input"));
                                                        
        }

        public void ClickToggle()
        {
            RenderToggle();
            toggleIcon.Click();
        }

        public void AddListing(string addTitle, string addDesc, string addCategory, string addSubCategory,
            string addTag, string addServiceType, string addLocationType, string addStartDate, string addEndDate, string addSkillTrade,
            string addSkillExchange, string addAmount, string addActiveStatus)
        {
            RenderShareSkillButton();
            shareSkillButton.Click();
            Thread.Sleep(3000);
            RenderShareSkillElements();
            title.SendKeys(addTitle);
            description.SendKeys(addDesc);
            SelectElement newCategory = new SelectElement(category);
            newCategory.SelectByText(addCategory);
            Thread.Sleep(1000);
            subCategory = driver.FindElement(By.Name("subcategoryId"));
            SelectElement newSubCategory = new SelectElement(subCategory);
            newSubCategory.SelectByText(addSubCategory);
            tags.SendKeys(addTag);
            tags.SendKeys(Keys.Enter);


            if (addServiceType == "Hourly basis service")
            {
                serviceTypeHourlyBasis.Click();
            }
            else
            {
                serviceTypeOneOff.Click();
            }

            if (addLocationType == "On-site")
            {
                locationTypeOnsite.Click();
            }
            else
            {
                locationTypeOnline.Click();
            }

            startDate.Clear();
            startDate.SendKeys(addStartDate);
            endDate.SendKeys(addEndDate);
            if (addSkillTrade == "Skill-exchange")
            {
                skillTradeSkillExchange.Click();
                skillExchange.SendKeys(addSkillExchange);
                skillExchange.SendKeys(Keys.Enter);
            }
            else
            {
                skillTradeCredit.Click();
                credit = driver.FindElement(By.XPath("//*[@placeholder='Amount']"));
                credit.SendKeys(addAmount);
            }

            if (addActiveStatus == "Active")
            {
                activeStatus.Click();
            }
            else
            {
                hiddenStatus.Click();
            }
            saveButton.Click();
            Thread.Sleep(1000);


        }

        public void UpdateListing(string editTitle, string editDesc, string editCategory, string editSubCategory,
            string editTag, string editServiceType, string editLocationType, string editStartDate, string editEndDate, string editSkillTrade,
            string editSkillExchange, string editAmount, string editActiveStatus)
        {
            ClickEditIcon();
            RenderShareSkillElements();
            title.Clear();
            title.SendKeys(editTitle);
            description.Clear();
            description.SendKeys(editDesc);
            SelectElement newCategory = new SelectElement(category);
            newCategory.SelectByText(editCategory);
            Thread.Sleep(1000);
            subCategory = driver.FindElement(By.Name("subcategoryId"));
            SelectElement newSubCategory = new SelectElement(subCategory);
            newSubCategory.SelectByText(editSubCategory);
            tags.Clear();
            tags.SendKeys(editTag);
            tags.SendKeys(Keys.Enter);


            if (editServiceType == "Hourly basis service")
            {
                serviceTypeHourlyBasis.Click();
            }
            else
            {
                serviceTypeOneOff.Click();
            }

            if (editLocationType == "On-site")
            {
                locationTypeOnsite.Click();
            }
            else
            {
                locationTypeOnline.Click();
            }

            startDate.Clear();
            startDate.SendKeys(editStartDate);
            endDate.Clear();

            endDate.SendKeys(editEndDate);
            if (editSkillTrade == "Skill-exchange")
            {
                skillTradeSkillExchange.Click();
                skillExchange.SendKeys(editSkillExchange);
                skillExchange.SendKeys(Keys.Enter);
            }
            else
            {
                skillTradeCredit.Click();
                credit = driver.FindElement(By.XPath("//*[@placeholder='Amount']"));
                credit.SendKeys(editAmount);
            }
            

            if (editActiveStatus == "Active")
            {
                activeStatus = driver.FindElement(By.XPath("//input[@name='isActive' and @value ='true']"));
                activeStatus.Click();
            }
            else
            {
                hiddenStatus = driver.FindElement(By.XPath("//input[@name='isActive' and @value ='false']"));
                hiddenStatus.Click();
            }
            saveButton = driver.FindElement(By.XPath("//*[@value='Save']"));
            saveButton.Click();

            Thread.Sleep(1000);

        }

        public string RenderPopUpMessage()
        {

            messageWindow = driver.FindElement(By.XPath("//*[@class='ns-box-inner']"));
            return messageWindow.Text;

        }

        public void RenderManageListingElements()
        {
            try
            {
                Wait.WaitToBeVisible(driver, "Xpath", "//*[@class='ui striped table']//tr[1]//td[2]", 10);
                expectedCategory = driver.FindElement(By.XPath("//*[@class='ui striped table']//tr[1]//td[2]"));
                expectedTitle = driver.FindElement(By.XPath("//*[@class='ui striped table']//tr[1]//td[3]"));
                expectedDescription = driver.FindElement(By.XPath("//*[@class='ui striped table']//tr[1]//td[4]"));

            }

            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public string ListCategory()
        {
            RenderManageListingElements();
            return expectedCategory.Text;
        }
        public string ListTitle()
        {
            RenderManageListingElements();
            return expectedTitle.Text;
        }

        public string ListDescription()
        {
            RenderManageListingElements();
            return expectedDescription.Text;
        }
    }
}

