using Faker;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Reqnroll;
using System;
using System.Linq;


namespace QA.Contribution.Test.Journey.Page
{
    public class ContactUs : PageBase
    {
        public ContactUs(ScenarioContext context) : base(context)
        {
        }

        private readonly string _emailLocator = "//*[@id='email']";
        private readonly string _messageLocator = "//*[@id='description']";
        private readonly string _submitMessageLocator = "//*[@id='submitContact']";
        private readonly string _subjectLocator = "//*[@id='subject']";
        private readonly string _errorLocator = "//*[@class='alert alert-danger']";
        private readonly string _successLocator = "//*[text()='as soon as possible.']";
        private readonly string _nameLocator = "//*[@id='name']";
        private readonly string _phoneLocator = "//*[@id='phone']";

        public string ClickSend()
        {
            Driver.GetClickableElement(By.XPath(_submitMessageLocator)).Click();
            return Driver.Url;
        }

        public string EnterEmailAddress()
        {
            var email = Faker.Internet.Email();
            var emailField = Driver.GetClickableElement(By.XPath(_emailLocator));
            emailField.Clear();
            emailField.SendKeys(email);
            return email;
        }

        public string EnterInvalidEmailAddress()
        {
                var email = Faker.Lorem.GetFirstWord();
                var emailField = Driver.GetClickableElement(By.XPath(_emailLocator));
                emailField.Clear();
                emailField.SendKeys(email);
                return email;
        }

        public void ClearEmailAddress()
        {
            var emailField = Driver.GetClickableElement(By.XPath(_emailLocator));
            emailField.Clear();
        }

        public string EnterMessage()
        {
            var message = Faker.Lorem.Paragraph();
            var messageField = Driver.GetClickableElement(By.XPath(_messageLocator));
            messageField.Clear();
            messageField.SendKeys(message);
            return message;
        }

        public string GetErrorMessage()
        {
            var errorAlert = Driver.GetClickableElement(By.XPath(_errorLocator));
            return errorAlert.Text;
        }

        public string GetSuccessMessage()
        {
            var successAlert = Driver.GetClickableElement(By.XPath(_successLocator));
            return successAlert.Text;
        }

        public string EnterPhone()
        {
            var phoneNumber = Faker.Phone.Number();
            var phoneField = Driver.GetClickableElement(By.XPath(_phoneLocator));
            phoneField.Clear();
            phoneField.SendKeys(phoneNumber);
            return phoneNumber;
        }

        public string EnterName()
        {
            var name = Faker.Name.FullName();
            var nameField = Driver.GetClickableElement(By.XPath(_nameLocator));
            nameField.Clear();
            nameField.SendKeys(name);
            return name;
        }

        public string EnterSubject()
        {
            var name = Faker.Lorem.GetFirstWord();
            var nameField = Driver.GetClickableElement(By.XPath(_subjectLocator));
            nameField.Clear();
            nameField.SendKeys(name);
            return name;
        }
        public void ClearName()
        {
            var name= Driver.GetClickableElement(By.XPath(_nameLocator));
            name.Clear();
        }
        public void ClearPhone()
        {
            var phone = Driver.GetClickableElement(By.XPath(_phoneLocator));
            phone.Clear();
        }
        public void ClearSubject()
        {
            var subject = Driver.GetClickableElement(By.XPath(_subjectLocator));
            subject.Clear();
        }
        public void ClearMessage()
        {
            var message = Driver.GetClickableElement(By.XPath(_messageLocator));
            message.Clear();
        }

        public string EnterNameAsDigits()
        {
            var digits = RandomNumber.Next(100000, 999999).ToString();
            var nameField = Driver.GetClickableElement(By.XPath(_nameLocator));
            nameField.Clear();
            nameField.SendKeys(digits);
            return digits;
        }

        public string EnterPhonenumberWithSpecialChars()
        {
            var randomString = Internet.UserName()+ "!@#$%^&*";
            var phoneNumber = Driver.GetClickableElement(By.XPath(_phoneLocator));
            phoneNumber.Clear();
            phoneNumber.SendKeys(randomString);
            return randomString; 
        }
        public string EnterPhonenumberWithMoreCharacters()
        {
            var random = new Random();
            int length = random.Next(12);
            var phoneNumString = Internet.UserName(length.ToString());
            var phoneNumber = Driver.GetClickableElement(By.XPath(_phoneLocator));
            phoneNumber.Clear();
            phoneNumber.SendKeys(phoneNumString);
            return phoneNumString;
        }
        public string EnterPhonenumberWithLessCharacters()
        {
            var random = new Random();
            int length = random.Next(5);
            var phoneNumString = Internet.UserName(length.ToString());
            var phoneNumber = Driver.GetClickableElement(By.XPath(_phoneLocator));
            phoneNumber.Clear();
            phoneNumber.SendKeys(phoneNumString);
            return phoneNumString;
        }
        public string EnterSubjectWithLessCharacters()
        {
            string subjectString = Guid.NewGuid().ToString("N").Substring(0, 4);
            var subject = Driver.GetClickableElement(By.XPath(_subjectLocator));
            subject.Clear();
            subject.SendKeys(subjectString);
            return subjectString;
        }
        public string EnterSubjectWithMoreCharacters()
        {
            string subjectString = string.Concat(Enumerable.Repeat(Guid.NewGuid().ToString("N"), 4))
                                 .Substring(0, 120);
            var subject = Driver.GetClickableElement(By.XPath(_subjectLocator));
            subject.Clear();
            subject.SendKeys(subjectString);
            return subjectString;
        }
        private string InsertRandomSpaces(string input)
        {
            if (string.IsNullOrEmpty(input))
                return input;

            Random random = new Random();
            int spacesToInsert = random.Next(1, input.Length / 2); // Insert 1 to half the length spaces

            for (int i = 0; i < spacesToInsert; i++)
            {
                int position = random.Next(1, input.Length);
                input = input.Insert(position, " ");
            }
            return input;
        }
        public string EnterNameWithWhiteSpace()
        {
            var name = Faker.Name.FullName();
            name= InsertRandomSpaces(name);
            var nameField = Driver.GetClickableElement(By.XPath(_nameLocator));
            nameField.Clear();
            nameField.SendKeys(name);
            return name;
        }
        public string EnterEmailWithWhiteSpace()
        {
            
            var email = Faker.Internet.Email();
            email = InsertRandomSpaces(email);
            var emailField = Driver.GetClickableElement(By.XPath(_emailLocator));
            emailField.Clear();
            emailField.SendKeys(email);
            return email;
        }

        public string EnterPhoneWithWhiteSpace()
        {
            var phoneNumber = Faker.Phone.Number();
            phoneNumber = InsertRandomSpaces(phoneNumber);
            var phoneField = Driver.GetClickableElement(By.XPath(_phoneLocator));
            phoneField.Clear();
            phoneField.SendKeys(phoneNumber);
            return phoneNumber;
        }

    }
}
