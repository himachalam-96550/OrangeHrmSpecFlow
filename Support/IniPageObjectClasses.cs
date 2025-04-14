using OpenQA.Selenium;
using OrangeHrmSpecFlow.Drivers;
using OrangeHrmSpecFlow.Paages;
using OrangeHrmSpecFlow.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeHrmSpecFlow.Support
{
    public class IniPageObjectClasses:BaseObjects
    {

        public DriverFactory driverFactory()
        {

            return new DriverFactory();
        }

        public LoginPage loginpage()
        {
            return new LoginPage();

        }

        public Admin admin()
        {
            return new Admin();

        }

            

    }
}
