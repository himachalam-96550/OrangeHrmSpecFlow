using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumExtras.PageObjects;



namespace OrangeHrmSpecFlow.Paages
{
    public class LoginPage :BaseObjects
    {
       

        public LoginPage()
        {
            
            PageFactory.InitElements(driver, this);
            
        }



        [FindsBy(How = How.XPath,Using = "//input[@name='username']")]
        private IWebElement username_ele;

        [FindsBy(How = How.XPath, Using = "//input[@name='password']")]
        private IWebElement password_ele;


        [FindsBy(How = How.XPath, Using = "//button[@type='submit']")]
        private IWebElement loginBtn;


        
        

        public void loginApplication()
        {
            username_ele.SendKeys("Admin");
            password_ele.SendKeys("admin123");
            loginBtn.Click();

        }
    }
}
