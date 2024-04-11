//using MARSNunitAutomation.Utilities;
using OpenQA.Selenium;
using SpecFlowProject1.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject1.Pages
{
    public class SplashPage : CommonDriver
    {
        private IWebElement signInButton;


        public void RenderSignInComponents()
        {
            try
            {
               
                signInButton = driver.FindElement(By.XPath("//*[@class='item']"));
            }

            catch(Exception e)
            {
                Console.WriteLine(e);
            }
           
        }

        public void ClickSignInButton()
        {
         
            RenderSignInComponents();
            signInButton.Click();

        }




    }
}
    

