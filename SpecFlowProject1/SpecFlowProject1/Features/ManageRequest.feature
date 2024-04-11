Feature: ManageRequest

As a user I would like to able to view Received and Sent Requests
So that the I will be able to manage all the Requests.

@ReceivedRequests
Scenario: Accept Received Requests 
	Given the user is able to login to MARS application successfully "Login.json"
	And the user navigates to the Manage Requests Page
	When the user tries to accept the Received Request "AcceptRequest.json"
	Then the request should be accepted successfully

	@ReceivedRequests
Scenario: Decline Received Requests 
	Given the user is able to login to MARS application successfully "Login.json"
	And the user navigates to the Manage Requests Page
	When the user tries to decline the Received Request "DeclineRequest.json"
	Then the request should be declined successfully

	
@SentRequests
Scenario: Withdraw Sent Requests
	Given the user is able to login to MARS application successfully "Login.json"
	And the user navigates to the Manage Requests Page
	When the user tries to withdraw the Sent Requests "WithdrawRequest.json"
	Then the user should be able to withdraw the Sent Request successfully

@CompleteRequests
Scenario: Complete Received Requests
	Given the user is able to login to MARS application successfully "Login.json"
	And the user navigates to the Manage Requests Page
	When the user tries to complete an Accepted Request "CompleteRequest.json"
	Then the user should be able to complete the Received Request successfully