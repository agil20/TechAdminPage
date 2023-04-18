using System;
using System.Collections.Generic;

namespace WebApplication.Models
{
    public partial class Mms
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int CallResult { get; set; }
        public string NoAnswerNote { get; set; }
        public int IsOrderChecked { get; set; }
        public int ClientFeedback { get; set; }
        public byte OperatorAssessmentScore { get; set; }
        public string OperatorNote { get; set; }
        public int ServiceScore { get; set; }
        public bool LateDeliveryService { get; set; }
        public bool AttitudeService { get; set; }
        public string ServiceNote { get; set; }
        public byte QualityControlAssessmentScore { get; set; }
        public string QualityControlAssessmentComments { get; set; }
        public string QualityControlAssessmentNote { get; set; }
        public string AdditionalNote { get; set; }
        public int CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual Users CreatedByNavigation { get; set; }
        public virtual Users ModifiedByNavigation { get; set; }
        public virtual Orders Order { get; set; }
    }
}
