using NUnit.Framework;
using SpecFlowProject1.Pages.Components.HomePageComponents.NavigationMenuComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject1.AssertionHelpers
{
    public class ManageRequestAssertions
    {
        ManageRequestsComponent manageRequestsComponent = new ManageRequestsComponent();
        public void AssertReceivedRequests(string popUpMessage)
        {
            string expectedMessage = manageRequestsComponent.RenderPopUpMessage();
            Assert.That(popUpMessage == expectedMessage, "Request not Accepted/Rejected successfully");
        }

        public void AssertCompleteRequest(string popUpMessage)
        {
            string expectedMessage = manageRequestsComponent.RenderPopUpMessage();
            Assert.That(popUpMessage == expectedMessage, "Request not completed successfully");
        }

        public void AssertWithdrawRequest(string popUpMessage)
        {
            string expectedMessage = manageRequestsComponent.RenderPopUpMessage();
            Assert.That(popUpMessage == expectedMessage, "Request not withdrawn successfully");
        }
    }
}
