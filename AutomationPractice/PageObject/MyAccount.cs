using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationPractice.PageObject
{
   public class MyAccount
    {
        public static By MeuEndereco = By.XPath("(//span[text()='My addresses'])");
        public static By Atualizar = By.XPath("//a[@title='Update']");
        public static By Nome = By.Id("firstname");
        public static By Sobrenome = By.Id("lastname");
        public static By Companhia = By.Id("company");
        public static By Endereco = By.Id("address1");
        public static By EnderecoLinha2 = By.Id("address2");
        public static By Cidade = By.Id("city");
        public static By Estado = By.Id("id_state");
        public static By CodigoPostal = By.Id("postcode");
        public static By Pais = By.Id("id_country");
        public static By TelefoneCasa = By.Id("phone");
        public static By TelefoneCelular = By.Id("phone_mobile");
        public static By AddInformacao = By.Id("other");
        public static By NomeDoEndereco = By.Id("alias");
        public static By Salvar = By.Id("submitAddress");

    }
}
