using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;

namespace WindowsCalculatorStandart.App
{
    public class CalculatorApp
    {
        private const string AppiumServUri = "http://127.0.0.1:4723/wd/hub";
        private const string WindowsCalcPath = "Microsoft.WindowsCalculator_8wekyb3d8bbwe!App";
        private readonly WindowsDriver<WindowsElement> driver;

        public CalculatorApp()
        {
            AppiumOptions appiumOptions = new AppiumOptions()
            { PlatformName = "Windows" };
            appiumOptions.AddAdditionalCapability("app", WindowsCalcPath);
            this.driver = new WindowsDriver<WindowsElement>(new Uri(AppiumServUri), appiumOptions);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
        }

        public WindowsElement PlusBtn => driver.FindElementByAccessibilityId("plusButton");
        public WindowsElement MinusBtn => driver.FindElementByAccessibilityId("minusButton");
        public WindowsElement MultiplyBtn => driver.FindElementByAccessibilityId("multiplyButton");
        public WindowsElement DivideBtn => driver.FindElementByAccessibilityId("divideButton");
        public WindowsElement EqualBtn => driver.FindElementByAccessibilityId("equalButton");
        public WindowsElement Num0Btn => driver.FindElementByAccessibilityId("num0Button");
        public WindowsElement Num1Btn => driver.FindElementByAccessibilityId("num1Button");
        public WindowsElement Num2Btn => driver.FindElementByAccessibilityId("num2Button");
        public WindowsElement Num3Btn => driver.FindElementByAccessibilityId("num3Button");
        public WindowsElement Num4Btn => driver.FindElementByAccessibilityId("num4Button");
        public WindowsElement Num5Btn => driver.FindElementByAccessibilityId("num5Button");
        public WindowsElement Num6Btn => driver.FindElementByAccessibilityId("num6Button");
        public WindowsElement Num7Btn => driver.FindElementByAccessibilityId("num7Button");
        public WindowsElement Num8Btn => driver.FindElementByAccessibilityId("num8Button");
        public WindowsElement Num9Btn => driver.FindElementByAccessibilityId("num9Button");
        public WindowsElement Result => driver.FindElementByAccessibilityId("CalculatorResults");

        public string AdditionOperation(WindowsElement buttonOne, WindowsElement buttonTwo)
        {
            buttonOne.Click();
            this.PlusBtn.Click();
            buttonTwo.Click();
            this.EqualBtn.Click();
            var result = this.Result.Text;
            return result;
        }

        public string SubtractionOperation(WindowsElement buttonOne, WindowsElement buttonTwo)
        {
            buttonOne.Click();
            this.MinusBtn.Click();
            buttonTwo.Click();
            this.EqualBtn.Click();
            var result = this.Result.Text;
            return result;
        }

        public void ShutDownApp()
        {
            driver.CloseApp();
        }

    }
}
