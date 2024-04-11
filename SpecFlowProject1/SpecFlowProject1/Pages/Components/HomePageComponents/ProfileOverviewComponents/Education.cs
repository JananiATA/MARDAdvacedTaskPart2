using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SpecFlowProject1.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject1.Pages.Components.HomePageComponents.ProfileOverviewComponents
{
    public class Education : CommonDriver
    {
        private IWebElement collegeName;
        private IWebElement countryNameDropdown;
        private IWebElement titleDropdown;
        private IWebElement degree;
        private IWebElement yearDropdown;
        private IWebElement educationTab;
        private IWebElement addNewButton;
        private IWebElement addButton;
        private IWebElement popUpMessage;
        private IWebElement closePopUpMessage;
        private IWebElement deleteIcon;

        public void RenderEducationTab()
        {
            educationTab = driver.FindElement(By.XPath("//*[@class='item' and text()='Education']"));
        }

        public void GoToEducationTab()
        {
            RenderEducationTab();
            educationTab.Click();
        }

        public void RenderDeleteIcon()
        {
            deleteIcon = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[6]/span[2]/i"));
        }
        public void RenderAddNewButton()
        {
            addNewButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/thead/tr/th[6]/div"));
        }

        public void RenderEducationComponents()
        {
            collegeName = driver.FindElement(By.Name("instituteName"));
            countryNameDropdown = driver.FindElement(By.Name("country"));
            titleDropdown = driver.FindElement(By.Name("title"));
            degree = driver.FindElement(By.Name("degree"));
            yearDropdown = driver.FindElement(By.Name("yearOfGraduation"));
        }
        public void RenderAddButton()
        {
            addButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[3]/div/input[1]"));
        }

        public void AddEducation(string college, string countryName, string titleName, string degreeName, string year)
        {
            RenderAddNewButton();
            addNewButton.Click();
            RenderEducationComponents();
            collegeName.SendKeys(college);
            SelectElement country = new SelectElement(countryNameDropdown);
            country.SelectByValue(countryName);
            SelectElement title = new SelectElement(titleDropdown);
            title.SelectByValue(titleName);
            degree.SendKeys(degreeName);
            SelectElement graduationYear = new SelectElement(yearDropdown);
            graduationYear.SelectByValue(year);
            RenderAddButton();
            addButton.Click();
            

        }

        public void DeleteEducation()
        {
            RenderDeleteIcon();
            deleteIcon.Click();
            Thread.Sleep(1000);
        }

        public void RenderPopUpMessage()
        {
            popUpMessage = driver.FindElement(By.XPath("//*[@class='ns-box-inner']"));
        }
        public string PopUpMessage()
        {
            RenderPopUpMessage();
            return popUpMessage.Text;
        }

        public void RenderClosePopUp()
        {
            
            closePopUpMessage = driver.FindElement(By.XPath("//*[@class='ns-close']"));
        }
        public void ResetEducationTable()
        {
            int rowCount = driver.FindElements(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr")).Count;

            if (rowCount > 0)
            {
                for (int i = 0; i < rowCount; i++)
                {
                    driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td[6]/span[2]/i")).Click();

                    Thread.Sleep(1000);
                }
            }

          

        }

        public void ClosePopUP()
        {
            RenderClosePopUp();
            closePopUpMessage.Click();
        }


    }
}
