using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationPractice.PageObject
{
   public class SignIn
    {
        public static By CreateInformarEmail = By.XPath("//input[@id= 'email_create']");
        public static By CreateAnAccount = By.XPath("//button[@id= 'SubmitCreate']");
        public static By RegisterednformarEmail = By.XPath("//input[@id= 'email']");
        public static By RegisteredPassword = By.XPath("//input[@id= 'passwd']");
        public static By ButtonSignIn = By.XPath("//button[@id= 'SubmitLogin']");
    }
}
