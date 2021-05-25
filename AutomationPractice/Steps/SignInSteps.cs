using AutomationPractice.Base;
using AutomationPractice.PageObject;
using OfficeOpenXml.FormulaParsing.Excel.Functions.Math;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit.Abstractions;

namespace AutomationPractice.Steps
{
   public class SignInSteps : BaseTests
    {
        public SignInSteps(ITestOutputHelper outputHelper) : base(outputHelper)
        {
        }
        public static void CriarEmail()
        {
            Report.Log("clicar no campo de texto e inserir o e-mail");
            WebDriver.FindElement(SignIn.CreateInformarEmail).SendKeys(Utils.RandomEmail());
            WebDriver.FindElement(SignIn.CreateAnAccount).Click();
        }
        public static void LogarConta()
        {
            Report.Log("colocar email e senha e apertar em sign in");
            WebDriver.FindElement(SignIn.RegisterednformarEmail).SendKeys("guilhermemoreiralima@outlook.com");
            WebDriver.FindElement(SignIn.RegisteredPassword).SendKeys("Guilherminho098");
            WebDriver.FindElement(SignIn.ButtonSignIn).Click();
                
        }
        public static void CriarConta(string nome, string sobrenome, string password, string company, string address, string addressLineTwo, string city, string addInformations, string homePhone, string mobilePhone, string assignAddress, string country, string state)
        {
        
            Report.Log("preencher todos os campos de dados e clicar em register");
            WebDriver.FindElement(CreateAccount.SelecionarFem).Click();
            WebDriver.FindElement(CreateAccount.SelecionarMasc).Click();                
            WebDriver.FindElement(CreateAccount.FirstName).SendKeys(nome);
            WebDriver.FindElement(CreateAccount.LastName).SendKeys(sobrenome);
            WebDriver.FindElement(CreateAccount.Password).SendKeys(password);
            var selectElementDia = new SelectElement(WebDriver.FindElement(CreateAccount.DateOfBirthDay));
            selectElementDia.SelectByValue("5");
            var selectElementMes = new SelectElement(WebDriver.FindElement(CreateAccount.DateOfBirthMonths));
            selectElementMes.SelectByValue("1");
            var SelectElementAno = new SelectElement(WebDriver.FindElement(CreateAccount.DateOfBirthsYear));
            SelectElementAno.SelectByValue("2006");
            WebDriver.FindElement(CreateAccount.AddressCompany).SendKeys(company);
            WebDriver.FindElement(CreateAccount.Address).SendKeys(address);
            WebDriver.FindElement(CreateAccount.AddresLine2).SendKeys(addressLineTwo);
            WebDriver.FindElement(CreateAccount.City).SendKeys(city);
            var selectElementEstado = new SelectElement(WebDriver.FindElement(CreateAccount.State));
            selectElementEstado.SelectByValue(state);
            WebDriver.FindElement(CreateAccount.Zip).SendKeys("00000");
            var SelectElementPais = new SelectElement(WebDriver.FindElement(CreateAccount.Country));
            SelectElementPais.SelectByValue(country);
            WebDriver.FindElement(CreateAccount.AddInformation).SendKeys(addInformations);
            WebDriver.FindElement(CreateAccount.HomePhone).SendKeys(homePhone);
            WebDriver.FindElement(CreateAccount.MobilePhone).SendKeys(mobilePhone);
            WebDriver.FindElement(CreateAccount.AssignAdress).SendKeys(assignAddress);
            WebDriver.FindElement(CreateAccount.Register).Click();
        }
        

       
    }
    
}
