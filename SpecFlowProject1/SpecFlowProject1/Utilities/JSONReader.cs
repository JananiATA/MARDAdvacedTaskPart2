using MarsSpecFlowProject.JSONObjectClasses;
using Newtonsoft.Json;
using SpecFlowProject1.JSONObjectClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject1.Utilities
{
    public class JSONReader
    {
        private readonly string _sampleJsonFilePath;
        public JSONReader(string sampleJsonFilePath)
        {
            _sampleJsonFilePath = sampleJsonFilePath;
        }

        public List<Login> ReadLoginFile()
        {
            using StreamReader reader = new(_sampleJsonFilePath);
            var json = reader.ReadToEnd();
            List<Login> list = JsonConvert.DeserializeObject<List<Login>>(json);
            return list;

        }

        public List<AddEducation> ReadAddEducationFile()
        {
            using StreamReader reader = new(_sampleJsonFilePath);
            var json = reader.ReadToEnd();
            List<AddEducation> list = JsonConvert.DeserializeObject<List<AddEducation>>(json);
            return list;

        }

        public List<AddInvalidEducation> ReadAddInvalidEducationFile()
        {
            using StreamReader reader = new(_sampleJsonFilePath);
            var json = reader.ReadToEnd();
            List<AddInvalidEducation> list = JsonConvert.DeserializeObject<List<AddInvalidEducation>>(json);
            return list;

        }

        public List<AddExistingEducation> ReadAddExistingEducationFile()
        {
            using StreamReader reader = new(_sampleJsonFilePath);
            var json = reader.ReadToEnd();
            List<AddExistingEducation> list = JsonConvert.DeserializeObject<List<AddExistingEducation>>(json);
            return list;

        }

        public List<DeleteEducation> ReadDeleteEducationFile()
        {
            using StreamReader reader = new(_sampleJsonFilePath);
            var json = reader.ReadToEnd();
            List<DeleteEducation> list = JsonConvert.DeserializeObject<List<DeleteEducation>>(json);
            return list;

        }

        public List<Password> ReadChangePasswordFile()
        {
            using StreamReader reader = new(_sampleJsonFilePath);
            var json = reader.ReadToEnd();
            List<Password> list = JsonConvert.DeserializeObject<List<Password>>(json);
            return list;

        }

        public List<AddListing> ReadAddListingFile()
        {
            using StreamReader reader = new(_sampleJsonFilePath);
            var json = reader.ReadToEnd();
            List<AddListing> list = JsonConvert.DeserializeObject<List<AddListing>>(json);
            return list;

        }

        public List<UpdateListing> ReadUpdateListingFile()
        {
            using StreamReader reader = new(_sampleJsonFilePath);
            var json = reader.ReadToEnd();
            List<UpdateListing> list = JsonConvert.DeserializeObject<List<UpdateListing>>(json);
            return list;

        }

        public List<ViewListing> ReadViewListingFile()
        {
            using StreamReader reader = new(_sampleJsonFilePath);
            var json = reader.ReadToEnd();
            List<ViewListing> list = JsonConvert.DeserializeObject<List<ViewListing>>(json);
            return list;

        }

        public List<DeleteListing> ReadDeleteListingFile()
        {
            using StreamReader reader = new(_sampleJsonFilePath);
            var json = reader.ReadToEnd();
            List<DeleteListing> list = JsonConvert.DeserializeObject<List<DeleteListing>>(json);
            return list;

        }

        public List<ToggleEnable> ReadToggleEnableListingFile()
        {
            using StreamReader reader = new(_sampleJsonFilePath);
            var json = reader.ReadToEnd();
            List<ToggleEnable> list = JsonConvert.DeserializeObject<List<ToggleEnable>>(json);
            return list;

        }

        public List<ToggleDisable> ReadToggleDisableListingFile()
        {
            using StreamReader reader = new(_sampleJsonFilePath);
            var json = reader.ReadToEnd();
            List<ToggleDisable> list = JsonConvert.DeserializeObject<List<ToggleDisable>>(json);
            return list;

        }

        public List<SendRequest> ReadSendRequestListingFile()
        {
            using StreamReader reader = new(_sampleJsonFilePath);
            var json = reader.ReadToEnd();
            List<SendRequest> list = JsonConvert.DeserializeObject<List<SendRequest>>(json);
            return list;

        }

        public List<AcceptRequest> ReadAcceptRequestFile()
        {
            using StreamReader reader = new(_sampleJsonFilePath);
            var json = reader.ReadToEnd();
            List<AcceptRequest> list = JsonConvert.DeserializeObject<List<AcceptRequest>>(json);
            return list;

        }

        public List<DeclineRequest> ReadDeclineRequestFile()
        {
            using StreamReader reader = new(_sampleJsonFilePath);
            var json = reader.ReadToEnd();
            List<DeclineRequest> list = JsonConvert.DeserializeObject<List<DeclineRequest>>(json);
            return list;

        }

        public List<CompleteRequest> ReadCompleteRequestFile()
        {
            using StreamReader reader = new(_sampleJsonFilePath);
            var json = reader.ReadToEnd();
            List<CompleteRequest> list = JsonConvert.DeserializeObject<List<CompleteRequest>>(json);
            return list;

        }

        public List<WithdrawRequest> ReadWithdrawRequestFile()
        {
            using StreamReader reader = new(_sampleJsonFilePath);
            var json = reader.ReadToEnd();
            List<WithdrawRequest> list = JsonConvert.DeserializeObject<List<WithdrawRequest>>(json);
            return list;

        }
    }
}
