using OpenQA.Selenium;

namespace TestesAPIGuilherme.PageObject
{
    public class AssistirTrailer
    {
        public static By Enviar = By.ClassName("submit-wrapper");
        public static By Dia = By.XPath("//input[@placeholder='DD']");
        public static By Mes = By.XPath("//input[@placeholder='Mês']");
        public static By Ano = By.XPath("//input[@placeholder='AAAA']");
        public static By Fechar = By.XPath("//div[@class='button-icon close']");
        public static By Trailer = By.ClassName("modal-content-container");
        public static By MensagemIdade = By.XPath("//div[text()='Desculpe, você não possui os requisitos mínimos.']");

    }
}
