using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationPractice.PageObject
{
   public class Autentificacao
    {
        public static By Email = By.Id("email");
        public static By Senha = By.Id("passwd");
        public static By Logar = By.Id("SubmitLogin");
    }
}
