namespace WebApplication.ViewModels
{
    public class OrderStatusReportViewModel
    {
        public int OperatorId { get; set; }
        public string OperatorName { get; set; }
        public int OrderHasBeenTaken { get; set; }
        public int TakeSelf { get; set; }
        public int WasInterested { get; set; }
        public int Reject { get; set; }
        public int ReturnBack { get; set; }
    }
}
