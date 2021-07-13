using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

class Selection
{
    private SelectElement element;

    public Selection(Element Element)
    {
        element = new SelectElement(Element.GetWebElement());
    }

    public IList<IWebElement> GetAllSelectedOptions()
    {
        return element.AllSelectedOptions;
    }

    public void DeselectAll()
    {
        element.DeselectAll();
    }

    public void DeselectByIndex(int index)
    {
        element.DeselectByIndex(index);
    }

    public void DeselectByText(string text)
    {
        element.DeselectByText(text);
    }

    public void DeselectByValue(string value)
    {
        element.DeselectByValue(value);
    }

    public bool isMultipleSelections()
    {
        return element.IsMultiple;
    }

    public IList<IWebElement> GetOptions()
    {
        return element.Options;
    }

    public IWebElement GetSelectedOption()
    {
        return element.SelectedOption;
    }

    public IWebElement GetWarpedElement()
    {
        return element.WrappedElement;
    }

    public void SelectByText(string text)
    {
        element.SelectByText(text);
    }

    public void SelectByValue(string value)
    {
        element.SelectByValue(value);
    }

    public void SelectByIndex(int index)
    {
        element.SelectByIndex(index);
    }

}