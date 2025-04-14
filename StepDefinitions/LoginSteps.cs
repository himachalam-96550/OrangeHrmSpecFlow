using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OrangeHrmSpecFlow.Drivers;
using OrangeHrmSpecFlow.Paages;
using OrangeHrmSpecFlow.Support;


namespace OrangeHrmSpecFlow.StepDefinitions
{
    [Binding]   
    public  class LoginSteps:IniPageObjectClasses
    {


        [Given("User launch the browser and navigate to login page")]
        public void GivenUserLaunchTheBrowserAndNavigateToLoginPage()
        {
            driverFactory().setNewDriver();
            
        }

        [When("User enter valid username  as {string} and password as {string} click login button")]
        public void WhenUserEnterValidUsernameAsAndPasswordAsClickLoginButton(string admin0, string p1)
        {

            loginpage().loginApplication();
        }

        [Then("Verify the user navigates to home page and title of the application")]
        public void ThenVerifyTheUserNavigatesToHomePageAndTitleOfTheApplication()
        {
           
        }
    }
}


    

