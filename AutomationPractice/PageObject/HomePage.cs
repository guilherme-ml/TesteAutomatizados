using AutomationPractice.Feature;
using iRely.Common.Ioc;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationPractice.PageObject
{
   public class HomePage
    {
        public static By SigIn = By.XPath("//div[@class='header_user_info']");
        public static By ContactUs = By.XPath("//div[@id='contact-link']");
        public static By Search = By.XPath("//input[@placeholder='Search']");
        public static By Buscar = By.XPath("//button[@type='submit']");
        public static By Cart = By.XPath("//div[@class='shopping_cart']");
        public static By Women = By.XPath("//a[@title='Women']");
        public static By Dresses = By.XPath("(//a[text()='Dresses'])[2]");
        public static By TShirts = By.XPath("(//a[text()='T-shirts'])[2]");
        public static By AddToCart = By.XPath("(//span[text()='Add to cart'])[1]");
        public static By More = By.XPath("//div[text()='More']");
        public static By Logo = By.XPath("//div[@id='header_logo']");
        public static By Produto1 = By.XPath("//img[@alt='Faded Short Sleeve T-shirts']");
        public static By UsuarioLogado = By.XPath("(//div[@class='header_user_info'])[1]");
        public static By HistoricoDeCompras = By.XPath("//span[text()='Order history and details']");
        public static By Home = By.XPath("(//a[@class='btn btn-default button button-small'])[5]");
    }
}
