using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.Events;
using System;
using System.IO;
using System.Reflection;
using Xunit.Abstractions;

namespace TestesAPIGuilherme.Base
{
    public abstract  class BaseTests : IDisposable
    {
        public static RemoteWebDriver driver;
        public static EventFiringWebDriver WebDriver;
        public static string Report = "";
        public static string TestResultsDir = "";
        public static string TestName = "";
        public static ITest Test;

        protected readonly ITestOutputHelper _output;
        public static bool TestStatusResult;

        internal BaseTests(ITestOutputHelper outputHelper)
        {
            var testMember = outputHelper.GetType().GetField("test", BindingFlags.Instance | BindingFlags.NonPublic);
            Test = (ITest)testMember.GetValue(outputHelper);

            InitReport();

            WebDriver = InitWebDriver("appsettings.json");
            _output = outputHelper;

        }

        public void InitReport()
        {
            TestResultsDir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "TestResults");

            if (!Directory.Exists(TestResultsDir))
            {
                Directory.CreateDirectory(TestResultsDir);
            }

            Report = Path.Combine(TestResultsDir, $"{Test.TestCase.TestMethod.Method.Name}_{DateTime.Now:ddMMyyyyThhmmss}.html");

            using (StreamWriter sw = new StreamWriter(Report, true))
            {
                sw.WriteLine($"<hr/><h1 style='color:@OUTCOME'>{Test.TestCase.TestMethod.Method.Name}</h1>");
            }
        }

        public EventFiringWebDriver InitWebDriver(string configFile)
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--ignore-ssl-errors=yes");
            options.AddArgument("--ignore-certificate-errors");

            driver = new ChromeDriver(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Base"), options);
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(60);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);

            driver.Url = configFile.GetJsonToken("URL");

            var webDriver = new EventFiringWebDriver(driver);
            webDriver.ElementClicking += WebDriver_ElementClicking;
            webDriver.FindElementCompleted += WebDriver_FindElementCompleted;
            webDriver.ElementValueChanging += WebDriver_ElementValueChanging;

            return webDriver;
        }

        public void Dispose()
        {
            if (TestStatusResult == true)
            {
                File.WriteAllText(Report, File.ReadAllText(Report).Replace("@OUTCOME", "green"));
            }
            else
            {
                File.WriteAllText(Report, File.ReadAllText(Report).Replace("@OUTCOME", "red"));
            }

            try { using (StreamWriter sw = new StreamWriter(Report, true)) { sw.WriteLine($"<center><hr/><h4>Última Tela Apresentada</h4><img style='width:50%;height:50%;' src='data:image/png; base64, {WebDriver.GetScreenshot().AsBase64EncodedString}'/></center><hr/>"); } } catch { }

            try { driver.Quit(); } catch { }

            try { WebDriver.Quit(); } catch { }


            _output.WriteLine($"Result Teste: {Report}");

        }

        #region Events

        private void WebDriver_ElementValueChanging(object sender, WebElementValueEventArgs e)
        {
            using (StreamWriter sw = new StreamWriter(Report, true))
            {
                sw.WriteLine($"<center><h4>SendKeys: {e.Value} | Element: {e.Element.TagName} {e.Element.Text} </center></h4>");
            }
        }

        private void WebDriver_FindElementCompleted(object sender, FindElementEventArgs e)
        {
            using (StreamWriter sw = new StreamWriter(Report, true))
            {
                sw.WriteLine($"<center><hr/><h4>Elemento encontrado pelo identifcador: {e.FindMethod}</h4>");
                sw.WriteLine($"<img style='width:50%;height:50%;' src='data:image/png; base64, {WebDriver.GetScreenshot().AsBase64EncodedString}'/></center>");
            }
        }

        private void WebDriver_ElementClicking(object sender, WebElementEventArgs e)
        {
            using (StreamWriter sw = new StreamWriter(Report, true))
            {
                sw.WriteLine($"<center><h4>Click | Element: {e.Element.TagName} {e.Element.Text}</h4></center>");
            }
        }

        #endregion

    }
}
