# Facebook Sign Up Automation Testing
This is an automation testing program written in C# that utilizes Selenium and NUnit frameworks to assert that an invalid email address will result in an error message when attempting to register for a new account on Facebook. As part of the testing, the program:
* opens a Chrome browser window
* navigates to the Facebook registration page
* expands the browser window
* inputs a first name
* inputs a last name
* inputs an email address
* re-enters email address
* selects a birth month
* selects a birth day
* selects a birth year
* selects a gender
* clicks on the Sign Up button
* closes the browser window

## Actual Results found in testing Facebook's code:
* class names contain spaces
* id's for elements change (at least 3 times) when a user refreshes the page
* tests conducted cannot find elements by id, XPath, class names due to their changing
* in many tests invalid emails still pass through the initial registration process

## Technologies Used: 
- Visual Studio IDE

### Languages Used:
- C# and .NET framework

### Automation Testing Frameworks:
- Selenium
- Selenium WebDriver
- Selenium UI
- NUnit
