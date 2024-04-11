using SpecFlowProject1.Pages.Components.HomePageComponents.NavigationMenuComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject1.Steps
{
    public class ManageRequestSteps
    {
        ManageRequestsComponent manageRequests;
        public ManageRequestSteps()
        {
            manageRequests = new ManageRequestsComponent();

        }

        public void ViewRecievedRequests()
        {
            manageRequests.GoToReceivedRequests();
            
        }

        public void AcceptReceivedRequests(string actions)
        {
            manageRequests.AcceptOrDeclineRequest(actions);
        }

        public void DeclineReceivedRequests(string actions)
        {
            manageRequests.AcceptOrDeclineRequest(actions);
        }

        public void CompleteAcceptedRequest(string actions)
        {
            manageRequests.CompleteRequest(actions);
        }
        public void ViewSentRequests()
        {
            manageRequests.GoToSentRequests();
            
        }

        public void WithdrawSentRequest(string action)
        {
            manageRequests.WithdrawRequest(action);
        }
    }
}
