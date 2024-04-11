using NUnit.Framework;
using SpecFlowProject1.Pages.Components.HomePageComponents.AccountMenuComponents.UserDetailsComponent;
using SpecFlowProject1.Pages.Components.HomePageComponents.ProfileOverviewComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject1.AssertionHelpers
{
    public class UpdatePasswordAssertion
    {
        ChangePassword changePassword = new ChangePassword();
        public void AssertChangePassword(string popUpMessage)
        {
            string expectedMessage = changePassword.PopUpMessage();
            Assert.That(expectedMessage == popUpMessage, "Language not added successfully");
        }
    }
}
