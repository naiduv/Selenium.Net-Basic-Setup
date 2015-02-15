using System.Drawing.Imaging;
using OpenQA.Selenium.Chrome;


namespace Blogger
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialize the Chrome Driver
            using (var driver = new ChromeDriver())
            {
                // Go to the home page
                driver.Navigate().GoToUrl("http://www.gmail.com");

                // Get User Name field, Password field and Login Button
                var userNameField = driver.FindElementById("Email");
                var userPasswordField = driver.FindElementById("Passwd");
                var loginButton = driver.FindElementById("signIn");

                // Type user name and password
                userNameField.SendKeys("admin");
                userPasswordField.SendKeys("12345");

                // and click the login button
                loginButton.Click();

                ReadKey();                
            }
        }
    }
   
}