using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace NetCoreSpecFlowTask.com.meDirect.toolbox
{
    public class Driver
    {
        // Constructor for driver.
        private Driver() { }

        // for reaching to the IWebDriver from everywhere. It's a singleton.  It's a static variable.
        private static IWebDriver driver;

        // Instance getDriver() method for driver. It's a static method.
        public static IWebDriver getDriver()
        { 
            // Adding condition before driver type selection to avoid null pointer exception.
            if (driver == null)
            {
                var browserType = "chrome";
                // Based on browser selection setup browser driver type. It's a switch case.
                switch (browserType) {
                    // Chrome browser WebDriver setup for Chrome browser.
                    case "chrome":
                        new DriverManager().SetUpDriver(new ChromeConfig());
                        driver = new ChromeDriver(); // Chrome driver initialization.
                        break;
                }
            }
            return driver; // Return driver.
        }
        
        // Instance killDriver() method for driver.
        public static void killDriver() {
            if (driver != null) {
                driver.Close();
                driver = null;
            }
        }
    }
}