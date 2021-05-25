using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationPractice.PageObject
{
   public class OrderSummaryCheck
    {
        public static By OtherPaymentMethods = By.XPath("//a[@class='button-exclusive btn btn-default']");
        public static By ConfirmOrder = By.XPath("//button[@class='button btn btn-default button-medium']");
        public static By ReturnHome = By.XPath("//a[@title='Return to Home']");
        public static By Cart = By.XPath("//div[@class='shopping_cart']");
        public static By Women = By.XPath("//a[@title='Women']");
        public static By Dresses = By.XPath("(//a[text()='Dresses'])[2]");
        public static By TShirts = By.XPath("(//a[text()='T-shirts'])[2]");
        public static By Search = By.XPath("//input[@placeholder='Search']");
        public static By Buscar = By.XPath("//button[@type='submit']");
        public static By Logo = By.XPath("//div[@id='header_logo']");
    }
}
