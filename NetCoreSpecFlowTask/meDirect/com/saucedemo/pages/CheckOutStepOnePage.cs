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
    public class CheckOutStepOnePage
    {
        public IWebElement inputFirstName => 
            Driver.getDriver().FindElement(By.XPath("//input[@id='first-name']"));
        
        public IWebElement inputLastName => 
            Driver.getDriver().FindElement(By.XPath("//input[@id='last-name']"));
        
        public IWebElement inputPostCode => 
            Driver.getDriver().FindElement(By.XPath("//input[@id='postal-code']"));
        
        public IWebElement continueButton => 
            Driver.getDriver().FindElement(By.XPath("//input[@data-test='continue']")); 
        
        public IWebElement cancelButton => 
            Driver.getDriver().FindElement(By.XPath("//input[@data-test='cancel']"));

        public IWebElement errorMessage => 
            Driver.getDriver().FindElement(By.XPath("//h3[@data-test='error']"));
        
        public void fillInformationForm(string firstName, string lastName, string postCode)
        {
            inputFirstName.SendKeys(firstName);
            inputLastName.SendKeys(lastName);
            inputPostCode.SendKeys(postCode);
        }
    }
}