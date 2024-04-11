using SpecFlowProject1.Pages.Components.HomePageComponents.ProfileOverviewComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject1.Steps
{
    public class EducationSteps
    {
        Education education;
        public EducationSteps()
        {
            education = new Education();
        }

        public void EducationTab()
        {
            education.GoToEducationTab();
        }
        public void AddEducationRecord(string college, string countryName, string titleName, string degreeName, string year)
        {
            
            education.ResetEducationTable();
            education.AddEducation( college,countryName,titleName, degreeName, year);


        }

        public void AddExistingEducationRecord(string college, string countryName, string titleName, string degreeName, string year)
        {
            education.ResetEducationTable();
            education.AddEducation(college, countryName, titleName, degreeName, year);
            Thread.Sleep(3000);
            education.AddEducation(college, countryName, titleName, degreeName, year);
        }

        public void DeleteEducationRecord(string college, string countryName, string titleName, string degreeName, string year)
        {
            education.ResetEducationTable();
            education.AddEducation(college, countryName, titleName, degreeName, year);
            education.DeleteEducation();

        }

    }
}
