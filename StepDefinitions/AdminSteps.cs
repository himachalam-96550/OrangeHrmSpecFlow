using OrangeHrmSpecFlow.Support;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeHrmSpecFlow.StepDefinitions
{
    [Binding]
    public class AdminSteps :IniPageObjectClasses
    {

        [Given("User login with valid username and password to the application")]
        public void GivenUserLoginWithValidUsernameAndPasswordToTheApplication()
        {
            driverFactory().setNewDriver();
            loginpage().loginApplication();
        }

        [When("Navigates to the admin module and search with name")]
        public void WhenNavigatesToTheAdminModuleAndSearchWithName()
        {
            admin().navToAdminPag();

        }

        [Then("Validate the user with all details in the grid")]
        public void ThenValidateTheUserWithAllDetailsInTheGrid()
        {
            admin().searchUser();

        }

    }
}
