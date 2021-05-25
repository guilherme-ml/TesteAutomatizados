using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationPractice.PageObject
{
   public class OrderConfirmationBW
    {
        public static By ConfirmOrder = By.XPath("(//span[text()='I confirm my order'])");
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
