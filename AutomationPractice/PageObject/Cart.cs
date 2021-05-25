using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationPractice.PageObject
{
   public class Cart
    {
        public static By ContinueShopping = By.XPath("//span[@class= 'continue btn btn-default button exclusive-medium']");
        public static By ProceedToCheckout = By.XPath("//a[@title= 'Proceed to checkout']");
        public static By ProseguirCarrinho = By.XPath("(//a[@title='Proceed to checkout'])[2]");
    }
}
