using NetCoreSpecFlowTask.com.meDirect.toolbox;
using SeleniumExtras.PageObjects;

namespace NetCoreSpecFlowTask.com.meDirect.pages
{
    // Page Object
    public abstract class BasePage
    {
        // This is the base page class that all other pages will inherit from.
        protected BasePage() // This is the constructor for the base page class.
        {
            PageFactory.InitElements(Driver.getDriver(), this); // This initializes the elements of the page.
        }
        
        // Getting Actual Page Title from the page.
        public string GetActualTitle()
        {
            return Driver.getDriver().Title;
        }
        
        // Getting Actual Page Url from the page.
        public string GetActualPageUrl()
        {
            return Driver.getDriver().Url;
        }
        

    }
}