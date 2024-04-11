using NUnit.Framework;
using TechTalk.SpecFlow;

namespace SpecFlowProject1.Utilities
{
    [Binding]
    public sealed class Hooks : CommonDriver
    {
        

        [BeforeScenario]

        public void BeforeScenario()
        {
            Setup();

        }

        [AfterScenario]

        public void AfterScenario()
        {
            QuitDriver();
        }

        [BeforeTestRun]

        public static void CreateExtentReport()
        {

            OneTimeSetup();
            
        }

        [AfterTestRun]

        public static void ExtentClose()
        {
            extent.Flush();
        }

    }

}