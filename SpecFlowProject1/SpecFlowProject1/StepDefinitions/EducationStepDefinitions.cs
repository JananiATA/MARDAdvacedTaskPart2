using AventStack.ExtentReports;
using MarsSpecFlowProject.JSONObjectClasses;
using SpecFlowProject1.AssertionHelpers;
using SpecFlowProject1.JSONObjectClasses;
using SpecFlowProject1.Steps;
using SpecFlowProject1.Utilities;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public class EducationStepDefinitions : CommonDriver
    {

        LoginSteps loginSteps = new LoginSteps();
        JSONReader jsonReader;
        EducationSteps educationSteps = new EducationSteps();
        LoginAssertion loginAssertion = new LoginAssertion();
        EducationAssertion educationAssertion = new EducationAssertion();
        private ScenarioContext _context;

        public EducationStepDefinitions(ScenarioContext context)
        {
            _context = context;
        }
        

        [Given(@"the user is able to login to MARS application successfully ""([^""]*)""")]
        public void GivenTheUserIsAbleToLoginToMARSApplicationSuccessfully(string fileName)
        {
            
            string loginFilePath = ProjectPathHelper.projectPath + "\\TestData\\LoginInputFile\\" + fileName;
            jsonReader = new JSONReader(loginFilePath);
            List<Login> login = new List<Login>();
            login = jsonReader.ReadLoginFile();
            
            foreach (var item in login)
            {
                loginSteps.Login(item.LoginId, item.Password);
                loginAssertion.AssertLogin(item.UserName);

            }
        }



        [Given(@"the user navigates to the education tab in the profile page")]
        public void GivenTheUserNavigatesToTheEducationTabInTheProfilePage()
        {
            educationSteps.EducationTab();
        }

        [When(@"the user tries to add the education data from the file ""([^""]*)""")]
        public void WhenTheUserTriesToAddTheEducationDataFromTheFile(string fileName)
        {
            test = extent.CreateTest("Education - Add New");
            test.Log(Status.Info, "Education - Add New");
            string addEducationFilePath = ProjectPathHelper.projectPath + "\\TestData\\EducationInputFiles\\" + fileName;
            jsonReader = new JSONReader(addEducationFilePath);
            List<AddEducation> addEducation = new List<AddEducation>();
            addEducation = jsonReader.ReadAddEducationFile();
            foreach (var education in addEducation)
            {
                educationSteps.AddEducationRecord(education.CollegeName, education.Country, education.Title, education.Degree, education.Year);
                _context.Add("AddPopUpMessage", education.PopUpMessage);
            }
        }

        [Then(@"the education details should be added successfully")]
        public void ThenTheEducationDetailsShouldBeAddedSuccessfully()
        {
            string popUpMessage = _context.Get<string>("AddPopUpMessage");
            educationAssertion.AssertAddLanguage(popUpMessage);
          
        }

        [When(@"the user tries to add the invalid education details from the file ""([^""]*)""")]
        public void WhenTheUserTriesToAddTheInvalidEducationDetailsFromTheFile(string fileName)
        {
            test = extent.CreateTest("Education - Add Invalid Details");
            test.Log(Status.Info, "Education - Add Invalid Details");
            string addInvalidEducationFilePath = ProjectPathHelper.projectPath + "\\TestData\\EducationInputFiles\\" + fileName;
            jsonReader = new JSONReader(addInvalidEducationFilePath);
            List<AddInvalidEducation> addInvalidEducation = new List<AddInvalidEducation>();
            addInvalidEducation = jsonReader.ReadAddInvalidEducationFile();
            foreach (var education in addInvalidEducation)
            {
                educationSteps.AddEducationRecord(education.CollegeName, education.Country, education.Title, education.Degree, education.Year);
                _context.Add("AddInvalidPopUpMessage", education.PopUpMessage);
            }
        }

        [Then(@"the education details should not be added successfully")]
        public void ThenTheEducationDetailsShouldNotBeAddedSuccessfully()
        {
            string popUpMessage = _context.Get<string>("AddInvalidPopUpMessage");
            educationAssertion.AssertAddInvalidLanguage(popUpMessage);
        }

        [When(@"the user tries to add the existing education details from the file ""([^""]*)""")]
        public void WhenTheUserTriesToAddTheExistingEducationDetailsFromTheFile(string fileName)
        {
            test = extent.CreateTest("Education - Add Existing Details");
            test.Log(Status.Info, "Education - Add Existing Details");
            string addExistingEducationFilePath = ProjectPathHelper.projectPath + "\\TestData\\EducationInputFiles\\" + fileName;
            jsonReader = new JSONReader(addExistingEducationFilePath);
            List<AddExistingEducation> addExistingEducation = new List<AddExistingEducation>();
            addExistingEducation = jsonReader.ReadAddExistingEducationFile();
            foreach (var education in addExistingEducation)
            {
                educationSteps.AddExistingEducationRecord(education.CollegeName, education.Country, education.Title, education.Degree, education.Year);

                _context.Add("AddExistingPopUpMessage", education.PopUpMessage);
            }
        }

        [Then(@"the education details should not be added as a duplicate data")]
        public void ThenTheEducationDetailsShouldNotBeAddedAsADuplicateData()
        {
            string popUpMessage = _context.Get<string>("AddExistingPopUpMessage");
            educationAssertion.AssertAddExistingLanguage(popUpMessage);
        }


        [When(@"the user tries to delete the added education ""([^""]*)""")]
        public void WhenTheUserTriesToDeleteTheAddedEducation(string fileName)
        {
            string deleteEducationFilePath = ProjectPathHelper.projectPath + "\\TestData\\EducationInputFiles\\" + fileName;
            jsonReader = new JSONReader(deleteEducationFilePath);
            List<DeleteEducation> deleteEducation = new List<DeleteEducation>();
            deleteEducation = jsonReader.ReadDeleteEducationFile();
            foreach (var education in deleteEducation)

            {
                educationSteps.DeleteEducationRecord(education.CollegeName, education.Country, education.Title, education.Degree, education.Year);
                _context.Add("DeletePopUpMessage", education.PopUpMessage);
            }
        }

        [Then(@"the education details should be deleted successfully")]
        public void ThenTheEducationDetailsShouldBeDeletedSuccessfully()
        {
            string popUpMessage = _context.Get<string>("DeletePopUpMessage");
            educationAssertion.AssertDeleteLanguage(popUpMessage);
        }


    }
}
