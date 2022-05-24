using System.Collections.Generic;
using OpenQA.Selenium;
/*
 * @author esalkan
 * @vcard https://esalkan.com
 * @project MeDirect - Skill Assessment
 * @type Web & Api Automation 
 * @repo https://github.com/esalkan/AutomationNetCoreSpecFlowSelenium.git
 */
namespace NetCoreSpecFlowTask.meDirect.com.saucedemo.toolbox
{
    public class BrowserUtilities
    {
        public static List<string> getElementsText(List<IWebElement> list)
        {
            List<string> elemTexts = new List<string>();
            foreach (IWebElement element in list)
            {
                elemTexts.Add(element.Text);
            }
            return elemTexts;
        }
    }
}