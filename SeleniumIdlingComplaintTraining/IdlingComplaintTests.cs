using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SeleniumIdlingComplaintTraining

	/*
	 * FindElement(By locator): Returns a Single Element 
	 * FindElements(By locator): Returns a list of elements
	 */
{
	internal class IdlingComplaintTests
	{
		[Test]
		public void LogInTest()
		{
			var driver = new ChromeDriver();
			driver.Manage().Window.Size = new Size(1920, 1200); //Sets the Window Size
			driver.Navigate().GoToUrl("https://nycidling-dev.azurewebsites.net" +
				"/login"); //Directs Selenium to go to the Idling Complaints Website
			driver.FindElement(By.Id("mat-input-0")).SendKeys("kchen@dep.nyc.gov"); //username
			driver.FindElement(By.Id("mat-input-1")).SendKeys("T3sting@1234"); //password
			driver.FindElement(By.TagName("button")).Click(); // Click on Login Button
			driver.Quit();
		}
	}
}

