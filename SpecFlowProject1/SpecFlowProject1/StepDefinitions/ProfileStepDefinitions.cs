using AventStack.ExtentReports;
using SpecFlowProject1.AssertionHelpers;
using SpecFlowProject1.JSONObjectClasses;
using SpecFlowProject1.Pages.Components.HomePageComponents.ProfileOverviewComponents;
using SpecFlowProject1.Steps;
using SpecFlowProject1.Utilities;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public class ProfileStepDefinitions : CommonDriver
    {
        ChangePasswordSteps changePasswordSteps = new ChangePasswordSteps();
        JSONReader jsonReader;
        private ScenarioContext _context;
        UpdatePasswordAssertion updatePasswordAssertion = new UpdatePasswordAssertion();

        public ProfileStepDefinitions(ScenarioContext context)
        {
            _context = context;
        }

        [When(@"the user tries to change password ""([^""]*)""")]
        public void WhenTheUserTriesToChangePassword(string fileName)
        {
            test = extent.CreateTest("Change Password");
            test.Log(Status.Info, "Change Password");
            string passwordFilePath = ProjectPathHelper.projectPath + "\\TestData\\ProfileDataInputFile\\" + fileName;
            jsonReader = new JSONReader(passwordFilePath);
            List<Password> changePassword = new List<Password>();
            changePassword = jsonReader.ReadChangePasswordFile();
            foreach (var password in changePassword)
            {
                changePasswordSteps.Password(password.OldPassword, password.NewPassword, password.NewPassword);
                _context.Add("AddPopUpMessage", password.PopUpMessage);
            }

        }

        [Then(@"the password should be updated successfully")]
        public void ThenThePasswordShouldBeUpdatedSuccessfully()
        {
            string popUpMessage = _context.Get<string>("AddPopUpMessage");
            updatePasswordAssertion.AssertChangePassword(popUpMessage);

        }
    }
}
