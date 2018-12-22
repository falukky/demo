using EnvironmentsManager.classes.enums;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using Syroot.Windows.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnvironmentsManager.classes.selenium
{
    public class Browser
    {
        private static IWebDriver _driver;
        public static IWebDriver Driver
        {
            get
            {
                if (_driver == null)
                    throw new NullReferenceException("The WebDriver browser instance was not initialized. You should first call the method Start.");
                return _driver;
            }

            private set
            {
                _driver = value;
            }
        }

        private static WebDriverWait _webDriverWait30Seconds;
        public static WebDriverWait WebDriverWait30Seconds
        {
            get
            {
                if (_webDriverWait30Seconds == null || _driver == null)
                    throw new NullReferenceException("The WebDriver 'Driver' wait instance was not initialized. You should first call the method StartBrowser.");
                return _webDriverWait30Seconds;
            }

            private set
            {
                _webDriverWait30Seconds = value;
            }
        }

        private static WebDriverWait _webDriverWait60Seconds;
        public static WebDriverWait WebDriverWait60Seconds
        {
            get
            {
                if (_webDriverWait60Seconds == null || _driver == null)
                    throw new NullReferenceException("The WebDriver 'Driver' wait instance was not initialized. You should first call the method StartBrowser.");
                return _webDriverWait60Seconds;
            }

            private set
            {
                _webDriverWait60Seconds = value;
            }
        }

        private static WebDriverWait _webDriverWait120Seconds;
        public static WebDriverWait WebDriverWait120Seconds
        {
            get
            {
                if (_webDriverWait120Seconds == null || _driver == null)
                    throw new NullReferenceException("The WebDriver 'Driver' wait instance was not initialized. You should first call the method StartBrowser.");
                return _webDriverWait120Seconds;
            }

            private set
            {
                _webDriverWait120Seconds = value;
            }

        }

        private static IJavaScriptExecutor _javaScriptExecutor;
        public static IJavaScriptExecutor JavaScriptExecutor
        {
            get
            {
                if (_javaScriptExecutor == null || _driver == null)
                    throw new NullReferenceException("The WebDriver 'JavaScriptExecutor' instance was not initialized. You should first call the method StartBrowser.");
                return _javaScriptExecutor;
            }
        }

        private static Actions _actions;
        public static Actions Actions
        {
            get
            {
                if (_actions == null || _driver == null)
                    throw new NullReferenceException("The WebDriver 'Actions' instance was not initialized. You should first call the method StartBrowser.");
                return _actions;
            }
        }

        private static BrowserType _browserType;
        public static BrowserType BrowserType
        {
            get
            {
                return _browserType;
            }
        }

        private static ITakesScreenshot _screenshot;
        public static ITakesScreenshot Screenshot
        {
            get
            {
                if (_screenshot == null || _driver == null)
                    throw new NullReferenceException("The WebDriver 'Screenshot' instance was not initialized. You should first call the method StartBrowser.");
                return _screenshot;
            }
        }

        public static void StartBrowser(BrowserType browserType)
        {
            _browserType = browserType;
            switch (_browserType)
            {
                #region chrome
                case BrowserType.Chrome:
                    ChromeOptions chromeOptions = new ChromeOptions();
                    chromeOptions.AddArguments("--disable-notifications");
                    chromeOptions.AddArguments("--disable-infobars");
                    chromeOptions.AddArguments("--disable-extensions");
                    chromeOptions.AddArguments("--profile-directory=Default");
                    //chromeOptions.AddArguments("--incognito");
                    chromeOptions.AddArguments("--disable-plugins-discovery");
                    chromeOptions.AddArguments("--start-maximized");
                    //chromeOptions.AddArgument("headless");

                    ChromeDriverService chromeDriverService = ChromeDriverService.CreateDefaultService();
                    chromeDriverService.HideCommandPromptWindow = true;

                    Driver = new ChromeDriver(chromeDriverService, chromeOptions);
                    break;
                #endregion

                #region firefix
                case BrowserType.Firefix:
                    FirefoxProfile firefoxProfile = new FirefoxProfile();
                    firefoxProfile.SetPreference("browser.tabs.loadInBackground", false);
                    firefoxProfile.SetPreference("browser.download.folderList", 2);
                    firefoxProfile.SetPreference("browser.download.dir", KnownFolders.Downloads.Path);
                    firefoxProfile.SetPreference("browser.download.manager.alertOnEXEOpen", false);
                    firefoxProfile.SetPreference("browser.helperApps.neverAsk.saveToDisk", "application/msword, application/csv, application/ris, text/csv, image/png, application/pdf, text/html, text/plain, application/zip, application/x-zip, application/x-zip-compressed, application/download, application/octet-stream");
                    firefoxProfile.SetPreference("browser.download.manager.focusWhenStarting", false);
                    firefoxProfile.SetPreference("browser.download.useDownloadDir", true);
                    firefoxProfile.SetPreference("browser.helperApps.alwaysAsk.force", false);
                    firefoxProfile.SetPreference("browser.download.manager.alertOnEXEOpen", false);
                    firefoxProfile.SetPreference("browser.download.manager.closeWhenDone", true);
                    firefoxProfile.SetPreference("browser.download.manager.showAlertOnComplete", false);
                    firefoxProfile.SetPreference("browser.download.manager.useWindow", false);
                    firefoxProfile.SetPreference("services.sync.prefs.sync.browser.download.manager.showWhenStarting", false);
                    firefoxProfile.SetPreference("pdfjs.disabled", true);

                    FirefoxOptions firefoxOptions = new FirefoxOptions();
                    firefoxOptions.Profile = firefoxProfile;
                    Driver = new FirefoxDriver(firefoxOptions);
                    break;
                #endregion

                #region default
                default:
                    break;
                    #endregion
            }

            Driver.Manage().Window.Maximize();
            _webDriverWait30Seconds = new WebDriverWait(_driver, TimeSpan.FromSeconds(30));
            _webDriverWait60Seconds = new WebDriverWait(_driver, TimeSpan.FromSeconds(60));
            _webDriverWait120Seconds = new WebDriverWait(_driver, TimeSpan.FromSeconds(120));
            _javaScriptExecutor = (IJavaScriptExecutor)_driver;
            _actions = new Actions(_driver);
            _screenshot = ((ITakesScreenshot)Driver);
        }

        public static void StopBrowser()
        {
            _driver.Quit();
            _driver = null;
            _webDriverWait30Seconds = null;
            _webDriverWait60Seconds = null;
            _webDriverWait120Seconds = null;
            _javaScriptExecutor = null;
            _actions = null;
            _screenshot = null;
        }

        public static void Refresh()
        {
            Driver.Navigate().Refresh();
        }

        public static void CaptureScreeshot()
        {
            Screenshot screenshot = Screenshot.GetScreenshot();
            screenshot.SaveAsFile(@"", ScreenshotImageFormat.Png);
        }
    }
}
