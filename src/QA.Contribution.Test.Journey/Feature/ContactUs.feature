Feature: ContactUs
	As a customer
	I want to contact customer services
	So that I can get support
	
	Description:
	A Contact Form that allows customers to send a message to customer servies.
	In submitting a message the customer uses the subject line to indicate the message title.
	In submitting a message the customer must provide a valid 'Email address' and a 'Messsage' body for the message to be submitted successfully.
	In submitting a message, the customer can provide a valid 'Phone' number.
	
	Glossary:
	Basic Message - A message that can be submitted.
	Invalid Email Address -  An empty string
	Malformed Email Address - An email address that does not validate as an email address, e.g. missing domain
	Valid details - Valid Name,Email,Phone,Subject and Message
	Required fields - Empty fields submission
	Disabled Submit button - Submit button remains disabled without filling required fileds
	Invalid Name - Name as digits
	Phone number with special characters 
	Phone number field with incorrect length -Longer than reuired
	Phone number field with incorrect length- Shorter than required
	Blank Subject field - An empty string
	Subject field with less charcters than required
	Subject field with more charcters than required
	Blank message field - An empty string
	White space check- Name,Email and Subject fields with white spaces
	Page Refresh - Click on Refresh button
	Browser Compatibility
	
Scenario: The one where the customer successfully submits a Basic Message
	Given the Contact Us page is displayed
	When the customer enters a Basic Message
	And the customer submits the message
	Then the message is successfully submitted

@refactor 
Scenario: The one where the customer provides an invalid email address
	Given the Contact Us page is displayed
	When the customer types an empty string into the email address field
	And the user types a message into the message body field
	And the customer submits the message
	Then the customer is informed of the email validation error

@failing
Scenario: The one where the customer provides a malformed email address
	Given the Contact Us page is displayed
	When the customer completes a Basic Message with a malformed email address
	And the customer submits the message
	Then the user is presented with the correct validation message
	
Scenario: The one where customer submits with valid details
	Given the Contact Us page is displayed
	When the customer enters a valid Name,Email,Phone,Subject and Message
	And the customer submits the message
	Then the message is successfully submitted
	
Scenario: Verifying Mandatory fields
	Given the Contact Us page is displayed
	When the customer leaves all the fields empty
	And the customer submits the message
	Then the user is presented with the correct validation message
	
Scenario: Name field validation when customer enters digits as name
	Given the Contact Us page is displayed
	When the customer fills the form with numbers as name
	And the customer submits the message
	
Scenario: Phone number validation with special characters
	Given the Contact Us page is displayed
	When the customer completes the form with special characters in the phone number field and valid data in all other fields
	And the customer submits the message
	Then the user is presented with the correct validation message
	
Scenario: Validate phone number field with incorrect length - Longer numbers than required 
    Given the Contact Us page is displayed  
    When the customer enters a phone number longer than the required length  
    And the customer enters valid details in all other fields except phone 
    And the customer submits the message  
    Then the user is presented with the correct validation message
	
Scenario: Validate phone number field with incorrect length- Shorter numbers than required 
    Given the Contact Us page is displayed  
    When the customer enters a phone number shorter than the required length  
    And the customer enters valid details in all other fields except phone 
    And the customer submits the message  
    Then the user is presented with the correct validation message
	
Scenario: Validate Empty Subject Field
	Given the Contact Us page is displayed
	When the customer completes the form with empty string into subject and valid data in all other fields
	And the customer submits the message
	Then the user is presented with the correct validation message
	
Scenario: Validate Subject field with less charcters than required
	Given the Contact Us page is displayed
	When the customer enters less charcters in subject field than required
	And customer enters valid details in all other fields except subject
	And the customer submits the message
	Then the user is presented with the correct validation message
	
Scenario: Validate Subject field with more charcters than required
	Given the Contact Us page is displayed
	When the customer enters more charcters in subject field than allowed
	And customer enters valid details in all other fields except subject
	And the customer submits the message
	Then the user is presented with the correct validation message
	
Scenario: Validate Empty Message Field
	Given the Contact Us page is displayed
	When the customer completes the form with empty string into message and valid data in all other fields
	And the customer submits the message
	Then the user is presented with the correct validation message
	
Scenario: Whitespace validation in required fields
	Given the Contact Us page is displayed
    When the customer enters spaces in the Name, Email, and Phone fields
    And the customer submits the message
    Then the user is presented with the correct validation message

@manual @ignore
Scenario: Verification of Page Refresh
	Given the Contact Us page is displayed
	When the customer enters a valid Name,Email,Phone,Subject and Message
	And clicks on refresh button
	Then all fields should be cleared

@manual @ignore
Scenario: Browser compatibility validation
    When the Contact Us form is opened on different browsers
    Then the form should function across all supported browsers as expected

@manual @ignore
Scenario: Customer is not allowed to click submit button without filling required fields
	Given the Contact Us page is displayed
	When the customer leaves mandatory fileds empty
	And the customer submits the message
	Then the submit buitton remains disabled





