using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

public class WebOptions
{
    private ChromeOptions options;
    private ChromeDriver driver;
    public WebOptions(Chrome chrome)
    {
        driver = chrome.GetDriver();
        options = new ChromeOptions();
        options.DebuggerAddress = "localhost:9014";
    }

    public ChromeOptions GetOptions()
    {
        return options;
    }

    public void AddArgument(string argument)
    {
        options.AddArgument(argument);
    }

    public void AddArguments(params string[] arguments)
    {
        options.AddArguments(arguments);
    }

    public void AddAdditionalCapacity(string capabilityName, object capabilityValue)
    {
        options.AddAdditionalCapability(capabilityName, capabilityValue);
    }

    public void AddEncodedExtension(string extension)
    {
        options.AddEncodedExtension(extension);
    }

    public void AddEncodedExtensions(params string[] extensions)
    {
        options.AddEncodedExtensions(extensions);
    }

    public void AddExcludedArgument(string argument)
    {
        options.AddExcludedArgument(argument);
    }

    public void AddExcludedArguments(params string[] arguments)
    {
        options.AddExcludedArguments(arguments);
    }

    public void AddExtension(string pathToExtension)
    {
        options.AddExtension(pathToExtension);
    }

    public void AddExtensions(params string[] pathsToExtensions)
    {
        options.AddExtensions(pathsToExtensions);
    }

    public void AddLocalStatePreference(string preferenceName, object preferenceValue)
    {
        options.AddLocalStatePreference(preferenceName, preferenceValue);
    }

    public void AddUserProfilePreference(string preferenceName, object preferenceValue)
    {
        options.AddUserProfilePreference(preferenceName, preferenceValue);
    }

    public void AddWindowType(string windowType)
    {
        options.AddWindowType(windowType);
    }

    public void AddWindowTypes(params string[] windowTypes)
    {
        options.AddWindowTypes(windowTypes);
    }
    
    public string GetBrowserName()
    {
        return options.BrowserName;
    }

    public string GetBrowserVersion()
    {
        return options.BrowserVersion;
    }

    public string GetDebuggerAddress()
    {
        return options.DebuggerAddress;
    }
}
