using OpenQA.Selenium;
using SpecFlowProject1.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject1.Pages.Components.HomePageComponents.AccountMenuComponents.UserDetailsComponent
{
    public class ChangePassword : CommonDriver
    {
        private IWebElement userNameLabel;
        private IWebElement changePasswordLink;
        private IWebElement currentPasswordTextBox;
        private IWebElement newPasswordTextBox;
        private IWebElement confirmPasswordTextBox;
        private IWebElement saveButton;
        private IWebElement popUpMessage;

        public void RenderUserName()
        {
            try
            {
                Wait.WaitToBeVisible(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/div[1]/div[2]/div/span", 10);
                userNameLabel = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/div[1]/div[2]/div/span"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

       public void GoToChangePassword()
        {
            RenderUserName();
            userNameLabel.Click();
            RenderChangePasswordLink();
            changePasswordLink.Click();
        }

        public void RenderChangePasswordLink()
        {
            try
            {
                changePasswordLink = driver.FindElement(By.LinkText("Change Password"));
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }


        }

        public void RenderChangePasswordElements()
        {
            try
            {
                currentPasswordTextBox = driver.FindElement(By.Name("oldPassword"));
                confirmPasswordTextBox = driver.FindElement(By.Name("newPassword"));
                newPasswordTextBox = driver.FindElement(By.Name("confirmPassword"));
                saveButton = driver.FindElement(By.XPath("//*[@type='button' and text()='Save']"));

            }

            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void ResetPassword(string oldPassword, string newPassword, string confirmPassword)
        {
            RenderChangePasswordElements();
            currentPasswordTextBox.SendKeys(oldPassword);
            confirmPasswordTextBox.SendKeys(newPassword);
            newPasswordTextBox.SendKeys(confirmPassword);
            saveButton.Click();
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
    }
}
