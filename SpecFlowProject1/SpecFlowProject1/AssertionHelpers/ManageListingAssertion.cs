using NUnit.Framework;
using SpecFlowProject1.Pages.Components.HomePageComponents.NavigationMenuComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject1.AssertionHelpers
{
    public class ManageListingAssertion
    {
        ManageListingComponent manageListingComponent = new ManageListingComponent();

         public void AssertDeleteListing(string popUpMessage)
          {
              string expectedMessage = manageListingComponent.RenderPopUpMessage();
              Assert.That(popUpMessage == expectedMessage, "Listing not deleted successfully");
          } 

        public void AssertAddListing(string expectedCategory, string expectedTitle, string expectedDescription)
        {
            string category = manageListingComponent.ListCategory();
            string title = manageListingComponent.ListTitle();
            string description = manageListingComponent.ListDescription();
            Assert.That(category == expectedCategory, "Category not added Successfully");
            Assert.That(title == expectedTitle, "Title not added Successfully");
            Assert.That(description == expectedDescription, "Description not added successfully");

        }

        public void AssertUpdateListing(string expectedCategory, string expectedTitle, string expectedDescription)
        {
            string category = manageListingComponent.ListCategory();
            string title = manageListingComponent.ListTitle();
            string description = manageListingComponent.ListDescription();
            Assert.That(category == expectedCategory, "Category not updated Successfully");
            Assert.That(title == expectedTitle, "Title not updated Successfully");
            Assert.That(description == expectedDescription, "Description not updated successfully");
        }


        public void AssertViewListing(string skillTitle)
        {
            string title = manageListingComponent.SkillTitle();
            Assert.That(title == skillTitle, "Skill not viewed Successfully");

        }

        public void AssertEnableToggle(string popUpMessage)
        {
            string expectedMessage = manageListingComponent.RenderPopUpMessage();
            Assert.That(popUpMessage == expectedMessage, "Listing not activated successfully");
        }

        public void AssertDisableToggle(string popUpMessage)
        {
            string expectedMessage = manageListingComponent.RenderPopUpMessage();
            Assert.That(popUpMessage == expectedMessage, "Listing not activated successfully");
        }


        public void AssertSendRequest(string popUpMessage)
        {
            string expectedMessage = manageListingComponent.RenderPopUpMessage();
            Assert.That(popUpMessage == expectedMessage, "Request not sent successfully");
        }
    }
}
