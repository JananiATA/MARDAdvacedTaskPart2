using NUnit.Framework;
using SpecFlowProject1.Pages.Components.HomePageComponents.ProfileOverviewComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject1.AssertionHelpers
{
    public class EducationAssertion
    {
        Education education = new Education();
        public void AssertAddLanguage(string popUpMessage)
        {
            string expectedMessage = education.PopUpMessage();
            Assert.That(expectedMessage == popUpMessage, "Language not added successfully");
        }

        public void AssertAddInvalidLanguage(string popUpMessage)
        {
            string expectedMessage = education.PopUpMessage();
            Assert.That(expectedMessage == popUpMessage, "Invalid Language added");
        }

        public void AssertAddExistingLanguage(string popUpMessage)
        {
            string expectedMessage = education.PopUpMessage();
            Assert.That(expectedMessage == popUpMessage, "Duplicate Language added ");
        }
        public void AssertDeleteLanguage(string popUpMessage)
        {
            string expectedMessage = education.PopUpMessage();
            Assert.That(expectedMessage == popUpMessage, "Language not deleted successfully");
        }
    }
}
