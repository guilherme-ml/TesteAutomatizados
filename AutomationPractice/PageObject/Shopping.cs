using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationPractice.PageObject
{
   public class Shopping
    {
        public static By TermsOfService = By.Id("cgv");
        public static By MyCarrier = By.Id("delivery_option_504735_0");
        public static By ProceedToCheckout = By.XPath("//button[@name='processCarrier']");
        public static By ContinueShopping = By.XPath("//a[@title='Previous']");
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
