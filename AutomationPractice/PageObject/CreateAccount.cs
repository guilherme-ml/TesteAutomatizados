using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationPractice.PageObject
{
   public class CreateAccount
    {
        public static By SelecionarFem = By.Id("id_gender1");
        public static By SelecionarMasc = By.Id("id_gender2");
        public static By FirstName = By.Id("customer_firstname");
        public static By LastName = By.Id("customer_lastname");
        public static By Email = By.Id("email");
        public static By Password = By.Id("passwd");
        public static By DateOfBirthDay = By.Id("days");
        public static By DateOfBirthMonths = By.Id("months");
        public static By DateOfBirthsYear = By.Id("years");
        public static By AddressFirstName = By.Id("firstname");
        public static By AddressLastName = By.Id("lastname");
        public static By AddressCompany = By.Id("company");
        public static By Address = By.Id("address1");
        public static By AddresLine2 = By.Id("address2");
        public static By City = By.Id("city");
        public static By State = By.Id("id_state");
        public static By Zip = By.Id("postcode");
        public static By Country = By.Id("id_country");
        public static By AddInformation = By.Id("other");
        public static By HomePhone = By.Id("phone");
        public static By MobilePhone = By.Id("phone_mobile");
        public static By AssignAdress = By.Id("alias");
        public static By Register = By.Id("submitAccount");

    }
}
