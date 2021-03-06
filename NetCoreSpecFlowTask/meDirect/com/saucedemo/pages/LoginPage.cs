using NetCoreSpecFlowTask.meDirect.com.saucedemo.toolbox;
using OpenQA.Selenium;
/*
 * @author esalkan
 * @vcard https://esalkan.com
 * @project MeDirect - Skill Assessment
 * @type Web & Api Automation 
 * @repo https://github.com/esalkan/AutomationNetCoreSpecFlowSelenium.git
 */
namespace NetCoreSpecFlowTask.meDirect.com.saucedemo.pages
{
    // This class is used to define the elements on the page
    public class LoginPage : BasePage
    {
        // WebElements are defined here and used in the methods below
        public IWebElement inputUserName => Driver.getDriver().FindElement(By.XPath("//input[@id='user-name']"));
        public IWebElement inputPassword => Driver.getDriver().FindElement(By.XPath("//input[@id='password']"));
        public IWebElement loginButton => Driver.getDriver().FindElement(By.XPath("//input[@id='login-button']"));
        public IWebElement wrongCredentialsErrorMessage => Driver.getDriver().FindElement(By.XPath("//*[@data-test='error']"));
        
        // Filling the login form with given data
        public void Login(string userName, string userPassword)
        {
            inputUserName.SendKeys(userName);
            inputPassword.SendKeys(userPassword);
        } 
        
        // Clicking on the login button
        public void ClickOnLoginBtn()
        {
            loginButton.Click(); // Click on login button
        }
        
        // Getting the error message text
        public string GetWrongCredentialErrorMessage()
        {
            return wrongCredentialsErrorMessage.Text;
        }
    }
}