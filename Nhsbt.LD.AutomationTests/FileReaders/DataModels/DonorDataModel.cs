using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhsbt.LD.AutomationTests.FileReaders
{
    public class DonorDataModel
    {
        public string age { get; set; }
        public string bloodGroup { get; set; }
        public string donorOn_ODR { get; set; }
        public string donorType { get; set; }
        public string ethnicOrigin { get; set; }
        public string girth { get; set; }
        public string hcv { get; set; }
        public string heightInCentimeters { get; set; }
        public string hla_a { get; set; }
        public string hla_b { get; set; }
        public string hla_dr { get; set; }
        public string hospital { get; set; }
        public string rhesus { get; set; }
        public string sex { get; set; }
        public string sn_Od { get; set; }
        public string sn_odForConsentAuthorisation { get; set; }
        public string weightInKilograms { get; set; }
        public string unitDonorCaredFor { get; set; }
    }
}
