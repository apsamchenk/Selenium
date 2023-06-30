using NUnit.Framework;
using OpenQA.Selenium;

namespace HerokuApp.HerokuAppTests
{
    public class FileUploadTests : BaseTest
    {
        [Test, Category("FileUploadTest"), Description("File upload test")]
        public void FileUpload()
        {
            driver.FindElement(By.LinkText("File Upload")).Click();

            driver.FindElement(By.Id("file-upload")).SendKeys(Environment.CurrentDirectory + "\\HerokuAppTests\\TestData\\HomeWork.docx");

            Assert.That(driver.FindElement(By.Id("file-upload")).GetAttribute("value"), Is.EqualTo("C:\\fakepath\\HomeWork.docx"));
        }
    }
}
