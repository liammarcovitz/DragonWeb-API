using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

class Element
{
    private Chrome chrome;
    private IWebElement element;

    public Element(string xpath, Chrome Chrome)
    {
        chrome = Chrome;
        element = chrome.GetDriver().FindElement(By.XPath(xpath));
    }

    public void Click()
    {
        element.Click();
    }

    public void Clear()
    {
        element.Clear();
    }

    public void Type(string keys)
    {
        element.SendKeys(keys);
    }

    public bool isEnabled()
    {
        return element.Enabled;
    }

    public bool isDisplayed()
    {
        return element.Displayed;
    }

    public System.Drawing.Point GetLocation()
    {
        return element.Location;
    }

    new public System.Type GetType()
    {
        return element.GetType();
    }

    public string GetText()
    {
        return element.Text;
    }

    public string GetAttribute(string attributeName)
    {
        return element.GetAttribute(attributeName);
    }

    public string GetCSSValue(string value)
    {
        return element.GetCssValue(value);
    }

    new public int GetHashCode()
    {
        return element.GetHashCode();
    }

    public string GetProperty(string propertyName)
    {
        return element.GetProperty(propertyName);
    }

    public bool isSelected()
    {
        return element.Selected;
    }

    public System.Drawing.Size GetSize()
    {
        return element.Size;
    }

    public void Submit()
    {
        element.Submit();
    }

    public string GetTagName()
    {
        return element.TagName;
    }

    public IWebElement GetWebElement()
    {
        return element;
    }
}