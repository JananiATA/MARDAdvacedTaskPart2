using SpecFlowProject1.Pages.Components.HomePageComponents.AccountMenuComponents.UserDetailsComponent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject1.Steps
{
    public class ChangePasswordSteps
    {
        ChangePassword changePassword;
        public ChangePasswordSteps()
        {
            changePassword = new ChangePassword();
        }

        public void Password(string oldPassword, string newPassword, string confirmPassword)
        {
            changePassword.GoToChangePassword();
            changePassword.ResetPassword(oldPassword, newPassword, confirmPassword);

        }
    }
}
