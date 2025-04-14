using OpenQA.Selenium;
using OrangeHrmSpecFlow.Paages;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeHrmSpecFlow.Pages
{
    public class Admin :BaseObjects
    {


       public Admin()
       {

            PageFactory.InitElements(driver,this);

       }

        [FindsBy(How =How.XPath,Using = "//span[.='Admin']")]
        private IWebElement admin_menu;

        [FindsBy(How = How.XPath, Using = "(//input[@class='oxd-input oxd-input--active'])[2]")]
        private IWebElement username_ele;

        [FindsBy(How = How.XPath, Using = "//label[.='User Role']/following::div[3]")]
        private IWebElement userrole_ele;

        [FindsBy(How = How.XPath, Using = "(//div[@role='listbox']/div/span)[1]")]
        private IWebElement admin_role_dd;

        [FindsBy(How = How.XPath, Using = "//button[@type='submit']")]
        private IWebElement search_btn;

      

        public void navToAdminPag()
        {
            admin_menu.Click();
        }
        public void searchUser()
        {
            //username_ele.Click();
            username_ele.SendKeys("suman");
            userrole_ele.Click();
            admin_role_dd.Click();
            search_btn.Click();
        }

    }
}
