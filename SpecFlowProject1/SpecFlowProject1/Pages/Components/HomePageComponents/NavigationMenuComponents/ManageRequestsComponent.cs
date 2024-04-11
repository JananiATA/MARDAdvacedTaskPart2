using OpenQA.Selenium;
using SpecFlowProject1.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject1.Pages.Components.HomePageComponents.NavigationMenuComponents
{
    public class ManageRequestsComponent : CommonDriver
    {
        private IWebElement manageRequeststab;
        private IWebElement receivedRequestsLink;
        private IWebElement sentRequestsLink;
        private IWebElement messageWindow;
        private IWebElement acceptButton;
        private IWebElement declineButton;
        private IWebElement completeButton;
        private IWebElement withdrawButton;
        private IWebElement closePopUp;

        public void RenderManageRequestsTab()
        {
            manageRequeststab = driver.FindElement(By.XPath("//*[@class='ui dropdown link item' and text()='Manage Requests']"));

        }

        public void RenderReceivedRequestsLink()
        {
            receivedRequestsLink = driver.FindElement(By.PartialLinkText("Received Requests"));
        }

        public void GoToReceivedRequests()
        {
            RenderManageRequestsTab();
            manageRequeststab.Click();
            RenderReceivedRequestsLink();
            receivedRequestsLink.Click();

        }

        public void RenderAcceptButton()
        {
            Wait.WaitToBeClickable(driver, "XPath", "//*[@id=\"received-request-section\"]/div[2]/div[1]/table/tbody/tr[1]/td[8]/button[1]", 5);
            acceptButton = driver.FindElement(By.XPath("//*[@id=\"received-request-section\"]/div[2]/div[1]/table/tbody/tr[1]/td[8]/button[1]"));
        }

        public void RenderDeclineButton()
        {
            Wait.WaitToBeVisible(driver, "XPath", "//*[@id=\"received-request-section\"]/div[2]/div[1]/table/tbody/tr[1]/td[8]/button[2]", 5);
            declineButton = driver.FindElement(By.XPath("//*[@id=\"received-request-section\"]/div[2]/div[1]/table/tbody/tr[1]/td[8]/button[2]"));
        }

        public void RenderCompleteButton()
        {
            Wait.WaitToBeVisible(driver, "XPath", "//*[@id=\"received-request-section\"]/div[2]/div[1]/table/tbody/tr[1]/td[8]/button", 10);
            completeButton = driver.FindElement(By.XPath("//*[@id=\"received-request-section\"]/div[2]/div[1]/table/tbody/tr[1]/td[8]/button"));
            
        }

        public void AcceptOrDeclineRequest(string actions)
        {
            RenderAcceptButton();
            RenderDeclineButton();
            if (actions == "Accept")
            {
                acceptButton.Click();
            }
            else
            {
                declineButton.Click();
            }


        }
        public void CompleteRequest(string actions)
        {
            AcceptOrDeclineRequest(actions);
            Thread.Sleep(2000);
            RenderClosePopUp();
            closePopUp.Click();
            RenderCompleteButton();
            completeButton.Click();
            Thread.Sleep(1000);
            
            
        }

        public void RenderSentRequestsLink()
        {
            sentRequestsLink = driver.FindElement(By.PartialLinkText("Sent Requests"));
        }

        public void GoToSentRequests()
        {
            RenderManageRequestsTab();
            manageRequeststab.Click();
            RenderSentRequestsLink();
            sentRequestsLink.Click();
        }

        public void RenderWithdrawButton()
        {
            Wait.WaitToBeVisible(driver, "XPath", "//*[@id=\"sent-request-section\"]/div[2]/div[1]/table/tbody/tr[1]/td[8]/button", 5);
            withdrawButton = driver.FindElement(By.XPath("//*[@id=\"sent-request-section\"]/div[2]/div[1]/table/tbody/tr[1]/td[8]/button"));
        }

        public void WithdrawRequest(string action)
        {
            RenderWithdrawButton();
            if (action == "Withdraw")
            {
                withdrawButton.Click();
            }
        }
        public void RenderClosePopUp()
        {

            closePopUp = driver.FindElement(By.XPath("//*[@class='ns-close']"));
        }
        public string RenderPopUpMessage()
        {
            
            messageWindow = driver.FindElement(By.XPath("//*[@class='ns-box-inner']"));
            return messageWindow.Text;

        }
    }
}
