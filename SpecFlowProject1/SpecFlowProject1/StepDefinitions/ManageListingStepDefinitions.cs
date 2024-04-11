using AventStack.ExtentReports;
using SpecFlowProject1.AssertionHelpers;
using SpecFlowProject1.JSONObjectClasses;
using SpecFlowProject1.Steps;
using SpecFlowProject1.Utilities;
using System;
using TechTalk.SpecFlow;
using static Microsoft.AspNetCore.Hosting.Internal.HostingApplication;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public class ManageListingStepDefinitions : CommonDriver
    {
        ManageListingSteps manageListingSteps = new ManageListingSteps();
        JSONReader jsonReader;
        private ScenarioContext _context;
        ManageListingAssertion manageListingAssertion = new ManageListingAssertion();
        public ManageListingStepDefinitions(ScenarioContext context)
        {
            _context = context;
        }

        [Given(@"the user navigates to the Manage Listing Page")]
        public void GivenTheUserNavigatesToTheManageListingPage()
        {
            manageListingSteps.GoToManageListing();
        }

        [When(@"the user tries to add a listing ""([^""]*)""")]
        public void WhenTheUserTriesToAddAListing(string fileName)
        {
            test = extent.CreateTest("Add Listing");
            test.Log(Status.Info, "Add Listing");
            string addListingFilePath = ProjectPathHelper.projectPath + "\\TestData\\ListingsInputFile\\" + fileName;
            jsonReader = new JSONReader(addListingFilePath);
            List<AddListing> addListing = new List<AddListing>();
            addListing = jsonReader.ReadAddListingFile();
            foreach (var skill in addListing)
            {
                manageListingSteps.AddNewListingSteps(skill.Title, skill.Description, skill.Category, skill.SubCategory, skill.Tags, skill.ServiceType, skill.LocationType,
                    skill.StartDate, skill.EndDate, skill.SkillTrade, skill.SkillExchange, skill.Amount, skill.ActiveStatus);
                
                _context.Add("category", skill.Category);
                _context.Add("title", skill.Title);
                _context.Add("description", skill.Description);

            }

        }

        [Then(@"the listing should be added successfully")]
        public void ThenTheListingShouldBeAddedSuccessfully()
        {
           
            string expectedCategory = _context.Get<string>("category");
            string expectedTitle = _context.Get<string>("title");
            string expectedDescription = _context.Get<string>("description");

            manageListingAssertion.AssertAddListing(expectedCategory, expectedTitle,expectedDescription);

        }

        [When(@"the user tries to update a listing ""([^""]*)""")]
        public void WhenTheUserTriesToUpdateAListing(string fileName)
        {
            test = extent.CreateTest("Update Listing");
            test.Log(Status.Info, "Update Listing");
            string updateListingFilePath = ProjectPathHelper.projectPath + "\\TestData\\ListingsInputFile\\" + fileName;
            jsonReader = new JSONReader(updateListingFilePath);
            List<UpdateListing> updateListing = new List<UpdateListing>();
            updateListing = jsonReader.ReadUpdateListingFile();
            foreach (var skill in updateListing)
            {
                manageListingSteps.AddNewListingSteps(skill.Title, skill.Description, skill.Category, skill.SubCategory, skill.Tags, skill.ServiceType, skill.LocationType,
                   skill.StartDate, skill.EndDate, skill.SkillTrade, skill.SkillExchange, skill.Amount, skill.ActiveStatus);
                manageListingSteps.UpdateNewListingSteps(skill.EditTitle, skill.EditDescription, skill.EditCategory, skill.EditSubCategory, skill.EditTags, skill.EditServiceType, skill.EditLocationType,
                    skill.EditStartDate, skill.EditEndDate, skill.EditSkillTrade, skill.EditSkillExchange, skill.EditAmount, skill.EditActiveStatus);

                _context.Add("category", skill.EditCategory);
                _context.Add("title", skill.EditTitle);
                _context.Add("description", skill.EditDescription);


            }
        }

        [Then(@"the listing should be updated successfully")]
        public void ThenTheListingShouldBeUpdatedSuccessfully()
        {
            string expectedCategory = _context.Get<string>("category");
            string expectedTitle = _context.Get<string>("title");
            string expectedDescription = _context.Get<string>("description");

            manageListingAssertion.AssertUpdateListing(expectedCategory, expectedTitle, expectedDescription);

        }

        [When(@"the user tries to view a listing ""([^""]*)""")]
        public void WhenTheUserTriesToViewAListing(string fileName)
        {
            test = extent.CreateTest("View Listing");
            test.Log(Status.Info, "View Listing");
            string viewListingFilePath = ProjectPathHelper.projectPath + "\\TestData\\ListingsInputFile\\" + fileName;
            jsonReader = new JSONReader(viewListingFilePath);
            List<ViewListing> viewListing = new List<ViewListing>();
            viewListing = jsonReader.ReadViewListingFile();
            foreach (var skill in viewListing)
            {
                manageListingSteps.AddNewListingSteps(skill.Title, skill.Description, skill.Category, skill.SubCategory, skill.Tags, skill.ServiceType, skill.LocationType,
                    skill.StartDate, skill.EndDate, skill.SkillTrade, skill.SkillExchange, skill.Amount, skill.ActiveStatus);
                manageListingSteps.ViewAddedListing();
                _context.Add("skilltitle", skill.Title);

            }

        }

        [Then(@"the listing should be viewed successfully")]
        public void ThenTheListingShouldBeViewedSuccessfully()
        {
            string skillTitle = _context.Get<string>("skilltitle");
            manageListingAssertion.AssertViewListing(skillTitle);
        }

        [When(@"the user tries to delete a listing ""([^""]*)""")]
        public void WhenTheUserTriesToDeleteAListing(string fileName)
        {
            test = extent.CreateTest("Delete Listing");
            test.Log(Status.Info, "Delete Listing");
            string deleteListingFilePath = ProjectPathHelper.projectPath + "\\TestData\\ListingsInputFile\\" + fileName;
            jsonReader = new JSONReader(deleteListingFilePath);
            List<DeleteListing> deleteListing = new List<DeleteListing>();
            deleteListing = jsonReader.ReadDeleteListingFile();
            foreach (var skill in deleteListing)
            {
                manageListingSteps.AddNewListingSteps(skill.Title, skill.Description, skill.Category, skill.SubCategory, skill.Tags, skill.ServiceType, skill.LocationType,
                    skill.StartDate, skill.EndDate, skill.SkillTrade, skill.SkillExchange, skill.Amount, skill.ActiveStatus);
                manageListingSteps.DeleteAddedListing();
                _context.Add("popUpMessage", skill.PopUpMessage);

            }
        }

        [Then(@"the listing should be deleted successfully")]
        public void ThenTheListingShouldBeDeletedSuccessfully()
        {
            string expectedMessage = _context.Get<string>("popUpMessage");
            manageListingAssertion.AssertDeleteListing(expectedMessage);
        }


        [When(@"the user tries to enable a toggle in a listing ""([^""]*)""")]
        public void WhenTheUserTriesToEnableAToggleInAListing(string fileName)
        {
            test = extent.CreateTest("Enable Toggle");
            test.Log(Status.Info, "Enable Toggle");
            string enableToggleFilePath = ProjectPathHelper.projectPath + "\\TestData\\ListingsInputFile\\" + fileName;
            jsonReader = new JSONReader(enableToggleFilePath);
            List<ToggleEnable> enableToggle = new List<ToggleEnable>();
            enableToggle = jsonReader.ReadToggleEnableListingFile();
            foreach (var skill in enableToggle)
            {
                manageListingSteps.AddNewListingSteps(skill.Title, skill.Description, skill.Category, skill.SubCategory, skill.Tags, skill.ServiceType, skill.LocationType,
                    skill.StartDate, skill.EndDate, skill.SkillTrade, skill.SkillExchange, skill.Amount, skill.ActiveStatus);
                manageListingSteps.EnableAddedListingToggle();
                _context.Add("popUpMessage", skill.PopUpMessage);
            }
        }


        [Then(@"the toggle should be enabled successfully")]
        public void ThenTheToggleShouldBeEnabledSuccessfully()
        {
            string expectedMessage = _context.Get<string>("popUpMessage");
            manageListingAssertion.AssertEnableToggle(expectedMessage);

        }

        [When(@"the user tries to disable a toggle in a listing ""([^""]*)""")]
        public void WhenTheUserTriesToDisableAToggleInAListing(string fileName)
        {
            test = extent.CreateTest("Disable Toggle");
            test.Log(Status.Info, "Disable Toggle");
            string disableToggleFilePath = ProjectPathHelper.projectPath + "\\TestData\\ListingsInputFile\\" + fileName;
            jsonReader = new JSONReader(disableToggleFilePath);
            List<ToggleDisable> disableToggle = new List<ToggleDisable>();
            disableToggle = jsonReader.ReadToggleDisableListingFile();
            foreach (var skill in disableToggle)
            {
                manageListingSteps.AddNewListingSteps(skill.Title, skill.Description, skill.Category, skill.SubCategory, skill.Tags, skill.ServiceType, skill.LocationType,
                    skill.StartDate, skill.EndDate, skill.SkillTrade, skill.SkillExchange, skill.Amount, skill.ActiveStatus);
                manageListingSteps.DisableAddedListingToggle();
                _context.Add("popUpMessage", skill.PopUpMessage);
            }
        }


        [Then(@"the toggle should be disabled successfully")]
        public void ThenTheToggleShouldBeDisabledSuccessfully()
        {
            string expectedMessage = _context.Get<string>("popUpMessage");
            manageListingAssertion.AssertEnableToggle(expectedMessage);

        }

        [When(@"the user tries to send a Request to a listing ""([^""]*)""")]
        public void WhenTheUserTriesToSendARequestToAListing(string fileName)
        {
            test = extent.CreateTest("Send Request");
            test.Log(Status.Info, "Send Request");
            string sendRequestFilePath = ProjectPathHelper.projectPath + "\\TestData\\ListingsInputFile\\" + fileName;
            jsonReader = new JSONReader(sendRequestFilePath);
            List<SendRequest> sendRequest = new List<SendRequest>();
            sendRequest = jsonReader.ReadSendRequestListingFile();
            foreach (var skill in sendRequest)
            {
                manageListingSteps.RequestSkillTrade(skill.Category, skill.SubCategory, skill.Message);
                _context.Add("popUpMessage", skill.PopUpMessage);
            }
        }

        [Then(@"the Request should be sent successfully")]
        public void ThenTheRequestShouldBeSentSuccessfully()
        {
            string expectedMessage = _context.Get<string>("popUpMessage");
            manageListingAssertion.AssertSendRequest(expectedMessage);
        }



    }
}
