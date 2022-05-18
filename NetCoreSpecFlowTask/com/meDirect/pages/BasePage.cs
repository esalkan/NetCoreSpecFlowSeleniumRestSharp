using NetCoreSpecFlowTask.com.meDirect.toolbox;
using SeleniumExtras.PageObjects;

namespace NetCoreSpecFlowTask.com.meDirect.pages
{
    public abstract class BasePage
    {
        public BasePage()
        {
            PageFactory.InitElements(Driver.getDriver(), this);
        }
        
        // getting Actual Title Of The Page
        public string getActualTitle()
        {
            return Driver.getDriver().Title;
        }
    }
}