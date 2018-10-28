using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace Selenium_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //@karakusnavy

            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.google.com"); // this is navigation.
            driver.FindElement(By.XPath("//*[@id='lst-ib']")).SendKeys("Simple Text");// this is send to text on search
            driver.FindElement(By.XPath("//*[@id='lst-ib']")).SendKeys(OpenQA.Selenium.Keys.Enter);//enter

            // Click To Button Code
            // driver.FindElement(By.Id("Simple_ID-Xpath-class-text....")).Click();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
