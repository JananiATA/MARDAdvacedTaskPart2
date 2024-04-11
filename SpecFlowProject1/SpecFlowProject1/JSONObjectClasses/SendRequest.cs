using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject1.JSONObjectClasses
{
    public class SendRequest
    {
        public string Category { get; set; } = string.Empty;
        public string SubCategory { get; set; } = string.Empty;
        public string Message { get; set; } = string.Empty;
        public string PopUpMessage { get; set; } = string.Empty;

    }
}
