Feature: Profile

As a User I would like to update my password so that
My account details are secure.

@Password
Scenario: Change Password
	Given the user is able to login to MARS application successfully "Login.json"
	When the user tries to change password "Password.json"
	Then the password should be updated successfully
