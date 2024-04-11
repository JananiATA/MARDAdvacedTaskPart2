
using NUnit.Framework;
using SpecFlowProject1.Pages.Components.HomePageComponents.AccountMenuComponents.UserDetailsComponent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject1.AssertionHelpers
{
    public class LoginAssertion 
    {

        UserName userNameComponent = new UserName();
        public void AssertLogin(string userName)
        {
            Thread.Sleep(2000);
            string firstName = userNameComponent.GetFirstName();
            Assert.That(firstName == userName, "User not logged in Successfully");

        }
    }
}
