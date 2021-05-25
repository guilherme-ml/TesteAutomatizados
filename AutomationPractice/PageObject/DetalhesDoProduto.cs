using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationPractice.PageObject
{
   public class DetalhesDoProduto 
    {
        public static By AddToCart = By.XPath("(//span[text()='Add to cart'])[1]");
        public static By ContinueShopping = By.XPath("//span[@class= 'continue btn btn-default button exclusive-medium']");
        public static By ProceedToCheckout = By.XPath("//a[@title= 'Proceed to checkout']");
    }
}
