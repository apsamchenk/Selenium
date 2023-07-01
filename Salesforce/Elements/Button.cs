﻿using OpenQA.Selenium;

namespace Salesforce.Elements
{
    public class Button : BaseElement
    {
        public Button(By locator) : base(locator)
        {
        }

        public Button(string value) : base($"//input[@name='{value}']")
        {
        }
    }
}
