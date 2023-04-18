using System;
using System.Collections.Generic;

namespace WebApplication.Models
{
    public partial class ZReport2
    {
        public string FactNo { get; set; }
        public string FullName { get; set; }
        public string PhoneNumber1 { get; set; }
        public string PhoneNumber2 { get; set; }
        public string HomeNumber { get; set; }
        public string ExpeditorName { get; set; }
        public DateTime DeliveryDate { get; set; }
        public string CallResult { get; set; }
        public string NoAnswerNote { get; set; }
        public string OrderChecked { get; set; }
        public string ClientFeedback { get; set; }
        public byte OperatorAssessmentScore { get; set; }
        public string OperatorNote { get; set; }
        public int ServiceScore { get; set; }
        public string LateDeliveryService { get; set; }
        public string ServiceNote { get; set; }
        public byte QualityControlAssessmentScore { get; set; }
        public string QualityControlAssessmentComments { get; set; }
        public string QualityControlAssessmentNote { get; set; }
        public string AdditionalNote { get; set; }
    }
}
