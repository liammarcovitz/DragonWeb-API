using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

public class Chrome
{
    private string driverPath;
    private WebOptions options;
    private ChromeDriver driver;
    public Chrome(string DriverPath)
    {
        driverPath = DriverPath;
    }

    public void Open(WebOptions Options, string port = "9014")
    {
        options = Options;
        string command = "/C" + "chrome.exe -remote-debugging-port=" + port + " --user-data-dir=\"C:\\Selenium\\Chrome_Test_Profile\"";
        System.Diagnostics.Process.Start("CMD.exe", command);
        driver = new ChromeDriver(driverPath, options.GetOptions());
    }

    public void SetURL(string URL)
    {
        driver.Url = URL;
    }

    public ChromeDriver GetDriver()
    {
        return driver;
    }

    public void Quit()
    {
        driver.Quit();
    }

    public WebOptions GetWebOptions()
    {
        return options;
    }
}