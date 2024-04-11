Feature: ManageListing

As a user I would like to able to Add, View, Update and Delete Listings
So that the people seeking for Listings can look at what details I hold.

   @AddListing
Scenario: Add a listing in Manage Listing
	Given the user is able to login to MARS application successfully "Login.json"
	And the user navigates to the Manage Listing Page
	When the user tries to add a listing "AddListing.json"
	Then the listing should be added successfully


	@UpdateListing
Scenario: Update a listing in Manage Listing
	Given the user is able to login to MARS application successfully "Login.json"
	And the user navigates to the Manage Listing Page
	When the user tries to update a listing "UpdateListing.json"
	Then the listing should be updated successfully

	@ViewListing
Scenario: View a listing in Manage Listing
	Given the user is able to login to MARS application successfully "Login.json"
	And the user navigates to the Manage Listing Page
	When the user tries to view a listing "ViewListing.json"
	Then the listing should be viewed successfully

	@DeleteListing
Scenario: Delete a listing in Manage Listing
	Given the user is able to login to MARS application successfully "Login.json"
	And the user navigates to the Manage Listing Page
	When the user tries to delete a listing "DeleteListing.json"
	Then the listing should be deleted successfully


	@EnableToggle
Scenario: Enable toggle in Manage Listing
	Given the user is able to login to MARS application successfully "Login.json"
	And the user navigates to the Manage Listing Page
	When the user tries to enable a toggle in a listing "ToggleEnable.json"
	Then the toggle should be enabled successfully

	@DisableToggle
Scenario: Disable toggle in Manage Listing
	Given the user is able to login to MARS application successfully "Login.json"
	And the user navigates to the Manage Listing Page
	When the user tries to disable a toggle in a listing "ToggleDisable.json"
	Then the toggle should be disabled successfully

	@SendRequest
Scenario: Send a Request to a Listing published by another user
	Given the user is able to login to MARS application successfully "Login.json"
	And the user navigates to the Manage Listing Page
	When the user tries to send a Request to a listing "SendRequest.json"
	Then the Request should be sent successfully
