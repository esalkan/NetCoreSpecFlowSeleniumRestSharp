using System;
using System.Collections.Generic;
using OpenQA.Selenium;

namespace NetCoreSpecFlowTask.com.meDirect.toolbox
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