using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationPractice.PageObject
{
   public class Address
    {
        public static By ReturnHome = By.XPath("//a[@title='Return to Home']");
        public static By MyAddress = By.Id("id_address_delivery");
        public static By UseDeliveryAddress = By.Id("addressesAreEquals");
        public static By DeliveryAddressUpdate = By.XPath("(//span[text()='Update'])[1]");
        public static By BillingAddressUpdate = By.XPath("(//span[text()='Update'])[2]");
        public static By AddNewAddress = By.XPath("(//span[text()='Add a new address'])");
        public static By Below = By.XPath("//textarea");
        public static By ProceedToCheckout = By.XPath("//button[@name='processAddress']");
        public static By ContinueShopping = By.XPath("//a[@title='Previous']");
        public static By Cart = By.XPath("//div[@class='shopping_cart']");
        public static By Women = By.XPath("//a[@title='Women']");
        public static By Dresses = By.XPath("(//a[text()='Dresses'])[2]");
        public static By TShirts = By.XPath("(//a[text()='T-shirts'])[2]");
        public static By Search = By.XPath("//input[@placeholder='Search']");
        public static By Buscar = By.XPath("//button[@type='submit']");
        public static By Logo = By.XPath("//div[@id='header_logo']");


    }
}
