using System;
using Reqnroll;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QA.Contribution.Test.Journey.Page;

namespace QA.Contribution.Test.Journey.StepDefinition
{
    [Binding]
    public class ContactUsSteps
    {
        private Landing _landingPage;
        private ContactUs _contactUsPage;

        public ContactUsSteps(ScenarioContext scenarioContext)
        {
            _landingPage = new Landing(scenarioContext);
            _contactUsPage = new ContactUs(scenarioContext);
        }

        [Given("the Contact Us page is displayed")]
        public void GivenTheContactUsPageIsDisplayed()
        {
            _landingPage.Navigate();
        }

        [When("the customer enters a Basic Message")]
        public void WhenTheCustomerEntersBasicMessage()
        {
            _contactUsPage.EnterName();
            _contactUsPage.EnterEmailAddress();
            _contactUsPage.EnterPhone();
            _contactUsPage.EnterSubject();
            _contactUsPage.EnterMessage();
        }

        [When("the customer submits the message")]
        public void WhenTheCustomerSubmitsTheMessage()
        {
            _contactUsPage.ClickSend();
        }

        [When("the customer types an empty string into the email address field")]
        public void WhenTheCustomerTypesAnEmptyStringIntoTheEmailAddressField()
        {
            _contactUsPage.ClearEmailAddress();
        }
        
        [When("the user types a message into the message body field")]
        public void WhenTheUserTypesThisIsAMessageIntoTheMessageBodyField()
        {
            _contactUsPage.EnterMessage();
        }

        [Then("the message is successfully submitted")]
        public void ThenTheMessageIsSuccessfullySubmitted()
        {
            var message = _contactUsPage.GetSuccessMessage();
            Assert.IsFalse(string.IsNullOrEmpty(message));
        }
        
        [Then("the message is not submitted successfully")]
        public void ThenTheMessageIsNotSubmittedSuccessfully()
        {
            var message = _contactUsPage.GetErrorMessage();
            Assert.IsFalse(string.IsNullOrEmpty(message));
        }
        
        [Then("the customer is informed of the email validation error")]
        public void ThenTheCustomerIsInformedOfTheEmailValidationError()
        {
            var message = _contactUsPage.GetErrorMessage();
            Assert.IsFalse(string.IsNullOrEmpty(message));
        }
        
        [Then("the user is presented with the correct validation message")]
        public void ThenTheUserIsPresentedWithTheCorrectValidationMessage()
        {
            var message = _contactUsPage.GetErrorMessage();
            Assert.IsFalse(string.IsNullOrEmpty(message));
        }

        [When(@"the customer completes a Basic Message with a malformed email address")]
        public void WhenTheCustomerCompletesATechincalSupportRequestWithAMalformedEmailAddress()
        {
            _contactUsPage.EnterInvalidEmailAddress();
            _contactUsPage.EnterMessage();
        }
        [When("the customer enters a valid Name,Email,Phone,Subject and Message")]
        public void WhenTheCustomerEntersAValidNameEmailPhoneSubjectAndMessage()
        {
            _contactUsPage.EnterName();
            _contactUsPage.EnterEmailAddress();
            _contactUsPage.EnterPhone();
            _contactUsPage.EnterSubject();
            _contactUsPage.EnterMessage();
        }

        [When("the customer leaves all the fields empty")]
        public void WhenTheCustomerLeavesAllTheFieldsEmpty()
        {
            _contactUsPage.ClearName();
            _contactUsPage.ClearEmailAddress();
            _contactUsPage.ClearPhone();
            _contactUsPage.ClearSubject();
            _contactUsPage.ClearMessage();
        }
      
        [When("the customer fills the form with numbers as name")]
        public void WhenTheCustomerFillsTheFormWithNumbersAsName()
        {
            _contactUsPage.EnterNameAsDigits();
            _contactUsPage.EnterEmailAddress();
            _contactUsPage.EnterPhone();
            _contactUsPage.EnterSubject();
            _contactUsPage.EnterMessage();

        }

        [When("the customer completes the form with special characters in the phone number field and valid data in all other fields")]
        public void WhenTheCustomerCompletesTheFormWithSpecialCharactersInThePhoneNumberFieldAndValidDataInAllOtherFields()
        {
            _contactUsPage.EnterName();
            _contactUsPage.EnterEmailAddress();
            _contactUsPage.EnterPhonenumberWithSpecialChars();
            _contactUsPage.EnterSubject();
            _contactUsPage.EnterMessage();

        }
        [When("the customer enters a phone number longer than the required length")]
        public void WhenTheCustomerEntersAPhoneNumberLongerThanTheRequiredLength()
        {
            _contactUsPage.EnterPhonenumberWithMoreCharacters();

        }
        [When("the customer enters valid details in all other fields except phone")]
        public void WhenTheCustomerEntersValidDetailsInAllOtherFieldsExceptPhone()
        {
            _contactUsPage.EnterName();
            _contactUsPage.EnterEmailAddress();
            _contactUsPage.EnterSubject();
            _contactUsPage.EnterMessage();
        }
        [When("the customer enters a phone number shorter than the required length")]
        public void WhenTheCustomerEntersAPhoneNumberShorterThanTheRequiredLength()
        {
            _contactUsPage.EnterPhonenumberWithLessCharacters();
        }
        [When("the customer completes the form with empty string into subject and valid data in all other fields")]
        public void WhenTheCustomerCompletesTheFormWithEmptyStringIntoSubjectAndValidDataInAllOtherFields()
        {
            _contactUsPage.EnterName();
            _contactUsPage.EnterEmailAddress();
            _contactUsPage.EnterPhone();
            _contactUsPage.ClearSubject();
            _contactUsPage.EnterMessage();
        }
        [When("the customer enters less charcters in subject field than required")]
        public void WhenTheCustomerEntersLessCharctersInSubjectFieldThanRequired()
        {
            _contactUsPage.EnterSubjectWithLessCharacters();
        }

        [When("the customer enters more charcters in subject field than allowed")]
        public void WhenTheCustomerEntersMoreCharctersInSubjectFieldThanAllowed()
        {
            _contactUsPage.EnterSubjectWithMoreCharacters();
        }
        [When("customer enters valid details in all other fields except subject")]
        public void WhenCustomerEntersValidDetailsInAllOtherFieldsExceptSubject()
        {
            _contactUsPage.EnterName();
            _contactUsPage.EnterEmailAddress();
            _contactUsPage.EnterPhone();
            _contactUsPage.EnterMessage();
        }
        [When("the customer completes the form with empty string into message and valid data in all other fields")]
        public void WhenTheCustomerCompletesTheFormWithEmptyStringIntoMessageAndValidDataInAllOtherFields()
        {
            _contactUsPage.EnterName();
            _contactUsPage.EnterEmailAddress();
            _contactUsPage.EnterPhone();
            _contactUsPage.ClearSubject();
            _contactUsPage.ClearMessage();
        }
        [When("the customer enters spaces in the Name, Email, and Phone fields")]
        public void WhenTheCustomerEntersSpacesInTheNameEmailAndPhoneFields()
        {
            _contactUsPage.EnterNameWithWhiteSpace();
            _contactUsPage.EnterEmailWithWhiteSpace();
            _contactUsPage.EnterPhoneWithWhiteSpace();
            _contactUsPage.EnterSubject();
            _contactUsPage.EnterMessage();
        }



    }
}
