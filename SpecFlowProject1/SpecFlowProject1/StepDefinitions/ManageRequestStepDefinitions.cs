using AventStack.ExtentReports;
using SpecFlowProject1.AssertionHelpers;
using SpecFlowProject1.JSONObjectClasses;
using SpecFlowProject1.Steps;
using SpecFlowProject1.Utilities;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public class ManageRequestStepDefinitions : CommonDriver
    {
        ManageRequestSteps manageRequestSteps = new ManageRequestSteps();
        JSONReader jsonReader;
        private ScenarioContext _context;

        public ManageRequestStepDefinitions(ScenarioContext context)
        {
            _context = context;
        }

        ManageRequestAssertions manageRequestAssertions = new ManageRequestAssertions();

        [Given(@"the user navigates to the Manage Requests Page")]
        public void GivenTheUserNavigatesToTheManageRequestsPage()
        {
            manageRequestSteps.ViewRecievedRequests();
        }

        [When(@"the user tries to accept the Received Request ""([^""]*)""")]
        public void WhenTheUserTriesToAcceptTheReceivedRequest(string fileName)
        {
            test = extent.CreateTest("Accept Request");
            test.Log(Status.Info, "Accept Request");
            string acceptRequestFilePath = ProjectPathHelper.projectPath + "\\TestData\\ManageRequestsInputFile\\" + fileName;
            jsonReader = new JSONReader(acceptRequestFilePath);
            List<AcceptRequest> acceptRequest = new List<AcceptRequest>();
            acceptRequest = jsonReader.ReadAcceptRequestFile();
            foreach (var skill in acceptRequest)
            {
                manageRequestSteps.ViewRecievedRequests();
                manageRequestSteps.AcceptReceivedRequests(skill.Actions);
                _context.Add("popUpMessage", skill.PopUpMessage);

            }
        }

        [Then(@"the request should be accepted successfully")]
        public void ThenTheRequestShouldBeAcceptedSuccessfully()
        {
            string expectedMessage = _context.Get<string>("popUpMessage");
            manageRequestAssertions.AssertReceivedRequests(expectedMessage);
        }

        [When(@"the user tries to decline the Received Request ""([^""]*)""")]
        public void WhenTheUserTriesToDeclineTheReceivedRequest(string fileName)
        {
            test = extent.CreateTest("Decline Request");
            test.Log(Status.Info, "Decline Request");
            string declineRequestFilePath = ProjectPathHelper.projectPath + "\\TestData\\ManageRequestsInputFile\\" + fileName;
            jsonReader = new JSONReader(declineRequestFilePath);
            List<DeclineRequest> declineRequest = new List<DeclineRequest>();
            declineRequest = jsonReader.ReadDeclineRequestFile();
            foreach (var skill in declineRequest)
            {
                manageRequestSteps.ViewRecievedRequests();
                manageRequestSteps.DeclineReceivedRequests(skill.Actions);
                _context.Add("popUpMessage", skill.PopUpMessage);

            }
        }

        [Then(@"the request should be declined successfully")]
        public void ThenTheRequestShouldBeDeclinedSuccessfully()
        {
            string expectedMessage = _context.Get<string>("popUpMessage");
            manageRequestAssertions.AssertReceivedRequests(expectedMessage);
        }


        [When(@"the user tries to withdraw the Sent Requests ""([^""]*)""")]
        public void WhenTheUserTriesToWithdrawTheSentRequests(string fileName)
        {
            test = extent.CreateTest("Withdraw Request");
            test.Log(Status.Info, "Withdraw Request");
            string withdrawRequestFilePath = ProjectPathHelper.projectPath + "\\TestData\\ManageRequestsInputFile\\" + fileName;
            jsonReader = new JSONReader(withdrawRequestFilePath);
            List<WithdrawRequest> withdrawRequest = new List<WithdrawRequest>();
            withdrawRequest = jsonReader.ReadWithdrawRequestFile();
            foreach (var skill in withdrawRequest)
            {
                manageRequestSteps.ViewSentRequests();
                manageRequestSteps.WithdrawSentRequest(skill.Actions);
                _context.Add("WithdrawRequestPopUpMessage", skill.PopUpMessage);

            }
        }

        [Then(@"the user should be able to withdraw the Sent Request successfully")]
        public void ThenTheUserShouldBeAbleToWithdrawTheSentRequestSuccessfully()
        {
            string Message = _context.Get<string>("WithdrawRequestPopUpMessage");
            manageRequestAssertions.AssertWithdrawRequest(Message);
        }


        [When(@"the user tries to complete an Accepted Request ""([^""]*)""")]
        public void WhenTheUserTriesToCompleteAnAcceptedRequest(string fileName)
        {
            test = extent.CreateTest("Complete Request");
            test.Log(Status.Info, "Complete Request");
            string completeRequestFilePath = ProjectPathHelper.projectPath + "\\TestData\\ManageRequestsInputFile\\" + fileName;
            jsonReader = new JSONReader(completeRequestFilePath);
            List<CompleteRequest> completeRequest = new List<CompleteRequest>();
            completeRequest = jsonReader.ReadCompleteRequestFile();
            foreach (var skill in completeRequest)
            {
                manageRequestSteps.ViewRecievedRequests();
                manageRequestSteps.CompleteAcceptedRequest(skill.Actions);
                _context.Add("CompleteRequestPopUpMessage", skill.PopUpMessage);

            }
        }

        [Then(@"the user should be able to complete the Received Request successfully")]
        public void ThenTheUserShouldBeAbleToCompleteTheReceivedRequestSuccessfully()
        {
            string Message = _context.Get<string>("CompleteRequestPopUpMessage");
            manageRequestAssertions.AssertCompleteRequest(Message);
        }


    }


}
