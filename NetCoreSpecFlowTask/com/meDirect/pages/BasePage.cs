using NetCoreSpecFlowTask.com.meDirect.toolbox;
using SeleniumExtras.PageObjects;

namespace NetCoreSpecFlowTask.com.meDirect.pages
{
    public abstract class BasePage
    {
        protected BasePage()
        {
            PageFactory.InitElements(Driver.getDriver(), this);
        }
        
        // getting Actual Title Of The Page
        public string GetActualTitle()
        {
            return Driver.getDriver().Title;
        }
        
        public string GetActualPageUrl()
        {
            return Driver.getDriver().Url;
        }
        

    }
}