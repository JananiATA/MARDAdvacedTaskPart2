using OpenQA.Selenium;
using SpecFlowProject1.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject1.Pages.Components.HomePageComponents.AccountMenuComponents.UserDetailsComponent
{
    public class UserName : CommonDriver
    {
        private IWebElement userNameLabel;
      

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

        public string GetFirstName()
        {
            
            try
            {
                RenderUserName();
                return userNameLabel.Text;

            }
            catch (Exception ex)
            {
                driver.Navigate().Refresh();
                return ex.Message;
            }
        }
    }
}
