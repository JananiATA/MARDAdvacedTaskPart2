using SpecFlowProject1.Pages.Components.HomePageComponents;
using SpecFlowProject1.Pages.Components.HomePageComponents.NavigationMenuComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject1.Steps
{

    public class ManageListingSteps
    {
        ManageListingComponent manageListingComponent;
        SearchSkillComponent searchSkillComponent;

        public ManageListingSteps()
        {
            manageListingComponent = new ManageListingComponent();
            searchSkillComponent = new SearchSkillComponent();
        }


        public void GoToManageListing()
        {
            manageListingComponent.ClickManageListings();

        }

        public void AddNewListingSteps(string addTitle, string addDesc, string addCategory, string addSubCategory,
            string addTag, string addServiceType, string addLocationType, string addStartDate, string addEndDate, string addSkillTrade,
            string addSkillExchange, string addAmount, string addActiveStatus)
        {
            GoToManageListing();
            manageListingComponent.AddListing(addTitle, addDesc, addCategory, addSubCategory,
            addTag, addServiceType, addLocationType, addStartDate, addEndDate, addSkillTrade,
            addSkillExchange, addAmount, addActiveStatus);

        }

        public void UpdateNewListingSteps(string addTitle, string addDesc, string addCategory, string addSubCategory,
           string addTag, string addServiceType, string addLocationType, string addStartDate, string addEndDate, string addSkillTrade,
           string addSkillExchange, string addAmount, string addActiveStatus)
        {
            
            manageListingComponent.UpdateListing(addTitle, addDesc, addCategory, addSubCategory,
            addTag, addServiceType, addLocationType, addStartDate, addEndDate, addSkillTrade,
            addSkillExchange, addAmount, addActiveStatus);

        }
        public void ViewAddedListing()
        {
            manageListingComponent.ViewListing();
        }

        public void DeleteAddedListing()
        {
            manageListingComponent.DeleteListing();
        }

        public void EnableAddedListingToggle()
        {
            manageListingComponent.ClickToggle();
        }

        public void DisableAddedListingToggle()
        {
            manageListingComponent.ClickToggle();
        }

        public void RequestSkillTrade(string category, string subCategory, string message)
        {
            searchSkillComponent.SendRequest(category,subCategory,message);
        }
    }
}

