Feature: Education
As a user I would like to able to Add and Delete Education
So that the people seeking for skills and Education can look at what details I hold.
   @AddEducation
Scenario: Add Education
	Given the user is able to login to MARS application successfully "Login.json"
	And the user navigates to the education tab in the profile page
	When the user tries to add the education data from the file "AddEducation.json"
	Then the education details should be added successfully

	@AddEducation
Scenario: Add Education with invalid details
	Given the user is able to login to MARS application successfully "Login.json"
	And the user navigates to the education tab in the profile page
	When the user tries to add the invalid education details from the file "AddInvalidEducation.json"
	Then the education details should not be added successfully

	@AddEducation
Scenario: Add Education that already exists
	Given the user is able to login to MARS application successfully "Login.json"
	And the user navigates to the education tab in the profile page
	When the user tries to add the existing education details from the file "AddExistingEducation.json"
	Then the education details should not be added as a duplicate data


	@DeleteEducation
	Scenario: Delete Education
	Given the user is able to login to MARS application successfully "Login.json"
	And the user navigates to the education tab in the profile page
	When the user tries to delete the added education "DeleteEducation.json" 
	Then the education details should be deleted successfully 
	