using NetCoreSpecFlowTask.com.meDirect.toolbox;
using OpenQA.Selenium;

namespace NetCoreSpecFlowTask.com.meDirect.pages
{
    public class LoginPage : BasePage
    {
        /*
        public IWebDriver WebDriver { get; }

        public LoginPage(IWebDriver webDriver)
        {
            WebDriver = webDriver;
        }
        */
        
        // UI Web Elements Locators
        public IWebElement inputUserName => Driver.getDriver().FindElement(By.XPath("//input[@id='user-name']"));
        public IWebElement inputPassword => Driver.getDriver().FindElement(By.XPath("//input[@id='password']"));
        public IWebElement loginButton => Driver.getDriver().FindElement(By.XPath("//input[@id='login-button']"));
        public IWebElement wrongCredentialsErrorMessage => Driver.getDriver().FindElement(By.XPath("//h3[@data-test='error']"));
        
        // Filling the login form with given data
        public void Login(string userName, string userPassword)
        {
            inputUserName.SendKeys(userName);
            inputPassword.SendKeys(userPassword);
        } 
        
        // Login button
        public void ClickOnLoginBtn()
        {
            loginButton.Click();
        }

        public string GetWrongCredentialErrorMessage()
        {
            return wrongCredentialsErrorMessage.Text;
        }
    }
}